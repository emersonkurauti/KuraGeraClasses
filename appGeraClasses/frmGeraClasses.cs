using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.IO;
using appGeraClasses.Controller;
using appGeraClasses.ModelAttribute;
using appGeraClasses.ModelObject;

namespace appGeraClasses
{
    public partial class frmGerarClasses : Form
    {
        csBanco objBanco;
        OracleDataAdapter objDta = new OracleDataAdapter();
        DataTable dtCamposTabela = new DataTable();
        DataTable dtRetornoFields = new DataTable();
        DataTable dtCampoCalculado = new DataTable();
        DataTable dtTabelasBase = new DataTable();
        string nmClasseController;
        string nmClasseModelObject;
        string nmClasseModelAttribute;
        string strTextoClasse;

        public frmGerarClasses()
        {
            InitializeComponent();

            objBanco = csBanco.Instance;

            //DataTable de Fields
            dtRetornoFields.Columns.Add("nmField", typeof(string));
            dtRetornoFields.Columns.Add("deCampo", typeof(string));
            dtRetornoFields.Columns.Add("boVisivel", typeof(string));

            //DataTable de campos calculados
            dtCampoCalculado.Columns.Add("nmCampoCalculado", typeof(string));
            dtCampoCalculado.Columns.Add("nmTabela", typeof(string));
            dtCampoCalculado.Columns.Add("nmChave", typeof(string));
            dtCampoCalculado.Columns.Add("nmCampoRetorno", typeof(string));
        }

        private string RetornaStringConexao()
        {
            return "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " + txtHost.Text +
                   ")(PORT = " + txtPorta.Text +
                   ")) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = " + txtService.Text +
                   "))); User Id=" + txtUsuario.Text + "; Password=" + txtSenha.Text + "";
        }

        private bool ValidaDadosConexao()
        {
            if ((txtHost.Text.Trim() == "") ||
                (txtPorta.Text.Trim() == "") ||
                (txtService.Text.Trim() == "") ||
                (txtUsuario.Text.Trim() == "") ||
                (txtSenha.Text.Trim() == ""))
                return false;

            return true;
        }

        private bool TestaConexao()
        {
            if (ValidaDadosConexao())
            {
                objBanco.strStringConexao = RetornaStringConexao();

                if (objBanco.ConectaBanco())
                {
                    objBanco.DesconectaBanco();
                    return true;
                }
            }

            return false;
        }

        private void btnCarregaCampos_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosConexao())
            {
                MessageBox.Show("Dados inválidos para conexão. Por favor, verifique.");
                return;
            }

            try
            {
                objBanco.strStringConexao = RetornaStringConexao();

                dtCamposTabela.Rows.Clear();

                objDta = objBanco.RetornaCamposTabela(txtNmTabela.Text);
                objDta.Fill(dtCamposTabela);

                if ((dtCamposTabela == null) || (dtCamposTabela.Rows.Count == 0))
                {
                    MessageBox.Show("Tabela não existe ou não possui campos. Por favor, verifique.");
                    return;
                }

                dgvCampos.AutoGenerateColumns = false;
                dgvCampos.DataSource = dtCamposTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar campos da Tabela: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtCamposTabela.Rows.Clear();
        }

        public string Valido()
        {
            string strMensagem = "";
            bool bDePrincipal = false, b2DePrincipal = false;

            foreach (DataRow dr in dtCamposTabela.Rows)
            {
                if (dr["dePrincipal"].ToString() == "S" && bDePrincipal)
                    b2DePrincipal = true;

                if (dr["dePrincipal"].ToString() == "S")
                    bDePrincipal = true;
            }

            if (b2DePrincipal)
                strMensagem = "Deve ser selecionado apenas um campo como Desc. Principal!";
            else
            if (!bDePrincipal)
                strMensagem = "Não foi selecionada a descrição principal!";

            return strMensagem;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string strMensagem = Valido();
            if (strMensagem != "")
            {
                MessageBox.Show(strMensagem);
                return;
            }

            try
            {
                GeraController();
                GeraModelAttribute();
                GeraModelObject();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Falha ao gerar classes: " + Ex.Message);
            }
        }

