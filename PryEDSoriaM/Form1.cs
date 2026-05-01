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
            frmDatosDesarrollador formulario = new frmDatosDesarrollador();
            formulario.ShowDialog();

        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses formulario = new frmMeses();
            formulario.ShowDialog();

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores formulario = new frmColores();
            formulario.ShowDialog();
           

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes formulario = new frmClientes();
            formulario.ShowDialog();

        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarreras formulario = new FrmCarreras();
            formulario.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos formulario = new frmAlumnos();
            formulario.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola formulario = new frmCola();
            formulario.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila formulario= new frmPila();
            formulario.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple formulario = new frmListaSimple();
            formulario.ShowDialog();
        }
    }
}
