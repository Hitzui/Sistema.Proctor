using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.WinForm.Dto;

public class LimitePlasticoDto : INotifyPropertyChanged
{
    private int _Idlimiteplastico;

    private int? _Idensayolimites;

    private string _CodigoTara;

    private decimal? _PesoTara;

    private decimal? _PesoTaraMuestraHumeda;

    private decimal? _PesoTaraMuestraSeca;

    private decimal? _PesoMuestraSeca;

    private decimal? _PesoAgua;

    private decimal? _Humedad;

    private EnsayoLimite _EnsayoLimite;

    public LimitePlasticoDto()
    {
        _Idensayolimites = 0;
        _Idlimiteplastico = 0;
        _CodigoTara = string.Empty;
        _PesoTara = 0;
        _PesoTaraMuestraHumeda = 0;
        _PesoTaraMuestraSeca = 0;
        _PesoMuestraSeca = 0;
        _PesoAgua = 0;
        _Humedad = 0;
    }

    public int Idlimiteplastico
    {
        get => _Idlimiteplastico;
        set => SetField(ref _Idlimiteplastico, value);
    }

    public int? Idensayolimites
    {
        get => _Idensayolimites;
        set => SetField(ref _Idensayolimites, value);
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
}