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
using DevExpress.XtraEditors.Controls;
using CapaData;
using CapaEntidad;
using DevExpress.XtraEditors.Repository;

namespace ModEnvioCorreo
{
    public partial class wf_actReporteEnvio : DevExpress.XtraEditors.XtraForm
    {
        public string codReporte;
        public string descripcionRep;
        public string comp;
        public string undNegocio;
        public string tipodata;
        public bool estado;
        private DataTable dtReportes;

        public wf_actReporteEnvio()
        {
            InitializeComponent();
            
        }
            
        private void wf_actReporteEnvio_Load(object sender, EventArgs e)
        {
            CargarComboTipoData();
            CargarComboUndNegocio();
            cboUndNeg.SelectedValue = undNegocio;
            CargarGrillaReportes();
            ComboGrillaUsuario();
            ComboGrillaDia();
            chkEstado.Checked = estado;
            
        }

        public void CargarComboTipoData (){

            cboTipoData.DisplayMember = "Text";
            cboTipoData.ValueMember = "Value";
            var items = new[] { 
             new { Text = "Excell ASCII", Value = "AS" }, 
             new { Text = "Excell DATA", Value = "EX" }, 
             new { Text = "Excell PROPIO", Value = "PO" },
             new { Text = "PLANTILLA WEB", Value = "WB" },
           
             };

            cboTipoData.DataSource = items;
            cboTipoData.SelectedValue = tipodata;
        }

        public void CargarComboUndNegocio()
        {

            CDUnidadNegocio und = new CDUnidadNegocio();
            cboUndNeg.DataSource = und.UnidadNegocioxCia(comp);
            cboUndNeg.ValueMember = "c_unidadnegocio";
            cboUndNeg.DisplayMember = "c_descripcion";
            

   
        }

        public void ComboGrillaUsuario()
        {
            CDEnviosAut env = new CDEnviosAut();
            List<CEUsuario> list = env.ListaUsuariosEnvio();
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            myLookup.DisplayMember = "Nombre";
            myLookup.ValueMember = "CodUsuario";
            myLookup.DataSource = list;
            gridView1.Columns["c_usuarioenvio"].ColumnEdit = myLookup;
        }

        public void ComboGrillaDia()
        {
            CEDiaRepAuto c1 = new CEDiaRepAuto("1LU", "LUNES");
            CEDiaRepAuto c2 = new CEDiaRepAuto("2MA", "MARTES");
            CEDiaRepAuto c3 = new CEDiaRepAuto("3MI", "MIERCOLES");
            CEDiaRepAuto c4 = new CEDiaRepAuto("4JU", "JUEVES");
            CEDiaRepAuto c5 = new CEDiaRepAuto("5VI", "VIERNES");
            CEDiaRepAuto c6 = new CEDiaRepAuto("6SA", "SABADO");
            CEDiaRepAuto c7 = new CEDiaRepAuto("7DO", "DOMINGO");


            List<CEDiaRepAuto> lst = new List<CEDiaRepAuto>();
            lst.Add(c1);
            lst.Add(c2);
            lst.Add(c3);
            lst.Add(c4);
            lst.Add(c5);
            lst.Add(c6);
            lst.Add(c7);
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            myLookup.DisplayMember = "Dia";
            myLookup.ValueMember = "CodDia";
            myLookup.DataSource = lst;
            gridView1.Columns["c_dia"].ColumnEdit = myLookup;
        }

        public void CargarGrillaReportes()
        {
            CDEnviosAut env = new CDEnviosAut();
            dtReportes =  env.ListaUsuariosxReporte(comp, txtCod.Text, 2);
            gvListaUsuarios.DataSource = dtReportes;
        }

        private void btnInsertarUs_Click(object sender, EventArgs e)
        {   
           DataRow dr =  dtReportes.NewRow();
           dr[1] = codReporte;
           dr[2] = "";
           dr[6] = 1;
           dr[7] = "SISTCORREO";
           dr[8] = DateTime.Now.ToString();
           dr[9] ="N";
           dtReportes.Rows.Add(dr);
           dtReportes.AcceptChanges();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int row = e.RowHandle;
            gridView1.SetRowCellValue(row, "c_flagReg", "N");
        } 
    }
}