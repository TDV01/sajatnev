using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sajatnev
{
    internal class Adatbazis
    {
        MySqlConnection connection =null;
        MySqlCommand command = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "konyvesbolt2";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
        }
        internal List<Konyv> getkonyvek()
        {
            List<Konyv> konyv = new List<Konyv>();
            command.CommandText = "SELECT * FROM konyv";
            try
            {
                nyit();
                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Konyv uj = new Konyv(dr.GetInt32("konyvid"),dr.GetString("szerzo"),dr.GetString("cim"),dr.GetString("isbn"),dr.GetInt32("ar"));
                        konyv.Add(uj);
                        
                    }
                }

                    zar();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return konyv;
        }
        internal List<Vasarlo> getvasarlok()
        {
            List<Vasarlo> vasarlos = new List<Vasarlo>();
            command.CommandText = "SELECT * FROM vasarlo";
            try
            {
                nyit();
                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Vasarlo uj = new Vasarlo(dr.GetInt32("vasarloid"),dr.GetString("nev"),dr.GetString("email_cim"),dr.GetString("felhasznalonev"));
                        vasarlos.Add(uj);
                    }
                }

                zar();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return vasarlos;

        }


        private void nyit() 
        {
            if (connection.State!=System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
