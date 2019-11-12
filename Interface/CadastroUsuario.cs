using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class CadastroUsuario : Form
    {
        public Form InterfaceAdministrador;
        public CadastroUsuario()
        {
            InitializeComponent();
            menuStripCadastro.Renderer = new ProjectRenderer();
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

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.FlatAppearance.BorderColor = Color.White;
            btnCadastrar.ForeColor = Color.White;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.FlatAppearance.BorderColor = Color.Green;
            btnCadastrar.ForeColor = Color.Green;
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
        
        /* Barra de ferramentas */
        private void menuToolSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Plataforma para controle de almoxarifado
Desenvolvedor: Pedro Couto
Versão: 2019.0.5",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        /* Funcionalidades da aplicação */
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailCadastro.Text) || string.IsNullOrEmpty(txtNomeCadastro.Text) ||
                txtNascimentoCadastro.Text == @"  /  /" || txtCpfCadastro.Text == @"   .   .   -" ||
                string.IsNullOrEmpty(txtSenhaCadastro.Text) || string.IsNullOrEmpty(txtValidaSenha.Text))
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
                MessageBox.Show(@"Autenticado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNomeCadastro.Clear();
            txtEmailCadastro.Clear();
            txtNascimentoCadastro.Clear();
            txtCpfCadastro.Clear();
            txtSenhaCadastro.Clear();
            txtValidaSenha.Clear();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}