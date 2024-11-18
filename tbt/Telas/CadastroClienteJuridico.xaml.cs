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
    /// Lógica interna para CadastroClienteJuridico.xaml
    /// </summary>
    public partial class CadastroClienteJuridico : Window
    {
        public CadastroClienteJuridico()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string razaoSocial = razao_social.Text;
            string nome_fantasia_cli = nome_fantasia.Text;
            string inscricao_estadual_cli = inscricaoEstadual.Text;
            string cnpj_cli = cnpj.Text;
            DateTime data_abertura_cli = Convert.ToDateTime(data_abertura.Text);
            string telefone_cli = telefone.Text;
            string cep_cli = cep.Text;
            string estado_cli = estado.Text;
            string cidade_cli = cidade.Text;
            string rua_cli = rua.Text;
            int numero_cli = Convert.ToInt32(numero.Text);
            string bairro_cli = bairro.Text;
            string ponto_referencia_cli = ponto_referencia.Text;

            Endereco endereco = new Endereco(cep_cli, estado_cli, cidade_cli, rua_cli, numero_cli, bairro_cli, ponto_referencia_cli);
            Cliente cliente = new Cliente(telefone_cli);
            Cliente_juridico cliente_Juridico = new Cliente_juridico(razaoSocial, nome_fantasia_cli, inscricao_estadual_cli, cnpj_cli, data_abertura_cli);

            Cliente_juridicoDAO insert = new Cliente_juridicoDAO();
            insert.Insert(cliente_Juridico, endereco, cliente);
        }
    }
}
