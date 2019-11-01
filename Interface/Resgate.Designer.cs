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
                new System.ComponentModel.ComponentResourceManager(typeof(Interface.Resgate));
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.label9 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripResgate = new System.Windows.Forms.MenuStrip();
            this.menuToolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinalizarPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStripResgate.SuspendLayout();
            this.SuspendLayout();
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.linkLimpeza.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.linkLimpeza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLimpeza.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLimpeza.Location = new System.Drawing.Point(480, 374);
            this.linkLimpeza.Name = "linkLimpeza";
            this.linkLimpeza.Size = new System.Drawing.Size(70, 23);
            this.linkLimpeza.TabIndex = 3;
            this.linkLimpeza.TabStop = true;
            this.linkLimpeza.Text = "Limpar";
            this.linkLimpeza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLimpeza.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linkLimpeza.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpeza_LinkClicked);
            this.label4.Location = new System.Drawing.Point(403, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Insira seu CPF";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(250, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data nascimento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtCpfResgate.Location = new System.Drawing.Point(403, 345);
            this.txtCpfResgate.Mask = "000,000,000-00";
            this.txtCpfResgate.Name = "txtCpfResgate";
            this.txtCpfResgate.Size = new System.Drawing.Size(147, 26);
            this.txtCpfResgate.TabIndex = 2;
            this.txtCpfResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNascimentoResgate.Location = new System.Drawing.Point(250, 345);
            this.txtNascimentoResgate.Mask = "00/00/0000";
            this.txtNascimentoResgate.Name = "txtNascimentoResgate";
            this.txtNascimentoResgate.Size = new System.Drawing.Size(147, 26);
            this.txtNascimentoResgate.TabIndex = 1;
            this.txtNascimentoResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNascimentoResgate.ValidatingType = typeof(System.DateTime);
            this.label2.Location = new System.Drawing.Point(250, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insira o e-mail cadastrado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(403, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.txtEmailResgate.Location = new System.Drawing.Point(250, 290);
            this.txtEmailResgate.MaxLength = 200;
            this.txtEmailResgate.Name = "txtEmailResgate";
            this.txtEmailResgate.Size = new System.Drawing.Size(300, 26);
            this.txtEmailResgate.TabIndex = 0;
            this.txtEmailResgate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.ForeColor = System.Drawing.Color.Green;
            this.btnConfirma.Location = new System.Drawing.Point(250, 400);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(147, 40);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Recuperar acesso";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            this.btnConfirma.MouseEnter += new System.EventHandler(this.btnConfirma_MouseEnter);
            this.btnConfirma.MouseLeave += new System.EventHandler(this.btnConfirma_MouseLeave);
            this.panelBottom.Controls.Add(this.label9);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(798, 30);
            this.panelBottom.TabIndex = 0;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(250, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Copyright - Pedro Couto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperação de acesso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStripResgate.AutoSize = false;
            this.menuStripResgate.BackColor = System.Drawing.Color.Transparent;
            this.menuStripResgate.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripResgate.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.menuStripResgate.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolSistema, this.menuToolSobre});
            this.menuStripResgate.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripResgate.Location = new System.Drawing.Point(0, 0);
            this.menuStripResgate.Name = "menuStripResgate";
            this.menuStripResgate.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripResgate.Size = new System.Drawing.Size(134, 30);
            this.menuStripResgate.TabIndex = 0;
            this.menuStripResgate.Text = "menuStripResgate";
            this.menuToolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuFinalizarPrograma});
            this.menuToolSistema.ForeColor = System.Drawing.Color.White;
            this.menuToolSistema.Name = "menuToolSistema";
            this.menuToolSistema.Size = new System.Drawing.Size(70, 26);
            this.menuToolSistema.Text = "&Sistema";
            this.menuFinalizarPrograma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuFinalizarPrograma.ForeColor = System.Drawing.Color.White;
            this.menuFinalizarPrograma.Name = "menuFinalizarPrograma";
            this.menuFinalizarPrograma.Size = new System.Drawing.Size(152, 22);
            this.menuFinalizarPrograma.Text = "&Finalizar";
            this.menuFinalizarPrograma.Click += new System.EventHandler(this.menuFinalizarPrograma_Click);
            this.menuToolSobre.ForeColor = System.Drawing.Color.White;
            this.menuToolSobre.Name = "menuToolSobre";
            this.menuToolSobre.Size = new System.Drawing.Size(56, 26);
            this.menuToolSobre.Text = "Sobr&e";
            this.menuToolSobre.Click += new System.EventHandler(this.menuToolSobre_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Resgate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuFinalizarPrograma;
        private System.Windows.Forms.ToolStripMenuItem menuToolSistema;
        private System.Windows.Forms.ToolStripMenuItem menuToolSobre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtEmailResgate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLimpeza;
        private System.Windows.Forms.MaskedTextBox txtCpfResgate;
        private System.Windows.Forms.MaskedTextBox txtNascimentoResgate;
    }
}