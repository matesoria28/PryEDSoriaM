using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEDSoriaM
{
    internal class clsCola
    {
        //campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Sig = nuevo;
                Ultimo = nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            { 
                Primero = Primero.Sig;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.Sig;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Cod);
                aux = aux.Sig;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nom);
                aux = aux.Sig;
            }
        }

        public void Recorrer(String NombreArchivo)
        { 
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo,false,Encoding.UTF8);
            AD.WriteLine("Lista de espera/n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Cod);
                AD.Write(";");
                AD.Write(aux.Nom);
                AD.Write(";");
                AD.Write(aux.Tra);
                aux = aux.Sig;

            }
            AD.Close();


        }
            

    }
}
