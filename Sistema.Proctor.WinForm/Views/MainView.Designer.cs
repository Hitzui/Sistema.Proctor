﻿namespace Sistema.Proctor.WinForm.Views
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
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageProyectos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageEnsayos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Cliente.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItemListaClientes, barButtonItemAddCliente, barButtonItemEditarCliente, barButtonItemEliminarCliente, barButtonItem1, barButtonItemAgregarEmpleado, barButtonItemEliminarEmpleado, barButtonItemListaProyectos, barButtonItemCrearProyecto, barButtonItemAgregarProctor, barButtonItemClose });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 12;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPageProyectos, ribbonPageEnsayos });
            ribbon.Size = new Size(950, 201);
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
            barButtonItemAgregarProctor.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
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
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
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
            ribbonPageGroup2.ItemLinks.Add(barButtonItemEliminarEmpleado);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Empleado";
            // 
            // ribbonPageProyectos
            // 
            ribbonPageProyectos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPageProyectos.Name = "ribbonPageProyectos";
            ribbonPageProyectos.Text = "Proyectos";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItemListaProyectos);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemCrearProyecto);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Proyectos";
            // 
            // ribbonPageEnsayos
            // 
            ribbonPageEnsayos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, ribbonPageGroup5 });
            ribbonPageEnsayos.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ribbonPageEnsayos.ImageOptions.SvgImage");
            ribbonPageEnsayos.ImageOptions.SvgImageSize = new Size(16, 16);
            ribbonPageEnsayos.Name = "ribbonPageEnsayos";
            ribbonPageEnsayos.Text = "Ensayos";
            ribbonPageEnsayos.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItemAgregarProctor);
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
            ribbonStatusBar.Location = new Point(0, 683);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(950, 37);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
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
    }
}