using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Fornecedor
    {
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        


        public Fornecedor() { }
        public Fornecedor(string razao_social, string nome_fantasia, string email, string telefone, string estado, string cidade, string bairro, string rua, int numero)
        {
            this.razao_social = razao_social;
            this.nome_fantasia = nome_fantasia;
            this.email = email;
            this.telefone = telefone;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.rua = rua;
            this.numero = numero;
        }
    }
}