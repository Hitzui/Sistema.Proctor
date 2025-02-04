namespace Sistema.Proctor.WinForm.Views.Cliente
{
    partial class ClientesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesList));
            gridControlClientes = new DevExpress.XtraGrid.GridControl();
            gridViewClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnNombreAbreviado = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            barManagerClientes = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItemEliminar = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditar = new DevExpress.XtraBars.BarButtonItem();
            popupMenuClientes = new DevExpress.XtraBars.PopupMenu(components);
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(WaitForm1), true, true, true);
            ((System.ComponentModel.ISupportInitialize)gridControlClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManagerClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuClientes).BeginInit();
            SuspendLayout();
            // 
            // gridControlClientes
            // 
            gridControlClientes.Dock = DockStyle.Fill;
            gridControlClientes.Location = new Point(0, 0);
            gridControlClientes.MainView = gridViewClientes;
            gridControlClientes.Name = "gridControlClientes";
            gridControlClientes.Size = new Size(929, 668);
            gridControlClientes.TabIndex = 4;
            gridControlClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewClientes });
            // 
            // gridViewClientes
            // 
            gridViewClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnNombreAbreviado, gridColumnDireccion, gridColumnEmail, gridColumnRuc, gridColumnTelefono });
            gridViewClientes.GridControl = gridControlClientes;
            gridViewClientes.Name = "gridViewClientes";
            gridViewClientes.PopupMenuShowing += gridViewClientes_PopupMenuShowing;
            gridViewClientes.SelectionChanged += gridViewClientes_SelectionChanged;
            // 
            // gridColumnNombreAbreviado
            // 
            gridColumnNombreAbreviado.Caption = "Nombre";
            gridColumnNombreAbreviado.FieldName = "NombreAbreviado";
            gridColumnNombreAbreviado.Name = "gridColumnNombreAbreviado";
            gridColumnNombreAbreviado.OptionsColumn.ReadOnly = true;
            gridColumnNombreAbreviado.Visible = true;
            gridColumnNombreAbreviado.VisibleIndex = 2;
            // 
            // gridColumnDireccion
            // 
            gridColumnDireccion.Caption = "Direccion";
            gridColumnDireccion.FieldName = "Direccion";
            gridColumnDireccion.Name = "gridColumnDireccion";
            gridColumnDireccion.OptionsColumn.ReadOnly = true;
            gridColumnDireccion.Visible = true;
            gridColumnDireccion.VisibleIndex = 0;
            // 
            // gridColumnEmail
            // 
            gridColumnEmail.Caption = "Email";
            gridColumnEmail.FieldName = "Email";
            gridColumnEmail.Name = "gridColumnEmail";
            gridColumnEmail.OptionsColumn.ReadOnly = true;
            gridColumnEmail.Visible = true;
            gridColumnEmail.VisibleIndex = 1;
            // 
            // gridColumnRuc
            // 
            gridColumnRuc.Caption = "Ruc";
            gridColumnRuc.FieldName = "Ruc";
            gridColumnRuc.Name = "gridColumnRuc";
            gridColumnRuc.OptionsColumn.ReadOnly = true;
            gridColumnRuc.Visible = true;
            gridColumnRuc.VisibleIndex = 3;
            // 
            // gridColumnTelefono
            // 
            gridColumnTelefono.Caption = "Telefono";
            gridColumnTelefono.FieldName = "Telefono";
            gridColumnTelefono.Name = "gridColumnTelefono";
            gridColumnTelefono.OptionsColumn.ReadOnly = true;
            gridColumnTelefono.Visible = true;
            gridColumnTelefono.VisibleIndex = 4;
            // 
            // barManagerClientes
            // 
            barManagerClientes.DockControls.Add(barDockControlTop);
            barManagerClientes.DockControls.Add(barDockControlBottom);
            barManagerClientes.DockControls.Add(barDockControlLeft);
            barManagerClientes.DockControls.Add(barDockControlRight);
            barManagerClientes.Form = this;
            barManagerClientes.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemEliminar, barButtonItemEditar });
            barManagerClientes.MaxItemId = 2;
            barManagerClientes.ItemClick += barManagerClientes_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManagerClientes;
            barDockControlTop.Size = new Size(929, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 668);
            barDockControlBottom.Manager = barManagerClientes;
            barDockControlBottom.Size = new Size(929, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManagerClientes;
            barDockControlLeft.Size = new Size(0, 668);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(929, 0);
            barDockControlRight.Manager = barManagerClientes;
            barDockControlRight.Size = new Size(0, 668);
            // 
            // barButtonItemEliminar
            // 
            barButtonItemEliminar.Caption = "Eliminar";
            barButtonItemEliminar.Id = 0;
            barButtonItemEliminar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEliminar.ImageOptions.SvgImage");
            barButtonItemEliminar.Name = "barButtonItemEliminar";
            // 
            // barButtonItemEditar
            // 
            barButtonItemEditar.Caption = "Editar";
            barButtonItemEditar.Id = 1;
            barButtonItemEditar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditar.ImageOptions.SvgImage");
            barButtonItemEditar.Name = "barButtonItemEditar";
            // 
            // popupMenuClientes
            // 
            popupMenuClientes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEditar), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEliminar) });
            popupMenuClientes.Manager = barManagerClientes;
            popupMenuClientes.Name = "popupMenuClientes";
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ClientesList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 668);
            Controls.Add(gridControlClientes);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ClientesList.IconOptions.SvgImage");
            Name = "ClientesList";
            ShowMdiChildCaptionInParentTitle = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += ClientesList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManagerClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClientes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombreAbreviado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTelefono;
        private DevExpress.XtraBars.BarManager barManagerClientes;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEliminar;
        private DevExpress.XtraBars.PopupMenu popupMenuClientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditar;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}