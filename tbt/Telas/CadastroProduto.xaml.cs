using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using tbt.Models;

namespace tbt.Telas
{
    /// <summary>
    /// Lógica interna para CadastroProduto.xaml
    /// </summary>
    public partial class CadastroProduto : Window
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tipo_produto = tipo_prod.Text;
            string marca = marca_prod.Text;
            string modelo = modelo_prod.Text;
            string referencia = refencia_prod.Text;
            string descricao = descricao_prod.Text;
            double preco_custo = Convert.ToDouble(preco_custo_prod.Text);
            double valor_aluguel = Convert.ToDouble(valor_aluguel_prod.Text);
            string cor = cor_prod.Text;

            Produto produto = new Produto(marca, tipo_produto, modelo, cor, preco_custo, referencia, descricao, valor_aluguel);
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.Insert(produto);
        }
    }
}
