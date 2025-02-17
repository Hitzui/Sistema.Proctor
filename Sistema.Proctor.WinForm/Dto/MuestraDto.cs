using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using MySqlX.XDevAPI;
using Sistema.Proctor.Data.Entities;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Dto;

public class MuestraDto: INotifyPropertyChanged, IDXDataErrorInfo
{
    private int _Idmuestra;

    private int? _Idproyecto;

    private string _SondeoNumero;

    private string _MuestraNumero;

    private string _Coordenadas;

    private string _LadoBanda;

    private string _DescripcionMaterial;

    private DateTime? _FechaEnsayo;

    private string _CoordeandasZ;

    private int? _Idempleado;

    private string _CodigoIngreso;

    private Proyecto? _Proyecto;

    private Empleado? _Empleado;

    public MuestraDto(int idmuestra, int? idproyecto, string sondeoNumero, string muestraNumero, string coordenadas, string ladoBanda, string descripcionMaterial, DateTime? fechaEnsayo, string coordeandasZ, int? idempleado, string codigoIngreso, Proyecto? proyecto, Empleado? empleado)
    {
        _Idmuestra = idmuestra;
        _Idproyecto = idproyecto;
        _SondeoNumero = sondeoNumero;
        _MuestraNumero = muestraNumero;
        _Coordenadas = coordenadas;
        _LadoBanda = ladoBanda;
        _DescripcionMaterial = descripcionMaterial;
        _FechaEnsayo = fechaEnsayo;
        _CoordeandasZ = coordeandasZ;
        _Idempleado = idempleado;
        _CodigoIngreso = codigoIngreso;
        _Proyecto = proyecto;
        _Empleado = empleado;
    }

    public MuestraDto()
    {
        _Idproyecto = 0;
        _SondeoNumero = string.Empty;
        _MuestraNumero = string.Empty;
        _Coordenadas = string.Empty;
        _LadoBanda = string.Empty;
        _DescripcionMaterial = string.Empty;
        _FechaEnsayo = DateTime.Now;
        _CoordeandasZ = string.Empty;
        _Idempleado = 0;
        _CodigoIngreso = string.Empty;
        _Proyecto = null;
        _Empleado = null;
    }

    public int Idmuestra
    {
        get => _Idmuestra;
        set => SetField(ref _Idmuestra, value);
    }

    public int? Idproyecto
    {
        get => _Idproyecto;
        set => SetField(ref _Idproyecto, value);
    }

    public string SondeoNumero
    {
        get => _SondeoNumero;
        set => SetField(ref _SondeoNumero, value);
    }

    public string MuestraNumero
    {
        get => _MuestraNumero;
        set => SetField(ref _MuestraNumero, value);
    }

    public string Coordenadas
    {
        get => _Coordenadas;
        set => SetField(ref _Coordenadas, value);
    }

    public string LadoBanda
    {
        get => _LadoBanda;
        set => SetField(ref _LadoBanda, value);
    }

    public string DescripcionMaterial
    {
        get => _DescripcionMaterial;
        set => SetField(ref _DescripcionMaterial, value);
    }

    public DateTime? FechaEnsayo
    {
        get => _FechaEnsayo;
        set => SetField(ref _FechaEnsayo, value);
    }

    public string CoordeandasZ
    {
        get => _CoordeandasZ;
        set => SetField(ref _CoordeandasZ, value);
    }

    public int? Idempleado
    {
        get => _Idempleado;
        set => SetField(ref _Idempleado, value);
    }

    public string CodigoIngreso
    {
        get => _CodigoIngreso;
        set => SetField(ref _CodigoIngreso, value);
    }

    public Proyecto? Proyecto
    {
        get => _Proyecto;
        set => SetField(ref _Proyecto, value);
    }

    public Empleado? Empleado
    {
        get => _Empleado;
        set => SetField(ref _Empleado, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
    // Implements the IDXDataErrorInfo.GetPropertyError method.
    public void GetPropertyError(string propertyName, ErrorInfo info)
    {
        if (propertyName == "CodigoIngreso" && CodigoIngreso == "" ||
            propertyName == "MuestraNumero" && MuestraNumero == "" ||
            propertyName == "SondeoNumero" && SondeoNumero== "" ||
            propertyName == "Idempleado" && Idempleado == 0)
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    // IDXDataErrorInfo.GetError method
    public void GetError(ErrorInfo info)
    {
    }

    public Muestra GetMuestra()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MuestraProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<Muestra>(this);
    }

    public MuestraDto GetMuestraDto(Muestra muestra)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MuestraProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<MuestraDto>(muestra);
    }

    public override string ToString()
    {
        return CodigoIngreso;
    }
}