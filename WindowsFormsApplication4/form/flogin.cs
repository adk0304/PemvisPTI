using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace WindowsFormsApplication4
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }
        koneksi req = new koneksi();
        MySqlConnection conn = koneksi.getkonek();

        private void ceklig(string loguser, string logpass)
        {
            string printa = "SELECT *  FROM adminn WHERE namaadmin LIKE '" + loguser + "' AND passadmin LIKE '" + logpass + "'";


            conn.Open();
            MySqlCommand cmdlog = new MySqlCommand(printa, conn);
            MySqlDataReader reader = cmdlog.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Selamat Datang");
            }
            else
            {
                MessageBox.Show("Periksa Form Login");
            }
            conn.Close();

        }
        private void godas()
        {
            form.fdasbot dasb = new form.fdasbot();
            dasb.Show();
            this.Hide();
        }
        private void newspassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void newsuser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void readdpass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {

        }

        private void userlogin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void passlog_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void loginn_Click(object sender, EventArgs e)
        {
            datadmin lig = new datadmin();
            lig.namamin = userlogin.Text;
            lig.passmin = passlog.Text;
            ceklig(lig.namamin, lig.passmin);
            godas();
            

        }

        private void buatac_Click(object sender, EventArgs e)
        {
            fregis freg = new fregis();
            freg.Show();
            this.Hide();
        }

        private void flogin_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
