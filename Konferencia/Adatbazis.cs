using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konferencia
{
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "konferencia";
            sb.CharacterSet = "utf8";

            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();

            try
            {
                kapcsolatNyit();
               
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal List<Eloadas> konferenciaAdatokBetolt()
        {
            List<Eloadas> eloadas = new List<Eloadas>();
            //sql.CommandText = "SELECT * FROM ertekelesek NATURAL JOIN eloadasok";
            sql.CommandText = "SELECT * FROM `ertekelesek` INNER JOIN eloadasok ON eloadasok.eloadasid=ertekelesek.eloadasid;";

            try
            {
                kapcsolatNyit();
                using (MySqlDataReader reader = sql.ExecuteReader())
                {
                    int aktualisID = -1;
                    int eloadasIndex = -1;
                    while (reader.Read())
                    {
                        if(aktualisID != reader.GetInt32("eloadasid"))
                        {
                            eloadas.Add(new Eloadas(reader.GetInt32("eloadasid"), reader.GetString("ertekeles"), reader.GetInt32("sor"), reader.GetInt32("szek")));
                            aktualisID = reader.GetInt32("eloadasid");
                            eloadasIndex++;
                        }
                        eloadas[eloadasIndex].TeremAdat(reader.GetInt32("sor"), reader.GetInt32("szek"), reader.GetInt32("ertekeles"));
                    }
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            return eloadas;
        }

        private void kapcsolatNyit()
        {
            if(connection.State != System.Data.ConnectionState.Open) connection.Open();
        }
        private void kapcsolatZar()
        {
            if(connection.State != System.Data.ConnectionState.Closed) connection.Close();
        }

    }
}
