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
    internal class ConsultaDAO
    {

        public Conectar conn = new Conectar();

        public MySqlDataAdapter read()
        {

            string sql = "SELECT m.nome AS Medico, m.codm AS CodMed, p.nome AS Paciente,p.codp AS CodPac, c.dataconsulta AS Data, c.horaconsulta AS Hora " +
                "FROM Medicos m INNER JOIN Consulta c " +
                "ON m.codm=c.codm " +
                "INNER JOIN Pacientes p " +
                "ON c.codp = p.codp;";

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

        public string insert(Consulta consulta)
        {

            string sql = "INSERT INTO Ambulatorio VALUES " +
                "(" + consulta.medico.id + "," + consulta.paciente.id + ",'" 
                + consulta.data + "','"+consulta.hora+"');";

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
