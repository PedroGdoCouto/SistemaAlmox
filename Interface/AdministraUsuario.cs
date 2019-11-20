using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class AdministraUsuario : Form
    {
        public Form InterfaceAdministrador;
        public AdministraUsuario(IReadOnlyList<string> args)
        {
            InitializeComponent();
            txtCpfUsuario.Text = args[0];
            txtNomeUsuario.Text = args[1];
            txtEmailUsuario.Text = args[2];
            txtNascimentoUsuario.Text = args[3];
            menuStripAdministraUsuario.Renderer = new ProjectRenderer();
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

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.FlatAppearance.BorderColor = Color.White;
            btnConfirmar.ForeColor = Color.White;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.FlatAppearance.BorderColor = Color.Green;
            btnConfirmar.ForeColor = Color.Green;
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
Versão: 2019.0.7",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /* Funcionalidades da aplicação */
        private void txtEmailUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char) Keys.Space;
        }
        
        private void linkEditarRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelNomeUsuario.Text = @"Nome completo";
            txtNomeUsuario.Clear();
            txtNomeUsuario.Enabled = true;
            txtEmailUsuario.Clear();
            txtEmailUsuario.Enabled = true;
            txtNascimentoUsuario.Clear();
            txtNascimentoUsuario.Enabled = true;
            txtNascimentoUsuario.Mask = @"00/00/0000";
            txtSenhaUsuario.Enabled = true;
            txtValidaSenha.Enabled = true;
            linkExcluirRegistro.Enabled = false;
            linkEditarRegistro.Visible = false;
            chkAdministrador.Visible = true;
            btnConfirmar.Enabled = true;
        }

        private void linkExcluirRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mensagem =
                MessageBox.Show(
                    @"Deseja excluir o registro do usuário?",
                    @"Exclusão de dados",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (!mensagem.Equals(DialogResult.Yes)) return;
            var retorno = Usuario.ExcluirRegistro(txtCpfUsuario.Text);
            switch (retorno)
            {
                case "excluido":
                    MessageBox.Show(
                        @"Usuário excluído com sucesso!",
                        @"Exclusão de material",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Close();
                    break;
                case "nulo":
                    MessageBox.Show(
                        @"Não foi possível realizar a exclusão do registro.",
                        @"Exclusão de material",
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cpf = txtCpfUsuario.Text.Replace(" ", "");
            var nascimento = txtNascimentoUsuario.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(txtNomeUsuario.Text) || string.IsNullOrEmpty(txtEmailUsuario.Text) ||
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
                var retorno = usuario.AtualizarRegistro(new []
                {
                    txtCpfUsuario.Text, txtNomeUsuario.Text, txtNascimentoUsuario.Text, txtEmailUsuario.Text,
                    txtSenhaUsuario.Text, txtValidaSenha.Text
                }, chkAdministrador.Checked);
                switch (retorno)
                {
                    case "atualizado":
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdministraUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}