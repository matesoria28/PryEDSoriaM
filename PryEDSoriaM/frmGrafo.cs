using pryEDSoriaM;
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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafos objGrafo = new clsGrafos();

        private void frmGrafos_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);
            objGrafo.MostrarCiudades(cmbDesde);
            objGrafo.MostrarCiudades(cmbHasta);
            objGrafo.MostrarCiudades(cmbOrigen2);
            objGrafo.MostrarCiudades(cmbDestino2);

            btnConsultar.Enabled = false;
            btnBorrar.Enabled = false;
            btnListarDestinos.Enabled = false;
            btnListarOrigenes.Enabled = false;
            btnVerViajes.Enabled = false;
        }

        private void Limpiar()
        {
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void ValidarDatos()
        {
            if (cmbOrigen.Text != "" && cmbDestino.Text != "" && txtPrecio.Text != "")
            {
                btnCargar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }
        private void Validacion()
        {
            if (cmbOrigen2.Text != "" && cmbDestino2.Text != "")
            {
                btnConsultar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen2.SelectedIndex;
            Int32 c = cmbDestino2.SelectedIndex;
            objGrafo.Eliminar(f, c);
            cmbOrigen2.SelectedIndex = -1;
            cmbDestino2.SelectedIndex = -1;
            lblPrecioResultado.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            objGrafo.Agregar(f, c, p);
            objGrafo.MostrarTodo(dgvGrafo);
            Limpiar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen2.SelectedIndex;
            Int32 c = cmbDestino2.SelectedIndex;
            lblPrecioResultado.Text = Convert.ToString(objGrafo.Consultar(f, c));
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Int32 f = cmbDesde.SelectedIndex;
            objGrafo.MostrarDestinos(f, dgvGrafo);
        }

        private void btnOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c = cmbHasta.SelectedIndex;
            objGrafo.MostrarOrigenes(c, dgvGrafo);
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dgvGrafo);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbOrigenCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDestinoCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesde.SelectedIndex != -1) btnListarDestinos.Enabled = true;
            else btnListarDestinos.Enabled = false;

        }

        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHasta.SelectedIndex != -1)
            {
                btnListarOrigenes.Enabled = true;
                btnVerViajes.Enabled = true;
            }
            else
            {
                btnListarOrigenes.Enabled = false;
                btnVerViajes.Enabled = false;
            }
        }

     
    }
}
