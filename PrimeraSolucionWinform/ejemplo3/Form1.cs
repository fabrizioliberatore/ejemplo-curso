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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("rojo");
            cboColorFavorito.Items.Add("verde");
            cboColorFavorito.Items.Add("negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = ckbChocolate.Checked == true ? "si chocolate" : "no choco";

            string tipo;
            if (rbtmuggle.Checked)
                tipo = "Muggle";
            else if (rbtwizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Skibs";

            string colorfavorito = cboColorFavorito.SelectedItem.ToString();
            string numerofavorito = numNumeroFavorito.Value.ToString();

            string mensaje = $"Nombre: {Nombre}\n" +  // \n es salto de line
                     $"Fecha de nacimiento: {fecha.ToShortDateString()}\n" +
                     $"Chocolate: {chocolate}\n" +
                     $"Tipo: {tipo}\n" +
                     $"Color favorito: {colorfavorito}\n" +
                     $"Número favorito: {numerofavorito}";

            MessageBox.Show(mensaje, "Perfil");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvwElementos.Items.Add(elem);
        }

        private void labelNumeroFavorito_Click(object sender, EventArgs e)
        {

        }
    }
}
