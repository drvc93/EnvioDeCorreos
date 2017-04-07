namespace ModEnvioCorreo
{
    partial class WfEnvioAut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboCompania = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHora = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtFechaEnvF = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaEnvI = new DevExpress.XtraEditors.DateEdit();
            this.chkFechaEnvio = new System.Windows.Forms.CheckBox();
            this.txtFechaAut = new System.Windows.Forms.TextBox();
            this.chkEnvioAutAct = new System.Windows.Forms.CheckBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnEnvioManual = new DevExpress.XtraEditors.SimpleButton();
            this.dtHoraManual = new DevExpress.XtraEditors.TimeEdit();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.chkEnvioAtodo = new System.Windows.Forms.CheckBox();
            this.dtFechaManual = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.TabRep = new DevExpress.XtraTab.XtraTabControl();
            this.Tab1 = new DevExpress.XtraTab.XtraTabPage();
            this.gvEnviosRealizados = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tab2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnRefreshGridEnvios = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gvEnviosDelDia = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvRepEnviados = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvF.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraManual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaManual.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaManual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabRep)).BeginInit();
            this.TabRep.SuspendLayout();
            this.Tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnviosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnviosDelDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRepEnviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCompania
            // 
            this.cboCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompania.FormattingEnabled = true;
            this.cboCompania.Location = new System.Drawing.Point(62, 23);
            this.cboCompania.Name = "cboCompania";
            this.cboCompania.Size = new System.Drawing.Size(183, 21);
            this.cboCompania.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(14, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Compania";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Fecha";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(173, 50);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(71, 21);
            this.txtHora.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtFechaEnvF);
            this.groupControl1.Controls.Add(this.dtFechaEnvI);
            this.groupControl1.Controls.Add(this.chkFechaEnvio);
            this.groupControl1.Controls.Add(this.txtFechaAut);
            this.groupControl1.Controls.Add(this.chkEnvioAutAct);
            this.groupControl1.Controls.Add(this.cboCompania);
            this.groupControl1.Controls.Add(this.txtHora);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(321, 121);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Envio Automatico";
            // 
            // dtFechaEnvF
            // 
            this.dtFechaEnvF.EditValue = null;
            this.dtFechaEnvF.Location = new System.Drawing.Point(166, 96);
            this.dtFechaEnvF.Name = "dtFechaEnvF";
            this.dtFechaEnvF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEnvF.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEnvF.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtFechaEnvF.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaEnvF.Size = new System.Drawing.Size(79, 20);
            this.dtFechaEnvF.TabIndex = 13;
            // 
            // dtFechaEnvI
            // 
            this.dtFechaEnvI.EditValue = null;
            this.dtFechaEnvI.Location = new System.Drawing.Point(81, 96);
            this.dtFechaEnvI.Name = "dtFechaEnvI";
            this.dtFechaEnvI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEnvI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEnvI.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtFechaEnvI.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaEnvI.Size = new System.Drawing.Size(79, 20);
            this.dtFechaEnvI.TabIndex = 12;
            // 
            // chkFechaEnvio
            // 
            this.chkFechaEnvio.AutoSize = true;
            this.chkFechaEnvio.Location = new System.Drawing.Point(14, 99);
            this.chkFechaEnvio.Name = "chkFechaEnvio";
            this.chkFechaEnvio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFechaEnvio.Size = new System.Drawing.Size(62, 17);
            this.chkFechaEnvio.TabIndex = 7;
            this.chkFechaEnvio.Text = "F.Envio";
            this.chkFechaEnvio.UseVisualStyleBackColor = true;
            // 
            // txtFechaAut
            // 
            this.txtFechaAut.Location = new System.Drawing.Point(62, 50);
            this.txtFechaAut.Name = "txtFechaAut";
            this.txtFechaAut.ReadOnly = true;
            this.txtFechaAut.Size = new System.Drawing.Size(105, 21);
            this.txtFechaAut.TabIndex = 6;
            // 
            // chkEnvioAutAct
            // 
            this.chkEnvioAutAct.AutoSize = true;
            this.chkEnvioAutAct.Checked = true;
            this.chkEnvioAutAct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnvioAutAct.Location = new System.Drawing.Point(63, 76);
            this.chkEnvioAutAct.Name = "chkEnvioAutAct";
            this.chkEnvioAutAct.Size = new System.Drawing.Size(142, 17);
            this.chkEnvioAutAct.TabIndex = 5;
            this.chkEnvioAutAct.Text = "Envio Automatico Activo";
            this.chkEnvioAutAct.UseVisualStyleBackColor = true;
            this.chkEnvioAutAct.CheckedChanged += new System.EventHandler(this.chkEnvioAutAct_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.btnEnvioManual);
            this.groupControl2.Controls.Add(this.dtHoraManual);
            this.groupControl2.Controls.Add(this.cboDia);
            this.groupControl2.Controls.Add(this.chkEnvioAtodo);
            this.groupControl2.Controls.Add(this.dtFechaManual);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtPeriodo);
            this.groupControl2.Location = new System.Drawing.Point(356, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(342, 121);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Envio Manual";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(16, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 15);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Día y Hora";
            // 
            // btnEnvioManual
            // 
            this.btnEnvioManual.Location = new System.Drawing.Point(239, 23);
            this.btnEnvioManual.Name = "btnEnvioManual";
            this.btnEnvioManual.Size = new System.Drawing.Size(78, 41);
            this.btnEnvioManual.TabIndex = 10;
            this.btnEnvioManual.Text = "Envio Manual";
            // 
            // dtHoraManual
            // 
            this.dtHoraManual.EditValue = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            this.dtHoraManual.Location = new System.Drawing.Point(154, 75);
            this.dtHoraManual.Name = "dtHoraManual";
            this.dtHoraManual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHoraManual.Properties.Mask.EditMask = "HH:mm";
            this.dtHoraManual.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.dtHoraManual.Size = new System.Drawing.Size(79, 20);
            this.dtHoraManual.TabIndex = 9;
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(66, 74);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(71, 21);
            this.cboDia.TabIndex = 7;
            // 
            // chkEnvioAtodo
            // 
            this.chkEnvioAtodo.AutoSize = true;
            this.chkEnvioAtodo.Location = new System.Drawing.Point(68, 54);
            this.chkEnvioAtodo.Name = "chkEnvioAtodo";
            this.chkEnvioAtodo.Size = new System.Drawing.Size(147, 17);
            this.chkEnvioAtodo.TabIndex = 6;
            this.chkEnvioAtodo.Text = "A todos los Usuarios Aut.";
            this.chkEnvioAtodo.UseVisualStyleBackColor = true;
            // 
            // dtFechaManual
            // 
            this.dtFechaManual.EditValue = null;
            this.dtFechaManual.Location = new System.Drawing.Point(143, 24);
            this.dtFechaManual.Name = "dtFechaManual";
            this.dtFechaManual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaManual.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaManual.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtFechaManual.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaManual.Size = new System.Drawing.Size(90, 20);
            this.dtFechaManual.TabIndex = 5;
            this.dtFechaManual.EditValueChanged += new System.EventHandler(this.dtFechaManual_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 15);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Periodo Rep";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(68, 24);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "9999-99";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(69, 20);
            this.txtPeriodo.TabIndex = 0;
            // 
            // TabRep
            // 
            this.TabRep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabRep.Location = new System.Drawing.Point(12, 139);
            this.TabRep.Name = "TabRep";
            this.TabRep.SelectedTabPage = this.Tab1;
            this.TabRep.Size = new System.Drawing.Size(760, 367);
            this.TabRep.TabIndex = 7;
            this.TabRep.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab1,
            this.Tab2});
            this.TabRep.Click += new System.EventHandler(this.TabRep_Click);
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.labelControl7);
            this.Tab1.Controls.Add(this.labelControl6);
            this.Tab1.Controls.Add(this.gvRepEnviados);
            this.Tab1.Controls.Add(this.gvEnviosDelDia);
            this.Tab1.Controls.Add(this.labelControl5);
            this.Tab1.Controls.Add(this.gvEnviosRealizados);
            this.Tab1.Image = global::ModEnvioCorreo.Properties.Resources.sent_aut_16;
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(754, 336);
            this.Tab1.Text = "Envio Automaticos.";
            // 
            // gvEnviosRealizados
            // 
            this.gvEnviosRealizados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEnviosRealizados.Location = new System.Drawing.Point(3, 0);
            this.gvEnviosRealizados.MainView = this.gridView1;
            this.gvEnviosRealizados.Name = "gvEnviosRealizados";
            this.gvEnviosRealizados.Size = new System.Drawing.Size(748, 135);
            this.gvEnviosRealizados.TabIndex = 0;
            this.gvEnviosRealizados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gvEnviosRealizados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Tab2
            // 
            this.Tab2.Image = global::ModEnvioCorreo.Properties.Resources.parameters_icn;
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(754, 293);
            this.Tab2.Text = "Parametros";
            // 
            // btnRefreshGridEnvios
            // 
            this.btnRefreshGridEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshGridEnvios.Image = global::ModEnvioCorreo.Properties.Resources.update_icn;
            this.btnRefreshGridEnvios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRefreshGridEnvios.Location = new System.Drawing.Point(677, 139);
            this.btnRefreshGridEnvios.Name = "btnRefreshGridEnvios";
            this.btnRefreshGridEnvios.Size = new System.Drawing.Size(89, 23);
            this.btnRefreshGridEnvios.TabIndex = 2;
            this.btnRefreshGridEnvios.Text = "Refrescar";
            this.btnRefreshGridEnvios.Click += new System.EventHandler(this.btnRefreshGridEnvios_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Ejecuion";
            this.gridColumn1.FieldName = "d_fechaejecucion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 178;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.FieldName = "d_fecha";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 178;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hora";
            this.gridColumn3.DisplayFormat.FormatString = "HH:mm:ss";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "d_hora";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 148;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Observacion";
            this.gridColumn4.FieldName = "c_observacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ult.Usuario";
            this.gridColumn5.FieldName = "c_ultimousuario";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ult.Fecha Mod";
            this.gridColumn6.FieldName = "d_ultimafechamodificacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(5, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Envios del día";
            // 
            // gvEnviosDelDia
            // 
            this.gvEnviosDelDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gvEnviosDelDia.Location = new System.Drawing.Point(3, 155);
            this.gvEnviosDelDia.MainView = this.gridView2;
            this.gvEnviosDelDia.Name = "gvEnviosDelDia";
            this.gvEnviosDelDia.Size = new System.Drawing.Size(360, 163);
            this.gvEnviosDelDia.TabIndex = 5;
            this.gvEnviosDelDia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gvEnviosDelDia;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gvRepEnviados
            // 
            this.gvRepEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRepEnviados.Location = new System.Drawing.Point(376, 154);
            this.gvRepEnviados.MainView = this.gridView3;
            this.gvRepEnviados.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.gvRepEnviados.Name = "gvRepEnviados";
            this.gvRepEnviados.Size = new System.Drawing.Size(375, 164);
            this.gvRepEnviados.TabIndex = 6;
            this.gvRepEnviados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gvRepEnviados;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(374, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 16);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Reportes Enviados";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(307, 159);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(0, 16);
            this.labelControl7.TabIndex = 8;
            // 
            // WfEnvioAut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 518);
            this.Controls.Add(this.btnRefreshGridEnvios);
            this.Controls.Add(this.TabRep);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "WfEnvioAut";
            this.Text = "Envio Automatico Correos";
            this.Load += new System.EventHandler(this.WfEnvioAut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvF.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEnvI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoraManual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaManual.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaManual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabRep)).EndInit();
            this.TabRep.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnviosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnviosDelDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRepEnviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtHora;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox chkEnvioAutAct;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtFechaAut;
        private DevExpress.XtraEditors.DateEdit dtFechaManual;
        private System.Windows.Forms.CheckBox chkEnvioAtodo;
        private System.Windows.Forms.ComboBox cboDia;
        private DevExpress.XtraEditors.TimeEdit dtHoraManual;
        private DevExpress.XtraEditors.SimpleButton btnEnvioManual;
        private DevExpress.XtraTab.XtraTabControl TabRep;
        private DevExpress.XtraTab.XtraTabPage Tab1;
        private DevExpress.XtraTab.XtraTabPage Tab2;
        private DevExpress.XtraGrid.GridControl gvEnviosRealizados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox chkFechaEnvio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtFechaEnvF;
        private DevExpress.XtraEditors.DateEdit dtFechaEnvI;
        private DevExpress.XtraEditors.SimpleButton btnRefreshGridEnvios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gvEnviosDelDia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gvRepEnviados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}