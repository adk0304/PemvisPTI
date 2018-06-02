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
    public partial class laporr : UserControl
    {
        public static laporr panggil;
        public static laporr panggil_
        {
            get
            {
                if (panggil == null)
                {
                    panggil = new laporr();
                }
                return panggil;
            }
        }
        public laporr()
        {
            InitializeComponent();
        }
    }
}
