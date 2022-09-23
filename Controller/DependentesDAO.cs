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
    internal class DependentesDAO
    {

        public Conectar conn = new Conectar();


        public MySqlDataAdapter read()
        {

            string sql = "SELECT d.codd AS Codigo,f.nome AS Funcionario, d.nome AS Nome, d.nascimento AS Nascimento " +
                "FROM Funcionarios f INNER JOIN Dependetes d " +
                "ON f.codf = d.codf;";

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

        public string insert(Dependentes dependentes)
        {

            string sql = "INSERT INTO Dependetes VALUES " +
                "(" + dependentes.id + ",'" + dependentes.nome + 
                "','" + dependentes.nasc + "',"+dependentes.funcionario+");";

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


        public string update(Dependentes dependentes)
        {

            string sql = "UPDATE Dependetes SET codf = " + dependentes.funcionario +
                ", nome = '" + dependentes.nome + "', nascimento = '"+dependentes.nasc+"' " +
                "WHERE codd = " + dependentes.id + ";";

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

            string sql = "DELETE FROM Dependetes WHERE codd = " + id + ";";

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
