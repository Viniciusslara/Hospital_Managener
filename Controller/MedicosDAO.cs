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
    internal class MedicosDAO
    {

        public Conectar conn = new Conectar();

        public MySqlDataAdapter read()
        {

            string sql = "SELECT * FROM Medicos";

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

        public string insert(Medicos medicos)
        {

            string sql = "INSERT INTO Medicos VALUES " +
                "(" + medicos.id + "," + medicos.ambulatorio + ",'" + medicos.nome +
                "'," + medicos.idade + ",'" + medicos.especialidade + "',"+medicos.cpf+
                ",'"+medicos.cidade+"');";

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


        public string update(Medicos medicos)
        {

            string sql = "UPDATE Medicos SET nroa = " + medicos.ambulatorio +
                ", nome = '" + medicos.nome + "', cidade = '" + medicos.cidade + "'," +
                "cpf = " + medicos.cpf + ", especialidade = '" + medicos.especialidade + 
                "', idade = "+medicos.idade+" WHERE codm = " + medicos.id + ";";

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

            string sql = "DELETE FROM Medicos WHERE codm = " + id + ";";

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
