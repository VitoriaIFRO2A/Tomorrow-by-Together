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
using MySqlX.XDevAPI;
using tbt.Models;

namespace tbt.Telas
{
    /// <summary>
    /// Lógica interna para ConsultarFuncionario.xaml
    /// </summary>
    public partial class ConsultarFuncionario : Window
    {
        public ConsultarFuncionario()
        {

            InitializeComponent();

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            List<Funcionario> funcionarios = funcionarioDAO.ObterFuncionarios();

            dgFuncionarios.ItemsSource = funcionarios;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cpf = txtCpf.Text;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            Funcionario funcionario = funcionarioDAO.Select(cpf);

            List<Funcionario> listafuncionarios = new List<Funcionario> { funcionario };

            dgFuncionarios.ItemsSource = listafuncionarios;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConsultarFuncionario consultarFuncionario = new ConsultarFuncionario();
            consultarFuncionario.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
