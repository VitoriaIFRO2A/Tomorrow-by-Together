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
    /// Lógica interna para ExcluirCliente.xaml
    /// </summary>
    public partial class ExcluirCliente : Window
    {
        public ExcluirCliente()
        {
            InitializeComponent();

            ClienteDAO clienteDAO = new ClienteDAO();

            List<Cliente> cliente = clienteDAO.ObterClientes();

            // Vincule a lista à DataGrid
            DGclientes.ItemsSource = cliente;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id_excluir.Text);
                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.Delete(id);

                List<Cliente> cliente = clienteDAO.ObterClientes();

                // Vincule a lista à DataGrid
                DGclientes.ItemsSource = cliente;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
           

        }
    }
}
