using System.ComponentModel;

namespace Interface
{
    partial class PainelUsuario
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
                new System.ComponentModel.ComponentResourceManager(typeof(PainelUsuario));
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkLimpeza = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoPesquisaLocal = new System.Windows.Forms.RadioButton();
            this.rdoPesquisaNome = new System.Windows.Forms.RadioButton();
            this.rdoPesquisaCodigo = new System.Windows.Forms.RadioButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridMaterial = new System.Windows.Forms.DataGridView();
            this.colIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.txtPesquisaMaterial = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStripUsuario = new System.Windows.Forms.MenuStrip();
            this.menuToolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEncerraSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.linkLimpeza);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.rdoPesquisaLocal);
            this.panelMain.Controls.Add(this.rdoPesquisaNome);
            this.panelMain.Controls.Add(this.rdoPesquisaCodigo);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.dataGridMaterial);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.btnPesquisarMaterial);
            this.panelMain.Controls.Add(this.txtPesquisaMaterial);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // linkLimpeza
            // 
            this.linkLimpeza.BackColor = System.Drawing.Color.Transparent;
            this.linkLimpeza.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpeza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpeza.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpeza.Location = new System.Drawing.Point(640, 542);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(110, 23);
            this.linkLimpeza.TabIndex = 12;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar pesquisa";
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtro de busca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoPesquisaLocal
            // 
            this.rdoPesquisaLocal.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.rdoPesquisaLocal.Location = new System.Drawing.Point(234, 113);
            this.rdoPesquisaLocal.Name = "rdoPesquisaLocal";
            this.rdoPesquisaLocal.Size = new System.Drawing.Size(60, 23);
            this.rdoPesquisaLocal.TabIndex = 10;
            this.rdoPesquisaLocal.Text = "Local";
            this.rdoPesquisaLocal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoPesquisaLocal.UseVisualStyleBackColor = true;
            // 
            // rdoPesquisaNome
            // 
            this.rdoPesquisaNome.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.rdoPesquisaNome.Location = new System.Drawing.Point(300, 113);
            this.rdoPesquisaNome.Name = "rdoPesquisaNome";
            this.rdoPesquisaNome.Size = new System.Drawing.Size(65, 23);
            this.rdoPesquisaNome.TabIndex = 9;
            this.rdoPesquisaNome.Text = "Nome";
            this.rdoPesquisaNome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoPesquisaNome.UseVisualStyleBackColor = true;
            // 
            // rdoPesquisaCodigo
            // 
            this.rdoPesquisaCodigo.Checked = true;
            this.rdoPesquisaCodigo.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.rdoPesquisaCodigo.Location = new System.Drawing.Point(156, 113);
            this.rdoPesquisaCodigo.Name = "rdoPesquisaCodigo";
            this.rdoPesquisaCodigo.Size = new System.Drawing.Size(72, 23);
            this.rdoPesquisaCodigo.TabIndex = 8;
            this.rdoPesquisaCodigo.TabStop = true;
            this.rdoPesquisaCodigo.Text = "Código";
            this.rdoPesquisaCodigo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoPesquisaCodigo.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(798, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(250, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Copyright - Pedro Couto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
                this.colIdMaterial, this.colNomeMaterial, this.colQuantidadeMaterial, this.colDescricaoMaterial,
                this.colLocalizacaoMaterial
            });
            this.dataGridMaterial.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMaterial.Location = new System.Drawing.Point(50, 139);
            this.dataGridMaterial.Name = "dataGridMaterial";
            this.dataGridMaterial.ReadOnly = true;
            this.dataGridMaterial.RowHeadersWidth = 25;
            this.dataGridMaterial.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMaterial.Size = new System.Drawing.Size(700, 400);
            this.dataGridMaterial.TabIndex = 7;
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
            this.colNomeMaterial.MinimumWidth = 530;
            this.colNomeMaterial.Name = "colNomeMaterial";
            this.colNomeMaterial.ReadOnly = true;
            this.colNomeMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNomeMaterial.Width = 530;
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
            // colDescricaoMaterial
            // 
            this.colDescricaoMaterial.DataPropertyName = "descricaoMaterial";
            this.colDescricaoMaterial.HeaderText = "Descrição";
            this.colDescricaoMaterial.MaxInputLength = 200;
            this.colDescricaoMaterial.MinimumWidth = 575;
            this.colDescricaoMaterial.Name = "colDescricaoMaterial";
            this.colDescricaoMaterial.ReadOnly = true;
            this.colDescricaoMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescricaoMaterial.Width = 575;
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
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
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
            this.btnPesquisarMaterial.Location = new System.Drawing.Point(724, 107);
            this.btnPesquisarMaterial.Name = "btnPesquisarMaterial";
            this.btnPesquisarMaterial.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarMaterial.TabIndex = 0;
            this.btnPesquisarMaterial.TabStop = false;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // txtPesquisaMaterial
            // 
            this.txtPesquisaMaterial.Location = new System.Drawing.Point(558, 107);
            this.txtPesquisaMaterial.MaxLength = 200;
            this.txtPesquisaMaterial.Name = "txtPesquisaMaterial";
            this.txtPesquisaMaterial.Size = new System.Drawing.Size(160, 26);
            this.txtPesquisaMaterial.TabIndex = 0;
            this.txtPesquisaMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.menuStripUsuario);
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
            this.label1.Text = "Nome do usuário";
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
            // menuStripUsuario
            // 
            this.menuStripUsuario.BackColor = System.Drawing.Color.Transparent;
            this.menuStripUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripUsuario.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolSistema, this.menuToolSobre});
            this.menuStripUsuario.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuStripUsuario.Name = "menuStripUsuario";
            this.menuStripUsuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripUsuario.Size = new System.Drawing.Size(134, 30);
            this.menuStripUsuario.TabIndex = 0;
            this.menuStripUsuario.Text = "menuStripUsuario";
            // 
            // menuToolSistema
            // 
            this.menuToolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuEncerraSessao});
            this.menuToolSistema.ForeColor = System.Drawing.Color.White;
            this.menuToolSistema.Name = "menuToolSistema";
            this.menuToolSistema.Size = new System.Drawing.Size(70, 26);
            this.menuToolSistema.Text = "&Sistema";
            // 
            // menuEncerraSessao
            // 
            this.menuEncerraSessao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuEncerraSessao.ForeColor = System.Drawing.Color.White;
            this.menuEncerraSessao.Name = "menuEncerraSessao";
            this.menuEncerraSessao.Size = new System.Drawing.Size(176, 22);
            this.menuEncerraSessao.Text = "Encerrar &sessão";
            this.menuEncerraSessao.Click += new System.EventHandler(this.menuEncerraSessao_Click);
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "Sobr&e";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // PainelUsuario
            // 
            this.AcceptButton = this.btnPesquisarMaterial;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripUsuario;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PainelUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PainelUsuario_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripUsuario.ResumeLayout(false);
            this.menuStripUsuario.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPesquisaMaterial;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStripUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoPesquisaCodigo;
        private System.Windows.Forms.RadioButton rdoPesquisaNome;
        private System.Windows.Forms.RadioButton rdoPesquisaLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeMaterial;
        private System.Windows.Forms.DataGridView dataGridMaterial;
        private System.Windows.Forms.Button btnPesquisarMaterial;
        private System.Windows.Forms.LinkLabel linkLimpeza;
        private System.Windows.Forms.ToolStripMenuItem menuEncerraSessao;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.ToolStripMenuItem menuToolSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMaterial;
    }
}