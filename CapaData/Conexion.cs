using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
     public class Conexion
    {

        SqlConnection con;
        string Conn;
        public Conexion()
        {
            if (con == null)
                con = conexion();
        }

        public SqlConnection conexion()
        {
            Conn = "data source = ibserver_29; initial catalog = lys; user id = desarrollador2; password = @desit39";
            //Conn = Constantes.ConexionString;
            return new SqlConnection(Conn);
        }
    }
}
