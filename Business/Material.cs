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

        public static string EntradaEstoque(string id, string operacao)
        {
            /*
            var retorno = RegistroEstoque(new []
            {
            }, operacao, "saida");
            switch (retorno)
            {
                case "offline":
                    return retorno;
                case "nulo":
                    return retorno;
                default:
                    return retorno;
            }
            */

            return "nulo";
        }

        public static string ExcluirRegistro(string id)
        {
            return ExcluirDados(id, "material");
        }

        public string SaidaEstoque(string[] args, string operacao, string cnpj = "", string estoque = "")
        {
            IdMaterial = args[0];
            if (operacao == "busca") return RegistroEstoque(new[] {IdMaterial}, operacao, "saida");
            
            QuantidadeMaterial = args[1];
            UltimaSaida = args[2];
            if (int.Parse(estoque) - int.Parse(QuantidadeMaterial) < 0) return "invalido";
            estoque = (int.Parse(estoque) - int.Parse(QuantidadeMaterial)).ToString();
            
            return RegistroEstoque(new []
            {
                IdMaterial, QuantidadeMaterial, UltimaSaida, cnpj
            }, operacao, "saida", estoque);
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