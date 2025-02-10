namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    partial class ProyectoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoEdit));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtCodigoProyecto = new DevExpress.XtraEditors.TextEdit();
            proyectoDtoBindingSource = new BindingSource(components);
            txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            txtFechInicio = new DevExpress.XtraEditors.DateEdit();
            txtFechaFin = new DevExpress.XtraEditors.DateEdit();
            txtClienteDescripcion = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            btnSeleccionarCliente = new DevExpress.XtraEditors.SimpleButton();
            dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).BeginInit();
            stackPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCodigoProyecto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proyectoDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescripcion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFechInicio.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFechInicio.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFechaFin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFechaFin.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtClienteDescripcion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // stackPanelFooter
            // 
            stackPanelFooter.Controls.Add(btnSeleccionarCliente);
            stackPanelFooter.Location = new Point(0, 365);
            stackPanelFooter.Size = new Size(687, 77);
            stackPanelFooter.Controls.SetChildIndex(btnGuardar, 0);
            stackPanelFooter.Controls.SetChildIndex(btnCancelar, 0);
            stackPanelFooter.Controls.SetChildIndex(btnSeleccionarCliente, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancelar.Appearance.ForeColor = Color.White;
            btnCancelar.Appearance.Options.UseBackColor = true;
            btnCancelar.Appearance.Options.UseForeColor = true;
            btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnCancelar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancelar.ImageOptions.SvgImage");
            btnCancelar.ImageOptions.SvgImageSize = new Size(32, 32);
            btnCancelar.Location = new Point(352, 19);
            btnCancelar.Size = new Size(125, 37);
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuardar.ImageOptions.SvgImage");
            btnGuardar.Location = new Point(174, 19);
            btnGuardar.Size = new Size(125, 37);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtCodigoProyecto);
            layoutControl1.Controls.Add(txtDescripcion);
            layoutControl1.Controls.Add(txtFechInicio);
            layoutControl1.Controls.Add(txtFechaFin);
            layoutControl1.Controls.Add(txtClienteDescripcion);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(687, 365);
            layoutControl1.TabIndex = 3;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtCodigoProyecto
            // 
            txtCodigoProyecto.DataBindings.Add(new Binding("EditValue", proyectoDtoBindingSource, "CodigoProyecto", true));
            txtCodigoProyecto.Location = new Point(133, 12);
            txtCodigoProyecto.Name = "txtCodigoProyecto";
            txtCodigoProyecto.Size = new Size(542, 20);
            txtCodigoProyecto.StyleController = layoutControl1;
            txtCodigoProyecto.TabIndex = 4;
            // 
            // proyectoDtoBindingSource
            // 
            proyectoDtoBindingSource.DataSource = typeof(Dto.ProyectoDto);
            // 
            // txtDescripcion
            // 
            txtDescripcion.DataBindings.Add(new Binding("EditValue", proyectoDtoBindingSource, "Descripcion", true));
            txtDescripcion.Location = new Point(133, 36);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(542, 245);
            txtDescripcion.StyleController = layoutControl1;
            txtDescripcion.TabIndex = 5;
            // 
            // txtFechInicio
            // 
            txtFechInicio.DataBindings.Add(new Binding("EditValue", proyectoDtoBindingSource, "FechaInicio", true));
            txtFechInicio.EditValue = null;
            txtFechInicio.Location = new Point(133, 285);
            txtFechInicio.Name = "txtFechInicio";
            txtFechInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFechInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFechInicio.Size = new Size(542, 20);
            txtFechInicio.StyleController = layoutControl1;
            txtFechInicio.TabIndex = 6;
            // 
            // txtFechaFin
            // 
            txtFechaFin.DataBindings.Add(new Binding("EditValue", proyectoDtoBindingSource, "FechaFin", true));
            txtFechaFin.EditValue = null;
            txtFechaFin.Location = new Point(133, 309);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFechaFin.Size = new Size(542, 20);
            txtFechaFin.StyleController = layoutControl1;
            txtFechaFin.TabIndex = 7;
            // 
            // txtClienteDescripcion
            // 
            txtClienteDescripcion.Location = new Point(133, 333);
            txtClienteDescripcion.Name = "txtClienteDescripcion";
            txtClienteDescripcion.Properties.ReadOnly = true;
            txtClienteDescripcion.Size = new Size(542, 20);
            txtClienteDescripcion.StyleController = layoutControl1;
            txtClienteDescripcion.TabIndex = 8;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5 });
            Root.Name = "Root";
            Root.Size = new Size(687, 365);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtCodigoProyecto;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(667, 24);
            layoutControlItem1.Text = "Código del proyecto";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem2.Control = txtDescripcion;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(667, 249);
            layoutControlItem2.Text = "Descripción del proyecto";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtFechInicio;
            layoutControlItem3.Location = new Point(0, 273);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(667, 24);
            layoutControlItem3.Text = "Fecha de inicio";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtFechaFin;
            layoutControlItem4.Location = new Point(0, 297);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(667, 24);
            layoutControlItem4.Text = "Fecha de fin";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtClienteDescripcion;
            layoutControlItem5.Location = new Point(0, 321);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(667, 24);
            layoutControlItem5.Text = "Cliente";
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnSeleccionarCliente.Appearance.ForeColor = Color.White;
            btnSeleccionarCliente.Appearance.Options.UseBackColor = true;
            btnSeleccionarCliente.Appearance.Options.UseForeColor = true;
            btnSeleccionarCliente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnSeleccionarCliente.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSeleccionarCliente.ImageOptions.SvgImage");
            btnSeleccionarCliente.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSeleccionarCliente.Location = new Point(529, 19);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(145, 37);
            btnSeleccionarCliente.TabIndex = 2;
            btnSeleccionarCliente.Text = "Seleccionar Cliente";
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // dxErrorProvider1
            // 
            dxErrorProvider1.ContainerControl = this;
            dxErrorProvider1.DataSource = proyectoDtoBindingSource;
            // 
            // ProyectoEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 442);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ProyectoEdit.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProyectoEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del Proyecto";
            Load += ProyectoEdit_Load;
            Controls.SetChildIndex(stackPanelFooter, 0);
            Controls.SetChildIndex(layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).EndInit();
            stackPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCodigoProyecto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)proyectoDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescripcion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFechInicio.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFechInicio.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFechaFin.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFechaFin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtClienteDescripcion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigoProyecto;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private DevExpress.XtraEditors.DateEdit txtFechInicio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit txtFechaFin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarCliente;
        private DevExpress.XtraEditors.TextEdit txtClienteDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource proyectoDtoBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}