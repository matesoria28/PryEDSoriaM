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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objListaDoble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            clsNodo x = new clsNodo();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objListaDoble.Agregar(x);
            objListaDoble.Recorrer(lstListaDoble);
            objListaDoble.Recorrer(dgvListaDoble);
            objListaDoble.Recorrer(cmbListaDoble);
            objListaDoble.Recorrer("ListaDoble.csv");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaDoble != null)
            {
                Int32 x = Convert.ToInt32(cmbListaDoble.Text);
                objListaDoble.Eliminar(x);
                objListaDoble.Recorrer(dgvListaDoble);
                objListaDoble.Recorrer(lstListaDoble);
                objListaDoble.Recorrer(cmbListaDoble);

            }
            else
            {
                MessageBox.Show("La lista esta vacia");

            }
            btnEliminar.Enabled = false;
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.Recorrer(dgvListaDoble);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.RecorrerDes(dgvListaDoble);
            
        }

        private void cmbListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaDoble.Text == "")
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
