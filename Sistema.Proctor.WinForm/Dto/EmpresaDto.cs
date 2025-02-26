using System.ComponentModel;
using System.Runtime.CompilerServices;
using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Dto;

public class EmpresaDto : INotifyPropertyChanged, IDXDataErrorInfo
{
    private int _Idempresa;

    private string _NombreComercial;

    private string _NombreAbreviado;

    private byte[] _Logo;

    private string _Email;

    private string _Telefono;

    private string _Celular;

    private string _Direccion;

    private string _Representante;

    private int? _CreatedBy;

    private DateTime _CreatedAt;

    private int? _UpdatedBy;

    private DateTime _UpdatedAt;

    private bool? _Activa;

    private bool? _Selected;

    public EmpresaDto()
    {
        _Idempresa = 0;
        _NombreComercial = string.Empty;
        _NombreAbreviado = string.Empty;
        _Logo = [];
        _Email = string.Empty;
        _Telefono = string.Empty;
        _Celular = string.Empty;
        _Direccion = string.Empty;
        _Representante = string.Empty;
        _CreatedBy = 0;
        _CreatedAt = DateTime.Now;
        _UpdatedBy = 0;
        _UpdatedAt = DateTime.Now;
        _Activa = true;
        _Selected = false;
    }

    public int Idempresa
    {
        get => _Idempresa;
        set => SetField(ref _Idempresa, value);
    }

    public string NombreComercial
    {
        get => _NombreComercial;
        set => SetField(ref _NombreComercial, value);
    }

    public string NombreAbreviado
    {
        get => _NombreAbreviado;
        set => SetField(ref _NombreAbreviado, value);
    }

    public byte[] Logo
    {
        get => _Logo;
        set => SetField(ref _Logo, value);
    }

    public string Email
    {
        get => _Email;
        set => SetField(ref _Email, value);
    }

    public string Telefono
    {
        get => _Telefono;
        set => SetField(ref _Telefono, value);
    }

    public string Celular
    {
        get => _Celular;
        set => SetField(ref _Celular, value);
    }

    public string Direccion
    {
        get => _Direccion;
        set => SetField(ref _Direccion, value);
    }

    public string Representante
    {
        get => _Representante;
        set => SetField(ref _Representante, value);
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

    public DateTime UpdatedAt
    {
        get => _UpdatedAt;
        set => SetField(ref _UpdatedAt, value);
    }

    public bool? Activa
    {
        get => _Activa;
        set => SetField(ref _Activa, value);
    }

    public bool? Selected
    {
        get => _Selected;
        set => SetField(ref _Selected, value);
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

    public Empresa GetEmpresa()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EmpresaProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<Empresa>(this);
    }

    public EmpresaDto GetEmpresaDto(Empresa empresa)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EmpresaProfile>(); });
        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<EmpresaDto>(empresa);
    }

    public void GetPropertyError(string propertyName, ErrorInfo info)
    {
        if (propertyName == "Direccion" && Direccion == "" ||
            propertyName == "Email" && Email == "" ||
            propertyName == "NombreAbreviado" && NombreAbreviado == "" ||
            propertyName == "NombreComercial" && NombreComercial == "")
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    // IDXDataErrorInfo.GetError method
    public void GetError(ErrorInfo info)
    {
    }

    public override string ToString()
    {
        return NombreAbreviado;
    }
}