using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4.form
{
    public partial class tbhpndonor : UserControl
    {
        public static tbhpndonor panggil;
        koneksi req2 = new koneksi();
        public static tbhpndonor panggil_
        {
            get
            {
                if (panggil == null)
                {
                    panggil = new tbhpndonor();
                }
                return panggil;
            }
        }
        public tbhpndonor()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void btambah_Click(object sender, EventArgs e)
        {
          
                tbnama.Text = "";
                tbalamat.Text = "";
                tbumur.Text = "";
                //TTL.Clear();
                tbberatbadan.Text = "";
                tbgoldar.Text = "";
                tbriwayat.Text = "";
                MessageBox.Show("Masukkan Data Pendonor");
           
        }

        private void bsimpan_Click(object sender, EventArgs e)
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
    }
}
