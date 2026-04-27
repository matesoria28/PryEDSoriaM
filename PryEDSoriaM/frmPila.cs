using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDSoriaM
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x= new clsNodo();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            pila.Agregar(x);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            pila.Recorrer("Pila.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(pila.Primero != null)
            {
                lblCodigo3.Text = pila.Primero.Cod.ToString();
                lblNombre3.Text = pila.Primero.Nom;
                lblTramite3.Text = pila.Primero.Tra;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
                pila.Recorrer("Pila.csv");
            }
            else
            {
                lblCodigo3.Text = "";
                lblNombre3.Text = "";
                lblTramite3.Text = "";
            }
        }
    }
}
