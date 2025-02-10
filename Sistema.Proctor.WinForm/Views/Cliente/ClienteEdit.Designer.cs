namespace Sistema.Proctor.WinForm.Views.Cliente
{
    partial class ClienteEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteEdit));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            clienteBindingSource = new BindingSource(components);
            txtNombreAbreviado = new DevExpress.XtraEditors.TextEdit();
            txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtTelefono = new DevExpress.XtraEditors.TextEdit();
            txtCelular = new DevExpress.XtraEditors.TextEdit();
            txtCiudad = new DevExpress.XtraEditors.TextEdit();
            txtDepartamento = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
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
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNombreComercial.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNombreAbreviado.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDireccion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefono.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCelular.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCiudad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartamento.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtNombreComercial);
            layoutControl1.Controls.Add(txtNombreAbreviado);
            layoutControl1.Controls.Add(txtDireccion);
            layoutControl1.Controls.Add(txtEmail);
            layoutControl1.Controls.Add(txtTelefono);
            layoutControl1.Controls.Add(txtCelular);
            layoutControl1.Controls.Add(txtCiudad);
            layoutControl1.Controls.Add(txtDepartamento);
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Font = new Font("Tahoma", 9F);
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(638, 419);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "NombreComercial", true));
            txtNombreComercial.EnterMoveNextControl = true;
            txtNombreComercial.Location = new Point(122, 12);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtNombreComercial.Properties.Appearance.Options.UseFont = true;
            txtNombreComercial.Size = new Size(504, 20);
            txtNombreComercial.StyleController = layoutControl1;
            txtNombreComercial.TabIndex = 4;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Proctor.Data.Entities.Cliente);
            // 
            // txtNombreAbreviado
            // 
            txtNombreAbreviado.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "NombreAbreviado", true));
            txtNombreAbreviado.EnterMoveNextControl = true;
            txtNombreAbreviado.Location = new Point(122, 36);
            txtNombreAbreviado.Name = "txtNombreAbreviado";
            txtNombreAbreviado.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtNombreAbreviado.Properties.Appearance.Options.UseFont = true;
            txtNombreAbreviado.Size = new Size(504, 20);
            txtNombreAbreviado.StyleController = layoutControl1;
            txtNombreAbreviado.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Direccion", true));
            txtDireccion.EnterMoveNextControl = true;
            txtDireccion.Location = new Point(122, 60);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtDireccion.Properties.Appearance.Options.UseFont = true;
            txtDireccion.Size = new Size(504, 179);
            txtDireccion.StyleController = layoutControl1;
            txtDireccion.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Email", true));
            txtEmail.EnterMoveNextControl = true;
            txtEmail.Location = new Point(122, 243);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new Size(504, 20);
            txtEmail.StyleController = layoutControl1;
            txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Telefono", true));
            txtTelefono.EnterMoveNextControl = true;
            txtTelefono.Location = new Point(122, 267);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtTelefono.Properties.Appearance.Options.UseFont = true;
            txtTelefono.Size = new Size(504, 20);
            txtTelefono.StyleController = layoutControl1;
            txtTelefono.TabIndex = 8;
            // 
            // txtCelular
            // 
            txtCelular.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Celular", true));
            txtCelular.EnterMoveNextControl = true;
            txtCelular.Location = new Point(122, 291);
            txtCelular.Name = "txtCelular";
            txtCelular.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtCelular.Properties.Appearance.Options.UseFont = true;
            txtCelular.Size = new Size(504, 20);
            txtCelular.StyleController = layoutControl1;
            txtCelular.TabIndex = 9;
            // 
            // txtCiudad
            // 
            txtCiudad.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Ciudad", true));
            txtCiudad.EnterMoveNextControl = true;
            txtCiudad.Location = new Point(122, 315);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtCiudad.Properties.Appearance.Options.UseFont = true;
            txtCiudad.Size = new Size(504, 20);
            txtCiudad.StyleController = layoutControl1;
            txtCiudad.TabIndex = 10;
            // 
            // txtDepartamento
            // 
            txtDepartamento.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Departamento", true));
            txtDepartamento.EnterMoveNextControl = true;
            txtDepartamento.Location = new Point(122, 339);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Properties.Appearance.Font = new Font("Tahoma", 9F);
            txtDepartamento.Properties.Appearance.Options.UseFont = true;
            txtDepartamento.Size = new Size(504, 20);
            txtDepartamento.StyleController = layoutControl1;
            txtDepartamento.TabIndex = 11;
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Ruc", true));
            textEdit1.EnterMoveNextControl = true;
            textEdit1.Location = new Point(122, 363);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 9F);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(504, 20);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 12;
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", clienteBindingSource, "Contacto", true));
            textEdit2.EnterMoveNextControl = true;
            textEdit2.Location = new Point(122, 387);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 9F);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(504, 20);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 13;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8, layoutControlItem9, layoutControlItem10 });
            Root.Name = "Root";
            Root.Size = new Size(638, 419);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.Control = txtNombreComercial;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(618, 24);
            layoutControlItem1.Text = "Nombre Comercial";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.Control = txtNombreAbreviado;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(618, 24);
            layoutControlItem2.Text = "Nombre Abreviado";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem3.Control = txtDireccion;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(618, 183);
            layoutControlItem3.Text = "Dirección";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.Control = txtEmail;
            layoutControlItem4.Location = new Point(0, 231);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(618, 24);
            layoutControlItem4.Text = "E-mail";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem5.Control = txtTelefono;
            layoutControlItem5.Location = new Point(0, 255);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(618, 24);
            layoutControlItem5.Text = "Teléfono";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.Control = txtCelular;
            layoutControlItem6.Location = new Point(0, 279);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(618, 24);
            layoutControlItem6.Text = "Celular";
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem7.Control = txtCiudad;
            layoutControlItem7.Location = new Point(0, 303);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(618, 24);
            layoutControlItem7.Text = "Ciudad";
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem8.Control = txtDepartamento;
            layoutControlItem8.Location = new Point(0, 327);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(618, 24);
            layoutControlItem8.Text = "Departamento";
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem9.Control = textEdit1;
            layoutControlItem9.Location = new Point(0, 351);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(618, 24);
            layoutControlItem9.Text = "Cedula o RUC";
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.AppearanceItemCaption.Font = new Font("Tahoma", 9.5F);
            layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem10.Control = textEdit2;
            layoutControlItem10.Location = new Point(0, 375);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(618, 24);
            layoutControlItem10.Text = "Contacto";
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnCancelar.Appearance.ForeColor = Color.White;
            btnCancelar.Appearance.Options.UseBackColor = true;
            btnCancelar.Appearance.Options.UseForeColor = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnCancelar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancelar.ImageOptions.SvgImage");
            btnCancelar.Location = new Point(461, 22);
            btnCancelar.Margin = new Padding(3, 3, 50, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnGuardar.Appearance.ForeColor = Color.White;
            btnGuardar.Appearance.Options.UseBackColor = true;
            btnGuardar.Appearance.Options.UseForeColor = true;
            btnGuardar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            btnGuardar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuardar.ImageOptions.SvgImage");
            btnGuardar.Location = new Point(292, 22);
            btnGuardar.Margin = new Padding(3, 3, 50, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 32);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dxErrorProvider1
            // 
            dxErrorProvider1.ContainerControl = this;
            dxErrorProvider1.DataSource = clienteBindingSource;
            // 
            // ClienteEdit
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 496);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ClienteEdit.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteEdit";
            Text = "Datos del Cliente";
            Load += ClienteEdit_Load;
            Controls.SetChildIndex(layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtNombreComercial.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNombreAbreviado.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDireccion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefono.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCelular.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCiudad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartamento.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtNombreComercial;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtNombreAbreviado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtCiudad;
        private DevExpress.XtraEditors.TextEdit txtDepartamento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}