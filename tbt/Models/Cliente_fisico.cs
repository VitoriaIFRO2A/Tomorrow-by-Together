using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Cliente_fisico
    {
        public int id { get; set; }
        public string nome {  get; set; }
	    public string rg {  get; set; }
        public string cpf {  get; set; }
	    public DateTime? data_nascimento { get; set; }
        public string estado_civil {  get; set; }

        public Cliente_fisico() { }
        public Cliente_fisico(string nome, string rg, string cpf, DateTime? data_nascimento, string estado_civil)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.data_nascimento = data_nascimento;
            this.estado_civil = estado_civil;
        }
    }
}
