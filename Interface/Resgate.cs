using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class Resgate : Form
    {
        public Form InterfaceInicial;
        public Resgate()
        {
            InitializeComponent();
            menuStripResgate.Renderer = new ProjectRenderer();
        }
        
        /* Personalização de janelas */
        private class ProjectRenderer : ToolStripProfessionalRenderer
        {
            public ProjectRenderer() : base(new ProjectColors()) {}
        }

        private class ProjectColors : ProfessionalColorTable
        {
            public override Color MenuBorder => Color.Empty;
            public override Color MenuItemBorder => Color.Empty;
            public override Color MenuItemPressedGradientBegin => Color.Transparent;
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(255, 0, 100, 100);
            public override Color MenuItemSelected => Color.FromArgb(255, 0, 100, 100);
            public override Color MenuItemSelectedGradientBegin => Color.Transparent;
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 0, 100, 100);
        }

        private void btnConfirma_MouseEnter(object sender, EventArgs e)
        {
            btnConfirma.FlatAppearance.BorderColor = Color.White;
            btnConfirma.ForeColor = Color.White;
        }

        private void btnConfirma_MouseLeave(object sender, EventArgs e)
        {
            btnConfirma.FlatAppearance.BorderColor = Color.Green;
            btnConfirma.ForeColor = Color.Green;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.FlatAppearance.BorderColor = Color.Red;
            btnCancelar.ForeColor = Color.Red;
        }

        private void menuFinalizarPrograma_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Close();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Close();
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Show();
            Close();
        }

        private void menuToolSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Plataforma para controle de almoxarifado
Desenvolvedor: Pedro Couto
Versão: 2019.0.4",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmailResgate.Clear();
            txtNascimentoResgate.Clear();
            txtCpfResgate.Clear();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailResgate.Text) || txtNascimentoResgate.Text == @"  /  /" ||
                txtCpfResgate.Text == @"   .   .   -")
            {
                MessageBox.Show(
                    @"É necessário o preenchimento de todos os campos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show(
                    @"Seu acesso foi recuperado com sucesso.",
                    @"Recuperação de acesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                InterfaceInicial.Show();
                Hide();
            }
        }
    }
}