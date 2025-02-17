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
    /// Lógica interna para CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroFuncionario : Window
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome_fun = nome_completo.Text;
                DateTime? data_nascimento = data_nas.SelectedDate;
                string cpf_fun = cpf.Text;
                string rg_fun = rg.Text;
                string telefone_fun = telefone.Text;
                string sexo = (comboSexo.SelectedItem as ComboBoxItem)?.Content.ToString();
                string email_fun = email.Text;
                string cargo_fun = cargo.Text;
                string estado_fun = estado.Text;
                string cidade_fun = cidade.Text;
                string bairro_fun = bairro.Text;
                string rua_fun = rua.Text;
                int numero_fun = Convert.ToInt32(numero.Text);

                string usuario_txt = usuario.Text;
                string senha_txt = senha.Text;

                Login_acess login = new Login_acess(usuario_txt, senha_txt);
                Funcionario funcionario = new Funcionario(nome_fun, data_nascimento, cpf_fun, rg_fun, sexo, cargo_fun, telefone_fun, email_fun, estado_fun, cidade_fun, numero_fun, bairro_fun);

                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Insert(funcionario, login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void numer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
