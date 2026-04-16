using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDSoriaM
{
    internal class clsNodo
    {
        private Int32 cod;
        public Int32 Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        private String nom;
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private String tra;
        public String Tra
        {
            get { return tra; }
            set { tra = value; }
        }

        private clsNodo sig;
        public clsNodo Sig
        {
            get { return sig; }
            set { sig = value; }
        }

    }


}
