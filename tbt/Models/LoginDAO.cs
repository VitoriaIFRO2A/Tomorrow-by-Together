using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tbt.database;


namespace tbt.Models
{
    internal class LoginDAO
    {
        private static Conexao _conn = new Conexao();

        public Login Select(string usuario, string senha)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "SELECT * FROM login WHERE usuario_login = @usuario and senha_login = @senha";
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Login login = new Login
                        {
                            id = reader.GetInt32("id_login"),
                            usuario = reader.GetString("usuario_login"),
                            senha = reader.GetString("senha_login"),
                            id_fun_fk = reader.GetInt32("id_fun_fk")  // Corrigido o nome da coluna
                        };
                        return login;
                    }
                    else
                    {
                        throw new Exception("Informações de login não encontradas.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe mais detalhes para depuração
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Erro ao realizar consulta.", ex);
            }
        }
    }

}