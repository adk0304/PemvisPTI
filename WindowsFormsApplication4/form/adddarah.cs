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
    public partial class adddarah : UserControl
    {
        public static adddarah panggil;
        public static adddarah panggil_
        {
            get
            {
                if (panggil == null)
                {
                    panggil = new adddarah();
                }
                return panggil;
            }
        }
        public adddarah()
        {
            InitializeComponent();
        }
    }
}
