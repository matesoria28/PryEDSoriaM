using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDSoriaM
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objCliente= new clsArchivo();
            objCliente.NomArchi = "Clientes.csv";
            objCliente.Grabar(TxtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objCliente.Recorrer(dgvClientes);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo X = new clsArchivo();
            X.NomArchi = "Clientes.CSV";
            if (File.Exists(X.NomArchi)) X.Recorrer(dgvClientes);
        }
    }
}
