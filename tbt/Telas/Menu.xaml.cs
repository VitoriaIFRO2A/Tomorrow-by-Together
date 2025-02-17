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

namespace tbt.Telas
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void catalogo_Click(object sender, RoutedEventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
        }

        private void consultaProdutos_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ConsultaFuncionario_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFuncionario consultarFuncionario = new ConsultarFuncionario();
            consultarFuncionario.Show();

        }

        private void ConsultaCliente_Click(object sender, RoutedEventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }

        private void consultaFornecedor_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFornecedor consultarFornecedor = new ConsultarFornecedor();
            consultarFornecedor.Show();
        }

        private void cadastraCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void CadastraFuncionario_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void CadastraProduto_Click(object sender, RoutedEventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }
        /*
        private void CadastraFornecedor_Click(object sender, RoutedEventArgs e)
        {
            
        }
        */
        private void CadastraFornecedor_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.Show();
        }
    }
}
