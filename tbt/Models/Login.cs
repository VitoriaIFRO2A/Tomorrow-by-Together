using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tbt.Models
{
    internal class Login
    {
        public string usuario { get; set; }
        public string senha { get; set; }
       
        public Login(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            
        }
        public Login() { }
    }
}