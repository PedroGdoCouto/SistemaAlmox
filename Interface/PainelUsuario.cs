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
Versão: 2019.0.7",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        /* Funcionalidades da aplicação */
        private void PainelUsuario_Activated(object sender, EventArgs e)
        {
            dataGridMaterial.DataSource = Material.BuscaCompleta();
        }
        
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

        private void dataGridMaterial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var interfaceDetalhamento = new DetalhamentoMaterial(new[]
                {
                    dataGridMaterial.Rows[e.RowIndex].Cells["colIdMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colNomeMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colDescricaoMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colQuantidadeMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colLocalizacaoMaterial"].Value.ToString(),
                    dataGridMaterial.Rows[e.RowIndex].Cells["colChaveNotaFiscal"].Value.ToString()
                }) {InterfaceUsuario = this};
                interfaceDetalhamento.Show();
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

        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaMaterial.Clear();
            dataGridMaterial.DataSource = Material.BuscaCompleta();
        }

        private void linkRegistrarEntrada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var interfaceRegistraEntrada = new RegistraEntrada {InterfaceUsuario = this};
            interfaceRegistraEntrada.Show();
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