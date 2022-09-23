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
    internal class PacientesDAO
    {

        public Conectar conn = new Conectar();

        public MySqlDataAdapter read()
        {

            string sql = "SELECT * FROM Pacientes;";

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

        public string insert(Paciente paciente)
        {

            string sql = "INSERT INTO Pacientes VALUES " +
                "(" + paciente.id + ",'" + paciente.nome + "'," + paciente.idade +
                ",'" + paciente.cidade + "','" + paciente.doenca + "');";

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


        public string update(Paciente paciente)
        {

            string sql = "UPDATE Pacientes SET nome = '" + paciente.nome +
                "', idade = " + paciente.idade + ", cidade = '"+paciente.cidade+"'," +
                "cpf = "+paciente.cpf+", doenca = '"+paciente.doenca+"' WHERE codp = "+paciente.id+";";

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

            string sql = "DELETE FROM Pacientes WHERE codp = " + id + ";";

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
