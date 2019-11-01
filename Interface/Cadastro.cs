using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class Cadastro : Form
    {
        public Form InterfaceInicial;
        public Cadastro()
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

        private void btnCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnCadastro.FlatAppearance.BorderColor = Color.White;
            btnCadastro.ForeColor = Color.White;
        }

        private void btnCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnCadastro.FlatAppearance.BorderColor = Color.Green;
            btnCadastro.ForeColor = Color.Green;
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
        
        /* Funcionalidades da aplicação */
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailCadastro.Text) || string.IsNullOrEmpty(txtNomeCadastro.Text) ||
                string.IsNullOrEmpty(txtNascimentoCadastro.Text) || string.IsNullOrEmpty(txtCpfCadastro.Text) ||
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
                var usuario = new Usuario
                {
                    EmailUsuario = txtEmailCadastro.Text,
                    NomeUsuario = txtNomeCadastro.Text,
                    SenhaUsuario = txtSenhaCadastro.Text,
                    ValidaSenha = txtValidaSenha.Text
                };
                usuario.ValidaCadastro();
                MessageBox.Show(
                    usuario.Retorno("cadastro"),
                    @"Validação de cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                if (usuario.Resultado != "1") return;
                InterfaceInicial.Show();
                Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Show();
            Close();
        }

        private void chkExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaCadastro.UseSystemPasswordChar = !chkExibeSenha.Checked;
            txtValidaSenha.UseSystemPasswordChar = !chkExibeSenha.Checked;
            /*
            if (chkExibeSenha.Checked){
                txtSenhaCadastro.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaCadastro.UseSystemPasswordChar = true;
            }
            */
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
            InterfaceInicial.Close();
            Close();
        }
        
        /* Barra de ferramentas */
        private void menuFinalizarPrograma_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Close();
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
    }
}