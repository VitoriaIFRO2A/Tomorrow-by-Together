using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Cms;

namespace tbt.Models
{
    internal class Venda_prod
    {
        public int id { get; set; }
        public DateTime? data { get; set; }
        public int id_fun { get; set; }
        public int id_cli { get; set; }
        public int id_pro { get; set; }

        public Venda_prod(DateTime? date, int id_fun, int id_cli, int id_pro)
        {
            this.data = date;
            this.id_fun = id_fun;
            this.id_cli = id_cli;
            this.id_pro = id_pro;
        }
        public Venda_prod() { }
    }
}
