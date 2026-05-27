using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using NLog.Extensions.Logging;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sistema.Proctor.WinForm.Dto;

public class EnsayoHumedadDto : INotifyPropertyChanged, IDXDataErrorInfo
{
    private int _Idensayohumedad;

    private string _InformeNumero;

    private int? _Idmuestra;

    private DateTime? _FechaIngreso;

    private string _DescripcionMaterial;

    private DateTime? _FechaEmision;

    private string _MetodoMuestreo;

    private DateTime? _FechaMuestreo;

    private DateTime? _FechaInicio;

    private DateTime? _FechaFin;

    private string _CodigoIngreso;

    private string _Metodo;

    private string _RealizadoEn;

    private int? _CreatedBy;

    private DateTime _CreatedAt;

    private int? _UpdatedBy;

    private DateTime? _UpdateAt;

    private int? _EnsayadoPor;

    private int? _RevisadoPor;

    private int? _VerificadoPor;

    private int? _AutorizadoPor;

    private Muestra? _Muestra;

    public EnsayoHumedadDto()
    {
        _InformeNumero = string.Empty;
        _Idmuestra = 0;
        _FechaIngreso = DateTime.Now;
        _DescripcionMaterial = string.Empty;
        _FechaEmision = DateTime.Now;
        _MetodoMuestreo = string.Empty;
        _FechaMuestreo = DateTime.Now;
        _FechaInicio = DateTime.Now;
        _FechaFin = DateTime.Now;
        _CodigoIngreso = string.Empty;
        _Metodo = string.Empty;
        _RealizadoEn = string.Empty;
        _CreatedBy = 0;
        _CreatedAt = DateTime.Now;
        _UpdateAt = DateTime.Now;
        _UpdatedBy = 0;
        _EnsayadoPor = 0;
        _AutorizadoPor = 0;
        _RevisadoPor = 0;
        _VerificadoPor = 0;
        _Muestra = null;
    }

    public int Idensayohumedad
    {
        get => _Idensayohumedad;
        set => SetField(ref _Idensayohumedad, value);
    }

    public string InformeNumero
    {
        get => _InformeNumero;
        set => SetField(ref _InformeNumero, value);
    }

    public int? Idmuestra
    {
        get => _Idmuestra;
        set => SetField(ref _Idmuestra, value);
    }

    public DateTime? FechaIngreso
    {
        get => _FechaIngreso;
        set => SetField(ref _FechaIngreso, value);
    }

    public string DescripcionMaterial
    {
        get => _DescripcionMaterial;
        set => SetField(ref _DescripcionMaterial, value);
    }

    public DateTime? FechaEmision
    {
        get => _FechaEmision;
        set => SetField(ref _FechaEmision, value);
    }

    public string MetodoMuestreo
    {
        get => _MetodoMuestreo;
        set => SetField(ref _MetodoMuestreo, value);
    }

    public DateTime? FechaMuestreo
    {
        get => _FechaMuestreo;
        set => SetField(ref _FechaMuestreo, value);
    }

    public DateTime? FechaInicio
    {
        get => _FechaInicio;
        set => SetField(ref _FechaInicio, value);
    }

    public DateTime? FechaFin
    {
        get => _FechaFin;
        set => SetField(ref _FechaFin, value);
    }

    public string CodigoIngreso
    {
        get => _CodigoIngreso;
        set => SetField(ref _CodigoIngreso, value);
    }

    public string Metodo
    {
        get => _Metodo;
        set => SetField(ref _Metodo, value);
    }

    public string RealizadoEn
    {
        get => _RealizadoEn;
        set => SetField(ref _RealizadoEn, value);
    }

    public int? CreatedBy
    {
        get => _CreatedBy;
        set => SetField(ref _CreatedBy, value);
    }

    public DateTime CreatedAt
    {
        get => _CreatedAt;
        set => SetField(ref _CreatedAt, value);
    }

    public int? UpdatedBy
    {
        get => _UpdatedBy;
        set => SetField(ref _UpdatedBy, value);
    }

    public DateTime? UpdateAt
    {
        get => _UpdateAt;
        set => SetField(ref _UpdateAt, value);
    }

    public int? EnsayadoPor
    {
        get => _EnsayadoPor;
        set => SetField(ref _EnsayadoPor, value);
    }

    public int? RevisadoPor
    {
        get => _RevisadoPor;
        set => SetField(ref _RevisadoPor, value);
    }

    public int? VerificadoPor
    {
        get => _VerificadoPor;
        set => SetField(ref _VerificadoPor, value);
    }

    public int? AutorizadoPor
    {
        get => _AutorizadoPor;
        set => SetField(ref _AutorizadoPor, value);
    }

    public Muestra? Muestra
    {
        get => _Muestra;
        set => SetField(ref _Muestra, value);
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

    public void GetPropertyError(string propertyName, ErrorInfo info)
    {
        if (propertyName == "InformeNumero" && InformeNumero == "" ||
            propertyName == "CodigoIngreso" && CodigoIngreso == "" ||
            propertyName == "Metodo" && Metodo == "" ||
            propertyName == "MetodoMuestreo" && MetodoMuestreo == "")
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    // IDXDataErrorInfo.GetError method
    public void GetError(ErrorInfo info)
    {
    }

    public EnsayoHumedad GetEnsayoHumedad()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EnsayoHumedadProfile>(); }, new NLogLoggerFactory());

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<EnsayoHumedad>(this);
    }

    public EnsayoHumedadDto GetEnsayoHumedadDto(EnsayoHumedad ensayoHumedad)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EnsayoHumedadProfile>(); }, new NLogLoggerFactory());

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<EnsayoHumedadDto>(ensayoHumedad);
    }
}