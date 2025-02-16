﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tbt.database;


namespace tbt.Models
{
    internal class ClienteDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Cliente obj_cli)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO cliente VALUES (null, @nome, @cpf, @telefone, @estado, @cidade, @rua, @numero, @bairro);" +

                comando.Parameters.AddWithValue("@nome", obj_cli.nome);
                comando.Parameters.AddWithValue("@cpf", obj_cli.cpf);
                comando.Parameters.AddWithValue("@telefone", obj_cli.telefone);
                comando.Parameters.AddWithValue("@estado", obj_cli.estado);
                comando.Parameters.AddWithValue("@cidade", obj_cli.cidade);
                comando.Parameters.AddWithValue("@rua", obj_cli.rua);
                comando.Parameters.AddWithValue("@numero", obj_cli.numero);
                comando.Parameters.AddWithValue("@bairro", obj_cli.bairro);


                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Cliente Select(string cpf_cliente)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM cliente WHERE cpf_cli = @cpf";
                comando.Parameters.AddWithValue("@cpf", cpf_cliente);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            id = reader.GetInt32("id_cli"),
                            nome = reader.GetString("nome_cli"),
                            cpf = reader.GetString("cpf_cli"),
                            telefone = reader.GetString("telefone_cli"),
                            estado = reader.GetString("estado_cli"),
                            cidade = reader.GetString("cidade_cli"),
                            rua = reader.GetString("rua_cli"),
                            numero = reader.GetInt32("numero_cli"),
                            bairro = reader.GetString("bairro_cli")
                        };
                        return cliente;
                    }
                    else
                    {
                        throw new Exception("Cliente não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar consulta.", ex);
            }
        }



        public List<Cliente> ObterClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM cliente";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = new Cliente
                        {
                            id = reader.GetInt32("id_cli"),
                            nome = reader.GetString("nome_cli"),
                            cpf = reader.GetString("cpf_cli"),
                            telefone = reader.GetString("telefone_cli"),
                            estado = reader.GetString("estado_cli"),
                            cidade = reader.GetString("cidade_cli"),
                            rua = reader.GetString("rua_cli"),
                            numero = reader.GetInt32("numero_cli"),
                            bairro = reader.GetString("bairro_cli")
                        };

                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao buscar clientes", ex);
            }

            return clientes; 
        }

    }
}