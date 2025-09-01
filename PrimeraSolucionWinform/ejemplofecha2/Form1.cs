using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplofecha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;

            MessageBox.Show($"fecha : {fecha1.ToString("dd/MM/yy")}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"fecha : {calFecha.SelectionStart.ToShortDateString()}");
        }
    }
}
