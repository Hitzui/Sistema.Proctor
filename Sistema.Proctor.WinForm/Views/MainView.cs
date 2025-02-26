using DevExpress.XtraBars;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using MathNet.Numerics;
using NLog;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Views.Cliente;
using Sistema.Proctor.WinForm.Views.Empleado;
using Sistema.Proctor.WinForm.Views.Empresa;
using Sistema.Proctor.WinForm.Views.Proyecto;
using Sistema.Proctor.WinForm.Views.Proyecto.Muestra;
using Sistema.Proctor.WinForm.Views.Proyecto.Proctor;
using Control = System.Windows.Forms.Control;
using Series = DevExpress.XtraCharts.Series;

namespace Sistema.Proctor.WinForm.Views
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

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
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.FillListadoClientes();
            AbrirFormularioHijo<ClientesList>();
            splashScreenManager1.CloseWaitForm();
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
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.FillListadoEmpleados();
            AbrirFormularioHijo<EmpleadoList>();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItemAgregarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            DependenciasGlobalesForm.Instance.SelectedEmpleado = null;
            var addEmpleado = new EmpleadoEdit();
            addEmpleado.ShowDialog();
        }

        private void barButtonItemEditarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addEmpleado = new EmpleadoEdit();
            addEmpleado.ShowDialog();
        }

        private void barButtonItemEliminarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            var empleadoList = new EmpleadoList();
            empleadoList.EliminarEmpleado();
        }

        private void barButtonItemListaProyectos_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.FillListadoProyectos();
            AbrirFormularioHijo<ProyectoList>();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItemCrearProyecto_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.SelectedProyecto = null;
            var agregarProyecto = new ProyectoEdit();
            splashScreenManager1.CloseWaitForm();
            agregarProyecto.ShowDialog();
        }

        private void barButtonItemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                if (form is not EnsayosProyecto) continue;
                form.Close();
                ribbon.SelectPage(ribbonPageProyectos);
                return;
            }
        }

        private void barButtonItemAgregarProctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formEnsayoProyectos = MdiChildren.OfType<EnsayosProyecto>().FirstOrDefault();
            if (formEnsayoProyectos is null) return;
            try
            {
                formEnsayoProyectos.AddTabPageProctor("Ensayo Proctor", null);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }

        }

        private void barButtonItemGenerarGrafico_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formEnsayoProyectos = MdiChildren.OfType<EnsayosProyecto>().FirstOrDefault();
            if (formEnsayoProyectos == null) return;

            try
            {
                var selectedTabPage = formEnsayoProyectos.xtraTabControlEnsayos.SelectedTabPage;
                var proctorControl = selectedTabPage.Controls.OfType<ProctorControl>().FirstOrDefault();
                proctorControl?.btnGenerarGrafico_Click();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar generar grafico proctor");
            }
        }

        private void barButtonItemGuardarEnsayoProctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formEnsayoProyectos = MdiChildren.OfType<EnsayosProyecto>().FirstOrDefault();
            if (formEnsayoProyectos == null) return;

            try
            {
                var selectedTabPage = formEnsayoProyectos.xtraTabControlEnsayos.SelectedTabPage;
                var proctorControl = selectedTabPage.Controls.OfType<ProctorControl>().FirstOrDefault();
                proctorControl?.btnGuardarEnsayoProctor_Click();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar Ensayo proctor");
            }
        }

        private void barButtonItemAgregarMuestra_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DependenciasGlobalesForm.Instance.SelectedProyecto is null)
            {
                XtraMessageBox.Show("Seleccione un proyecto para añadir muestras", "Muestra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frmMuestras = new AgregarMuestra();
            frmMuestras.ShowDialog();
        }

        private async void barButtonItemAbrirProyecto_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (DependenciasGlobalesForm.Instance.SelectedProyecto is null)
                {
                    XtraMessageBox.Show("Seleccione un proyecto para abrir", "Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                splashScreenManager1.ShowWaitForm();
                var selectedProyectoIdproyecto = DependenciasGlobalesForm.Instance.SelectedProyecto.Idproyecto;
                await DependenciasGlobalesForm.Instance.FillListadoMuestras(selectedProyectoIdproyecto);
                AbrirFormularioHijo<EnsayosProyecto>();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al abrir el formulario de proyectos");
            }
        }

        private void barButtonItemReporteResultadosProctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formEnsayoProyectos = MdiChildren.OfType<EnsayosProyecto>().FirstOrDefault();
            if (formEnsayoProyectos == null) return;

            try
            {
                var selectedTabPage = formEnsayoProyectos.xtraTabControlEnsayos.SelectedTabPage;
                var proctorControl = selectedTabPage.Controls.OfType<ProctorControl>().FirstOrDefault();
                if (proctorControl == null)
                {
                    XtraMessageBox.Show("No se ha seleccionado un ensayo proctor", "Proctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                proctorControl.PrintReport();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar Ensayo proctor");
            }
        }

        private void barButtonItemAbrirEnsayoProctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formEnsayoProyectos = MdiChildren.OfType<EnsayosProyecto>().FirstOrDefault();
            if (formEnsayoProyectos == null) return;

            try
            {
                var selectedEnsayoRecordDto = formEnsayoProyectos.SelectedEnsayoRecordDto;
                if (selectedEnsayoRecordDto is not null)
                {
                    formEnsayoProyectos.FindEnsayos(selectedEnsayoRecordDto.IdTipoEnsayo);
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar Ensayo proctor");
            }
        }

        private void barButtonItemListadoEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.FillListadoEmpresas();
            AbrirFormularioHijo<EmpresaList>();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItemAgregarEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.SelectedEmpresa = null;
            var frmAgregarEmpresa = new EmpresaEdit();
            splashScreenManager1.CloseWaitForm();
            frmAgregarEmpresa.ShowDialog(this);
        }

        private void barButtonItemEditarEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            if (DependenciasGlobalesForm.Instance.SelectedEmpresa is null)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Seleccione una empresa para editar", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var frmAgregarEmpresa = new EmpresaEdit();
            splashScreenManager1.CloseWaitForm();
            frmAgregarEmpresa.ShowDialog(this);
        }
    }
}