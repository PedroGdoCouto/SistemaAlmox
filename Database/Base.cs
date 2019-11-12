using Npgsql;
using System;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace Database
{
    public class Base
    {
        private const string ConnectionString =
            "Server=127.0.0.1; Port=5432; Database=bd_login; Username=postgres; Password=by900b1xwm;";

        protected static DataTable BuscaTodoRegistro(string tipoBusca)
        {
            var dataTable = new DataTable();
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    switch (tipoBusca)
                    {
                        case "instituicao":
                            var querySelect = "SELECT cnpjInstituicao, razaoSocialInstituicao FROM instituicoes";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "material":
                            querySelect = "SELECT nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial FROM materiais";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "usuario":
                            querySelect = "SELECT cpfUsuario, substring(nomeUsuario FROM '[^ ]+'::text), emailUsuario FROM usuarios";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                    }
                }
                catch (NpgsqlException e)
                {
                    return new DataTable(e.Message);
                }
                pgConnection.Close();
            }

            return dataTable;
        }

        protected static DataTable BuscaUnicoRegistro(string pesquisa, string termoBusca, string tipoBusca = "")
        {
            var dataTable = new DataTable();
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    var querySelect = "";
                    switch (termoBusca)
                    {
                        case "instituicao":
                            querySelect =
                                $"SELECT cnpjInstituicao, razaoSocialInstituicao FROM instituicoes WHERE cnpjInstituicao = '{pesquisa}'";
                            
                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "material":
                            switch (tipoBusca)
                            {
                                case "codigo":
                                    querySelect =
                                        $"SELECT nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial FROM materiais WHERE idMaterial::text LIKE '%{pesquisa}%'";
                                    break;
                                case "local":
                                    querySelect =
                                        $"SELECT nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial FROM materiais WHERE localizacaoMaterial LIKE upper('%{pesquisa}%')";
                                    break;
                                case "nome":
                                    querySelect =
                                        $"SELECT nomeMaterial, descricaoMaterial, quantidadeMaterial, localizacaoMaterial FROM materiais WHERE nomeMaterial LIKE initcap('%{pesquisa}%')";
                                    break;
                            }
                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "usuario":
                            querySelect =
                                $"SELECT cpfUsuario, substring(nomeUsuario FROM '[^ ]+'::text), emailUsuario FROM usuarios WHERE cpfUsuario = '{pesquisa}'";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                    }
                }
                catch (NpgsqlException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return dataTable;
        }

        protected static string LoginUsuario(string[] args)
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    const string querySelect =
                        "SELECT tipoUsuario from usuarios WHERE emailUsuario = (@email) AND senhaUsuario = crypt((@senha), senhaUsuario)";

                    using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                    {
                        pgSelect.Parameters.AddWithValue("email", args[0]);
                        pgSelect.Parameters.AddWithValue("senha", args[1]);
                        
                        using (var reader = pgSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
                catch (NpgsqlException e)
                {
                    return @"Não foi possível iniciar a conexão com o banco de dados.
Caso o erro persista, contate o administrador do sistema. " + e.Message;
                }
                pgConnection.Close();
            }

            return "nulo";
        }

        protected static string ResgateAcesso(string[] args)
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    var querySelect =
                        "SELECT count(*) FROM usuarios WHERE emailUsuario = (@email) AND dataNascimento = (@nascimento) AND cpfUsuario = (@cpf)";
                    var retorno = 0;

                    using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                    {
                        pgSelect.Parameters.AddWithValue("email", args[0]);
                        pgSelect.Parameters.AddWithValue("nascimento", args[1]);
                        pgSelect.Parameters.AddWithValue("cpf", args[2]);
                        
                        using (var reader = pgSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                retorno = reader.GetInt32(0);
                            }
                        }
                    }

                    if (retorno == 1)
                    {
                        const string queryUpdate =
                            "UPDATE usuarios SET senhaUsuario = crypt((@senha), gen_salt((@crypt), 8)) WHERE emailUsuario = (@email) AND dataNascimento = (@nascimento) AND cpfUsuario = (@cpf)";

                        using (var pgUpdate = new NpgsqlCommand(queryUpdate, pgConnection))
                        {
                            pgUpdate.Parameters.AddWithValue("email", args[0]);
                            pgUpdate.Parameters.AddWithValue("nascimento", args[1]);
                            pgUpdate.Parameters.AddWithValue("cpf", args[2]);
                            pgUpdate.Parameters.AddWithValue("senha", args[3]);
                            pgUpdate.Parameters.AddWithValue("crypt", "bf");
                            pgUpdate.ExecuteNonQuery();
                            
                            querySelect =
                                "SELECT count(*) FROM usuarios WHERE emailUsuario = (@email) AND senhaUsuario = crypt((@senha), senhaUsuario)";

                            using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                            {
                                pgSelect.Parameters.AddWithValue("email", args[0]);
                                pgSelect.Parameters.AddWithValue("senha", args[3]);

                                using (var reader = pgSelect.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (reader.GetInt32(0) == 1) return "atualizado";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return @"nulo";
                    }
                }
                catch (NpgsqlException e)
                {
                    return @"Não foi possível iniciar a conexão com o banco de dados.
Caso o erro persista, contate o administrador do sistema. " + e.Message;
                }
                pgConnection.Close();
            }

            return "nulo";
        }
    }
}