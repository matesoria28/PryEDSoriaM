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
        
        private clsNodo primerNodo;
        
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
                    if (Nuevo.Cod < aux.Cod) aux = aux.Izquierdo; 
                    else aux = aux.Derecho; 
                }
                if (Nuevo.Cod < ant.Cod) ant.Izquierdo = Nuevo;
                else ant.Derecho = Nuevo;
            }
        }
        public void Eliminar(Int32 codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }

       
        private clsNodo EliminarNodo(clsNodo R, Int32 codigo)
        {
            if (R == null)
            {
                MessageBox.Show("El código no existe en el árbol.");
                return null;
            }
            if (codigo < R.Cod) R.Izquierdo = EliminarNodo(R.Izquierdo, codigo);       
            else if (codigo > R.Cod) R.Derecho = EliminarNodo(R.Derecho, codigo); 

            else
            {                
                if (R.Izquierdo == null && R.Derecho == null) return null;
                else if (R.Izquierdo == null) return R.Derecho;
               
                else if (R.Derecho == null) return R.Izquierdo;

               
                else
                {
                    clsNodo sucesor = BuscarMinimo(R.Derecho);
                    R.Cod = sucesor.Cod;
                    R.Nom = sucesor.Nom;
                    R.Tra = sucesor.Tra;
                    R.Derecho = EliminarNodo(R.Derecho, sucesor.Cod);
                }
            }
            return R;
        }
        private clsNodo BuscarMinimo(clsNodo R)
        {
            while (R.Izquierdo != null)
                R = R.Izquierdo;
            return R;
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo); 
            dgv.Rows.Add(R.Cod, R.Nom, R.Tra);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0; 
            if (Raiz != null)
            {
                InOrdenAsc(vector, ref ind, Raiz);
            }
        }

       
        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(vec, ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho != null) InOrdenAsc(vec, ref ind, R.Derecho);

        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

       
        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) 
            {
                grilla.Rows.Add(R.Cod, R.Nom, R.Tra);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla, R.Derecho);
            }
        }

        
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

      
        private void PostOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) 
            {
                PostOrden(grilla, R.Izquierdo);
                PostOrden(grilla, R.Derecho);
                grilla.Rows.Add(R.Cod, R.Nom, R.Tra);
            }
        }

        
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

        
        public void Equilibrar()
        {
            int cantidad = ContarNodos(Raiz);
            if (cantidad <= 1) return;
            clsNodo[] vector = new clsNodo[cantidad];
            Recorrer(vector);
            Raiz = null;
            InsertarBalanceado(vector, 0, cantidad - 1);
        }
        private int ContarNodos(clsNodo R)
        {
            if (R == null) return 0;
            return 1 + ContarNodos(R.Izquierdo) + ContarNodos(R.Derecho);
        }
        private void InsertarBalanceado(clsNodo[] vector, int inicio, int fin)
        {
            if (inicio > fin) return;

            int medio = (inicio + fin) / 2;

            vector[medio].Izquierdo = null;
            vector[medio].Derecho = null;

            Agregar(vector[medio]);

            InsertarBalanceado(vector, inicio, medio - 1);
            InsertarBalanceado(vector, medio + 1, fin);
        }

    }
}

