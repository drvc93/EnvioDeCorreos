using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModEnvioCorreo
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string CodUsuario;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void barbtnModEnvios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            WfEnvioAut wfe = new WfEnvioAut();
            wfe.MdiParent = this;
            wfe.Show();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MaxmizedFromTray();
        }

        private void MaxmizedFromTray()
        {
           
           


        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            
        }

<<<<<<< HEAD
        private void btnItemMailHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WfCorreoHTML wfe = new WfCorreoHTML();
            wfe.MdiParent = this;
            ribbonControl1.Minimized = true;
            wfe.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            WfCorreoHTML wfe = new WfCorreoHTML();
            wfe.MdiParent = this;
            ribbonControl1.Minimized = true;
            wfe.UsurioGeneral = barStaticUser.Caption;
            wfe.Accesos(barStaticUser.Caption);
            wfe.Show();

        }

        public void NombreUsuario(string  usuario ) {

            CDUsuario us = new CDUsuario();
            barStaticNombre.Caption = us.NomreUsuario(usuario);
        }

        public void Accesos(string usuairio)
        {
            CDAccesos ac = new CDAccesos();
            List<CEAcceso> list = new List<CEAcceso>();
            list = ac.AccesosXUsuario(usuairio,"EA");
            string niveles = "", acceso = ""; 

            if (list.Count > 0) 
            {

                for (int i = 0; i < list.Count; i++)
                {
                    niveles = list.ElementAt(i).Niveles;
                    acceso = list.ElementAt(i).Acceso;
                    
                    switch (niveles) 
                    { 
                        case  "0101000000" :
                            barbtnModEnvios.Enabled = true;
                            break;
                        case "0102000000" :
                            barButtonItem1.Enabled = true;
                            break;
                    } 
                }
            
            }
        }
=======
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WfCorreoHTML wfe = new WfCorreoHTML();
            wfe.MdiParent = this;
            wfe.Show();
        }
>>>>>>> origin/master
    }
}
