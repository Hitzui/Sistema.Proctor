namespace Sistema.Proctor.WinForm.Views.Cliente
{
    partial class SelectClienteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectClienteDialog));
            gridControlSelectCliente = new DevExpress.XtraGrid.GridControl();
            clienteBindingSource = new BindingSource(components);
            gridViewSelectCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            colNombreAbreviado = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            colRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).BeginInit();
            stackPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlSelectCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSelectCliente).BeginInit();
            SuspendLayout();
            // 
            // stackPanelFooter
            // 
            stackPanelFooter.Location = new Point(0, 360);
            stackPanelFooter.Size = new Size(700, 77);
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancelar.Appearance.ForeColor = Color.White;
            btnCancelar.Appearance.Options.UseBackColor = true;
            btnCancelar.Appearance.Options.UseForeColor = true;
            btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnCancelar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancelar.ImageOptions.SvgImage");
            btnCancelar.ImageOptions.SvgImageSize = new Size(25, 25);
            btnCancelar.Location = new Point(507, 22);
            btnCancelar.Size = new Size(132, 32);
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuardar.ImageOptions.SvgImage");
            btnGuardar.ImageOptions.SvgImageSize = new Size(25, 25);
            btnGuardar.Location = new Point(322, 22);
            btnGuardar.Size = new Size(132, 32);
            btnGuardar.Text = "Seleccionar Cliente";
            // 
            // gridControlSelectCliente
            // 
            gridControlSelectCliente.DataSource = clienteBindingSource;
            gridControlSelectCliente.Dock = DockStyle.Fill;
            gridControlSelectCliente.Location = new Point(0, 0);
            gridControlSelectCliente.MainView = gridViewSelectCliente;
            gridControlSelectCliente.Name = "gridControlSelectCliente";
            gridControlSelectCliente.Size = new Size(700, 360);
            gridControlSelectCliente.TabIndex = 3;
            gridControlSelectCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewSelectCliente });
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Proctor.Data.Entities.Cliente);
            // 
            // gridViewSelectCliente
            // 
            gridViewSelectCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNombreComercial, colNombreAbreviado, colEmail, colDireccion, colRuc });
            gridViewSelectCliente.GridControl = gridControlSelectCliente;
            gridViewSelectCliente.Name = "gridViewSelectCliente";
            gridViewSelectCliente.OptionsBehavior.Editable = false;
            gridViewSelectCliente.SelectionChanged += gridViewSelectCliente_SelectionChanged;
            // 
            // colNombreComercial
            // 
            colNombreComercial.Caption = "Nombre Comercial";
            colNombreComercial.FieldName = "NombreComercial";
            colNombreComercial.Name = "colNombreComercial";
            colNombreComercial.Visible = true;
            colNombreComercial.VisibleIndex = 0;
            // 
            // colNombreAbreviado
            // 
            colNombreAbreviado.Caption = "Nombre Abreviado";
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
            // colDireccion
            // 
            colDireccion.FieldName = "Direccion";
            colDireccion.Name = "colDireccion";
            colDireccion.Visible = true;
            colDireccion.VisibleIndex = 3;
            // 
            // colRuc
            // 
            colRuc.FieldName = "Ruc";
            colRuc.Name = "colRuc";
            colRuc.Visible = true;
            colRuc.VisibleIndex = 4;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // SelectClienteDialog
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 437);
            Controls.Add(gridControlSelectCliente);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SelectClienteDialog.IconOptions.SvgImage");
            Name = "SelectClienteDialog";
            Text = "Seleccionar Cliente";
            Load += SelectClienteDialog_Load;
            Controls.SetChildIndex(stackPanelFooter, 0);
            Controls.SetChildIndex(gridControlSelectCliente, 0);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).EndInit();
            stackPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlSelectCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSelectCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSelectCliente;
        private BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSelectCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAbreviado;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colRuc;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}