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
using CapaEntidad;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;


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
            gvEnviosDelDia.DataSource = env.DiasEnvios(ls_comp,ls_sDia);
            gridColumn7.Group();
            gridView2.ExpandAllGroups();

            //Envios Horas 
            string ls_hora;
            ls_hora = txtHora.Text.Substring(1, 5);
            gvEnivosHoras.DataSource = env.HorasEnvios(ls_comp, ls_sDia, ls_hora);
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
             gvListaUsuariosRep .DataSource = env.ListaUsuariosxReporte(cboCompania.SelectedValue.ToString(), ls_codrep,1); 

        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            
            if( dtUsuariosManual.Rows.Count  <= 0) {

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
            ls_value = ls_value;

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
                MessageBox.Show("Para modificar primero debe deneter el envio automatico.", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            int row = gridView4.FocusedRowHandle;
            string codRep, descripcionRep, undNego , tipodata;
            bool estado;
            

            codRep = gridView4.GetRowCellValue(row, "c_reporteenvio").ToString();
            descripcionRep = gridView4.GetRowCellValue(row, "c_descripcion").ToString();
            undNego = gridView4.GetRowCellValue(row, "c_unidadnegocio").ToString();
            tipodata = gridView4.GetRowCellValue(row, "c_tipodata").ToString();
            estado =  Convert.ToBoolean( gridView4.GetRowCellValue(row, "c_estado"));
            wf_actReporteEnvio wfact = new wf_actReporteEnvio();
            wfact.txtCod.Text = codRep;
            wfact.txtDescripcion.Text = descripcionRep;
            wfact.undNegocio = undNego;
            wfact.tipodata = tipodata;
            wfact.estado = estado;
            wfact.comp = cboCompania.SelectedValue.ToString() ;
            wfact.ShowDialog();


        }

       
    }
}