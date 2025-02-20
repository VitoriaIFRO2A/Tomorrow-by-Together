﻿using System;
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

        public Login_acess Select(string usuario, string senha)
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
                        // Verifica se o id_fun_fk é nulo e atribui valor apropriado
                        Login_acess login_Acess = new Login_acess
                        {
                            id = reader.GetInt32("id_login"),
                            usuario = reader.GetString("usuario_login"),
                            senha = reader.GetString("senha_login"),
                            // Se id_fun_fk for nulo, atribui null ou valor padrão
                            id_fun_fk = reader.IsDBNull(reader.GetOrdinal("id_fun_fk")) ? (int?)null : reader.GetInt32("id_fun_fk")
                        };
                        return login_Acess;
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