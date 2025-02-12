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
using DevExpress.Utils;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.ViewInfo;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Proctor
{
    public partial class ProctorControl : DevExpress.XtraEditors.XtraUserControl
    {
        private EnsayoProctor EnsayoProctor;
        public ProctorControl()
        {
            InitializeComponent();
            EnsayoProctor = new EnsayoProctor();
            EnsayoProctor.DiametroMoldeCm = 15.2m;
            EnsayoProctor.AlturaMoldeCm = 12.0m;
            ensayoProctorBindingSource.DataSource = EnsayoProctor;
        }

        private void tabResultadosProctor_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                AddPage();
            }
        }

        private void AddPage()
        {
            var countPages = tabResultadosProctor.TabPages.Count + 1;
            var resultadoProctor = new ResultadosProctor();
            if (EnsayoProctor.DiametroMoldeCm is not null && EnsayoProctor.AlturaMoldeCm is not null)
            {
                var volumen = Formulas.VolumenCilindro((decimal)EnsayoProctor.DiametroMoldeCm, (decimal)EnsayoProctor.AlturaMoldeCm);
                resultadoProctor.VolumenMolde = volumen;
            }
            else
            {
                resultadoProctor.VolumenMolde = decimal.Zero;
            }
            var proctorResultados = new ProctorResultadosControl(resultadoProctor)
            {
                Dock = DockStyle.Fill
            };
            var xtraTabPage = new XtraTabPage()
            {
                Text = $@"Proctor {countPages}",
                ShowCloseButton = DefaultBoolean.True
            };
            xtraTabPage.Controls.Clear();
            xtraTabPage.Controls.Add(proctorResultados);
            tabResultadosProctor.TabPages.Add(xtraTabPage);
            tabResultadosProctor.SelectedTabPage = xtraTabPage;
        }

        private void ProctorControl_Load(object sender, EventArgs e)
        {
            AddPage();
            EnsayoProctor.FechaEnsayo = DateTime.Now;
        }

        private void tabResultadosProctor_CloseButtonClick(object sender, EventArgs e)
        {
            if (tabResultadosProctor.TabPages.Count <= 0) return;
            if (e is not ClosePageButtonEventArgs arg) return;
            var xtraTabPage = arg.Page as XtraTabPage;
            tabResultadosProctor.TabPages.Remove(xtraTabPage);
        }

        private void txtDiametroMoldeCm_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiametroMoldeCm.Text))
            {
                EnsayoProctor.DiametroMoldeCm = decimal.Zero;
                return;
            }
            EnsayoProctor.DiametroMoldeCm = decimal.Parse(txtDiametroMoldeCm.Text);
            if (EnsayoProctor.AlturaMoldeCm is not null)
            {
                var volumen = Formulas.VolumenCilindro(EnsayoProctor.DiametroMoldeCm.Value, EnsayoProctor.AlturaMoldeCm.Value);
                foreach (XtraTabPage tabPage in tabResultadosProctor.TabPages)
                {
                    var controlVolumen = tabPage.Controls.Find("txtVolumenMolde", true).FirstOrDefault();
                    if (controlVolumen is TextEdit edit)
                    {
                        edit.EditValue = volumen;
                    }
                }
            }
        }
    }
}
