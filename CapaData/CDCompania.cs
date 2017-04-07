using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CDCompania
    {
        Conexion con;
        public CDCompania()
        {
            con = new Conexion();
        }


        public DataTable AllCompanias()
        {
            String selectText = "SELECT	c_Compania , c_Nombres FROM ma_Compania";
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter(selectText, cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.Text;
            //dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
            dap.Fill(dt);
            cn.Close();

            return dt;

        }

        public DataTable CompaniasxUsuario(String  sUsuario)
        {
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_IN_COMPANIASXUSUARIO", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
            dap.Fill(dt);
            cn.Close();

            return dt;
        }

    }
}
