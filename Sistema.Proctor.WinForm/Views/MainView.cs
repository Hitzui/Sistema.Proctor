using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Proctor.Data;
using Sistema.Proctor.WinForm.Views.Cliente;
using Sistema.Proctor.WinForm.Views.Empleado;

namespace Sistema.Proctor.WinForm.Views
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo<T>() where T : Form, new()
        {
            // Buscar si ya existe una instancia del formulario hijo
            foreach (var form in MdiChildren)
            {
                if (form is not T) continue;
                // Si ya existe, lo traemos al frente
                form.BringToFront();
                return;
            }

            // Si no existe, creamos una nueva instancia
            var nuevoFormulario = new T();
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Show();
        }

        private void barButtonItemListaClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            DependenciasGlobalesForm.Instance.FillListadoClientes();
            AbrirFormularioHijo<ClientesList>();
        }

        private void barButtonItemAddCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            DependenciasGlobalesForm.Instance.SelectedCliente = null;
            var addCliente = new ClienteEdit();
            addCliente.ShowDialog();
        }

        private void barButtonItemEditarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addCliente = new ClienteEdit();
            addCliente.ShowDialog();
        }

        private void barButtonItemEliminarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clienteList = new ClientesList();
            clienteList.EliminarCliente();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DependenciasGlobalesForm.Instance.FillListadoEmpleados();
            AbrirFormularioHijo<EmpleadoList>();
        }

        private void barButtonItemAgregarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            DependenciasGlobalesForm.Instance.SelectedEmpleado = null;
            var addEmpleado = new EmpleadoEdit();
            addEmpleado.ShowDialog();
        }

        private void barButtonItemEliminarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            var empleadoList = new EmpleadoList();
            empleadoList.EliminarEmpleado();
        }
    }
}