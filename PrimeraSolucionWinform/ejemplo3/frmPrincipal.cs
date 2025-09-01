using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void tbsPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms) //si dentro de la coleccion,en alguna de las vueltas
            {                                           //encuentra un form q sea del mismo tipo que quiero abrir luego, corta
                if (item.GetType() == typeof(Form1))  // con el return, y no lee el sig codigo
                {
                    MessageBox.Show("ey");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;//al usar MdiParent, no puedo usar el dialog, ya que dialog toma el control
            //ventana.ShowDialog();
            ventana.Show();
        }
    }
}
