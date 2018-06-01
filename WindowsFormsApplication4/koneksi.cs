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
        //public void test(string hasil)
        //{
        //    sambung.Open();
        //    if (sambung.State == System.Data.ConnectionState.Open)
        //    {
        //        string ss = "Connection is opened";
        //    }
        //}

    }
}
