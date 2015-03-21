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
        string nmClasseController;
        string nmClasseModelObject;
        string nmClasseModelAttribute;
        string strTextoClasse;

        public frmGerarClasses()
        {
            InitializeComponent();

            objBanco = csBanco.Instance;
        }

        private void btnCarregaCampos_Click(object sender, EventArgs e)
        {
            dtCamposTabela.Rows.Clear();
            
            objDta = objBanco.RetornaCamposTabela(txtNmTabela.Text);
            objDta.Fill(dtCamposTabela);

            dgvCampos.AutoGenerateColumns = false;
            dgvCampos.DataSource = dtCamposTabela;

            CarregaRetornoFields();
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

        private void CarregaRetornoFields()
        {
            dtRetornoFields.Columns.Add("nmField", typeof(string));
            dtRetornoFields.Columns.Add("deCampo", typeof(string));
            dtRetornoFields.Columns.Add("boVisivel", typeof(string));

            foreach (DataRow dr in dtCamposTabela.Rows)
            {
                DataRow drField = dtRetornoFields.NewRow();

                drField["nmField"] = dr["NomeClasse"].ToString();
                drField["deCampo"] = dr["NomeClasse"].ToString();
                drField["boVisivel"] = 1;

                dtRetornoFields.Rows.Add(drField);
            }

            dgvRetornoFields.DataSource = dtRetornoFields;
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
                        //strTextoClasse = strTextoClasse.Replace("[CampoCalculado]", strCampoCalculado);

                        sw.Write(strTextoClasse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Controller: " + ex.Message);
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
    }
}
