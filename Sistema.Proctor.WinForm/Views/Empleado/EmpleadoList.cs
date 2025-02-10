using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Views.Empleado
{
    public partial class EmpleadoList : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public EmpleadoList()
        {
            InitializeComponent();
        }

        private void LoadValues()
        {
            BeginInvoke(() =>
            {
                splashScreenManager1.ShowWaitForm();
                gridControlEmpleados.DataSource = DependenciasGlobalesForm.Instance.ListadoEmpleados;
                splashScreenManager1.CloseWaitForm();
            });
        }

        private void EmpleadoList_Load(object sender, EventArgs e)
        {
            LoadValues();
        }

        private void gridViewEmpleados_PopupMenuShowing(object sender,
            DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                e.ShowCustomMenu(popupMenu1);
            }
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item == barButtonEditar)
            {
                var editEmpleado = new EmpleadoEdit();
                editEmpleado.ShowDialog();
            }

            if (e.Item == barButtonEliminar)
            {
                EliminarEmpleado();
            }
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRowsCount = gridViewEmpleados.SelectedRowsCount;
            if (selectedRowsCount <= 0) return;
            var empleado = (Proctor.Data.Entities.Empleado)gridViewEmpleados.GetRow(gridViewEmpleados.FocusedRowHandle);
            DependenciasGlobalesForm.Instance.SelectedEmpleado = new EmpleadoDto().GetEmpleadoDto(empleado);
        }

        public async void EliminarEmpleado()
        {
            try
            {
                var result =
                    XtraMessageBox.Show("¿Seguro eliminará el empleado seleccionado? Esta acción no se puede revertir",
                        "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                var empleado = DependenciasGlobalesForm.Instance.SelectedEmpleado;
                if (empleado is null)
                {
                    await XtraMessageBox.ShowAsync("No ha seleccionado un empleado");
                    return;
                }

                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var repositorio = unitOfWork.EmpleadoRepository;
                repositorio.Delete(empleado.GetEmpleado());
                await unitOfWork.CompleteAsync();
                DependenciasGlobalesForm.Instance.FillListadoEmpleados();
                await XtraMessageBox.ShowAsync("Se ha eliminado el cliente de forma correcta");
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al eliminar el cliente");
            }
        }
    }
}