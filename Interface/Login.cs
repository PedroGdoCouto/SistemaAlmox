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
            var usuario = new Usuario();
            usuario.EmailUsuario = txtEmail.Text;
            usuario.SenhaUsuario = txtSenha.Text;
            usuario.Acessar();
            MessageBox.Show(usuario.Retorno());
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
                @"Sistema de cadastro básico - SAEP
Criador: Pedro Couto
Versão: 2019.1.1",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}