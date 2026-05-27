using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using NLog.Extensions.Logging;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sistema.Proctor.WinForm.Dto;

public class LimiteLiquidoDto : INotifyPropertyChanged, IDXDataErrorInfo
{
    private int _Idlimiteliquido;

    private int? _Idensayolimites;

    private int _NumGolpes;

    private string _CodigoTara;

    private decimal? _PesoTara;

    private decimal? _PesoTaraMuestraHumeda;

    private decimal? _PesoTaraMuestraSeca;

    private decimal? _PesoMuestraSeca;

    private decimal? _PesoAgua;

    private decimal? _Humedad;

    private string _Metodo;

    private EnsayoLimite _EnsayoLimite;

    private IMapper _mapper;

    public LimiteLiquidoDto()
    {
        _Idlimiteliquido = 0;
        _Idensayolimites = 0;
        _NumGolpes = 0;
        _CodigoTara = string.Empty;
        _PesoTara = 0;
        _PesoTaraMuestraHumeda = 0;
        _PesoTaraMuestraSeca = 0;
        _PesoMuestraSeca = 0;
        _PesoAgua = 0;
        _Humedad = 0;
        _Metodo = string.Empty;
        var mapperConfiguraion = new MapperConfiguration(expression => expression.AddProfile<LimiteLiquidoProfile>(), new NLogLoggerFactory());
        _mapper = mapperConfiguraion.CreateMapper();
    }

    public int Idlimiteliquido
    {
        get => _Idlimiteliquido;
        set => SetField(ref _Idlimiteliquido, value);
    }

    public int? Idensayolimites
    {
        get => _Idensayolimites;
        set => SetField(ref _Idensayolimites, value);
    }

    public int NumGolpes
    {
        get => _NumGolpes;
        set => SetField(ref _NumGolpes, value);
    }

    public string CodigoTara
    {
        get => _CodigoTara;
        set => SetField(ref _CodigoTara, value);
    }

    public decimal? PesoTara
    {
        get => _PesoTara;
        set => SetField(ref _PesoTara, value);
    }

    public decimal? PesoTaraMuestraHumeda
    {
        get => _PesoTaraMuestraHumeda;
        set => SetField(ref _PesoTaraMuestraHumeda, value);
    }

    public decimal? PesoTaraMuestraSeca
    {
        get => _PesoTaraMuestraSeca;
        set => SetField(ref _PesoTaraMuestraSeca, value);
    }

    public decimal? PesoMuestraSeca
    {
        get => _PesoMuestraSeca;
        set => SetField(ref _PesoMuestraSeca, value);
    }

    public decimal? PesoAgua
    {
        get => _PesoAgua;
        set => SetField(ref _PesoAgua, value);
    }

    public decimal? Humedad
    {
        get => _Humedad;
        set => SetField(ref _Humedad, value);
    }

    public string Metodo
    {
        get => _Metodo;
        set => SetField(ref _Metodo, value);
    }

    public EnsayoLimite EnsayoLimite
    {
        get => _EnsayoLimite;
        set => SetField(ref _EnsayoLimite, value);
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
        if (propertyName == "NumGolpes" && NumGolpes == 0 ||
            propertyName == "PesoTaraMuestraHumeda" && PesoTaraMuestraHumeda == 0 ||
            propertyName == "PesoTaraMuestraSeca" && PesoTaraMuestraSeca == 0)
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    public void GetError(ErrorInfo info)
    {

    }

    public LimiteLiquido GetLimiteLiquido() => _mapper.Map<LimiteLiquido>(this);


    public LimiteLiquidoDto GetLimiteLiquidoDto(LimiteLiquido limiteLiquido) =>
        _mapper.Map<LimiteLiquidoDto>(limiteLiquido);
}