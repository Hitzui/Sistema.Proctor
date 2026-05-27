using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using Sistema.Proctor.WinForm.Dto;
using DevExpress.Utils;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Views.Proyecto.Proctor;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Granulometria
{
    public partial class LimitesControl : DevExpress.XtraEditors.XtraUserControl
    {
        private List<LimiteLiquidoDto> _listaLimiteLiquidoDtos=new();
        private int _Counter = 0;
        public LimitesControl(EnsayoLimitesDto ensayoLimite)
        {
            InitializeComponent();
            ensayoLimitesDtoBindingSource.DataSource = ensayoLimite;
        }

        private void xtraTabControlLimites_CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                AddPage();
            }
        }

        private void AddPage(LimiteLiquidoDto? limiteLiquidoDto = null)
        {
            limiteLiquidoDto ??= new LimiteLiquidoDto();
            _Counter++;
            _listaLimiteLiquidoDtos.Add(limiteLiquidoDto);
            var limitesLiquidoControl = new ResultadoLimitesControl()
            {
                Dock = DockStyle.Fill
            };
            var xtraTabPage = new XtraTabPage()
            {
                Text = $@"Limite Liquido {_Counter}",
                ShowCloseButton = DefaultBoolean.True
            };
            xtraTabPage.Controls.Clear();
            xtraTabPage.Controls.Add(limitesLiquidoControl);
            xtraTabPage.Tag = limitesLiquidoControl;
            xtraTabControlLimites.TabPages.Add(xtraTabPage);
            xtraTabControlLimites.SelectedTabPage = xtraTabPage;
        }

        private void controlNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var limitesDialog = new LimitesDialog();
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                e.Handled = true;

                limitesDialog.LimiteLiquidoDto = new();
                limitesDialog.LimitePlasticoDto = new();
                if (limitesDialog.ShowDialog() == DialogResult.OK)
                {
                    if (limitesDialog.AddLimiteLiquido)
                    {
                        limiteLiquidoDtoBindingSource.Add(limitesDialog.LimiteLiquidoDto);
                    }

                    if (limitesDialog.AddLimitePlastico)
                    {
                        limitePlasticoDtoBindingSource.Add(limitesDialog.LimitePlasticoDto);
                    }
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Custom)
            {
                var selectedValue = limiteLiquidoDtoBindingSource.Current as LimiteLiquidoDto;
                var selectedLimitePlastico = limitePlasticoDtoBindingSource.Current as LimitePlasticoDto;
                if (selectedValue == null && selectedLimitePlastico == null) return;
                limitesDialog.LimiteLiquidoDto = selectedValue ?? new();
                limitesDialog.LimitePlasticoDto = selectedLimitePlastico ?? new();
                if (limitesDialog.ShowDialog() == DialogResult.OK)
                {
                    limiteLiquidoDtoBindingSource.ResetCurrentItem();
                    limitePlasticoDtoBindingSource.ResetCurrentItem();
                }
            }
        }

        private void cardViewLimiteLiquido_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            controlNavigator1.NavigatableControl = gridControlResultadoLimiteLiquido;
        }

        private void cardViewLimitePlastico_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            controlNavigator1.NavigatableControl = gridControlLimitePlastico;
        }
    }
}
