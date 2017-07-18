using System;
<<<<<<< HEAD
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaData;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using Microsoft.Office.Interop.Outlook;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Collections.Generic;
using CapaEntidad;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> origin/master

namespace ModEnvioCorreo
{
    public partial class WfCorreoHTML : Form
    {
<<<<<<< HEAD
        int starindexHtml = 0;
        List<string> lisAdj = new List<string>();
        DataTable dtFiles;
        Conexion conex = new Conexion();
        string rutaHtml = "";
        public string UsurioGeneral;

        public WfCorreoHTML()
        {
            InitializeComponent();
            LoadComboTipo();
            rutaHtml = conex.GetCredenciales("RUTAHTML");
        }

        private void xtraTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            // int  tab = 0 ;
            if (xtraTabControl1.SelectedTabPageIndex == 2) 
            {
                webBrowser1.DocumentText = richEditControl1.Text;
                ;
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                webBrowser1.DocumentText = richEditControl1.HtmlText;
                barDockControlTop.Enabled = false;
            }

            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                webBrowser1.DocumentText = richEditControl1.HtmlText;
                barDockControlTop.Enabled = true;
            }
            else 
            {
                barDockControlTop.Enabled = false;
            }
        }

        public void CargarComboCompania()
        {
            CDCompania c = new CDCompania();
            DataTable dts;
            dts = c.AllCompanias();
            cboCompania.DataSource = dts;
            cboCompania.DisplayMember = "c_Nombres";
            cboCompania.ValueMember = "c_Compania";
        }

        public void LoadComboTipo()
        { 
            cboTipoCliente.DisplayMember = "Text";
            cboTipoCliente.ValueMember = "Value";
            var items = new[]
            {
                new { Text = "Lista de Clientes", Value = "LC" },
                new { Text = "Otros", Value = "OT" },
            };

            cboTipoCliente.DataSource = items;
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoCliente.SelectedValue.ToString())
            { 
                case "LC" :
                    cboCompania.Enabled = true;
                    CargarComboCompania();
                    btnCaragar.Enabled = true;
                    break;
                case "OT" :
                    cboCompania.Enabled = false;
                    btnCaragar.Enabled = false;
                    break;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo delimitado por tabulaciones (*.txt)|";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string fileextension = openFileDialog1.SafeFileName;
                if (fileextension.IndexOf(".txt") < 0)
                { 
                    XtraMessageBox.Show("El formato del archivo debe ser .txt ", "Aviso", MessageBoxButtons.OK);
                }
                try
                {
                    ImportarExcel(file); 
                }
                catch (IOException oe)
                {
                    XtraMessageBox.Show("Error : " + oe.Message, "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        public void ImportarExcel(string filepath) 
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("n_persona", typeof(int)));
            dt.Columns.Add(new DataColumn("c_nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("c_correo", typeof(string)));
            //dt.Columns.Add(new DataColumn("c_enviado", typeof(bool)));

            var lines = File.ReadAllLines(@filepath);
            foreach (string line in lines)
                dt.Rows.Add(line.Split('\t'));

            dt.Columns.Add(new DataColumn("c_enviado", typeof(bool)));
            gvClientes.DataSource = dt;
        }

        private void btnEnviarMailHmtl_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAsunto.Text))
            {
                XtraMessageBox.Show("DEBE INGRESAR UN ASUNTO PARA EL CORREO", "Aviso", MessageBoxButtons.OK);
                return;
            }

            if (gridviewClientes.RowCount <= 0)
            {
                XtraMessageBox.Show("No se encontro clientes  para enviar.", "Aviso", MessageBoxButtons.OK);
                return;
            }
            // ProgressBarControl progressBar = new ProgressBarControl();
            //ReflectorBar reflectorBar = new ReflectorBar(progressBar);
            //this.Controls.Add(progressBar);

            int count = 0;
            count = gridviewClientes.RowCount;
            string sCorreo = "" ;
            string SresultSend = "";
            string sRazonSocial = "";

            if (count > 0)
            {
                // marqueeProgressBarControl1.Visible = true;
                // progressPanel1.Visible = true;
                for (int i = 0; i < count; i++)
                {
                    sCorreo = gridviewClientes.GetRowCellValue(i, "c_correo").ToString();
                    sRazonSocial = gridviewClientes.GetRowCellValue(i, "c_nombre").ToString(); 
                    SresultSend = EnviarCorreoHTML(sCorreo, sRazonSocial);
                    if (SresultSend == "OK") 
                    {
                        gridviewClientes.SetRowCellValue(i, "c_enviado", 1);                      
                    }
                }
            }
            // progressPanel1.Visible = false;
            lisAdj.Clear();
            // marqueeProgressBarControl1.Visible = false;
        }

        public string EnviarCorreoHTML(string correo, string sRazonSoc)
        {
            CDEnviosAut env = new CDEnviosAut();
            string msjResult = "Envio de correos se realizó en forma exitosa.";
            string HTMLFinal = "";
            string adjName = "", adjUbicacion = "";
            try
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("OUTLOOK");

                int collCount = processes.Length;

                Microsoft.Office.Interop.Outlook.Application oApp;

                if (collCount != 0)
                {
                    // Capturar instancia de outlook
                    oApp = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                }
                else
                {
                    oApp = new Microsoft.Office.Interop.Outlook.Application();
                }
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                Outlook.Inspector oInspector = oMsg.GetInspector;

                oMsg.BodyFormat = OlBodyFormat.olFormatHTML;
                HTMLFinal = GetHTMLFinal();
                if (HTMLFinal.IndexOf("(*)") > 0)
                {
                    HTMLFinal = HTMLFinal.Replace("(*)", sRazonSoc);
                }
                oMsg.HTMLBody = HTMLFinal;
                oMsg.Save();
                if (lisAdj != null)
                {
                    for (int i = 0; i < lisAdj.Count; i++)
                    {
                        int iPosition = (int)oMsg.Body.Length + 1;
                        int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                        Outlook.Attachment oAttach4 = oMsg.Attachments.Add(@rutaHtml + lisAdj.ElementAt(i), iAttachType, iPosition, lisAdj.ElementAt(i));
                    }

                    for (int i = 0; i < dtFiles.Rows.Count; i++)
                    {
                        int iPosition = (int)oMsg.Body.Length + 1;
                        int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                        adjName = gridviewArchivos.GetRowCellValue(i, "c_nombrearchivo").ToString();
                        adjUbicacion = gridviewArchivos.GetRowCellValue(i, "c_ubicacion").ToString(); 
                        Outlook.Attachment oAttach4 = oMsg.Attachments.Add(@adjUbicacion, iAttachType, iPosition, adjName);
                    }
                }

                oMsg.Subject = txtAsunto.Text.Trim().ToUpper();

                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;

                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(correo);
                oRecip.Resolve();

                oMsg.Send();

                msjResult = "OK";

                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }
            catch (System.Exception ex)
            {
                return "ERROR";
            }
            lisAdj.Clear();
            return msjResult;
        }

        private void insertPictureItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        public Image GetImageFromPath(string imgpath)
        {
            Bitmap bm = new Bitmap(@"D:\Paisaje.jpg");
            Image res = (Image)bm;
            return res;
        }

        public string GetBase64FromImg(string path)
        {
            string imgBase64;
            
            Bitmap b = new Bitmap(@"D:\Paisaje.jpg");
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            imgBase64 = Convert.ToBase64String(byteImage);

            return imgBase64;
        }

        public void Base64ToImage(string base64String, string namefile)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            ///  string namefile = DateTime.Now.ToString("ddMMyyyyhhMMss");
            string rutacompleta = @rutaHtml + namefile + ".jpg";
            image.Save(@rutacompleta, ImageFormat.Jpeg);
            lisAdj.Add(namefile + ".jpg");
            //return image;
        }

        private void btnImageHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        public string GetHTMLFinal()
        {
            int nIni = 0 , nFin = 0;
            string html = "";
            html = richEditControl1.HtmlText;
            char character = (char)34;
            int n_count = 0;

            while (html.IndexOf("data:image/jpeg;base64,", starindexHtml) > 0)
            {
                n_count = n_count + 1;
                nIni = html.IndexOf("data:image/jpeg;base64,", starindexHtml) + 23;
                nFin = html.IndexOf(character, nIni);
                string base64 = html.Substring(nIni, (nFin - nIni));
                string namefile = DateTime.Now.ToString("ddMMyyyyhhMMss") + n_count.ToString();
                html = html.Replace("data:image/jpeg;base64," + base64, "cid:" + namefile + ".jpg");
                Base64ToImage(base64, namefile);
            }
            return html;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (richEditControl1.Options.VerticalRuler.Visibility == DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden)
            {
                richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Visible;
                richEditControl1.Options.HorizontalRuler.Visibility = richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Visible;
            }
            else
            {
                richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
                richEditControl1.Options.HorizontalRuler.Visibility = richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            }
        }

        private void btnCaragar_Click(object sender, EventArgs e)
        {
            CDCliente clinte = new CDCliente();
            DataTable dt = clinte.MailClientes(cboCompania.SelectedValue.ToString());
            gvClientes.DataSource = dt;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (gridviewClientes.RowCount <= 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("n_persona", typeof(int)));
                dt.Columns.Add(new DataColumn("c_nombre", typeof(string)));
                dt.Columns.Add(new DataColumn("c_correo", typeof(string)));
                dt.Columns.Add(new DataColumn("c_enviado", typeof(bool)));

                DataRow row = dt.NewRow();
                row["n_persona"] = 0;
                row["c_nombre"] = "";
                row["c_correo"] = "";
                row["c_enviado"] = 0;
                dt.Rows.Add(row);

                gvClientes.DataSource = dt;
            }
            else
            {
                gridviewClientes.AddNewRow();
            }
        }

        private void btnInsertarFile_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogoFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string fullPath = DialogoFile.InitialDirectory + DialogoFile.FileName;
                string filename = DialogoFile.SafeFileName;
                try
                {
                    FillDataTableArchivos(fullPath, filename);
                }
                catch (IOException oe)
                {
                    XtraMessageBox.Show("Error : " + oe.Message, "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public void FillDataTableArchivos(string fullPath, string fileName) 
        {
            FileInfo f = new FileInfo(fullPath);
            decimal filesize = Math.Round(Convert.ToDecimal(f.Length) / 1048576, 2);

            if (dtFiles == null || dtFiles.Rows.Count <= 0) 
            {
                dtFiles = new DataTable();
                dtFiles.Columns.Add(new DataColumn("c_ubicacion", typeof(string)));
                dtFiles.Columns.Add(new DataColumn("c_nombrearchivo", typeof(string)));
                dtFiles.Columns.Add(new DataColumn("c_peso", typeof(string)));          
            }
            DataRow row = dtFiles.NewRow();
            row["c_ubicacion"] = fullPath;
            row["c_nombrearchivo"] = fileName;
            row["c_peso"] = filesize.ToString() + " Mb";
            dtFiles.Rows.Add(row);

            gvArchivos.DataSource = dtFiles;
        }

        private void btnEliminarFile_Click(object sender, EventArgs e)
        {
            if (dtFiles != null && dtFiles.Rows.Count > 0)
            {
                int rowsel = gridviewArchivos.FocusedRowHandle;
                dtFiles.Rows[rowsel].Delete();
            }
            else if (dtFiles == null && dtFiles.Rows.Count <= 0)
            {
                XtraMessageBox.Show("No se encontro registros a eliminar.", "Aviso", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridviewClientes.RowCount > 0)
            {
                int row = gridviewClientes.FocusedRowHandle;
                gridviewClientes.DeleteRow(row);
            }
            else if (gridviewClientes.RowCount <= 0)
            {
                XtraMessageBox.Show("No se encontro clinetes  para  eliminar.", "Aviso", MessageBoxButtons.OK);
                return;
            }
        }

        public void Accesos(string usuairio)
        {
            CDAccesos ac = new CDAccesos();
            List<CEAcceso> list = new List<CEAcceso>();
            list = ac.AccesosXUsuario(usuairio, "EA");
            string niveles = "", acceso = "";

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    niveles = list.ElementAt(i).Niveles;
                    acceso = list.ElementAt(i).Acceso;

                    switch (niveles)
                    {
                        case "0102010000":
                            btnEnviarMailHmtl.Enabled = true;
                            break;
                    }
                }
            }
        }
    }
}
=======
        public WfCorreoHTML()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> origin/master
