using Sistema.Proctor.WinForm.Data;
using System.ComponentModel;

namespace Sistema.Proctor.WinForm.Views.Empleado;

public partial class SelectEmpleadoDialog : Template.EditForm
{

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Proctor.Data.Entities.Empleado? EmpleadoSeleccionado { get; private set; }

    public SelectEmpleadoDialog()
    {
        InitializeComponent();

    }

    private async void SelectEmpleadoDialog_Load(object sender, EventArgs e)
    {
        try
        {
            await Task.Run(DependenciasGlobalesForm.Instance.FillListadoEmpleados);
            empleadoBindingSource.DataSource = DependenciasGlobalesForm.Instance.ListadoEmpleados;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        var focused = gridViewSeleccionarEmpleado.GetFocusedRow() as Proctor.Data.Entities.Empleado;
        if (focused is null)
        {
            return;
        }

        EmpleadoSeleccionado = focused;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        EmpleadoSeleccionado = null;
    }
}