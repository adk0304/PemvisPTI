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

        private void btndasbor_Click(object sender, EventArgs e)
        {

        }

        private void btnupdarah_Click(object sender, EventArgs e)
        {
            Fpendonor fpend = new Fpendonor();
            fpend.Show();
            this.Hide();
        }

        private void btngivedrh_Click(object sender, EventArgs e)
        {

        }

        private void btnstok_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnlaporan_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnlogout_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        
    }
}
