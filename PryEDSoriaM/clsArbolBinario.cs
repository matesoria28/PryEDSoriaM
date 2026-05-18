using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDSoriaM
{
    internal class clsArbolBinario
    {
        //creo el campo inicial del arbol. Lo llamamos raiz
        private clsNodo Pri;

        private clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo P= Raiz; //Ant
                clsNodo Aux=Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Cod < Aux.Cod) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;                  
                }
                //Fuera del limiete
                if (Nvo.Cod < P.Cod) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;
            }

        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo !=null)InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Cod, R.Nom, R.Tra);
            if(R.Derecho !=null)InOrdenAsc(Dgv, R.Derecho);
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Cod);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
    }
}
