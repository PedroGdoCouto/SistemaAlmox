using System.ComponentModel;

namespace Interface
{
    partial class CadastroUsuario
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
                new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.linkLimpeza = new System.Windows.Forms.LinkLabel();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.txtValidaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimentoCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStripCadastro = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStripCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnCadastrar);
            this.panelMain.Controls.Add(this.linkLimpeza);
            this.panelMain.Controls.Add(this.chkAdministrador);
            this.panelMain.Controls.Add(this.txtValidaSenha);
            this.panelMain.Controls.Add(this.txtSenhaCadastro);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.txtCpfCadastro);
            this.panelMain.Controls.Add(this.txtNascimentoCadastro);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtEmailCadastro);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtNomeCadastro);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 13;
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
            this.btnCadastrar.Location = new System.Drawing.Point(250, 403);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 40);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // linkLimpeza
            // 
            this.linkLimpeza.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpeza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpeza.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpeza.Location = new System.Drawing.Point(495, 370);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(55, 23);
            this.linkLimpeza.TabIndex = 11;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar";
            this.linkLimpeza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpeza.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpeza_LinkClicked);
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.chkAdministrador.Location = new System.Drawing.Point(250, 373);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(116, 24);
            this.chkAdministrador.TabIndex = 10;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtValidaSenha
            // 
            this.txtValidaSenha.Location = new System.Drawing.Point(403, 341);
            this.txtValidaSenha.MaxLength = 200;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.Size = new System.Drawing.Size(147, 26);
            this.txtValidaSenha.TabIndex = 9;
            this.txtValidaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValidaSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(250, 341);
            this.txtSenhaCadastro.MaxLength = 200;
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(147, 26);
            this.txtSenhaCadastro.TabIndex = 8;
            this.txtSenhaCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(403, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirme a senha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(250, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Insira a senha";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCpfCadastro
            // 
            this.txtCpfCadastro.Location = new System.Drawing.Point(403, 283);
            this.txtCpfCadastro.Mask = "000,000,000-00";
            this.txtCpfCadastro.Name = "txtCpfCadastro";
            this.txtCpfCadastro.Size = new System.Drawing.Size(147, 26);
            this.txtCpfCadastro.TabIndex = 5;
            this.txtCpfCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNascimentoCadastro
            // 
            this.txtNascimentoCadastro.Location = new System.Drawing.Point(250, 283);
            this.txtNascimentoCadastro.Mask = "00/00/0000";
            this.txtNascimentoCadastro.Name = "txtNascimentoCadastro";
            this.txtNascimentoCadastro.Size = new System.Drawing.Size(147, 26);
            this.txtNascimentoCadastro.TabIndex = 4;
            this.txtNascimentoCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(403, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Insira seu CPF";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(250, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data nascimento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(250, 225);
            this.txtEmailCadastro.MaxLength = 200;
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(300, 26);
            this.txtEmailCadastro.TabIndex = 1;
            this.txtEmailCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(250, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail do usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(250, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome completo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(250, 170);
            this.txtNomeCadastro.MaxLength = 200;
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(300, 26);
            this.txtNomeCadastro.TabIndex = 0;
            this.txtNomeCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.menuStripCadastro);
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
            this.label1.Text = "Cadastrar novo usuário";
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
            // menuStripCadastro
            // 
            this.menuStripCadastro.BackColor = System.Drawing.Color.Transparent;
            this.menuStripCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripCadastro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripCadastro.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripCadastro.Location = new System.Drawing.Point(0, 0);
            this.menuStripCadastro.Name = "menuStripCadastro";
            this.menuStripCadastro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripCadastro.Size = new System.Drawing.Size(64, 30);
            this.menuStripCadastro.TabIndex = 1;
            this.menuStripCadastro.Text = "menuStripCadastro";
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
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripCadastro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroUsuario_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripCadastro.ResumeLayout(false);
            this.menuStripCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLimpeza;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.MaskedTextBox txtNascimentoCadastro;
        private System.Windows.Forms.MaskedTextBox txtCpfCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtValidaSenha;
        private System.Windows.Forms.MenuStrip menuStripCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.PictureBox picLogo;
    }
}