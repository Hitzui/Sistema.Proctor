using Sistema.Proctor.Data.Entities;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;
using AutoMapper;
using Sistema.Proctor.Data;

namespace Sistema.Proctor.WinForm.Dto;

public class ProyectoDto : INotifyPropertyChanging, INotifyPropertyChanged, IDXDataErrorInfo
{
    private static PropertyChangingEventArgs emptyChangingEventArgs = new(System.String.Empty);

    private int _Idproyecto;

    private bool _Activo;

    private string _CodigoProyecto;

    private string _Descripcion;

    private string _DescripcionMezcla;

    private DateTime? _FechaFin;

    private DateTime? _FechaInicio;

    private DateTime? _FechaMuestreo;

    private string _ProecedenciaConcreto;

    private string _UbicacionMuestra;

    private string _UbicacionProyecto;

    private int? _Idcliente;

    private Cliente _Cliente;

    private IList<Muestra> _Muestras;

    private IList<Entry> _Entries;

    public ProyectoDto()
    {
        _Activo = true;
        _CodigoProyecto = string.Empty;
        _Descripcion = string.Empty;
        _DescripcionMezcla = string.Empty;
        _FechaFin = DateTime.Now;
        _FechaInicio = DateTime.Now;
        _FechaMuestreo = DateTime.Now;
        _ProecedenciaConcreto = string.Empty;
        _UbicacionMuestra = string.Empty;
        _UbicacionProyecto = string.Empty;
    }

    public int Idproyecto
    {
        get { return this._Idproyecto; }
        set
        {
            if (this._Idproyecto != value)
            {
                this.SendPropertyChanging("Idproyecto");
                this._Idproyecto = value;
                this.SendPropertyChanged("Idproyecto");
            }
        }
    }

    public bool Activo
    {
        get { return this._Activo; }
        set
        {
            if (this._Activo != value)
            {
                this.SendPropertyChanging("Activo");
                this._Activo = value;
                this.SendPropertyChanged("Activo");
            }
        }
    }

    public string CodigoProyecto
    {
        get { return this._CodigoProyecto; }
        set
        {
            if (this._CodigoProyecto != value)
            {
                this.SendPropertyChanging("CodigoProyecto");
                this._CodigoProyecto = value;
                this.SendPropertyChanged("CodigoProyecto");
            }
        }
    }

    public string Descripcion
    {
        get { return this._Descripcion; }
        set
        {
            if (this._Descripcion != value)
            {
                this.SendPropertyChanging("Descripcion");
                this._Descripcion = value;
                this.SendPropertyChanged("Descripcion");
            }
        }
    }

    public string DescripcionMezcla
    {
        get { return this._DescripcionMezcla; }
        set
        {
            if (this._DescripcionMezcla != value)
            {
                this.SendPropertyChanging("DescripcionMezcla");
                this._DescripcionMezcla = value;
                this.SendPropertyChanged("DescripcionMezcla");
            }
        }
    }

    public DateTime? FechaFin
    {
        get { return this._FechaFin; }
        set
        {
            if (this._FechaFin != value)
            {
                this.SendPropertyChanging("FechaFin");
                this._FechaFin = value;
                this.SendPropertyChanged("FechaFin");
            }
        }
    }

    public DateTime? FechaInicio
    {
        get { return this._FechaInicio; }
        set
        {
            if (this._FechaInicio != value)
            {
                this.SendPropertyChanging("FechaInicio");
                this._FechaInicio = value;
                this.SendPropertyChanged("FechaInicio");
            }
        }
    }

    public DateTime? FechaMuestreo
    {
        get { return this._FechaMuestreo; }
        set
        {
            if (this._FechaMuestreo != value)
            {
                this.SendPropertyChanging("FechaMuestreo");
                this._FechaMuestreo = value;
                this.SendPropertyChanged("FechaMuestreo");
            }
        }
    }

    public string ProecedenciaConcreto
    {
        get { return this._ProecedenciaConcreto; }
        set
        {
            if (this._ProecedenciaConcreto != value)
            {
                this.SendPropertyChanging("ProecedenciaConcreto");
                this._ProecedenciaConcreto = value;
                this.SendPropertyChanged("ProecedenciaConcreto");
            }
        }
    }

    public string UbicacionMuestra
    {
        get { return this._UbicacionMuestra; }
        set
        {
            if (this._UbicacionMuestra != value)
            {
                this.SendPropertyChanging("UbicacionMuestra");
                this._UbicacionMuestra = value;
                this.SendPropertyChanged("UbicacionMuestra");
            }
        }
    }

    public string UbicacionProyecto
    {
        get { return this._UbicacionProyecto; }
        set
        {
            if (this._UbicacionProyecto != value)
            {
                this.SendPropertyChanging("UbicacionProyecto");
                this._UbicacionProyecto = value;
                this.SendPropertyChanged("UbicacionProyecto");
            }
        }
    }

    public int? Idcliente
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

    public Cliente? Cliente
    {
        get { return this._Cliente; }
        set
        {
            if (this._Cliente != value)
            {
                this.SendPropertyChanging("Cliente");
                this._Cliente = value;
                this.SendPropertyChanged("Cliente");
            }
        }
    }

    public IList<Muestra> Muestras
    {
        get { return this._Muestras; }
        set { this._Muestras = value; }
    }

    public IList<Entry> Entries
    {
        get { return this._Entries; }
        set { this._Entries = value; }
    }

    #region Extensibility Method Definitions

    public override bool Equals(object obj)
    {
        Proyecto toCompare = obj as Proyecto;
        if (toCompare == null)
        {
            return false;
        }

        if (!Object.Equals(this.Idproyecto, toCompare.Idproyecto))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        int hashCode = 13;
        hashCode = (hashCode * 7) + Idproyecto.GetHashCode();
        return hashCode;
    }

    #endregion

    public virtual event PropertyChangingEventHandler PropertyChanging;

    public virtual event PropertyChangedEventHandler PropertyChanged;

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
        if (propertyName == "CodigoProyecto" && CodigoProyecto == "" ||
            propertyName == "UbicacionProyecto" && UbicacionProyecto == "" ||
            propertyName == "Descripcion" && Descripcion == "")
        {
            info.ErrorText = $"The '{propertyName}' field cannot be empty";
        }
    }

    // IDXDataErrorInfo.GetError method
    public void GetError(ErrorInfo info)
    {
    }

    public Proyecto GetProyecto()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<ProyectoProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<Proyecto>(this);
    }

    public ProyectoDto GetProyectoDto(Proyecto proyecto)
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<ProyectoProfile>(); });

        // Crear el mapper
        var mapper = config.CreateMapper();
        return mapper.Map<ProyectoDto>(proyecto);
    }
}