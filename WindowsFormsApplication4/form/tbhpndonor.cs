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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
