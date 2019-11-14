using System.ComponentModel;

namespace Interface
{
    partial class CadastroMaterial
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
                new System.ComponentModel.ComponentResourceManager(typeof(CadastroMaterial));
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkLimpeza = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalizacaoMaterial = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMaterial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMaterial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripCadastroMaterial = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripCadastroMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.linkLimpeza);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtLocalizacaoMaterial);
            this.panelMain.Controls.Add(this.txtQuantidadeMaterial);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtDescricaoMaterial);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtNomeMaterial);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnCadastrar);
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
            this.linkLimpeza.Location = new System.Drawing.Point(495, 326);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(55, 23);
            this.linkLimpeza.TabIndex = 4;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar";
            this.linkLimpeza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpeza.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpeza_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(403, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Localização";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(250, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtLocalizacaoMaterial
            // 
            this.txtLocalizacaoMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizacaoMaterial.Location = new System.Drawing.Point(403, 297);
            this.txtLocalizacaoMaterial.MaxLength = 200;
            this.txtLocalizacaoMaterial.Name = "txtLocalizacaoMaterial";
            this.txtLocalizacaoMaterial.Size = new System.Drawing.Size(147, 26);
            this.txtLocalizacaoMaterial.TabIndex = 3;
            this.txtLocalizacaoMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLocalizacaoMaterial.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtLocalizacaoMaterial_KeyPress);
            // 
            // txtQuantidadeMaterial
            // 
            this.txtQuantidadeMaterial.Location = new System.Drawing.Point(250, 297);
            this.txtQuantidadeMaterial.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.txtQuantidadeMaterial.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.txtQuantidadeMaterial.Name = "txtQuantidadeMaterial";
            this.txtQuantidadeMaterial.Size = new System.Drawing.Size(147, 26);
            this.txtQuantidadeMaterial.TabIndex = 2;
            this.txtQuantidadeMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeMaterial.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.txtQuantidadeMaterial.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(250, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição do material";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescricaoMaterial
            // 
            this.txtDescricaoMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoMaterial.Location = new System.Drawing.Point(250, 242);
            this.txtDescricaoMaterial.MaxLength = 200;
            this.txtDescricaoMaterial.Name = "txtDescricaoMaterial";
            this.txtDescricaoMaterial.Size = new System.Drawing.Size(300, 26);
            this.txtDescricaoMaterial.TabIndex = 1;
            this.txtDescricaoMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(250, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do material";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNomeMaterial
            // 
            this.txtNomeMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMaterial.Location = new System.Drawing.Point(250, 187);
            this.txtNomeMaterial.MaxLength = 200;
            this.txtNomeMaterial.Name = "txtNomeMaterial";
            this.txtNomeMaterial.Size = new System.Drawing.Size(300, 26);
            this.txtNomeMaterial.TabIndex = 0;
            this.txtNomeMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrar.Location = new System.Drawing.Point(250, 352);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 40);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripCadastroMaterial);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 30);
            this.panelTop.TabIndex = 0;
            // 
            // btnMinimize
            // 
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
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
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
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.label1.Text = "Cadastrar material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripCadastroMaterial
            // 
            this.menuStripCadastroMaterial.BackColor = System.Drawing.Color.Transparent;
            this.menuStripCadastroMaterial.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripCadastroMaterial.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripCadastroMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolSobre});
            this.menuStripCadastroMaterial.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripCadastroMaterial.Location = new System.Drawing.Point(0, 0);
            this.menuStripCadastroMaterial.Name = "menuStripCadastroMaterial";
            this.menuStripCadastroMaterial.Size = new System.Drawing.Size(64, 30);
            this.menuStripCadastroMaterial.TabIndex = 0;
            this.menuStripCadastroMaterial.Text = "menuStripCadastroMaterial";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
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
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // CadastroMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripCadastroMaterial;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroMaterial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroMaterial_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripCadastroMaterial.ResumeLayout(false);
            this.menuStripCadastroMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStripCadastroMaterial;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLimpeza;
        private System.Windows.Forms.TextBox txtLocalizacaoMaterial;
        private System.Windows.Forms.NumericUpDown txtQuantidadeMaterial;
        private System.Windows.Forms.PictureBox picLogo;
    }
}