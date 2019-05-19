using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.cap6
{
    public partial class promedio : Form
    {
        public promedio()
        {
            InitializeComponent();
        }

        int[] x = new int[4] { 14, 25, 12, 12 };

        private void Button1_Click(object sender, EventArgs e)
        {

            int suma_ = x.Sum;
            /* foreach (int m in x)
             {
                suma = suma + m;
             suma+= m.ToString() + "  ";
             }

             MessageBox.Show(suma);
            */
        }
    }
}
