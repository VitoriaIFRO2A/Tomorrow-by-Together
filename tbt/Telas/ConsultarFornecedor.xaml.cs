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
    /// Lógica interna para ConsultarFornecedor.xaml
    /// </summary>
    public partial class ConsultarFornecedor : Window
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            List<Fornecedor> fornecedor = fornecedorDAO.Obterfornecedores();
            dgFornecedores.ItemsSource = fornecedor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nome_fantasia = txtNomeEmpresa.Text;

            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            Fornecedor fornecedor = fornecedorDAO.select(nome_fantasia);

            List<Fornecedor> listaFornecedor = new List<Fornecedor> { fornecedor };

            // Agora a DataGrid receberá uma lista (mesmo que tenha um único cliente)
            dgFornecedores.ItemsSource = listaFornecedor;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConsultarFornecedor consultar = new ConsultarFornecedor();
            consultar.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
