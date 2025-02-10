namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    partial class ProyectoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoList));
            gridControlProyectos = new DevExpress.XtraGrid.GridControl();
            proyectoBindingSource = new BindingSource(components);
            gridViewProyectos = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCodigoProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaMuestreo = new DevExpress.XtraGrid.Columns.GridColumn();
            colUbicacionProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemAbrirProyecto = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditarProyecto = new DevExpress.XtraBars.BarButtonItem();
            barManagerProyecto = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)gridControlProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManagerProyecto).BeginInit();
            SuspendLayout();
            // 
            // gridControlProyectos
            // 
            gridControlProyectos.DataSource = proyectoBindingSource;
            gridControlProyectos.Dock = DockStyle.Fill;
            gridControlProyectos.Location = new Point(0, 0);
            gridControlProyectos.MainView = gridViewProyectos;
            gridControlProyectos.Name = "gridControlProyectos";
            gridControlProyectos.Size = new Size(896, 484);
            gridControlProyectos.TabIndex = 0;
            gridControlProyectos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewProyectos });
            // 
            // proyectoBindingSource
            // 
            proyectoBindingSource.DataSource = typeof(Sistema.Proctor.Data.Entities.Proyecto);
            // 
            // gridViewProyectos
            // 
            gridViewProyectos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCodigoProyecto, colDescripcion, colFechaFin, colFechaInicio, colFechaMuestreo, colUbicacionProyecto });
            gridViewProyectos.GridControl = gridControlProyectos;
            gridViewProyectos.Name = "gridViewProyectos";
            gridViewProyectos.OptionsBehavior.Editable = false;
            gridViewProyectos.PopupMenuShowing += gridViewProyectos_PopupMenuShowing;
            gridViewProyectos.SelectionChanged += gridViewProyectos_SelectionChanged;
            // 
            // colCodigoProyecto
            // 
            colCodigoProyecto.FieldName = "CodigoProyecto";
            colCodigoProyecto.Name = "colCodigoProyecto";
            colCodigoProyecto.Visible = true;
            colCodigoProyecto.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            colDescripcion.FieldName = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Visible = true;
            colDescripcion.VisibleIndex = 1;
            // 
            // colFechaFin
            // 
            colFechaFin.FieldName = "FechaFin";
            colFechaFin.Name = "colFechaFin";
            colFechaFin.Visible = true;
            colFechaFin.VisibleIndex = 2;
            // 
            // colFechaInicio
            // 
            colFechaInicio.FieldName = "FechaInicio";
            colFechaInicio.Name = "colFechaInicio";
            colFechaInicio.Visible = true;
            colFechaInicio.VisibleIndex = 3;
            // 
            // colFechaMuestreo
            // 
            colFechaMuestreo.FieldName = "FechaMuestreo";
            colFechaMuestreo.Name = "colFechaMuestreo";
            colFechaMuestreo.Visible = true;
            colFechaMuestreo.VisibleIndex = 4;
            // 
            // colUbicacionProyecto
            // 
            colUbicacionProyecto.FieldName = "UbicacionProyecto";
            colUbicacionProyecto.Name = "colUbicacionProyecto";
            colUbicacionProyecto.Visible = true;
            colUbicacionProyecto.VisibleIndex = 5;
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAbrirProyecto), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEditarProyecto) });
            popupMenu.Manager = barManagerProyecto;
            popupMenu.Name = "popupMenu";
            // 
            // barButtonItemAbrirProyecto
            // 
            barButtonItemAbrirProyecto.Caption = "Abrir Proyecto";
            barButtonItemAbrirProyecto.Id = 0;
            barButtonItemAbrirProyecto.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAbrirProyecto.ImageOptions.SvgImage");
            barButtonItemAbrirProyecto.Name = "barButtonItemAbrirProyecto";
            // 
            // barButtonItemEditarProyecto
            // 
            barButtonItemEditarProyecto.Caption = "EditarProyecto";
            barButtonItemEditarProyecto.Id = 1;
            barButtonItemEditarProyecto.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditarProyecto.ImageOptions.SvgImage");
            barButtonItemEditarProyecto.Name = "barButtonItemEditarProyecto";
            // 
            // barManagerProyecto
            // 
            barManagerProyecto.DockControls.Add(barDockControlTop);
            barManagerProyecto.DockControls.Add(barDockControlBottom);
            barManagerProyecto.DockControls.Add(barDockControlLeft);
            barManagerProyecto.DockControls.Add(barDockControlRight);
            barManagerProyecto.Form = this;
            barManagerProyecto.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemAbrirProyecto, barButtonItemEditarProyecto });
            barManagerProyecto.MaxItemId = 2;
            barManagerProyecto.ItemClick += barManagerProyecto_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManagerProyecto;
            barDockControlTop.Size = new Size(896, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 484);
            barDockControlBottom.Manager = barManagerProyecto;
            barDockControlBottom.Size = new Size(896, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManagerProyecto;
            barDockControlLeft.Size = new Size(0, 484);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(896, 0);
            barDockControlRight.Manager = barManagerProyecto;
            barDockControlRight.Size = new Size(0, 484);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ProyectoList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 484);
            Controls.Add(gridControlProyectos);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ProyectoList.IconOptions.SvgImage");
            Name = "ProyectoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Proyectos";
            WindowState = FormWindowState.Maximized;
            Load += ProyectoList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManagerProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProyectos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProyectos;
        private BindingSource proyectoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoProyecto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMuestreo;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacionProyecto;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbrirProyecto;
        private DevExpress.XtraBars.BarManager barManagerProyecto;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarProyecto;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}