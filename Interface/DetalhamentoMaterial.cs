using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class DetalhamentoMaterial : Form
    {
        public Form InterfaceUsuario;
        private readonly Material _material = new Material();
        public DetalhamentoMaterial(IReadOnlyList<string> args)
        {
            InitializeComponent();
            labelIdMaterial.Text = args[0];
            txtNomeMaterial.Text = args[1];
            txtDescricaoMaterial.Text = args[2];
            txtQuantidadeMaterial.Text = args[3];
            txtLocalizacaoMaterial.Text = args[4];
            txtChaveNotaFiscal.Text = args[5];
            /* txtUltimaEntrada.Text = _material.EntradaEstoque(labelIdMaterial.Text, "busca"); */
            txtUltimaSaida.Text = _material.SaidaEstoque(new[] {labelIdMaterial.Text}, "busca");
            if (int.Parse(txtQuantidadeMaterial.Text) == 0) btnConfirmar.Enabled = false;
            menuStripDetalhamentoMaterial.Renderer = new ProjectRenderer();
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
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var interfaceRegistraSaida = new RegistraSaida(new []
            {
                labelIdMaterial.Text,
                txtQuantidadeMaterial.Text,
                txtNomeMaterial.Text + " - " + txtDescricaoMaterial.Text
            }) {InterfaceUsuario = InterfaceUsuario};
            interfaceRegistraSaida.Show();
            Hide();
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

        private void DetalhamentoMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceUsuario.Show();
        }
    }
}