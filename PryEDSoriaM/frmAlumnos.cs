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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo Alumnos= new clsArchivo();
            Alumnos.NomArchi = "Clientes.csv";
            Alumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            Alumnos.Recorrer(dgvAlumnos);
        }
    }
}
