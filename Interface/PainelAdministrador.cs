using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class PainelAdministrador : Form
    {
        public Form InterfaceInicial;
        public PainelAdministrador(string usuario)
        {
            InitializeComponent();
            labelNomeUsuario.Text = $@"Bem-vindo {usuario}!";
            menuStripAdministrador.Renderer = new ProjectRenderer();
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
        
        /* Aba instituição */
        private void btnPesquisarInstituicao_Click(object sender, EventArgs e)
        {
            var cnpj = txtPesquisaInstituicao.Text.Replace(" ", "");
            if (cnpj.Length < 18)
            {
                MessageBox.Show(
                    @"É necessário o preenchimento do campo.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                dataGridInstituicao.DataSource = Instituicao.BuscaUnica(txtPesquisaInstituicao.Text);
            }
        }

        private void dataGridInstituicao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var endereco = dataGridInstituicao.Rows[e.RowIndex].Cells["colEnderecoInstituicao"].Value.ToString()
                    .Split('-');
                endereco[4] = endereco[4].Replace(" ", "");
                var interfaceAdministraInstituicao = new AdministraInstituicao(new []
                {
                    dataGridInstituicao.Rows[e.RowIndex].Cells["colCnpjInstituicao"].Value.ToString(),
                    dataGridInstituicao.Rows[e.RowIndex].Cells["colRazaoSocialInstituicao"].Value.ToString(),
                    endereco[0], endereco[1], endereco[2], endereco[3], endereco[4], endereco[5]
                }) {InterfaceAdministrador = this};
                interfaceAdministraInstituicao.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Ocorreu um erro no carregamento das tabelas, reinicie a aplicação. " + ex.Message,
                    @"Erro de detalhamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void linkCadastrarInstituicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var interfaceCadastroInstituicao = new CadastroInstituicao {InterfaceAdministrador = this};
            interfaceCadastroInstituicao.Show();
            Hide();
        }

        private void linkLimpezaInstituicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaInstituicao.Clear();
            dataGridInstituicao.DataSource = Instituicao.BuscaCompleta();
        }
        
        /* Aba material */
        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaMaterial.Text))
            {
                MessageBox.Show(
                    @"É necessário o preenchimento do campo.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                dataGridMaterial.DataSource = Material.BuscaUnica(txtPesquisaMaterial.Text, "nome");
            }
        }

        private void dataGridMaterial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var interfaceAdministraMaterial = new AdministraMaterial(new []
                {
                    dataGridMaterial.Rows[e.RowIndex].Cells["colIdMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colNomeMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colDescricaoMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colQuantidadeMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colLocalizacaoMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colChaveNotaFiscal"].Value.ToString()
                }) {InterfaceAdministrador = this};
                interfaceAdministraMaterial.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Ocorreu um erro no carregamento das tabelas, reinicie a aplicação. " + ex.Message,
                    @"Erro de detalhamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void linkCadastrarMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var interfaceCadastroMaterial = new CadastroMaterial {InterfaceAdministrador = this};
            interfaceCadastroMaterial.Show();
            Hide();
        }

        private void linkLimpezaMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaMaterial.Clear();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
        }

        /* Aba usuário */
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            var cpf = txtPesquisaUsuario.Text.Replace(" ", "");
            if (cpf.Length < 14)
            {
                MessageBox.Show(
                    @"É necessário o preenchimento do campo.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                dataGridUsuario.DataSource = Usuario.BuscaUnica(txtPesquisaUsuario.Text);
            }
        }

        private void dataGridUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var interfaceAdministraUsuario = new AdministraUsuario(new []
                {
                    dataGridUsuario.Rows[e.RowIndex].Cells["colCpfUsuario"].Value.ToString(),
                    dataGridUsuario.Rows[e.RowIndex].Cells["colNomeUsuario"].Value.ToString(),
                    dataGridUsuario.Rows[e.RowIndex].Cells["colEmailUsuario"].Value.ToString(),
                    dataGridUsuario.Rows[e.RowIndex].Cells["colNascimentoUsuario"].Value.ToString()
                }) {InterfaceAdministrador = this};
                interfaceAdministraUsuario.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Ocorreu um erro no carregamento das tabelas, reinicie a aplicação. " + ex.Message,
                    @"Erro de detalhamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void linkCadastrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var interfaceCadastroUsuario = new CadastroUsuario {InterfaceAdministrador = this};
            interfaceCadastroUsuario.Show();
            Hide();
        }

        private void linkLimpezaUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaUsuario.Clear();
            dataGridUsuario.DataSource = Usuario.BuscaCompleta();
        }

        /* Funcionalidades da aplicação */
        private void PainelAdministrador_Activated(object sender, EventArgs e)
        {
            dataGridInstituicao.DataSource = Instituicao.BuscaCompleta();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
            dataGridUsuario.DataSource = Usuario.BuscaCompleta();
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PainelAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            var mensagem =
                MessageBox.Show(
                    @"Deseja sair do seu acesso?", 
                    @"Encerrar sessão", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );
            e.Cancel = mensagem != DialogResult.Yes;
            if (mensagem == DialogResult.No) return;
            InterfaceInicial.Show();
        }
    }
}