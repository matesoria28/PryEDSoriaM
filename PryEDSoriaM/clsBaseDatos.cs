using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; //Solamente para BD de access
using System.Windows.Forms;
using System.Drawing.Text;

namespace PryEDSoriaM
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion1 = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        //private string varSQL = "Select * from Libro";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }


        public void Listar(String tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }

        }

        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }

        }












    }
}
