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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();
        private void frmArbol_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objArbol.Agregar(x);
            objArbol.Recorrer(dgvArbol);
            //Esto no es necesario pero se realiza para ver si funciona el programa y el método
            objArbol.Recorrer(cmbCodigo);
            objArbol.Recorrer(trvArbolBinario);

            //Recorrer vector y guardar los datos 
            int cantidadNodos = dgvArbol.Rows.Count;
            clsNodo[] vectorDeNodos = new clsNodo[cantidadNodos];
            objArbol.Recorrer(vectorDeNodos);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.Text != "")
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
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

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            if (rbInOrden.Checked) objArbol.Recorrer(dgvArbol);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            if (rbPreOrden.Checked) objArbol.RecorrerPreOrden(dgvArbol);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            if (rbPostOrden.Checked) objArbol.RecorrerPostOrden(dgvArbol);
        }
    }
}