        private string GeraCampoCalculado()
        {
            string strCampoCalculado = "";

            if (dtCampoCalculado.Rows.Count > 0)
            {
                csModelObject ClasseModelObject = new csModelObject();

                string strSelectCampoCalc = ClasseModelObject.strSelectCampoCalc;
                string strListaControllers = "";
                string strAlteraReadyOnly_Length = "";
                string strFiltrosConsulta = "";
                string strPreparaControllerParaConsulta = "";
                string strExecutaConsulta = "";
                string strTraducaoCampoCalc = "";
                string strTable = "";
                string strTabelaAnterior = dtCampoCalculado.Rows[0]["nmTabela"].ToString();
                string[] strCamposChaves;

                foreach (DataRow dr in dtCampoCalculado.Rows)
                {
                    if (!strListaControllers.Contains(dr["nmTabela"].ToString()))
                        strListaControllers += ClasseModelObject.strListaControllers.Replace("[TableCalc]", dr["nmTabela"].ToString());

                    strAlteraReadyOnly_Length += ClasseModelObject.strAlteraReadyOnly_Length.Replace("[CCAttribute]", dr["nmCampoCalculado"].ToString()).Replace("[Table]", txtNmTabela.Text);

                    if (!strPreparaControllerParaConsulta.Contains(dr["nmTabela"].ToString()) ||
                        !strPreparaControllerParaConsulta.Contains(dr["nmChave"].ToString()) ||
                        !strPreparaControllerParaConsulta.Contains(txtNmTabela.Text))
                        strPreparaControllerParaConsulta += ClasseModelObject.strPreparaControllerParaConsulta.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("[Table]", txtNmTabela.Text);

                    strCamposChaves = dr["nmChave"].ToString().Split(';');

                    foreach (string strCampoChave in strCamposChaves)
                    {
                        strFiltrosConsulta += ClasseModelObject.strFiltrosConsulta.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("[Table]", txtNmTabela.Text).Replace("[CampoChave]", strCampoChave);
                    }

                    strPreparaControllerParaConsulta.Replace("[strFiltrosConsulta]", strFiltrosConsulta);

                    strTraducaoCampoCalc += ClasseModelObject.strTraducaoCampoCalc.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("[CCAttribute]", dr["nmCampoCalculado"].ToString()).Replace("[Table]", txtNmTabela.Text).Replace("[AttributeCalc]", dr["nmCampoRetorno"].ToString());

                    if (strTabelaAnterior != dr["nmTabela"].ToString())
                    {
                        strExecutaConsulta += ClasseModelObject.strExecutaConsulta.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("TraducaoCampoCalc", strTraducaoCampoCalc);
                        strTraducaoCampoCalc = "";
                        strTabelaAnterior = dr["nmTabela"].ToString();
                    }

                    strTable = dr["nmTabela"].ToString();
                }

                strExecutaConsulta += ClasseModelObject.strExecutaConsulta.Replace("[TableCalc]", strTable).Replace("[TraducaoCampoCalc]", strTraducaoCampoCalc);

                strSelectCampoCalc = strSelectCampoCalc.Replace("[ListaControllers]", strListaControllers);
                strSelectCampoCalc = strSelectCampoCalc.Replace("[AlteraReadyOnly_Length]", strAlteraReadyOnly_Length);
                strSelectCampoCalc = strSelectCampoCalc.Replace("[PreparaControllerParaConsulta]", strPreparaControllerParaConsulta);
                strSelectCampoCalc = strSelectCampoCalc.Replace("[ExecutaConsulta]", strExecutaConsulta);

                strCampoCalculado = strSelectCampoCalc;
            }

            return strCampoCalculado;
        }

        private void txtNmTabela_Leave(object sender, EventArgs e)
        {
            nmClasseController = txtCaminho.Text + "\\" + "con" + txtNmTabela.Text + ".cs";
            nmClasseModelObject = txtCaminho.Text + "\\" + "co" + txtNmTabela.Text + ".cs";
            nmClasseModelAttribute = txtCaminho.Text + "\\" + "ca" + txtNmTabela.Text + ".cs";

            btnCarregaCampos_Click(null, null);
        }

        private void GeraController()
        {
            csController ClasseController = new csController();
            try
            {
                using (FileStream fs = File.Create(nmClasseController))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        strTextoClasse = ClasseController.strController;

                        strTextoClasse = strTextoClasse.Replace("[Table]", txtNmTabela.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceModel]", txtNameSpaceModel.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceController]", txtNameSpaceController.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceMensagem]", txtNameSpaceMensagem.Text);

                        sw.Write(strTextoClasse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Controller: " + ex.Message);
            }
        }

