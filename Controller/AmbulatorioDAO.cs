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
    internal class AmbulatorioDAO
    {

        public Conectar conn = new Conectar();


        public MySqlDataAdapter read()
        {

            string sql = "SELECT * FROM Ambulatorio";

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

        public string insert(Ambulatorio ambulatorio)
        {

            string sql = "INSERT INTO Ambulatorio VALUES " +
                "(" + ambulatorio.id + "," + ambulatorio.andar + "," + ambulatorio.capacidade + ");";

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


        public string update(Ambulatorio ambulatorio)
        {

            string sql = "UPDATE Ambulatorio SET andar = " + ambulatorio.andar +
                ", capacidade = " + ambulatorio.capacidade + " WHERE nroa = " + ambulatorio.id + ";";

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

            string sql = "DELETE FROM Ambulatorio WHERE nroa = " + id + ";";

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
