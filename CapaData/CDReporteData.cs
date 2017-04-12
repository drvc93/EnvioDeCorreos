using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{
     public class CDReporteData
    {
         Conexion con;

         public CDReporteData()
         {
             con = new Conexion();
         }

         public DataTable DataRepCumple(string sCompania, DateTime dtFecha, string sUsuario)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("SP_CO_EMPLCUMPLE", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
             dap.SelectCommand.Parameters.AddWithValue("@FechaHoy", dtFecha);
             dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
             dap.SelectCommand.Parameters.AddWithValue("@Fecha", dtFecha);
             dap.SelectCommand.Parameters.AddWithValue("@Registros", 0);

             dap.Fill(dt);
             cn.Close();

             return dt;


         }
    }
}
