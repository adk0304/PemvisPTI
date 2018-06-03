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
    public partial class Fpendonor : Form
    {
        public Fpendonor()
        {
            InitializeComponent();
        }
        koneksi req2 = new koneksi();

        private void addpendonor()
        {
            variable.inputdatapendonor pend = new variable.inputdatapendonor();
            pend.nama_pendonor = tbnama.Text;
            pend.alamat_donor = tbalamat.Text;
            pend.umur_donor = tbumur.Text;
            pend.tanggal_lahir = TTL.Text;
            pend.berat_badan = tbberatbadan.Text;
            pend.input_goldar = tbgoldar.Text;
            pend.riwayat_penyakit = tbriwayat.Text;
            req2.tambahpendonor(pend.nama_pendonor, pend.alamat_donor, pend.umur_donor, pend.tanggal_lahir, pend.berat_badan, pend.input_goldar, pend.riwayat_penyakit);
            MessageBox.Show("Data berhasil di simpan");
        }
        
        private void Fpendonor_Load(object sender, EventArgs e)
        {

        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            addpendonor();
        }

        private void btambah_Click(object sender, EventArgs e)
        {
            tbnama.Clear();
            tbalamat.Clear();
            tbumur.Clear();
            //TTL.Clear();
            tbberatbadan.Clear();
            tbgoldar.Clear();
            tbriwayat.Clear();
        }

        private void TTL_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            fdasbot home = new fdasbot();
            home.Show();
            this.Hide();
        }
    }
}
