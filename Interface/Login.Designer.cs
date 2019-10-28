using System.ComponentModel;

namespace Interface
{
    partial class Login
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
                new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovoCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecuperaSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEncerraPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobrePrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.chkExibeSenha = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(170, 215);
            this.txtSenhaLogin.MaxLength = 32;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(300, 26);
            this.txtSenhaLogin.TabIndex = 1;
            this.txtSenhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(170, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira seu e-mail";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(170, 160);
            this.txtEmailLogin.MaxLength = 200;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(300, 26);
            this.txtEmailLogin.TabIndex = 0;
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira sua senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(170, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.arquivoToolStripMenuItem, this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuNovoCadastro, this.menuRecuperaSenha, this.toolStripSeparator1, this.menuEncerraPrograma});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu", 8.999999F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // menuNovoCadastro
            // 
            this.menuNovoCadastro.Name = "menuNovoCadastro";
            this.menuNovoCadastro.Size = new System.Drawing.Size(174, 22);
            this.menuNovoCadastro.Text = "Novo Cadastro";
            this.menuNovoCadastro.Click += new System.EventHandler(this.menuNovoCadastro_Click);
            // 
            // menuRecuperaSenha
            // 
            this.menuRecuperaSenha.Name = "menuRecuperaSenha";
            this.menuRecuperaSenha.Size = new System.Drawing.Size(174, 22);
            this.menuRecuperaSenha.Text = "Recuperar Senha";
            this.menuRecuperaSenha.Click += new System.EventHandler(this.menuRecuperaSenha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // menuEncerraPrograma
            // 
            this.menuEncerraPrograma.Name = "menuEncerraPrograma";
            this.menuEncerraPrograma.Size = new System.Drawing.Size(174, 22);
            this.menuEncerraPrograma.Text = "Sair";
            this.menuEncerraPrograma.Click += new System.EventHandler(this.menuEncerraPrograma_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuSobrePrograma});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu", 8.999999F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuSobrePrograma
            // 
            this.menuSobrePrograma.Name = "menuSobrePrograma";
            this.menuSobrePrograma.Size = new System.Drawing.Size(111, 22);
            this.menuSobrePrograma.Text = "Sobre";
            this.menuSobrePrograma.Click += new System.EventHandler(this.menuSobrePrograma_Click);
            // 
            // chkExibeSenha
            // 
            this.chkExibeSenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExibeSenha.Location = new System.Drawing.Point(320, 247);
            this.chkExibeSenha.Name = "chkExibeSenha";
            this.chkExibeSenha.Size = new System.Drawing.Size(150, 24);
            this.chkExibeSenha.TabIndex = 2;
            this.chkExibeSenha.Text = "Exibir senha";
            this.chkExibeSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExibeSenha.UseVisualStyleBackColor = true;
            this.chkExibeSenha.CheckedChanged += new System.EventHandler(this.chkExibeSenha_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.chkExibeSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Painel de acesso";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRecuperaSenha;
        private System.Windows.Forms.ToolStripMenuItem menuEncerraPrograma;
        private System.Windows.Forms.ToolStripMenuItem menuSobrePrograma;
        private System.Windows.Forms.ToolStripMenuItem menuNovoCadastro;
        private System.Windows.Forms.CheckBox chkExibeSenha;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
    }
}