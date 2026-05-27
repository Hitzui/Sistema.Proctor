namespace Sistema.Proctor.WinForm.Views.Proyecto.Granulometria
{
    partial class ResultadoLimitesControl
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
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            gridControlLimitePlastico = new DevExpress.XtraGrid.GridControl();
            limitePlasticoDtoBindingSource = new BindingSource(components);
            cardViewLimitePlastico = new DevExpress.XtraGrid.Views.Card.CardView();
            colCodigoTara1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTara1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTaraMuestraHumeda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTaraMuestraSeca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoMuestraSeca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoAgua1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colHumedad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            gridControlResultadoLimiteLiquido = new DevExpress.XtraGrid.GridControl();
            limiteLiquidoDtoBindingSource = new BindingSource(components);
            cardViewLimiteLiquido = new DevExpress.XtraGrid.Views.Card.CardView();
            colNumGolpes = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigoTara = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTara = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTaraMuestraHumeda = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoTaraMuestraSeca = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoMuestraSeca = new DevExpress.XtraGrid.Columns.GridColumn();
            colPesoAgua = new DevExpress.XtraGrid.Columns.GridColumn();
            colHumedad = new DevExpress.XtraGrid.Columns.GridColumn();
            colMetodo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlLimitePlastico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limitePlasticoDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardViewLimitePlastico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlResultadoLimiteLiquido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limiteLiquidoDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardViewLimiteLiquido).BeginInit();
            SuspendLayout();
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel1.Controls.Add(gridControlLimitePlastico);
            tablePanel1.Controls.Add(controlNavigator1);
            tablePanel1.Controls.Add(gridControlResultadoLimiteLiquido);
            tablePanel1.Dock = DockStyle.Fill;
            tablePanel1.Location = new Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel1.Size = new Size(980, 634);
            tablePanel1.TabIndex = 0;
            tablePanel1.UseSkinIndents = true;
            // 
            // gridControlLimitePlastico
            // 
            tablePanel1.SetColumn(gridControlLimitePlastico, 0);
            gridControlLimitePlastico.DataSource = limitePlasticoDtoBindingSource;
            gridControlLimitePlastico.Dock = DockStyle.Fill;
            gridControlLimitePlastico.Location = new Point(13, 333);
            gridControlLimitePlastico.MainView = cardViewLimitePlastico;
            gridControlLimitePlastico.Name = "gridControlLimitePlastico";
            tablePanel1.SetRow(gridControlLimitePlastico, 2);
            gridControlLimitePlastico.Size = new Size(475, 288);
            gridControlLimitePlastico.TabIndex = 3;
            gridControlLimitePlastico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { cardViewLimitePlastico });
            // 
            // limitePlasticoDtoBindingSource
            // 
            limitePlasticoDtoBindingSource.DataSource = typeof(Dto.LimitePlasticoDto);
            // 
            // cardViewLimitePlastico
            // 
            cardViewLimitePlastico.CardCaptionFormat = "LP # {0}";
            cardViewLimitePlastico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCodigoTara1, colPesoTara1, colPesoTaraMuestraHumeda1, colPesoTaraMuestraSeca1, colPesoMuestraSeca1, colPesoAgua1, colHumedad1 });
            cardViewLimitePlastico.GridControl = gridControlLimitePlastico;
            cardViewLimitePlastico.Name = "cardViewLimitePlastico";
            cardViewLimitePlastico.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            cardViewLimitePlastico.FocusedRowChanged += cardViewLimitePlastico_FocusedRowChanged;
            // 
            // colCodigoTara1
            // 
            colCodigoTara1.FieldName = "CodigoTara";
            colCodigoTara1.Name = "colCodigoTara1";
            colCodigoTara1.Visible = true;
            colCodigoTara1.VisibleIndex = 0;
            // 
            // colPesoTara1
            // 
            colPesoTara1.FieldName = "PesoTara";
            colPesoTara1.Name = "colPesoTara1";
            colPesoTara1.Visible = true;
            colPesoTara1.VisibleIndex = 1;
            // 
            // colPesoTaraMuestraHumeda1
            // 
            colPesoTaraMuestraHumeda1.FieldName = "PesoTaraMuestraHumeda";
            colPesoTaraMuestraHumeda1.Name = "colPesoTaraMuestraHumeda1";
            colPesoTaraMuestraHumeda1.Visible = true;
            colPesoTaraMuestraHumeda1.VisibleIndex = 2;
            // 
            // colPesoTaraMuestraSeca1
            // 
            colPesoTaraMuestraSeca1.FieldName = "PesoTaraMuestraSeca";
            colPesoTaraMuestraSeca1.Name = "colPesoTaraMuestraSeca1";
            colPesoTaraMuestraSeca1.Visible = true;
            colPesoTaraMuestraSeca1.VisibleIndex = 3;
            // 
            // colPesoMuestraSeca1
            // 
            colPesoMuestraSeca1.FieldName = "PesoMuestraSeca";
            colPesoMuestraSeca1.Name = "colPesoMuestraSeca1";
            colPesoMuestraSeca1.Visible = true;
            colPesoMuestraSeca1.VisibleIndex = 4;
            // 
            // colPesoAgua1
            // 
            colPesoAgua1.FieldName = "PesoAgua";
            colPesoAgua1.Name = "colPesoAgua1";
            colPesoAgua1.Visible = true;
            colPesoAgua1.VisibleIndex = 5;
            // 
            // colHumedad1
            // 
            colHumedad1.FieldName = "Humedad";
            colHumedad1.Name = "colHumedad1";
            colHumedad1.Visible = true;
            colHumedad1.VisibleIndex = 6;
            // 
            // controlNavigator1
            // 
            controlNavigator1.Buttons.Edit.Visible = false;
            tablePanel1.SetColumn(controlNavigator1, 0);
            controlNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] { new DevExpress.XtraEditors.NavigatorCustomButton(7, 8, "Editar Datos") });
            controlNavigator1.Dock = DockStyle.Fill;
            controlNavigator1.Location = new Point(13, 304);
            controlNavigator1.Name = "controlNavigator1";
            controlNavigator1.NavigatableControl = gridControlResultadoLimiteLiquido;
            tablePanel1.SetRow(controlNavigator1, 1);
            controlNavigator1.Size = new Size(475, 25);
            controlNavigator1.TabIndex = 2;
            controlNavigator1.TextStringFormat = "Ensayo {0} of {1}";
            controlNavigator1.ButtonClick += controlNavigator1_ButtonClick;
            // 
            // gridControlResultadoLimiteLiquido
            // 
            tablePanel1.SetColumn(gridControlResultadoLimiteLiquido, 0);
            gridControlResultadoLimiteLiquido.DataSource = limiteLiquidoDtoBindingSource;
            gridControlResultadoLimiteLiquido.Dock = DockStyle.Fill;
            gridControlResultadoLimiteLiquido.Location = new Point(13, 12);
            gridControlResultadoLimiteLiquido.MainView = cardViewLimiteLiquido;
            gridControlResultadoLimiteLiquido.Name = "gridControlResultadoLimiteLiquido";
            tablePanel1.SetRow(gridControlResultadoLimiteLiquido, 0);
            gridControlResultadoLimiteLiquido.Size = new Size(475, 288);
            gridControlResultadoLimiteLiquido.TabIndex = 0;
            gridControlResultadoLimiteLiquido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { cardViewLimiteLiquido });
            // 
            // limiteLiquidoDtoBindingSource
            // 
            limiteLiquidoDtoBindingSource.DataSource = typeof(Dto.LimiteLiquidoDto);
            // 
            // cardViewLimiteLiquido
            // 
            cardViewLimiteLiquido.CardCaptionFormat = "LL # {0}";
            cardViewLimiteLiquido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNumGolpes, colCodigoTara, colPesoTara, colPesoTaraMuestraHumeda, colPesoTaraMuestraSeca, colPesoMuestraSeca, colPesoAgua, colHumedad, colMetodo });
            cardViewLimiteLiquido.GridControl = gridControlResultadoLimiteLiquido;
            cardViewLimiteLiquido.Name = "cardViewLimiteLiquido";
            cardViewLimiteLiquido.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            cardViewLimiteLiquido.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            cardViewLimiteLiquido.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            cardViewLimiteLiquido.FocusedRowChanged += cardViewLimiteLiquido_FocusedRowChanged;
            // 
            // colNumGolpes
            // 
            colNumGolpes.FieldName = "NumGolpes";
            colNumGolpes.Name = "colNumGolpes";
            colNumGolpes.OptionsColumn.ReadOnly = true;
            colNumGolpes.Visible = true;
            colNumGolpes.VisibleIndex = 0;
            // 
            // colCodigoTara
            // 
            colCodigoTara.FieldName = "CodigoTara";
            colCodigoTara.Name = "colCodigoTara";
            colCodigoTara.OptionsColumn.ReadOnly = true;
            colCodigoTara.Visible = true;
            colCodigoTara.VisibleIndex = 1;
            // 
            // colPesoTara
            // 
            colPesoTara.FieldName = "PesoTara";
            colPesoTara.Name = "colPesoTara";
            colPesoTara.OptionsColumn.ReadOnly = true;
            colPesoTara.Visible = true;
            colPesoTara.VisibleIndex = 2;
            // 
            // colPesoTaraMuestraHumeda
            // 
            colPesoTaraMuestraHumeda.FieldName = "PesoTaraMuestraHumeda";
            colPesoTaraMuestraHumeda.Name = "colPesoTaraMuestraHumeda";
            colPesoTaraMuestraHumeda.OptionsColumn.ReadOnly = true;
            colPesoTaraMuestraHumeda.Visible = true;
            colPesoTaraMuestraHumeda.VisibleIndex = 3;
            // 
            // colPesoTaraMuestraSeca
            // 
            colPesoTaraMuestraSeca.FieldName = "PesoTaraMuestraSeca";
            colPesoTaraMuestraSeca.Name = "colPesoTaraMuestraSeca";
            colPesoTaraMuestraSeca.OptionsColumn.ReadOnly = true;
            colPesoTaraMuestraSeca.Visible = true;
            colPesoTaraMuestraSeca.VisibleIndex = 4;
            // 
            // colPesoMuestraSeca
            // 
            colPesoMuestraSeca.FieldName = "PesoMuestraSeca";
            colPesoMuestraSeca.Name = "colPesoMuestraSeca";
            colPesoMuestraSeca.OptionsColumn.ReadOnly = true;
            colPesoMuestraSeca.Visible = true;
            colPesoMuestraSeca.VisibleIndex = 5;
            // 
            // colPesoAgua
            // 
            colPesoAgua.FieldName = "PesoAgua";
            colPesoAgua.Name = "colPesoAgua";
            colPesoAgua.OptionsColumn.ReadOnly = true;
            colPesoAgua.Visible = true;
            colPesoAgua.VisibleIndex = 6;
            // 
            // colHumedad
            // 
            colHumedad.FieldName = "Humedad";
            colHumedad.Name = "colHumedad";
            colHumedad.OptionsColumn.ReadOnly = true;
            colHumedad.Visible = true;
            colHumedad.VisibleIndex = 7;
            // 
            // colMetodo
            // 
            colMetodo.FieldName = "Metodo";
            colMetodo.Name = "colMetodo";
            colMetodo.OptionsColumn.ReadOnly = true;
            colMetodo.Visible = true;
            colMetodo.VisibleIndex = 8;
            // 
            // ResultadoLimitesControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablePanel1);
            Name = "ResultadoLimitesControl";
            Size = new Size(980, 634);
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlLimitePlastico).EndInit();
            ((System.ComponentModel.ISupportInitialize)limitePlasticoDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardViewLimitePlastico).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlResultadoLimiteLiquido).EndInit();
            ((System.ComponentModel.ISupportInitialize)limiteLiquidoDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardViewLimiteLiquido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControlResultadoLimiteLiquido;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewLimiteLiquido;
        private DevExpress.XtraGrid.Columns.GridColumn colNumGolpes;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoTara;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTara;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTaraMuestraHumeda;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTaraMuestraSeca;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoMuestraSeca;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoAgua;
        private DevExpress.XtraGrid.Columns.GridColumn colHumedad;
        private DevExpress.XtraGrid.Columns.GridColumn colMetodo;
        public BindingSource limiteLiquidoDtoBindingSource;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl gridControlLimitePlastico;
        private BindingSource limitePlasticoDtoBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewLimitePlastico;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoTara1;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTara1;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTaraMuestraHumeda1;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoTaraMuestraSeca1;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoMuestraSeca1;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoAgua1;
        private DevExpress.XtraGrid.Columns.GridColumn colHumedad1;
    }
}
