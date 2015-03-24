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

        private void btnCarregaCampos_Click(object sender, EventArgs e)
        {
            dtCamposTabela.Rows.Clear();
            
            objDta = objBanco.RetornaCamposTabela(txtNmTabela.Text);
            objDta.Fill(dtCamposTabela);

            dgvCampos.AutoGenerateColumns = false;
            dgvCampos.DataSource = dtCamposTabela;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtCamposTabela.Rows.Clear();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GeraController();
            GeraModelAttribute();
            GeraModelObject();
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
                string strPreparaControllerParaConsulta = "";
                string strExecutaConsulta = "";

                foreach (DataRow dr in dtCampoCalculado.Rows)
                {
                    strListaControllers += ClasseModelObject.strListaControllers.Replace("[TableCalc]", dr["nmTabela"].ToString());
                    strAlteraReadyOnly_Length += ClasseModelObject.strAlteraReadyOnly_Length.Replace("[CCAttribute]", dr["nmCampoCalculado"].ToString()).Replace("[Table]", txtNmTabela.Text);
                    strPreparaControllerParaConsulta += ClasseModelObject.strPreparaControllerParaConsulta.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("[CampoChave]", dr["nmChave"].ToString()).Replace("[Table]", txtNmTabela.Text);
                    strExecutaConsulta += ClasseModelObject.strExecutaConsulta.Replace("[TableCalc]", dr["nmTabela"].ToString()).Replace("[CCAttribute]", dr["nmCampoCalculado"].ToString()).Replace("[Table]", txtNmTabela.Text).Replace("[AttributeCalc]", dr["nmCampoRetorno"].ToString());
                }

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
            nmClasseController = txtCaminho.Text + "con" + txtNmTabela.Text + ".cs";
            nmClasseModelObject = txtCaminho.Text + "co" + txtNmTabela.Text + ".cs";
            nmClasseModelAttribute = txtCaminho.Text + "ca" + txtNmTabela.Text + ".cs";
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
                            if (dr["CHAVE"].ToString() == "S")
                                strTextoClasse = strTextoClasse.Replace("[PK]", dr["NomeClasse"].ToString());

                            strAttributes += "\n" + ClasseModelObject.strAttribute.Replace("[nmAttribute]", dr["NomeClasse"].ToString()).Replace("[Type]", dr["TpVariavel"].ToString().ToLower());
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
                                strTextoClasse = strTextoClasse.Replace("[PK]", dr["Nome"].ToString());

                            if (dr["dePrincipal"].ToString() == "S")
                                strTextoClasse = strTextoClasse.Replace("[DescPrinc]", dr["Nome"].ToString());

                            if (dr["CHCOMPOSTA"].ToString() == "S")
                                strChComposta += dr["Nome"].ToString() + ";";

                            strAttributes += "\n" + ClasseModelAttribute.strAttribute.Replace("[nmAttribute]", dr["NomeClasse"].ToString());
                        }

                        strTextoClasse = strTextoClasse.Replace("[ChComposta]", strChComposta.Substring(0, strChComposta.Length - 1));
                        strTextoClasse = strTextoClasse.Replace("[Attribute]", strAttributes);

                        foreach (DataRow dr in dtRetornoFields.Rows)
                        {
                            strFields += dr["nmField"].ToString() + " + \";\" + ";
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
                                strChave += dr["Nome"].ToString() + ";";
                        }

                        dtCampoCalculado.Rows[e.RowIndex]["nmTabela"] = dgvCampoCalculado[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                        dtCampoCalculado.Rows[e.RowIndex]["nmChave"] = strChave.Substring(0, strChave.Length - 1);

                        dgvCampoCalculado.DataSource = dtCampoCalculado;
                    }
                    else
                        MessageBox.Show("Nenhum campo chave localizado, verifique o nome da tabela ou a estrutura dela!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Chave da Tabela Origem: " + ex.Message);
            }
        }
    }
}
