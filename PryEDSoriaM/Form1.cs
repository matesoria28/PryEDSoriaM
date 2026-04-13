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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datosDeDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador v = new frmDatosDesarrollador();
            v.ShowDialog();

        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses frmMeses = new frmMeses();
            frmMeses.ShowDialog();

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores frmColores = new frmColores();
            frmColores.ShowDialog();
           

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();

        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarreras Carreras = new FrmCarreras();
            Carreras.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos Alumnos = new frmAlumnos();
            Alumnos.ShowDialog();
        }
    }
}
