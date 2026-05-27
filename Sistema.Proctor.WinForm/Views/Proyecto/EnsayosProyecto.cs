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
using Sistema.Proctor.WinForm.Views.Proyecto.Humedad;
using Sistema.Proctor.WinForm.Views.Proyecto.Proctor;
using TipoEnsayo = Sistema.Proctor.WinForm.Data.Enum.TipoEnsayo;

namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    public partial class EnsayosProyecto : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public XtraTabControl xtraTabControlEnsayos;
        private Panel panelIzquierdo;
        public List<EnsayoProctor> ListEnsayoProctor = new();
        public List<EnsayoHumedadDto> ListaEnsayoHumedad = new();
        public List<EnsayoLimitesDto> ListaEnsayoLimites = new();
        public EnsayoRecordDto? SelectedEnsayoRecordDto;
        private IEnsayoRepository EnsayoRepository;
        private readonly IUnitOfWork? UnitOfWork;
        private readonly Dictionary<XtraTabPage, object> _tabPageEnsayoMap = new();

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
            if (sender is not XtraTabControl { SelectedTabPage: not null } tabControl) return;
            var selectedPage = tabControl.SelectedTabPage;

            if (_tabPageEnsayoMap.TryGetValue(selectedPage, out var ensayoObj))
            {
                // Eliminar el ensayo correspondiente de la lista asociada
                switch (ensayoObj)
                {
                    case EnsayoProctor ensayoProctor:
                        ListEnsayoProctor.Remove(ensayoProctor);
                        break;
                    case EnsayoHumedadDto ensayoHumedad:
                        ListaEnsayoHumedad.Remove(ensayoHumedad);
                        break;
                    // Agregar más casos según sea necesario para otros tipos de ensayos
                }

                _tabPageEnsayoMap.Remove(selectedPage);
            }

            tabControl.TabPages.Remove(selectedPage);
        }

        private async void EnsayosProyecto_Load(object sender, EventArgs e)
        {
            try
            {
                var findAll = DependenciasGlobalesForm.Instance.ListadoMuestras;
                treeListEnsayos.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn()
                    { Caption = @"Codigo muestra", VisibleIndex = 0 });
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

        private void treeListEnsayos_FocusedNodeChanged(object sender,
            DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
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

        public void AddTabPage<TEnsayo, TControl>(TipoEnsayo tipoEnsayo, TEnsayo? ensayo,
            IList<TEnsayo> listaEnsayos, Func<TEnsayo, TControl> controlFactory)
            where TEnsayo : new()
            where TControl : Control
        {
            // Crear y agregar la nueva pestaña
            var newPage = new XtraTabPage
            {
                Tag = tipoEnsayo,
                Text = tipoEnsayo.ToString(),
                ShowCloseButton = DefaultBoolean.True
            };

            ensayo ??= new TEnsayo();
            listaEnsayos.Add(ensayo);

            // Asocia la pestaña con su lista para facilitar la eliminación
            _tabPageEnsayoMap[newPage] = listaEnsayos;

            // Crear el control y agregarlo a la pestaña
            var control = controlFactory(ensayo);
            control.Dock = DockStyle.Fill;
            newPage.Controls.Add(control);

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
                var ensayoHumedadRepository = UnitOfWork.EnsayoHumedadRepository;
                EnsayoRepository = UnitOfWork.EnsayosRepository;
                var findTipoEnsayo = await tipoEnsayoRepository.GetByIdAsync(tipoEnsayo);
                if (findTipoEnsayo is null)
                {
                    XtraMessageBox.Show("No se encontró el tipo de ensayo", "Abrir ensayo", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                switch (findTipoEnsayo.Descripcion)
                {
                    case "Proctor":
                    {
                        var findEnsayoProctor = await ensayoProctorRepository.GetByCriteriaAsync(proctor =>
                            proctor.Idmuestra == SelectedEnsayoRecordDto.IdMuestra);
                        if (findEnsayoProctor.Count <= 0) return;
                        xtraTabControlEnsayos.TabPages.Clear();
                        foreach (var ensayoProctor in findEnsayoProctor)
                        {
                            AddTabPage(TipoEnsayo.Proctor, ensayoProctor, ListEnsayoProctor,
                                proctor => new ProctorControl(proctor));
                        }

                        break;
                    }
                    case "Humedad":
                        var findEnsayoHumedad = await ensayoHumedadRepository.GetByCriteriaAsync(proctor =>
                            proctor.Idmuestra == SelectedEnsayoRecordDto.IdMuestra);
                        if (findEnsayoHumedad.Count <= 0) return;
                        xtraTabControlEnsayos.TabPages.Clear();
                        foreach (var humedadDto in findEnsayoHumedad.Select(ensayoHumedad =>
                                     new EnsayoHumedadDto().GetEnsayoHumedadDto(ensayoHumedad)))
                        {
                            AddTabPage(TipoEnsayo.Humedad, humedadDto, ListaEnsayoHumedad,
                                humedad => new HumedadControl(humedad));
                        }

                        break;
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al recuperar los ensayos");
            }
        }


        private void treeListEnsayos_PopupMenuShowing(object sender,
            DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == TreeListMenuType.Node)
            {
                e.ShowCustomMenu(popupMenuEnsayos);
            }
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item == barButtonItemVerEnsayo)
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