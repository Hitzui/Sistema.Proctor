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
            treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            treeListEnsayos = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).BeginInit();
            SuspendLayout();
            // 
            // treeListBand1
            // 
            treeListBand1.Caption = "treeListBand1";
            treeListBand1.Name = "treeListBand1";
            // 
            // treeListEnsayos
            // 
            treeListEnsayos.Location = new Point(0, 0);
            treeListEnsayos.Name = "treeListEnsayos";
            treeListEnsayos.OptionsBehavior.ReadOnly = true;
            treeListEnsayos.Size = new Size(400, 649);
            treeListEnsayos.TabIndex = 1;
            treeListEnsayos.FocusedNodeChanged += treeListEnsayos_FocusedNodeChanged;
            // 
            // EnsayosProyecto
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 647);
            Controls.Add(treeListEnsayos);
            Name = "EnsayosProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnsayosProyecto";
            WindowState = FormWindowState.Maximized;
            FormClosed += EnsayosProyecto_FormClosed;
            Load += EnsayosProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)treeListEnsayos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.TreeList treeListEnsayos;
    }
}