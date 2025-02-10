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
using Sistema.Proctor.Data;
using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    public partial class EnsayosProyecto : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEnsayoRepository EnsayoRepository;
        public EnsayosProyecto()
        {
            InitializeComponent();
            EnsayoRepository = DependenciasGlobales.Instance.GetService<IEnsayoRepository>();
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
                    var muestraNode = treeListEnsayos.AppendNode(new object[] { muestra.CodigoIngreso }, null);
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
                if (selectedValue is EnsayoRecordDto ensayoRecordDto)
                {

                }

            }
        }

        private void EnsayosProyecto_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mdiParent = (MainView)MdiParent!;
            mdiParent.ribbonPageEnsayos.Visible = false;
        }
    }
}