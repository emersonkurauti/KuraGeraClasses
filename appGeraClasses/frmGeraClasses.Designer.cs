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
            this.tcClasses = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.gbDadosClasses = new System.Windows.Forms.GroupBox();
            this.brnCarregarConfig = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarConfig = new System.Windows.Forms.Button();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSpaceModel = new System.Windows.Forms.TextBox();
            this.txtNameSpaceMensagem = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameSpaceController = new System.Windows.Forms.TextBox();
            this.gbConexao = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tpTabela = new System.Windows.Forms.TabPage();
            this.txtNomeTabela = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.dePrincipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nmCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpVariavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHAVE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CHCOMPOSTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TpCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNmTabela = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCarregaCampos = new System.Windows.Forms.Button();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.tcModel = new System.Windows.Forms.TabControl();
            this.tpAttribute = new System.Windows.Forms.TabPage();
            this.cbControlaTransacao = new System.Windows.Forms.CheckBox();
            this.cbGeraChave = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRetornoFields = new System.Windows.Forms.DataGridView();
            this.nmField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boVisivel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpObject = new System.Windows.Forms.TabPage();
            this.dgvCampoCalculado = new System.Windows.Forms.DataGridView();
            this.nmCampoCalculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmTabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmCampoRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.fbdCaminhoArquivos = new System.Windows.Forms.FolderBrowserDialog();
            this.tcClasses.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.gbDadosClasses.SuspendLayout();
            this.gbConexao.SuspendLayout();
            this.tpTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.tpModel.SuspendLayout();
            this.tcModel.SuspendLayout();
            this.tpAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetornoFields)).BeginInit();
            this.tpObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoCalculado)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClasses
            // 
            this.tcClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcClasses.Controls.Add(this.tpGeral);
            this.tcClasses.Controls.Add(this.tpTabela);
            this.tcClasses.Controls.Add(this.tpModel);
            this.tcClasses.Location = new System.Drawing.Point(12, 12);
            this.tcClasses.Name = "tcClasses";
            this.tcClasses.SelectedIndex = 0;
            this.tcClasses.Size = new System.Drawing.Size(820, 439);
            this.tcClasses.TabIndex = 0;
            this.tcClasses.SelectedIndexChanged += new System.EventHandler(this.tcClasses_SelectedIndexChanged);
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.gbDadosClasses);
            this.tpGeral.Controls.Add(this.gbConexao);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(812, 413);
            this.tpGeral.TabIndex = 3;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // gbDadosClasses
            // 
            this.gbDadosClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosClasses.Controls.Add(this.brnCarregarConfig);
            this.gbDadosClasses.Controls.Add(this.txtCaminho);
            this.gbDadosClasses.Controls.Add(this.label6);
            this.gbDadosClasses.Controls.Add(this.btnSalvarConfig);
            this.gbDadosClasses.Controls.Add(this.btnLoadFolder);
            this.gbDadosClasses.Controls.Add(this.label2);
            this.gbDadosClasses.Controls.Add(this.txtNameSpaceModel);
            this.gbDadosClasses.Controls.Add(this.txtNameSpaceMensagem);
            this.gbDadosClasses.Controls.Add(this.btnOpenFolder);
            this.gbDadosClasses.Controls.Add(this.label4);
            this.gbDadosClasses.Controls.Add(this.label5);
            this.gbDadosClasses.Controls.Add(this.txtNameSpaceController);
            this.gbDadosClasses.Location = new System.Drawing.Point(306, 6);
            this.gbDadosClasses.Name = "gbDadosClasses";
            this.gbDadosClasses.Size = new System.Drawing.Size(500, 156);
            this.gbDadosClasses.TabIndex = 1;
            this.gbDadosClasses.TabStop = false;
            this.gbDadosClasses.Text = "Dados Classes :";
            // 
            // brnCarregarConfig
            // 
            this.brnCarregarConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brnCarregarConfig.Image = global::appGeraClasses.Properties.Resources.carregarConfig;
            this.brnCarregarConfig.Location = new System.Drawing.Point(109, 123);
            this.brnCarregarConfig.Name = "brnCarregarConfig";
            this.brnCarregarConfig.Size = new System.Drawing.Size(111, 23);
            this.brnCarregarConfig.TabIndex = 11;
            this.brnCarregarConfig.Text = "Carregar Config";
            this.brnCarregarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnCarregarConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.brnCarregarConfig.UseVisualStyleBackColor = true;
            this.brnCarregarConfig.Click += new System.EventHandler(this.brnCarregarConfig_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(147, 19);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(264, 20);
            this.txtCaminho.TabIndex = 1;
            this.txtCaminho.Leave += new System.EventHandler(this.txtNmTabela_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name Space Menssagem :";
            // 
            // btnSalvarConfig
            // 
            this.btnSalvarConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarConfig.Image = global::appGeraClasses.Properties.Resources.SalvarP;
            this.btnSalvarConfig.Location = new System.Drawing.Point(6, 123);
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.Size = new System.Drawing.Size(97, 23);
            this.btnSalvarConfig.TabIndex = 10;
            this.btnSalvarConfig.Text = "Salvar Config";
            this.btnSalvarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvarConfig.UseVisualStyleBackColor = true;
            this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFolder.Image = global::appGeraClasses.Properties.Resources.pasta;
            this.btnLoadFolder.Location = new System.Drawing.Point(417, 17);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(35, 23);
            this.btnLoadFolder.TabIndex = 2;
            this.btnLoadFolder.Tag = "Procurar Caminho";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caminho :";
            // 
            // txtNameSpaceModel
            // 
            this.txtNameSpaceModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSpaceModel.Location = new System.Drawing.Point(147, 98);
            this.txtNameSpaceModel.Name = "txtNameSpaceModel";
            this.txtNameSpaceModel.Size = new System.Drawing.Size(346, 20);
            this.txtNameSpaceModel.TabIndex = 9;
            // 
            // txtNameSpaceMensagem
            // 
            this.txtNameSpaceMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSpaceMensagem.Location = new System.Drawing.Point(147, 46);
            this.txtNameSpaceMensagem.Name = "txtNameSpaceMensagem";
            this.txtNameSpaceMensagem.Size = new System.Drawing.Size(347, 20);
            this.txtNameSpaceMensagem.TabIndex = 5;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Image = global::appGeraClasses.Properties.Resources.SalvarNaPasta;
            this.btnOpenFolder.Location = new System.Drawing.Point(458, 17);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(35, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name Space Controller :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name Space Model :";
            // 
            // txtNameSpaceController
            // 
            this.txtNameSpaceController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSpaceController.Location = new System.Drawing.Point(147, 72);
            this.txtNameSpaceController.Name = "txtNameSpaceController";
            this.txtNameSpaceController.Size = new System.Drawing.Size(346, 20);
            this.txtNameSpaceController.TabIndex = 7;
            // 
            // gbConexao
            // 
            this.gbConexao.Controls.Add(this.btnConnect);
            this.gbConexao.Controls.Add(this.btnTestarConexao);
            this.gbConexao.Controls.Add(this.txtService);
            this.gbConexao.Controls.Add(this.txtPorta);
            this.gbConexao.Controls.Add(this.txtHost);
            this.gbConexao.Controls.Add(this.txtSenha);
            this.gbConexao.Controls.Add(this.txtUsuario);
            this.gbConexao.Controls.Add(this.label1);
            this.gbConexao.Controls.Add(this.label10);
            this.gbConexao.Controls.Add(this.label9);
            this.gbConexao.Controls.Add(this.label8);
            this.gbConexao.Controls.Add(this.lblUser);
            this.gbConexao.Location = new System.Drawing.Point(6, 6);
            this.gbConexao.Name = "gbConexao";
            this.gbConexao.Size = new System.Drawing.Size(294, 156);
            this.gbConexao.TabIndex = 0;
            this.gbConexao.TabStop = false;
            this.gbConexao.Text = "Dados Conexão :";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Image = global::appGeraClasses.Properties.Resources.connect;
            this.btnConnect.Location = new System.Drawing.Point(147, 123);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Image = global::appGeraClasses.Properties.Resources.TestConnect;
            this.btnTestarConexao.Location = new System.Drawing.Point(9, 123);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(132, 23);
            this.btnTestarConexao.TabIndex = 10;
            this.btnTestarConexao.Text = "Testar";
            this.btnTestarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestarConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // txtService
            // 
            this.txtService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtService.Location = new System.Drawing.Point(61, 97);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(227, 20);
            this.txtService.TabIndex = 9;
            this.txtService.Text = "XE";
            // 
            // txtPorta
            // 
            this.txtPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorta.Location = new System.Drawing.Point(235, 71);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(53, 20);
            this.txtPorta.TabIndex = 7;
            this.txtPorta.Text = "1521";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(61, 71);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(124, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "localhost";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(61, 45);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(227, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(61, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Service :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Porta :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Host :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Senha :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuário :";
            // 
            // tpTabela
            // 
            this.tpTabela.Controls.Add(this.txtNomeTabela);
            this.tpTabela.Controls.Add(this.dgvCampos);
            this.tpTabela.Controls.Add(this.txtNmTabela);
            this.tpTabela.Controls.Add(this.btnLimpar);
            this.tpTabela.Controls.Add(this.btnCarregaCampos);
            this.tpTabela.Location = new System.Drawing.Point(4, 22);
            this.tpTabela.Name = "tpTabela";
            this.tpTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabela.Size = new System.Drawing.Size(812, 413);
            this.tpTabela.TabIndex = 4;
            this.tpTabela.Text = "Tabela";
            this.tpTabela.UseVisualStyleBackColor = true;
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.AutoSize = true;
            this.txtNomeTabela.Location = new System.Drawing.Point(6, 3);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(77, 13);
            this.txtNomeTabela.TabIndex = 0;
            this.txtNomeTabela.Text = "Nome Tabela :";
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
            this.dgvCampos.Location = new System.Drawing.Point(6, 45);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.Size = new System.Drawing.Size(800, 333);
            this.dgvCampos.TabIndex = 2;
            this.dgvCampos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampos_CellLeave);
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
            // txtNmTabela
            // 
            this.txtNmTabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmTabela.Location = new System.Drawing.Point(6, 19);
            this.txtNmTabela.Name = "txtNmTabela";
            this.txtNmTabela.Size = new System.Drawing.Size(800, 20);
            this.txtNmTabela.TabIndex = 0;
            this.txtNmTabela.Leave += new System.EventHandler(this.txtNmTabela_Leave);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Image = global::appGeraClasses.Properties.Resources.limpar;
            this.btnLimpar.Location = new System.Drawing.Point(90, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCarregaCampos
            // 
            this.btnCarregaCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCarregaCampos.Image = global::appGeraClasses.Properties.Resources.Carregar;
            this.btnCarregaCampos.Location = new System.Drawing.Point(5, 384);
            this.btnCarregaCampos.Name = "btnCarregaCampos";
            this.btnCarregaCampos.Size = new System.Drawing.Size(78, 23);
            this.btnCarregaCampos.TabIndex = 3;
            this.btnCarregaCampos.Text = "Carregar";
            this.btnCarregaCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregaCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarregaCampos.UseVisualStyleBackColor = true;
            this.btnCarregaCampos.Click += new System.EventHandler(this.btnCarregaCampos_Click);
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.tcModel);
            this.tpModel.Location = new System.Drawing.Point(4, 22);
            this.tpModel.Name = "tpModel";
            this.tpModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpModel.Size = new System.Drawing.Size(812, 413);
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
            this.tcModel.Location = new System.Drawing.Point(9, 6);
            this.tcModel.Name = "tcModel";
            this.tcModel.SelectedIndex = 0;
            this.tcModel.Size = new System.Drawing.Size(797, 401);
            this.tcModel.TabIndex = 0;
            // 
            // tpAttribute
            // 
            this.tpAttribute.Controls.Add(this.cbControlaTransacao);
            this.tpAttribute.Controls.Add(this.cbGeraChave);
            this.tpAttribute.Controls.Add(this.label3);
            this.tpAttribute.Controls.Add(this.dgvRetornoFields);
            this.tpAttribute.Location = new System.Drawing.Point(4, 22);
            this.tpAttribute.Name = "tpAttribute";
            this.tpAttribute.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttribute.Size = new System.Drawing.Size(789, 375);
            this.tpAttribute.TabIndex = 1;
            this.tpAttribute.Text = "Attribute";
            this.tpAttribute.UseVisualStyleBackColor = true;
            // 
            // cbControlaTransacao
            // 
            this.cbControlaTransacao.AutoSize = true;
            this.cbControlaTransacao.Checked = true;
            this.cbControlaTransacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbControlaTransacao.Location = new System.Drawing.Point(580, 2);
            this.cbControlaTransacao.Name = "cbControlaTransacao";
            this.cbControlaTransacao.Size = new System.Drawing.Size(119, 17);
            this.cbControlaTransacao.TabIndex = 1;
            this.cbControlaTransacao.Text = "Controla Transação";
            this.cbControlaTransacao.UseVisualStyleBackColor = true;
            // 
            // cbGeraChave
            // 
            this.cbGeraChave.AutoSize = true;
            this.cbGeraChave.Checked = true;
            this.cbGeraChave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGeraChave.Location = new System.Drawing.Point(705, 2);
            this.cbGeraChave.Name = "cbGeraChave";
            this.cbGeraChave.Size = new System.Drawing.Size(83, 17);
            this.cbGeraChave.TabIndex = 2;
            this.cbGeraChave.Text = "Gera Chave";
            this.cbGeraChave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Retorna Fields:";
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
            this.dgvRetornoFields.Size = new System.Drawing.Size(777, 350);
            this.dgvRetornoFields.TabIndex = 3;
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
            // tpObject
            // 
            this.tpObject.Controls.Add(this.dgvCampoCalculado);
            this.tpObject.Controls.Add(this.label7);
            this.tpObject.Location = new System.Drawing.Point(4, 22);
            this.tpObject.Name = "tpObject";
            this.tpObject.Padding = new System.Windows.Forms.Padding(3);
            this.tpObject.Size = new System.Drawing.Size(789, 375);
            this.tpObject.TabIndex = 0;
            this.tpObject.Text = "Object";
            this.tpObject.UseVisualStyleBackColor = true;
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
            this.dgvCampoCalculado.Size = new System.Drawing.Size(777, 350);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Campo Calculado:";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.Image = global::appGeraClasses.Properties.Resources.Finalizar;
            this.btnGerar.Location = new System.Drawing.Point(767, 457);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(65, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // fbdCaminhoArquivos
            // 
            this.fbdCaminhoArquivos.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // frmGerarClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.tcClasses);
            this.MinimumSize = new System.Drawing.Size(860, 530);
            this.Name = "frmGerarClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gera Classes";
            this.tcClasses.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.gbDadosClasses.ResumeLayout(false);
            this.gbDadosClasses.PerformLayout();
            this.gbConexao.ResumeLayout(false);
            this.gbConexao.PerformLayout();
            this.tpTabela.ResumeLayout(false);
            this.tpTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.tpModel.ResumeLayout(false);
            this.tcModel.ResumeLayout(false);
            this.tpAttribute.ResumeLayout(false);
            this.tpAttribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetornoFields)).EndInit();
            this.tpObject.ResumeLayout(false);
            this.tpObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoCalculado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClasses;
        private System.Windows.Forms.TabPage tpModel;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TabControl tcModel;
        private System.Windows.Forms.TabPage tpObject;
        private System.Windows.Forms.TabPage tpAttribute;
        private System.Windows.Forms.TextBox txtNameSpaceMensagem;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.CheckBox cbControlaTransacao;
        private System.Windows.Forms.CheckBox cbGeraChave;
        private System.Windows.Forms.Button btnSalvarConfig;
        private System.Windows.Forms.Button brnCarregarConfig;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TabPage tpTabela;
        private System.Windows.Forms.Label txtNomeTabela;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dePrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpVariavel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHAVE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHCOMPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpCampo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregaCampos;
        private System.Windows.Forms.TextBox txtNmTabela;
        private System.Windows.Forms.TextBox txtNameSpaceController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSpaceModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDadosClasses;
        private System.Windows.Forms.GroupBox gbConexao;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoArquivos;
    }
}

