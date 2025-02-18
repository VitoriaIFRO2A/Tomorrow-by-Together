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
    /// Lógica interna para ConsultaVenda.xaml
    /// </summary>
    public partial class ConsultaVenda : Window
    {
        public ConsultaVenda()
        {
            InitializeComponent();

            VendaDAO vendaDAO = new VendaDAO();
            List<Venda_prod> venda =  vendaDAO.ObterVendas();

            dgvenda.ItemsSource = venda;
        }

        private void dgprodutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
