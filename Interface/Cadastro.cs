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
            menuFinalizarPrograma.ForeColor = Color.White;
            menuFinalizarPrograma.BackColor = Color.Black;
        }
        
        /* Personalização de janelas */
        private class ProjectRenderer : ToolStripProfessionalRenderer
        {
            public ProjectRenderer() : base(new ProjectColors()) {}
        }

        private class ProjectColors : ProfessionalColorTable
        {
            public override Color MenuItemBorder => Color.Empty;
            public override Color ButtonPressedBorder => Color.Black;
            public override Color MenuItemPressedGradientBegin => Color.DimGray;
            public override Color MenuItemPressedGradientEnd => Color.DimGray;
            public override Color MenuItemSelected => Color.DimGray;
            public override Color MenuItemSelectedGradientBegin => Color.Black;
            public override Color MenuItemSelectedGradientEnd => Color.Black;
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
        private void menuToolSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Controle de almoxarifado
Desenvolvedor: Pedro Couto
Versão: 2019.0.2",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}