using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Cliente
    {

        public string tipo_pessoa { get; set; }
        public string telefone { get; set; }

        public Cliente() { }
        public Cliente(string telefone)
        {
            this.telefone = telefone;
        }
    }
}
