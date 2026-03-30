using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            AD.WriteLine("Hola!!!");
            AD.Close();

        }

        public void grabar(string Dato)
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine(Dato);
            AD.Close();

        }
    }

   
}   
