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
    /// Lógica interna para CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome_cli = nome.Text;
                string cpf_cli = cpf.Text;
                string telefone_cli = telefone.Text;
                string estado_cli = estado.Text;
                string cidade_cli = cidade.Text;
                string bairro_cli = bairro.Text;
                string rua_cli = rua.Text;
                int numero_cli = Convert.ToInt32(numero.Text);

                Cliente cliente = new Cliente(nome_cli, cpf_cli, telefone_cli, estado_cli, cidade_cli, rua_cli, numero_cli, bairro_cli);

                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.Insert(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nome.Text = "";
            cpf.Text = "";
            telefone.Text = "";
            estado.Text = "";
            cidade.Text = "";
            bairro.Text = "";
            rua.Text = "";
            numero.Text = "";
        }
    }
}
