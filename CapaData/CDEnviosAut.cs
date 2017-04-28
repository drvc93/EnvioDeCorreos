using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

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

         public DataTable HorasEnvios(String sCompania, string sDia, string sHora)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("SP_CO_ENVIOSXDIA_HORA", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
             dap.SelectCommand.Parameters.AddWithValue("@Dia", sDia);
             dap.SelectCommand.Parameters.AddWithValue("@Hora", sHora);

             dap.Fill(dt);
             cn.Close();

             return dt;
         }

         public DataTable ListaReporte(String sCompania)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("sp_co_listarep_envioaut", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);

             dap.Fill(dt);
             cn.Close();

             return dt;
         }

         public DataTable ListaUsuariosxReporte(String sCompania,string sCodRep , int nConsulta)
         {
             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter("SP_CO_LISTA_USUARIOS_X_REPAUT", cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.StoredProcedure;
             dap.SelectCommand.Parameters.AddWithValue("@Compania", sCompania);
             dap.SelectCommand.Parameters.AddWithValue("@CodigoRep", sCodRep);
             dap.SelectCommand.Parameters.AddWithValue("@Consulta", nConsulta);

             dap.Fill(dt);
             cn.Close();

             return dt;
         }

         public  List<CEUsuario> ListaUsuariosEnvio()
         {
             List<CEUsuario> lstUser = new List<CEUsuario>();
             String sqlSelect = "Select c_codigousuario,c_nombre from ma_usuario where c_estado = 'A'and isnull(c_correo,'') <> '' order by  c_nombre asc";

             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter(sqlSelect, cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.Text;
            

             dap.Fill(dt);
             cn.Close();

             if  (dt != null  &&  dt.Rows.Count > 0 )
             {
                 string ls_nom = "";
                 string ls_cod = "";
                 
                 for (int i = 0  ;  i< dt.Rows.Count ;i++)
                 {  

                    ls_nom =  dt.Rows[i]["c_nombre"].ToString();
                    ls_cod =  dt.Rows[i]["c_codigousuario"].ToString();

                    CEUsuario u = new CEUsuario(ls_nom.Trim(), ls_cod.Trim());
                    lstUser.Add(u);

                 }


                

             }

             return lstUser;
         }


         public string getCorreoUsuario(string codUsuario)
         {
             string correo = "";
             String sqlSelect = "SELECT IsNull(c_correo,'') c_correo FROM  dbo.ma_usuario where c_codigousuario  = '"+codUsuario+ "'";

             SqlConnection cn = con.conexion();
             cn.Open();
             SqlDataAdapter dap = new SqlDataAdapter(sqlSelect, cn);
             DataTable dt = new DataTable();
             dap.SelectCommand.CommandType = CommandType.Text;


             dap.Fill(dt);
             cn.Close();

             if (dt != null && dt.Rows.Count > 0)
             {
                 

                 for (int i = 0; i < dt.Rows.Count; i++)
                 {

                     correo = dt.Rows[i]["c_correo"].ToString();


                 }

             }

             return correo; 
         }


         public string UpdateInsertRepEnvioUs(CERepEnvUsu ru , CERepEnvUsu oldus)
         {
             SqlConnection cn = con.conexion();
             string result = "";
             SqlCommand sqlcmd = new SqlCommand();
             sqlcmd.Connection = cn;
             try
             {
                 sqlcmd.CommandText = "SP_CO_UPDATEREP_ENVIOAUT";
                 sqlcmd.CommandType = CommandType.StoredProcedure;
                 cn.Open();
                 sqlcmd.Parameters.AddWithValue("@Compania", ru.CCompania);
                 sqlcmd.Parameters.AddWithValue("@ReporteEnvio", ru.CReporteenvio);
                 sqlcmd.Parameters.AddWithValue("@Dia", ru.CDia);
                 sqlcmd.Parameters.AddWithValue("@Hora", ru.DHora);
                 sqlcmd.Parameters.AddWithValue("@UsuarioEnvio", ru.CUsuarioenvio);
                 sqlcmd.Parameters.AddWithValue("@Estado", ru.CEstado);
                 sqlcmd.Parameters.AddWithValue("@UltUsuario", ru.CUltimousuario);
                 sqlcmd.Parameters.AddWithValue("@UltFechaMod", ru.DUltimafechamodificacion);
                 sqlcmd.Parameters.AddWithValue("@CompaniaOld", oldus.CCompania);
                 sqlcmd.Parameters.AddWithValue("@ReporteEnvioOld", oldus.CReporteenvio);
                 sqlcmd.Parameters.AddWithValue("@DiaOld", oldus.CDia);
                 sqlcmd.Parameters.AddWithValue("@HoraOld", oldus.DHora);
                 sqlcmd.Parameters.AddWithValue("@UsuarioEnvioOld", oldus.CUsuarioenvio);

                 int rowsafect = sqlcmd.ExecuteNonQuery();
                 if (rowsafect > 0)
                 {

                     result = "OK";
                 }
             }



             catch (SqlException ex)
             {


                 result = Convert.ToString(ex.ErrorCode);
                 


             }

             finally
             {
                 cn.Close();
             }

             return result;
         }

         public string InsertarEjecucionEnvio(string Compania ,DateTime FechaEjecucion ,string Obs ,string UltUsu,DateTime UltFechaMod)
         {
             SqlConnection cn = con.conexion();
             string result = "";
             SqlCommand sqlcmd = new SqlCommand();
             sqlcmd.Connection = cn;
             try
             {
                 sqlcmd.CommandText = "SP_CO_INSERTAR_EJECUCION_ENVIO";
                 sqlcmd.CommandType = CommandType.StoredProcedure;
                 cn.Open();
                 sqlcmd.Parameters.AddWithValue("@Compania", Compania);
                 sqlcmd.Parameters.AddWithValue("@FechaEjecucion", FechaEjecucion);
                 sqlcmd.Parameters.AddWithValue("@Observacion", Obs);
                 sqlcmd.Parameters.AddWithValue("@UltUsuario", UltUsu);
                 sqlcmd.Parameters.AddWithValue("@UltimaFechaMod", UltFechaMod);

                 int rowsafect = sqlcmd.ExecuteNonQuery();
                 if (rowsafect > 0)
                 {

                     result = "OK";
                 }
             }



             catch (SqlException ex)
             {


                 result = ex.Message;


             }

             finally
             {
                 cn.Close();
             }

             return result;
         }


         public string DeleteRepEnvioUs(CERepEnvUsu ru)
         {
             SqlConnection cn = con.conexion();
             string result = "";
             SqlCommand sqlcmd = new SqlCommand();
             sqlcmd.Connection = cn;
             try
             {
                 sqlcmd.CommandText = "SP_CO_DELETEREP_ENVIOAUT";
                 sqlcmd.CommandType = CommandType.StoredProcedure;
                 cn.Open();
                 sqlcmd.Parameters.AddWithValue("@Compania", ru.CCompania);
                 sqlcmd.Parameters.AddWithValue("@ReporteEnvio", ru.CReporteenvio);
                 sqlcmd.Parameters.AddWithValue("@Dia", ru.CDia);
                 sqlcmd.Parameters.AddWithValue("@Hora", ru.DHora);
                 sqlcmd.Parameters.AddWithValue("@UsuarioEnvio", ru.CUsuarioenvio);

                 int rowsafect = sqlcmd.ExecuteNonQuery();
                 if (rowsafect > 0)
                 {

                     result = "OK";
                 }
             }



             catch (SqlException ex)
             {


                 result = ex.Message;


             }

             finally
             {
                 cn.Close();
             }

             return result;
         }


         public string UpdateReporteCab(string Compania , string Reporte , string Estado , string EnvioXUsuario)
         {
             SqlConnection cn = con.conexion();
             string result = "";
             SqlCommand sqlcmd = new SqlCommand();
             sqlcmd.Connection = cn;
             try
             {
                 sqlcmd.CommandText = "SP_CO_UPDATEREP_CAB";
                 sqlcmd.CommandType = CommandType.StoredProcedure;
                 cn.Open();
                 sqlcmd.Parameters.AddWithValue("@Compania",  Compania);
                 sqlcmd.Parameters.AddWithValue("@Reporte", Reporte);
                 sqlcmd.Parameters.AddWithValue("@Estado", Estado);
                 sqlcmd.Parameters.AddWithValue("@EnvioXusuario",EnvioXUsuario);
            

                 int rowsafect = sqlcmd.ExecuteNonQuery();
                 if (rowsafect > 0)
                 {

                     result = "OK";
                 }
             }



             catch (SqlException ex)
             {


                 result = ex.Message;


             }

             finally
             {
                 cn.Close();
             }

             return result;

         }


        


         


    }
}
