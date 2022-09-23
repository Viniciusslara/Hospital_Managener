using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AtividadeClinica.Database;
using AtividadeClinica.Model;

namespace AtividadeClinica.Controller
{
    internal class FuncionariosDAO
    {

        public Conectar conn = new Conectar();

        public MySqlDataAdapter read()
        {

            string sql = "SELECT * FROM Funcionarios;";

            if (conn.Connect())
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    return da;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.connect.Close();
                }
            }

            return null;
        }

        public string insert(Funcionarios funcionarios)
        {

            string sql = "INSERT INTO Funcionarios VALUES " +
                "(" + funcionarios.id + ",'" + funcionarios.nome +
                "'," + funcionarios.idade + "," + funcionarios.cpf +
                ",'" + funcionarios.cidade + "',"+funcionarios.salario+
                ",'"+funcionarios.cargo+"');";

            if (conn.Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally
                {
                    conn.connect.Close();
                }
            }

            return "Salvo com sucesso";

        }


        public string update(Funcionarios funcionarios)
        {

            string sql = "UPDATE Funcionarios SET nome = '" + funcionarios.nome + "', cidade = '" +funcionarios.cidade + "'," +
                "cpf = " + funcionarios.cpf + ", cargo = '" + funcionarios.cargo +
                "', idade = " + funcionarios.idade + ", salario = "+funcionarios.salario+" WHERE codf = " + funcionarios.id + ";";

            if (conn.Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally
                {
                    conn.connect.Close();
                }
            }

            return "Salvo com sucesso";

        }

        public string delete(int id)
        {

            string sql = "DELETE FROM Funcionarios WHERE codf = " + id + ";";

            if (conn.Connect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally
                {
                    conn.connect.Close();
                }
            }

            return "Salvo com sucesso";

        }

    }
}
