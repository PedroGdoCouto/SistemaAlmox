using System.Data;
using Database;
using System.Diagnostics;
using System.Linq;

namespace Business
{
    public class Usuario : Base
    {
        private string CpfUsuario { get; set; }
        private string NomeUsuario { get; set; }
        private string DataNascimento { get; set; }
        private string EmailUsuario { get; set; }
        private string SenhaUsuario { get; set; }
        private string ValidaSenha { get; set; }

        public string AtualizarRegistro(string[] args, bool adm)
        {
            CpfUsuario = args[0];
            NomeUsuario = args[1];
            DataNascimento = args[2];
            EmailUsuario = args[3];
            SenhaUsuario = args[4];
            ValidaSenha = args[5];
            if (!EmailUsuario.Contains("@") || !EmailUsuario.Contains(".com")) return @"invalido";
            if (adm)
            {
                return SenhaUsuario == ValidaSenha
                    ? AtualizarDados(new [] {CpfUsuario, NomeUsuario, DataNascimento, EmailUsuario, SenhaUsuario}, "usuario", "adm")
                    : @"divergente";
            }
            
            return SenhaUsuario == ValidaSenha
                ? AtualizarDados(new [] {CpfUsuario, NomeUsuario, DataNascimento, EmailUsuario, SenhaUsuario}, "usuario", "usuario")
                : @"divergente";
        }

        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("usuario");
        }

        public static DataTable BuscaUnica(string termoBusca)
        {
            return BuscaUnicoRegistro(termoBusca, "usuario");
        }

        public static string BuscaUsuario(string email)
        {
            return BuscaRegistroUsuario(email);
        }

        public static string ExcluirRegistro(string cpf)
        {
            return ExcluirDados(cpf, "usuario");
        }

        public string ValidarCadastro(string[] args, bool adm)
        {
            CpfUsuario = args[0];
            NomeUsuario = args[1];
            DataNascimento = args[2];
            EmailUsuario = args[3];
            SenhaUsuario = args[4];
            ValidaSenha = args[5];
            if (!EmailUsuario.Contains("@") || !EmailUsuario.Contains(".com")) return @"invalido";
            if (adm)
            {
                return SenhaUsuario == ValidaSenha
                    ? CadastrarDados(new [] {CpfUsuario, NomeUsuario, DataNascimento, EmailUsuario, SenhaUsuario}, "usuario", "adm")
                    : @"divergente";
            }
            
            return SenhaUsuario == ValidaSenha
                    ? CadastrarDados(new [] {CpfUsuario, NomeUsuario, DataNascimento, EmailUsuario, SenhaUsuario}, "usuario", "usuario")
                    : @"divergente";
        }
        
        public string ValidarLogin(string[] args)
        {
            EmailUsuario = args[0];
            SenhaUsuario = args[1];
            if (EmailUsuario.Contains("@") && EmailUsuario.Contains(".com"))
            {
                return LoginUsuario(new[] {EmailUsuario, SenhaUsuario});
            }
            
            return @"invalido";
        }

        public string ValidarResgate(string[] args)
        {
            EmailUsuario = args[0];
            DataNascimento = args[1];
            CpfUsuario = args[2];
            SenhaUsuario = args[3];
            ValidaSenha = args[4];
            if (EmailUsuario.Contains("@") && EmailUsuario.Contains(".com"))
            {
                return SenhaUsuario == ValidaSenha
                    ? ResgateAcesso(new[] {EmailUsuario, DataNascimento, CpfUsuario, SenhaUsuario})
                    : @"divergente";
            }

            return @"invalido";
        }
    }
}