        private void GeraModelObject()
        {
            string strAttributes = "";
            string strCampoCalculado = "";
            string strIniVar = "";
            csModelObject ClasseModelObject = new csModelObject();
            try
            {
                using (FileStream fs = File.Create(nmClasseModelObject))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        strTextoClasse = ClasseModelObject.strModelObject;

                        strTextoClasse = strTextoClasse.Replace("[Table]", txtNmTabela.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceObjects]", txtNameSpaceModel.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceController]", txtNameSpaceController.Text);

                        foreach (DataRow dr in dtCamposTabela.Rows)
                        {
                            strIniVar = "";
                            if (dr["TpVariavel"].ToString().ToLower() == "string")
                                strIniVar = " = \"\"";

                            if (dr["CHAVE"].ToString() == "S")
                                strTextoClasse = strTextoClasse.Replace("[PK]", dr["NomeClasse"].ToString());

                            strAttributes += "\n" + ClasseModelObject.strAttribute.Replace("[nmAttribute]", dr["NomeClasse"].ToString()).Replace("[Type]", dr["TpVariavel"].ToString().ToLower()).Replace("[IniVar]", strIniVar);
                        }

                        strTextoClasse = strTextoClasse.Replace("[Attribute]", strAttributes);

                        strCampoCalculado = GeraCampoCalculado();
                        strTextoClasse = strTextoClasse.Replace("[CampoCalculado]", strCampoCalculado);

                        sw.Write(strTextoClasse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Model Object: " + ex.Message);
            }
        }

        private void GeraModelAttribute()
        {
            string strAttributes = "";
            string strChComposta = "";
            string strFields = "";
            string strNameFields = "";
            string strVisibleFields = "";

            csModelAttribute ClasseModelAttribute = new csModelAttribute();
            try
            {
                using (FileStream fs = File.Create(nmClasseModelAttribute))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        strTextoClasse = ClasseModelAttribute.strModelAttribute;

                        strTextoClasse = strTextoClasse.Replace("[Table]", txtNmTabela.Text);
                        strTextoClasse = strTextoClasse.Replace("[Upper|Table]", txtNmTabela.Text.ToUpper());
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceModel]", txtNameSpaceModel.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceController]", txtNameSpaceController.Text);
                        strTextoClasse = strTextoClasse.Replace("[NameSpaceMensagem]", txtNameSpaceMensagem.Text);
                        strTextoClasse = strTextoClasse.Replace("[GeraChave]", cbGeraChave.Checked.ToString().ToLower());
                        strTextoClasse = strTextoClasse.Replace("[ControlaTransacao]", cbControlaTransacao.Checked.ToString().ToLower());

                        foreach (DataRow dr in dtCamposTabela.Rows)
                        {
                            if (dr["CHAVE"].ToString() == "S")
                                strTextoClasse = strTextoClasse.Replace("[PK]", dr["NomeClasse"].ToString());

                            if (dr["dePrincipal"].ToString() == "S")
                                strTextoClasse = strTextoClasse.Replace("[DescPrinc]", dr["NomeClasse"].ToString());

                            if (dr["CHCOMPOSTA"].ToString() == "S")
                                strChComposta += dr["NomeClasse"].ToString() + ";";

                            strAttributes += "\n" + ClasseModelAttribute.strAttribute.Replace("[nmAttribute]", dr["NomeClasse"].ToString());
                        }


                        if (strChComposta != "")
                            strTextoClasse = strTextoClasse.Replace("[ChComposta]", strChComposta.Substring(0, strChComposta.Length - 1));
                        strTextoClasse = strTextoClasse.Replace("[Attribute]", strAttributes);

                        foreach (DataRow dr in dtRetornoFields.Rows)
                        {
                            strFields += dr["nmField"].ToString() + " + \",\" + ";
                            strNameFields += dr["deCampo"].ToString() + ", ";
                            strVisibleFields += dr["boVisivel"].ToString() + ", ";
                        }

                        strTextoClasse = strTextoClasse.Replace("[strFields]", strFields.Substring(0, strFields.Length - 9));
                        strTextoClasse = strTextoClasse.Replace("[strNameFields]", strNameFields.Substring(0, strNameFields.Length - 2));
                        strTextoClasse = strTextoClasse.Replace("[strVisibleFields]", strVisibleFields.Substring(0, strVisibleFields.Length - 2));

