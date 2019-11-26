using System.ComponentModel;

namespace Interface
{
    partial class AdministraInstituicao
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
                new System.ComponentModel.ComponentResourceManager(typeof(AdministraInstituicao));
            this.panelMain = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstadoEndereco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCepEndereco = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairroEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.NumericUpDown();
            this.txtLogradouroEndereco = new System.Windows.Forms.TextBox();
            this.linkEditarRegistro = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.linkExcluirRegistro = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnpjInstituicao = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocialInstituicao = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripAdministraInstituicao = new System.Windows.Forms.MenuStrip();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.txtNumeroEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStripAdministraInstituicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.cmbEstadoEndereco);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.txtCepEndereco);
            this.panelMain.Controls.Add(this.txtCidadeEndereco);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.txtBairroEndereco);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtNumeroEndereco);
            this.panelMain.Controls.Add(this.txtLogradouroEndereco);
            this.panelMain.Controls.Add(this.linkEditarRegistro);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Controls.Add(this.linkExcluirRegistro);
            this.panelMain.Controls.Add(this.btnCancelar);
            this.panelMain.Controls.Add(this.btnConfirmar);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtCnpjInstituicao);
            this.panelMain.Controls.Add(this.txtRazaoSocialInstituicao);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(403, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "CNPJ Instituição";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(250, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "CEP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(480, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbEstadoEndereco
            // 
            this.cmbEstadoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEndereco.Enabled = false;
            this.cmbEstadoEndereco.FormattingEnabled = true;
            this.cmbEstadoEndereco.Items.AddRange(new object[]
            {
                "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI",
                "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"
            });
            this.cmbEstadoEndereco.Location = new System.Drawing.Point(480, 318);
            this.cmbEstadoEndereco.Name = "cmbEstadoEndereco";
            this.cmbEstadoEndereco.Size = new System.Drawing.Size(70, 28);
            this.cmbEstadoEndereco.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(250, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cidade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCepEndereco
            // 
            this.txtCepEndereco.Enabled = false;
            this.txtCepEndereco.Location = new System.Drawing.Point(250, 375);
            this.txtCepEndereco.Name = "txtCepEndereco";
            this.txtCepEndereco.Size = new System.Drawing.Size(147, 26);
            this.txtCepEndereco.TabIndex = 6;
            this.txtCepEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCidadeEndereco
            // 
            this.txtCidadeEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeEndereco.Enabled = false;
            this.txtCidadeEndereco.Location = new System.Drawing.Point(250, 320);
            this.txtCidadeEndereco.MaxLength = 200;
            this.txtCidadeEndereco.Name = "txtCidadeEndereco";
            this.txtCidadeEndereco.Size = new System.Drawing.Size(224, 26);
            this.txtCidadeEndereco.TabIndex = 4;
            this.txtCidadeEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(326, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bairro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBairroEndereco
            // 
            this.txtBairroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroEndereco.Enabled = false;
            this.txtBairroEndereco.Location = new System.Drawing.Point(326, 265);
            this.txtBairroEndereco.MaxLength = 200;
            this.txtBairroEndereco.Name = "txtBairroEndereco";
            this.txtBairroEndereco.Size = new System.Drawing.Size(224, 26);
            this.txtBairroEndereco.TabIndex = 3;
            this.txtBairroEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(250, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Enabled = false;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(250, 265);
            this.txtNumeroEndereco.Maximum = new decimal(new int[] {99999, 0, 0, 0});
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(70, 26);
            this.txtNumeroEndereco.TabIndex = 2;
            this.txtNumeroEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroEndereco.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // txtLogradouroEndereco
            // 
            this.txtLogradouroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouroEndereco.Enabled = false;
            this.txtLogradouroEndereco.Location = new System.Drawing.Point(250, 210);
            this.txtLogradouroEndereco.MaxLength = 200;
            this.txtLogradouroEndereco.Name = "txtLogradouroEndereco";
            this.txtLogradouroEndereco.Size = new System.Drawing.Size(300, 26);
            this.txtLogradouroEndereco.TabIndex = 1;
            this.txtLogradouroEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkEditarRegistro
            // 
            this.linkEditarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.linkEditarRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkEditarRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkEditarRegistro.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkEditarRegistro.Location = new System.Drawing.Point(450, 404);
            this.linkEditarRegistro.Name = "linkEditarRegistro";
            this.linkEditarRegistro.Size = new System.Drawing.Size(100, 23);
            this.linkEditarRegistro.TabIndex = 8;
            this.linkEditarRegistro.TabStop = true;
            this.linkEditarRegistro.Text = "Editar registro";
            this.linkEditarRegistro.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkEditarRegistro.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditarRegistro_LinkClicked);
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
            // linkExcluirRegistro
            // 
            this.linkExcluirRegistro.BackColor = System.Drawing.Color.Transparent;
            this.linkExcluirRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkExcluirRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkExcluirRegistro.LinkColor = System.Drawing.Color.DimGray;
            this.linkExcluirRegistro.Location = new System.Drawing.Point(250, 404);
            this.linkExcluirRegistro.Name = "linkExcluirRegistro";
            this.linkExcluirRegistro.Size = new System.Drawing.Size(110, 23);
            this.linkExcluirRegistro.TabIndex = 9;
            this.linkExcluirRegistro.TabStop = true;
            this.linkExcluirRegistro.Text = "Excluir registro";
            this.linkExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkExcluirRegistro.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkExcluirRegistro.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExcluirRegistro_LinkClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 11;
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
            this.btnConfirmar.Location = new System.Drawing.Point(250, 430);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 40);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseEnter += new System.EventHandler(this.btnConfirmar_MouseEnter);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(250, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Logradouro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(250, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razão Social";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCnpjInstituicao
            // 
            this.txtCnpjInstituicao.Enabled = false;
            this.txtCnpjInstituicao.Location = new System.Drawing.Point(403, 375);
            this.txtCnpjInstituicao.Name = "txtCnpjInstituicao";
            this.txtCnpjInstituicao.Size = new System.Drawing.Size(147, 26);
            this.txtCnpjInstituicao.TabIndex = 7;
            this.txtCnpjInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRazaoSocialInstituicao
            // 
            this.txtRazaoSocialInstituicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocialInstituicao.Enabled = false;
            this.txtRazaoSocialInstituicao.Location = new System.Drawing.Point(250, 155);
            this.txtRazaoSocialInstituicao.MaxLength = 200;
            this.txtRazaoSocialInstituicao.Name = "txtRazaoSocialInstituicao";
            this.txtRazaoSocialInstituicao.Size = new System.Drawing.Size(300, 26);
            this.txtRazaoSocialInstituicao.TabIndex = 0;
            this.txtRazaoSocialInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuStripAdministraInstituicao);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelTop.ForeColor = System.Drawing.Color.White;
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
            this.label1.Location = new System.Drawing.Point(250, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar registros de instituições";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripAdministraInstituicao
            // 
            this.menuStripAdministraInstituicao.BackColor = System.Drawing.Color.Transparent;
            this.menuStripAdministraInstituicao.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripAdministraInstituicao.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripAdministraInstituicao.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolSobre});
            this.menuStripAdministraInstituicao.LayoutStyle =
                System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripAdministraInstituicao.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdministraInstituicao.Name = "menuStripAdministraInstituicao";
            this.menuStripAdministraInstituicao.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripAdministraInstituicao.Size = new System.Drawing.Size(64, 30);
            this.menuStripAdministraInstituicao.TabIndex = 0;
            this.menuStripAdministraInstituicao.Text = "menuStripAdministraInstituicao";
            // 
            // menuToolSobre
            // 
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "&Sobre";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            // 
            // AdministraInstituicao
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
            this.MainMenuStrip = this.menuStripAdministraInstituicao;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministraInstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministraInstituicao";
            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(this.AdministraInstituicao_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.txtNumeroEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStripAdministraInstituicao.ResumeLayout(false);
            this.menuStripAdministraInstituicao.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStripAdministraInstituicao;
        private System.Windows.Forms.TextBox txtRazaoSocialInstituicao;
        private System.Windows.Forms.MaskedTextBox txtCnpjInstituicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.LinkLabel linkExcluirRegistro;
        private System.Windows.Forms.LinkLabel linkEditarRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstadoEndereco;
        private System.Windows.Forms.TextBox txtCidadeEndereco;
        private System.Windows.Forms.TextBox txtBairroEndereco;
        private System.Windows.Forms.NumericUpDown txtNumeroEndereco;
        private System.Windows.Forms.TextBox txtLogradouroEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCepEndereco;
    }
}