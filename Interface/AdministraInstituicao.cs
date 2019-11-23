using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class AdministraInstituicao : Form
    {
        public Form InterfaceAdministrador;
        public AdministraInstituicao(IReadOnlyList<string> args)
        {
            InitializeComponent();
            txtCnpjInstituicao.Text = args[0];
            txtRazaoSocialInstituicao.Text = args[1];
            txtLogradouroEndereco.Text = args[2];
            txtNumeroEndereco.Text = args[3];
            txtBairroEndereco.Text = args[4];
            txtCidadeEndereco.Text = args[5];
            cmbEstadoEndereco.SelectedIndex = cmbEstadoEndereco.FindStringExact(args[6]);
            txtCepEndereco.Text = args[7];
            menuStripAdministraInstituicao.Renderer = new ProjectRenderer();
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
Versão: 2019.0.8",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /* Funcionalidades da aplicação */
        private void linkEditarRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtRazaoSocialInstituicao.Clear();
            txtRazaoSocialInstituicao.Enabled = true;
            txtLogradouroEndereco.Clear();
            txtLogradouroEndereco.Enabled = true;
            txtNumeroEndereco.ResetText();
            txtNumeroEndereco.Enabled = true;
            txtBairroEndereco.Clear();
            txtBairroEndereco.Enabled = true;
            txtCidadeEndereco.Clear();
            txtCidadeEndereco.Enabled = true;
            cmbEstadoEndereco.SelectedIndex = 0;
            cmbEstadoEndereco.Enabled = true;
            txtCepEndereco.Clear();
            txtCepEndereco.Enabled = true;
            txtCepEndereco.Mask = @"00000-000";
            linkExcluirRegistro.Enabled = false;
            linkEditarRegistro.Enabled = false;
            btnConfirmar.Enabled = true;
        }
        
        private void linkExcluirRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mensagem =
                MessageBox.Show(
                    @"Deseja excluir o registro da instituição?",
                    @"Exclusão de dados",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (!mensagem.Equals(DialogResult.Yes)) return;
            var retorno = Instituicao.ExcluirRegistro(txtCnpjInstituicao.Text);
            switch (retorno)
            {
                case "excluido":
                    MessageBox.Show(
                        @"Instituição excluída com sucesso!",
                        @"Exclusão de instituição",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Close();
                    break;
                case "nulo":
                    MessageBox.Show(
                        @"Não foi possível realizar a exclusão do registro.",
                        @"Exclusão de instituição",
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
            var cep = txtCepEndereco.Text.Replace(" ", "").Replace("-", "");
            var cnpj = txtCnpjInstituicao.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(txtRazaoSocialInstituicao.Text) || string.IsNullOrEmpty(txtLogradouroEndereco.Text) ||
                string.IsNullOrEmpty(txtBairroEndereco.Text) || string.IsNullOrEmpty(txtCidadeEndereco.Text))
            {
                MessageBox.Show(
                    @"É necessário o preenchimento de todos os campos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else if (cep.Length < 8 || cnpj.Length < 18)
            {
                MessageBox.Show(
                    @"CEP e/ou CNPJ inválidos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                var instituicao = new Instituicao();
                var retorno = instituicao.AtualizarRegistro(new []
                {
                    txtCnpjInstituicao.Text,
                    txtRazaoSocialInstituicao.Text,
                    txtLogradouroEndereco.Text,
                    txtNumeroEndereco.Text,
                    txtBairroEndereco.Text,
                    txtCidadeEndereco.Text,
                    cmbEstadoEndereco.Text,
                    cep
                });
                switch (retorno)
                {
                    case "atualizado":
                        MessageBox.Show(
                            @"Registro da instituição atualizado com sucesso!",
                            @"Atualização de material",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        Close();
                        break;
                    case "nulo":
                        MessageBox.Show(
                            @"Não foi possível realizar a atualização do registro.",
                            @"Atualização de material",
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

        private void AdministraInstituicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}