                        sw.Write(strTextoClasse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Model Attribute: " + ex.Message);
            }
        }

        private void tcClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtCampoCalculado.Rows.Clear();
            dtRetornoFields.Rows.Clear();

            foreach (DataRow dr in dtCamposTabela.Rows)
            {
                if (dr["NomeClasse"].ToString().Substring(0, 3) == "CC_")
                {
                    DataRow drField = dtCampoCalculado.NewRow();

                    drField["nmCampoCalculado"] = dr["NomeClasse"].ToString();

                    dtCampoCalculado.Rows.Add(drField);
                }

                DataRow drFieldRet = dtRetornoFields.NewRow();

                drFieldRet["nmField"] = dr["NomeClasse"].ToString();
                drFieldRet["deCampo"] = dr["NomeClasse"].ToString();
                drFieldRet["boVisivel"] = 1;

                dtRetornoFields.Rows.Add(drFieldRet);
            }

            dgvCampoCalculado.DataSource = dtCampoCalculado;
            dgvRetornoFields.DataSource = dtRetornoFields;
        }

        private void dgvCampoCalculado_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtCampos = new DataTable();
            string strChave = "";

            try
            {
                if (dgvCampoCalculado.Columns[e.ColumnIndex].DataPropertyName.ToString() == "nmTabela")
                {
                    objDta = objBanco.RetornaCamposTabela(dgvCampoCalculado[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                    objDta.Fill(dtCampos);

                    if (dtCampos.Rows.Count > 0)
                    {

                        foreach (DataRow dr in dtCampos.Rows)
                        {
                            if (dr["CHAVE"].ToString() == "S")
                                strChave += dr["Nome"].ToString().Substring(0, 2).ToLower() +
                                    dr["Nome"].ToString().Substring(2, 1).ToUpper() +
                                    dr["Nome"].ToString().Substring(3, dr["Nome"].ToString().Length - 3).ToLower() + ";";
                        }

                        dtCampoCalculado.Rows[e.RowIndex]["nmTabela"] = dgvCampoCalculado[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                        dtCampoCalculado.Rows[e.RowIndex]["nmChave"] = strChave.Substring(0, strChave.Length - 1);
                        dtCampoCalculado.Rows[e.RowIndex]["nmCampoRetorno"] = dtCampoCalculado.Rows[e.RowIndex]["nmCampoCalculado"].ToString().Substring(3, dtCampoCalculado.Rows[e.RowIndex]["nmCampoCalculado"].ToString().Length - 3);

                        dgvCampoCalculado.DataSource = dtCampoCalculado;
                    }
                    else
                        MessageBox.Show("Nenhum campo chave localizado, verifique o nome da tabela ou a estrutura dela!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chave da Tabela Origem: " + ex.Message);
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TestaConexao())
                    MessageBox.Show("Dados inválidos para conexão. Por favor, Verifique.");
                else
                    MessageBox.Show("Dados OK para conxão!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Falha ao testar conexão: " + Ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TestaConexao())
                    MessageBox.Show("Dados inválidos para conexão. Por favor, Verifique.");
                else
                {
                    dtTabelasBase.Rows.Clear();

                    objDta = objBanco.RetornaTabelasBase();
                    objDta.Fill(dtTabelasBase);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Falha ao tentar conectar: " + Ex.Message);
            }
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fbdCaminhoArquivos.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCaminho.Text = this.fbdCaminhoArquivos.SelectedPath.ToString();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtCaminho.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao abrir pasta: " + Ex.Message);
            }
        }

        private void btnSalvarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TestaConexao())
                    MessageBox.Show("Dados inválidos para conexão. Por favor, Verifique.");
                else
                {
                    objBanco.ExecutarSQL("DELETE FROM GERACLASSESCONFIG");

                    string strCommand = "INSERT INTO GERACLASSESCONFIG VALUES([cdConfig], '[deConfig]', '[deVlConfig]')";

                    objBanco.ExecutarSQL(strCommand.Replace("[cdConfig]", "1").Replace("[deConfig]", "Caminho dos Arquivos").Replace("[deVlConfig]", txtCaminho.Text));
                    objBanco.ExecutarSQL(strCommand.Replace("[cdConfig]", "2").Replace("[deConfig]", "NameSpace Mensagem").Replace("[deVlConfig]", txtNameSpaceMensagem.Text));
                    objBanco.ExecutarSQL(strCommand.Replace("[cdConfig]", "3").Replace("[deConfig]", "NameSpace Controler").Replace("[deVlConfig]", txtNameSpaceController.Text));
                    objBanco.ExecutarSQL(strCommand.Replace("[cdConfig]", "4").Replace("[deConfig]", "NameSpace Model").Replace("[deVlConfig]", txtNameSpaceModel.Text));
                    objBanco.ExecutarSQL("COMMIT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar configurações: " + ex.Message);
            }
        }

        private void brnCarregarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TestaConexao())
                    MessageBox.Show("Dados inválidos para conexão. Por favor, Verifique.");
                else
                {
                    DataTable dt = new DataTable();
                    dt.Rows.Clear();

                    objDta = objBanco.RetornaConfiguracoes();
                    objDta.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["cdConfig"].ToString() == "1")
                            txtCaminho.Text = dr["deVlConfig"].ToString();

                        if (dr["cdConfig"].ToString() == "2")
                            txtNameSpaceMensagem.Text = dr["deVlConfig"].ToString();

                        if (dr["cdConfig"].ToString() == "3")
                            txtNameSpaceController.Text = dr["deVlConfig"].ToString();

                        if (dr["cdConfig"].ToString() == "4")
                            txtNameSpaceModel.Text = dr["deVlConfig"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar configurações: " + ex.Message);
            }
        }

        private void dgvCampos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            tcClasses_SelectedIndexChanged(null, null);
        }
    }
}
