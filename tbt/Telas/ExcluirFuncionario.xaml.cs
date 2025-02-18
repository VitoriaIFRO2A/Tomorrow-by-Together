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
    /// Lógica interna para ExcluirFuncionario.xaml
    /// </summary>
    public partial class ExcluirFuncionario : Window
    {
        public ExcluirFuncionario()
        {
            InitializeComponent();

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            List<Funcionario> funcionarios = funcionarioDAO.ObterFuncionarios();

            dgFuncionarios.ItemsSource = funcionarios;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(excluir_id.Text);
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Delete(id);

                List<Funcionario> funcionarios = funcionarioDAO.ObterFuncionarios();

                dgFuncionarios.ItemsSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
