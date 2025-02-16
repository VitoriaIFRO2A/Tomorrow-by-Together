using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tbt.database;


namespace tbt.Models
{
    internal class FuncionarioDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Funcionario obj_fun, Login login)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO funcionario VALUES (null, @nome, @data_nascimento, @cpf, @rg, @sexo, @funcao, @telefone, @email, @estado, @cidade, @rua, @numero, @bairro);" +
                "set @ultimo_id = last_insert_id();" +
                "insert into login values (null, @usuario, @senha, @ultimo_id);";

                comando.Parameters.AddWithValue("@nome", obj_fun.nome);
                comando.Parameters.AddWithValue("@data_nascimento", obj_fun.data_nascimento);
                comando.Parameters.AddWithValue("@cpf", obj_fun.cpf);
                comando.Parameters.AddWithValue("@rg", obj_fun.rg);
                comando.Parameters.AddWithValue("@sexo", obj_fun.sexo);
                comando.Parameters.AddWithValue("@funcao", obj_fun.funcao);
                comando.Parameters.AddWithValue("@telefone", obj_fun.telefone);
                comando.Parameters.AddWithValue("@email", obj_fun.email);
                comando.Parameters.AddWithValue("@estado", obj_fun.estado);
                comando.Parameters.AddWithValue("@cidade", obj_fun.cidade);
                comando.Parameters.AddWithValue("@rua", obj_fun.rua);
                comando.Parameters.AddWithValue("@numero", obj_fun.numero);
                comando.Parameters.AddWithValue("@bairro", obj_fun.bairro);

                comando.Parameters.AddWithValue("@usuario", login.usuario);
                comando.Parameters.AddWithValue("@senha", login.senha);



                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}