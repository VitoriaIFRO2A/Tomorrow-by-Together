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
    /// Lógica interna para ExcluirFornecedor.xaml
    /// </summary>
    public partial class ExcluirFornecedor : Window
    {
        public ExcluirFornecedor()
        {
            InitializeComponent();
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            List<Fornecedor> fornecedor = fornecedorDAO.Obterfornecedores();
            dgFornecedores.ItemsSource = fornecedor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Excluir_id.Text);
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.Delete(id);

                List<Fornecedor> fornecedor = fornecedorDAO.Obterfornecedores();
                dgFornecedores.ItemsSource = fornecedor;
            }
            catch
            {
                MessageBox.Show("Nenhum id encontrado");
            }
        }
    }
}
