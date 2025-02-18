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
    /// Lógica interna para Venda.xaml
    /// </summary>
    public partial class Venda : Window
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cpf = cpf_cliente.Text;
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = clienteDAO.Select(cpf);
            ApresentaCliente.Text = cliente.nome;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string cpf = cpf_funcionario.Text;
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            Funcionario funcionario = funcionarioDAO.Select(cpf);
            ApresentaFuncionario.Text = funcionario.nome;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string modelo = id_produto.Text;
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto produto = produtoDAO.Select(modelo);
            ApresentaProduto.Text = produto.Descricao;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                string cpf = cpf_cliente.Text;
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente cliente = clienteDAO.Select(cpf);

                string cpf2 = cpf_funcionario.Text;
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                Funcionario funcionario = funcionarioDAO.Select(cpf2);

                string modelo = id_produto.Text;
                ProdutoDAO produtoDAO = new ProdutoDAO();
                Produto produto = produtoDAO.Select(modelo);

                int id_cli = cliente.id;
                int id_fun = funcionario.id;
                int id_pro = produto.id;

                DateTime date = DateTime.Now;

                VendaDAO vendaDAO = new VendaDAO();
                Venda_prod venda = new Venda_prod(date, id_fun, id_cli, id_pro);
                vendaDAO.Insert(venda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
