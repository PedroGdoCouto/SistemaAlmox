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

        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("usuario");
        }

        public static DataTable BuscaUnica(string termoBusca)
        {
            return BuscaUnicoRegistro(termoBusca, "usuario");
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
                return SenhaUsuario == ValidaSenha ?
                    ResgateAcesso(new [] {EmailUsuario, DataNascimento, CpfUsuario, SenhaUsuario}) :
                    @"divergente";
            }

            return @"invalido";
        }
    }
}