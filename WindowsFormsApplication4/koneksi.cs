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
        public void tambahacc(string name, string pass)
        {
            sambung.Open();
            string perintah = "INSERT INTO adminn(namaadmin,passadmin) VALUES ('" + name + "','" + pass + "');";
            MySqlCommand cmd = new MySqlCommand(perintah, sambung);
            cmd.ExecuteNonQuery();
            sambung.Close();
        }

    }
}
