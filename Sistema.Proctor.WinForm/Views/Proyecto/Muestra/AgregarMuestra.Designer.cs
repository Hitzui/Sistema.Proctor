namespace Sistema.Proctor.WinForm.Views.Proyecto.Muestra
{
    partial class AgregarMuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMuestra));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            muestraDtoBindingSource = new BindingSource(components);
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            textEdit6 = new DevExpress.XtraEditors.TextEdit();
            textEdit7 = new DevExpress.XtraEditors.TextEdit();
            txtEmpleadoNombre = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            btnSeleccionarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)muestraDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit7.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpleadoNombre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit3);
            layoutControl1.Controls.Add(textEdit4);
            layoutControl1.Controls.Add(textEdit5);
            layoutControl1.Controls.Add(textEdit6);
            layoutControl1.Controls.Add(textEdit7);
            layoutControl1.Controls.Add(txtEmpleadoNombre);
            layoutControl1.Controls.Add(dateEdit1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(757, 389);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "CodigoIngreso", true));
            textEdit1.EnterMoveNextControl = true;
            textEdit1.Location = new Point(144, 16);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(597, 28);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // muestraDtoBindingSource
            // 
            muestraDtoBindingSource.DataSource = typeof(Dto.MuestraDto);
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "SondeoNumero", true));
            textEdit2.EnterMoveNextControl = true;
            textEdit2.Location = new Point(144, 50);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(597, 28);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "MuestraNumero", true));
            textEdit3.EnterMoveNextControl = true;
            textEdit3.Location = new Point(144, 84);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(597, 28);
            textEdit3.StyleController = layoutControl1;
            textEdit3.TabIndex = 6;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "Coordenadas", true));
            textEdit4.EnterMoveNextControl = true;
            textEdit4.Location = new Point(144, 118);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(597, 28);
            textEdit4.StyleController = layoutControl1;
            textEdit4.TabIndex = 7;
            // 
            // textEdit5
            // 
            textEdit5.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "CoordeandasZ", true));
            textEdit5.EnterMoveNextControl = true;
            textEdit5.Location = new Point(144, 152);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(597, 28);
            textEdit5.StyleController = layoutControl1;
            textEdit5.TabIndex = 8;
            // 
            // textEdit6
            // 
            textEdit6.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "DescripcionMaterial", true));
            textEdit6.EnterMoveNextControl = true;
            textEdit6.Location = new Point(144, 186);
            textEdit6.Name = "textEdit6";
            textEdit6.Size = new Size(597, 28);
            textEdit6.StyleController = layoutControl1;
            textEdit6.TabIndex = 9;
            // 
            // textEdit7
            // 
            textEdit7.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "LadoBanda", true));
            textEdit7.EnterMoveNextControl = true;
            textEdit7.Location = new Point(144, 220);
            textEdit7.Name = "textEdit7";
            textEdit7.Size = new Size(597, 28);
            textEdit7.StyleController = layoutControl1;
            textEdit7.TabIndex = 10;
            // 
            // txtEmpleadoNombre
            // 
            txtEmpleadoNombre.EnterMoveNextControl = true;
            txtEmpleadoNombre.Location = new Point(144, 254);
            txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            txtEmpleadoNombre.Properties.ReadOnly = true;
            txtEmpleadoNombre.Size = new Size(597, 28);
            txtEmpleadoNombre.StyleController = layoutControl1;
            txtEmpleadoNombre.TabIndex = 11;
            // 
            // dateEdit1
            // 
            dateEdit1.DataBindings.Add(new Binding("EditValue", muestraDtoBindingSource, "FechaEnsayo", true));
            dateEdit1.EditValue = null;
            dateEdit1.EnterMoveNextControl = true;
            dateEdit1.Location = new Point(144, 288);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(597, 28);
            dateEdit1.StyleController = layoutControl1;
            dateEdit1.TabIndex = 12;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8, layoutControlItem9 });
            Root.Name = "Root";
            Root.Size = new Size(757, 389);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(731, 34);
            layoutControlItem1.Text = "Código de ingreso";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 34);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(731, 34);
            layoutControlItem2.Text = "Número de Sondeo";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textEdit3;
            layoutControlItem3.Location = new Point(0, 68);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(731, 34);
            layoutControlItem3.Text = "Número de muestra";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textEdit4;
            layoutControlItem4.Location = new Point(0, 102);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(731, 34);
            layoutControlItem4.Text = "Coordenadas";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textEdit5;
            layoutControlItem5.Location = new Point(0, 136);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(731, 34);
            layoutControlItem5.Text = "Coordenadas Z";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = textEdit6;
            layoutControlItem6.Location = new Point(0, 170);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(731, 34);
            layoutControlItem6.Text = "Descripción del material";
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = textEdit7;
            layoutControlItem7.Location = new Point(0, 204);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(731, 34);
            layoutControlItem7.Text = "Lado de Banda";
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = txtEmpleadoNombre;
            layoutControlItem8.Location = new Point(0, 238);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(731, 34);
            layoutControlItem8.Text = "Empleado";
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = dateEdit1;
            layoutControlItem9.Location = new Point(0, 272);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(731, 91);
            layoutControlItem9.Text = "Fecha del Ensayo";
            // 
            // stackPanel1
            // 
            stackPanel1.AutoSize = true;
            stackPanel1.Controls.Add(simpleButton3);
            stackPanel1.Controls.Add(btnGuardar);
            stackPanel1.Controls.Add(btnSeleccionarEmpleado);
            stackPanel1.Dock = DockStyle.Bottom;
            stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            stackPanel1.Location = new Point(0, 389);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Padding = new Padding(2);
            stackPanel1.Size = new Size(757, 44);
            stackPanel1.TabIndex = 1;
            stackPanel1.UseSkinIndents = true;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButton3.Appearance.ForeColor = Color.White;
            simpleButton3.Appearance.Options.UseBackColor = true;
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.DialogResult = DialogResult.Cancel;
            simpleButton3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            simpleButton3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton3.ImageOptions.SvgImage");
            simpleButton3.Location = new Point(628, 5);
            simpleButton3.Margin = new Padding(3, 3, 20, 3);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(107, 34);
            simpleButton3.TabIndex = 2;
            simpleButton3.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            btnGuardar.ImageOptions.SvgImageSize = new Size(30, 30);
            btnGuardar.Location = new Point(487, 5);
            btnGuardar.Margin = new Padding(3, 3, 20, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSeleccionarEmpleado
            // 
            btnSeleccionarEmpleado.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            btnSeleccionarEmpleado.Appearance.ForeColor = Color.White;
            btnSeleccionarEmpleado.Appearance.Options.UseBackColor = true;
            btnSeleccionarEmpleado.Appearance.Options.UseForeColor = true;
            btnSeleccionarEmpleado.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnSeleccionarEmpleado.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSeleccionarEmpleado.ImageOptions.SvgImage");
            btnSeleccionarEmpleado.ImageOptions.SvgImageSize = new Size(30, 30);
            btnSeleccionarEmpleado.Location = new Point(294, 5);
            btnSeleccionarEmpleado.Margin = new Padding(3, 3, 20, 3);
            btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            btnSeleccionarEmpleado.Size = new Size(170, 34);
            btnSeleccionarEmpleado.TabIndex = 0;
            btnSeleccionarEmpleado.Text = "Seleccionar Empleado";
            btnSeleccionarEmpleado.Click += btnSeleccionarEmpleado_Click;
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            dxErrorProvider.DataSource = muestraDtoBindingSource;
            // 
            // AgregarMuestra
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 433);
            Controls.Add(layoutControl1);
            Controls.Add(stackPanel1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("AgregarMuestra.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarMuestra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Muestra";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)muestraDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit7.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpleadoNombre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit txtEmpleadoNombre;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarEmpleado;
        private BindingSource muestraDtoBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}