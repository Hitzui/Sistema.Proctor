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
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            cmbPesoMartillo = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbTemperaturaSecado = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbNorma = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbMetotoUtilizado = new DevExpress.XtraEditors.ComboBoxEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            txtDiametroMoldeCm = new DevExpress.XtraEditors.TextEdit();
            txtAlturaMoldeCm = new DevExpress.XtraEditors.TextEdit();
            cmbNumeroCapas = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbGolpesPorCapa = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbTipoProctor = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            tabResultadosProctor = new DevExpress.XtraTab.XtraTabControl();
            tabPageGrafico = new DevExpress.XtraTab.XtraTabPage();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true, typeof(UserControl));
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ensayoProctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPesoMartillo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTemperaturaSecado.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbNorma.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbMetotoUtilizado.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiametroMoldeCm.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlturaMoldeCm.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbNumeroCapas.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbGolpesPorCapa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoProctor.Properties).BeginInit();
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
            layoutControl1.Controls.Add(textEdit5);
            layoutControl1.Controls.Add(cmbPesoMartillo);
            layoutControl1.Controls.Add(cmbTemperaturaSecado);
            layoutControl1.Controls.Add(cmbNorma);
            layoutControl1.Controls.Add(cmbMetotoUtilizado);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(13, 12);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            tablePanel1.SetRow(layoutControl1, 0);
            layoutControl1.Size = new Size(496, 216);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "FechaEnsayo", true));
            textEdit1.EditValue = null;
            textEdit1.Location = new Point(147, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit1.Properties.DisplayFormat.FormatString = "";
            textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            textEdit1.Properties.EditFormat.FormatString = "";
            textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            textEdit1.Properties.MaskSettings.Set("mask", "");
            textEdit1.Size = new Size(337, 22);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // ensayoProctorBindingSource
            // 
            ensayoProctorBindingSource.DataSource = typeof(Sistema.Proctor.Data.Entities.EnsayoProctor);
            // 
            // textEdit5
            // 
            textEdit5.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "PesoMaterialG", true));
            textEdit5.Location = new Point(147, 90);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(337, 22);
            textEdit5.StyleController = layoutControl1;
            textEdit5.TabIndex = 7;
            // 
            // cmbPesoMartillo
            // 
            cmbPesoMartillo.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "PesoMartilloLb", true));
            cmbPesoMartillo.Location = new Point(147, 64);
            cmbPesoMartillo.Name = "cmbPesoMartillo";
            cmbPesoMartillo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPesoMartillo.Size = new Size(337, 22);
            cmbPesoMartillo.StyleController = layoutControl1;
            cmbPesoMartillo.TabIndex = 6;
            // 
            // cmbTemperaturaSecado
            // 
            cmbTemperaturaSecado.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "TemperaturaSecado", true));
            cmbTemperaturaSecado.Location = new Point(147, 116);
            cmbTemperaturaSecado.Name = "cmbTemperaturaSecado";
            cmbTemperaturaSecado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTemperaturaSecado.Size = new Size(337, 22);
            cmbTemperaturaSecado.StyleController = layoutControl1;
            cmbTemperaturaSecado.TabIndex = 8;
            // 
            // cmbNorma
            // 
            cmbNorma.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "Norma", true));
            cmbNorma.Location = new Point(147, 142);
            cmbNorma.Name = "cmbNorma";
            cmbNorma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbNorma.Size = new Size(337, 22);
            cmbNorma.StyleController = layoutControl1;
            cmbNorma.TabIndex = 9;
            // 
            // cmbMetotoUtilizado
            // 
            cmbMetotoUtilizado.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "MetodoUtilizado", true));
            cmbMetotoUtilizado.Location = new Point(147, 38);
            cmbMetotoUtilizado.Name = "cmbMetotoUtilizado";
            cmbMetotoUtilizado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbMetotoUtilizado.Size = new Size(337, 22);
            cmbMetotoUtilizado.StyleController = layoutControl1;
            cmbMetotoUtilizado.TabIndex = 5;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem5, layoutControlItem6, layoutControlItem11 });
            Root.Name = "Root";
            Root.Size = new Size(496, 216);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(476, 26);
            layoutControlItem1.Text = "Fecha Ensayo";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = cmbMetotoUtilizado;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(476, 26);
            layoutControlItem2.Text = "Método utilizado";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = cmbPesoMartillo;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(476, 26);
            layoutControlItem3.Text = "Peso Martillo (lb)";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textEdit5;
            layoutControlItem5.Location = new Point(0, 78);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(476, 26);
            layoutControlItem5.Text = "Peso del Material (g)";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = cmbTemperaturaSecado;
            layoutControlItem6.Location = new Point(0, 104);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(476, 26);
            layoutControlItem6.Text = "Temperatura Secado (°C)";
            // 
            // layoutControlItem11
            // 
            layoutControlItem11.Control = cmbNorma;
            layoutControlItem11.Location = new Point(0, 130);
            layoutControlItem11.Name = "layoutControlItem11";
            layoutControlItem11.Size = new Size(476, 66);
            // 
            // layoutControl2
            // 
            tablePanel1.SetColumn(layoutControl2, 1);
            layoutControl2.Controls.Add(txtDiametroMoldeCm);
            layoutControl2.Controls.Add(txtAlturaMoldeCm);
            layoutControl2.Controls.Add(cmbNumeroCapas);
            layoutControl2.Controls.Add(cmbGolpesPorCapa);
            layoutControl2.Controls.Add(cmbTipoProctor);
            layoutControl2.Dock = DockStyle.Fill;
            layoutControl2.Location = new Point(513, 12);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            tablePanel1.SetRow(layoutControl2, 0);
            layoutControl2.Size = new Size(496, 216);
            layoutControl2.TabIndex = 1;
            layoutControl2.Text = "layoutControl2";
            // 
            // txtDiametroMoldeCm
            // 
            txtDiametroMoldeCm.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "DiametroMoldeCm", true));
            txtDiametroMoldeCm.Location = new Point(122, 12);
            txtDiametroMoldeCm.Name = "txtDiametroMoldeCm";
            txtDiametroMoldeCm.Size = new Size(362, 22);
            txtDiametroMoldeCm.StyleController = layoutControl2;
            txtDiametroMoldeCm.TabIndex = 4;
            txtDiametroMoldeCm.EditValueChanged += txtDiametroMoldeCm_EditValueChanged;
            // 
            // txtAlturaMoldeCm
            // 
            txtAlturaMoldeCm.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "AlturaMoldeCm", true));
            txtAlturaMoldeCm.Location = new Point(122, 38);
            txtAlturaMoldeCm.Name = "txtAlturaMoldeCm";
            txtAlturaMoldeCm.Size = new Size(362, 22);
            txtAlturaMoldeCm.StyleController = layoutControl2;
            txtAlturaMoldeCm.TabIndex = 5;
            // 
            // cmbNumeroCapas
            // 
            cmbNumeroCapas.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "NumCapas", true));
            cmbNumeroCapas.Location = new Point(122, 64);
            cmbNumeroCapas.Name = "cmbNumeroCapas";
            cmbNumeroCapas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbNumeroCapas.Size = new Size(362, 22);
            cmbNumeroCapas.StyleController = layoutControl2;
            cmbNumeroCapas.TabIndex = 6;
            // 
            // cmbGolpesPorCapa
            // 
            cmbGolpesPorCapa.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "NumGolpes", true));
            cmbGolpesPorCapa.Location = new Point(122, 90);
            cmbGolpesPorCapa.Name = "cmbGolpesPorCapa";
            cmbGolpesPorCapa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGolpesPorCapa.Size = new Size(362, 22);
            cmbGolpesPorCapa.StyleController = layoutControl2;
            cmbGolpesPorCapa.TabIndex = 7;
            // 
            // cmbTipoProctor
            // 
            cmbTipoProctor.DataBindings.Add(new Binding("EditValue", ensayoProctorBindingSource, "TipoProctor", true));
            cmbTipoProctor.Location = new Point(122, 116);
            cmbTipoProctor.Name = "cmbTipoProctor";
            cmbTipoProctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTipoProctor.Size = new Size(362, 22);
            cmbTipoProctor.StyleController = layoutControl2;
            cmbTipoProctor.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem7, layoutControlItem8, layoutControlItem9, layoutControlItem10 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(496, 216);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtDiametroMoldeCm;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(476, 26);
            layoutControlItem4.Text = "Diametro Molde (cm)";
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = txtAlturaMoldeCm;
            layoutControlItem7.Location = new Point(0, 26);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(476, 26);
            layoutControlItem7.Text = "Altura Molde (cm)";
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = cmbNumeroCapas;
            layoutControlItem8.Location = new Point(0, 52);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(476, 26);
            layoutControlItem8.Text = "No. de Capas";
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = cmbGolpesPorCapa;
            layoutControlItem9.Location = new Point(0, 78);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(476, 26);
            layoutControlItem9.Text = "No Capas/Golpes";
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = cmbTipoProctor;
            layoutControlItem10.Location = new Point(0, 104);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(476, 92);
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
            tabPageGrafico.Size = new Size(1020, 353);
            tabPageGrafico.Text = "Grafico";
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
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
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPesoMartillo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTemperaturaSecado.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbNorma.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMetotoUtilizado.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDiametroMoldeCm.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlturaMoldeCm.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbNumeroCapas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbGolpesPorCapa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoProctor.Properties).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtDiametroMoldeCm;
        private DevExpress.XtraEditors.TextEdit txtAlturaMoldeCm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraTab.XtraTabControl tabResultadosProctor;
        private BindingSource ensayoProctorBindingSource;
        private DevExpress.XtraTab.XtraTabPage tabPageGrafico;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPesoMartillo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNumeroCapas;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGolpesPorCapa;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTemperaturaSecado;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoProctor;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNorma;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMetotoUtilizado;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
