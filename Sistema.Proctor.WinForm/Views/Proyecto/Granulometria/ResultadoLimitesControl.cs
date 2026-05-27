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
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Granulometria
{
    public partial class ResultadoLimitesControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ResultadoLimitesControl()
        {
            InitializeComponent();
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