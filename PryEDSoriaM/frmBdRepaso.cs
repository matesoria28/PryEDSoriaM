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
    public partial class frmBdRepaso : Form
    {
        public frmBdRepaso()
        {
            InitializeComponent();
        }

        clsBaseDatos sql = new clsBaseDatos();

        private void frmBdRepaso_Load(object sender, EventArgs e)
        {
            btnListar.Enabled = false;
            cmbOperacionesBD.Items.Clear();
            cmbOperacionesBD.Items.Add("Todos los libros ordenados por título");
            cmbOperacionesBD.Items.Add("Libros con su autor");
            cmbOperacionesBD.Items.Add("Libros por país");
            cmbOperacionesBD.Items.Add("Libros por idioma");
            cmbOperacionesBD.Items.Add("Todos los autores");
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacionesBD.SelectedIndex != -1) btnListar.Enabled = true;
            else btnListar.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String varSql = "";
            switch (cmbOperacionesBD.SelectedIndex)
            {
                case 0:
                    lblOperacionesBD.Text = "Operación: Proyección de todos los libros ordenados por título (A-Z).";
                    varSql = "SELECT IDLIBRO, TITULO, AÑO, PRECIO " +
                             "FROM LIBRO " +
                             "ORDER BY TITULO ASC";
                    break;

                case 1:
                    lblOperacionesBD.Text = "Operación: Juntar (JOIN) entre Libro y Autor para ver qué autor escribió cada libro.";
                    varSql = "SELECT Libro.Titulo, Autor.Nombre, Libro.AÑO " +
                             "FROM Libro INNER JOIN Autor " +
                             "ON Libro.IdAutor = Autor.IdAutor " +
                             "ORDER BY Libro.Titulo ASC";
                    break;

                case 2:
                    lblOperacionesBD.Text = "Operación: Juntar (JOIN) entre Libro y País para ver el país de origen de cada libro.";
                    varSql = "SELECT Libro.Titulo, Pais.Nombre, Libro.AÑO " +
                             "FROM Libro INNER JOIN Pais " +
                             "ON Libro.IdPais = Pais.IdPais " +
                             "ORDER BY Pais.Nombre ASC";
                    break;

                case 3:
                    lblOperacionesBD.Text = "Operación: Juntar (JOIN) entre Libro e Idioma para ver en qué idioma está cada libro.";
                    varSql = "SELECT Libro.Titulo, Idioma.Nombre, Libro.PRECIO " +
                             "FROM Libro INNER JOIN Idioma " +
                             "ON Libro.IdIdioma = Idioma.IdIdioma " +
                             "ORDER BY Idioma.Nombre ASC";
                    break;

                case 4:
                    lblOperacionesBD.Text = "Operación: Proyección de todos los autores registrados en la base de datos.";
                    varSql = "SELECT * " +
                             "FROM Autor " +
                             "ORDER BY Nombre ASC";
                    break;
            }

            sql.Listar(dgvOperacionesBD, varSql);

        }
    }
}
