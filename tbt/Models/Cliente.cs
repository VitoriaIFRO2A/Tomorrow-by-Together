using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }


        public Cliente() { }
        public Cliente(string nome, string cpf, string telefone, string estado, string cidade, string rua, int numero, string bairro)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.estado = estado;
            this.cidade = cidade;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
        }
    }
}