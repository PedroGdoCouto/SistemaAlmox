using Business;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class PainelAdministrador : Form
    {
        public Form InterfaceInicial;
        public PainelAdministrador()
        {
            InitializeComponent();
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

        private void menuSeparatorAdministrador_Paint(object sender, PaintEventArgs e)
        {
            var separator = (ToolStripSeparator) sender;
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkSlateGray), 0, 0, separator.Width, separator.Height);
            e.Graphics.DrawLine(new Pen(Color.FromArgb(255, 0, 100, 100)), 30, separator.Height / 2, separator.Width - 4, separator.Height / 2);
        }

        /* Barra de ferramentas */
        private void submenuCadastrarInstituicao_Click(object sender, EventArgs e)
        {
            var interfaceCadastroInstituicao = new CadastroInstituicao {InterfaceAdministrador = this};
            interfaceCadastroInstituicao.Show();
            Hide();
        }

        private void submenuCadastrarMaterial_Click(object sender, EventArgs e)
        {
            var interfaceCadastroMaterial = new CadastroMaterial {InterfaceAdministrador = this};
            interfaceCadastroMaterial.Show();
            Hide();
        }
        
        private void submenuCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var interfaceCadastroUsuario = new CadastroUsuario {InterfaceAdministrador = this};
            interfaceCadastroUsuario.Show();
            Hide();
        }
        
        private void menuEncerraSessao_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        private void PainelAdministrador_Activated(object sender, EventArgs e)
        {
            dataGridInstituicao.DataSource = Instituicao.BuscaCompleta();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
            dataGridUsuario.DataSource = Usuario.BuscaCompleta();
        }
        
        /* Aba instituição */
        private void btnPesquisarInstituicao_Click(object sender, EventArgs e)
        {
            if (txtPesquisaInstituicao.Text == @"  .   .   /    -")
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

        private void linkLimpezaInstituicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaInstituicao.Clear();
            dataGridInstituicao.DataSource = Instituicao.BuscaCompleta();
        }

        private void dataGridInstituicao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void linkLimpezaMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaMaterial.Clear();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
        }

        private void dataGridMaterial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var interfaceAdministraMaterial = new AdministraMaterial(new []
            {
                dataGridMaterial.Rows[e.RowIndex].Cells["colIdMaterial"].Value.ToString(),
                dataGridMaterial.Rows[e.RowIndex].Cells["colNomeMaterial"].Value.ToString(),
                dataGridMaterial.Rows[e.RowIndex].Cells["colDescricaoMaterial"].Value.ToString(),
                dataGridMaterial.Rows[e.RowIndex].Cells["colQuantidadeMaterial"].Value.ToString(),
                dataGridMaterial.Rows[e.RowIndex].Cells["colLocalizacaoMaterial"].Value.ToString()
            }) {InterfaceAdministrador = this};
            interfaceAdministraMaterial.Show();
            Hide();
        }

        /* Aba usuário */
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            if (txtPesquisaUsuario.Text == @"   .   .   -")
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

        private void linkLimpezaUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaUsuario.Clear();
            dataGridUsuario.DataSource = Usuario.BuscaCompleta();
        }

        private void dataGridUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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