using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta elchocolate" : "Odia el chocolate";
            string tipo;
            if (rbtnMuggle.Checked)
                tipo = "Muggle";
            else if (rbtnWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squb";

            string colorFavorito = cboColor.SelectedItem.ToString();

            string numeroFavorito = numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + ", " + chocolate + ", Es de tipo: " + tipo + "Color favorito: " + colorFavorito + "Numero Favorito: " + numeroFavorito);
        }
    }
}
