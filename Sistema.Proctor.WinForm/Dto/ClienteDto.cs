using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using Sistema.Proctor.Data.Entities;
using System.ComponentModel;
using Sistema.Proctor.Data;

namespace Sistema.Proctor.WinForm.Dto;

public class ClienteDto : INotifyPropertyChanging, INotifyPropertyChanged, IDXDataErrorInfo
{
    private static PropertyChangingEventArgs emptyChangingEventArgs = new(string.Empty);

    private int _Idcliente;

    private string _Celular;

    private string _Ciudad;

    private string _Contacto;

    private string _Departamento;

    private string _Direccion;

    private string _Email;

    private DateTime? _FIngreso;

    private string _NombreAbreviado;

    private string _NombreComercial;

    private string _Ruc;

    private string _Telefono;


    public ClienteDto()
    {
        _Celular = string.Empty;
        _Ciudad = string.Empty;
        _Contacto = string.Empty;
        _Departamento = string.Empty;
        _Direccion = string.Empty;
        _Email = string.Empty;
        _FIngreso = DateTime.Now;
        _NombreAbreviado = string.Empty;
        _NombreComercial = string.Empty;
        _Ruc = string.Empty;
        _Telefono = string.Empty;
    }

    public int Idcliente
    {
        get { return this._Idcliente; }
        set
        {
            if (this._Idcliente != value)
            {
                this.SendPropertyChanging("Idcliente");
                this._Idcliente = value;
                this.SendPropertyChanged("Idcliente");
            }
        }
    }

    public string Celular
    {
        get { return this._Celular; }
        set
        {
            if (this._Celular != value)
            {
                this.SendPropertyChanging("Celular");
                this._Celular = value;
                this.SendPropertyChanged("Celular");
            }
        }
    }

    public string Ciudad
    {
        get { return this._Ciudad; }
        set
        {
            if (this._Ciudad != value)
            {
                this.SendPropertyChanging("Ciudad");
                this._Ciudad = value;
                this.SendPropertyChanged("Ciudad");
            }
        }
    }

    public string Contacto
    {
        get { return this._Contacto; }
        set
        {
            if (this._Contacto != value)
            {
                this.SendPropertyChanging("Contacto");
                this._Contacto = value;
                this.SendPropertyChanged("Contacto");
            }
        }
    }

    public string Departamento
    {
        get { return this._Departamento; }
        set
        {
            if (this._Departamento != value)
            {
                this.SendPropertyChanging("Departamento");
                this._Departamento = value;
                this.SendPropertyChanged("Departamento");
            }
        }
    }

    public string Direccion
    {
        get { return this._Direccion; }
        set
        {
            if (this._Direccion != value)
            {
                this.SendPropertyChanging("Direccion");
                this._Direccion = value;
                this.SendPropertyChanged("Direccion");
            }
        }
    }

    public string Email
    {
        get { return this._Email; }
        set
        {
            if (this._Email != value)
            {
                this.SendPropertyChanging("Email");
                this._Email = value;
                this.SendPropertyChanged("Email");
            }
        }
    }

    public DateTime? FIngreso
    {
        get { return this._FIngreso; }
        set
        {
            if (this._FIngreso != value)
            {
                this.SendPropertyChanging("FIngreso");
                this._FIngreso = value;
                this.SendPropertyChanged("FIngreso");
            }
        }
    }

    public string NombreAbreviado
    {
        get { return this._NombreAbreviado; }
        set
        {
            if (this._NombreAbreviado != value)
            {
                this.SendPropertyChanging("NombreAbreviado");
                this._NombreAbreviado = value;
                this.SendPropertyChanged("NombreAbreviado");
            }
        }
    }

    public string NombreComercial
    {
        get { return this._NombreComercial; }
        set
        {
            if (this._NombreComercial != value)
            {
                this.SendPropertyChanging("NombreComercial");
                this._NombreComercial = value;
                this.SendPropertyChanged("NombreComercial");
            }
        }
    }

    public string Ruc
    {
        get { return this._Ruc; }
        set
        {
            if (this._Ruc != value)
            {
                this.SendPropertyChanging("Ruc");
                this._Ruc = value;
                this.SendPropertyChanged("Ruc");
            }
        }
    }

    public string Telefono
    {
        get { return this._Telefono; }
        set
        {
            if (this._Telefono != value)
            {
                this.SendPropertyChanging("Telefono");
                this._Telefono = value;
                this.SendPropertyChanged("Telefono");
            }
        }
    }


    #region Extensibility Method Definitions

    public override bool Equals(object obj)
    {
        Cliente toCompare = obj as Cliente;
        if (toCompare == null)
        {
            return false;
        }

        if (!Object.Equals(this.Idcliente, toCompare.Idcliente))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        int hashCode = 13;
        hashCode = (hashCode * 7) + Idcliente.GetHashCode();
        return hashCode;
    }

    #endregion

    public virtual event PropertyChangingEventHandler? PropertyChanging;

    public virtual event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
        var handler = this.PropertyChanging;
        if (handler != null)
            handler(this, emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanging(System.String propertyName)
    {
        var handler = this.PropertyChanging;
        if (handler != null)
            handler(this, new PropertyChangingEventArgs(propertyName));
    }

    protected virtual void SendPropertyChanged(System.String propertyName)
    {
        var handler = this.PropertyChanged;
        if (handler != null)
            handler(this, new PropertyChangedEventArgs(propertyName));
    }

    // Implements the IDXDataErrorInfo.GetPropertyError method.
    public void GetPropertyError(string propertyName, ErrorInfo info)
    {
        if (propertyName == "Direccion" && Direccion == "" ||
            propertyName == "Email" && Email == "" ||
            propertyName == "RUC" && Email == "" ||
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

    public Cliente GetCliente()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<ClienteProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<Cliente>(this);
    }

    public ClienteDto GetClienteDto(Cliente cliente)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<ClienteProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<ClienteDto>(cliente);
    }
}