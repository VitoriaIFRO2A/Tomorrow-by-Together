using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tbt.database;

namespace tbt.Models
{
    internal class Cliente_juridicoDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Cliente_juridico obj_cli_jur, Endereco obj_end, Cliente obj_cli)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Endereco VALUES (null, @cep, @rua, @numero, @bairro, @cidade, @estado, @porto_referencia);" +
                "SET @endereco_id = LAST_INSERT_ID();" +
                "INSERT INTO Cliente VALUES (null, 'Juridico', @telefone, @endereco_id);" +
                "SET @cliente_id = LAST_INSERT_ID();" +
                "INSERT INTO Cliente_fisico VALUES (null, @razao_social, @nome_fantasia, @inscricao_estadual, @cnpj, @data_abertura, @cliente_id);";


                comando.Parameters.AddWithValue("@cep", obj_end.cep);
                comando.Parameters.AddWithValue("@estado", obj_end.estado);
                comando.Parameters.AddWithValue("@cidade", obj_end.cidade);
                comando.Parameters.AddWithValue("@rua", obj_end.rua);
                comando.Parameters.AddWithValue("@numero", obj_end.numero);
                comando.Parameters.AddWithValue("@bairro", obj_end.bairro);
                comando.Parameters.AddWithValue("@porto_referencia", obj_end.ponto_referencia);
                comando.Parameters.AddWithValue("@telefone", obj_cli.telefone);

                comando.Parameters.AddWithValue("@razao_social", obj_cli_jur.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", obj_cli_jur.NomeFantasia);
                comando.Parameters.AddWithValue("@inscricao_estadual", obj_cli_jur.InscricaoEstadual);
                comando.Parameters.AddWithValue("@cnpj", obj_cli_jur.CNPJ) ;
                comando.Parameters.AddWithValue("@data_abertura", obj_cli_jur.DataAbertura);
               

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
