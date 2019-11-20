using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class AdministraMaterial : Form
    {
        public Form InterfaceAdministrador;
        public AdministraMaterial(IReadOnlyList<string> args)
        {
            InitializeComponent();
            labelIdMaterial.Text = args[0];
            txtNomeMaterial.Text = args[1];
            txtDescricaoMaterial.Text = args[2];
            txtQuantidadeMaterial.Text = args[3];
            txtLocalizacaoMaterial.Text = args[4];
            menuStripAdministraMaterial.Renderer = new ProjectRenderer();
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
        private void txtLocalizacaoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char) Keys.Space;
        }
        
        private void linkEditarRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNomeMaterial.Clear();
            txtNomeMaterial.Enabled = true;
            txtDescricaoMaterial.Clear();
            txtDescricaoMaterial.Enabled = true;
            txtQuantidadeMaterial.Text = @"1";
            txtQuantidadeMaterial.Enabled = true;
            txtLocalizacaoMaterial.Clear();
            txtLocalizacaoMaterial.Enabled = true;
            linkExcluirRegistro.Enabled = false;
            linkEditarRegistro.Enabled = false;
            btnConfirmar.Enabled = true;
        }

        private void linkExcluirRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mensagem =
                MessageBox.Show(
                    @"Deseja excluir o registro do material?",
                    @"Exclusão de dados",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (!mensagem.Equals(DialogResult.Yes)) return;
            var retorno = Material.ExcluirRegistro(labelIdMaterial.Text);
            switch (retorno)
            {
                case "excluido":
                    MessageBox.Show(
                        @"Material excluído com sucesso!",
                        @"Exclusão de material",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Close();
                    break;
                case "nulo":
                    MessageBox.Show(
                        @"Não foi possível realizar a exclusão do registro.",
                        @"Exclusão de material",
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
            if (string.IsNullOrEmpty(txtNomeMaterial.Text) || string.IsNullOrEmpty(txtDescricaoMaterial.Text) ||
                string.IsNullOrEmpty(txtQuantidadeMaterial.Text) || string.IsNullOrEmpty(txtLocalizacaoMaterial.Text))
            {
                MessageBox.Show(
                    @"É necessário o preenchimento de todos os campos.",
                    @"Preenchimento obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                var material = new Material();
                var retorno = material.AtualizarRegistro(new []
                {
                    labelIdMaterial.Text,
                    txtNomeMaterial.Text,
                    txtDescricaoMaterial.Text,
                    txtQuantidadeMaterial.Text,
                    txtLocalizacaoMaterial.Text
                });
                switch (retorno)
                {
                    case "atualizado":
                        MessageBox.Show(
                            @"Registro do material atualizado com sucesso!",
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

        private void AdministraMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceAdministrador.Show();
        }
    }
}