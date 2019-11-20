using System.ComponentModel;

namespace Interface
{
    partial class PainelAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(PainelAdministrador));
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkHistorico = new System.Windows.Forms.LinkLabel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlAdministrador = new System.Windows.Forms.TabControl();
            this.tabInstituicao = new System.Windows.Forms.TabPage();
            this.linkCadastrarInstituicao = new System.Windows.Forms.LinkLabel();
            this.linkLimpezaInstituicao = new System.Windows.Forms.LinkLabel();
            this.btnPesquisarInstituicao = new System.Windows.Forms.Button();
            this.txtPesquisaInstituicao = new System.Windows.Forms.MaskedTextBox();
            this.dataGridInstituicao = new System.Windows.Forms.DataGridView();
            this.colCnpjInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocialInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.linkCadastrarMaterial = new System.Windows.Forms.LinkLabel();
            this.linkLimpezaMaterial = new System.Windows.Forms.LinkLabel();
            this.txtPesquisaMaterial = new System.Windows.Forms.TextBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.dataGridMaterial = new System.Windows.Forms.DataGridView();
            this.colIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChaveNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.linkCadastrarUsuario = new System.Windows.Forms.LinkLabel();
            this.linkLimpezaUsuario = new System.Windows.Forms.LinkLabel();
            this.txtPesquisaUsuario = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.colCpfUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNascimentoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStripAdministrador = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControlAdministrador.SuspendLayout();
            this.tabInstituicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridInstituicao)).BeginInit();
            this.tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).BeginInit();
            this.tabUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.linkHistorico);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.tabControlAdministrador);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // linkHistorico
            // 
            this.linkHistorico.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkHistorico.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHistorico.LinkColor = System.Drawing.Color.DimGray;
            this.linkHistorico.Location = new System.Drawing.Point(3, 542);
            this.linkHistorico.Name = "linkHistorico";
            this.linkHistorico.Size = new System.Drawing.Size(110, 23);
            this.linkHistorico.TabIndex = 9;
            this.linkHistorico.TabStop = true;
            this.linkHistorico.Text = "Histórico";
            this.linkHistorico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkHistorico.VisitedLinkColor = System.Drawing.Color.DarkGray;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(798, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(250, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright - Pedro Couto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdministrador
            // 
            this.tabControlAdministrador.Controls.Add(this.tabInstituicao);
            this.tabControlAdministrador.Controls.Add(this.tabMaterial);
            this.tabControlAdministrador.Controls.Add(this.tabUsuario);
            this.tabControlAdministrador.Location = new System.Drawing.Point(50, 100);
            this.tabControlAdministrador.Name = "tabControlAdministrador";
            this.tabControlAdministrador.SelectedIndex = 0;
            this.tabControlAdministrador.Size = new System.Drawing.Size(708, 433);
            this.tabControlAdministrador.TabIndex = 0;
            // 
            // tabInstituicao
            // 
            this.tabInstituicao.Controls.Add(this.linkCadastrarInstituicao);
            this.tabInstituicao.Controls.Add(this.linkLimpezaInstituicao);
            this.tabInstituicao.Controls.Add(this.btnPesquisarInstituicao);
            this.tabInstituicao.Controls.Add(this.txtPesquisaInstituicao);
            this.tabInstituicao.Controls.Add(this.dataGridInstituicao);
            this.tabInstituicao.Location = new System.Drawing.Point(4, 29);
            this.tabInstituicao.Name = "tabInstituicao";
            this.tabInstituicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstituicao.Size = new System.Drawing.Size(700, 400);
            this.tabInstituicao.TabIndex = 0;
            this.tabInstituicao.Text = "Instituições";
            this.tabInstituicao.UseVisualStyleBackColor = true;
            // 
            // linkCadastrarInstituicao
            // 
            this.linkCadastrarInstituicao.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkCadastrarInstituicao.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCadastrarInstituicao.LinkColor = System.Drawing.Color.Green;
            this.linkCadastrarInstituicao.Location = new System.Drawing.Point(424, 374);
            this.linkCadastrarInstituicao.Name = "linkCadastrarInstituicao";
            this.linkCadastrarInstituicao.Size = new System.Drawing.Size(110, 23);
            this.linkCadastrarInstituicao.TabIndex = 3;
            this.linkCadastrarInstituicao.TabStop = true;
            this.linkCadastrarInstituicao.Text = "Novo registro";
            this.linkCadastrarInstituicao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkCadastrarInstituicao.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkCadastrarInstituicao.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrarInstituicao_LinkClicked);
            // 
            // linkLimpezaInstituicao
            // 
            this.linkLimpezaInstituicao.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpezaInstituicao.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpezaInstituicao.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpezaInstituicao.Location = new System.Drawing.Point(540, 374);
            this.linkLimpezaInstituicao.Name = "linkLimpezaInstituicao";
            this.linkLimpezaInstituicao.Size = new System.Drawing.Size(110, 23);
            this.linkLimpezaInstituicao.TabIndex = 2;
            this.linkLimpezaInstituicao.TabStop = true;
            this.linkLimpezaInstituicao.Text = "Limpar pesquisa";
            this.linkLimpezaInstituicao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLimpezaInstituicao.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpezaInstituicao.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpezaInstituicao_LinkClicked);
            // 
            // btnPesquisarInstituicao
            // 
            this.btnPesquisarInstituicao.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnPesquisarInstituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarInstituicao.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisarInstituicao.Image =
                ((System.Drawing.Image) (resources.GetObject("btnPesquisarInstituicao.Image")));
            this.btnPesquisarInstituicao.Location = new System.Drawing.Point(624, 39);
            this.btnPesquisarInstituicao.Name = "btnPesquisarInstituicao";
            this.btnPesquisarInstituicao.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarInstituicao.TabIndex = 1;
            this.btnPesquisarInstituicao.UseVisualStyleBackColor = true;
            this.btnPesquisarInstituicao.Click += new System.EventHandler(this.btnPesquisarInstituicao_Click);
            // 
            // txtPesquisaInstituicao
            // 
            this.txtPesquisaInstituicao.Location = new System.Drawing.Point(448, 39);
            this.txtPesquisaInstituicao.Mask = "00,000,000/0000-00";
            this.txtPesquisaInstituicao.Name = "txtPesquisaInstituicao";
            this.txtPesquisaInstituicao.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaInstituicao.TabIndex = 0;
            this.txtPesquisaInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridInstituicao
            // 
            this.dataGridInstituicao.AllowUserToAddRows = false;
            this.dataGridInstituicao.AllowUserToDeleteRows = false;
            this.dataGridInstituicao.AllowUserToResizeColumns = false;
            this.dataGridInstituicao.AllowUserToResizeRows = false;
            this.dataGridInstituicao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridInstituicao.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInstituicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.colCnpjInstituicao, this.colRazaoSocialInstituicao, this.colEnderecoInstituicao});
            this.dataGridInstituicao.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridInstituicao.Location = new System.Drawing.Point(50, 71);
            this.dataGridInstituicao.Name = "dataGridInstituicao";
            this.dataGridInstituicao.ReadOnly = true;
            this.dataGridInstituicao.RowHeadersWidth = 25;
            this.dataGridInstituicao.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridInstituicao.Size = new System.Drawing.Size(600, 300);
            this.dataGridInstituicao.TabIndex = 0;
            this.dataGridInstituicao.TabStop = false;
            this.dataGridInstituicao.CellContentDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInstituicao_CellContentDoubleClick);
            // 
            // colCnpjInstituicao
            // 
            this.colCnpjInstituicao.DataPropertyName = "cnpjInstituicao";
            this.colCnpjInstituicao.HeaderText = "CNPJ";
            this.colCnpjInstituicao.MaxInputLength = 18;
            this.colCnpjInstituicao.MinimumWidth = 160;
            this.colCnpjInstituicao.Name = "colCnpjInstituicao";
            this.colCnpjInstituicao.ReadOnly = true;
            this.colCnpjInstituicao.Width = 160;
            // 
            // colRazaoSocialInstituicao
            // 
            this.colRazaoSocialInstituicao.DataPropertyName = "razaoSocialInstituicao";
            this.colRazaoSocialInstituicao.HeaderText = "Razão Social";
            this.colRazaoSocialInstituicao.MaxInputLength = 200;
            this.colRazaoSocialInstituicao.MinimumWidth = 413;
            this.colRazaoSocialInstituicao.Name = "colRazaoSocialInstituicao";
            this.colRazaoSocialInstituicao.ReadOnly = true;
            this.colRazaoSocialInstituicao.Width = 413;
            // 
            // colEnderecoInstituicao
            // 
            this.colEnderecoInstituicao.DataPropertyName = "enderecoInstituicao";
            this.colEnderecoInstituicao.HeaderText = "Endereço";
            this.colEnderecoInstituicao.MaxInputLength = 200;
            this.colEnderecoInstituicao.MinimumWidth = 573;
            this.colEnderecoInstituicao.Name = "colEnderecoInstituicao";
            this.colEnderecoInstituicao.ReadOnly = true;
            this.colEnderecoInstituicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEnderecoInstituicao.Width = 573;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.linkCadastrarMaterial);
            this.tabMaterial.Controls.Add(this.linkLimpezaMaterial);
            this.tabMaterial.Controls.Add(this.txtPesquisaMaterial);
            this.tabMaterial.Controls.Add(this.btnPesquisarMaterial);
            this.tabMaterial.Controls.Add(this.dataGridMaterial);
            this.tabMaterial.Location = new System.Drawing.Point(4, 29);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterial.Size = new System.Drawing.Size(700, 400);
            this.tabMaterial.TabIndex = 1;
            this.tabMaterial.Text = "Materiais";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // linkCadastrarMaterial
            // 
            this.linkCadastrarMaterial.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkCadastrarMaterial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCadastrarMaterial.LinkColor = System.Drawing.Color.Green;
            this.linkCadastrarMaterial.Location = new System.Drawing.Point(424, 374);
            this.linkCadastrarMaterial.Name = "linkCadastrarMaterial";
            this.linkCadastrarMaterial.Size = new System.Drawing.Size(110, 23);
            this.linkCadastrarMaterial.TabIndex = 4;
            this.linkCadastrarMaterial.TabStop = true;
            this.linkCadastrarMaterial.Text = "Novo registro";
            this.linkCadastrarMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkCadastrarMaterial.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkCadastrarMaterial.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrarMaterial_LinkClicked);
            // 
            // linkLimpezaMaterial
            // 
            this.linkLimpezaMaterial.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpezaMaterial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpezaMaterial.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpezaMaterial.Location = new System.Drawing.Point(540, 374);
            this.linkLimpezaMaterial.Name = "linkLimpezaMaterial";
            this.linkLimpezaMaterial.Size = new System.Drawing.Size(110, 23);
            this.linkLimpezaMaterial.TabIndex = 5;
            this.linkLimpezaMaterial.TabStop = true;
            this.linkLimpezaMaterial.Text = "Limpar pesquisa";
            this.linkLimpezaMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLimpezaMaterial.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpezaMaterial.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpezaMaterial_LinkClicked);
            // 
            // txtPesquisaMaterial
            // 
            this.txtPesquisaMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaMaterial.Location = new System.Drawing.Point(448, 39);
            this.txtPesquisaMaterial.MaxLength = 200;
            this.txtPesquisaMaterial.Name = "txtPesquisaMaterial";
            this.txtPesquisaMaterial.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaMaterial.TabIndex = 3;
            this.txtPesquisaMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisarMaterial
            // 
            this.btnPesquisarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarMaterial.FlatAppearance.BorderSize = 0;
            this.btnPesquisarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisarMaterial.Image =
                ((System.Drawing.Image) (resources.GetObject("btnPesquisarMaterial.Image")));
            this.btnPesquisarMaterial.Location = new System.Drawing.Point(624, 39);
            this.btnPesquisarMaterial.Name = "btnPesquisarMaterial";
            this.btnPesquisarMaterial.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarMaterial.TabIndex = 4;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // dataGridMaterial
            // 
            this.dataGridMaterial.AllowUserToAddRows = false;
            this.dataGridMaterial.AllowUserToDeleteRows = false;
            this.dataGridMaterial.AllowUserToResizeColumns = false;
            this.dataGridMaterial.AllowUserToResizeRows = false;
            this.dataGridMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMaterial.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colIdMaterial, this.colNomeMaterial, this.colDescricaoMaterial, this.colQuantidadeMaterial,
                this.colLocalizacaoMaterial, this.colChaveNotaFiscal
            });
            this.dataGridMaterial.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMaterial.Location = new System.Drawing.Point(50, 71);
            this.dataGridMaterial.Name = "dataGridMaterial";
            this.dataGridMaterial.ReadOnly = true;
            this.dataGridMaterial.RowHeadersWidth = 25;
            this.dataGridMaterial.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMaterial.Size = new System.Drawing.Size(600, 300);
            this.dataGridMaterial.TabIndex = 0;
            this.dataGridMaterial.TabStop = false;
            this.dataGridMaterial.CellContentDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaterial_CellContentDoubleClick);
            // 
            // colIdMaterial
            // 
            this.colIdMaterial.DataPropertyName = "idMaterial";
            this.colIdMaterial.HeaderText = "ID";
            this.colIdMaterial.MaxInputLength = 10;
            this.colIdMaterial.MinimumWidth = 45;
            this.colIdMaterial.Name = "colIdMaterial";
            this.colIdMaterial.ReadOnly = true;
            this.colIdMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdMaterial.Width = 45;
            // 
            // colNomeMaterial
            // 
            this.colNomeMaterial.DataPropertyName = "nomeMaterial";
            this.colNomeMaterial.HeaderText = "Nome";
            this.colNomeMaterial.MaxInputLength = 200;
            this.colNomeMaterial.MinimumWidth = 528;
            this.colNomeMaterial.Name = "colNomeMaterial";
            this.colNomeMaterial.ReadOnly = true;
            this.colNomeMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNomeMaterial.Width = 528;
            // 
            // colDescricaoMaterial
            // 
            this.colDescricaoMaterial.DataPropertyName = "descricaoMaterial";
            this.colDescricaoMaterial.HeaderText = "Descrição";
            this.colDescricaoMaterial.MaxInputLength = 200;
            this.colDescricaoMaterial.MinimumWidth = 377;
            this.colDescricaoMaterial.Name = "colDescricaoMaterial";
            this.colDescricaoMaterial.ReadOnly = true;
            this.colDescricaoMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescricaoMaterial.Width = 377;
            // 
            // colQuantidadeMaterial
            // 
            this.colQuantidadeMaterial.DataPropertyName = "quantidadeMaterial";
            this.colQuantidadeMaterial.HeaderText = "Quantidade";
            this.colQuantidadeMaterial.MaxInputLength = 5;
            this.colQuantidadeMaterial.MinimumWidth = 98;
            this.colQuantidadeMaterial.Name = "colQuantidadeMaterial";
            this.colQuantidadeMaterial.ReadOnly = true;
            this.colQuantidadeMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantidadeMaterial.Width = 98;
            // 
            // colLocalizacaoMaterial
            // 
            this.colLocalizacaoMaterial.DataPropertyName = "localizacaoMaterial";
            this.colLocalizacaoMaterial.HeaderText = "Localização";
            this.colLocalizacaoMaterial.MaxInputLength = 10;
            this.colLocalizacaoMaterial.MinimumWidth = 98;
            this.colLocalizacaoMaterial.Name = "colLocalizacaoMaterial";
            this.colLocalizacaoMaterial.ReadOnly = true;
            this.colLocalizacaoMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLocalizacaoMaterial.Width = 98;
            // 
            // colChaveNotaFiscal
            // 
            this.colChaveNotaFiscal.DataPropertyName = "chaveNotaFiscal";
            this.colChaveNotaFiscal.HeaderText = "NF";
            this.colChaveNotaFiscal.MaxInputLength = 44;
            this.colChaveNotaFiscal.MinimumWidth = 100;
            this.colChaveNotaFiscal.Name = "colChaveNotaFiscal";
            this.colChaveNotaFiscal.ReadOnly = true;
            this.colChaveNotaFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChaveNotaFiscal.Visible = false;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.linkCadastrarUsuario);
            this.tabUsuario.Controls.Add(this.linkLimpezaUsuario);
            this.tabUsuario.Controls.Add(this.txtPesquisaUsuario);
            this.tabUsuario.Controls.Add(this.btnPesquisarUsuario);
            this.tabUsuario.Controls.Add(this.dataGridUsuario);
            this.tabUsuario.Location = new System.Drawing.Point(4, 29);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(700, 400);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuários";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // linkCadastrarUsuario
            // 
            this.linkCadastrarUsuario.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkCadastrarUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCadastrarUsuario.LinkColor = System.Drawing.Color.Green;
            this.linkCadastrarUsuario.Location = new System.Drawing.Point(424, 374);
            this.linkCadastrarUsuario.Name = "linkCadastrarUsuario";
            this.linkCadastrarUsuario.Size = new System.Drawing.Size(110, 23);
            this.linkCadastrarUsuario.TabIndex = 6;
            this.linkCadastrarUsuario.TabStop = true;
            this.linkCadastrarUsuario.Text = "Novo registro";
            this.linkCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkCadastrarUsuario.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkCadastrarUsuario.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrarUsuario_LinkClicked);
            // 
            // linkLimpezaUsuario
            // 
            this.linkLimpezaUsuario.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpezaUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpezaUsuario.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpezaUsuario.Location = new System.Drawing.Point(540, 374);
            this.linkLimpezaUsuario.Name = "linkLimpezaUsuario";
            this.linkLimpezaUsuario.Size = new System.Drawing.Size(110, 23);
            this.linkLimpezaUsuario.TabIndex = 8;
            this.linkLimpezaUsuario.TabStop = true;
            this.linkLimpezaUsuario.Text = "Limpar pesquisa";
            this.linkLimpezaUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLimpezaUsuario.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpezaUsuario.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpezaUsuario_LinkClicked);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(448, 39);
            this.txtPesquisaUsuario.Mask = "000,000,000-00";
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaUsuario.TabIndex = 6;
            this.txtPesquisaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarUsuario.FlatAppearance.BorderSize = 0;
            this.btnPesquisarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisarUsuario.Image =
                ((System.Drawing.Image) (resources.GetObject("btnPesquisarUsuario.Image")));
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(624, 39);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarUsuario.TabIndex = 7;
            this.btnPesquisarUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            this.dataGridUsuario.AllowUserToDeleteRows = false;
            this.dataGridUsuario.AllowUserToResizeColumns = false;
            this.dataGridUsuario.AllowUserToResizeRows = false;
            this.dataGridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.colCpfUsuario, this.colNomeUsuario, this.colEmailUsuario, this.colNascimentoUsuario});
            this.dataGridUsuario.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridUsuario.Location = new System.Drawing.Point(50, 71);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            this.dataGridUsuario.RowHeadersWidth = 25;
            this.dataGridUsuario.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridUsuario.Size = new System.Drawing.Size(600, 300);
            this.dataGridUsuario.TabIndex = 0;
            this.dataGridUsuario.TabStop = false;
            this.dataGridUsuario.CellContentDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuario_CellContentDoubleClick);
            // 
            // colCpfUsuario
            // 
            this.colCpfUsuario.DataPropertyName = "cpfUsuario";
            this.colCpfUsuario.HeaderText = "CPF";
            this.colCpfUsuario.MaxInputLength = 18;
            this.colCpfUsuario.MinimumWidth = 130;
            this.colCpfUsuario.Name = "colCpfUsuario";
            this.colCpfUsuario.ReadOnly = true;
            this.colCpfUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCpfUsuario.Width = 130;
            // 
            // colNomeUsuario
            // 
            this.colNomeUsuario.DataPropertyName = "nomeUsuario";
            this.colNomeUsuario.HeaderText = "Usuário";
            this.colNomeUsuario.MaxInputLength = 200;
            this.colNomeUsuario.MinimumWidth = 443;
            this.colNomeUsuario.Name = "colNomeUsuario";
            this.colNomeUsuario.ReadOnly = true;
            this.colNomeUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNomeUsuario.Width = 443;
            // 
            // colEmailUsuario
            // 
            this.colEmailUsuario.DataPropertyName = "emailUsuario";
            this.colEmailUsuario.HeaderText = "E-mail registrado";
            this.colEmailUsuario.MaxInputLength = 200;
            this.colEmailUsuario.MinimumWidth = 573;
            this.colEmailUsuario.Name = "colEmailUsuario";
            this.colEmailUsuario.ReadOnly = true;
            this.colEmailUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmailUsuario.Width = 573;
            // 
            // colNascimentoUsuario
            // 
            this.colNascimentoUsuario.DataPropertyName = "dataNascimento";
            this.colNascimentoUsuario.HeaderText = "Data de nascimento";
            this.colNascimentoUsuario.MaxInputLength = 15;
            this.colNascimentoUsuario.MinimumWidth = 100;
            this.colNascimentoUsuario.Name = "colNascimentoUsuario";
            this.colNascimentoUsuario.ReadOnly = true;
            this.colNascimentoUsuario.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.ErrorImage = ((System.Drawing.Image) (resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(687, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.menuStripAdministrador);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 30);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(719, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 31);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(759, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStripAdministrador
            // 
            this.menuStripAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.menuStripAdministrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripAdministrador.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripAdministrador.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripAdministrador.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdministrador.Name = "menuStripAdministrador";
            this.menuStripAdministrador.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripAdministrador.Size = new System.Drawing.Size(64, 30);
            this.menuStripAdministrador.TabIndex = 0;
            this.menuStripAdministrador.Text = "menuStripAdministrador";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // PainelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripAdministrador;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PainelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelAdministrador";
            this.Activated += new System.EventHandler(this.PainelAdministrador_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PainelAdministrador_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.tabControlAdministrador.ResumeLayout(false);
            this.tabInstituicao.ResumeLayout(false);
            this.tabInstituicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridInstituicao)).EndInit();
            this.tabMaterial.ResumeLayout(false);
            this.tabMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).EndInit();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripAdministrador.ResumeLayout(false);
            this.menuStripAdministrador.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripAdministrador;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabControl tabControlAdministrador;
        private System.Windows.Forms.TabPage tabInstituicao;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.TabPage tabMaterial;
        private System.Windows.Forms.DataGridView dataGridInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazaoSocialInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnpjInstituicao;
        private System.Windows.Forms.MaskedTextBox txtPesquisaInstituicao;
        private System.Windows.Forms.Button btnPesquisarInstituicao;
        private System.Windows.Forms.DataGridView dataGridMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfUsuario;
        private System.Windows.Forms.Button btnPesquisarMaterial;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.LinkLabel linkLimpezaInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoMaterial;
        private System.Windows.Forms.MaskedTextBox txtPesquisaUsuario;
        private System.Windows.Forms.TextBox txtPesquisaMaterial;
        private System.Windows.Forms.LinkLabel linkLimpezaUsuario;
        private System.Windows.Forms.LinkLabel linkLimpezaMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNascimentoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoInstituicao;
        private System.Windows.Forms.LinkLabel linkCadastrarUsuario;
        private System.Windows.Forms.LinkLabel linkCadastrarMaterial;
        private System.Windows.Forms.LinkLabel linkCadastrarInstituicao;
        private System.Windows.Forms.LinkLabel linkHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChaveNotaFiscal;
    }
}