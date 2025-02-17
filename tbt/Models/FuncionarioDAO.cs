using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using tbt.database;
using tbt.Helpers;


namespace tbt.Models
{
    internal class FuncionarioDAO
    {
        private static Conexao _conn = new Conexao();
        public void Insert(Funcionario obj_fun, Login_acess login)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO funcionario VALUES (null, @nome, @data_nascimento, @cpf, @rg, @sexo, @funcao, @telefone, @email, @estado, @cidade, @rua, @numero, @bairro);";
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

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

                comando.CommandText = "SELECT LAST_INSERT_ID();"; // Para pegar o ID do funcionário recém inserido
                var ultimoId = Convert.ToInt32(comando.ExecuteScalar());

                comando.CommandText = "INSERT INTO login VALUES (null, @usuario, @senha, @ultimo_id);";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@usuario", login.usuario);
                comando.Parameters.AddWithValue("@senha", login.senha);
                comando.Parameters.AddWithValue("@ultimo_id", ultimoId);

                resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    MessageBox.Show("Funcionario não salvo");
                }
                else if (resultado > 0)
                {
                    MessageBox.Show("Funcionario e Login salvos com sucesso");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Funcionario Select(string cpf_funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM funcionario WHERE cpf_fun = @cpf";
                comando.Parameters.AddWithValue("@cpf", cpf_funcionario.Trim()); // Remover espaços extras

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Funcionario funcionario = new Funcionario
                        {
                            id = reader.IsDBNull(reader.GetOrdinal("id_fun")) ? 0 : reader.GetInt32("id_fun"),
                            nome = reader.IsDBNull(reader.GetOrdinal("nome_fun")) ? null : reader.GetString("nome_fun"),
                            data_nascimento = reader.IsDBNull(reader.GetOrdinal("data_nascimento_fun")) ? (DateTime?)null : reader.GetDateTime("data_nascimento_fun"),
                            cpf = reader.IsDBNull(reader.GetOrdinal("cpf_fun")) ? null : reader.GetString("cpf_fun"),
                            rg = reader.IsDBNull(reader.GetOrdinal("rg_fun")) ? null : reader.GetString("rg_fun"),
                            sexo = reader.IsDBNull(reader.GetOrdinal("sexo_fun")) ? null : reader.GetString("sexo_fun"),
                            funcao = reader.IsDBNull(reader.GetOrdinal("funcao_fun")) ? null : reader.GetString("funcao_fun"),
                            telefone = reader.IsDBNull(reader.GetOrdinal("telefone_fun")) ? null : reader.GetString("telefone_fun"),
                            email = reader.IsDBNull(reader.GetOrdinal("email_fun")) ? null : reader.GetString("email_fun"),
                            estado = reader.IsDBNull(reader.GetOrdinal("estado_fun")) ? null : reader.GetString("estado_fun"),
                            cidade = reader.IsDBNull(reader.GetOrdinal("cidade_fun")) ? null : reader.GetString("cidade_fun"),
                            rua = reader.IsDBNull(reader.GetOrdinal("rua_fun")) ? null : reader.GetString("rua_fun"),
                            numero = reader.IsDBNull(reader.GetOrdinal("numero_fun")) ? 0 : reader.GetInt32("numero_fun"),
                            bairro = reader.IsDBNull(reader.GetOrdinal("bairro_fun")) ? null : reader.GetString("bairro_fun")
                        };
                        return funcionario;
                    }
                    else
                    {
                        return new Funcionario
                        {
                            id = 0,
                            nome = "Funcionário não encontrado",
                            cpf = "",
                            rg = "",
                            sexo = "",
                            funcao = "",
                            telefone = "",
                            email = "",
                            estado = "",
                            cidade = "",
                            rua = "",
                            numero = 0,
                            bairro = ""
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Imprimir ou logar a exceção para análise
                Console.WriteLine(ex.Message); // Pode ser um MessageBox ou outro tipo de log
                return new Funcionario
                {
                    id = 0,
                    nome = "Erro ao buscar o funcionário",
                    cpf = "",
                    rg = "",
                    sexo = "",
                    funcao = "",
                    telefone = "",
                    email = "",
                    estado = "",
                    cidade = "",
                    rua = "",
                    numero = 0,
                    bairro = ""
                };
            }
        }


        public List<Funcionario> ObterFuncionarios()
        {
            List<Funcionario> func = new List<Funcionario>();

            try
            {
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM funcionario";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Funcionario funcionario = new Funcionario
                        {
                            id = reader.IsDBNull(reader.GetOrdinal("id_fun")) ? 0 : reader.GetInt32("id_fun"),
                            nome = reader.IsDBNull(reader.GetOrdinal("nome_fun")) ? null : reader.GetString("nome_fun"),
                            data_nascimento = reader.IsDBNull(reader.GetOrdinal("data_nascimento_fun")) ? (DateTime?)null : reader.GetDateTime("data_nascimento_fun"),
                            cpf = reader.IsDBNull(reader.GetOrdinal("cpf_fun")) ? null : reader.GetString("cpf_fun"),
                            rg = reader.IsDBNull(reader.GetOrdinal("rg_fun")) ? null : reader.GetString("rg_fun"),
                            sexo = reader.IsDBNull(reader.GetOrdinal("sexo_fun")) ? null : reader.GetString("sexo_fun"),
                            funcao = reader.IsDBNull(reader.GetOrdinal("funcao_fun")) ? null : reader.GetString("funcao_fun"),
                            telefone = reader.IsDBNull(reader.GetOrdinal("telefone_fun")) ? null : reader.GetString("telefone_fun"),
                            email = reader.IsDBNull(reader.GetOrdinal("email_fun")) ? null : reader.GetString("email_fun"),
                            estado = reader.IsDBNull(reader.GetOrdinal("estado_fun")) ? null : reader.GetString("estado_fun"),
                            cidade = reader.IsDBNull(reader.GetOrdinal("cidade_fun")) ? null : reader.GetString("cidade_fun"),
                            rua = reader.IsDBNull(reader.GetOrdinal("rua_fun")) ? null : reader.GetString("rua_fun"),
                            numero = reader.IsDBNull(reader.GetOrdinal("numero_fun")) ? 0 : reader.GetInt32("numero_fun"),
                            bairro = reader.IsDBNull(reader.GetOrdinal("bairro_fun")) ? null : reader.GetString("bairro_fun")
                        };

                        func.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Funcionarios", ex);
            }

            return func;
        }

        public void Delete(int id)
        {
            try
            {
                var comando = _conn.Query();

                // Deleta primeiro da tabela 'login'
                comando.CommandText = "DELETE FROM login WHERE id_fun_fk = @id";
                comando.Parameters.Clear();  // Limpa os parâmetros para o próximo comando
                comando.Parameters.AddWithValue("@id", id);
                int resultadoLogin = comando.ExecuteNonQuery();

                // Agora, deleta da tabela 'funcionario'
                comando.CommandText = "DELETE FROM funcionario WHERE id_fun = @id";
                comando.Parameters.Clear();  // Limpa os parâmetros para o próximo comando
                comando.Parameters.AddWithValue("@id", id);
                int resultadoFuncionario = comando.ExecuteNonQuery();

                // Verifica se ambos os comandos foram executados corretamente
                if (resultadoLogin == 0 && resultadoFuncionario == 0)
                {
                    throw new Exception("Nenhum registro encontrado para excluir.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }


}