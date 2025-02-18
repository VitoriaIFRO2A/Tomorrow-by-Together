using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using tbt.database;
using tbt.Helpers;


namespace tbt.Models
{
    internal class VendaDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Venda_prod obj_ven)
        {
            try
            {
                var comando = _conn.Query();


                comando.CommandText = "INSERT INTO venda VALUES (null, @data, @funcionario, @cliente, @produto);";



                comando.Parameters.AddWithValue("@data", obj_ven.data);
                comando.Parameters.AddWithValue("@funcionario", obj_ven.id_fun);
                comando.Parameters.AddWithValue("@cliente", obj_ven.id_cli);
                comando.Parameters.AddWithValue("@produto", obj_ven.id_pro);



                var resultado = comando.ExecuteNonQuery();


                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }
                else if (resultado > 0)
                {
                    MessageBox.Show("Venda inserido com sucesso!");
                }
            }
            catch
            {

                throw;
            }
        }

        public List<Venda_prod> ObterVendas()
        {
            List<Venda_prod> vendas = new List<Venda_prod>();

            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM venda";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venda = new Venda_prod
                        {
                            id = reader.GetInt32("id_ven"),
                            data = DAOHelper.GetDateTime(reader, "data_ven"),
                            id_fun = reader.GetInt32("id_fun_fk"),
                            id_cli = reader.GetInt32("id_cli_fk"),
                            id_pro = reader.GetInt32("id_pro_fk")
                        };
                        vendas.Add(venda);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar vendas", ex);
            }

            return vendas;
        }
    }
}