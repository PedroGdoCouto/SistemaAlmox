using System.ComponentModel;

namespace Interface
{
    partial class RegistraEntrada
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
                new System.ComponentModel.ComponentResourceManager(typeof(RegistraEntrada));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtLocalizacaoMaterial = new System.Windows.Forms.TextBox();
            this.txtChaveNotaFiscal = new System.Windows.Forms.TextBox();
            this.labelIdMaterial = new System.Windows.Forms.Label();
            this.txtQuantidadeMaterial = new System.Windows.Forms.NumericUpDown();
            this.txtNomeMaterial = new System.Windows.Forms.TextBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.txtPesquisaMaterial = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripRegistroEntrada = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLimpeza = new System.Windows.Forms.LinkLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripRegistroEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.linkLimpeza);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnConfirmar);
            this.panelMain.Controls.Add(this.txtLocalizacaoMaterial);
            this.panelMain.Controls.Add(this.txtChaveNotaFiscal);
            this.panelMain.Controls.Add(this.labelIdMaterial);
            this.panelMain.Controls.Add(this.txtQuantidadeMaterial);
            this.panelMain.Controls.Add(this.txtNomeMaterial);
            this.panelMain.Controls.Add(this.btnPesquisarMaterial);
            this.panelMain.Controls.Add(this.txtPesquisaMaterial);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = ((System.Drawing.Image) (resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(687, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmar.Location = new System.Drawing.Point(250, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 40);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Registrar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtLocalizacaoMaterial
            // 
            this.txtLocalizacaoMaterial.Location = new System.Drawing.Point(500, 295);
            this.txtLocalizacaoMaterial.MaxLength = 10;
            this.txtLocalizacaoMaterial.Name = "txtLocalizacaoMaterial";
            this.txtLocalizacaoMaterial.Size = new System.Drawing.Size(100, 26);
            this.txtLocalizacaoMaterial.TabIndex = 5;
            this.txtLocalizacaoMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChaveNotaFiscal
            // 
            this.txtChaveNotaFiscal.Location = new System.Drawing.Point(200, 295);
            this.txtChaveNotaFiscal.MaxLength = 44;
            this.txtChaveNotaFiscal.Name = "txtChaveNotaFiscal";
            this.txtChaveNotaFiscal.Size = new System.Drawing.Size(294, 26);
            this.txtChaveNotaFiscal.TabIndex = 4;
            this.txtChaveNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIdMaterial
            // 
            this.labelIdMaterial.Location = new System.Drawing.Point(250, 324);
            this.labelIdMaterial.Name = "labelIdMaterial";
            this.labelIdMaterial.Size = new System.Drawing.Size(300, 23);
            this.labelIdMaterial.TabIndex = 0;
            this.labelIdMaterial.Text = "ID Material";
            this.labelIdMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantidadeMaterial
            // 
            this.txtQuantidadeMaterial.Location = new System.Drawing.Point(500, 240);
            this.txtQuantidadeMaterial.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.txtQuantidadeMaterial.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.txtQuantidadeMaterial.Name = "txtQuantidadeMaterial";
            this.txtQuantidadeMaterial.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidadeMaterial.TabIndex = 3;
            this.txtQuantidadeMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeMaterial.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.txtQuantidadeMaterial.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // txtNomeMaterial
            // 
            this.txtNomeMaterial.Enabled = false;
            this.txtNomeMaterial.Location = new System.Drawing.Point(200, 239);
            this.txtNomeMaterial.MaxLength = 200;
            this.txtNomeMaterial.Name = "txtNomeMaterial";
            this.txtNomeMaterial.Size = new System.Drawing.Size(294, 26);
            this.txtNomeMaterial.TabIndex = 2;
            this.txtNomeMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisarMaterial
            // 
            this.btnPesquisarMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarMaterial.FlatAppearance.BorderSize = 0;
            this.btnPesquisarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisarMaterial.Image =
                ((System.Drawing.Image) (resources.GetObject("btnPesquisarMaterial.Image")));
            this.btnPesquisarMaterial.Location = new System.Drawing.Point(574, 185);
            this.btnPesquisarMaterial.Name = "btnPesquisarMaterial";
            this.btnPesquisarMaterial.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarMaterial.TabIndex = 1;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = false;
            // 
            // txtPesquisaMaterial
            // 
            this.txtPesquisaMaterial.Location = new System.Drawing.Point(398, 185);
            this.txtPesquisaMaterial.MaxLength = 200;
            this.txtPesquisaMaterial.Name = "txtPesquisaMaterial";
            this.txtPesquisaMaterial.Size = new System.Drawing.Size(170, 26);
            this.txtPesquisaMaterial.TabIndex = 0;
            this.txtPesquisaMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripRegistroEntrada);
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
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de entradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripRegistroEntrada
            // 
            this.menuStripRegistroEntrada.BackColor = System.Drawing.Color.Transparent;
            this.menuStripRegistroEntrada.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripRegistroEntrada.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripRegistroEntrada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripRegistroEntrada.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripRegistroEntrada.Location = new System.Drawing.Point(0, 0);
            this.menuStripRegistroEntrada.Name = "menuStripRegistroEntrada";
            this.menuStripRegistroEntrada.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripRegistroEntrada.Size = new System.Drawing.Size(64, 30);
            this.menuStripRegistroEntrada.TabIndex = 0;
            this.menuStripRegistroEntrada.Text = "menuStripRegistroEntrada";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do material";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(200, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número de chave NF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(500, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Localização";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(500, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // linkLimpeza
            // 
            this.linkLimpeza.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpeza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpeza.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpeza.Location = new System.Drawing.Point(545, 324);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(55, 23);
            this.linkLimpeza.TabIndex = 6;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar";
            this.linkLimpeza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            // 
            // RegistraEntrada
            // 
            this.AcceptButton = this.btnPesquisarMaterial;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripRegistroEntrada;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistraEntrada";
            this.Text = "RegistraEntrada";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripRegistroEntrada.ResumeLayout(false);
            this.menuStripRegistroEntrada.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStripRegistroEntrada;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.TextBox txtPesquisaMaterial;
        private System.Windows.Forms.Button btnPesquisarMaterial;
        private System.Windows.Forms.Label labelIdMaterial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalizacaoMaterial;
        private System.Windows.Forms.TextBox txtChaveNotaFiscal;
        private System.Windows.Forms.TextBox txtNomeMaterial;
        private System.Windows.Forms.NumericUpDown txtQuantidadeMaterial;
        private System.Windows.Forms.LinkLabel linkLimpeza;
    }
}