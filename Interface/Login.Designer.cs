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
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.linkRecuperaAcesso = new System.Windows.Forms.LinkLabel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.chkExibeSenha = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.menuToolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinalizarPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.linkRecuperaAcesso);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtSenhaLogin);
            this.panelMain.Controls.Add(this.txtEmailLogin);
            this.panelMain.Controls.Add(this.chkExibeSenha);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
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
            this.picLogo.Location = new System.Drawing.Point(250, 140);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // linkRecuperaAcesso
            // 
            this.linkRecuperaAcesso.BackColor = System.Drawing.Color.Transparent;
            this.linkRecuperaAcesso.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.linkRecuperaAcesso.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRecuperaAcesso.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkRecuperaAcesso.Location = new System.Drawing.Point(442, 337);
            this.linkRecuperaAcesso.Name = "linkRecuperaAcesso";
            this.linkRecuperaAcesso.Size = new System.Drawing.Size(108, 23);
            this.linkRecuperaAcesso.TabIndex = 3;
            this.linkRecuperaAcesso.TabStop = true;
            this.linkRecuperaAcesso.Text = "Esqueci a senha";
            this.linkRecuperaAcesso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkRecuperaAcesso.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkRecuperaAcesso.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperaAcesso_LinkClicked);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(798, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(250, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Copyright - Pedro Couto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(250, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Insira sua senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(250, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insira seu e-mail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(250, 308);
            this.txtSenhaLogin.MaxLength = 50;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(300, 26);
            this.txtSenhaLogin.TabIndex = 1;
            this.txtSenhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(250, 253);
            this.txtEmailLogin.MaxLength = 200;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(300, 26);
            this.txtEmailLogin.TabIndex = 0;
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkExibeSenha
            // 
            this.chkExibeSenha.BackColor = System.Drawing.Color.Transparent;
            this.chkExibeSenha.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkExibeSenha.Location = new System.Drawing.Point(250, 340);
            this.chkExibeSenha.Name = "chkExibeSenha";
            this.chkExibeSenha.Size = new System.Drawing.Size(112, 24);
            this.chkExibeSenha.TabIndex = 2;
            this.chkExibeSenha.Text = "Exibir senha";
            this.chkExibeSenha.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExibeSenha.UseVisualStyleBackColor = false;
            this.chkExibeSenha.CheckedChanged += new System.EventHandler(this.chkExibeSenha_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Green;
            this.btnLogin.Location = new System.Drawing.Point(250, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.menuStripLogin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.label1.Text = "Nome do programa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            // menuStripLogin
            // 
            this.menuStripLogin.AutoSize = false;
            this.menuStripLogin.BackColor = System.Drawing.Color.Transparent;
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripLogin.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolSistema, this.menuToolSobre});
            this.menuStripLogin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripLogin.Location = new System.Drawing.Point(0, 0);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripLogin.Size = new System.Drawing.Size(134, 30);
            this.menuStripLogin.TabIndex = 0;
            this.menuStripLogin.Text = "menuStripLogin";
            // 
            // menuToolSistema
            // 
            this.menuToolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuFinalizarPrograma});
            this.menuToolSistema.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuToolSistema.ForeColor = System.Drawing.Color.White;
            this.menuToolSistema.Name = "menuToolSistema";
            this.menuToolSistema.Size = new System.Drawing.Size(70, 26);
            this.menuToolSistema.Text = "&Sistema";
            // 
            // menuFinalizarPrograma
            // 
            this.menuFinalizarPrograma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuFinalizarPrograma.ForeColor = System.Drawing.Color.White;
            this.menuFinalizarPrograma.Name = "menuFinalizarPrograma";
            this.menuFinalizarPrograma.Size = new System.Drawing.Size(152, 22);
            this.menuFinalizarPrograma.Text = "&Finalizar";
            this.menuFinalizarPrograma.Click += new System.EventHandler(this.menuFinalizarPrograma_Click);
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "Sobr&e";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.CheckBox chkExibeSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.ToolStripMenuItem menuFinalizarPrograma;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.ToolStripMenuItem menuToolSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.LinkLabel linkRecuperaAcesso;
        private System.Windows.Forms.PictureBox picLogo;
    }
}