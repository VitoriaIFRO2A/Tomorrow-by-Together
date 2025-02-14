using System;
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

                comando.CommandText = "INSERT INTO cliente VALUES (null, @nome, @cpf, @telefone, @estado, @cidade, @estado, @cidade, @rua, @numero, @bairro);" +

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
    }
}