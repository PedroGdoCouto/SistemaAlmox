using Database;
using System.Data;

namespace Business
{
    public class Instituicao : Base
    {
        private string CnpjInstituicao { get; set; }
        private string RazaoSocial { get; set; }

        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("instituicao");
        }

        public static DataTable BuscaUnica(string cnpj)
        {
            return BuscaUnicoRegistro(cnpj, "instituicao");
        }
    }
}