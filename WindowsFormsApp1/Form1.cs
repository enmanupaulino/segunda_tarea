using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.cap_5;
using WindowsFormsApp1.cap6;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void EjecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial f = new Factorial();
            f.MdiParent = this;
            f.Show();
        }

        private void ArrglegoJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promedio f = new promedio();
            f.MdiParent = this;
            f.Show();
        }
    }
}
