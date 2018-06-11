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
    public partial class stokdara : UserControl
    {
        public static stokdara panggil;
        public static stokdara panggil_
        {
            get
            {
                if (panggil == null)
                {
                    panggil = new stokdara();
                }
                return panggil;
            }
        }
        public stokdara()
        {
            InitializeComponent();
        }
        koneksi req = new koneksi();
        MySqlConnection conn = koneksi.getkonek();
        private void hitungdrha()
        {
            string A = "A";
            string perina = "SELECT COUNT(*) FROM inputdarah WHERE inputgoldar LIKE '"+A+"'";
            conn.Open();
            MySqlCommand cmdlog = new MySqlCommand(perina, conn);
            //MySqlDataReader reader = cmdlog.ExecuteReader();
            typea.Text = cmdlog.ExecuteScalar().ToString();
            
            conn.Close();

            string B = "B";
            string perina1 = "SELECT COUNT(*) FROM inputdarah WHERE inputgoldar LIKE '" + B + "'";
            conn.Open();
            MySqlCommand cmdlog1 = new MySqlCommand(perina1, conn);
            //MySqlDataReader reader = cmdlog.ExecuteReader();
            typeb.Text = cmdlog1.ExecuteScalar().ToString();
            conn.Close();

            
            string AB = "AB";
            string perina2 = "SELECT COUNT(*) FROM inputdarah WHERE inputgoldar LIKE '" + AB + "'";
            conn.Open();
            MySqlCommand cmdlog2 = new MySqlCommand(perina2, conn);
            //MySqlDataReader reader = cmdlog.ExecuteReader();
            typeab.Text = cmdlog2.ExecuteScalar().ToString();
            conn.Close();

            string O = "O";
            string perina3 = "SELECT COUNT(*) FROM inputdarah WHERE inputgoldar LIKE '" + O + "'";
            conn.Open();
            MySqlCommand cmdlog3 = new MySqlCommand(perina3, conn);
            //MySqlDataReader reader = cmdlog.ExecuteReader();
            typeo.Text = cmdlog3.ExecuteScalar().ToString();
            conn.Close();
            

        }
        private void cicle()
        {
           // int hasil;
            int aa = int.Parse(typea.Text);
            int bb = int.Parse(typeb.Text);
            int cc = int.Parse(typeab.Text);
            int dd = int.Parse(typeo.Text);
            cicleea.Value = aa;
            cicleeb.Value = bb;
            cicleeab.Value = cc;
            cicleeo.Value = dd;


            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void typea_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitungdrha();
            cicle();

        }
    }
}
