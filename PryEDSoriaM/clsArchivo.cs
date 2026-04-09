using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace PryEDSoriaM
{
    internal class clsArchivo
    {
        //hemos creado un campo
        public string NomArchi= "Colores.txt";

        //hemos creado algunos metodos
        public void grabar()
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine();
            AD.Close();

        }

        public void grabar(string Dato)
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine(Dato);
            AD.Close();

        }
        public void Recorrer(ComboBox cmbDatos)
        {
            cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido= AD.ReadLine();
            while (DatoLeido != null)
            {
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido=AD.ReadLine();
            }
            AD.Close ();
        }
        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void BorrarTodo()
        {
            StreamWriter AD= new StreamWriter(NomArchi, false);
            AD.Close();
        }
        public void Grabar(String cod, String nom, String deu)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //Abrir AD para escritura
            AD.Write(cod); //Escribir el contenido de la variable
            AD.Write(";"); //va a la siguiente fila 
            AD.Write(nom);
            AD.Write(';');
            AD.WriteLine(deu);//escribir el contenido de la variable + enter
            AD.Close(); //cerrar AD
        }
    }

   
}   
