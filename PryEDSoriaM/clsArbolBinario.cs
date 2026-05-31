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
        //Campo inicial del arbol se llama raiz
        private clsNodo primerNodo;
        //Propiedad
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo ant = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    ant = aux;
                    if (Nuevo.Cod < aux.Cod) aux = aux.Izquierdo; //Cuando el codigo sea menor a la raiz(que esta en aux) va a ir del lado izquierdo
                    else aux = aux.Derecho; //si el codigo es mayor a la raiz, pasa al lado derecho del arbol
                }
                if (Nuevo.Cod < ant.Cod) ant.Izquierdo = Nuevo;
                else ant.Derecho = Nuevo;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo); //El reocrrido es izquierda, raíz, derecha
            dgv.Rows.Add(R.Cod, R.Nom, R.Tra);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        //Sobrecarga recorrer para cargar vector
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0; // Inicializamos el índice en 0
            if (Raiz != null)
            {
                InOrdenAsc(vector, ref ind, Raiz);
            }
        }

        //Metodo recursivo InOrdenAsc para guardar en un vector
        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(vec, ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho != null) InOrdenAsc(vec, ref ind, R.Derecho);

        }

        //Recorrer PreOrden
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        //Procedimiento para mostrar en grilla PreOrden
        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) //Recorrido es raíz, izquierda y derecha
            {
                grilla.Rows.Add(R.Cod, R.Nom, R.Tra);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla, R.Derecho);
            }
        }

        //Recorrer PostOrden
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        //Procedimiento para mostrar en grilla PostOrden
        private void PostOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) //Recorrido es izquierda, derecha y raíz
            {
                PostOrden(grilla, R.Izquierdo);
                PostOrden(grilla, R.Derecho);
                grilla.Rows.Add(R.Cod, R.Nom, R.Tra);
            }
        }

        //Sobrecarga para recorrer el combo box 
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }


        private void InOrdenAsc(ComboBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Cod);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }

        //Recorrido para mostrar en un tree view
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Cod.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }
    }
}

