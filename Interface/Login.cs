using System;
using System.Drawing;
using System.Windows.Forms;
using Business;

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            menuStripLogin.Renderer = new ProjectRenderer();
            menuNovoCadastro.ForeColor = Color.White;
            menuNovoCadastro.BackColor = Color.Black;
            menuRecuperarSenha.ForeColor = Color.White;
            menuRecuperarSenha.BackColor = Color.Black;
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
            public override Color MenuItemSelectedGradientBegin => Color.DimGray;
            public override Color MenuItemSelectedGradientEnd => Color.DimGray;
        }

        private void menuLoginSeparator_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator separator = (ToolStripSeparator) sender;
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, separator.Width, separator.Height);
            e.Graphics.DrawLine(new Pen(Color.White), 30, separator.Height / 2, separator.Width - 4, separator.Height / 2);
        }

        /* Funcionalidades da aplicação */
        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                var usuario = new Usuario
                {
                    EmailUsuario = txtEmailLogin.Text,
                    SenhaUsuario = txtSenhaLogin.Text
                };
                usuario.Acessar();
                MessageBox.Show(
                    usuario.Retorno("acesso"),
                    @"Validação de acesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            var mensagem = MessageBox.Show(
                @"Deseja sair do programa?",
                @"Encerrar aplicação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            switch (mensagem)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    Show();
                    break;
                default:
                    MessageBox.Show(
                        @"Ocorreu um erro durante o processo.",
                        @"Erro de processamento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }
        
        /* Barra de ferramentas */
        private void menuNovoCadastro_Click(object sender, EventArgs e)
        {
            txtEmailLogin.Clear();
            txtSenhaLogin.Clear();
            Cadastro interfaceCadastro = new Cadastro { InterfaceInicial = this };
            interfaceCadastro.Show();
            Hide();
        }

        private void menuRecuperarSenha_Click(object sender, EventArgs e)
        {
            txtEmailLogin.Clear();
            txtSenhaLogin.Clear();
            Resgate interfaceResgate = new Resgate() { InterfaceInicial = this };
            interfaceResgate.Show();
            Hide();
        }

        private void menuFinalizarPrograma_Click(object sender, EventArgs e)
        {
            Close();
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