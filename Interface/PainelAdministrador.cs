using Business;
using System;
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
            dataGridInstituicao.DataSource = Instituicao.BuscaCompleta();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
            dataGridUsuario.DataSource = Usuario.BuscaCompleta();
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
        private void submenuCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var interfaceCadastroUsuario = new CadastroUsuario { InterfaceAdministrador = this };
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
Versão: 2019.0.5",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /* Funcionalidades da aplicação */
        
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
            var interfaceAdministraInstituicao = new AdministraInstituicao();
            interfaceAdministraInstituicao.Show();
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
            var interfaceAdministraMaterial = new AdministraMaterial();
            interfaceAdministraMaterial.Show();
        }

        /* Aba usuário */
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaUsuario.Text))
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
            var interfaceAdministraUsuario = new AdministraUsuario();
            interfaceAdministraUsuario.Show();
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
            var mensagem = MessageBox.Show(
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