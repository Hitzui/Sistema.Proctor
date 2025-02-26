namespace Sistema.Proctor.WinForm.Views.Empresa
{
    partial class EmpresaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresaList));
            gridControlEmpresas = new DevExpress.XtraGrid.GridControl();
            empresaBindingSource = new BindingSource(components);
            gridViewEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            colNombreAbreviado = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControlEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmpresas).BeginInit();
            SuspendLayout();
            // 
            // gridControlEmpresas
            // 
            gridControlEmpresas.DataSource = empresaBindingSource;
            gridControlEmpresas.Dock = DockStyle.Fill;
            gridControlEmpresas.Location = new Point(0, 0);
            gridControlEmpresas.MainView = gridViewEmpresas;
            gridControlEmpresas.Name = "gridControlEmpresas";
            gridControlEmpresas.Size = new Size(886, 527);
            gridControlEmpresas.TabIndex = 0;
            gridControlEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewEmpresas });
            // 
            // empresaBindingSource
            // 
            empresaBindingSource.DataSource = typeof(Proctor.Data.Entities.Empresa);
            // 
            // gridViewEmpresas
            // 
            gridViewEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNombreComercial, colNombreAbreviado, colEmail, colTelefono, colCelular, colDireccion });
            gridViewEmpresas.GridControl = gridControlEmpresas;
            gridViewEmpresas.Name = "gridViewEmpresas";
            gridViewEmpresas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewEmpresas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewEmpresas.OptionsBehavior.Editable = false;
            gridViewEmpresas.SelectionChanged += gridViewEmpresas_SelectionChanged;
            // 
            // colNombreComercial
            // 
            colNombreComercial.FieldName = "NombreComercial";
            colNombreComercial.Name = "colNombreComercial";
            colNombreComercial.Visible = true;
            colNombreComercial.VisibleIndex = 0;
            // 
            // colNombreAbreviado
            // 
            colNombreAbreviado.FieldName = "NombreAbreviado";
            colNombreAbreviado.Name = "colNombreAbreviado";
            colNombreAbreviado.Visible = true;
            colNombreAbreviado.VisibleIndex = 1;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 2;
            // 
            // colTelefono
            // 
            colTelefono.FieldName = "Telefono";
            colTelefono.Name = "colTelefono";
            colTelefono.Visible = true;
            colTelefono.VisibleIndex = 3;
            // 
            // colCelular
            // 
            colCelular.FieldName = "Celular";
            colCelular.Name = "colCelular";
            colCelular.Visible = true;
            colCelular.VisibleIndex = 4;
            // 
            // colDireccion
            // 
            colDireccion.FieldName = "Direccion";
            colDireccion.Name = "colDireccion";
            colDireccion.Visible = true;
            colDireccion.VisibleIndex = 5;
            // 
            // EmpresaList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 527);
            Controls.Add(gridControlEmpresas);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmpresaList.IconOptions.SvgImage");
            Name = "EmpresaList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado Empresas";
            WindowState = FormWindowState.Maximized;
            Load += EmpresaList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmpresas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpresas;
        private BindingSource empresaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAbreviado;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
    }
}