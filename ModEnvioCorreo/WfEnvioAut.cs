using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaData;

namespace ModEnvioCorreo
{
    public partial class WfEnvioAut : DevExpress.XtraEditors.XtraForm
    {
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
            
        }

        public void CargarComboCompania()
        {
            CDCompania c = new CDCompania();
            DataTable dts;
            dts = c.AllCompanias();
            cboCompania.DataSource =dts ;
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

    }
}