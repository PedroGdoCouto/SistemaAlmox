using Database;
using System.Data;

namespace Business
{
    public class Material : Base
    {
        private string NomeMaterial {get; set;}
        private int QuantidadeMaterial { get; set; }
        private string LocalizacaoMaterial { get; set; }
        private string UltimaEntrada { get; set; }
        private string UltimaSaida { get; set; }
        private string ChaveNotaFiscal { get; set; }
        
        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("material");
        }

        public static DataTable BuscaUnica(string pesquisa, string tipoBusca)
        {
            return BuscaUnicoRegistro(pesquisa, "material", tipoBusca);
        }
    }
}