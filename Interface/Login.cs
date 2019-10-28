using System;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Instruções de acesso ao sistema
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailLogin.Text) || string.IsNullOrEmpty(txtSenhaLogin.Text))
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
                    EmailUsuario = txtEmailLogin.Text,
                    SenhaUsuario = txtSenhaLogin.Text
                };
                usuario.Acessar();
                MessageBox.Show(
                    usuario.Retorno("acesso"),
                    @"Validação de acesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // Instruções de encerramento do sistema
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            var mensagem = MessageBox.Show(
                @"Deseja sair do programa?",
                @"Encerrar aplicação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );
            switch (mensagem)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    Show();
                    break;
                default:
                    MessageBox.Show(
                        @"Ocorreu um erro durante o processo.",
                        @"Erro de processamento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }

        private void menuEncerraPrograma_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Instruções de informação do sistema
        private void menuSobrePrograma_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Sistema de cadastro - SAEP
Criador: Pedro Couto
Versão: 2019.1.1",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void menuNovoCadastro_Click(object sender, EventArgs e)
        {
            txtEmailLogin.Clear();
            txtSenhaLogin.Clear();
            Cadastro interfaceCadastro = new Cadastro { InterfaceInicial = this };
            interfaceCadastro.Show();
            Hide();
        }

        private void chkExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaLogin.UseSystemPasswordChar = !chkExibeSenha.Checked;
            /*
            if (chkExibeSenha.Checked){
                txtSenhaLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaLogin.UseSystemPasswordChar = true;
            }
            */
        }

        private void menuRecuperaSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Função estará disponível em breve.",
                @"Recuperar acesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}