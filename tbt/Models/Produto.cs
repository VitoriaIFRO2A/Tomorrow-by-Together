using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Produto
    {
        public string Marca { get; set; }
        public string TipoEquipamento { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double PrecoCusto { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public double ValorAluguel { get; set; }
        public Produto() { }
        public Produto(string marca, string tipoEquipamento, string modelo, string cor, double precoCusto, string referencia, string descricao, double valorAluguel)
        {
            Marca = marca;
            TipoEquipamento = tipoEquipamento;
            Modelo = modelo;
            Cor = cor;
            PrecoCusto = precoCusto;
            Referencia = referencia;
            Descricao = descricao;
            ValorAluguel = valorAluguel;
        }
    }
}
