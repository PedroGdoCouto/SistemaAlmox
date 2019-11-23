using System.ComponentModel;

namespace Interface
{
    partial class Resgate
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
                new System.ComponentModel.ComponentResourceManager(typeof(Resgate));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkExibeSenha = new System.Windows.Forms.CheckBox();
            this.txtValidaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaResgate = new System.Windows.Forms.TextBox();
            this.linkLimpeza = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpfResgate = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimentoResgate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmailResgate = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripResgate = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStripResgate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.chkExibeSenha);
            this.panelMain.Controls.Add(this.txtValidaSenha);
            this.panelMain.Controls.Add(this.txtSenhaResgate);
            this.panelMain.Controls.Add(this.linkLimpeza);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtCpfResgate);
            this.panelMain.Controls.Add(this.txtNascimentoResgate);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.txtEmailResgate);
            this.panelMain.Controls.Add(this.btnConfirma);
            this.panelMain.Controls.Add(this.panelBottom);
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(403, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirme a senha";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(200, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Insira a nova senha";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkExibeSenha
            // 
            this.chkExibeSenha.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.chkExibeSenha.Location = new System.Drawing.Point(200, 371);
            this.chkExibeSenha.Name = "chkExibeSenha";
            this.chkExibeSenha.Size = new System.Drawing.Size(112, 23);
            this.chkExibeSenha.TabIndex = 5;
            this.chkExibeSenha.Text = "Exibe senha";
            this.chkExibeSenha.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExibeSenha.UseVisualStyleBackColor = true;
            this.chkExibeSenha.CheckedChanged += new System.EventHandler(this.chkExibeSenha_CheckedChanged);
            // 
            // txtValidaSenha
            // 
            this.txtValidaSenha.Location = new System.Drawing.Point(403, 342);
            this.txtValidaSenha.MaxLength = 50;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.Size = new System.Drawing.Size(197, 26);
            this.txtValidaSenha.TabIndex = 4;
            this.txtValidaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValidaSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaResgate
            // 
            this.txtSenhaResgate.Location = new System.Drawing.Point(200, 342);
            this.txtSenhaResgate.MaxLength = 50;
            this.txtSenhaResgate.Name = "txtSenhaResgate";
            this.txtSenhaResgate.Size = new System.Drawing.Size(197, 26);
            this.txtSenhaResgate.TabIndex = 3;
            this.txtSenhaResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaResgate.UseSystemPasswordChar = true;
            // 
            // linkLimpeza
            // 
            this.linkLimpeza.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpeza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpeza.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpeza.Location = new System.Drawing.Point(545, 371);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(55, 23);
            this.linkLimpeza.TabIndex = 6;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar";
            this.linkLimpeza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpeza.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpeza_LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(403, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Insira seu CPF";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(250, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data nascimento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCpfResgate
            // 
            this.txtCpfResgate.Location = new System.Drawing.Point(403, 287);
            this.txtCpfResgate.Mask = "000,000,000-00";
            this.txtCpfResgate.Name = "txtCpfResgate";
            this.txtCpfResgate.Size = new System.Drawing.Size(147, 26);
            this.txtCpfResgate.TabIndex = 2;
            this.txtCpfResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNascimentoResgate
            // 
            this.txtNascimentoResgate.Location = new System.Drawing.Point(250, 287);
            this.txtNascimentoResgate.Mask = "00/00/0000";
            this.txtNascimentoResgate.Name = "txtNascimentoResgate";
            this.txtNascimentoResgate.Size = new System.Drawing.Size(147, 26);
            this.txtNascimentoResgate.TabIndex = 1;
            this.txtNascimentoResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNascimentoResgate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insira o e-mail cadastrado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // txtEmailResgate
            // 
            this.txtEmailResgate.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmailResgate.Location = new System.Drawing.Point(200, 232);
            this.txtEmailResgate.MaxLength = 200;
            this.txtEmailResgate.Name = "txtEmailResgate";
            this.txtEmailResgate.Size = new System.Drawing.Size(400, 26);
            this.txtEmailResgate.TabIndex = 0;
            this.txtEmailResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailResgate.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtEmailResgate_KeyPress);
            // 
            // btnConfirma
            // 
            this.btnConfirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.ForeColor = System.Drawing.Color.Green;
            this.btnConfirma.Location = new System.Drawing.Point(250, 400);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(147, 40);
            this.btnConfirma.TabIndex = 7;
            this.btnConfirma.Text = "Recuperar acesso";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            this.btnConfirma.MouseEnter += new System.EventHandler(this.btnConfirma_MouseEnter);
            this.btnConfirma.MouseLeave += new System.EventHandler(this.btnConfirma_MouseLeave);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(798, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(250, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Copyright - Pedro Couto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripResgate);
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
            this.label1.Text = "Recuperação de acesso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripResgate
            // 
            this.menuStripResgate.AutoSize = false;
            this.menuStripResgate.BackColor = System.Drawing.Color.Transparent;
            this.menuStripResgate.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripResgate.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripResgate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuToolSobre});
            this.menuStripResgate.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripResgate.Location = new System.Drawing.Point(0, 0);
            this.menuStripResgate.Name = "menuStripResgate";
            this.menuStripResgate.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripResgate.Size = new System.Drawing.Size(134, 30);
            this.menuStripResgate.TabIndex = 0;
            this.menuStripResgate.Text = "menuStripResgate";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // Resgate
            // 
            this.AcceptButton = this.btnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Resgate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resgate_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.menuStripResgate.ResumeLayout(false);
            this.menuStripResgate.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStripResgate;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtEmailResgate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLimpeza;
        private System.Windows.Forms.MaskedTextBox txtCpfResgate;
        private System.Windows.Forms.MaskedTextBox txtNascimentoResgate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaResgate;
        private System.Windows.Forms.CheckBox chkExibeSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValidaSenha;
        private System.Windows.Forms.PictureBox picLogo;
    }
}