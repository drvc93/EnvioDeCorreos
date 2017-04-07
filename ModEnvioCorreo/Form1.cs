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
    }
}
