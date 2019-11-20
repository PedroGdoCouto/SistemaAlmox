using Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public partial class CadastroInstituicao : Form
    {
        public Form InterfaceAdministrador;
        public CadastroInstituicao()
        {
            InitializeComponent();
            menuStripCadastroInstituicao.Renderer = new ProjectRenderer();
            cmbEstadoEndereco.SelectedIndex = 0;
            txtNumeroEndereco.ResetText();
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
Versão: 2019.0.7",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        /* Funcionalidades da aplicação */
        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCnpjInstituicao.Clear();
            txtRazaoSocialInstituicao.Clear();
            txtLogradouroEndereco.Clear();
            txtNumeroEndereco.Text = @"1";
            txtBairroEndereco.Clear();
            txtCidadeEndereco.Clear();
            cmbEstadoEndereco.SelectedIndex = 0;
            txtCepEndereco.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                var retorno = instituicao.ValidarCadastro(new []
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
                    case "registrado":
                        MessageBox.Show(
                            @"Instituição registrada com sucesso!",
                            @"Validação de registro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        Close();
                        break;
                    case "nulo":
                        MessageBox.Show(
                            @"Não foi possível realizar o registro, tente novamente.
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

        private void CadastroInstituicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}