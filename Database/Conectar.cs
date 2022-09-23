using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AtividadeClinica.Database
{
    internal class Conectar
    {

        public MySqlConnection connect;

        public bool Connect()
        {

            try
            {
                string dataSource = "datasource=database-1.cax3ljwbmj7z.us-east-1.rds.amazonaws.com;" +
                    "username=admin;password=10121430;database=Clinica";

                connect = new MySqlConnection(dataSource);
                connect.Open();
                return true;

            }
            catch (Exception)
            {
                connect.Close();
                return false;
            }
        }
    }
}
