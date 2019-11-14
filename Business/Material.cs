using Database;
using System.Data;

namespace Business
{
    public class Material : Base
    {
        private string IdMaterial { get; set; }
        private string NomeMaterial { get; set; }
        private string DescricaoMaterial { get; set; }
        private string QuantidadeMaterial { get; set; }
        private string LocalizacaoMaterial { get; set; }
        private string UltimaEntrada { get; set; }
        private string UltimaSaida { get; set; }
        private string ChaveNotaFiscal { get; set; }

        public string AtualizarRegistro(string[] args)
        {
            IdMaterial = args[0];
            NomeMaterial = args[1];
            DescricaoMaterial = args[2];
            QuantidadeMaterial = args[3];
            LocalizacaoMaterial = args[4];
            return AtualizarDados(new []
            {
                IdMaterial, NomeMaterial, DescricaoMaterial, QuantidadeMaterial, LocalizacaoMaterial
            }, "material");
        }
        
        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("material");
        }

        public static DataTable BuscaUnica(string pesquisa, string tipoBusca)
        {
            return BuscaUnicoRegistro(pesquisa, "material", tipoBusca);
        }

        public static string ExcluirRegistro(string id)
        {
            return ExcluirDados(id, "material");
        }

        public string ValidarCadastro(string[] args)
        {
            NomeMaterial = args[0];
            DescricaoMaterial = args[1];
            QuantidadeMaterial = args[2];
            LocalizacaoMaterial = args[3];
            return CadastrarDados(new []
            {
                NomeMaterial, DescricaoMaterial, QuantidadeMaterial, LocalizacaoMaterial
            }, "material");
        }
    }
}