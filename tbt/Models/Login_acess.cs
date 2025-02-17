using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using tbt.database;
using tbt.Recursos.Imagens;

namespace tbt.Models
{
    internal class Login_acess
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public int id_fun_fk { get; set; }
       
        public Login_acess(string usuario, string senha) 
        { 
            this.usuario = usuario; 
            this.senha = senha;
        }
        public Login_acess() { }
    }
}