using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                comando.CommandText = "INSERT INTO fornecedor VALUES (null, @razao_social, @nome_fantasia, @email, @telefone, @estado, @cidade, @bairro, @rua, @numero);" +

                comando.Parameters.AddWithValue("@razao_social", obj_for.razao_social);
                comando.Parameters.AddWithValue("@nome_fantasia", obj_for.nome_fantasia);
                comando.Parameters.AddWithValue("@email", obj_for.email);
                comando.Parameters.AddWithValue("@telefone", obj_for.telefone);
                comando.Parameters.AddWithValue("@estado", obj_for.estado);
                comando.Parameters.AddWithValue("@cidade", obj_for.cidade);
                comando.Parameters.AddWithValue("@bairro", obj_for.bairro);
                comando.Parameters.AddWithValue("@rua", obj_for.rua);
                comando.Parameters.AddWithValue("@numero", obj_for.numero);




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