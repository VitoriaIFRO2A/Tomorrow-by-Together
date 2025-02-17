using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

                comando.CommandText = "INSERT INTO Produto VALUES (null, @tipoProduto, @marca, @modelo, @Referencia, @descricao, @precoCusto, @valorAluguel, @cor, @id_for_fk);";

                comando.Parameters.AddWithValue("@tipoProduto", obj.TipoEquipamento);
                comando.Parameters.AddWithValue("@marca", obj.Marca);
                comando.Parameters.AddWithValue("@modelo", obj.Modelo);
                comando.Parameters.AddWithValue("@referencia", obj.Referencia);
                comando.Parameters.AddWithValue("@descricao", obj.Descricao);
                comando.Parameters.AddWithValue("@precoCusto", obj.PrecoCusto);
                comando.Parameters.AddWithValue("@valorAluguel", obj.ValorAluguel);
                comando.Parameters.AddWithValue("@cor", obj.Cor);
                comando.Parameters.AddWithValue("@id_for_fk", obj.id_for_fk);




                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }
                else if (resultado > 0)
                {
                    MessageBox.Show("produto cadastrado com sucesso");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Produto Select(string modelo)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM produto WHERE modelo_pro = @modelo";
                comando.Parameters.AddWithValue("@modelo", modelo);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Produto produto = new Produto
                        {
                            id = reader.GetInt32("id_pro"),
                            TipoEquipamento = reader.GetString("tipo_produto_pro"),
                            Marca = reader.GetString("marca_pro"),
                            Modelo = reader.GetString("modelo_pro"),
                            Referencia = reader.GetString("referencia_pro"),
                            Descricao = reader.GetString("descricao_pro"),
                            PrecoCusto = reader.GetDouble("preco_custo_pro"),
                            ValorAluguel = reader.GetDouble("valor_aluguel_pro"),
                            Cor = reader.GetString("cor_pro"),
                            id_for_fk = reader.GetInt32("id_for_fk")
                        };
                        return produto;
                    }
                    else
                    {
                        return new Produto
                        {
                            id = 0,
                            TipoEquipamento = "Cliente não encontrado",
                            Marca = "",
                            Modelo = "",
                            Referencia = "",
                            Descricao = "",
                            PrecoCusto = 0,
                            ValorAluguel = 0,
                            Cor = "",
                            id_for_fk = 0
                        };
                    }
                }
            }
            catch
            {
                return new Produto
                {
                    id = 0,
                    TipoEquipamento = "Cliente não encontrado",
                    Marca = "",
                    Modelo = "",
                    Referencia = "",
                    Descricao = "",
                    PrecoCusto = 0,
                    ValorAluguel = 0,
                    Cor = "",
                    id_for_fk = 0
                };
            }
        }

        public List<Produto> ObterProduto()
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM produto";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var produto = new Produto
                        {
                            id = reader.GetInt32("id_pro"),
                            TipoEquipamento = reader.GetString("tipo_produto_pro"),
                            Marca = reader.GetString("marca_pro"),
                            Modelo = reader.GetString("modelo_pro"),
                            Referencia = reader.GetString("referencia_pro"),
                            Descricao = reader.GetString("descricao_pro"),
                            PrecoCusto = reader.GetDouble("preco_custo_pro"),
                            ValorAluguel = reader.GetDouble("valor_aluguel_pro"),
                            Cor = reader.GetString("cor_pro"),
                            id_for_fk = reader.GetInt32("id_for_fk")
                        };

                        produtos.Add(produto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar produtos", ex);
            }

            return produtos;
        }

        public void Delete(int id)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM produto WHERE id_pro = @id";

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

