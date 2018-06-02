using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4.variable
{
    class outputdarah
    {
        private string idoutput, golongandarah, banyakkantong, tanggalkeluar, keterangan;

        public string id_output
        {
            get { return idoutput; }
            set { idoutput = value; }
        }
        public string golongan_darah
        {
            get { return golongandarah; }
            set { golongandarah = value; }
        }
        public string banyak_kantong
        {
            get { return banyakkantong; }
            set { banyakkantong = value; }
        }
        public string tanggal_keluar
        {
            get { return tanggalkeluar; }
            set { tanggalkeluar = value; }
        }
        public string keterangan_darah
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
    }
}