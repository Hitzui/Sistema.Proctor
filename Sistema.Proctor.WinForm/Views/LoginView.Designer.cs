namespace Sistema.Proctor.WinForm.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.UITemplates.Collection.Editors.PasswordBox();
            txtEmail = new DevExpress.UITemplates.Collection.Editors.EmailBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnIngresar = new DevExpress.XtraEditors.SimpleButton();
            btnSalir = new DevExpress.XtraEditors.SimpleButton();
            errorProvider1 = new ErrorProvider(components);
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = Color.DarkRed;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(98, 212);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(230, 33);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "INICIAR SESIÓN";
            // 
            // txtPassword
            // 
            txtPassword.EditorSize = DevExpress.XtraEditors.Internal.HtmlTextBoxBase.EditSize.Large;
            txtPassword.EnterMoveNextControl = true;
            txtPassword.Location = new Point(41, 403);
            txtPassword.Name = "txtPassword";
            txtPassword.Placeholder = "Ingrese contraseña";
            txtPassword.Size = new Size(340, 30);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.EditorSize = DevExpress.XtraEditors.Internal.HtmlTextBoxBase.EditSize.Large;
            txtEmail.EnterMoveNextControl = true;
            txtEmail.Location = new Point(41, 301);
            txtEmail.Name = "txtEmail";
            txtEmail.Placeholder = "Ingrese correo electrónico";
            txtEmail.Size = new Size(340, 30);
            txtEmail.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10F);
            labelControl2.Appearance.ForeColor = Color.DimGray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(41, 279);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(36, 16);
            labelControl2.TabIndex = 5;
            labelControl2.Text = "E-mail";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10F);
            labelControl3.Appearance.ForeColor = Color.DimGray;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(41, 381);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(65, 16);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            btnIngresar.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnIngresar.Appearance.Options.UseBackColor = true;
            btnIngresar.Appearance.Options.UseFont = true;
            btnIngresar.Location = new Point(41, 487);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(339, 36);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnSalir.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSalir.Appearance.Options.UseBackColor = true;
            btnSalir.Appearance.Options.UseFont = true;
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(41, 549);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(339, 36);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pictureBox1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(txtEmail);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(txtPassword);
            panelControl1.Controls.Add(btnIngresar);
            panelControl1.Controls.Add(btnSalir);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(443, 627);
            panelControl1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.BorderColor = Color.Black;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseBorderColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(443, 627);
            ControlBox = false;
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.None;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("LoginView.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.UITemplates.Collection.Editors.PasswordBox txtPassword;
        private DevExpress.UITemplates.Collection.Editors.EmailBox txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnIngresar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private ErrorProvider errorProvider1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private PictureBox pictureBox1;
    }
}