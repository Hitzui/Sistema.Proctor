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
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barButtonItemEliminarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItemListaClientes, barButtonItemAddCliente, barButtonItemEditarCliente, barButtonItemEliminarCliente, barButtonItem1, barButtonItemAgregarEmpleado, barButtonItemEliminarEmpleado });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(950, 151);
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
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 699);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(950, 21);
            // 
            // barButtonItemEliminarEmpleado
            // 
            barButtonItemEliminarEmpleado.Caption = "Eliminar";
            barButtonItemEliminarEmpleado.Id = 7;
            barButtonItemEliminarEmpleado.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            barButtonItemEliminarEmpleado.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItemEliminarEmpleado.ItemAppearance.Normal.ForeColor = Color.Red;
            barButtonItemEliminarEmpleado.ItemAppearance.Normal.Options.UseForeColor = true;
            barButtonItemEliminarEmpleado.Name = "barButtonItemEliminarEmpleado";
            barButtonItemEliminarEmpleado.ItemClick += barButtonItemEliminarEmpleado_ItemClick;
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
    }
}