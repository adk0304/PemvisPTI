using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class fregis : Form
    {
        public fregis()
        {
            InitializeComponent();
        }
        koneksi req = new koneksi();
        private void addacc()
        {
            datadmin min = new datadmin();
            min.namamin = baruuser.Text;
            min.passmin = addpassword.Text;
            if (min.passmin == readdpass.Text)
            {
                req.tambahacc(min.namamin, min.passmin);
                gcancel();
            }
            else
            {
                MessageBox.Show("Periksa kembari Form login");
            }
        }
        private void gcancel()
        {
            flogin flog = new flogin();
            flog.Show();
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

        private void addpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void baruuser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void canceel_Click(object sender, EventArgs e)
        {
            gcancel();
        }

        private void btnbuatacc_Click(object sender, EventArgs e)
        {
            addacc();
            
        }

        

        
    }
}
