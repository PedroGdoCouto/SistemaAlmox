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

        /* Barra de ferramentas */
        private void menuToolSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Plataforma para controle de almoxarifado
Desenvolvedor: Pedro Couto
Versão: 2019.0.8",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /* Funcionalidades da aplicação */
        private void txtEmailResgate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char) Keys.Space;
        }
        
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            var cpf = txtCpfResgate.Text.Replace(" ", "");
            var nascimento = txtNascimentoResgate.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(txtEmailResgate.Text) || txtNascimentoResgate.Text == @"  /  /" ||
                string.IsNullOrEmpty(txtValidaSenha.Text))
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
                var retorno = usuario.ValidarResgate(new[]
                {
                    txtEmailResgate.Text, txtNascimentoResgate.Text, txtCpfResgate.Text,
                    txtSenhaResgate.Text, txtValidaSenha.Text
                });
                switch (retorno)
                {
                    case "atualizado":
                        MessageBox.Show(
                            @"Sua senha foi redefinida com sucesso.",
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
                            @"Dados inválidos, tente novamente.
Caso o erro persista contate o administrador.",
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

        private void chkExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaResgate.UseSystemPasswordChar = !chkExibeSenha.Checked;
            txtValidaSenha.UseSystemPasswordChar = !chkExibeSenha.Checked;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmailResgate.Clear();
            txtNascimentoResgate.Clear();
            txtCpfResgate.Clear();
            txtSenhaResgate.Clear();
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

        private void Resgate_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceInicial.Show();
        }
    }
}