namespace appGeraClasses
{
    partial class frmGerarClasses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tcClasses = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.txtNameSpaceMensagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.btnCarregaCampos = new System.Windows.Forms.Button();
            this.txtNmTabela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpController = new System.Windows.Forms.TabPage();
            this.txtNameSpaceController = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.tcModel = new System.Windows.Forms.TabControl();
            this.tpObject = new System.Windows.Forms.TabPage();
            this.tpAttribute = new System.Windows.Forms.TabPage();
            this.txtNameSpaceModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.dePrincipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nmCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpVariavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHAVE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CHCOMPOSTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TpCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRetornoFields = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nmField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boVisivel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCampoCalculado = new System.Windows.Forms.DataGridView();
            this.nmCampoCalculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmTabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmCampoRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcClasses.SuspendLayout();
            this.tpGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.tpController.SuspendLayout();
            this.tpModel.SuspendLayout();
            this.tcModel.SuspendLayout();
            this.tpObject.SuspendLayout();
            this.tpAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetornoFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoCalculado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 457);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Grid";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tcClasses
            // 
            this.tcClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcClasses.Controls.Add(this.tpGeral);
            this.tcClasses.Controls.Add(this.tpController);
            this.tcClasses.Controls.Add(this.tpModel);
            this.tcClasses.Location = new System.Drawing.Point(12, 36);
            this.tcClasses.Name = "tcClasses";
            this.tcClasses.SelectedIndex = 0;
            this.tcClasses.Size = new System.Drawing.Size(822, 415);
            this.tcClasses.TabIndex = 2;
            this.tcClasses.SelectedIndexChanged += new System.EventHandler(this.tcClasses_SelectedIndexChanged);
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.txtNameSpaceMensagem);
            this.tpGeral.Controls.Add(this.label6);
            this.tpGeral.Controls.Add(this.dgvCampos);
            this.tpGeral.Controls.Add(this.btnCarregaCampos);
            this.tpGeral.Controls.Add(this.txtNmTabela);
            this.tpGeral.Controls.Add(this.label1);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(814, 389);
            this.tpGeral.TabIndex = 3;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // txtNameSpaceMensagem
            // 
            this.txtNameSpaceMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSpaceMensagem.Location = new System.Drawing.Point(9, 68);
            this.txtNameSpaceMensagem.Name = "txtNameSpaceMensagem";
            this.txtNameSpaceMensagem.Size = new System.Drawing.Size(718, 20);
            this.txtNameSpaceMensagem.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name Space Menssagem:";
            // 
            // dgvCampos
            // 
            this.dgvCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dePrincipal,
            this.nmCampo,
            this.NomeClasse,
            this.TpVariavel,
            this.CHAVE,
            this.CHCOMPOSTA,
            this.TpCampo});
            this.dgvCampos.Location = new System.Drawing.Point(9, 99);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.Size = new System.Drawing.Size(799, 284);
            this.dgvCampos.TabIndex = 7;
            // 
            // btnCarregaCampos
            // 
            this.btnCarregaCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregaCampos.Location = new System.Drawing.Point(733, 13);
            this.btnCarregaCampos.Name = "btnCarregaCampos";
            this.btnCarregaCampos.Size = new System.Drawing.Size(75, 36);
            this.btnCarregaCampos.TabIndex = 4;
            this.btnCarregaCampos.Text = "Carregar";
            this.btnCarregaCampos.UseVisualStyleBackColor = true;
            this.btnCarregaCampos.Click += new System.EventHandler(this.btnCarregaCampos_Click);
            // 
            // txtNmTabela
            // 
            this.txtNmTabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmTabela.Location = new System.Drawing.Point(9, 29);
            this.txtNmTabela.Name = "txtNmTabela";
            this.txtNmTabela.Size = new System.Drawing.Size(718, 20);
            this.txtNmTabela.TabIndex = 1;
            this.txtNmTabela.Leave += new System.EventHandler(this.txtNmTabela_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabela :";
            // 
            // tpController
            // 
            this.tpController.Controls.Add(this.txtNameSpaceController);
            this.tpController.Controls.Add(this.label4);
            this.tpController.Location = new System.Drawing.Point(4, 22);
            this.tpController.Name = "tpController";
            this.tpController.Padding = new System.Windows.Forms.Padding(3);
            this.tpController.Size = new System.Drawing.Size(814, 389);
            this.tpController.TabIndex = 0;
            this.tpController.Text = "Controller";
            this.tpController.UseVisualStyleBackColor = true;
            // 
            // txtNameSpaceController
            // 
            this.txtNameSpaceController.Location = new System.Drawing.Point(9, 29);
            this.txtNameSpaceController.Name = "txtNameSpaceController";
            this.txtNameSpaceController.Size = new System.Drawing.Size(245, 20);
            this.txtNameSpaceController.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name Space:";
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.tcModel);
            this.tpModel.Controls.Add(this.txtNameSpaceModel);
            this.tpModel.Controls.Add(this.label5);
            this.tpModel.Location = new System.Drawing.Point(4, 22);
            this.tpModel.Name = "tpModel";
            this.tpModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpModel.Size = new System.Drawing.Size(814, 389);
            this.tpModel.TabIndex = 1;
            this.tpModel.Text = "Model";
            this.tpModel.UseVisualStyleBackColor = true;
            // 
            // tcModel
            // 
            this.tcModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcModel.Controls.Add(this.tpAttribute);
            this.tcModel.Controls.Add(this.tpObject);
            this.tcModel.Location = new System.Drawing.Point(9, 55);
            this.tcModel.Name = "tcModel";
            this.tcModel.SelectedIndex = 0;
            this.tcModel.Size = new System.Drawing.Size(799, 328);
            this.tcModel.TabIndex = 4;
            // 
            // tpObject
            // 
            this.tpObject.Controls.Add(this.dgvCampoCalculado);
            this.tpObject.Controls.Add(this.label7);
            this.tpObject.Location = new System.Drawing.Point(4, 22);
            this.tpObject.Name = "tpObject";
            this.tpObject.Padding = new System.Windows.Forms.Padding(3);
            this.tpObject.Size = new System.Drawing.Size(791, 302);
            this.tpObject.TabIndex = 0;
            this.tpObject.Text = "Object";
            this.tpObject.UseVisualStyleBackColor = true;
            // 
            // tpAttribute
            // 
            this.tpAttribute.Controls.Add(this.label3);
            this.tpAttribute.Controls.Add(this.dgvRetornoFields);
            this.tpAttribute.Location = new System.Drawing.Point(4, 22);
            this.tpAttribute.Name = "tpAttribute";
            this.tpAttribute.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttribute.Size = new System.Drawing.Size(791, 302);
            this.tpAttribute.TabIndex = 1;
            this.tpAttribute.Text = "Attribute";
            this.tpAttribute.UseVisualStyleBackColor = true;
            // 
            // txtNameSpaceModel
            // 
            this.txtNameSpaceModel.Location = new System.Drawing.Point(9, 29);
            this.txtNameSpaceModel.Name = "txtNameSpaceModel";
            this.txtNameSpaceModel.Size = new System.Drawing.Size(245, 20);
            this.txtNameSpaceModel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name Space:";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerar.Location = new System.Drawing.Point(93, 457);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caminho :";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(72, 10);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(762, 20);
            this.txtCaminho.TabIndex = 1;
            this.txtCaminho.Text = "C:\\Users\\Emerson\\Desktop\\";
            this.txtCaminho.Leave += new System.EventHandler(this.txtNmTabela_Leave);
            // 
            // dePrincipal
            // 
            this.dePrincipal.DataPropertyName = "dePrincipal";
            this.dePrincipal.FalseValue = "N";
            this.dePrincipal.HeaderText = "Desc. Princ.";
            this.dePrincipal.Name = "dePrincipal";
            this.dePrincipal.TrueValue = "S";
            this.dePrincipal.Width = 75;
            // 
            // nmCampo
            // 
            this.nmCampo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmCampo.DataPropertyName = "Nome";
            this.nmCampo.HeaderText = "Nome Campo Tablea";
            this.nmCampo.Name = "nmCampo";
            this.nmCampo.ReadOnly = true;
            // 
            // NomeClasse
            // 
            this.NomeClasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeClasse.DataPropertyName = "NomeClasse";
            this.NomeClasse.HeaderText = "Nome Campo Classe";
            this.NomeClasse.Name = "NomeClasse";
            // 
            // TpVariavel
            // 
            this.TpVariavel.DataPropertyName = "TpVariavel";
            this.TpVariavel.HeaderText = "Tp. Variavel";
            this.TpVariavel.Name = "TpVariavel";
            this.TpVariavel.Width = 90;
            // 
            // CHAVE
            // 
            this.CHAVE.DataPropertyName = "CHAVE";
            this.CHAVE.FalseValue = "N";
            this.CHAVE.HeaderText = "Chave";
            this.CHAVE.Name = "CHAVE";
            this.CHAVE.ReadOnly = true;
            this.CHAVE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHAVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHAVE.TrueValue = "S";
            this.CHAVE.Width = 50;
            // 
            // CHCOMPOSTA
            // 
            this.CHCOMPOSTA.DataPropertyName = "CHCOMPOSTA";
            this.CHCOMPOSTA.FalseValue = "N";
            this.CHCOMPOSTA.HeaderText = "Ch. Comp.";
            this.CHCOMPOSTA.Name = "CHCOMPOSTA";
            this.CHCOMPOSTA.ReadOnly = true;
            this.CHCOMPOSTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHCOMPOSTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHCOMPOSTA.TrueValue = "S";
            this.CHCOMPOSTA.Width = 85;
            // 
            // TpCampo
            // 
            this.TpCampo.DataPropertyName = "Tipo";
            this.TpCampo.HeaderText = "Tp. Campo";
            this.TpCampo.Name = "TpCampo";
            this.TpCampo.ReadOnly = true;
            this.TpCampo.Width = 85;
            // 
            // dgvRetornoFields
            // 
            this.dgvRetornoFields.AllowUserToAddRows = false;
            this.dgvRetornoFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRetornoFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetornoFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nmField,
            this.deCampo,
            this.boVisivel});
            this.dgvRetornoFields.Location = new System.Drawing.Point(6, 19);
            this.dgvRetornoFields.Name = "dgvRetornoFields";
            this.dgvRetornoFields.Size = new System.Drawing.Size(779, 277);
            this.dgvRetornoFields.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Retorna Fields:";
            // 
            // nmField
            // 
            this.nmField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmField.DataPropertyName = "nmField";
            this.nmField.HeaderText = "Nome Campo";
            this.nmField.Name = "nmField";
            // 
            // deCampo
            // 
            this.deCampo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deCampo.DataPropertyName = "deCampo";
            this.deCampo.HeaderText = "Desc. Campo";
            this.deCampo.Name = "deCampo";
            // 
            // boVisivel
            // 
            this.boVisivel.DataPropertyName = "boVisivel";
            this.boVisivel.FalseValue = "0";
            this.boVisivel.HeaderText = "Visível?";
            this.boVisivel.Name = "boVisivel";
            this.boVisivel.TrueValue = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Campo Calculado:";
            // 
            // dgvCampoCalculado
            // 
            this.dgvCampoCalculado.AllowUserToAddRows = false;
            this.dgvCampoCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCampoCalculado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampoCalculado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nmCampoCalculado,
            this.nmTabela,
            this.nmChave,
            this.nmCampoRetorno});
            this.dgvCampoCalculado.Location = new System.Drawing.Point(6, 19);
            this.dgvCampoCalculado.Name = "dgvCampoCalculado";
            this.dgvCampoCalculado.Size = new System.Drawing.Size(779, 277);
            this.dgvCampoCalculado.TabIndex = 1;
            this.dgvCampoCalculado.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampoCalculado_CellLeave);
            // 
            // nmCampoCalculado
            // 
            this.nmCampoCalculado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmCampoCalculado.DataPropertyName = "nmCampoCalculado";
            this.nmCampoCalculado.HeaderText = "Campo Calculado";
            this.nmCampoCalculado.Name = "nmCampoCalculado";
            // 
            // nmTabela
            // 
            this.nmTabela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmTabela.DataPropertyName = "nmTabela";
            this.nmTabela.HeaderText = "Tabela Origem";
            this.nmTabela.Name = "nmTabela";
            // 
            // nmChave
            // 
            this.nmChave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmChave.DataPropertyName = "nmChave";
            this.nmChave.HeaderText = "Chave";
            this.nmChave.Name = "nmChave";
            // 
            // nmCampoRetorno
            // 
            this.nmCampoRetorno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmCampoRetorno.DataPropertyName = "nmCampoRetorno";
            this.nmCampoRetorno.HeaderText = "Campo Retorno";
            this.nmCampoRetorno.Name = "nmCampoRetorno";
            // 
            // frmGerarClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 492);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.tcClasses);
            this.Controls.Add(this.btnLimpar);
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "frmGerarClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gera Classes";
            this.tcClasses.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.tpGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.tpController.ResumeLayout(false);
            this.tpController.PerformLayout();
            this.tpModel.ResumeLayout(false);
            this.tpModel.PerformLayout();
            this.tcModel.ResumeLayout(false);
            this.tpObject.ResumeLayout(false);
            this.tpObject.PerformLayout();
            this.tpAttribute.ResumeLayout(false);
            this.tpAttribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetornoFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoCalculado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TabControl tcClasses;
        private System.Windows.Forms.TabPage tpController;
        private System.Windows.Forms.TabPage tpModel;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.TextBox txtNmTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregaCampos;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtNameSpaceController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSpaceModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tcModel;
        private System.Windows.Forms.TabPage tpObject;
        private System.Windows.Forms.TabPage tpAttribute;
        private System.Windows.Forms.TextBox txtNameSpaceMensagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dePrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpVariavel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHAVE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHCOMPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRetornoFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmField;
        private System.Windows.Forms.DataGridViewTextBoxColumn deCampo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boVisivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCampoCalculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmCampoCalculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmCampoRetorno;
    }
}

