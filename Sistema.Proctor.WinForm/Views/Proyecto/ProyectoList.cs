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
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    public partial class ProyectoList : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ProyectoList()
        {
            InitializeComponent();
        }

        private void ProyectoList_Load(object sender, EventArgs e)
        {
            DependenciasGlobalesForm.Instance.FillListadoProyectos();
            gridControlProyectos.DataSource = DependenciasGlobalesForm.Instance.ListadoProyectos;
        }

        private void gridViewProyectos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRowsCount = gridViewProyectos.SelectedRowsCount;
            if (selectedRowsCount <= 0) return;
            var proyecto = (Sistema.Proctor.Data.Entities.Proyecto)gridViewProyectos.GetRow(gridViewProyectos.FocusedRowHandle);
            DependenciasGlobalesForm.Instance.SelectedProyecto = new ProyectoDto().GetProyectoDto(proyecto);
        }

        private void gridViewProyectos_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                e.ShowCustomMenu(popupMenu);
            }
        }

        private async void barManagerProyecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (e.Item == barButtonItemEditarProyecto)
                {
                    var editarProyecto = new ProyectoEdit();
                    editarProyecto.ShowDialog();
                }

                if (e.Item == barButtonItemAbrirProyecto)
                {
                    splashScreenManager1.ShowWaitForm();
                    if (DependenciasGlobalesForm.Instance.SelectedProyecto is null) return;
                    var selectedProyectoIdproyecto = DependenciasGlobalesForm.Instance.SelectedProyecto.Idproyecto;
                    await DependenciasGlobalesForm.Instance.FillListadoMuestras(selectedProyectoIdproyecto);
                    var mainView = (MainView)MdiParent;
                    var abrirProyecto = new EnsayosProyecto()
                    {
                        MdiParent = mainView
                    };
                    splashScreenManager1.CloseWaitForm();
                    abrirProyecto.Show();
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al cargar la lista de muestras");
            }
        }
    }
}