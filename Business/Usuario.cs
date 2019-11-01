using System.Linq;
using Database;

namespace Business
{
    public class Usuario : Base
    {
        public Usuario(string email, string nome, string senha, string resultado, string validacao)
        {
            EmailUsuario = email;
            NomeUsuario = nome;
            SenhaUsuario = senha;
            ValidaSenha = validacao;
            Resultado = resultado;
        }
        
        public Usuario() {}

        public void ValidaCadastro()
        {
            if (EmailUsuario.Contains(".com") && EmailUsuario.Contains("@"))
            {
                Cadastrar(SenhaUsuario == ValidaSenha ? 1 : 0);
                /*
                if (SenhaUsuario == ValidaSenha)
                {
                    Cadastrar(1);
                }
                else
                {
                    Cadastrar(0);
                }
                */
            }
            else
            {
                Resultado = "O e-mail está incorreto, tente novamente.";
            }
        }

        public string Retorno(string retorno)
        {
            switch (retorno)
            {
                case "acesso":
                    return Resultado == "1" ? @"Dados autenticados com sucesso!" : @"Dados incorretos, tente novamente.";
                case "cadastro":
                    return Resultado == "1" ? @"Usuário registrado com sucesso!" : Resultado;
                default:
                    break;
            }

            return @"Ocorreu um erro no processamento.
Tente novamente ou contate o administrador.";
        }
    }
}