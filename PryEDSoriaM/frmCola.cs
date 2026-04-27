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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola ColaEspera= new clsCola(); //Global
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona=new clsNodo();
            Persona.Cod = Convert.ToInt32(txtCodigo.Text);
            Persona.Nom = txtNombre.Text;
            Persona.Tra = txtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dgvCola);
            ColaEspera.Agregar(Persona);
            ColaEspera.Agregar(Persona);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            { 
                lblCodigo3.Text=ColaEspera.Primero.Cod.ToString();
                lblNombre3.Text = ColaEspera.Primero.Nom;
                lblTramite3.Text = ColaEspera.Primero.Tra;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvCola);
                ColaEspera.Recorrer(lstCola);
                ColaEspera.Recorrer("Cola.csv");
   
            }
            else
            {
                lblCodigo3.Text = "";   
                lblNombre3.Text = "";
                lblTramite3.Text = "";
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
