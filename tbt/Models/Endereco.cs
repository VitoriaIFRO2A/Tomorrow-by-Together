using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Endereco
    {

        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string ponto_referencia { get; set; }

        public Endereco() { }
        public Endereco(string cep, string estado, string cidade, string rua, int numero, string bairro, string ponto_referencia)
        {
            this.cep = cep;
            this.estado = estado;
            this.cidade = cidade;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.ponto_referencia = ponto_referencia;
        }
        public Endereco( string cep, string estado, string cidade, string rua, int numero, string bairro)
        { 
            this.cep = cep;
            this.estado = estado;
            this.cidade = cidade;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;;
        }
    }
}
