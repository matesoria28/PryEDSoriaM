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
        clsArbolBinario x= new clsArbolBinario();
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
          //  x.Agregar(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToString(txtTramite.Text));
            x.Recorrer(dgvArbol);
            x.Recorrer(cmbLista);
        }
    }
}
