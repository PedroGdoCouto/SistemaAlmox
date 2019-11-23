using Database;
using System.Data;

namespace Business
{
    public class Instituicao : Base
    {
        private string CnpjInstituicao { get; set; }
        private string RazaoSocial { get; set; }
        private string EnderecoInstituicao { get; set; }

        public string AtualizarRegistro(string[] args)
        {
            CnpjInstituicao = args[0];
            RazaoSocial = args[1];
            EnderecoInstituicao = args[2] + " - " + args[3] + " - " + args[4] + " - " + args[5] + " - " + args[6] +
                                  " - " + args[7];
            return AtualizarDados(new []
            {
                CnpjInstituicao, RazaoSocial, EnderecoInstituicao
            }, "instituicao");
        }

        public static string BuscaInstituicao(string cnpj)
        {
            return BuscaRegistroInstituicao(cnpj);
        }
        
        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("instituicao");
        }

        public static DataTable BuscaUnica(string cnpj)
        {
            return BuscaUnicoRegistro(cnpj, "instituicao");
        }

        public static string ExcluirRegistro(string cnpj)
        {
            return ExcluirDados(cnpj, "instituicao");
        }

        public string ValidarCadastro(string[] args)
        {
            CnpjInstituicao = args[0];
            RazaoSocial = args[1];
            EnderecoInstituicao = args[2] + " - " + args[3] + " - " + args[4] + " - " + args[5] + " - " + args[6] +
                                  " - " + args[7];
            return CadastrarDados(new []
            {
                CnpjInstituicao, RazaoSocial, EnderecoInstituicao
            }, "instituicao");
        }
    }
}