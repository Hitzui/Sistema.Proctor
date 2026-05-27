namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    partial class EnsayosProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnsayosProyecto));
            treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            treeListEnsayos = new DevExpress.XtraTreeList.TreeList();
            popupMenuEnsayos = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemVerEnsayo = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Sistema.Proctor.WinForm.Views.Cliente.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuEnsayos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // treeListBand1
            // 
            treeListBand1.Caption = "treeListBand1";
            treeListBand1.Name = "treeListBand1";
            // 
            // treeListEnsayos
            // 
            treeListEnsayos.Caption = "Proyectos";
            treeListEnsayos.CaptionHeight = 15;
            treeListEnsayos.Location = new System.Drawing.Point(0, 0);
            treeListEnsayos.Name = "treeListEnsayos";
            treeListEnsayos.OptionsBehavior.ReadOnly = true;
            treeListEnsayos.OptionsSelection.SelectNodesOnRightClick = true;
            treeListEnsayos.Size = new System.Drawing.Size(400, 649);
            treeListEnsayos.TabIndex = 1;
            treeListEnsayos.FocusedNodeChanged += treeListEnsayos_FocusedNodeChanged;
            treeListEnsayos.PopupMenuShowing += treeListEnsayos_PopupMenuShowing;
            // 
            // popupMenuEnsayos
            // 
            popupMenuEnsayos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemVerEnsayo) });
            popupMenuEnsayos.Manager = barManager1;
            popupMenuEnsayos.Name = "popupMenuEnsayos";
            // 
            // barButtonItemVerEnsayo
            // 
            barButtonItemVerEnsayo.Caption = "Abrir Ensayo";
            barButtonItemVerEnsayo.Id = 0;
            barButtonItemVerEnsayo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemVerEnsayo.ImageOptions.SvgImage"));
            barButtonItemVerEnsayo.Name = "barButtonItemVerEnsayo";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemVerEnsayo });
            barManager1.MaxItemId = 1;
            barManager1.ItemClick += barManager1_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(1089, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(1089, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 645);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1089, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 645);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // EnsayosProyecto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1089, 645);
            Controls.Add(treeListEnsayos);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EnsayosProyecto";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosed += EnsayosProyecto_FormClosed;
            Load += EnsayosProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuEnsayos).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        public DevExpress.XtraTreeList.TreeList treeListEnsayos;
        private DevExpress.XtraBars.PopupMenu popupMenuEnsayos;
        private DevExpress.XtraBars.BarButtonItem barButtonItemVerEnsayo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}