using Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class RegistraEntrada : Form
    {
        public Form InterfaceUsuario;
        private readonly object[] _nomeMaterial;

        public RegistraEntrada()
        {
            InitializeComponent();
            labelIdMaterial.Text = Material.BuscaMaterial("id");
            _nomeMaterial = new object[int.Parse(labelIdMaterial.Text)];
            menuStripRegistroEntrada.Renderer = new ProjectRenderer();
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

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.FlatAppearance.BorderColor = Color.White;
            btnRegistrar.ForeColor = Color.White;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.FlatAppearance.BorderColor = Color.Green;
            btnRegistrar.ForeColor = Color.Green;
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
Versão: 2019.1.0",
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

        private void txtChaveNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLimpeza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPesquisaMaterial.Clear();
            cmbNomeMaterial.Items.Clear();
            for (var i = 0; i < int.Parse(labelIdMaterial.Text); i++)
            {
                _nomeMaterial[i] = Material.BuscaMaterial("nome", i + 1);
            }
            cmbNomeMaterial.Items.AddRange(_nomeMaterial);
            cmbNomeMaterial.SelectedIndex = 0;
            txtQuantidadeMaterial.Text = @"1";
            txtLocalizacaoMaterial.Clear();
            txtChaveNotaFiscal.Clear();
        }

        private void txtPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            cmbNomeMaterial.Items.Clear();
            for (var i = 0; i < int.Parse(labelIdMaterial.Text); i++)
            {
                _nomeMaterial[i] = Material.BuscaMaterial("nome", i + 1);
            }
            cmbNomeMaterial.Items.AddRange(_nomeMaterial);
            cmbNomeMaterial.SelectedIndex = 0;
        }

        private void txtPesquisaMaterial_Enter(object sender, EventArgs e)
        {
            txtPesquisaMaterial.Clear();
            cmbNomeMaterial.Items.Clear();
            for (var i = 0; i < int.Parse(labelIdMaterial.Text); i++)
            {
                _nomeMaterial[i] = Material.BuscaMaterial("nome", i + 1);
            }
            cmbNomeMaterial.Items.AddRange(_nomeMaterial);
            cmbNomeMaterial.SelectedIndex = 0;
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
                for (var i = 0; i < cmbNomeMaterial.Items.Count; i++)
                {
                    for (var j = 0; j < cmbNomeMaterial.Items.Count; j++)
                    {
                        if (!cmbNomeMaterial.Items[j].ToString().Contains(txtPesquisaMaterial.Text))
                            cmbNomeMaterial.Items.RemoveAt(j);
                    }
                    if (cmbNomeMaterial.Items.Count < i) break;
                }
                cmbNomeMaterial.SelectedIndex = 0;
            }
        }

        private void cmbNomeMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < _nomeMaterial.Length; i++)
            {
                var idMaterial = 0;
                for (var j = 0; j < _nomeMaterial.Length; j++)
                {
                    if (cmbNomeMaterial.Items.Count < i) break;
                    if (!cmbNomeMaterial.Text.Equals(_nomeMaterial[j].ToString())) continue;
                    idMaterial = j + 1;
                }
                labelIdMaterial.Text = idMaterial.ToString();
                if (idMaterial > 0) break;
            }
            labelChaveNotaFiscal.Text = Material.BuscaMaterial("chave", int.Parse(labelIdMaterial.Text));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChaveNotaFiscal.Text) || string.IsNullOrEmpty(txtLocalizacaoMaterial.Text))
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
                var material = new Material();
                var retorno = material.EntradaEstoque(new []
                {
                    labelIdMaterial.Text,
                    txtQuantidadeMaterial.Text,
                    DateTime.Now.ToShortDateString(),
                    txtLocalizacaoMaterial.Text,
                    txtChaveNotaFiscal.Text,
                    labelChaveNotaFiscal.Text
                }, "registro");
                switch (retorno)
                {
                    case "offline":
                        MessageBox.Show(
                            @"Não foi possível iniciar a conexão com o banco de dados.
Caso o erro persista, contate o administrador do sistema.",
                            @"Erro no processamento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        break;
                    case "nulo":
                        MessageBox.Show(
                            @"Não foi possível realizar o registro, tente novamente.
Caso o erro persista, contate o administrador.",
                            @"Erro no registro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    case "registrado":
                        MessageBox.Show(
                            @"Entrada de material realizada com sucesso.",
                            @"Registro de entrada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        Close();
                        break;
                    default:
                        MessageBox.Show(
                            retorno,
                            @"Erro no processamento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
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

        private void RegistraEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceUsuario.Show();
        }
    }
}