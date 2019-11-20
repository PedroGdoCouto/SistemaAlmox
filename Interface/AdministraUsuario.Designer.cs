using System.ComponentModel;

namespace Interface
{
    partial class AdministraUsuario
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
                new System.ComponentModel.ComponentResourceManager(typeof(AdministraUsuario));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtCpfUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimentoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.txtValidaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.linkExcluirRegistro = new System.Windows.Forms.LinkLabel();
            this.linkEditarRegistro = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripAdministraUsuario = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripAdministraUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.txtCpfUsuario);
            this.panelMain.Controls.Add(this.txtNascimentoUsuario);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.labelNomeUsuario);
            this.panelMain.Controls.Add(this.chkAdministrador);
            this.panelMain.Controls.Add(this.txtValidaSenha);
            this.panelMain.Controls.Add(this.txtSenhaUsuario);
            this.panelMain.Controls.Add(this.txtEmailUsuario);
            this.panelMain.Controls.Add(this.txtNomeUsuario);
            this.panelMain.Controls.Add(this.linkExcluirRegistro);
            this.panelMain.Controls.Add(this.linkEditarRegistro);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnConfirmar);
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
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // txtCpfUsuario
            // 
            this.txtCpfUsuario.Enabled = false;
            this.txtCpfUsuario.Location = new System.Drawing.Point(403, 293);
            this.txtCpfUsuario.Name = "txtCpfUsuario";
            this.txtCpfUsuario.Size = new System.Drawing.Size(147, 26);
            this.txtCpfUsuario.TabIndex = 3;
            this.txtCpfUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNascimentoUsuario
            // 
            this.txtNascimentoUsuario.Enabled = false;
            this.txtNascimentoUsuario.Location = new System.Drawing.Point(250, 293);
            this.txtNascimentoUsuario.Name = "txtNascimentoUsuario";
            this.txtNascimentoUsuario.Size = new System.Drawing.Size(147, 26);
            this.txtNascimentoUsuario.TabIndex = 2;
            this.txtNascimentoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(403, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Confirme a senha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(250, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Insira a senha";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(403, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "CPF do usuário";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(250, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data nascimento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(250, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail do usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelNomeUsuario.Location = new System.Drawing.Point(250, 157);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(300, 23);
            this.labelNomeUsuario.TabIndex = 0;
            this.labelNomeUsuario.Text = "Usuário";
            this.labelNomeUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.chkAdministrador.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.chkAdministrador.Location = new System.Drawing.Point(250, 377);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(116, 23);
            this.chkAdministrador.TabIndex = 6;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAdministrador.UseVisualStyleBackColor = false;
            this.chkAdministrador.Visible = false;
            // 
            // txtValidaSenha
            // 
            this.txtValidaSenha.Enabled = false;
            this.txtValidaSenha.Location = new System.Drawing.Point(403, 348);
            this.txtValidaSenha.MaxLength = 50;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.Size = new System.Drawing.Size(147, 26);
            this.txtValidaSenha.TabIndex = 5;
            this.txtValidaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValidaSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Enabled = false;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(250, 348);
            this.txtSenhaUsuario.MaxLength = 50;
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(147, 26);
            this.txtSenhaUsuario.TabIndex = 4;
            this.txtSenhaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmailUsuario.Enabled = false;
            this.txtEmailUsuario.Location = new System.Drawing.Point(250, 238);
            this.txtEmailUsuario.MaxLength = 200;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtEmailUsuario.TabIndex = 1;
            this.txtEmailUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailUsuario.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtEmailUsuario_KeyPress);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeUsuario.Enabled = false;
            this.txtNomeUsuario.Location = new System.Drawing.Point(250, 183);
            this.txtNomeUsuario.MaxLength = 200;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtNomeUsuario.TabIndex = 0;
            this.txtNomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkExcluirRegistro
            // 
            this.linkExcluirRegistro.BackColor = System.Drawing.Color.Transparent;
            this.linkExcluirRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkExcluirRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkExcluirRegistro.LinkColor = System.Drawing.Color.Red;
            this.linkExcluirRegistro.Location = new System.Drawing.Point(440, 377);
            this.linkExcluirRegistro.Name = "linkExcluirRegistro";
            this.linkExcluirRegistro.Size = new System.Drawing.Size(110, 23);
            this.linkExcluirRegistro.TabIndex = 7;
            this.linkExcluirRegistro.TabStop = true;
            this.linkExcluirRegistro.Text = "Excluir registro";
            this.linkExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkExcluirRegistro.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkExcluirRegistro.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExcluirRegistro_LinkClicked);
            // 
            // linkEditarRegistro
            // 
            this.linkEditarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.linkEditarRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkEditarRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkEditarRegistro.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkEditarRegistro.Location = new System.Drawing.Point(250, 377);
            this.linkEditarRegistro.Name = "linkEditarRegistro";
            this.linkEditarRegistro.Size = new System.Drawing.Size(100, 23);
            this.linkEditarRegistro.TabIndex = 6;
            this.linkEditarRegistro.TabStop = true;
            this.linkEditarRegistro.Text = "Editar registro";
            this.linkEditarRegistro.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkEditarRegistro.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditarRegistro_LinkClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmar.Location = new System.Drawing.Point(250, 403);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 40);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseEnter += new System.EventHandler(this.btnConfirmar_MouseEnter);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripAdministraUsuario);
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
            this.label1.Text = "Gerenciar registros de usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripAdministraUsuario
            // 
            this.menuStripAdministraUsuario.BackColor = System.Drawing.Color.Transparent;
            this.menuStripAdministraUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripAdministraUsuario.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripAdministraUsuario.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripAdministraUsuario.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripAdministraUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdministraUsuario.Name = "menuStripAdministraUsuario";
            this.menuStripAdministraUsuario.Size = new System.Drawing.Size(64, 30);
            this.menuStripAdministraUsuario.TabIndex = 0;
            this.menuStripAdministraUsuario.Text = "menuStripAdministraUsuario";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // AdministraUsuario
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripAdministraUsuario;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministraUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministraUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministraUsuario_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripAdministraUsuario.ResumeLayout(false);
            this.menuStripAdministraUsuario.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStripAdministraUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel linkEditarRegistro;
        private System.Windows.Forms.LinkLabel linkExcluirRegistro;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtValidaSenha;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCpfUsuario;
        private System.Windows.Forms.MaskedTextBox txtNascimentoUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labelNomeUsuario;
    }
}