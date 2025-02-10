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
            DevExpress.Utils.Animation.DissolveTransition dissolveTransition1 = new DevExpress.Utils.Animation.DissolveTransition();
            treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            treeListEnsayos = new DevExpress.XtraTreeList.TreeList();
            xtraTabControlEnsayos = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlEnsayos).BeginInit();
            xtraTabControlEnsayos.SuspendLayout();
            SuspendLayout();
            // 
            // treeListBand1
            // 
            treeListBand1.Caption = "treeListBand1";
            treeListBand1.Name = "treeListBand1";
            // 
            // treeListEnsayos
            // 
            treeListEnsayos.Dock = DockStyle.Left;
            treeListEnsayos.Location = new Point(0, 0);
            treeListEnsayos.Name = "treeListEnsayos";
            treeListEnsayos.OptionsBehavior.ReadOnly = true;
            treeListEnsayos.Size = new Size(400, 651);
            treeListEnsayos.TabIndex = 0;
            treeListEnsayos.FocusedNodeChanged += treeListEnsayos_FocusedNodeChanged;
            // 
            // xtraTabControlEnsayos
            // 
            xtraTabControlEnsayos.Dock = DockStyle.Fill;
            xtraTabControlEnsayos.Location = new Point(400, 0);
            xtraTabControlEnsayos.Name = "xtraTabControlEnsayos";
            xtraTabControlEnsayos.SelectedTabPage = xtraTabPage1;
            xtraTabControlEnsayos.Size = new Size(689, 651);
            xtraTabControlEnsayos.TabIndex = 1;
            xtraTabControlEnsayos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1 });
            xtraTabControlEnsayos.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControlEnsayos.Transition.TransitionType = dissolveTransition1;
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            xtraTabPage1.Size = new Size(687, 620);
            xtraTabPage1.Text = "xtraTabPage1";
            // 
            // EnsayosProyecto
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 651);
            Controls.Add(xtraTabControlEnsayos);
            Controls.Add(treeListEnsayos);
            Name = "EnsayosProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnsayosProyecto";
            WindowState = FormWindowState.Maximized;
            FormClosed += EnsayosProyecto_FormClosed;
            Load += EnsayosProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlEnsayos).EndInit();
            xtraTabControlEnsayos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.TreeList treeListEnsayos;
        public DevExpress.XtraTab.XtraTabControl xtraTabControlEnsayos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}