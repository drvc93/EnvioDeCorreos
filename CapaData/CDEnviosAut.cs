using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
     public class CDEnviosAut
    {
         Conexion con;

         public CDEnviosAut()
         {
             con = new Conexion();

         }


         public DataTable EnviosRealizados(String sCompania , DateTime  dtFechaI , DateTime dtFechaF)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("SP_CO_ENVIOSAUTREALIZADOS", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
             dap.SelectCommand.Parameters.AddWithValue("@FechaI", dtFechaI);
             dap.SelectCommand.Parameters.AddWithValue("@FechaF", dtFechaF);
             dap.Fill(dt);
             cn.Close();

             return dt;
         }

         public DataTable DiasEnvios(String sCompania, string sDia)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("SP_CO_ENVIOSXDIA", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
             dap.SelectCommand.Parameters.AddWithValue("@Dia", sDia);
             
             dap.Fill(dt);
             cn.Close();

             return dt;
         }


    }
}
