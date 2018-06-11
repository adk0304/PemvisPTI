using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4.form
{
    public partial class adddarah : UserControl
    {
        public static adddarah panggil;
        public static adddarah panggil_
        {
            get
            {
                if (panggil == null)
                {
                    panggil = new adddarah();
                }
                return panggil;
            }
        }
        public adddarah()
        {
           
                InitializeComponent();
                clearr();
        }
        koneksi req = new koneksi();
        MySqlConnection conn = koneksi.getkonek();
        private void isibio()
        {
            label4.Text = Namapen.Text;
            label6.Text = goldar.Text;
        }
        private void clearr()
        {
            panel2.Hide();
            panel1.Hide();
            panel3.Hide();
            label4.Text = "";
            label6.Text = "";
        }
        

        private void ceklig(string loguser, string loggol)
        {
            string printa = "SELECT *  FROM inputdatapendonor WHERE namapendonor LIKE '" + loguser + "' AND inputgoldar LIKE '" + loggol + "'";


            conn.Open();
            MySqlCommand cmdlog = new MySqlCommand(printa, conn);
            MySqlDataReader reader = cmdlog.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Account Terdaftar");
                panel2.Show();
                panel1.Show();
                isibio();
            }
            else
            {
                MessageBox.Show("Periksa Form pencarian");
            }
            conn.Close();

        }
        private void inputtt(string nam, string tgl, string gildir)
        {
            req.tbhdarahhh(nam, tgl, gildir);
            MessageBox.Show("Terima Kasih Telah mendonor");
            clearr();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btambah_Click(object sender, EventArgs e)
        {

            variable.inputdatapendonor bar = new variable.inputdatapendonor();
            bar.nama_pendonor = Namapen.Text;
            bar.input_goldar = goldar.Text;
            ceklig(bar.nama_pendonor, bar.input_goldar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            variable.inputdarah indrh = new variable.inputdarah();
            indrh.nama_pendonor = Namapen.Text;
            indrh.input_goldar = goldar.Text;
            indrh.tanggal_masuk = TTL.Text;
            inputtt(indrh.nama_pendonor, indrh.tanggal_masuk, indrh.input_goldar);
        }
    }
}
