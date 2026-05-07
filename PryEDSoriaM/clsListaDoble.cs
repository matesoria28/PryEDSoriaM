using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEDSoriaM
{
    internal class clsListaDoble
    {
        private clsNodo Primero;
        private clsNodo Ultimo;
        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Cod < Primero.Cod)
                {
                    Nvo.Sig = Primero;
                    Primero.anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Cod > Ultimo.Cod)
                    {
                        Ultimo.Sig = Nvo;
                        Nvo.anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;

                        while (aux.Cod < Nvo.Cod)
                        {
                            ant = aux;
                            aux = aux.Sig;
                        }
                        ant.Sig = Nvo;
                        Nvo.Sig = aux;
                        aux.anterior = Nvo;
                        Nvo.anterior = ant;
                    }
                }
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
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.anterior;
            }

        }
        public void Eliminar(Int32 Cod)
        {
            if (Primero.Cod == Cod && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Cod == Cod)
                {
                    Primero = Primero.Sig;
                    Primero.anterior = null;
                }
                else
                {
                    if (Ultimo.Cod == Cod)
                    {
                        Ultimo = Ultimo.anterior;
                        Ultimo.Sig = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Cod < Cod)
                        {
                            ant = aux;
                            aux = aux.Sig;
                        }
                        aux = aux.Sig;
                        ant.Sig = aux;
                        aux.anterior = ant;
                    }
                }
            }
        }



    }
}
