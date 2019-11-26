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
        private static string UltimaEntrada { get; set; }
        private static string UltimaSaida { get; set; }
        private string ChaveNotaFiscal { get; set; }

        public string AtualizarRegistro(string[] args)
        {
            IdMaterial = args[0];
            NomeMaterial = args[1];
            DescricaoMaterial = args[2];
            QuantidadeMaterial = args[3];
            LocalizacaoMaterial = args[4];
            ChaveNotaFiscal = args[5];
            return AtualizarDados(new []
            {
                IdMaterial, NomeMaterial, DescricaoMaterial, QuantidadeMaterial, LocalizacaoMaterial, ChaveNotaFiscal
            }, "material");
        }
        
        public static DataTable BuscaCompleta()
        {
            return BuscaTodoRegistro("material");
        }

        public static DataTable BuscaHistorico(string tipoBusca, string pesquisa = "")
        {
            return BuscaHistoricoCompleto(tipoBusca, pesquisa);
        }

        public static string BuscaMaterial(string tipoBusca, int id = 0)
        {
            switch (tipoBusca)
            {
                case "chave":
                    return BuscaRegistroMaterial(tipoBusca, id);
                case "nome":
                    return BuscaRegistroMaterial(tipoBusca, id);
            }
            
            return BuscaRegistroMaterial(tipoBusca);
        }

        public static DataTable BuscaUnica(string pesquisa, string tipoBusca)
        {
            return BuscaUnicoRegistro(pesquisa, "material", tipoBusca);
        }

        public string EntradaEstoque(string[] args, string operacao)
        {
            IdMaterial = args[0];
            if (operacao == "busca") return RegistroMaterial(new[] {IdMaterial}, operacao, "entrada");
            
            QuantidadeMaterial = args[1];
            UltimaEntrada = args[2];
            LocalizacaoMaterial = args[3];
            ChaveNotaFiscal = args[4];
            return RegistroMaterial(new[]
            {
                IdMaterial, QuantidadeMaterial, UltimaEntrada, LocalizacaoMaterial, ChaveNotaFiscal, args[5]
            }, operacao, "entrada");
        }

        public string SaidaEstoque(string[] args, string operacao)
        {
            IdMaterial = args[0];
            if (operacao == "busca") return RegistroMaterial(new[] {IdMaterial}, operacao, "saida");
            
            QuantidadeMaterial = args[1];
            UltimaSaida = args[2];
            if (int.Parse(args[3]) - int.Parse(QuantidadeMaterial) < 0) return "invalido";
            
            return RegistroMaterial(new []
            {
                IdMaterial, QuantidadeMaterial, UltimaSaida, args[4]
            }, operacao, "saida");
        }

        public string ValidarCadastro(string[] args)
        {
            NomeMaterial = args[0];
            DescricaoMaterial = args[1];
            QuantidadeMaterial = args[2];
            LocalizacaoMaterial = args[3];
            ChaveNotaFiscal = "0";
            return CadastrarDados(new []
            {
                NomeMaterial, DescricaoMaterial, QuantidadeMaterial, LocalizacaoMaterial, ChaveNotaFiscal
            }, "material");
        }
    }
}