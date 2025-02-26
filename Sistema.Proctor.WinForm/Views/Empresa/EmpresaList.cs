using DevExpress.XtraEditors;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Views.Empresa
{
    public partial class EmpresaList : XtraForm
    {
        public EmpresaList()
        {
            InitializeComponent();

        }

        private void EmpresaList_Load(object sender, EventArgs e)
        {
            gridControlEmpresas.DataSource = DependenciasGlobalesForm.Instance.ListadoEmpresas;
        }

        private void gridViewEmpresas_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRow = (Proctor.Data.Entities.Empresa)gridViewEmpresas.FocusedRowObject;
            if (selectedRow is not null)
            {
                DependenciasGlobalesForm.Instance.SelectedEmpresa = selectedRow;
            }
        }
    }
}