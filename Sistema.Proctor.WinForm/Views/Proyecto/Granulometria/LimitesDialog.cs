using DevExpress.XtraEditors;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Helpers;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Granulometria
{
    public partial class LimitesDialog : EditForm
    {
        public bool AddLimiteLiquido;
        public bool AddLimitePlastico;
        public LimiteLiquidoDto LimiteLiquidoDto { get; set; }
        public LimitePlasticoDto LimitePlasticoDto { get; set; }

        public LimitesDialog()
        {
            InitializeComponent();
        }

        private void LimitesDialog_Load(object sender, EventArgs e)
        {
            btnGuardar.Text = @"Aceptar";
            LoadValues();
            HelperMethods.OnlyDecimals(txtPesoTara);
            HelperMethods.OnlyDecimals(txtPesoTara2);
            HelperMethods.OnlyDecimals(txtPesoTaraMuestraHumeda);
            HelperMethods.OnlyDecimals(txtPesoTaraMuestraHumeda2);
            HelperMethods.OnlyDecimals(txtPesoTaraMuestraSeca);
            HelperMethods.OnlyDecimals(txtPesoTaraMuestraSeca2);
            HelperMethods.OnlyDecimals(txtPesoMuestraSeca);
            HelperMethods.OnlyDecimals(txtPesoMuestraSeca2);
            HelperMethods.OnlyDecimals(txtPesoAgua);
            HelperMethods.OnlyDecimals(txtPesoAgua2);
            HelperMethods.OnlyDecimals(txtLimiteLiquido);
            HelperMethods.OnlyDecimals(txtLimitePlastico);
        }

        private void LoadValues()
        {
            txtNoGolpes.EditValue = LimiteLiquidoDto.NumGolpes;
            txtPesoTara.EditValue = LimiteLiquidoDto.PesoTara;
            txtPesoTaraMuestraHumeda.EditValue = LimiteLiquidoDto.PesoTaraMuestraHumeda;
            txtPesoTaraMuestraSeca.EditValue = LimiteLiquidoDto.PesoTaraMuestraSeca;
            txtPesoMuestraSeca.EditValue = LimiteLiquidoDto.PesoMuestraSeca;
            txtPesoAgua.EditValue = LimiteLiquidoDto.PesoAgua;
            txtLimiteLiquido.EditValue = LimiteLiquidoDto.Humedad;
            txtCodigoTara.EditValue = LimiteLiquidoDto.CodigoTara;

            txtPesoTara2.EditValue = LimitePlasticoDto.PesoTara;
            txtPesoTaraMuestraHumeda2.EditValue = LimitePlasticoDto.PesoTaraMuestraHumeda;
            txtPesoTaraMuestraSeca2.EditValue = LimitePlasticoDto.PesoTaraMuestraSeca;
            txtPesoMuestraSeca2.EditValue = LimitePlasticoDto.PesoMuestraSeca;
            txtPesoAgua2.EditValue = LimitePlasticoDto.PesoAgua;
            txtLimitePlastico.EditValue = LimitePlasticoDto.Humedad;
            txtCodigoTara2.EditValue = LimitePlasticoDto.CodigoTara;
        }

        private void CalcularLimite(
            TextEdit pesoTaraTextEdit, 
            TextEdit pesoTaraMuestraHumedaTextEdit,
            TextEdit pesoTaraMuestraSecaTextEdit, 
            TextEdit pesoMuestraSecaTextedit, 
            TextEdit pesoAguaTextEdit, 
            TextEdit limiteTextEdit)
        {
            var pesoTara = HelperMethods.ConvertToDecimal(pesoTaraTextEdit);
            var pesoTaraMuestraHumeda = HelperMethods.ConvertToDecimal(pesoTaraMuestraHumedaTextEdit);
            var pesoTaraMuestraseca = HelperMethods.ConvertToDecimal(pesoTaraMuestraSecaTextEdit);

            if (pesoTaraMuestraHumeda == 0 || pesoTaraMuestraseca == 0)
            {
                return;
            }

            var pesoMuestraSeca = pesoTaraMuestraseca - pesoTara;
            var pesoAgua = pesoTaraMuestraHumeda - pesoTaraMuestraseca;
            var limite = (pesoAgua / pesoMuestraSeca) * 100;

            pesoMuestraSecaTextedit.Text = pesoMuestraSeca.ToString("F2");
            pesoAguaTextEdit.Text = pesoAgua.ToString("F2");
            limiteTextEdit.Text = limite.ToString("F2");
        }

        private void CalcularLimiteLiquido()
        {
            CalcularLimite(txtPesoTara, txtPesoTaraMuestraHumeda, txtPesoTaraMuestraSeca, txtPesoMuestraSeca,
                txtPesoAgua, txtLimiteLiquido);
        }

        private void CalcularLimitePlastico()
        {
            CalcularLimite(txtPesoTara2, txtPesoTaraMuestraHumeda2, txtPesoTaraMuestraSeca2, txtPesoMuestraSeca2,
                txtPesoAgua2, txtLimitePlastico);
        }

        private void txtPesoTara_EditValueChanged(object sender, EventArgs e)
        {
            CalcularLimiteLiquido();
        }

        private void txtPesoTaraMuestraHumeda_EditValueChanged(object sender, EventArgs e)
        {
            CalcularLimiteLiquido();
        }

        private void txtPesoTaraMuestraSeca_EditValueChanged(object sender, EventArgs e)
        {
            CalcularLimiteLiquido();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var limiteLiquido = HelperMethods.ConvertToDecimal(txtLimiteLiquido);
            if (limiteLiquido.CompareTo(decimal.Zero) > 0)
            {
                if (string.IsNullOrWhiteSpace(txtNoGolpes.Text))
                {
                    XtraMessageBox.Show("Debe especificar los número de golpes", "Limites", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var noGolpes = HelperMethods.ConvertToInt(txtNoGolpes);
                LimiteLiquidoDto.NumGolpes = noGolpes;
                LimiteLiquidoDto.CodigoTara = txtCodigoTara.Text;
                LimiteLiquidoDto.PesoTara = HelperMethods.ConvertToDecimal(txtPesoTara);
                LimiteLiquidoDto.PesoTaraMuestraHumeda = HelperMethods.ConvertToDecimal(txtPesoTaraMuestraHumeda);
                LimiteLiquidoDto.PesoTaraMuestraSeca = HelperMethods.ConvertToDecimal(txtPesoTaraMuestraSeca);
                LimiteLiquidoDto.PesoMuestraSeca = HelperMethods.ConvertToDecimal(txtPesoMuestraSeca);
                LimiteLiquidoDto.PesoAgua = HelperMethods.ConvertToDecimal(txtPesoAgua);
                LimiteLiquidoDto.Humedad = HelperMethods.ConvertToDecimal(txtLimiteLiquido);
                AddLimiteLiquido = true;
            }

            var limitePlastico = HelperMethods.ConvertToDecimal(txtLimitePlastico);
            if (limitePlastico.CompareTo(decimal.Zero) > 0)
            {
                LimitePlasticoDto.CodigoTara = txtCodigoTara2.Text;
                LimitePlasticoDto.PesoTara = HelperMethods.ConvertToDecimal(txtPesoTara2);
                LimitePlasticoDto.PesoTaraMuestraHumeda = HelperMethods.ConvertToDecimal(txtPesoTaraMuestraHumeda2);
                LimitePlasticoDto.PesoTaraMuestraSeca = HelperMethods.ConvertToDecimal(txtPesoTaraMuestraSeca2);
                LimitePlasticoDto.PesoMuestraSeca = HelperMethods.ConvertToDecimal(txtPesoMuestraSeca2);
                LimitePlasticoDto.PesoAgua = HelperMethods.ConvertToDecimal(txtPesoAgua2);
                LimitePlasticoDto.Humedad = HelperMethods.ConvertToDecimal(txtLimitePlastico);
                AddLimitePlastico = true;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtPesoTara2_EditValueChanged(object sender, EventArgs e)
        {
            CalcularLimitePlastico();
        }
    }
}