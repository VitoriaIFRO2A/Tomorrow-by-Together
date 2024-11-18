using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tbt.database;


namespace tbt.Models
{
    internal class Cliente_fisicoDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Cliente_fisico obj_cli_fis, Endereco obj_end, Cliente obj_cli)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Endereco VALUES (null, @cep, @rua, @numero, @bairro, @cidade, @estado, @porto_referencia);" +
                "SET @endereco_id = LAST_INSERT_ID();" +
                "INSERT INTO Cliente VALUES (null, 'fisico', @telefone, @endereco_id);" +
                "SET @cliente_id = LAST_INSERT_ID();" +
                "INSERT INTO Cliente_fisico VALUES (null, @nome, @rg, @cpf, @data_nascimento, @estado_civil, @cliente_id);";


                comando.Parameters.AddWithValue("@cep", obj_end.cep);
                comando.Parameters.AddWithValue("@estado", obj_end.estado);
                comando.Parameters.AddWithValue("@cidade", obj_end.cidade);
                comando.Parameters.AddWithValue("@rua", obj_end.rua);
                comando.Parameters.AddWithValue("@numero", obj_end.numero);
                comando.Parameters.AddWithValue("@bairro", obj_end.bairro);
                comando.Parameters.AddWithValue("@porto_referencia", obj_end.ponto_referencia);
                comando.Parameters.AddWithValue("@telefone", obj_cli.telefone);
                comando.Parameters.AddWithValue("@nome", obj_cli_fis.nome);
                comando.Parameters.AddWithValue("@rg", obj_cli_fis.rg);
                comando.Parameters.AddWithValue("@cpf", obj_cli_fis.cpf);
                comando.Parameters.AddWithValue("@data_nascimento", obj_cli_fis.data_nascimento);
                comando.Parameters.AddWithValue("@estado_civil", obj_cli_fis.estado_civil);

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
