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

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }
    }
}
