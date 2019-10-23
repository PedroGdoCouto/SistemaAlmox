using Database;

namespace Business
{
    public class Usuario : Base
    {
        public Usuario(string email, string nome, string senha, int resultado)
        {
            EmailUsuario = email;
            NomeUsuario = nome;
            SenhaUsuario = senha;
            Resultado = resultado;
        }
        
        public Usuario() {}

        public string Retorno()
        {
            if (Resultado == 1)
            {
                return "Dados validados com sucesso.";
            }

            return "Dados incorretos, tente novamente.";
        }
    }
}