using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CDUsuario
    {
        Conexion con;
        public CDUsuario() {

            con = new Conexion();
        }

        public string ValidarUsuario(string sUsuario) {

            string res = "";
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_CO_VALIDAR_USUARIO", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
            dap.Fill(dt);
            cn.Close();

            if (dt != null && dt.Rows.Count > 0)
            {
                string resultado = "";
                res = dt.Rows[0]["mensaje"].ToString();

            }
            else 
            {
                res = "Hubo  algun error al momento de validar.";    
            }


            return res;
        }

        public string AutenticarUsuairo(string sUsuario, string clave)
        {

            string res = "";
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_LOGIN_HTMLCORREO", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
            dap.SelectCommand.Parameters.AddWithValue("@Clave", clave);
            dap.Fill(dt);
            cn.Close();

            if (dt != null && dt.Rows.Count > 0)
            {
                string resultado = "";
                res = dt.Rows[0]["mensaje"].ToString();

            }
            else
            {
                res = "Hubo  algun error al momento del login.";
            }

            return res;
        }

        public string NomreUsuario(string usuario ) 
        {
            string res = "";
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT  c_nombre   FROM ma_usuario where c_codigousuario = '"+usuario+"'", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.Text;
            dap.Fill(dt);
            cn.Close();


            if (dt != null && dt.Rows.Count > 0)
            {
                res = dt.Rows[0]["c_nombre"].ToString();

            }

            return res;
        }
    }
}
