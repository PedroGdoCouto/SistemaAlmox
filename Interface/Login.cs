using Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public sealed partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            menuStripLogin.Renderer = new ProjectRenderer();
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

        /* Separador personalizado para a barra de ferramentas
        private void menuLoginSeparator_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator separator = (ToolStripSeparator) sender;
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkSlateGray), 0, 0, separator.Width, separator.Height);
            e.Graphics.DrawLine(new Pen(Color.FromArgb(255, 0, 100, 100)), 30, separator.Height / 2, separator.Width - 4, separator.Height / 2);
        }
        */

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderColor = Color.Green;
            btnLogin.ForeColor = Color.Green;
        }
        
        /* Barra de ferramentas */
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
        private void txtEmailLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char) Keys.Space;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var interfaceAdministrador = new PainelAdministrador {InterfaceInicial = this};
            interfaceAdministrador.Show();
            Hide();
            /*
            if (string.IsNullOrEmpty(txtEmailLogin.Text) || string.IsNullOrEmpty(txtSenhaLogin.Text))
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
                var usuario = new Usuario();
                var retorno = usuario.ValidarLogin(new[] {txtEmailLogin.Text, txtSenhaLogin.Text});
                switch (retorno)
                {
                    case "adm":
                        txtEmailLogin.Clear();
                        txtSenhaLogin.Clear();
                        var interfaceAdministrador = new PainelAdministrador {InterfaceInicial = this};
                        interfaceAdministrador.Show();
                        Hide();
                        break;
                    case "usuario":
                        txtEmailLogin.Clear();
                        txtSenhaLogin.Clear();
                        var interfaceUsuario = new PainelUsuario {InterfaceInicial = this};
                        interfaceUsuario.Show();
                        Hide();
                        break;
                    case "invalido":
                        MessageBox.Show(
                            @"O e-mail inserido é inválido, tente novamente.",
                            @"Dados incorretos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    case "nulo":
                        MessageBox.Show(
                            @"Dados inválidos, tente novamente.",
                            @"Dados incorretos",
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
            */
        }

        private void chkExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaLogin.UseSystemPasswordChar = !chkExibeSenha.Checked;
            /*
            if (chkExibeSenha.Checked){
                txtSenhaLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaLogin.UseSystemPasswordChar = true;
            }
            */
        }

        private void linkRecuperaAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmailLogin.Clear();
            txtSenhaLogin.Clear();
            var interfaceResgate = new Resgate { InterfaceInicial = this };
            interfaceResgate.Show();
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
        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            var mensagem =
                MessageBox.Show(
                    @"Deseja sair do programa?",
                    @"Encerrar aplicação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            e.Cancel = mensagem != DialogResult.Yes;
        }
    }
}