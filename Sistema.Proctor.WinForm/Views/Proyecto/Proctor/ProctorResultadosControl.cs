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
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Helpers;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Proctor
{
    public partial class ProctorResultadosControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ResultadosProctor _ResultadosProctor;

        public ProctorResultadosControl(ResultadosProctor resultadosProctor)
        {
            InitializeComponent();
            _ResultadosProctor = resultadosProctor;
            resultadosProctorBindingSource.DataSource = _ResultadosProctor;
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
            if (string.IsNullOrWhiteSpace(txtPesoMaterialHumedo.Text))
            {
                _ResultadosProctor.PesoMoldeMaterialHumedo = decimal.Zero;
                return;
            }
            _ResultadosProctor.PesoMoldeMaterialHumedo = decimal.Parse(txtPesoMoldeMaterialHumedo.Text);
            if (_ResultadosProctor.PesoMolde is not null)
            {
                var pesoMaterialHumedo = Formulas.PesoMaterialHumedo(_ResultadosProctor.PesoMoldeMaterialHumedo.Value,
                    _ResultadosProctor.PesoMolde.Value);
                _ResultadosProctor.PesoMaterialHumedo = pesoMaterialHumedo;
                if (_ResultadosProctor.VolumenMolde is not null)
                {
                    _ResultadosProctor.DensidadHumeda = Formulas.DensidadHumeda(pesoMaterialHumedo, _ResultadosProctor.VolumenMolde.Value);
                }
            }
        }

        private void txtPesoMolde_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesoMolde.Text))
            {
                _ResultadosProctor.PesoMolde = decimal.Zero;
                return;
            }
            _ResultadosProctor.PesoMolde = decimal.Parse(txtPesoMolde.Text);
            if (_ResultadosProctor.PesoMoldeMaterialHumedo is not null)
            {
                var pesoMaterialHumedo = Formulas.PesoMaterialHumedo(_ResultadosProctor.PesoMoldeMaterialHumedo.Value,
                    _ResultadosProctor.PesoMolde.Value);
                _ResultadosProctor.PesoMaterialHumedo = pesoMaterialHumedo;
                if (_ResultadosProctor.VolumenMolde is not null)
                {
                    _ResultadosProctor.DensidadHumeda = Formulas.DensidadHumeda(pesoMaterialHumedo, _ResultadosProctor.VolumenMolde.Value);
                }
            }
        }

        private void txtTaraMaterialHumedo_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaraMaterialHumedo.Text))
            {
                _ResultadosProctor.TaraMaterialHumedo = decimal.Zero;
                return;
            }

            _ResultadosProctor.TaraMaterialHumedo = decimal.Parse(txtTaraMaterialHumedo.Text);
            if (_ResultadosProctor.TaraMaterialSeco is not null)
            {
                _ResultadosProctor.PesoAgua = decimal.Subtract(_ResultadosProctor.TaraMaterialHumedo.Value,
                    _ResultadosProctor.TaraMaterialSeco.Value);
            }
        }

        private void txtTaraMaterialSeco_EditValueChanged(object sender, EventArgs e)
        {
            // Validar si el texto es nulo o está vacío
            if (string.IsNullOrWhiteSpace(txtTaraMaterialSeco.Text))
            {
                _ResultadosProctor.TaraMaterialSeco = decimal.Zero;
                return;
            }

            // Intentar parsear el valor del texto a decimal
            if (!decimal.TryParse(txtTaraMaterialSeco.Text, out var taraMaterialSeco))
            {
                // Manejar el error de conversión, por ejemplo, lanzar una excepción o mostrar un mensaje al usuario
                throw new InvalidOperationException("El valor ingresado no es un número válido.");
            }

            _ResultadosProctor.TaraMaterialSeco = taraMaterialSeco;

            // Verificar si TaraMaterialHumedo tiene un valor
            if (_ResultadosProctor.TaraMaterialHumedo.HasValue)
            {
                // Asegurarse de que el peso del suelo seco no sea cero
                var pesoSueloSeco = _ResultadosProctor.PesoSueloSeco ?? decimal.One;
                if (pesoSueloSeco == decimal.Zero)
                {
                    pesoSueloSeco = decimal.One;
                }

                // Calcular el peso del agua
                var pesoAgua = _ResultadosProctor.TaraMaterialHumedo.Value - taraMaterialSeco;

                // Calcular el contenido de humedad
                var contenidoHumedad = (pesoAgua / pesoSueloSeco) * 100;

                // Asignar los valores calculados a las propiedades de ResultadosProctor
                _ResultadosProctor.PesoSueloSeco = pesoSueloSeco;
                _ResultadosProctor.PesoAgua = pesoAgua;
                _ResultadosProctor.ContenidoHumedad = contenidoHumedad;
                if (_ResultadosProctor.ContenidoHumedad.HasValue)
                {
                    _ResultadosProctor.AguaAgregada = contenidoHumedad;
                }
            }
        }

        private void txtPesoTara_EditValueChanged(object sender, EventArgs e)
        {
            // Validar si el texto es nulo o está vacío
            if (string.IsNullOrWhiteSpace(txtPesoTara.Text))
            {
                _ResultadosProctor.PesoTara = decimal.Zero;
                return;
            }

            // Intentar parsear el valor del texto a decimal
            if (!decimal.TryParse(txtPesoTara.Text, out var pesoTara))
            {
                // Manejar el error de conversión, por ejemplo, lanzar una excepción o mostrar un mensaje al usuario
                throw new InvalidOperationException("El valor ingresado no es un número válido.");
            }

            _ResultadosProctor.PesoTara = pesoTara;

            // Verificar si TaraMaterialSeco tiene un valor
            if (_ResultadosProctor.TaraMaterialSeco.HasValue)
            {
                // Calcular el peso del suelo seco
                var pesoSueloSeco = _ResultadosProctor.TaraMaterialSeco.Value - pesoTara;

                // Asegurarse de que el peso del suelo seco no sea cero
                pesoSueloSeco = pesoSueloSeco == decimal.Zero ? decimal.One : pesoSueloSeco;

                // Calcular el contenido de humedad si PesoAgua tiene un valor
                if (_ResultadosProctor.PesoAgua.HasValue)
                {
                    _ResultadosProctor.ContenidoHumedad = (_ResultadosProctor.PesoAgua.Value / pesoSueloSeco) * 100;
                    if (_ResultadosProctor.ContenidoHumedad.HasValue)
                    {
                        _ResultadosProctor.AguaAgregada = _ResultadosProctor.ContenidoHumedad;
                    }
                }

                // Asignar el valor calculado a PesoSueloSeco
                _ResultadosProctor.PesoSueloSeco = pesoSueloSeco;
            }
        }

        private void txtContenidoHumedad_EditValueChanged(object sender, EventArgs e)
        {
            if (_ResultadosProctor.DensidadHumeda.HasValue)
            {
                _ResultadosProctor.DensidadSeca = Formulas.DensidadSeca(_ResultadosProctor.DensidadHumeda.Value,
                    _ResultadosProctor.ContenidoHumedad ?? decimal.One);
            }
        }
    }
}
