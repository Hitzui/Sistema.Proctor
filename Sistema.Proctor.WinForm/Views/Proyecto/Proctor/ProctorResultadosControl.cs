using DevExpress.XtraEditors;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Helpers;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Proctor
{
    public partial class ProctorResultadosControl : DevExpress.XtraEditors.XtraUserControl
    {
        public readonly ResultadosProctor ResultadosProctor;

        public ProctorResultadosControl(ResultadosProctor resultadosProctor)
        {
            InitializeComponent();
            ResultadosProctor = resultadosProctor;
            resultadosProctorBindingSource.DataSource = ResultadosProctor;
            foreach (var control in layoutControl1.Controls)
            {
                if (control is TextEdit textEdit)
                {
                    switch (textEdit.Name)
                    {
                        case "txtTaraNo":
                            continue;
                        default:
                            HelperMethods.OnlyDecimals(textEdit);
                            break;
                    }
                }
            }
        }

        private void ProctorResultadosControl_Load(object sender, EventArgs e)
        {
        }

        private void txtPesoMoldeMaterialHumedo_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtPesoMaterialHumedo.Text))
            //{
            //    ResultadosProctor.PesoMoldeMaterialHumedo = decimal.Zero;
            //    return;
            //}
            //ResultadosProctor.PesoMoldeMaterialHumedo = decimal.Parse(txtPesoMoldeMaterialHumedo.Text);
            ResultadosProctor.PesoMoldeMaterialHumedo ??= decimal.Zero;
            if (ResultadosProctor.PesoMolde is not null)
            {
                var pesoMaterialHumedo = Formulas.PesoMaterialHumedo(ResultadosProctor.PesoMoldeMaterialHumedo.Value,
                    ResultadosProctor.PesoMolde.Value);
                ResultadosProctor.PesoMaterialHumedo = pesoMaterialHumedo;
                if (ResultadosProctor.VolumenMolde is not null)
                {
                    ResultadosProctor.DensidadHumeda = Formulas.DensidadHumeda(pesoMaterialHumedo, ResultadosProctor.VolumenMolde.Value);
                }
            }
        }

        private void txtPesoMolde_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesoMolde.Text))
            {
                ResultadosProctor.PesoMolde = decimal.Zero;
                return;
            }
            ResultadosProctor.PesoMolde = decimal.Parse(txtPesoMolde.Text);
            if (ResultadosProctor.PesoMoldeMaterialHumedo is not null)
            {
                var pesoMaterialHumedo = Formulas.PesoMaterialHumedo(ResultadosProctor.PesoMoldeMaterialHumedo.Value,
                    ResultadosProctor.PesoMolde.Value);
                ResultadosProctor.PesoMaterialHumedo = pesoMaterialHumedo;
                if (ResultadosProctor.VolumenMolde is not null)
                {
                    ResultadosProctor.DensidadHumeda = Formulas.DensidadHumeda(pesoMaterialHumedo, ResultadosProctor.VolumenMolde.Value);
                }
            }
        }

        private void txtTaraMaterialHumedo_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaraMaterialHumedo.Text))
            {
                ResultadosProctor.TaraMaterialHumedo = decimal.Zero;
                return;
            }

            ResultadosProctor.TaraMaterialHumedo = decimal.Parse(txtTaraMaterialHumedo.Text);
            if (ResultadosProctor.TaraMaterialSeco is not null)
            {
                ResultadosProctor.PesoAgua = decimal.Subtract(ResultadosProctor.TaraMaterialHumedo.Value,
                    ResultadosProctor.TaraMaterialSeco.Value);
            }
        }

        private void txtTaraMaterialSeco_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaraMaterialSeco.Text))
            {
                ResultadosProctor.TaraMaterialSeco = decimal.Zero;
                return;
            }

            if (!decimal.TryParse(txtTaraMaterialSeco.Text, out var taraMaterialSeco))
            {
                throw new InvalidOperationException("El valor ingresado no es un número válido.");
            }

            ResultadosProctor.TaraMaterialSeco = taraMaterialSeco;

            // Verificar si TaraMaterialHumedo tiene un valor
            if (ResultadosProctor.TaraMaterialHumedo.HasValue)
            {
                // Asegurarse de que el peso del suelo seco no sea cero
                var pesoSueloSeco = ResultadosProctor.PesoSueloSeco ?? decimal.One;
                if (pesoSueloSeco == decimal.Zero)
                {
                    pesoSueloSeco = decimal.One;
                }

                // Calcular el peso del agua
                var pesoAgua = ResultadosProctor.TaraMaterialHumedo.Value - taraMaterialSeco;

                // Calcular el contenido de humedad
                var contenidoHumedad = (pesoAgua / pesoSueloSeco) * 100;

                // Asignar los valores calculados a las propiedades de ResultadosProctor
                ResultadosProctor.PesoSueloSeco = pesoSueloSeco;
                ResultadosProctor.PesoAgua = pesoAgua;
                ResultadosProctor.ContenidoHumedad = contenidoHumedad;
                if (ResultadosProctor.ContenidoHumedad.HasValue)
                {
                    ResultadosProctor.AguaAgregada = contenidoHumedad;
                }
            }
        }

        private void txtPesoTara_EditValueChanged(object sender, EventArgs e)
        {
            // Validar si el texto es nulo o está vacío
            if (string.IsNullOrWhiteSpace(txtPesoTara.Text))
            {
                ResultadosProctor.PesoTara = decimal.Zero;
                return;
            }

            // Intentar parsear el valor del texto a decimal
            if (!decimal.TryParse(txtPesoTara.Text, out var pesoTara))
            {
                // Manejar el error de conversión, por ejemplo, lanzar una excepción o mostrar un mensaje al usuario
                throw new InvalidOperationException("El valor ingresado no es un número válido.");
            }

            ResultadosProctor.PesoTara = pesoTara;

            // Verificar si TaraMaterialSeco tiene un valor
            if (ResultadosProctor.TaraMaterialSeco.HasValue)
            {
                // Calcular el peso del suelo seco
                var pesoSueloSeco = ResultadosProctor.TaraMaterialSeco.Value - pesoTara;

                // Asegurarse de que el peso del suelo seco no sea cero
                pesoSueloSeco = pesoSueloSeco == decimal.Zero ? decimal.One : pesoSueloSeco;

                // Calcular el contenido de humedad si PesoAgua tiene un valor
                if (ResultadosProctor.PesoAgua.HasValue)
                {
                    ResultadosProctor.ContenidoHumedad = (ResultadosProctor.PesoAgua.Value / pesoSueloSeco) * 100;
                    if (ResultadosProctor.ContenidoHumedad.HasValue)
                    {
                        ResultadosProctor.AguaAgregada = ResultadosProctor.ContenidoHumedad;
                    }
                }

                // Asignar el valor calculado a PesoSueloSeco
                ResultadosProctor.PesoSueloSeco = pesoSueloSeco;
            }
        }

        private void txtContenidoHumedad_EditValueChanged(object sender, EventArgs e)
        {
            if (ResultadosProctor.DensidadHumeda.HasValue)
            {
                ResultadosProctor.DensidadSeca = Formulas.DensidadSeca(ResultadosProctor.DensidadHumeda.Value,
                    ResultadosProctor.ContenidoHumedad ?? decimal.One);
            }
        }
    }
}
