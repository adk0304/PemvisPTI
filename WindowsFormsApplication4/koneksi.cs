using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    class koneksi
    {
        string konfigurasi = "SERVER=localhost;PORT=3306;UID=root;PASSWORD=;DATABASE=donordarah";
        MySqlConnection sambung = new MySqlConnection();
        public koneksi()
        {
            sambung.ConnectionString = konfigurasi;
        }
        public static MySqlConnection getkonek()
        {
            MySqlConnection connn = null;
            try
            {
                string baru ="SERVER=localhost;PORT=3306;UID=root;PASSWORD=;DATABASE=donordarah";
                connn = new MySqlConnection(baru);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return connn;
        }
        public void tambahacc(string name, string pass)
        {
            sambung.Open();
            string perintah = "INSERT INTO adminn(namaadmin,passadmin) VALUES ('" + name + "','" + pass + "');";
            MySqlCommand cmd = new MySqlCommand(perintah, sambung);
            cmd.ExecuteNonQuery();
            sambung.Close();
        }
        //public Boolean ceklog(string loguser, string logpass)
        //{
        //    string printa = "SELECT namaadmin,passadmin FROM adminn";
        //    sambung.Open();
        //    MySqlCommand cmdlog = new MySqlCommand(printa, sambung);
        //    MySqlDataReader reader = cmdlog.ExecuteReader();
        //    while(reader.Read())
        //    {
        //        if((loguser==reader.GetString(0))&&(logpass==reader.GetString(1)))
        //        {
        //            return true;
        //        }
        //    }
        //    sambung.Close();
        //    return false;

        //}

    }
}
