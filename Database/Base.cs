﻿using Npgsql;
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

        protected static string AtualizarDados(string[] args, string termoBusca, string tipoUsuario = "")
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    switch (termoBusca)
                    {
                        case "instituicao":
                            var queryUpdate =
                                 "UPDATE instituicoes SET razaoSocialInstituicao = (@razaoSocial), enderecoInstituicao = (@endereco) WHERE cnpjInstituicao = (@cnpj)";

                            using (var pgUpdate = new NpgsqlCommand(queryUpdate, pgConnection))
                            {
                                pgUpdate.Parameters.AddWithValue("cnpj", args[0]);
                                pgUpdate.Parameters.AddWithValue("razaoSocial", args[1]);
                                pgUpdate.Parameters.AddWithValue("endereco", args[2]);
                                if (pgUpdate.ExecuteNonQuery() == 1) return "atualizado";
                            }
                            break;
                        case "material":
                            queryUpdate =
                                "UPDATE materiais SET nomeMaterial = (@nome), descricaoMaterial = (@descricao), quantidadeMaterial = (@quantidade), localizacaoMaterial = (@localizacao) WHERE idMaterial::text = (@id)";

                            using (var pgUpdate = new NpgsqlCommand(queryUpdate, pgConnection))
                            {
                                pgUpdate.Parameters.AddWithValue("id", args[0]);
                                pgUpdate.Parameters.AddWithValue("nome", args[1]);
                                pgUpdate.Parameters.AddWithValue("descricao", args[2]);
                                pgUpdate.Parameters.AddWithValue("quantidade", int.Parse(args[3]));
                                pgUpdate.Parameters.AddWithValue("localizacao", args[4]);
                                if (pgUpdate.ExecuteNonQuery() == 1) return "atualizado";
                            }
                            break;
                        case "usuario":
                            queryUpdate =
                                "UPDATE usuarios SET nomeUsuario = (@nome), dataNascimento = (@nascimento), emailUsuario = (@email), senhaUsuario = crypt((@senha), gen_salt((@crypt), 8)), tipoUsuario = (@tipo) WHERE cpfUsuario = (@cpf)";

                            using (var pgUpdate = new NpgsqlCommand(queryUpdate, pgConnection))
                            {
                                pgUpdate.Parameters.AddWithValue("cpf", args[0]);
                                pgUpdate.Parameters.AddWithValue("nome", args[1]);
                                pgUpdate.Parameters.AddWithValue("nascimento", args[2]);
                                pgUpdate.Parameters.AddWithValue("email", args[3]);
                                pgUpdate.Parameters.AddWithValue("senha", args[4]);
                               
                                pgUpdate.Parameters.AddWithValue("tipo", tipoUsuario);
                                pgUpdate.Parameters.AddWithValue("crypt", "bf");
                                if (pgUpdate.ExecuteNonQuery() == 1) return "atualizado";
                            }
                            break;
                    }
                }
                catch (NpgsqlException e)
                {
                    return @"Não foi possível iniciar a conexão com o banco de dados.
Caso o erro persista, contate o administrador do sistema. " + e.Message;
                }
            }

            return "nulo";
        }

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
                            var querySelect = "SELECT cnpjInstituicao, razaoSocialInstituicao, enderecoInstituicao FROM instituicoes";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "material":
                            querySelect =
                                "SELECT * FROM materiais";

                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "usuario":
                            querySelect = "SELECT cpfUsuario, nomeUsuario, emailUsuario, DataNascimento FROM usuarios";
                                /* "SELECT cpfUsuario, substring(nomeUsuario FROM '[^ ]+'::text), emailUsuario, dataNascimento FROM usuarios"; */

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

        protected static string BuscaUnicoCnpj(string pesquisa)
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    var querySelect =
                        $"SELECT razaoSocialInstituicao FROM instituicoes WHERE cnpjInstituicao = '{pesquisa}'";

                    using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                    {
                        using (var reader = pgSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
                catch (NpgsqlException)
                {
                    return "offline";
                }
            }
            
            return "nulo";
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
                                $"SELECT cnpjInstituicao, razaoSocialInstituicao, enderecoInstituicao FROM instituicoes WHERE cnpjInstituicao = '{pesquisa}'";
                            
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
                                        $"SELECT * FROM materiais WHERE idMaterial::text LIKE '%{pesquisa}%'";
                                    break;
                                case "local":
                                    querySelect =
                                        $"SELECT * FROM materiais WHERE localizacaoMaterial LIKE '%{pesquisa}%'";
                                    break;
                                case "nome":
                                    querySelect =
                                        $"SELECT * FROM materiais WHERE nomeMaterial LIKE '%{pesquisa}%'";
                                    break;
                            }
                            using (var pgDataTable = new NpgsqlDataAdapter(querySelect, pgConnection))
                            {
                                pgDataTable.Fill(dataTable);
                            }
                            break;
                        case "usuario":
                            querySelect =
                                $"SELECT cpfUsuario, nomeUsuario, emailUsuario, dataNascimento FROM usuarios WHERE cpfUsuario = '{pesquisa}'";
                                /* $"SELECT cpfUsuario, substring(nomeUsuario FROM '[^ ]+'::text), emailUsuario, dataNascimento FROM usuarios WHERE cpfUsuario = '{pesquisa}'"; */

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
            }

            return dataTable;
        }

        protected static string CadastrarDados(string[] args, string termoBusca, string tipoUsuario = "")
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    switch (termoBusca)
                    {
                        case "instituicao":
                            var queryInsert =
                                "INSERT INTO instituicoes VALUES (DEFAULT, (@cnpj), (@razaoSocial), (@endereco))";

                            using (var pgInsert = new NpgsqlCommand(queryInsert, pgConnection))
                            {
                                pgInsert.Parameters.AddWithValue("cnpj", args[0]);
                                pgInsert.Parameters.AddWithValue("razaoSocial", args[1]);
                                pgInsert.Parameters.AddWithValue("endereco", args[2]);
                                if (pgInsert.ExecuteNonQuery() == 1) return "registrado";
                            }
                            break;
                        case "material":
                            queryInsert =
                                "INSERT INTO materiais VALUES (DEFAULT, (@nome), (@descricao), (@quantidade), (@localizacao))";

                            using (var pgInsert = new NpgsqlCommand(queryInsert, pgConnection))
                            {
                                pgInsert.Parameters.AddWithValue("nome", args[0]);
                                pgInsert.Parameters.AddWithValue("descricao", args[1]);
                                pgInsert.Parameters.AddWithValue("quantidade", int.Parse(args[2]));
                                pgInsert.Parameters.AddWithValue("localizacao", args[3]);
                                if (pgInsert.ExecuteNonQuery() == 1) return "registrado";
                            }
                            break;
                        case "usuario":
                            queryInsert =
                                "INSERT INTO usuarios VALUES ((@cpf), (@nome), (@nascimento), (@email), crypt((@senha), gen_salt((@crypt), 8)), (@tipo))";

                            using (var pgInsert = new NpgsqlCommand(queryInsert, pgConnection))
                            {
                                pgInsert.Parameters.AddWithValue("cpf", args[0]);
                                pgInsert.Parameters.AddWithValue("nome", args[1]);
                                pgInsert.Parameters.AddWithValue("nascimento", args[2]);
                                pgInsert.Parameters.AddWithValue("email", args[3]);
                                pgInsert.Parameters.AddWithValue("senha", args[4]);
                                pgInsert.Parameters.AddWithValue("crypt", "bf");
                                pgInsert.Parameters.AddWithValue("tipo", tipoUsuario);
                                if (pgInsert.ExecuteNonQuery() == 1) return "registrado";
                            }
                            break;
                    }
                }
                catch (NpgsqlException e)
                {
                    return @"Não foi possível iniciar a conexão com o banco de dados.
Caso o erro persista, contate o administrador do sistema. " + e.Message;
                }
                pgConnection.Close();
            }
            
            return @"nulo";
        }

        protected static string ExcluirDados(string pesquisa, string termoBusca)
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    switch (termoBusca)
                    {
                        case "instituicao":
                            var queryDelete =
                                "DELETE FROM instituicoes WHERE cnpjInstituicao = (@cnpj)";
                            
                            using (var pgDelete = new NpgsqlCommand(queryDelete, pgConnection))
                            {
                                pgDelete.Parameters.AddWithValue("cnpj", pesquisa);
                                if (pgDelete.ExecuteNonQuery() == 1) return "excluido";
                            }
                            break;
                        case "material":
                            queryDelete =
                                "DELETE FROM materiais WHERE idMaterial::text = (@id)";

                            using (var pgDelete = new NpgsqlCommand(queryDelete, pgConnection))
                            {
                                pgDelete.Parameters.AddWithValue("id", pesquisa);
                                if (pgDelete.ExecuteNonQuery() == 1) return "excluido";
                            }
                            break;
                        case "usuario":
                            queryDelete =
                                "DELETE FROM usuarios WHERE cpfUsuario = (@cpf)";

                            using (var pgDelete = new NpgsqlCommand(queryDelete, pgConnection))
                            {
                                pgDelete.Parameters.AddWithValue("cpf", pesquisa);
                                if (pgDelete.ExecuteNonQuery() == 1) return "excluido";
                            }
                            break;
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
                    const string querySelect =
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
                            if (pgUpdate.ExecuteNonQuery() == 1) return "atualizado";
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

        protected static string RegistroEstoque(string[] args, string operacao, string tipoRegistro, string estoque = "")
        {
            using (var pgConnection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    pgConnection.Open();
                    switch (tipoRegistro)
                    {
                        case "entrada":
                            switch (operacao)
                            {
                                case "busca":
                                    const string querySelect =
                                        "SELECT dataRegistro FROM registroEntrada WHERE idMaterial = (@idMaterial) ORDER BY idRegistro DESC LIMIT 1";
                                    using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                                    {
                                        pgSelect.Parameters.AddWithValue("idMaterial", int.Parse(args[0]));
                                        using (var reader = pgSelect.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                return reader.GetString(0);
                                            }
                                        }
                                    }

                                    break;
                                case "registro":
                                    break;
                            }

                            break;
                        case "saida":
                            switch (operacao)
                            {
                                case "busca":
                                    const string querySelect =
                                        "SELECT dataRegistro FROM registroSaida WHERE idMaterial = (@idMaterial) ORDER BY idRegistro DESC LIMIT 1";
                                    using (var pgSelect = new NpgsqlCommand(querySelect, pgConnection))
                                    {
                                        pgSelect.Parameters.AddWithValue("idMaterial", int.Parse(args[0]));
                                        using (var reader = pgSelect.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                return reader.GetString(0);
                                            }
                                        }
                                    }

                                    break;
                                case "registro":
                                    const string queryInsert =
                                        "INSERT INTO registroSaida VALUES (DEFAULT, (@saida), (@quantidade), (@instituicao), (@idMaterial))";

                                    using (var pgInsert = new NpgsqlCommand(queryInsert, pgConnection))
                                    {
                                        pgInsert.Parameters.AddWithValue("idMaterial", int.Parse(args[0]));
                                        pgInsert.Parameters.AddWithValue("quantidade", int.Parse(args[1]));
                                        pgInsert.Parameters.AddWithValue("saida", args[2]);
                                        pgInsert.Parameters.AddWithValue("instituicao", args[3]);
                                        if (pgInsert.ExecuteNonQuery() == 1)
                                        {
                                            const string queryUpdate =
                                                "UPDATE materiais SET quantidadeMaterial = (@estoque) WHERE idMaterial = (@idMaterial)";

                                            using (var pgUpdate = new NpgsqlCommand(queryUpdate, pgConnection))
                                            {
                                                pgUpdate.Parameters.AddWithValue("idMaterial", int.Parse(args[0]));
                                                pgUpdate.Parameters.AddWithValue("estoque", int.Parse(estoque));
                                                if (pgUpdate.ExecuteNonQuery() == 1) return "registrado";
                                            }
                                        }
                                    }

                                    break;
                            }
                            break;
                    }
                }
                catch (NpgsqlException)
                {
                    return "offline";
                }
                catch (Exception e)
                {
                    return "Erro: " + e.Message;
                }
            }
            
            return "nulo";
        }
    }
}