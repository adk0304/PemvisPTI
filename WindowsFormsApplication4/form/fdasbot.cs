using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4.form
{
    public partial class fdasbot : Form
    {
        public fdasbot()
        {
            InitializeComponent();
            
        }
        public void sembunyi()
        {
            panel7.Hide();
            panel3.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
        }
        private void dasbott()
        {
            
            panel3.Show();
            this.label4.Text = "Dashboard";
            
        }
        private void tbhdonor()
        {

            panel7.Show();
            this.label4.Text = "Donor Darah";
            
        }
        private void signout()
        {
            flogin baru = new flogin();
            this.Hide();
            baru.Show();
        }
        private void dnrdarah()
        {
            panel8.Show();
            this.label4.Text = "Tambah Pendonor";
        }
        private void stokkk()
        {
            panel9.Show();
            this.label4.Text = "Stok Darah";
        }
        private void laporrrr()
        {
            panel10.Show();
            this.label4.Text = "Laporan";
        }
        private void btndasbor_Click(object sender, EventArgs e)
        {
            sembunyi();
            dasbott();
        }

        private void btnupdarah_Click(object sender, EventArgs e)
        {
            sembunyi();
            dnrdarah();
        }

        private void btngivedrh_Click(object sender, EventArgs e)
        {
            sembunyi();
            tbhdonor();
            
        }

        private void btnstok_MouseClick(object sender, MouseEventArgs e)
        {
            sembunyi();
            stokkk();
        }

        private void btnlaporan_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnlogout_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            sembunyi();
            laporrrr();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            signout();
        }

        

        
    }
}
