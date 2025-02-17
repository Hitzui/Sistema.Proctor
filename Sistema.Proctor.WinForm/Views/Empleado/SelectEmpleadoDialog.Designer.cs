namespace Sistema.Proctor.WinForm.Views.Empleado
{
    partial class SelectEmpleadoDialog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectEmpleadoDialog));
            gridControlSeleccionarEmpleado = new DevExpress.XtraGrid.GridControl();
            empleadoBindingSource = new BindingSource(components);
            gridViewSeleccionarEmpleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).BeginInit();
            stackPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlSeleccionarEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSeleccionarEmpleado).BeginInit();
            SuspendLayout();
            // 
            // stackPanelFooter
            // 
            stackPanelFooter.Location = new Point(0, 351);
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancelar.Appearance.ForeColor = Color.White;
            btnCancelar.Appearance.Options.UseBackColor = true;
            btnCancelar.Appearance.Options.UseForeColor = true;
            btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnCancelar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancelar.ImageOptions.SvgImage");
            btnCancelar.Location = new Point(496, 22);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuardar.ImageOptions.SvgImage");
            btnGuardar.Location = new Point(310, 22);
            btnGuardar.Size = new Size(133, 32);
            btnGuardar.Text = "Seleccionar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gridControlSeleccionarEmpleado
            // 
            gridControlSeleccionarEmpleado.DataSource = empleadoBindingSource;
            gridControlSeleccionarEmpleado.Dock = DockStyle.Fill;
            gridControlSeleccionarEmpleado.Location = new Point(0, 0);
            gridControlSeleccionarEmpleado.MainView = gridViewSeleccionarEmpleado;
            gridControlSeleccionarEmpleado.Name = "gridControlSeleccionarEmpleado";
            gridControlSeleccionarEmpleado.Size = new Size(676, 351);
            gridControlSeleccionarEmpleado.TabIndex = 3;
            gridControlSeleccionarEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewSeleccionarEmpleado });
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Proctor.Data.Entities.Empleado);
            // 
            // gridViewSeleccionarEmpleado
            // 
            gridViewSeleccionarEmpleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNombre, colApellido, colCedula });
            gridViewSeleccionarEmpleado.GridControl = gridControlSeleccionarEmpleado;
            gridViewSeleccionarEmpleado.Name = "gridViewSeleccionarEmpleado";
            gridViewSeleccionarEmpleado.OptionsBehavior.Editable = false;
            // 
            // colNombre
            // 
            colNombre.FieldName = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.OptionsColumn.ReadOnly = true;
            colNombre.Visible = true;
            colNombre.VisibleIndex = 2;
            // 
            // colApellido
            // 
            colApellido.FieldName = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.Visible = true;
            colApellido.VisibleIndex = 0;
            // 
            // colCedula
            // 
            colCedula.FieldName = "Cedula";
            colCedula.Name = "colCedula";
            colCedula.Visible = true;
            colCedula.VisibleIndex = 1;
            // 
            // SelectEmpleadoDialog
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 428);
            Controls.Add(gridControlSeleccionarEmpleado);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SelectEmpleadoDialog.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectEmpleadoDialog";
            Text = "Seleccionar Empleado";
            Load += SelectEmpleadoDialog_Load;
            Controls.SetChildIndex(stackPanelFooter, 0);
            Controls.SetChildIndex(gridControlSeleccionarEmpleado, 0);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).EndInit();
            stackPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlSeleccionarEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSeleccionarEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSeleccionarEmpleado;
        private BindingSource empleadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSeleccionarEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
    }
}