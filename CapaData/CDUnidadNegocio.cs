using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CDUnidadNegocio
    {

        Conexion con;

        public CDUnidadNegocio()
        {
            con = new Conexion();
        }

        public DataTable UnidadNegocioxCia(String sCompania)
        {
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_CO_UNDNEGO_X_CIA", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
           
            dap.Fill(dt);
            cn.Close();

            return dt;
        }
    }
}
