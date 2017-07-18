using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CDCliente
    {
        Conexion con;
        public CDCliente()
        { 
        
           con = new Conexion();
        
        }

        public DataTable MailClientes(string compania)
        {
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_MAIL_CLINETES", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Compania", compania);
            dap.Fill(dt);
            cn.Close();

            return dt;
        }

    }
}
