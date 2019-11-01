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
            menuFinalizarPrograma.ForeColor = Color.White;
            menuFinalizarPrograma.BackColor = Color.Black;
        }
        
        /* Personalização de janelas */
        private class ProjectRenderer : ToolStripProfessionalRenderer
        {
            public ProjectRenderer() : base(new ProjectColors()) {}
        }

        private class ProjectColors : ProfessionalColorTable
        {
            public override Color MenuItemBorder => Color.Empty;
            public override Color ButtonPressedBorder => Color.Black;
            public override Color MenuItemPressedGradientBegin => Color.DimGray;
            public override Color MenuItemPressedGradientEnd => Color.DimGray;
            public override Color MenuItemSelected => Color.DimGray;
            public override Color MenuItemSelectedGradientBegin => Color.Black;
            public override Color MenuItemSelectedGradientEnd => Color.Black;
        }

        private void menuFinalizarPrograma_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Close();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            InterfaceInicial.Close();
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menuToolSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Controle de almoxarifado
Desenvolvedor: Pedro Couto
Versão: 2019.0.2",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}