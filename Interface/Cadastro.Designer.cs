using System.ComponentModel;

namespace Interface
{
    partial class Cadastro
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
                new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtValidaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkExibeSenha = new System.Windows.Forms.CheckBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobrePrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(170, 105);
            this.txtEmailCadastro.MaxLength = 200;
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(300, 26);
            this.txtEmailCadastro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(170, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insira seu e-mail";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(170, 160);
            this.txtNomeUsuario.MaxLength = 200;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome completo";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(170, 277);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(147, 40);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(170, 215);
            this.txtSenhaCadastro.MaxLength = 32;
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(147, 26);
            this.txtSenhaCadastro.TabIndex = 2;
            this.txtSenhaCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // txtValidaSenha
            // 
            this.txtValidaSenha.Location = new System.Drawing.Point(323, 215);
            this.txtValidaSenha.MaxLength = 32;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.Size = new System.Drawing.Size(147, 26);
            this.txtValidaSenha.TabIndex = 3;
            this.txtValidaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValidaSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(170, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Insira a senha";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(323, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirme a senha";
            // 
            // chkExibeSenha
            // 
            this.chkExibeSenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExibeSenha.Location = new System.Drawing.Point(320, 247);
            this.chkExibeSenha.Name = "chkExibeSenha";
            this.chkExibeSenha.Size = new System.Drawing.Size(150, 24);
            this.chkExibeSenha.TabIndex = 4;
            this.chkExibeSenha.Text = "Exibir senha";
            this.chkExibeSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExibeSenha.UseVisualStyleBackColor = true;
            this.chkExibeSenha.CheckedChanged += new System.EventHandler(this.chkExibeSenha_CheckedChanged);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(323, 277);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(147, 40);
            this.btnCancela.TabIndex = 10;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.chkExibeSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValidaSenha);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailCadastro);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Novo cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.CheckBox chkExibeSenha;
        private System.Windows.Forms.TextBox txtValidaSenha;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSobrePrograma;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}