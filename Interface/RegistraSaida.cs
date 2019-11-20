using Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class RegistraSaida : Form
    {
        public Form InterfaceUsuario;
        public RegistraSaida(IReadOnlyList<string> args)
        {
            InitializeComponent();
            labelIdMaterial.Text = args[0];
            txtQuantidadeMaterial.Maximum = int.Parse(args[1]);
            txtNomeMaterial.Text = args[2];
            menuStripRegistraSaida.Renderer = new ProjectRenderer();
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
Versão: 2019.0.7",
                @"Sobre o sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        /* Funcionalidades da aplicação */
        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            var cnpj = txtCnpjInstituicao.Text.Replace(" ", "");
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
                var retorno = Instituicao.BuscaCnpj(txtCnpjInstituicao.Text);
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
                            @"Instituição não identificada, favor verificar os dados.",
                            @"Registro de saída",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    default:
                        txtRazaoSocial.Text = retorno;
                        break;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var material = new Material();
            var retorno = material.SaidaEstoque(new []
            {
                labelIdMaterial.Text,
                txtQuantidadeMaterial.Text,
                DateTime.Now.ToShortDateString()
            }, "registro", txtCnpjInstituicao.Text, txtQuantidadeMaterial.Maximum.ToString(CultureInfo.CurrentCulture));
            switch (retorno)
            {
                case "invalido":
                    MessageBox.Show(
                        @"Quantidade superior à quantidade em estoque.",
                        @"Erro no registro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    break;
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
                        @"Baixa de material realizada com sucesso.",
                        @"Registro de retirada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Close();
                    break;
                default:
                    MessageBox.Show(
                        retorno,
                        @"Registro de retirada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    break;
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

        private void RegistraSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceUsuario.Show();
        }
    }
}