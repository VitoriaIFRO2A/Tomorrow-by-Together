using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public DateTime? data_nascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string sexo { get; set; }
        public string funcao { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }

        public Funcionario(string nome, DateTime data_nascimento, string cpf, string rg, string sexo, string funcao, string telefone, string email, string estado, string cidade, int numero, string bairro)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.cpf = cpf;
            this.rg = rg;
            this.sexo = sexo;
            this.funcao = funcao;
            this.telefone = telefone;
            this.email = email;
            this.estado = estado;
            this.cidade = cidade;
            this.numero = numero;
            this.bairro = bairro;
        }
        public Funcionario() { }
    }
}