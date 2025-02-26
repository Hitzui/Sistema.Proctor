namespace Sistema.Proctor.WinForm.Views.Empresa
{
    partial class EmpresaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresaEdit));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            empresaDtoBindingSource = new BindingSource(components);
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            txtLogo = new DevExpress.XtraEditors.PictureEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).BeginInit();
            stackPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLogo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // stackPanelFooter
            // 
            stackPanelFooter.Location = new Point(0, 385);
            stackPanelFooter.Size = new Size(621, 77);
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancelar.Appearance.ForeColor = Color.White;
            btnCancelar.Appearance.Options.UseBackColor = true;
            btnCancelar.Appearance.Options.UseForeColor = true;
            btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnCancelar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancelar.ImageOptions.SvgImage");
            btnCancelar.Location = new Point(444, 22);
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuardar.ImageOptions.SvgImage");
            btnGuardar.Location = new Point(275, 22);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit3);
            layoutControl1.Controls.Add(textEdit4);
            layoutControl1.Controls.Add(textEdit5);
            layoutControl1.Controls.Add(memoEdit1);
            layoutControl1.Controls.Add(txtLogo);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(621, 385);
            layoutControl1.TabIndex = 3;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "NombreComercial", true));
            textEdit1.Location = new Point(113, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(496, 22);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // empresaDtoBindingSource
            // 
            empresaDtoBindingSource.DataSource = typeof(Dto.EmpresaDto);
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "NombreAbreviado", true));
            textEdit2.Location = new Point(113, 38);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(496, 22);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "Telefono", true));
            textEdit3.Location = new Point(113, 64);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(496, 22);
            textEdit3.StyleController = layoutControl1;
            textEdit3.TabIndex = 6;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "Celular", true));
            textEdit4.Location = new Point(113, 90);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(496, 22);
            textEdit4.StyleController = layoutControl1;
            textEdit4.TabIndex = 7;
            // 
            // textEdit5
            // 
            textEdit5.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "Representante", true));
            textEdit5.Location = new Point(113, 116);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(496, 22);
            textEdit5.StyleController = layoutControl1;
            textEdit5.TabIndex = 8;
            // 
            // memoEdit1
            // 
            memoEdit1.DataBindings.Add(new Binding("EditValue", empresaDtoBindingSource, "Direccion", true));
            memoEdit1.Location = new Point(113, 142);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(496, 114);
            memoEdit1.StyleController = layoutControl1;
            memoEdit1.TabIndex = 9;
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(113, 260);
            txtLogo.Name = "txtLogo";
            txtLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            txtLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            txtLogo.Size = new Size(496, 113);
            txtLogo.StyleController = layoutControl1;
            txtLogo.TabIndex = 10;
            txtLogo.ImageLoading += txtLogo_ImageLoading;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            Root.Name = "Root";
            Root.Size = new Size(621, 385);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(601, 26);
            layoutControlItem1.Text = "Nombre Comercial";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(601, 26);
            layoutControlItem2.Text = "Nombre Abreviado";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textEdit3;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(601, 26);
            layoutControlItem3.Text = "Telefono";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textEdit4;
            layoutControlItem4.Location = new Point(0, 78);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(601, 26);
            layoutControlItem4.Text = "Celular";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textEdit5;
            layoutControlItem5.Location = new Point(0, 104);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(601, 26);
            layoutControlItem5.Text = "Representante";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem6.Control = memoEdit1;
            layoutControlItem6.Location = new Point(0, 130);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(601, 118);
            layoutControlItem6.Text = "Dirección";
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem7.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem7.Control = txtLogo;
            layoutControlItem7.Location = new Point(0, 248);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(601, 117);
            layoutControlItem7.Text = "Logo";
            // 
            // dxErrorProvider1
            // 
            dxErrorProvider1.ContainerControl = this;
            // 
            // EmpresaEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 462);
            Controls.Add(layoutControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmpresaEdit.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpresaEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Empresa";
            Load += EmpresaEdit_Load;
            Controls.SetChildIndex(stackPanelFooter, 0);
            Controls.SetChildIndex(layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)stackPanelFooter).EndInit();
            stackPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLogo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BindingSource empresaDtoBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.PictureEdit txtLogo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}