using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Pegue os valores dos controles TextBox e PasswordBox
                string usuario = usuariotxt.Text;
                string senha = senhatxt.Text;

                // Crie uma instância da classe onde a função Select está definida (por exemplo, LoginDAO ou algo similar)
                LoginDAO loginDAO = new LoginDAO();
                var login = loginDAO.Select(usuario, senha); // Chame a função Select

                if (login.usuario == usuario && login.senha == senha)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Informações de login inválidas.");
                }
                // Se a função Select retornar um login válido, você pode continuar o processo (por exemplo, abrir outra janela)
                
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe a mensagem de erro
                MessageBox.Show(ex.Message); // Exibe o erro na tela
            }
        }
    }
}
