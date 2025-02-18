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
    /// Lógica interna para ConsultarProduto.xaml
    /// </summary>
    public partial class ConsultarProduto : Window
    {
        public ConsultarProduto()
        {
            InitializeComponent();

            ProdutoDAO buscar = new ProdutoDAO();
            List<Produto> produto = buscar.ObterProduto();
            dgprodutos.ItemsSource = produto;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string modelo = txtmodelo.Text;

            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = produtoDAO.Select(modelo);

            List<Produto> produtos = new List<Produto> {produto };

            dgprodutos.ItemsSource = produtos;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConsultarProduto consultarProduto = new ConsultarProduto();
            consultarProduto.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
