using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using tbt.database;


namespace tbt.Models
{
    internal class FornecedorDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Fornecedor obj_for)
        {
            try
            {
                var comando = _conn.Query();

                // Especifica as colunas corretamente no INSERT
                comando.CommandText = @"INSERT INTO fornecedor 
                                (razao_social_for, nome_fantasia_for, telefone_for, email_for, estado_for, cidade_for, bairro_for, rua_for, numero_for)
                                VALUES (@razao_social, @nome_fantasia, @telefone, @email, @estado, @cidade, @bairro, @rua, @numero);";

                // Adiciona os parâmetros
                comando.Parameters.AddWithValue("@razao_social", obj_for.razao_social);
                comando.Parameters.AddWithValue("@nome_fantasia", obj_for.nome_fantasia);
                comando.Parameters.AddWithValue("@telefone", obj_for.telefone);
                comando.Parameters.AddWithValue("@email", obj_for.email);
                comando.Parameters.AddWithValue("@estado", obj_for.estado);
                comando.Parameters.AddWithValue("@cidade", obj_for.cidade);
                comando.Parameters.AddWithValue("@bairro", obj_for.bairro);
                comando.Parameters.AddWithValue("@rua", obj_for.rua);
                comando.Parameters.AddWithValue("@numero", obj_for.numero);

                // Executa a consulta e retorna o número de linhas afetadas
                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }
                else if (resultado > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Fornecedor select(string Nome_fantasia)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM fornecedor WHERE nome_fantasia_for = @nome_fantasia";
                comando.Parameters.AddWithValue("@nome_fantasia", Nome_fantasia);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor
                        {
                            id = reader.GetInt32("id_for"),
                            razao_social = reader.GetString("razao_social_for"),
                            nome_fantasia = reader.GetString("nome_fantasia_for"),
                            telefone = reader.GetString("telefone_for"),
                            email = reader.GetString("email_for"),
                            estado = reader.GetString("estado_for"),
                            cidade = reader.GetString("cidade_for"),
                            bairro = reader.GetString("bairro_for"),
                            rua = reader.GetString("rua_for"),
                            numero = reader.GetInt32("numero_for"),
                        };
                        return fornecedor;
                    }
                    else
                    {
                        return new Fornecedor
                        {
                            id = 0,
                            razao_social = "Fornecedor não encontrado",
                            nome_fantasia = "",
                            email = "",
                            telefone = "",
                            estado = "",
                            cidade = "",
                            bairro = "",
                            rua = "",
                            numero = 0
                        };
                    }
                }
            }
            catch
            {
                return new Fornecedor
                {
                    id = 0,
                    razao_social = "Fornecedor não encontrado",
                    nome_fantasia = "",
                    email = "",
                    telefone = "",
                    estado = "",
                    cidade = "",
                    bairro = "",
                    rua = "",
                    numero = 0
                };
            }
        }

        public List<Fornecedor> Obterfornecedores()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM fornecedor";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fornecedor = new Fornecedor
                        {
                            id = reader.GetInt32("id_for"),
                            razao_social = reader.GetString("razao_social_for"),
                            nome_fantasia = reader.GetString("nome_fantasia_for"),
                            telefone = reader.GetString("telefone_for"),
                            email = reader.GetString("email_for"),
                            estado = reader.GetString("estado_for"),
                            cidade = reader.GetString("cidade_for"),
                            bairro = reader.GetString("bairro_for"),
                            rua = reader.GetString("rua_for"),
                            numero = reader.GetInt32("numero_for"),
                        };

                        fornecedores.Add(fornecedor);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar fornecedores", ex);
            }

            return fornecedores;
        }

        public void Delete(int id)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM fornecedor WHERE id_for = @id";

                comando.Parameters.AddWithValue("@id", id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}