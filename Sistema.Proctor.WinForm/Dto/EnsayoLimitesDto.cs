using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using NLog.Extensions.Logging;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sistema.Proctor.WinForm.Dto;

public class EnsayoLimitesDto : INotifyPropertyChanged, IDXDataErrorInfo
{
    private int _Idensayolimites;

    private decimal? _ProfundidadInicial;

    private decimal? _ProfundidadFinal;

    private string _InformeNo;

    private string _Muestra;

    private DateTime? _FechaIngreso;

    private string _DescripcionMaterial;

    private int? _MuestraNo;

    private DateTime? _FechaEmision;

    private string _MetodoMuestreo;

    private DateTime? _FechaMuestreo;

    private string _CodigoIngreso;

    private DateTime? _FechaEnsayoInicio;

    private DateTime? _FechaEnsayoFin;

    private decimal? _PasaTamiz4;

    private decimal? _PasaTamiz10;

    private decimal? _PasaTamiz40;

    private decimal? _PasaTamiz200;

    private int? _CreatedBy;

    private DateTime _CreatedAt;

    private int? _UpdatedBy;

    private DateTime? _UpdateAt;

    private int? _EnsayadoPor;

    private int? _RevisadoPor;

    private int? _VerificadoPor;

    private int? _AutorizadoPor;

    private decimal? _LimiteLiquido;

    private decimal? _LimitePlastico;

    private decimal? _IndicePlasticidad;

    private IList<LimiteLiquido> _LimiteLiquidos;

    private IList<LimitePlastico> _LimitePlasticos;

    private IMapper _mapper;

    public EnsayoLimitesDto()
    {
        var mapperConfiguraion = new MapperConfiguration(expression => expression.AddProfile<EnsayosLimitesProfile>(), new NLogLoggerFactory());
        _mapper = mapperConfiguraion.CreateMapper();
        _Idensayolimites = 0;
        _ProfundidadInicial = 0;
        _ProfundidadFinal = 0;
        _InformeNo = string.Empty;
        _Muestra = string.Empty;
        _FechaIngreso = DateTime.Now;
        _DescripcionMaterial = string.Empty;
        _MuestraNo = 0;
        _FechaEmision = DateTime.Now;
        _MetodoMuestreo = string.Empty;
        _FechaMuestreo = DateTime.Now;
        _CodigoIngreso = string.Empty;
        _FechaEnsayoInicio = DateTime.Now;
        _FechaEnsayoFin = DateTime.Now;
        _PasaTamiz4 = 0;
        _PasaTamiz10 = 0;
        _PasaTamiz40 = 0;
        _PasaTamiz200 = 0;
        _CreatedBy = 0;
        _CreatedAt = DateTime.Now;
        _UpdatedBy = 0;
        _UpdateAt = DateTime.Now;
        _EnsayadoPor = 0;
        _RevisadoPor = 0;
        _VerificadoPor = 0;
        _AutorizadoPor = 0;
        _LimiteLiquido = 0;
        _LimitePlastico = 0;
        _IndicePlasticidad = 0;
        _LimiteLiquidos = new List<LimiteLiquido>();
        _LimitePlasticos = new List<LimitePlastico>();
    }

    public int Idensayolimites
    {
        get => _Idensayolimites;
        set => SetField(ref _Idensayolimites, value);
    }

    public decimal? ProfundidadInicial
    {
        get => _ProfundidadInicial;
        set => SetField(ref _ProfundidadInicial, value);
    }

    public decimal? ProfundidadFinal
    {
        get => _ProfundidadFinal;
        set => SetField(ref _ProfundidadFinal, value);
    }

    public string InformeNo
    {
        get => _InformeNo;
        set => SetField(ref _InformeNo, value);
    }

    public string Muestra
    {
        get => _Muestra;
        set => SetField(ref _Muestra, value);
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

    public int? MuestraNo
    {
        get => _MuestraNo;
        set => SetField(ref _MuestraNo, value);
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

    public string CodigoIngreso
    {
        get => _CodigoIngreso;
        set => SetField(ref _CodigoIngreso, value);
    }

    public DateTime? FechaEnsayoInicio
    {
        get => _FechaEnsayoInicio;
        set => SetField(ref _FechaEnsayoInicio, value);
    }

    public DateTime? FechaEnsayoFin
    {
        get => _FechaEnsayoFin;
        set => SetField(ref _FechaEnsayoFin, value);
    }

    public decimal? PasaTamiz4
    {
        get => _PasaTamiz4;
        set => SetField(ref _PasaTamiz4, value);
    }

    public decimal? PasaTamiz10
    {
        get => _PasaTamiz10;
        set => SetField(ref _PasaTamiz10, value);
    }

    public decimal? PasaTamiz40
    {
        get => _PasaTamiz40;
        set => SetField(ref _PasaTamiz40, value);
    }

    public decimal? PasaTamiz200
    {
        get => _PasaTamiz200;
        set => SetField(ref _PasaTamiz200, value);
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

    public decimal? LimiteLiquido
    {
        get => _LimiteLiquido;
        set => SetField(ref _LimiteLiquido, value);
    }

    public decimal? LimitePlastico
    {
        get => _LimitePlastico;
        set => SetField(ref _LimitePlastico, value);
    }

    public decimal? IndicePlasticidad
    {
        get => _IndicePlasticidad;
        set => SetField(ref _IndicePlasticidad, value);
    }

    public IList<LimiteLiquido> LimiteLiquidos
    {
        get => _LimiteLiquidos;
        set => SetField(ref _LimiteLiquidos, value);
    }

    public IList<LimitePlastico> LimitePlasticos
    {
        get => _LimitePlasticos;
        set => SetField(ref _LimitePlasticos, value);
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
        if (propertyName == "CodigoIngreso" && CodigoIngreso == "" ||
            propertyName == "DescripcionMaterial" && DescripcionMaterial == "" )
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    public void GetError(ErrorInfo info)
    {
       
    }

    public EnsayoLimite GetEnsayoLimite() => _mapper.Map<EnsayoLimite>(this);

    public EnsayoLimitesDto GetEnsayoLimitesDto(EnsayoLimite ensayoLimite) => _mapper.Map<EnsayoLimitesDto>(ensayoLimite);
}