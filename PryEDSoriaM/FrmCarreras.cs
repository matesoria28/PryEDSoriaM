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
    public partial class FrmCarreras : Form
    {
        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera=new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.grabar(txtCarrera.Text);
            objCarrera.Recorrer(lstCarrera);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.BorrarTodo();
            objCarrera.Recorrer(lstCarrera);
            
        }
    }
}
