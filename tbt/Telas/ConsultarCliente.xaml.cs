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
    /// Lógica interna para ConsultarCliente.xaml
    /// </summary>
    public partial class ConsultarCliente : Window
    {
        public ConsultarCliente()
        {
            InitializeComponent();

            ClienteDAO clienteDAO = new ClienteDAO();

            List<Cliente> cliente = clienteDAO.ObterClientes();

            // Vincule a lista à DataGrid
            DGclientes.ItemsSource = cliente;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cpf = txtCpf.Text;

            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = clienteDAO.Select(cpf);

            // Envolva o cliente em uma lista para passar para a ItemsSource
            List<Cliente> listaCliente = new List<Cliente> { cliente };

            // Agora a DataGrid receberá uma lista (mesmo que tenha um único cliente)
            DGclientes.ItemsSource = listaCliente;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }
    }
}
