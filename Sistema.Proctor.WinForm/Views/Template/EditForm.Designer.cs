namespace Sistema.Proctor.WinForm.Views.Template
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(btnCancelar);
            stackPanel1.Controls.Add(btnGuardar);
            stackPanel1.Dock = DockStyle.Bottom;
            stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            stackPanel1.Location = new Point(0, 353);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(676, 77);
            stackPanel1.TabIndex = 2;
            stackPanel1.UseSkinIndents = true;
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
            btnCancelar.Location = new Point(499, 22);
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
            btnGuardar.Location = new Point(330, 22);
            btnGuardar.Margin = new Padding(3, 3, 50, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 32);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 430);
            Controls.Add(stackPanel1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}