namespace Sistema.Proctor.WinForm.Views.Proyecto.Proctor
{
    partial class ProctorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textEdit1 = new DevExpress.XtraEditors.DateEdit();
            ensayoProctorBindingSource = new BindingSource(components);
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            textEdit6 = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            txtDiametroMoldeCm = new DevExpress.XtraEditors.TextEdit();
            txtAlturaMoldeCm = new DevExpress.XtraEditors.TextEdit();
            textEdit8 = new DevExpress.XtraEditors.TextEdit();
            textEdit9 = new DevExpress.XtraEditors.TextEdit();
            textEdit10 = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            tabResultadosProctor = new DevExpress.XtraTab.XtraTabControl();
            tabPageGrafico = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ensayoProctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiametroMoldeCm.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlturaMoldeCm.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit8.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit9.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit10.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabResultadosProctor).BeginInit();
            tabResultadosProctor.SuspendLayout();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            tablePanel1.SetColumn(layoutControl1, 0);
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit4);
            layoutControl1.Controls.Add(textEdit5);
            layoutControl1.Controls.Add(textEdit6);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(17, 16);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            tablePanel1.SetRow(layoutControl1, 0);
            layoutControl1.Size = new Size(491, 208);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "FechaEnsayo", true));
            textEdit1.EditValue = null;
            textEdit1.Location = new Point(155, 16);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit1.Properties.DisplayFormat.FormatString = "";
            textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            textEdit1.Properties.EditFormat.FormatString = "";
            textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            textEdit1.Properties.MaskSettings.Set("mask", "");
            textEdit1.Size = new Size(320, 28);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // ensayoProctorBindingSource
            // 
            ensayoProctorBindingSource.DataSource = typeof(Sistema.Proctor.Data.Entities.EnsayoProctor);
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "MetodoUtilizado", true));
            textEdit2.Location = new Point(155, 50);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(320, 28);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "PesoMartilloLb", true));
            textEdit4.Location = new Point(155, 84);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(320, 28);
            textEdit4.StyleController = layoutControl1;
            textEdit4.TabIndex = 6;
            // 
            // textEdit5
            // 
            textEdit5.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "PesoMaterialG", true));
            textEdit5.Location = new Point(155, 118);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(320, 28);
            textEdit5.StyleController = layoutControl1;
            textEdit5.TabIndex = 7;
            // 
            // textEdit6
            // 
            textEdit6.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "TemperaturaSecado", true));
            textEdit6.Location = new Point(155, 152);
            textEdit6.Name = "textEdit6";
            textEdit6.Size = new Size(320, 28);
            textEdit6.StyleController = layoutControl1;
            textEdit6.TabIndex = 8;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem5, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new Size(491, 208);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(465, 34);
            layoutControlItem1.Text = "Fecha Ensayo";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 34);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(465, 34);
            layoutControlItem2.Text = "Método utilizado";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textEdit4;
            layoutControlItem3.Location = new Point(0, 68);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(465, 34);
            layoutControlItem3.Text = "Peso Martillo (lb)";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textEdit5;
            layoutControlItem5.Location = new Point(0, 102);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(465, 34);
            layoutControlItem5.Text = "Peso del Material (g)";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = textEdit6;
            layoutControlItem6.Location = new Point(0, 136);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(465, 46);
            layoutControlItem6.Text = "Temperatura Secado (°C)";
            // 
            // layoutControl2
            // 
            tablePanel1.SetColumn(layoutControl2, 1);
            layoutControl2.Controls.Add(txtDiametroMoldeCm);
            layoutControl2.Controls.Add(txtAlturaMoldeCm);
            layoutControl2.Controls.Add(textEdit8);
            layoutControl2.Controls.Add(textEdit9);
            layoutControl2.Controls.Add(textEdit10);
            layoutControl2.Dock = DockStyle.Fill;
            layoutControl2.Location = new Point(514, 16);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            tablePanel1.SetRow(layoutControl2, 0);
            layoutControl2.Size = new Size(491, 208);
            layoutControl2.TabIndex = 1;
            layoutControl2.Text = "layoutControl2";
            // 
            // txtDiametroMoldeCm
            // 
            txtDiametroMoldeCm.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "DiametroMoldeCm", true));
            txtDiametroMoldeCm.Location = new Point(130, 16);
            txtDiametroMoldeCm.Name = "txtDiametroMoldeCm";
            txtDiametroMoldeCm.Size = new Size(345, 28);
            txtDiametroMoldeCm.StyleController = layoutControl2;
            txtDiametroMoldeCm.TabIndex = 4;
            txtDiametroMoldeCm.EditValueChanged += txtDiametroMoldeCm_EditValueChanged;
            // 
            // txtAlturaMoldeCm
            // 
            txtAlturaMoldeCm.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "AlturaMoldeCm", true));
            txtAlturaMoldeCm.Location = new Point(130, 50);
            txtAlturaMoldeCm.Name = "txtAlturaMoldeCm";
            txtAlturaMoldeCm.Size = new Size(345, 28);
            txtAlturaMoldeCm.StyleController = layoutControl2;
            txtAlturaMoldeCm.TabIndex = 5;
            // 
            // textEdit8
            // 
            textEdit8.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "NumCapas", true));
            textEdit8.Location = new Point(130, 84);
            textEdit8.Name = "textEdit8";
            textEdit8.Size = new Size(345, 28);
            textEdit8.StyleController = layoutControl2;
            textEdit8.TabIndex = 6;
            // 
            // textEdit9
            // 
            textEdit9.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "NumGolpes", true));
            textEdit9.Location = new Point(130, 118);
            textEdit9.Name = "textEdit9";
            textEdit9.Size = new Size(345, 28);
            textEdit9.StyleController = layoutControl2;
            textEdit9.TabIndex = 7;
            // 
            // textEdit10
            // 
            textEdit10.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "TipoProctor", true));
            textEdit10.Location = new Point(130, 152);
            textEdit10.Name = "textEdit10";
            textEdit10.Size = new Size(345, 28);
            textEdit10.StyleController = layoutControl2;
            textEdit10.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem7, layoutControlItem8, layoutControlItem9, layoutControlItem10 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(491, 208);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtDiametroMoldeCm;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(465, 34);
            layoutControlItem4.Text = "Diametro Molde (cm)";
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = txtAlturaMoldeCm;
            layoutControlItem7.Location = new Point(0, 34);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(465, 34);
            layoutControlItem7.Text = "Altura Molde (cm)";
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = textEdit8;
            layoutControlItem8.Location = new Point(0, 68);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(465, 34);
            layoutControlItem8.Text = "No. de Capas";
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = textEdit9;
            layoutControlItem9.Location = new Point(0, 102);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(465, 34);
            layoutControlItem9.Text = "No Capas/Golpes";
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = textEdit10;
            layoutControlItem10.Location = new Point(0, 136);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(465, 46);
            layoutControlItem10.Text = "Proctor";
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel1.Controls.Add(layoutControl2);
            tablePanel1.Controls.Add(layoutControl1);
            tablePanel1.Dock = DockStyle.Top;
            tablePanel1.Location = new Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
            tablePanel1.Size = new Size(1022, 241);
            tablePanel1.TabIndex = 2;
            tablePanel1.UseSkinIndents = true;
            // 
            // tabResultadosProctor
            // 
            tabResultadosProctor.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            tabResultadosProctor.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] { new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            tabResultadosProctor.Dock = DockStyle.Fill;
            tabResultadosProctor.Location = new Point(0, 241);
            tabResultadosProctor.Name = "tabResultadosProctor";
            tabResultadosProctor.SelectedTabPage = tabPageGrafico;
            tabResultadosProctor.Size = new Size(1022, 377);
            tabResultadosProctor.TabIndex = 3;
            tabResultadosProctor.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabPageGrafico });
            tabResultadosProctor.CloseButtonClick += tabResultadosProctor_CloseButtonClick;
            tabResultadosProctor.CustomHeaderButtonClick += tabResultadosProctor_CustomHeaderButtonClick;
            // 
            // tabPageGrafico
            // 
            tabPageGrafico.Name = "tabPageGrafico";
            tabPageGrafico.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            tabPageGrafico.Size = new Size(1020, 346);
            tabPageGrafico.Text = "Grafico";
            // 
            // ProctorControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabResultadosProctor);
            Controls.Add(tablePanel1);
            Name = "ProctorControl";
            Size = new Size(1022, 618);
            Load += ProctorControl_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ensayoProctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDiametroMoldeCm.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlturaMoldeCm.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit8.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit9.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit10.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabResultadosProctor).EndInit();
            tabResultadosProctor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtDiametroMoldeCm;
        private DevExpress.XtraEditors.TextEdit txtAlturaMoldeCm;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraTab.XtraTabControl tabResultadosProctor;
        private BindingSource ensayoProctorBindingSource;
        private DevExpress.XtraTab.XtraTabPage tabPageGrafico;
    }
}
