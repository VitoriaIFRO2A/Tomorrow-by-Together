using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Cliente_juridico
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string CNPJ { get; set; }
        public DateTime? DataAbertura { get; set; }

        public Cliente_juridico() { }
        public Cliente_juridico(string razaoSocial, string nomeFantasia, string inscricaoEstadual, string cNPJ, DateTime? dataAbertura)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            CNPJ = cNPJ;
            DataAbertura = dataAbertura;
        }

    }
}
