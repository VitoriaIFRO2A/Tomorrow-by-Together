using Mysqlx.Crud;
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
    /// Lógica interna para CadastroClienteFisico.xaml
    /// </summary>
    public partial class CadastroClienteFisico : Window
    {
        public CadastroClienteFisico()
        {
            InitializeComponent();
        }

        private void Salvar_click(object sender, RoutedEventArgs e)
        {
            string nome = nome_completo.Text;
            string rg_cli = rg.Text;
            string cpf_cli = cpf.Text;
            string estado_civil_cli = estado_civil.Text;
            DateTime data_nascimento = Convert.ToDateTime(data_nasc.Text);
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
            Cliente_fisico cliente_Fisico = new Cliente_fisico(nome, rg_cli, cpf_cli, data_nascimento, estado_civil_cli);

            Cliente_fisicoDAO insert = new Cliente_fisicoDAO();
            insert.Insert(cliente_Fisico, endereco, cliente);
        }
    }
}
