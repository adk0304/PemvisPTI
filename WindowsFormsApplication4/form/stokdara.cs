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
    }
}
