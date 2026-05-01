using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDSoriaM
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; } 
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else 
            {
                if (Nuevo.Cod <= Primero.Cod)
                {
                    Nuevo.Sig = Primero;
                    Primero = Nuevo;
                }
                else 
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux.Cod < Nuevo.Cod)
                    { 
                        ant = aux;
                        aux = aux.Sig;
                        if (aux == null) break;
                    }
                    ant.Sig = Nuevo;
                    Nuevo.Sig = aux;
                }

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
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
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

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Cod==Codigo)
            {
                Primero = Primero.Sig;
            }
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while(aux1.Cod!=Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Sig;
                }
                aux2.Sig = aux1.Sig;
            }
        }




    }

}
