using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public sealed partial class PainelUsuario : Form
    {
        public Form InterfaceInicial;
        public PainelUsuario()
        {
            InitializeComponent();
            menuStripUsuario.Renderer = new ProjectRenderer();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
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
                if (rdoPesquisaCodigo.Checked)
                {
                    dataGridMaterial.DataSource = Material.BuscaUnica(txtPesquisaMaterial.Text, "codigo");
                }
                else if (rdoPesquisaLocal.Checked)
                {
                    dataGridMaterial.DataSource = Material.BuscaUnica(txtPesquisaMaterial.Text, "local");
                }
                else
                {
                    dataGridMaterial.DataSource = Material.BuscaUnica(txtPesquisaMaterial.Text, "nome");
                }
            }
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void PainelUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
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