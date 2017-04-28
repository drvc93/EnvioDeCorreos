namespace ModEnvioCorreo
{
    partial class wf_actReporteEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_actReporteEnvio));
            this.txtCod = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnInsertarUs = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.gvListaUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usuarioenv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ultusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ultfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_flagreg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.cboTipoData = new System.Windows.Forms.ComboBox();
            this.cboUndNeg = new System.Windows.Forms.ComboBox();
            this.chkXUsuario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(88, 14);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(83, 21);
            this.txtCod.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(37, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Codigo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(229, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tipo Data";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(321, 21);
            this.txtDescripcion.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(9, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Und. Negocio";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(264, 66);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Progración de Envios";
            // 
            // btnInsertarUs
            // 
            this.btnInsertarUs.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarUs.Image")));
            this.btnInsertarUs.Location = new System.Drawing.Point(13, 119);
            this.btnInsertarUs.Name = "btnInsertarUs";
            this.btnInsertarUs.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarUs.TabIndex = 10;
            this.btnInsertarUs.Text = "Insertar";
            this.btnInsertarUs.Click += new System.EventHandler(this.btnInsertarUs_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuario.Image")));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(88, 119);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 11;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // gvListaUsuarios
            // 
            this.gvListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListaUsuarios.Location = new System.Drawing.Point(13, 148);
            this.gvListaUsuarios.MainView = this.gridView1;
            this.gvListaUsuarios.Name = "gvListaUsuarios";
            this.gvListaUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTimeEdit1});
            this.gvListaUsuarios.Size = new System.Drawing.Size(638, 289);
            this.gvListaUsuarios.TabIndex = 12;
            this.gvListaUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvListaUsuarios.Click += new System.EventHandler(this.gvListaUsuarios_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_index,
            this.col_diaNom,
            this.col_hora,
            this.col_estado,
            this.col_usuarioenv,
            this.col_ultusuario,
            this.col_ultfecha,
            this.col_flagreg});
            this.gridView1.GridControl = this.gvListaUsuarios;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // col_index
            // 
            this.col_index.Caption = "#";
            this.col_index.FieldName = "n_index";
            this.col_index.Name = "col_index";
            this.col_index.Visible = true;
            this.col_index.VisibleIndex = 0;
            this.col_index.Width = 20;
            // 
            // col_diaNom
            // 
            this.col_diaNom.Caption = "Dia";
            this.col_diaNom.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.col_diaNom.FieldName = "c_dia";
            this.col_diaNom.Name = "col_diaNom";
            this.col_diaNom.Visible = true;
            this.col_diaNom.VisibleIndex = 1;
            this.col_diaNom.Width = 99;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // col_hora
            // 
            this.col_hora.Caption = "Hora";
            this.col_hora.ColumnEdit = this.repositoryItemTimeEdit1;
            this.col_hora.DisplayFormat.FormatString = "HH:mm";
            this.col_hora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_hora.FieldName = "d_hora";
            this.col_hora.Name = "col_hora";
            this.col_hora.Visible = true;
            this.col_hora.VisibleIndex = 2;
            this.col_hora.Width = 99;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "HH:mm";
            this.repositoryItemTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // col_estado
            // 
            this.col_estado.Caption = "Estado";
            this.col_estado.FieldName = "c_estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 6;
            this.col_estado.Width = 105;
            // 
            // col_usuarioenv
            // 
            this.col_usuarioenv.Caption = "Usuario Envio";
            this.col_usuarioenv.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.col_usuarioenv.FieldName = "c_usuarioenvio";
            this.col_usuarioenv.Name = "col_usuarioenv";
            this.col_usuarioenv.Visible = true;
            this.col_usuarioenv.VisibleIndex = 3;
            this.col_usuarioenv.Width = 99;
            // 
            // col_ultusuario
            // 
            this.col_ultusuario.Caption = "Ult.Usuario";
            this.col_ultusuario.FieldName = "c_ultimousuario";
            this.col_ultusuario.Name = "col_ultusuario";
            this.col_ultusuario.OptionsColumn.AllowEdit = false;
            this.col_ultusuario.OptionsColumn.ReadOnly = true;
            this.col_ultusuario.Visible = true;
            this.col_ultusuario.VisibleIndex = 4;
            this.col_ultusuario.Width = 99;
            // 
            // col_ultfecha
            // 
            this.col_ultfecha.Caption = "Ult.Fecha Mod.";
            this.col_ultfecha.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.col_ultfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_ultfecha.FieldName = "d_ultimafechamodificacion";
            this.col_ultfecha.Name = "col_ultfecha";
            this.col_ultfecha.OptionsColumn.AllowEdit = false;
            this.col_ultfecha.OptionsColumn.ReadOnly = true;
            this.col_ultfecha.Visible = true;
            this.col_ultfecha.VisibleIndex = 5;
            this.col_ultfecha.Width = 99;
            // 
            // col_flagreg
            // 
            this.col_flagreg.Caption = "flag";
            this.col_flagreg.FieldName = "c_flagReg";
            this.col_flagreg.Name = "col_flagreg";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(363, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(285, 443);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboTipoData
            // 
            this.cboTipoData.Enabled = false;
            this.cboTipoData.FormattingEnabled = true;
            this.cboTipoData.Location = new System.Drawing.Point(285, 13);
            this.cboTipoData.Name = "cboTipoData";
            this.cboTipoData.Size = new System.Drawing.Size(124, 21);
            this.cboTipoData.TabIndex = 15;
            // 
            // cboUndNeg
            // 
            this.cboUndNeg.Enabled = false;
            this.cboUndNeg.FormattingEnabled = true;
            this.cboUndNeg.Location = new System.Drawing.Point(88, 65);
            this.cboUndNeg.Name = "cboUndNeg";
            this.cboUndNeg.Size = new System.Drawing.Size(173, 21);
            this.cboUndNeg.TabIndex = 16;
            // 
            // chkXUsuario
            // 
            this.chkXUsuario.AutoSize = true;
            this.chkXUsuario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkXUsuario.Checked = true;
            this.chkXUsuario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXUsuario.Location = new System.Drawing.Point(326, 66);
            this.chkXUsuario.Name = "chkXUsuario";
            this.chkXUsuario.Size = new System.Drawing.Size(81, 17);
            this.chkXUsuario.TabIndex = 17;
            this.chkXUsuario.Text = "Por Usuario";
            this.chkXUsuario.UseVisualStyleBackColor = true;
            // 
            // wf_actReporteEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 470);
            this.Controls.Add(this.chkXUsuario);
            this.Controls.Add(this.cboUndNeg);
            this.Controls.Add(this.cboTipoData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gvListaUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnInsertarUs);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(679, 509);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(679, 509);
            this.Name = "wf_actReporteEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Envio Reporte";
            this.Load += new System.EventHandler(this.wf_actReporteEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.CheckBox chkEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnInsertarUs;
        private DevExpress.XtraEditors.SimpleButton btnEliminarUsuario;
        private DevExpress.XtraGrid.GridControl gvListaUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTipoData;
        public System.Windows.Forms.ComboBox cboUndNeg;
        private DevExpress.XtraGrid.Columns.GridColumn col_diaNom;
        private DevExpress.XtraGrid.Columns.GridColumn col_hora;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_usuarioenv;
        private DevExpress.XtraGrid.Columns.GridColumn col_ultusuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_ultfecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_flagreg;
        private System.Windows.Forms.CheckBox chkXUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_index;
    }
}