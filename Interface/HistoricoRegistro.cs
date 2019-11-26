using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class HistoricoRegistro : Form
    {
        public Form InterfaceAdministrador;
        public HistoricoRegistro()
        {
            InitializeComponent();
            menuStripHistoricoRegistro.Renderer = new ProjectRenderer();
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
Versão: 2019.1.0",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
                dataGridMaterial.DataSource = Material.BuscaHistorico("material", txtPesquisaMaterial.Text);
            }
        }
        
        private void linkLimpezaMaterial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaMaterial.Clear();
            dataGridMaterial.DataSource = Material.BuscaHistorico("material");
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
                dataGridUsuario.DataSource = Usuario.BuscaHistorico("usuario", txtPesquisaUsuario.Text);
            }
        }

        private void linkLimpezaUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaUsuario.Clear();
            dataGridUsuario.DataSource = Usuario.BuscaHistorico("usuario");
        }
        
        /* Funcionalidades da aplicação */
        private void HistoricoRegistro_Activated(object sender, EventArgs e)
        {
            dataGridMaterial.DataSource = Material.BuscaHistorico("material");
            dataGridUsuario.DataSource = Usuario.BuscaHistorico("usuario");
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistoricoRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}