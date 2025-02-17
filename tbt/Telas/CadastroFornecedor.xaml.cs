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
    /// Lógica interna para CadastroFornecedor.xaml
    /// </summary>
    public partial class CadastroFornecedor : Window
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string razao_social_for = razao_social.Text;
                string nome_fantasia_for = nome_fantasia.Text;
                string email_for = email.Text;
                string telefone_for = telefone.Text;
                string estado_for = estado.Text;
                string cidade_for = cidade.Text;
                string bairro_for = bairro.Text;
                string rua_for = rua.Text;
                int numero_for = Convert.ToInt32(numero.Text);

                Fornecedor fornecedor = new Fornecedor(razao_social_for, nome_fantasia_for, email_for, telefone_for, estado_for, cidade_for, bairro_for, rua_for, numero_for);
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.Insert(fornecedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
