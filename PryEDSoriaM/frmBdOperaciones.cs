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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos sql = new clsBaseDatos();
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmBdOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO " +
               "FROM LIBRO " +
               "ORDER BY 1 DESC";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO, AÑO " +
              "FROM LIBRO " +
              "ORDER BY TITULO ASC";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT Libro.Titulo, Autor.Nombre " +
                "FROM Libro INNER JOIN Autor " +
                "ON Libro.IdAutor = Autor.IdAutor";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnSleccionSimple_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionPorConvulcion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * " +
               "FROM (SELECT * FROM LIBRO WHERE idIdioma > 1) as X " +
               "WHERE IdPais = 2 ";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT *  " +
               "FROM LIBRO " +
               "WHERE IDIDIOMA = 1 " +
               "UNION " +
               "SELECT * " +
               "FROM LIBRO " +
               "WHERE IDIDIOMA = 2";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM LIBRO " +
    " WHERE IDIDIOMA = 2 AND " +
    "IDLIBRO IN " +
    " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) " +
    " ORDER BY 1 ASC";
            sql.Listar(varSql, dgvBdOperaciones);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM LIBRO " +
               " WHERE IDIDIOMA = 2 AND " +
               "IDIDIOMA NOT IN " +
               " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) " +
               " ORDER BY 1 ASC";
            sql.Listar(varSql, dgvBdOperaciones);
        }
    }
}
