﻿using System;
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
        public void tambahpendonor(string nama, string alamat, string umur, string tanggallahir, string beratbadan, string goldar, string riwayat)
        {
            sambung.Open();
            string perintah2 = "INSERT INTO inputdatapendonor(namapendonor,alamat,umur,tanggallahir,beratbadan,inputgoldar,riwayatpenyakit) VALUES ('" + nama + "','" + alamat + "','" + umur + "','" + tanggallahir + "','" + beratbadan + "','" + goldar + "','" + riwayat + "');";
            MySqlCommand cmd2 = new MySqlCommand(perintah2, sambung);
            cmd2.ExecuteNonQuery();
            sambung.Close();
        }
        public void tbhdarahhh(string name, string tanggal, string gooldar)
        {
            sambung.Open();
            string perintah = "INSERT INTO inputdarah(namapendonor,tanggalmasuk,inputgoldar) VALUES ('" + name + "','" + tanggal + "','"+ gooldar +"');";
            MySqlCommand cmd = new MySqlCommand(perintah, sambung);
            cmd.ExecuteNonQuery();
            sambung.Close();
        }

    }
}
