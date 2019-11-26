using System.ComponentModel;

namespace Interface
{
    partial class HistoricoRegistro
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
                new System.ComponentModel.ComponentResourceManager(typeof(HistoricoRegistro));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlHistorico = new System.Windows.Forms.TabControl();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.linkLimpezaMaterial = new System.Windows.Forms.LinkLabel();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.txtPesquisaMaterial = new System.Windows.Forms.TextBox();
            this.dataGridMaterial = new System.Windows.Forms.DataGridView();
            this.colIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntradaMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaidaMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChaveNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.linkLimpezaUsuario = new System.Windows.Forms.LinkLabel();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.txtPesquisaUsuario = new System.Windows.Forms.MaskedTextBox();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.colCpfUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstrucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripHistoricoRegistro = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.tabControlHistorico.SuspendLayout();
            this.tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).BeginInit();
            this.tabUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripHistoricoRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.tabControlHistorico);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // tabControlHistorico
            // 
            this.tabControlHistorico.Controls.Add(this.tabMaterial);
            this.tabControlHistorico.Controls.Add(this.tabUsuario);
            this.tabControlHistorico.Location = new System.Drawing.Point(50, 100);
            this.tabControlHistorico.Name = "tabControlHistorico";
            this.tabControlHistorico.SelectedIndex = 0;
            this.tabControlHistorico.Size = new System.Drawing.Size(708, 433);
            this.tabControlHistorico.TabIndex = 0;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.linkLimpezaMaterial);
            this.tabMaterial.Controls.Add(this.btnPesquisarMaterial);
            this.tabMaterial.Controls.Add(this.txtPesquisaMaterial);
            this.tabMaterial.Controls.Add(this.dataGridMaterial);
            this.tabMaterial.Location = new System.Drawing.Point(4, 29);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterial.Size = new System.Drawing.Size(700, 400);
            this.tabMaterial.TabIndex = 0;
            this.tabMaterial.Text = "Materiais";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // linkLimpezaMaterial
            // 
            this.linkLimpezaMaterial.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpezaMaterial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpezaMaterial.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpezaMaterial.Location = new System.Drawing.Point(540, 374);
            this.linkLimpezaMaterial.Name = "linkLimpezaMaterial";
            this.linkLimpezaMaterial.Size = new System.Drawing.Size(110, 23);
            this.linkLimpezaMaterial.TabIndex = 2;
            this.linkLimpezaMaterial.TabStop = true;
            this.linkLimpezaMaterial.Text = "Limpar pesquisa";
            this.linkLimpezaMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLimpezaMaterial.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpezaMaterial.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpezaMaterial_LinkClicked);
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
            this.btnPesquisarMaterial.TabIndex = 1;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // txtPesquisaMaterial
            // 
            this.txtPesquisaMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaMaterial.Location = new System.Drawing.Point(448, 39);
            this.txtPesquisaMaterial.MaxLength = 200;
            this.txtPesquisaMaterial.Name = "txtPesquisaMaterial";
            this.txtPesquisaMaterial.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaMaterial.TabIndex = 0;
            this.txtPesquisaMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
                this.colIdMaterial, this.colNomeMaterial, this.colQuantidadeMaterial, this.colLocalizacaoMaterial,
                this.colEntradaMaterial, this.colSaidaMaterial, this.colChaveNotaFiscal
            });
            this.dataGridMaterial.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMaterial.Location = new System.Drawing.Point(50, 71);
            this.dataGridMaterial.Name = "dataGridMaterial";
            this.dataGridMaterial.RowHeadersWidth = 25;
            this.dataGridMaterial.Size = new System.Drawing.Size(600, 300);
            this.dataGridMaterial.TabIndex = 0;
            this.dataGridMaterial.TabStop = false;
            // 
            // colIdMaterial
            // 
            this.colIdMaterial.DataPropertyName = "idMaterial";
            this.colIdMaterial.HeaderText = "ID";
            this.colIdMaterial.MaxInputLength = 10;
            this.colIdMaterial.MinimumWidth = 45;
            this.colIdMaterial.Name = "colIdMaterial";
            this.colIdMaterial.ReadOnly = true;
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
            this.colNomeMaterial.Width = 528;
            // 
            // colQuantidadeMaterial
            // 
            this.colQuantidadeMaterial.DataPropertyName = "quantidadeMaterial";
            this.colQuantidadeMaterial.HeaderText = "Quantidade";
            this.colQuantidadeMaterial.MaxInputLength = 5;
            this.colQuantidadeMaterial.MinimumWidth = 140;
            this.colQuantidadeMaterial.Name = "colQuantidadeMaterial";
            this.colQuantidadeMaterial.ReadOnly = true;
            this.colQuantidadeMaterial.Width = 140;
            // 
            // colLocalizacaoMaterial
            // 
            this.colLocalizacaoMaterial.DataPropertyName = "localizacaoMaterial";
            this.colLocalizacaoMaterial.HeaderText = "Localização";
            this.colLocalizacaoMaterial.MaxInputLength = 10;
            this.colLocalizacaoMaterial.MinimumWidth = 140;
            this.colLocalizacaoMaterial.Name = "colLocalizacaoMaterial";
            this.colLocalizacaoMaterial.ReadOnly = true;
            this.colLocalizacaoMaterial.Width = 140;
            // 
            // colEntradaMaterial
            // 
            this.colEntradaMaterial.DataPropertyName = "dataEntrada";
            this.colEntradaMaterial.HeaderText = "Última entrada";
            this.colEntradaMaterial.MaxInputLength = 10;
            this.colEntradaMaterial.MinimumWidth = 147;
            this.colEntradaMaterial.Name = "colEntradaMaterial";
            this.colEntradaMaterial.ReadOnly = true;
            this.colEntradaMaterial.Width = 147;
            // 
            // colSaidaMaterial
            // 
            this.colSaidaMaterial.DataPropertyName = "dataSaida";
            this.colSaidaMaterial.HeaderText = "Última saída";
            this.colSaidaMaterial.MaxInputLength = 10;
            this.colSaidaMaterial.MinimumWidth = 146;
            this.colSaidaMaterial.Name = "colSaidaMaterial";
            this.colSaidaMaterial.ReadOnly = true;
            this.colSaidaMaterial.Width = 146;
            // 
            // colChaveNotaFiscal
            // 
            this.colChaveNotaFiscal.DataPropertyName = "chaveNotaFiscal";
            this.colChaveNotaFiscal.HeaderText = "Última Nota Fiscal";
            this.colChaveNotaFiscal.MaxInputLength = 44;
            this.colChaveNotaFiscal.MinimumWidth = 573;
            this.colChaveNotaFiscal.Name = "colChaveNotaFiscal";
            this.colChaveNotaFiscal.ReadOnly = true;
            this.colChaveNotaFiscal.Width = 573;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.linkLimpezaUsuario);
            this.tabUsuario.Controls.Add(this.btnPesquisarUsuario);
            this.tabUsuario.Controls.Add(this.txtPesquisaUsuario);
            this.tabUsuario.Controls.Add(this.dataGridUsuario);
            this.tabUsuario.Location = new System.Drawing.Point(4, 29);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(700, 400);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "Usuários";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // linkLimpezaUsuario
            // 
            this.linkLimpezaUsuario.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpezaUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpezaUsuario.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpezaUsuario.Location = new System.Drawing.Point(540, 374);
            this.linkLimpezaUsuario.Name = "linkLimpezaUsuario";
            this.linkLimpezaUsuario.Size = new System.Drawing.Size(110, 23);
            this.linkLimpezaUsuario.TabIndex = 5;
            this.linkLimpezaUsuario.TabStop = true;
            this.linkLimpezaUsuario.Text = "Limpar pesquisa";
            this.linkLimpezaUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLimpezaUsuario.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpezaUsuario.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpezaUsuario_LinkClicked);
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
            this.btnPesquisarUsuario.TabIndex = 4;
            this.btnPesquisarUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(448, 39);
            this.txtPesquisaUsuario.Mask = "000,000,000-00";
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaUsuario.TabIndex = 3;
            this.txtPesquisaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
                {this.colCpfUsuario, this.colNomeUsuario, this.colDataRegistro, this.colInstrucao});
            this.dataGridUsuario.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridUsuario.Location = new System.Drawing.Point(50, 71);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.RowHeadersWidth = 25;
            this.dataGridUsuario.Size = new System.Drawing.Size(600, 300);
            this.dataGridUsuario.TabIndex = 0;
            this.dataGridUsuario.TabStop = false;
            // 
            // colCpfUsuario
            // 
            this.colCpfUsuario.DataPropertyName = "cpfUsuario";
            this.colCpfUsuario.HeaderText = "CPF Usuário";
            this.colCpfUsuario.MaxInputLength = 14;
            this.colCpfUsuario.MinimumWidth = 130;
            this.colCpfUsuario.Name = "colCpfUsuario";
            this.colCpfUsuario.ReadOnly = true;
            this.colCpfUsuario.Width = 130;
            // 
            // colNomeUsuario
            // 
            this.colNomeUsuario.DataPropertyName = "nomeUsuario";
            this.colNomeUsuario.HeaderText = "Nome do usuário";
            this.colNomeUsuario.MaxInputLength = 200;
            this.colNomeUsuario.MinimumWidth = 258;
            this.colNomeUsuario.Name = "colNomeUsuario";
            this.colNomeUsuario.ReadOnly = true;
            this.colNomeUsuario.Width = 258;
            // 
            // colDataRegistro
            // 
            this.colDataRegistro.DataPropertyName = "dataRegistro";
            this.colDataRegistro.HeaderText = "Registro";
            this.colDataRegistro.MaxInputLength = 10;
            this.colDataRegistro.MinimumWidth = 100;
            this.colDataRegistro.Name = "colDataRegistro";
            this.colDataRegistro.ReadOnly = true;
            // 
            // colInstrucao
            // 
            this.colInstrucao.DataPropertyName = "operacao";
            this.colInstrucao.HeaderText = "Operação";
            this.colInstrucao.MaxInputLength = 10;
            this.colInstrucao.MinimumWidth = 85;
            this.colInstrucao.Name = "colInstrucao";
            this.colInstrucao.ReadOnly = true;
            this.colInstrucao.Width = 85;
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
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripHistoricoRegistro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 30);
            this.panelTop.TabIndex = 0;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de registros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripHistoricoRegistro
            // 
            this.menuStripHistoricoRegistro.BackColor = System.Drawing.Color.Transparent;
            this.menuStripHistoricoRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripHistoricoRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripHistoricoRegistro.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripHistoricoRegistro.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripHistoricoRegistro.Location = new System.Drawing.Point(0, 0);
            this.menuStripHistoricoRegistro.Name = "menuStripHistoricoRegistro";
            this.menuStripHistoricoRegistro.Size = new System.Drawing.Size(64, 30);
            this.menuStripHistoricoRegistro.TabIndex = 0;
            this.menuStripHistoricoRegistro.Text = "menuStripHistoricoRegistro";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // HistoricoRegistro
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
            this.MainMenuStrip = this.menuStripHistoricoRegistro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistoricoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricoRegistro";
            this.Activated += new System.EventHandler(this.HistoricoRegistro_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoricoRegistro_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.tabControlHistorico.ResumeLayout(false);
            this.tabMaterial.ResumeLayout(false);
            this.tabMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).EndInit();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripHistoricoRegistro.ResumeLayout(false);
            this.menuStripHistoricoRegistro.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.MenuStrip menuStripHistoricoRegistro;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabControl tabControlHistorico;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.TabPage tabMaterial;
        private System.Windows.Forms.DataGridView dataGridMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaidaMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntradaMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChaveNotaFiscal;
        private System.Windows.Forms.TextBox txtPesquisaMaterial;
        private System.Windows.Forms.Button btnPesquisarMaterial;
        private System.Windows.Forms.LinkLabel linkLimpezaMaterial;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstrucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfUsuario;
        private System.Windows.Forms.MaskedTextBox txtPesquisaUsuario;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.LinkLabel linkLimpezaUsuario;
    }
}