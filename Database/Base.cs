using System;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Npgsql;

namespace Database
{
    public class Base
    {
        public Base(string email, string nome, string senha)
        {
            EmailUsuario = email;
            NomeUsuario = nome;
            SenhaUsuario = senha;
        }
        
        public Base() {}
        
        public string EmailUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public int Resultado { get; set; }

        public virtual void Acessar()
        {
            DataTable dt = new DataTable();
            string connectionString = String.Format("Server={0}; Port={1}; Username={2}; Password={3}; Database={4};",
                "127.0.0.1", "5432", "postgres", "by900b1xwm", "bd_login");

            using (NpgsqlConnection pgConnection = new NpgsqlConnection(connectionString))
            {
                // Define a instrução SQL
                string queryString = string.Format(
                    "SELECT count(*) FROM usuarios WHERE emailUsuario = '{0}' AND senhaUsuario = '{1}'",
                    EmailUsuario, SenhaUsuario);

                // Semântica similar ao Ruby
                // string queryString = $"INSERT INTO usuarios ('{Cpf}', '{Nome}', '{Telefone}')";
                
                // Abre a conexão com o banco
                pgConnection.Open();
                using (NpgsqlCommand pgCommand = new NpgsqlCommand(queryString, pgConnection))
                {
                    using (var reader = pgCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Resultado = reader.GetInt32(0);
                        }
                    }
                }
            }
        }
    }
}