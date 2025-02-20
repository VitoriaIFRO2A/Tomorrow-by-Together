﻿using System;
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
    /// Lógica interna para ExcluirProduto.xaml
    /// </summary>
    public partial class ExcluirProduto : Window
    {
        public ExcluirProduto()
        {
            InitializeComponent();
            ProdutoDAO buscar = new ProdutoDAO();
            List<Produto> produto = buscar.ObterProduto();
            dgprodutos.ItemsSource = produto;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id_excluir.Text);
                ProdutoDAO buscar = new ProdutoDAO();
                buscar.Delete(id);

                List<Produto> produto = buscar.ObterProduto();
                dgprodutos.ItemsSource = produto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
