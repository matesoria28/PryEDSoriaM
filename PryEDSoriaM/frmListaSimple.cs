using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEDSoriaM
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }


        clsListaSimple objLista= new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvLista);
            objLista.Recorrer(cmbLista);
            objLista.Recorrer(lstLista);
            objLista.Recorrer("clsListaSimple.csv"); 

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text!=""&&txtNombre.Text!=""&&txtTramite.Text!="")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbLista.Text);
                objLista.Eliminar(x);
                objLista.Recorrer(dgvLista);
                objLista.Recorrer(lstLista);
                objLista.Recorrer(cmbLista);
                
            }
            else
            {
                MessageBox.Show("La lista esta vacia");

            }
            btnEliminar.Enabled = false;
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.Text =="") 
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
