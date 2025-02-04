namespace Sistema.Proctor.WinForm.Views.Empleado
{
    partial class EmpleadoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoEdit));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            empleadoDtoBindingSource = new BindingSource(components);
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            textEdit4 = new DevExpress.XtraEditors.MemoEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit3);
            layoutControl1.Controls.Add(dateEdit1);
            layoutControl1.Controls.Add(textEdit4);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(633, 301);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", empleadoDtoBindingSource, "Nombre", true));
            textEdit1.Location = new Point(100, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(521, 20);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // empleadoDtoBindingSource
            // 
            empleadoDtoBindingSource.DataSource = typeof(Dto.EmpleadoDto);
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", empleadoDtoBindingSource, "Apellido", true));
            textEdit2.Location = new Point(100, 36);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(521, 20);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("EditValue", empleadoDtoBindingSource, "Cedula", true));
            textEdit3.Location = new Point(100, 60);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(521, 20);
            textEdit3.StyleController = layoutControl1;
            textEdit3.TabIndex = 6;
            // 
            // dateEdit1
            // 
            dateEdit1.DataBindings.Add(new Binding("EditValue", empleadoDtoBindingSource, "FNacimiento", true));
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(100, 269);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(521, 20);
            dateEdit1.StyleController = layoutControl1;
            dateEdit1.TabIndex = 8;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", empleadoDtoBindingSource, "Direccion", true));
            textEdit4.Location = new Point(100, 84);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(521, 181);
            textEdit4.StyleController = layoutControl1;
            textEdit4.TabIndex = 7;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5 });
            Root.Name = "Root";
            Root.Size = new Size(633, 301);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(613, 24);
            layoutControlItem1.Text = "Nombres";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(613, 24);
            layoutControlItem2.Text = "Apellidos";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textEdit3;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(613, 24);
            layoutControlItem3.Text = "Cedula";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textEdit4;
            layoutControlItem4.Location = new Point(0, 72);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(613, 185);
            layoutControlItem4.Text = "Direccion";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = dateEdit1;
            layoutControlItem5.Location = new Point(0, 257);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(613, 24);
            layoutControlItem5.Text = "Fecha Nacimiento";
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            dxErrorProvider.DataSource = empleadoDtoBindingSource;
            // 
            // EmpleadoEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 378);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmpleadoEdit.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Empleado";
            Load += EmpleadoEdit_Load;
            Controls.SetChildIndex(layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private BindingSource empleadoDtoBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.MemoEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}