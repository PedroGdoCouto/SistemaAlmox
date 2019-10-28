using System;
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
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailCadastro.Text) || string.IsNullOrEmpty(txtNomeUsuario.Text) ||
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
                    NomeUsuario = txtNomeUsuario.Text,
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

        private void chkExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaCadastro.UseSystemPasswordChar = !chkExibeSenha.Checked;
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

        private void btnCancela_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Show();
            Hide();
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceInicial.Close();
        }

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
    }
}