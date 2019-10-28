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
        public string ValidaSenha { get; set; }
        public string Resultado { get; set; }

        private string _connectionString = String.Format(
            "Server={0}; Port={1}; Username={2}; Password={3}; Database={4};",
            "127.0.0.1", "5432", "postgres", "by900b1xwm", "bd_login"
        );

        public void Acessar()
        {
            using (NpgsqlConnection pgConnection = new NpgsqlConnection(_connectionString))
            {
                // Define a instrução SQL
                string queryString = String.Format(
                    "SELECT count(*) FROM usuarios WHERE emailUsuario = '{0}' AND senhaUsuario = md5('{1}')",
                    EmailUsuario, SenhaUsuario);

                // Semântica similar ao Ruby
                // string queryString = $"INSERT INTO usuarios ('{Cpf}', '{Nome}', '{Telefone}')";
                
                // Abre a conexão com o banco
                pgConnection.Open();
                using (NpgsqlCommand pgCommand = new NpgsqlCommand(queryString, pgConnection))
                {
                    pgCommand.Prepare();
                    using (var reader = pgCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Resultado = reader.GetInt32(0).ToString();
                        }
                    }
                }
                pgConnection.Close();
            }
        }

        protected void Cadastrar(int validacao)
        {
            using (NpgsqlConnection pgConnection = new NpgsqlConnection(_connectionString))
            {
                string queryString = String.Format(
                    "INSERT INTO usuarios VALUES ('{0}', '{1}', md5('{2}'))",
                    EmailUsuario, NomeUsuario, SenhaUsuario);
                
                pgConnection.Open();
                using (NpgsqlCommand pgCommand = new NpgsqlCommand(queryString, pgConnection))
                {
                    if (validacao == 1)
                    {
                        pgCommand.Prepare();
                        pgCommand.ExecuteNonQuery();
                        string selectString = String.Format(
                            "SELECT count(*) FROM usuarios WHERE emailUsuario = '{0}' AND senhaUsuario = md5('{1}')",
                            EmailUsuario, SenhaUsuario);
                        using (NpgsqlCommand pgSelect = new NpgsqlCommand(selectString, pgConnection))
                        {
                            pgSelect.Prepare();
                            using (var reader = pgSelect.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Resultado = reader.GetInt32(0).ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        Resultado = "Senhas estão divergentes, tente novamente.";
                    }
                }
                pgConnection.Close();
            }
        }
    }
}