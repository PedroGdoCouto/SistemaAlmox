using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class CadastroUsuario : Form
    {
        public Form InterfaceAdministrador;
        public CadastroUsuario()
        {
            InitializeComponent();
            menuStripCadastroUsuario.Renderer = new ProjectRenderer();
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
Versão: 2019.0.6",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        /* Funcionalidades da aplicação */
        private void txtEmailCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char) Keys.Space;
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cpf = txtCpfUsuario.Text.Replace(" ", "");
            var nascimento = txtNascimentoUsuario.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(txtEmailUsuario.Text) || string.IsNullOrEmpty(txtNomeUsuario.Text) ||
                string.IsNullOrEmpty(txtSenhaUsuario.Text) || string.IsNullOrEmpty(txtValidaSenha.Text))
            {
                MessageBox.Show(
                    @"É necessário o preenchimento de todos os campos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else if (nascimento.Length < 10 || cpf.Length < 14)
            {
                MessageBox.Show(
                    @"Data de nascimento e/ou CPF inválidos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                var usuario = new Usuario();
                var retorno = usuario.ValidarCadastro(new []
                {
                    txtCpfUsuario.Text, txtNomeUsuario.Text, txtNascimentoUsuario.Text, txtEmailUsuario.Text,
                    txtSenhaUsuario.Text, txtValidaSenha.Text
                }, chkAdministrador.Checked);
                switch (retorno)
                {
                    case "registrado":
                        MessageBox.Show(
                            @"Usuário registrado com sucesso!",
                            @"Validação de registro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        Close();
                        break;
                    case "divergente":
                        MessageBox.Show(
                            @"Senhas inseridas estão divergentes, tente novamente.",
                            @"Dados incorretos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    case "invalido":
                        MessageBox.Show(
                            @"O e-mail inserido é inválido, tente novamente.",
                            @"Dados incorretos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    case "nulo":
                        MessageBox.Show(
                            retorno,
                            @"Dados incorretos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    default:
                        MessageBox.Show(
                            retorno,
                            @"Erro no processamento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNomeUsuario.Clear();
            txtEmailUsuario.Clear();
            txtNascimentoUsuario.Clear();
            txtCpfUsuario.Clear();
            txtSenhaUsuario.Clear();
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