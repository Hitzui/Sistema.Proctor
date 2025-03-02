namespace Sistema.Proctor.WinForm.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemListaClientes = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAddCliente = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditarCliente = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEliminarCliente = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAgregarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEliminarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemListaProyectos = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCrearProyecto = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAgregarProctor = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemGenerarGrafico = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemGuardarEnsayoProctor = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAgregarMuestra = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAbrirProyecto = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemReporteResultadosProctor = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAbrirEnsayoProctor = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemListadoEmpresa = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditarEmpresa = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAgregarEmpresa = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEditarMuestra = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageProyectos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageEnsayos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true);
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonItemAgregarHumedad = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItemListaClientes, barButtonItemAddCliente, barButtonItemEditarCliente, barButtonItemEliminarCliente, barButtonItem1, barButtonItemAgregarEmpleado, barButtonItemEliminarEmpleado, barButtonItemListaProyectos, barButtonItemCrearProyecto, barButtonItemAgregarProctor, barButtonItemClose, barButtonItemGenerarGrafico, barButtonItemGuardarEnsayoProctor, barButtonItemAgregarMuestra, barButtonItemAbrirProyecto, barButtonItemReporteResultadosProctor, barButtonItemAbrirEnsayoProctor, barButtonItemEditarEmpleado, barButtonItemListadoEmpresa, barButtonItemEditarEmpresa, barButtonItemAgregarEmpresa, barButtonItemEditarMuestra, barButtonItemAgregarHumedad });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 24;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPageProyectos, ribbonPageEnsayos });
            ribbon.Size = new Size(950, 171);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItemListaClientes
            // 
            barButtonItemListaClientes.Caption = "Lista";
            barButtonItemListaClientes.Id = 1;
            barButtonItemListaClientes.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemListaClientes.ImageOptions.SvgImage");
            barButtonItemListaClientes.Name = "barButtonItemListaClientes";
            barButtonItemListaClientes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItemListaClientes.ItemClick += barButtonItemListaClientes_ItemClick;
            // 
            // barButtonItemAddCliente
            // 
            barButtonItemAddCliente.Caption = "Agregar";
            barButtonItemAddCliente.Id = 2;
            barButtonItemAddCliente.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAddCliente.ImageOptions.SvgImage");
            barButtonItemAddCliente.Name = "barButtonItemAddCliente";
            barButtonItemAddCliente.ItemClick += barButtonItemAddCliente_ItemClick;
            // 
            // barButtonItemEditarCliente
            // 
            barButtonItemEditarCliente.Caption = "Editar";
            barButtonItemEditarCliente.Id = 3;
            barButtonItemEditarCliente.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditarCliente.ImageOptions.SvgImage");
            barButtonItemEditarCliente.Name = "barButtonItemEditarCliente";
            barButtonItemEditarCliente.ItemClick += barButtonItemEditarCliente_ItemClick;
            // 
            // barButtonItemEliminarCliente
            // 
            barButtonItemEliminarCliente.Caption = "Eliminar";
            barButtonItemEliminarCliente.Id = 4;
            barButtonItemEliminarCliente.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEliminarCliente.ImageOptions.SvgImage");
            barButtonItemEliminarCliente.Name = "barButtonItemEliminarCliente";
            barButtonItemEliminarCliente.ItemClick += barButtonItemEliminarCliente_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Lista";
            barButtonItem1.Id = 5;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItemAgregarEmpleado
            // 
            barButtonItemAgregarEmpleado.Caption = "Agregar";
            barButtonItemAgregarEmpleado.Id = 6;
            barButtonItemAgregarEmpleado.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAgregarEmpleado.ImageOptions.SvgImage");
            barButtonItemAgregarEmpleado.Name = "barButtonItemAgregarEmpleado";
            barButtonItemAgregarEmpleado.ItemClick += barButtonItemAgregarEmpleado_ItemClick;
            // 
            // barButtonItemEliminarEmpleado
            // 
            barButtonItemEliminarEmpleado.Caption = "Eliminar";
            barButtonItemEliminarEmpleado.Id = 7;
            barButtonItemEliminarEmpleado.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            barButtonItemEliminarEmpleado.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEliminarEmpleado.ImageOptions.SvgImage");
            barButtonItemEliminarEmpleado.ItemAppearance.Normal.ForeColor = Color.Red;
            barButtonItemEliminarEmpleado.ItemAppearance.Normal.Options.UseForeColor = true;
            barButtonItemEliminarEmpleado.Name = "barButtonItemEliminarEmpleado";
            barButtonItemEliminarEmpleado.ItemClick += barButtonItemEliminarEmpleado_ItemClick;
            // 
            // barButtonItemListaProyectos
            // 
            barButtonItemListaProyectos.Caption = "Lista Proyectos";
            barButtonItemListaProyectos.Id = 8;
            barButtonItemListaProyectos.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemListaProyectos.ImageOptions.SvgImage");
            barButtonItemListaProyectos.Name = "barButtonItemListaProyectos";
            barButtonItemListaProyectos.ItemClick += barButtonItemListaProyectos_ItemClick;
            // 
            // barButtonItemCrearProyecto
            // 
            barButtonItemCrearProyecto.Caption = "Crear Proyecto";
            barButtonItemCrearProyecto.Id = 9;
            barButtonItemCrearProyecto.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemCrearProyecto.ImageOptions.SvgImage");
            barButtonItemCrearProyecto.Name = "barButtonItemCrearProyecto";
            barButtonItemCrearProyecto.ItemClick += barButtonItemCrearProyecto_ItemClick;
            // 
            // barButtonItemAgregarProctor
            // 
            barButtonItemAgregarProctor.Caption = "Agregar";
            barButtonItemAgregarProctor.Id = 10;
            barButtonItemAgregarProctor.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAgregarProctor.ImageOptions.SvgImage");
            barButtonItemAgregarProctor.Name = "barButtonItemAgregarProctor";
            barButtonItemAgregarProctor.ItemClick += barButtonItemAgregarProctor_ItemClick;
            // 
            // barButtonItemClose
            // 
            barButtonItemClose.Caption = "Cerrar";
            barButtonItemClose.Id = 11;
            barButtonItemClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemClose.ImageOptions.SvgImage");
            barButtonItemClose.Name = "barButtonItemClose";
            barButtonItemClose.ItemClick += barButtonItemClose_ItemClick;
            // 
            // barButtonItemGenerarGrafico
            // 
            barButtonItemGenerarGrafico.Caption = "Generar Grafico";
            barButtonItemGenerarGrafico.Id = 12;
            barButtonItemGenerarGrafico.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemGenerarGrafico.ImageOptions.SvgImage");
            barButtonItemGenerarGrafico.Name = "barButtonItemGenerarGrafico";
            barButtonItemGenerarGrafico.ItemClick += barButtonItemGenerarGrafico_ItemClick;
            // 
            // barButtonItemGuardarEnsayoProctor
            // 
            barButtonItemGuardarEnsayoProctor.Caption = "Guardar";
            barButtonItemGuardarEnsayoProctor.Id = 13;
            barButtonItemGuardarEnsayoProctor.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemGuardarEnsayoProctor.ImageOptions.SvgImage");
            barButtonItemGuardarEnsayoProctor.Name = "barButtonItemGuardarEnsayoProctor";
            barButtonItemGuardarEnsayoProctor.ItemClick += barButtonItemGuardarEnsayoProctor_ItemClick;
            // 
            // barButtonItemAgregarMuestra
            // 
            barButtonItemAgregarMuestra.Caption = "Agregar Muestra";
            barButtonItemAgregarMuestra.Id = 14;
            barButtonItemAgregarMuestra.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAgregarMuestra.ImageOptions.SvgImage");
            barButtonItemAgregarMuestra.Name = "barButtonItemAgregarMuestra";
            barButtonItemAgregarMuestra.ItemClick += barButtonItemAgregarMuestra_ItemClick;
            // 
            // barButtonItemAbrirProyecto
            // 
            barButtonItemAbrirProyecto.Caption = "Abrir Proyecto";
            barButtonItemAbrirProyecto.Id = 15;
            barButtonItemAbrirProyecto.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAbrirProyecto.ImageOptions.SvgImage");
            barButtonItemAbrirProyecto.Name = "barButtonItemAbrirProyecto";
            barButtonItemAbrirProyecto.ItemClick += barButtonItemAbrirProyecto_ItemClick;
            // 
            // barButtonItemReporteResultadosProctor
            // 
            barButtonItemReporteResultadosProctor.Caption = "Reporte";
            barButtonItemReporteResultadosProctor.Id = 16;
            barButtonItemReporteResultadosProctor.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemReporteResultadosProctor.ImageOptions.SvgImage");
            barButtonItemReporteResultadosProctor.Name = "barButtonItemReporteResultadosProctor";
            barButtonItemReporteResultadosProctor.ItemClick += barButtonItemReporteResultadosProctor_ItemClick;
            // 
            // barButtonItemAbrirEnsayoProctor
            // 
            barButtonItemAbrirEnsayoProctor.Caption = "Abrir Ensayo";
            barButtonItemAbrirEnsayoProctor.Id = 17;
            barButtonItemAbrirEnsayoProctor.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAbrirEnsayoProctor.ImageOptions.SvgImage");
            barButtonItemAbrirEnsayoProctor.Name = "barButtonItemAbrirEnsayoProctor";
            barButtonItemAbrirEnsayoProctor.ItemClick += barButtonItemAbrirEnsayoProctor_ItemClick;
            // 
            // barButtonItemEditarEmpleado
            // 
            barButtonItemEditarEmpleado.Caption = "Editar";
            barButtonItemEditarEmpleado.Id = 18;
            barButtonItemEditarEmpleado.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditarEmpleado.ImageOptions.SvgImage");
            barButtonItemEditarEmpleado.Name = "barButtonItemEditarEmpleado";
            barButtonItemEditarEmpleado.ItemClick += barButtonItemEditarEmpleado_ItemClick;
            // 
            // barButtonItemListadoEmpresa
            // 
            barButtonItemListadoEmpresa.Caption = "Lista";
            barButtonItemListadoEmpresa.Id = 19;
            barButtonItemListadoEmpresa.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemListadoEmpresa.ImageOptions.SvgImage");
            barButtonItemListadoEmpresa.Name = "barButtonItemListadoEmpresa";
            barButtonItemListadoEmpresa.ItemClick += barButtonItemListadoEmpresa_ItemClick;
            // 
            // barButtonItemEditarEmpresa
            // 
            barButtonItemEditarEmpresa.Caption = "Editar";
            barButtonItemEditarEmpresa.Id = 20;
            barButtonItemEditarEmpresa.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditarEmpresa.ImageOptions.SvgImage");
            barButtonItemEditarEmpresa.Name = "barButtonItemEditarEmpresa";
            barButtonItemEditarEmpresa.ItemClick += barButtonItemEditarEmpresa_ItemClick;
            // 
            // barButtonItemAgregarEmpresa
            // 
            barButtonItemAgregarEmpresa.Caption = "Agregar";
            barButtonItemAgregarEmpresa.Id = 21;
            barButtonItemAgregarEmpresa.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemAgregarEmpresa.ImageOptions.SvgImage");
            barButtonItemAgregarEmpresa.Name = "barButtonItemAgregarEmpresa";
            barButtonItemAgregarEmpresa.ItemClick += barButtonItemAgregarEmpresa_ItemClick;
            // 
            // barButtonItemEditarMuestra
            // 
            barButtonItemEditarMuestra.Caption = "Editar Muestra";
            barButtonItemEditarMuestra.Id = 22;
            barButtonItemEditarMuestra.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemEditarMuestra.ImageOptions.SvgImage");
            barButtonItemEditarMuestra.Name = "barButtonItemEditarMuestra";
            barButtonItemEditarMuestra.ItemClick += barButtonItemEditarMuestra_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup7 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Administrar";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItemListaClientes);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemAddCliente);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemEditarCliente);
            ribbonPageGroup1.ItemLinks.Add(barButtonItemEliminarCliente);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Clientes";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup2.ItemLinks.Add(barButtonItemAgregarEmpleado);
            ribbonPageGroup2.ItemLinks.Add(barButtonItemEditarEmpleado);
            ribbonPageGroup2.ItemLinks.Add(barButtonItemEliminarEmpleado);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Empleado";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(barButtonItemListadoEmpresa);
            ribbonPageGroup7.ItemLinks.Add(barButtonItemAgregarEmpresa);
            ribbonPageGroup7.ItemLinks.Add(barButtonItemEditarEmpresa);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            ribbonPageGroup7.Text = "Empresa";
            // 
            // ribbonPageProyectos
            // 
            ribbonPageProyectos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup6 });
            ribbonPageProyectos.Name = "ribbonPageProyectos";
            ribbonPageProyectos.Text = "Proyectos";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItemListaProyectos);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemCrearProyecto);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemAbrirProyecto);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Proyectos";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(barButtonItemAgregarMuestra);
            ribbonPageGroup6.ItemLinks.Add(barButtonItemEditarMuestra);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            ribbonPageGroup6.Text = "Muestras";
            // 
            // ribbonPageEnsayos
            // 
            ribbonPageEnsayos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, ribbonPageGroup8, ribbonPageGroup5 });
            ribbonPageEnsayos.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ribbonPageEnsayos.ImageOptions.SvgImage");
            ribbonPageEnsayos.ImageOptions.SvgImageSize = new Size(16, 16);
            ribbonPageEnsayos.Name = "ribbonPageEnsayos";
            ribbonPageEnsayos.Text = "Ensayos";
            ribbonPageEnsayos.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItemAgregarProctor);
            ribbonPageGroup4.ItemLinks.Add(barButtonItemAbrirEnsayoProctor);
            ribbonPageGroup4.ItemLinks.Add(barButtonItemGenerarGrafico);
            ribbonPageGroup4.ItemLinks.Add(barButtonItemGuardarEnsayoProctor);
            ribbonPageGroup4.ItemLinks.Add(barButtonItemReporteResultadosProctor);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Proctor";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(barButtonItemClose);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "Cerrar";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 689);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(950, 31);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(barButtonItemAgregarHumedad);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            ribbonPageGroup8.Text = "Humedad";
            // 
            // barButtonItemAgregarHumedad
            // 
            barButtonItemAgregarHumedad.Caption = "Agregar";
            barButtonItemAgregarHumedad.Id = 23;
            barButtonItemAgregarHumedad.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItemAgregarHumedad.Name = "barButtonItemAgregarHumedad";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 720);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainView.IconOptions.SvgImage");
            IsMdiContainer = true;
            Name = "MainView";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "Sistema de Gestion de Laboratorio";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemListaClientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddCliente;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarCliente;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEliminarCliente;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarEmpleado;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEliminarEmpleado;
        private DevExpress.XtraBars.BarButtonItem barButtonItemListaProyectos;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProyectos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCrearProyecto;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarProctor;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEnsayos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGenerarGrafico;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGuardarEnsayoProctor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarMuestra;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbrirProyecto;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReporteResultadosProctor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbrirEnsayoProctor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarEmpleado;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItemListadoEmpresa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarEmpresa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarEmpresa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarMuestra;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAgregarHumedad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}