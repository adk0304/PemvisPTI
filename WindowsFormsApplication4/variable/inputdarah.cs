using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4.variable
{
    class inputdarah
    {
        private string idinput, namapendonor, tanggalmasuk, inputgoldar;

        public string id_input
        {
            get { return idinput; }
            set { idinput = value; }
        }
        public string nama_pendonor
        {
            get { return namapendonor; }
            set { namapendonor = value; }
        }
        public string tanggal_masuk
        {
            get { return tanggalmasuk; }
            set { tanggalmasuk = value; }
        }
        public string input_goldar
        {
            get { return inputgoldar; }
            set { inputgoldar = value;}
        }
    }
}
