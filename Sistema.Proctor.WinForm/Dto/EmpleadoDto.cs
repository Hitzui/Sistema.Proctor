using AutoMapper;
using DevExpress.XtraEditors.DXErrorProvider;
using Sistema.Proctor.Data.Entities;
using System.ComponentModel;
using Sistema.Proctor.Data;
using MySqlX.XDevAPI;

namespace Sistema.Proctor.WinForm.Dto;

public class EmpleadoDto : INotifyPropertyChanging, INotifyPropertyChanged, IDXDataErrorInfo
{
    private static PropertyChangingEventArgs
        emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

    private int _Idempleado;

    private string _Apellido;

    private string _Cedula;

    private string _Direccion;

    private DateTime? _FIngreso;

    private DateTime? _FNacimiento;

    private string _Nombre;

    public EmpleadoDto()
    {
        _Apellido = string.Empty;
        _Cedula = string.Empty;
        _Direccion = string.Empty;
        _FIngreso = DateTime.Now;
        _FNacimiento = DateTime.Now;
        _Nombre = string.Empty;
    }

    public EmpleadoDto(string apellido, string cedula, string direccion, DateTime? fIngreso, DateTime? fNacimiento,
        string nombre)
    {
        _Apellido = apellido;
        _Cedula = cedula;
        _Direccion = direccion;
        _FIngreso = fIngreso;
        _FNacimiento = fNacimiento;
        _Nombre = nombre;
    }

    public int Idempleado
    {
        get { return this._Idempleado; }
        set
        {
            if (this._Idempleado != value)
            {
                this.SendPropertyChanging("Idempleado");
                this._Idempleado = value;
                this.SendPropertyChanged("Idempleado");
            }
        }
    }

    public string Apellido
    {
        get { return this._Apellido; }
        set
        {
            if (this._Apellido != value)
            {
                this.SendPropertyChanging("Apellido");
                this._Apellido = value;
                this.SendPropertyChanged("Apellido");
            }
        }
    }

    public string Cedula
    {
        get { return this._Cedula; }
        set
        {
            if (this._Cedula != value)
            {
                this.SendPropertyChanging("Cedula");
                this._Cedula = value;
                this.SendPropertyChanged("Cedula");
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

    public DateTime? FNacimiento
    {
        get { return this._FNacimiento; }
        set
        {
            if (this._FNacimiento != value)
            {
                this.SendPropertyChanging("FNacimiento");
                this._FNacimiento = value;
                this.SendPropertyChanged("FNacimiento");
            }
        }
    }

    public string Nombre
    {
        get { return this._Nombre; }
        set
        {
            if (this._Nombre != value)
            {
                this.SendPropertyChanging("Nombre");
                this._Nombre = value;
                this.SendPropertyChanged("Nombre");
            }
        }
    }


    #region Extensibility Method Definitions

    public override bool Equals(object obj)
    {
        Empleado toCompare = obj as Empleado;
        if (toCompare == null)
        {
            return false;
        }

        if (!Object.Equals(this.Idempleado, toCompare.Idempleado))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        int hashCode = 13;
        hashCode = (hashCode * 7) + Idempleado.GetHashCode();
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
            propertyName == "Nombre" && Nombre == "" ||
            propertyName == "Apellido" && Apellido == "" ||
            propertyName == "Cedula" && Cedula == "")
        {
            info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
        }
    }

    // IDXDataErrorInfo.GetError method
    public void GetError(ErrorInfo info)
    {
    }

    public Empleado GetEmpleado()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EmpleadoProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<Empleado>(this);
    }

    public EmpleadoDto GetEmpleadoDto(Empleado empleado)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<EmpleadoProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<EmpleadoDto>(empleado);
    }
}