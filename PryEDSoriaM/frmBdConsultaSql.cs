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
    public partial class frmBdConsultaSql : Form
    {
        public frmBdConsultaSql()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos sql = new clsBaseDatos();
            sql.Listar(dgvConsultaSQL, txtConsultaSQL.Text);
        }

        private void frmBdConsultaSql_Load(object sender, EventArgs e)
        {
            btnListar.Enabled = false;
        }

        private void txtSQL_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultaSQL.Text != "") btnListar.Enabled = true;
            else btnListar.Enabled = false;
        }
    }
}
