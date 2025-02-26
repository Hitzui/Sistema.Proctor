using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList.Menu;
using Sistema.Proctor.Data;
using NLog;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Proyecto.Proctor;

namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    public partial class EnsayosProyecto : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public XtraTabControl xtraTabControlEnsayos;
        private Panel panelIzquierdo;
        private List<EnsayoProctor> ListEnsayoProctor = new();
        public EnsayoRecordDto? SelectedEnsayoRecordDto;
        private IEnsayoRepository EnsayoRepository;
        private readonly IUnitOfWork? UnitOfWork;

        public EnsayosProyecto()
        {
            InitializeComponent();
            InitializeXtraTabControl();
            UnitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
            EnsayoRepository = UnitOfWork.EnsayosRepository;
        }

        private void InitializeXtraTabControl()
        {
            xtraTabControlEnsayos = new XtraTabControl
            {
                Dock = DockStyle.Fill,
                ClosePageButtonShowMode = ClosePageButtonShowMode.InActiveTabPageHeader
            };
            Controls.Add(xtraTabControlEnsayos);
            // Inicializar y configurar el panel izquierdo
            panelIzquierdo = new Panel
            {
                Dock = DockStyle.Left,
                Width = 500 // Ajusta el ancho según sea necesario
            };
            treeListEnsayos.Dock = DockStyle.Fill;
            panelIzquierdo.Controls.Add(treeListEnsayos);
            Controls.Add(panelIzquierdo);
            xtraTabControlEnsayos.CloseButtonClick += XtraTabControlEnsayos_CloseButtonClick;
        }

        private void XtraTabControlEnsayos_CloseButtonClick(object? sender, EventArgs e)
        {
            if (sender is XtraTabControl { SelectedTabPage: not null } tabControl)
            {
                var index = tabControl.SelectedTabPageIndex;
                ListEnsayoProctor.RemoveAt(index-1);
                tabControl.TabPages.Remove(tabControl.SelectedTabPage);
            }
        }

        private async void EnsayosProyecto_Load(object sender, EventArgs e)
        {
            try
            {
                var findAll = DependenciasGlobalesForm.Instance.ListadoMuestras;
                treeListEnsayos.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn() { Caption = @"Codigo muestra", VisibleIndex = 0 });
                treeListEnsayos.ShowLoadingPanel();
                treeListEnsayos.BeginUnboundLoad();
                foreach (var muestra in findAll)
                {
                    var muestraDto = new MuestraDto().GetMuestraDto(muestra);
                    var muestraNode = treeListEnsayos.AppendNode(new object[] { muestraDto }, null);
                    var ensayos = await EnsayoRepository.GetEnsayosByMuestra(muestra.Idmuestra);
                    foreach (var ensayo in ensayos)
                    {
                        treeListEnsayos.AppendNode(new object[] { ensayo }, muestraNode);
                    }
                }

                treeListEnsayos.EndUnboundLoad();
                treeListEnsayos.ExpandAll();
                treeListEnsayos.HideLoadingPanel();
                var mdiParent = (MainView)MdiParent!;
                mdiParent.ribbonPageEnsayos.Visible = true;
                mdiParent.ribbonPageEnsayos.Ribbon.SelectPage(mdiParent.ribbonPageEnsayos);
            }
            catch (Exception exception)
            {
                await XtraMessageBox.ShowAsync(exception.Message);
            }
        }

        private void treeListEnsayos_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                // Aquí puedes acceder al nodo seleccionado
                var selectedNode = e.Node;
                var selectedValue = selectedNode.GetValue(0); // Obtener el valor de la primera columna
                switch (selectedValue)
                {
                    case MuestraDto muestraDto:
                        DependenciasGlobalesForm.Instance.SelectedIdMuestra = muestraDto.Idmuestra;
                        SelectedEnsayoRecordDto = null;
                        break;
                    case EnsayoRecordDto ensayoRecordDto:
                        SelectedEnsayoRecordDto = ensayoRecordDto;
                        DependenciasGlobalesForm.Instance.SelectedIdMuestra = ensayoRecordDto.IdMuestra;
                        break;
                    default:
                        DependenciasGlobalesForm.Instance.SelectedIdMuestra = 0;
                        break;
                }
            }
        }

        private void EnsayosProyecto_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mdiParent = (MainView)MdiParent!;
            mdiParent.ribbonPageEnsayos.Visible = false;
        }

        public void AddTabPageProctor(string tabName, EnsayoProctor? ensayoProctor)
        {
            // Crear y agregar la nueva pestaña
            var newPage = new XtraTabPage
            {
                Text = tabName,
                ShowCloseButton = DefaultBoolean.True
            };
            ensayoProctor ??= new EnsayoProctor();
           
            ListEnsayoProctor.Add(ensayoProctor);
            // Agregar el control deseado a la pestaña
            newPage.Controls.Add(new ProctorControl(ensayoProctor)
            {
                Dock = DockStyle.Fill
            });
            xtraTabControlEnsayos.TabPages.Add(newPage);
        }

        public async void FindEnsayos(int tipoEnsayo)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                if (SelectedEnsayoRecordDto is null)
                {
                    return;
                }
                
                var tipoEnsayoRepository = UnitOfWork.TipoEnsayoRepository;
                var ensayoProctorRepository = UnitOfWork.EnsayosProctorRepository;
                EnsayoRepository = UnitOfWork.EnsayosRepository;
                var findTipoEnsayo = await tipoEnsayoRepository.GetByIdAsync(tipoEnsayo);
                if (findTipoEnsayo is null)
                {
                    XtraMessageBox.Show("No se encontró el tipo de ensayo","Abrir ensayo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (findTipoEnsayo.Descripcion=="Proctor")
                {
                    var findEnsayoProctor = await ensayoProctorRepository.GetByCriteriaAsync(proctor =>
                        proctor.Idmuestra == SelectedEnsayoRecordDto.IdMuestra);
                    if (findEnsayoProctor.Count <= 0) return;
                    xtraTabControlEnsayos.TabPages.Clear();
                    foreach (var ensayoProctor in findEnsayoProctor)
                    {
                        AddTabPageProctor("Proctor", ensayoProctor);
                    }

                }
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al recuperar los ensayos");
            }
        }


        private void treeListEnsayos_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == TreeListMenuType.Node)
            {
                e.ShowCustomMenu(popupMenuEnsayos);
            }
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item== barButtonItemVerEnsayo)
            {
                if (SelectedEnsayoRecordDto is null)
                {
                    return;
                }
                FindEnsayos(SelectedEnsayoRecordDto.IdTipoEnsayo);
            }
        }
    }
}