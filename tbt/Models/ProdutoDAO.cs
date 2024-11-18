using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tbt.database;

namespace tbt.Models
{
    internal class ProdutoDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Produto obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Produto VALUES (null, @marca, @tipoProduto, @modelo, @cor, @precoCusto, @Referencia, @descricao, @valorAluguel);";

                comando.Parameters.AddWithValue("@tipoProduto", obj.TipoEquipamento);
                comando.Parameters.AddWithValue("@modelo", obj.Modelo);
                comando.Parameters.AddWithValue("@referencia", obj.Referencia);
                comando.Parameters.AddWithValue("@descricao", obj.Descricao);
                comando.Parameters.AddWithValue("@cor", obj.Cor);
                comando.Parameters.AddWithValue("@valorAluguel", obj.ValorAluguel);
                comando.Parameters.AddWithValue("@precoCusto", obj.PrecoCusto);
                comando.Parameters.AddWithValue("@marca", obj.Marca);

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

