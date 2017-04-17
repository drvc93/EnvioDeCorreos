using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using CapaData;
using CapaEntidad;
using DevExpress.XtraEditors.Repository;

namespace ModEnvioCorreo
{
    public partial class wf_actReporteEnvio : DevExpress.XtraEditors.XtraForm
    {
        // private bool _inCellValueChanged = false;
        public string codReporte;
        public string descripcionRep;
        public string comp;
        public string undNegocio;
        public string tipodata;
        public bool estado;
        private DataTable dtReportes;
        public bool Xusuario;

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
            chkXUsuario.Checked = Xusuario;
        }

        public void CargarComboTipoData()
        {
            cboTipoData.DisplayMember = "Text";
            cboTipoData.ValueMember = "Value";
            var items = new[]
            {
                new { Text = "Excell ASCII", Value = "AS" },
                new { Text = "Excell DATA", Value = "EX" },
                new { Text = "Excell PROPIO", Value = "PO" },
                new { Text = "PLANTILLA HTML", Value = "HT" },
               
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
            dtReportes = env.ListaUsuariosxReporte(comp, txtCod.Text, 2);
            gvListaUsuarios.DataSource = dtReportes;
        }

        private void btnInsertarUs_Click(object sender, EventArgs e)
        { 
            DataRow dr = dtReportes.NewRow();
            dr[1] = codReporte;
            dr[2] = "";
            dr[6] = 1;
            dr[7] = "SISTCORREO";
            dr[8] = DateTime.Now.ToString();
            dr[9] = "N";
            dtReportes.Rows.Add(dr);
            dtReportes.AcceptChanges();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            

            string c_flagreg;
            int contUpdt = 0 ;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                c_flagreg = gridView1.GetRowCellValue(i, "c_flagReg").ToString() ;

                if (c_flagreg == "N")
                {
                    string result = "";
                    CERepEnvUsu repus = new CERepEnvUsu();
                    CDEnviosAut env = new CDEnviosAut();
                    repus.CCompania = comp;
                    repus.CDia = gridView1.GetRowCellValue(i, "c_dia").ToString();
                    repus.CUsuarioenvio = gridView1.GetRowCellValue(i, "c_usuarioenvio").ToString();
                    if (Convert.ToBoolean(gridView1.GetRowCellValue(i, "c_estado")) == true)
                    {
                        repus.CEstado = "A";
                    }
                    else
                    {
                        repus.CEstado = "I";
                    }

                    repus.CReporteenvio = txtCod.Text;
                    repus.CUltimousuario = Constanst.UsuarioSist;

                    if (string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "d_hora").ToString()) == true)
                    {
                        XtraMessageBox.Show("Falto Ingresar la hora", "Aviso", MessageBoxButtons.OK);
                        //MessageBox.Show("Falto Ingresar la hora", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.SelectRow(i);
                        gridView1.FocusedRowHandle = i;
                         
                        return;
                    }

                    repus.DHora = Convert.ToDateTime(gridView1.GetRowCellValue(i, "d_hora"));
                    repus.DUltimafechamodificacion = DateTime.Now;
                    result = env.UpdateInsertRepEnvioUs(repus);
                    if (result == "OK")
                    {
                        contUpdt = contUpdt + 1;
                    }
                }
            }

            if (contUpdt > 0)
            {
                XtraMessageBox.Show("Se actualizo correctamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // MessageBox.Show("Se actualizo correctamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int row = e.RowHandle;
           
            gridView1.SetRowCellValue(row, "c_flagReg", "N");
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string c_flagReg, resultDelete = "";
            int row = -1;

            row = gridView1.FocusedRowHandle;

            if (row < 0)
            {
                MessageBox.Show("Debe seleccionar un registro primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dgresult = MessageBox.Show("¿Esta seguro que desea eliminar el registro ?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dgresult == DialogResult.No || dgresult == DialogResult.Cancel)
            {
                return;
            }

            c_flagReg = gridView1.GetRowCellValue(row, "c_flagReg").ToString();
            if (c_flagReg == "S")
            {
                CERepEnvUsu repus = new CERepEnvUsu();
                CDEnviosAut env = new CDEnviosAut();
                repus.CCompania = comp;
                repus.CDia = gridView1.GetRowCellValue(row, "c_dia").ToString();
                repus.CUsuarioenvio = gridView1.GetRowCellValue(row, "c_usuarioenvio").ToString();
                repus.DHora = Convert.ToDateTime(gridView1.GetRowCellValue(row, "d_hora"));
                repus.CReporteenvio = txtCod.Text;

                resultDelete = env.DeleteRepEnvioUs(repus);

                if (resultDelete == "OK")
                {
                    MessageBox.Show("Se elimino el registro correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CargarGrillaReportes();
                }
            }
            else
            {
                gridView1.DeleteRow(row);
            }
        }

        private void gvListaUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}