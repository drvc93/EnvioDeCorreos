using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CapaData;
using CapaEntidad;
using DevExpress.XtraEditors.Repository;
using Microsoft.Office.Interop.Outlook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ModEnvioCorreo
{
    public partial class WfEnvioAut : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtUsuariosManual = new DataTable();

        public WfEnvioAut()
        {
            InitializeComponent();
        }

        private void WfEnvioAut_Load(object sender, EventArgs e)
        {
            CargarComboCompania();
            CargarCajasTextos();
            CargarComboDia();
            CargarGrillaEnviosAut();
            CargarGrillaListaReportes();
            CargarComboGrilla();
        }

        public void CargarComboCompania()
        {
            CDCompania c = new CDCompania();
            DataTable dts;
            dts = c.AllCompanias();
            cboCompania.DataSource = dts ;
            cboCompania.DisplayMember = "c_Nombres";
            cboCompania.ValueMember = "c_Compania";
        }

        public void CargarCajasTextos()
        {
            txtFechaAut.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            txtPeriodo.Text = DateTime.Now.ToString("yyyy-MM");
            dtFechaManual.Text = DateTime.Now.ToShortDateString();
            dtFechaEnvI.Text = DateTime.Now.ToShortDateString();
            dtFechaEnvF.Text = DateTime.Now.ToShortDateString();
            dtHoraManual.Text = DateTime.Now.ToString("hh:mm p");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            CargarGrillaDiaEnvios();
        }

        private void chkEnvioAutAct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnvioAutAct.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        
        private void dtFechaManual_EditValueChanged(object sender, EventArgs e)
        {
            txtPeriodo.Text = dtFechaManual.Text.Substring(6, 4) + "-" + dtFechaManual.Text.Substring(3, 2);
        }

        public void CargarComboDia()
        {
            KeyValuePair<string, string> listValue1 = new KeyValuePair<string, string>("Lunes", "1LU");
            KeyValuePair<string, string> listValue2 = new KeyValuePair<string, string>("Martes", "2MA");
            KeyValuePair<string, string> listValue3 = new KeyValuePair<string, string>("Miercoles", "3MI");
            KeyValuePair<string, string> listValue4 = new KeyValuePair<string, string>("Jueves", "4JU");
            KeyValuePair<string, string> listValue5 = new KeyValuePair<string, string>("Virnes", "5VI");
            KeyValuePair<string, string> listValue6 = new KeyValuePair<string, string>("Sabado", "6SA");
            KeyValuePair<string, string> listValue7 = new KeyValuePair<string, string>("Domingo", "7DO");
            cboDia.Items.Add(listValue1);
            cboDia.Items.Add(listValue2);
            cboDia.Items.Add(listValue3);
            cboDia.Items.Add(listValue4);
            cboDia.Items.Add(listValue5);
            cboDia.Items.Add(listValue6);
            cboDia.Items.Add(listValue7);
            cboDia.DisplayMember = "Key";
            cboDia.ValueMember = "Value";
        }

        public void CargarGrillaEnviosAut()
        {
            CDEnviosAut env = new CDEnviosAut();
            DateTime dt_FEnvioIni;
            DateTime dt_FEnvioFin;
            if (chkFechaEnvio.Checked == true)
            {
                dt_FEnvioIni = Convert.ToDateTime(dtFechaEnvI.Text + " 00:00:00");
                dt_FEnvioFin = Convert.ToDateTime(dtFechaEnvF.Text + " 23:59:59");
            }
            else
            {
                dt_FEnvioIni = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy") + " 00:00:00");
                dt_FEnvioFin = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy") + " 23:59:59");
            }
            
            string ls_comp ;
            ls_comp = cboCompania.SelectedValue.ToString() ;
            gvEnviosRealizados.DataSource = env.EnviosRealizados(ls_comp, dt_FEnvioIni, dt_FEnvioFin);

          
        }

        private void TabRep_Click(object sender, EventArgs e)
        {
        }

        private void btnRefreshGridEnvios_Click(object sender, EventArgs e)
        {
            CargarGrillaEnviosAut();
        }

        public void CargarGrillaDiaEnvios()
        {
            string ls_comp, ls_sDia = "";
            ls_comp = cboCompania.SelectedValue.ToString();
            CDEnviosAut env = new CDEnviosAut();

            if (chkEnvioAutAct.Checked == true)
            {
                DateTime dt_fechaDia = Convert.ToDateTime(txtFechaAut.Text);
                int nDia = (int)dt_fechaDia.DayOfWeek;

                switch (nDia)
                {
                    case 1:
                        ls_sDia = "1LU";
                        break;
                    case 2:
                        ls_sDia = "2MA";
                        break;
                    case 3:
                        ls_sDia = "3MI";
                        break;
                    case 4:
                        ls_sDia = "4JU";
                        break;
                    case 5:
                        ls_sDia = "5VI";
                        break;
                    case 6:
                        ls_sDia = "6SA";
                        break;
                    case 7:
                        ls_sDia = "7DO";
                        break;
                }
            }
            else
            {
                ls_sDia = cboDia.SelectedValue.ToString() ;
            }

            //Envios Dias
            gvEnviosDelDia.DataSource = env.DiasEnvios(ls_comp, ls_sDia);
            gridColumn7.Group();
            gridView2.ExpandAllGroups();

            //Envios Horas 
            string ls_hora;
            ls_hora = txtHora.Text;
            gvEnivosHoras.DataSource = env.HorasEnvios(ls_comp, ls_sDia, ls_hora);


            if (gridView3.RowCount > 0)
            {
                string coReporte = "", CodUsuario = "", Correo ="";

                for (int i = 0; i < gridView3.RowCount; i++)
                {
                    CDEnviosAut envioc = new CDEnviosAut();
                    coReporte = gridView3.GetRowCellValue(i, "c_reporteenvio").ToString();
                    CodUsuario = gridView3.GetRowCellValue(i, "c_usuarioenvio").ToString();
                    Correo = envioc.getCorreoUsuario(CodUsuario);


                    switch (coReporte)
                    {
                        case "28":
                            Funct_EvnRepCumpleHTML(Correo);
                            break;
                    }



                }

            }
        }

        
        public void CargarGrillaListaReportes()
        {
            CDEnviosAut env = new CDEnviosAut();
            gvListaReportes.DataSource = env.ListaReporte(cboCompania.SelectedValue.ToString());
        }

        public void CargarComboGrilla()
        {
            CDEnviosAut env = new CDEnviosAut();
            List<CEUsuario> list = env.ListaUsuariosEnvio();
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            myLookup.DisplayMember = "Nombre";
            myLookup.ValueMember = "CodUsuario";
            myLookup.DataSource = list;
            gridView6.Columns["c_nombre"].ColumnEdit = myLookup;
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string ls_codrep;
            CDEnviosAut env = new CDEnviosAut();

            ls_codrep = gridView4.GetDataRow(e.FocusedRowHandle)["c_reporteenvio"].ToString();
            gvListaUsuariosRep.DataSource = env.ListaUsuariosxReporte(cboCompania.SelectedValue.ToString(), ls_codrep, 1); 
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            if (dtUsuariosManual.Rows.Count <= 0)
            {
                dtUsuariosManual.Clear();
                dtUsuariosManual.Columns.Add("c_nombre");
                dtUsuariosManual.Columns.Add("c_cod");
                DataRow _ravi = dtUsuariosManual.NewRow();
                _ravi["c_nombre"] = "";
                _ravi["c_cod"] = "";
                dtUsuariosManual.Rows.Add(_ravi);
            }
            else if (dtUsuariosManual.Rows.Count > 0)
            {
                DataRow _ravi = dtUsuariosManual.NewRow();
                _ravi["c_nombre"] = "";
                _ravi["c_cod"] = "";
                dtUsuariosManual.Rows.Add(_ravi);
            }

            gvUsuariosManual.DataSource = dtUsuariosManual;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = gridView6.FocusedRowHandle;
            gridView6.DeleteRow(row);
        }

        private void gridView6_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void gridView6_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string ls_value;
            ls_value = e.Value.ToString();
            //ls_value = ls_value;

            if (dtUsuariosManual.Rows.Count > 0)
            {
                string ls_valuedt = "";

                for (int i = 0; i < dtUsuariosManual.Rows.Count; i++)
                {
                    ls_valuedt = dtUsuariosManual.Rows[i]["c_nombre"].ToString();

                    if (ls_valuedt == ls_value)
                    {
                        MessageBox.Show("No se puede agregar dos veces el mismo usuario, revisar por favor.", "Aviso");
                        gridView6.DeleteRow(e.RowHandle);
                    }
                }
            }
        }

        private void btnModificarReporte_Click(object sender, EventArgs e)
        {
            if (chkEnvioAutAct.Checked == true)
            {
                MessageBox.Show("Para modificar primero debe deneter el envio automatico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int row = gridView4.FocusedRowHandle;
            string codRep, descripcionRep, undNego , tipodata;
            bool estado,envioxusu;

            codRep = gridView4.GetRowCellValue(row, "c_reporteenvio").ToString();
            descripcionRep = gridView4.GetRowCellValue(row, "c_descripcion").ToString();
            undNego = gridView4.GetRowCellValue(row, "c_unidadnegocio").ToString();
            tipodata = gridView4.GetRowCellValue(row, "c_tipodata").ToString();
            estado = Convert.ToBoolean(gridView4.GetRowCellValue(row, "c_estado"));
            envioxusu = Convert.ToBoolean(gridView4.GetRowCellValue(row, "c_flagenvxusu"));
            wf_actReporteEnvio wfact = new wf_actReporteEnvio();
            wfact.txtCod.Text = codRep;
            wfact.txtDescripcion.Text = descripcionRep;
            wfact.undNegocio = undNego;
            wfact.tipodata = tipodata;
            wfact.estado = estado;
            wfact.Xusuario = envioxusu;
            wfact.comp = cboCompania.SelectedValue.ToString() ;
            wfact.ShowDialog();
        }

        private void btnEnvioManual_Click(object sender, EventArgs e)
        {
            int row = -1;
            string codReporte = "";
            bool EnvioXusu= false;

            

            if (chkEnvioAutAct.Checked == true)
            {
                MessageBox.Show("Primero desactive el envio automatico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabRep.SelectedTabPageIndex = 1;
                return;
            }


            if (txtPeriodo.Text.Substring(0, 4) != dtFechaManual.Text.ToString().Substring(6, 4) || txtPeriodo.Text.Substring(5, 2) != dtFechaManual.Text.ToString().Substring(3, 2))
            {
                MessageBox.Show("La fecha no coincide con  el periodo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabRep.SelectedTabPageIndex = 1;
                return;
            }

            DialogResult result = MessageBox.Show("¿Esta seguro que quiere realizar el envio manual de correos a los usuarios?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {/**/

                return;

            }


            row = gridView4.FocusedRowHandle;

            if (row < 0)
            {
                MessageBox.Show("Debe seleccionar un reporte a enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabRep.SelectedTabPageIndex = 1;
                return;

            }

            if (gridView6.RowCount <= 0)
            {
                MessageBox.Show("Debe ingresar al menos un usuario de envio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabRep.SelectedTabPageIndex = 1;
                return;
            }

            if (VerificarUsuariosManuales() == false)
            {
                MessageBox.Show("Existen usuario(s) que no ingresaron de forma correcta, verfique por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabRep.SelectedTabPageIndex = 1;
                return;

            }

            codReporte =  gridView4.GetRowCellValue(row, "c_reporteenvio").ToString();
            EnvioXusu = Convert.ToBoolean(gridView4.GetRowCellValue(row, "c_flagenvxusu"));
            

            // Seleccionando Reporte //
            switch (codReporte)
            {
                case "28" :
                    string codUsuario = ""; string Correo="" ;
                    for (int i = 0; i < gridView6.RowCount; i++)
                    {
                        CDEnviosAut ev = new CDEnviosAut();
                        codUsuario = gridView6.GetRowCellValue(i, "c_nombre").ToString(); ;
                        Correo = ev.getCorreoUsuario(codUsuario);
                        Funct_EvnRepCumpleHTML(Correo);
                    }
                       
                    break;
            }

           
         
        }




        public bool VerificarUsuariosManuales()
        {
            bool result = false;
            string valNombre = "";
           

            if (gridView6.RowCount > 0)
            {

                for (int i = 0; i < gridView6.RowCount; i++)
                {
                    valNombre = gridView6.GetRowCellValue(i, "c_nombre").ToString();

                    if (valNombre == "")
                    {
                        result = false;

                        return false;
                    }

                    else
                    {
                        result = true;
                    }

                }

            }


            return result;

        }

        public void Funct_EvnRepCumpleHTML(string correo)
        {
            CDEnviosAut env = new CDEnviosAut();
            int unicode = 0022;
            char character = (char)unicode;

            string BodyHtml = "", msjResult = "Envio de correos se realizó en forma exitosa.";
            BodyHtml = BoDyForHtmlMail();

             if (BodyHtml=="NODATA")
             {
                 return;
             }

            try
            {
                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();
                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                // Set HTMLBody. 
                //add the body of the email
                // string msHTML = "<button type=" + comillas + "button" + comillas + "class=" + comillas + "btn btn-primary" + comillas + ">Prueba</button>";
                string msHTML = "";
                msHTML = GetHeaderOrFoodHtml("H") + BodyHtml + GetHeaderOrFoodHtml("F");

                oMsg.BodyFormat = OlBodyFormat.olFormatHTML;
                oMsg.HTMLBody = msHTML;
                oMsg.Save();
              
                String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //now attached the file
                Outlook.Attachment oAttach = oMsg.Attachments.Add( Constanst.RutaFotosHtml+"img4.jpg", iAttachType, iPosition, sDisplayName);
                Outlook.Attachment oAttach2 = oMsg.Attachments.Add(Constanst.RutaFotosHtml + "img1.png", iAttachType, iPosition, sDisplayName);
                Outlook.Attachment oAttach3 = oMsg.Attachments.Add(Constanst.RutaFotosHtml + "img2.png", iAttachType, iPosition, sDisplayName);
                Outlook.Attachment oAttach4 = oMsg.Attachments.Add(Constanst.RutaFotosHtml + "img3.png", iAttachType, iPosition, sDisplayName);
                Outlook.Attachment oAttach5 = oMsg.Attachments.Add(Constanst.RutaFotosHtml + "pie.jpg", iAttachType, iPosition, sDisplayName);
                //Subject line
                oMsg.Subject = GetFechaTexto()+ "-" + cboCompania.Text;//Asunto
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(correo);
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (System.Exception ex)
            {
               
                msjResult = "Hubo errores en el envio de correos, revisar por favor.";
               
            }//end of catch

            string resmsjdb = env.InsertarEjecucionEnvio(cboCompania.SelectedValue.ToString(), DateTime.Now, msjResult, Constanst.UsuarioSist, DateTime.Now);

            if (resmsjdb == "OK")
            {
                MessageBox.Show("Se realizó el envio de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//end of Email Method

        public string GetHeaderOrFoodHtml(string tipoCadena)
        { 
            string style = "", sFechaTexto;
            sFechaTexto = GetFechaTexto();
            //style = GetCssStyle();

            string resultHtml = "";
            if (tipoCadena == "H")
            { 
                //string comillas = (Convert.ToChar(34)).ToString();
               

                resultHtml = "<!DOCTYPE html> " +
                             "<html lang='en'>" +
                             "<head>" +
                             "<title>Bootstrap Example</title>" +
                             "<style>" +
                            // GetCssStyle()+
                             "</style>" +
                             "<meta charset='utf-8'>" +
                             "</head>" +
                             "<body   style ='width:500px' >" +
                             "<div style=' width:600px ; height:100%;'> " +
                             "<div style=' width:50% ; height:50px;'> " +
                           
                             "<img  height='50px' width='600px' src='cid:img4.jpg'/>" +
                             "</div>" +

                           " <div>"+
                                "<table style='width:500px' >"+
                                    "<tr>"+
                                        "<th> <img  src='cid:img3.png'  width='100px'  /> </th>" +
                                        "<th> <img  src='cid:img1.png'   width='350px' style='margin-left:15px'  /> </th>" +
                                        "<th> <img  src='cid:img2.png'  width='150px' style='margin-left:15px'  /> </th>" +
                                    "</tr>"+
                               " </table>"+
                            "</div>"+

                             "<div  style='background-color:red;height:50px; width:100%;color:white;font:bold;font-size:35px;font-family:Cambria;font-style:italic;text-align:center;border-style: solid;border-width:1px'>" +
                             GetFechaTexto()+
                             "</div>";
            }

            if (tipoCadena == "F")
            {
                resultHtml = "</div></body></html>";
            }

            return resultHtml;
        }

        public string GetFechaTexto()
        {
            string result = "", ls_NomDia, ls_NomMes;
            DateTime ldt_Fecha;

            if (chkEnvioAutAct.Checked == true)
            {
                ldt_Fecha = Convert.ToDateTime(txtFechaAut.Text);

            }

            else
            {
                ldt_Fecha = Convert.ToDateTime(dtFechaManual.Text);
            }

            ls_NomDia = ldt_Fecha.ToString("dddd");
            ls_NomMes = ldt_Fecha.ToString("MMMMMMMMMMMMMMMM");

            result = "¡FELIZ CUMPLEAÑOS! " + ls_NomDia + " " + Convert.ToString(ldt_Fecha.Day) + " DE " + ls_NomMes + " DEL " + Convert.ToString(ldt_Fecha.Year);

            result = result.ToUpper();

            return result;

        }

        public string BoDyForHtmlMail()
        {
            string result = "" , sHeaderFields ="" , sbody ="", sPieImg="";
            DateTime ldt_Fecha;

            if (chkEnvioAutAct.Checked == true)
            {
                ldt_Fecha = Convert.ToDateTime(txtFechaAut.Text);
            }
            else
            {
                ldt_Fecha = Convert.ToDateTime(dtFechaManual.Text);
            }

            CDReporteData rpt = new CDReporteData();

            DataTable dtHtml = rpt.DataRepCumple(cboCompania.SelectedValue.ToString(), ldt_Fecha, Constanst.UsuarioSist);

            if (dtHtml == null || dtHtml.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontro datos para enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            if (dtHtml.Rows.Count > 1 && dtHtml.Columns.Count > 1)
            {
                string sFlag = "",sNombreCompleto , sArea, sFechaText;
                sHeaderFields = "<br />" +
                                "<div>" +
                                "<table style= 'width:100%;border-collapse: collapse;' >" +
                                "<tr  >" +
                                     "<th style='color:white;background-color:red;font-family:Cambria;width:100px; font-size:15px;border-style: solid;border-width:1px'  > DIA </th>" +
                                     "<th style='color:white;background-color:red;font-family:Cambria;width:300px;font-size:15px;border-style: solid;border-width:1px'> NOMBRE COMPLETO </th>" +
                                    " <th style='color:white;background-color:red;font-family:Cambria;width:300px;font-size:15px;border-style: solid;border-width:1px'> AREA </th>" +
                              " </tr>";
                for (int i = 0; i < dtHtml.Rows.Count; i++)
                {
                    sFlag = dtHtml.Rows[i]["c_flag"].ToString().Substring(8, 1);
                    sNombreCompleto = dtHtml.Rows[i]["c_empleado"].ToString();
                    sArea = dtHtml.Rows[i]["c_area"].ToString();
                    sFechaText = dtHtml.Rows[i]["c_dia"].ToString();

                    if (sFlag == "A")
                    {
                        sbody = sbody + "<tr>" +
                                "<td colspan='3' style ='color:red;font-size:20px;font-family:Cambria;font-weight:bold;font-style:italic;padding-top:5px;padding-bottom:5px' >" + sFechaText + "</td>" +
                                "</tr>";
                    }
                    else if (sFlag == "B")
                    {

                        sbody = sbody + "<tr>" +
                             "<td> </td>"+
                               "<td style = 'border: 1px solid black;font-weight:bold;font-style:italic' >" + sNombreCompleto + "</td>" +
                               "<td  style = 'border: 1px solid black;font-weight:bold;font-style:italic'  >" + sArea + "</td>" +
                               "</tr>";
                    }

                   
                }
                sPieImg = "<tr>" +
                             "<td> </td>" +
                             "<td style='text-align:right' > <img  src='cid:pie.jpg'  /> </td>" +
                             "<td> </td>"+
                          "</tr>";



                

            }


            result = sHeaderFields + sbody + sPieImg+ "</table></div>";
            result = result + 
                "<div style = 'width:100%;background-color:red;color:red; height:30px;margin-top:20px;border-style: solid;border-width:1px' >....</div>";


            if (dtHtml.Rows.Count == 1 && dtHtml.Columns.Count == 1)
            {
                result = "NODATA";
            }

            return result;
        }

        public string GetCssStyle()
        {
            string text;
            var fileStream = new FileStream(Constanst.DirectorioCss, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            
            return text;
        }
    }
}