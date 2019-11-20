using System.ComponentModel;

namespace Interface
{
    partial class RegistraSaida
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
                new System.ComponentModel.ComponentResourceManager(typeof(RegistraSaida));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtCnpjInstituicao = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMaterial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelIdMaterial = new System.Windows.Forms.Label();
            this.txtNomeMaterial = new System.Windows.Forms.TextBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripRegistraSaida = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripRegistraSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.txtCnpjInstituicao);
            this.panelMain.Controls.Add(this.txtRazaoSocial);
            this.panelMain.Controls.Add(this.txtQuantidadeMaterial);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnRegistrar);
            this.panelMain.Controls.Add(this.labelIdMaterial);
            this.panelMain.Controls.Add(this.txtNomeMaterial);
            this.panelMain.Controls.Add(this.btnPesquisarMaterial);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
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
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // txtCnpjInstituicao
            // 
            this.txtCnpjInstituicao.Location = new System.Drawing.Point(398, 185);
            this.txtCnpjInstituicao.Mask = "00,000,000/0000-00";
            this.txtCnpjInstituicao.Name = "txtCnpjInstituicao";
            this.txtCnpjInstituicao.Size = new System.Drawing.Size(170, 26);
            this.txtCnpjInstituicao.TabIndex = 0;
            this.txtCnpjInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(200, 295);
            this.txtRazaoSocial.MaxLength = 200;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(300, 26);
            this.txtRazaoSocial.TabIndex = 4;
            this.txtRazaoSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidadeMaterial
            // 
            this.txtQuantidadeMaterial.Location = new System.Drawing.Point(506, 295);
            this.txtQuantidadeMaterial.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.txtQuantidadeMaterial.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.txtQuantidadeMaterial.Name = "txtQuantidadeMaterial";
            this.txtQuantidadeMaterial.Size = new System.Drawing.Size(94, 26);
            this.txtQuantidadeMaterial.TabIndex = 3;
            this.txtQuantidadeMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeMaterial.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.txtQuantidadeMaterial.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(200, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razão Social";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(506, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.Location = new System.Drawing.Point(250, 350);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 40);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseEnter);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // labelIdMaterial
            // 
            this.labelIdMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelIdMaterial.Location = new System.Drawing.Point(250, 324);
            this.labelIdMaterial.Name = "labelIdMaterial";
            this.labelIdMaterial.Size = new System.Drawing.Size(300, 23);
            this.labelIdMaterial.TabIndex = 0;
            this.labelIdMaterial.Text = "ID Material";
            this.labelIdMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIdMaterial.Visible = false;
            // 
            // txtNomeMaterial
            // 
            this.txtNomeMaterial.Enabled = false;
            this.txtNomeMaterial.Location = new System.Drawing.Point(200, 240);
            this.txtNomeMaterial.MaxLength = 200;
            this.txtNomeMaterial.Name = "txtNomeMaterial";
            this.txtNomeMaterial.Size = new System.Drawing.Size(400, 26);
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
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripRegistraSaida);
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
            this.label1.Text = "Registro de saídas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripRegistraSaida
            // 
            this.menuStripRegistraSaida.BackColor = System.Drawing.Color.Transparent;
            this.menuStripRegistraSaida.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripRegistraSaida.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripRegistraSaida.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripRegistraSaida.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripRegistraSaida.Location = new System.Drawing.Point(0, 0);
            this.menuStripRegistraSaida.Name = "menuStripRegistraSaida";
            this.menuStripRegistraSaida.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripRegistraSaida.Size = new System.Drawing.Size(64, 30);
            this.menuStripRegistraSaida.TabIndex = 0;
            this.menuStripRegistraSaida.Text = "menuStripRegistraSaida";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(200, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do material";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // RegistraSaida
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
            this.MainMenuStrip = this.menuStripRegistraSaida;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistraSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistraSaida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistraSaida_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.txtQuantidadeMaterial)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripRegistraSaida.ResumeLayout(false);
            this.menuStripRegistraSaida.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStripRegistraSaida;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.Button btnPesquisarMaterial;
        private System.Windows.Forms.Label labelIdMaterial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNomeMaterial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.NumericUpDown txtQuantidadeMaterial;
        private System.Windows.Forms.MaskedTextBox txtCnpjInstituicao;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
    }
}