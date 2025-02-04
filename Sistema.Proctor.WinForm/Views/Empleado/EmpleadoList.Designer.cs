namespace Sistema.Proctor.WinForm.Views.Empleado
{
    partial class EmpleadoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoList));
            gridControlEmpleados = new DevExpress.XtraGrid.GridControl();
            empleadoBindingSource = new BindingSource(components);
            gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            colFIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true, true);
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barButtonEditar = new DevExpress.XtraBars.BarButtonItem();
            barButtonEliminar = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)gridControlEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // gridControlEmpleados
            // 
            gridControlEmpleados.DataSource = empleadoBindingSource;
            gridControlEmpleados.Dock = DockStyle.Fill;
            gridControlEmpleados.Location = new Point(0, 0);
            gridControlEmpleados.MainView = gridViewEmpleados;
            gridControlEmpleados.Name = "gridControlEmpleados";
            gridControlEmpleados.Size = new Size(733, 470);
            gridControlEmpleados.TabIndex = 0;
            gridControlEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewEmpleados });
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Data.Entities.Empleado);
            // 
            // gridViewEmpleados
            // 
            gridViewEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNombre, colApellido, colCedula, colDireccion, colFIngreso });
            gridViewEmpleados.GridControl = gridControlEmpleados;
            gridViewEmpleados.Name = "gridViewEmpleados";
            gridViewEmpleados.PopupMenuShowing += gridViewEmpleados_PopupMenuShowing;
            gridViewEmpleados.SelectionChanged += gridViewEmpleados_SelectionChanged;
            // 
            // colNombre
            // 
            colNombre.FieldName = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.OptionsColumn.ReadOnly = true;
            colNombre.Visible = true;
            colNombre.VisibleIndex = 3;
            // 
            // colApellido
            // 
            colApellido.FieldName = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.OptionsColumn.ReadOnly = true;
            colApellido.Visible = true;
            colApellido.VisibleIndex = 0;
            // 
            // colCedula
            // 
            colCedula.FieldName = "Cedula";
            colCedula.Name = "colCedula";
            colCedula.OptionsColumn.ReadOnly = true;
            colCedula.Visible = true;
            colCedula.VisibleIndex = 1;
            // 
            // colDireccion
            // 
            colDireccion.FieldName = "Direccion";
            colDireccion.Name = "colDireccion";
            colDireccion.OptionsColumn.ReadOnly = true;
            colDireccion.Visible = true;
            colDireccion.VisibleIndex = 2;
            // 
            // colFIngreso
            // 
            colFIngreso.Caption = "Fecha Ingreso";
            colFIngreso.FieldName = "FIngreso";
            colFIngreso.Name = "colFIngreso";
            colFIngreso.OptionsColumn.ReadOnly = true;
            colFIngreso.Visible = true;
            colFIngreso.VisibleIndex = 4;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonEditar), new DevExpress.XtraBars.LinkPersistInfo(barButtonEliminar) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // barButtonEditar
            // 
            barButtonEditar.Caption = "Editar";
            barButtonEditar.Id = 0;
            barButtonEditar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonEditar.ImageOptions.SvgImage");
            barButtonEditar.Name = "barButtonEditar";
            // 
            // barButtonEliminar
            // 
            barButtonEliminar.Caption = "Eliminar";
            barButtonEliminar.Id = 1;
            barButtonEliminar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonEliminar.ImageOptions.SvgImage");
            barButtonEliminar.Name = "barButtonEliminar";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonEditar, barButtonEliminar });
            barManager1.MaxItemId = 2;
            barManager1.ItemClick += barManager1_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(733, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 470);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(733, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 470);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(733, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 470);
            // 
            // EmpleadoList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 470);
            Controls.Add(gridControlEmpleados);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmpleadoList.IconOptions.SvgImage");
            Name = "EmpleadoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Empleados";
            WindowState = FormWindowState.Maximized;
            Load += EmpleadoList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private BindingSource empleadoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colFIngreso;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonEditar;
        private DevExpress.XtraBars.BarButtonItem barButtonEliminar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}