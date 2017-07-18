using System.Data.SqlClient;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaData
{   
     
    public class CDAccesos
    {
        Conexion con;
        public CDAccesos() {

            con = new Conexion();
        }

        public List<CEAcceso> AccesosXUsuario(string sUsuario , string sAplicacion)
        {
            List<CEAcceso> listresult = new List<CEAcceso>();
            SqlConnection cn = con.conexion();
            cn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SP_ACCESOS_MODENVIOS", cn);
            DataTable dt = new DataTable();
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@Usuario", sUsuario);
            dap.SelectCommand.Parameters.AddWithValue("@Aplicacion", sAplicacion);
            dap.Fill(dt);
            cn.Close();

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CEAcceso ac = new CEAcceso();
                    ac.Niveles = dt.Rows[i]["c_niveles"].ToString();
                    ac.Acceso = dt.Rows[i]["c_acceso"].ToString();
                    ac.Nuevo = dt.Rows[i]["c_nuevo"].ToString();
                    ac.Modificar = dt.Rows[i]["c_modificar"].ToString();
                    ac.Eliminar = dt.Rows[i]["c_eliminar"].ToString();
                    ac.Otros = dt.Rows[i]["c_otros"].ToString();

                    listresult.Add(ac);
                }

            }

            return listresult;
        }
    }
}
