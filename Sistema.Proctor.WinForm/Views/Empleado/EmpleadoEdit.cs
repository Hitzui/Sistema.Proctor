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
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Empleado
{
    public partial class EmpleadoEdit : EditForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private EmpleadoDto? _EmpleadoDto;

        public EmpleadoEdit()
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardarOnClick;
        }

        private async void BtnGuardarOnClick(object? sender, EventArgs e)
        {
            try
            {
                if (dxErrorProvider.HasErrors)
                {
                    await XtraMessageBox.ShowAsync("Llenar todos los campos para poder continuar");
                    return;
                }

                var confirm = XtraMessageBox.Show("¿Guardar datos del Cliente?", "Guardar", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (confirm == DialogResult.Cancel)
                {
                    return;
                }

                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var empleadoRepository = unitOfWork.EmpleadoRepository;
                var empleadoDto = empleadoDtoBindingSource.Current as EmpleadoDto;
                var empleado = empleadoDto.GetEmpleado();
                if (IsNew)
                {
                    await empleadoRepository.AddAsync(empleado);
                }
                else
                {
                    empleadoRepository.Update(empleado);
                }
                await unitOfWork.CompleteAsync();

                if (IsNew)
                {
                    DependenciasGlobalesForm.Instance.ListadoEmpleados.Add(empleado);
                }
                else
                {
                    DependenciasGlobalesForm.Instance.FillListadoEmpleados();
                }

                await XtraMessageBox.ShowAsync("Se han guardado los datos de forma correcta");
                Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error");
            }
        }

        private void EmpleadoEdit_Load(object sender, EventArgs e)
        {
            if (DependenciasGlobalesForm.Instance.SelectedEmpleado is null)
            {
                _EmpleadoDto = new EmpleadoDto();
                IsNew = true;
            }
            else
            {
                _EmpleadoDto = DependenciasGlobalesForm.Instance.SelectedEmpleado;
                IsNew = false;
            }

            empleadoDtoBindingSource.DataSource = _EmpleadoDto;
        }
    }
}