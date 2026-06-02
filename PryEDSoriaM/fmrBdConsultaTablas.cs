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
    public partial class fmrBdConsultaTablas : Form
    {
        public fmrBdConsultaTablas()
        {
            InitializeComponent();
        }

        clsBaseDatos x = new clsBaseDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            x.Listar(cmbTablaBd.Text, dgvDatos);
        }
    }
}
