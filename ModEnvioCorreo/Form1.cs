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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WfCorreoHTML wfe = new WfCorreoHTML();
            wfe.MdiParent = this;
            wfe.Show();
        }
    }
}
