using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Produto
    {
        public int id { get; set; }
        public string TipoEquipamento { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public double PrecoCusto { get; set; }
        public double ValorAluguel { get; set; }
        public string Cor { get; set; }
        public int id_for_fk { get; set; }
        public Produto() { }
        public Produto(string tipoEquipamento, string marca, string modelo, string referencia, string descricao, double precoCusto, double valorAluguel, string cor, int id_for_fk)
        {
            this.TipoEquipamento = tipoEquipamento;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Referencia = referencia;
            this.Descricao = descricao;
            this.PrecoCusto = precoCusto;
            this.ValorAluguel = valorAluguel;
            this.Cor = cor;
            this.id_for_fk = id_for_fk;
        }
    }
}
