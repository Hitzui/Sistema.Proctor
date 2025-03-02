﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2/3/2025 5:02:30 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace Sistema.Proctor.Data.Entities
{
    public partial class Entry : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private long _IdEntry;

        private decimal? _Altura;

        private decimal? _Anchura;

        private decimal? _Area;

        private decimal? _Carga;

        private string _Codigo;

        private decimal? _Densidad;

        private decimal? _Diametro;

        private int _Edad;

        private int? _EdadReal;

        private DateTime? _End;

        private TimeSpan? _EndTime;

        private string _Estructura;

        private DateTime? _FechaColado;

        private DateTime? _FechaRoturaReal;

        private bool _Finalizado;

        private bool? _FullDay;

        private string _Id;

        private string _Location;

        private decimal? _LongitudSoporte;

        private decimal? _Peso;

        private decimal? _PromedioSoporte;

        private TimeSpan? _StarTime;

        private DateTime? _Start;

        private string _Title;

        private decimal? _Volumen;

        private string _ZoneId;

        private int? _Idempleado;

        private int? _Idproyecto;

        private int? _Idtamano;

        private long? _Idtipo;

        private long? _Idunidad;

        private IList<Resultado> _Resultados;

        private TamanoEspeciman _TamanoEspeciman;

        private Proyecto _Proyecto;

        private TipoEspeciman _TipoEspeciman;

        private UnidadMedida _UnidadMedida;

        public Entry()
        {
            this._Resultados = new List<Resultado>();
            OnCreated();
        }

        public long IdEntry
        {
            get
            {
                return this._IdEntry;
            }
            set
            {
                if (this._IdEntry != value)
                {
                    this.SendPropertyChanging("IdEntry");
                    this._IdEntry = value;
                    this.SendPropertyChanged("IdEntry");
                }
            }
        }

        public decimal? Altura
        {
            get
            {
                return this._Altura;
            }
            set
            {
                if (this._Altura != value)
                {
                    this.SendPropertyChanging("Altura");
                    this._Altura = value;
                    this.SendPropertyChanged("Altura");
                }
            }
        }

        public decimal? Anchura
        {
            get
            {
                return this._Anchura;
            }
            set
            {
                if (this._Anchura != value)
                {
                    this.SendPropertyChanging("Anchura");
                    this._Anchura = value;
                    this.SendPropertyChanged("Anchura");
                }
            }
        }

        public decimal? Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                if (this._Area != value)
                {
                    this.SendPropertyChanging("Area");
                    this._Area = value;
                    this.SendPropertyChanged("Area");
                }
            }
        }

        public decimal? Carga
        {
            get
            {
                return this._Carga;
            }
            set
            {
                if (this._Carga != value)
                {
                    this.SendPropertyChanging("Carga");
                    this._Carga = value;
                    this.SendPropertyChanged("Carga");
                }
            }
        }

        public string Codigo
        {
            get
            {
                return this._Codigo;
            }
            set
            {
                if (this._Codigo != value)
                {
                    this.SendPropertyChanging("Codigo");
                    this._Codigo = value;
                    this.SendPropertyChanged("Codigo");
                }
            }
        }

        public decimal? Densidad
        {
            get
            {
                return this._Densidad;
            }
            set
            {
                if (this._Densidad != value)
                {
                    this.SendPropertyChanging("Densidad");
                    this._Densidad = value;
                    this.SendPropertyChanged("Densidad");
                }
            }
        }

        public decimal? Diametro
        {
            get
            {
                return this._Diametro;
            }
            set
            {
                if (this._Diametro != value)
                {
                    this.SendPropertyChanging("Diametro");
                    this._Diametro = value;
                    this.SendPropertyChanged("Diametro");
                }
            }
        }

        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                if (this._Edad != value)
                {
                    this.SendPropertyChanging("Edad");
                    this._Edad = value;
                    this.SendPropertyChanged("Edad");
                }
            }
        }

        public int? EdadReal
        {
            get
            {
                return this._EdadReal;
            }
            set
            {
                if (this._EdadReal != value)
                {
                    this.SendPropertyChanging("EdadReal");
                    this._EdadReal = value;
                    this.SendPropertyChanged("EdadReal");
                }
            }
        }

        public DateTime? End
        {
            get
            {
                return this._End;
            }
            set
            {
                if (this._End != value)
                {
                    this.SendPropertyChanging("End");
                    this._End = value;
                    this.SendPropertyChanged("End");
                }
            }
        }

        public TimeSpan? EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                if (this._EndTime != value)
                {
                    this.SendPropertyChanging("EndTime");
                    this._EndTime = value;
                    this.SendPropertyChanged("EndTime");
                }
            }
        }

        public string Estructura
        {
            get
            {
                return this._Estructura;
            }
            set
            {
                if (this._Estructura != value)
                {
                    this.SendPropertyChanging("Estructura");
                    this._Estructura = value;
                    this.SendPropertyChanged("Estructura");
                }
            }
        }

        public DateTime? FechaColado
        {
            get
            {
                return this._FechaColado;
            }
            set
            {
                if (this._FechaColado != value)
                {
                    this.SendPropertyChanging("FechaColado");
                    this._FechaColado = value;
                    this.SendPropertyChanged("FechaColado");
                }
            }
        }

        public DateTime? FechaRoturaReal
        {
            get
            {
                return this._FechaRoturaReal;
            }
            set
            {
                if (this._FechaRoturaReal != value)
                {
                    this.SendPropertyChanging("FechaRoturaReal");
                    this._FechaRoturaReal = value;
                    this.SendPropertyChanged("FechaRoturaReal");
                }
            }
        }

        public bool Finalizado
        {
            get
            {
                return this._Finalizado;
            }
            set
            {
                if (this._Finalizado != value)
                {
                    this.SendPropertyChanging("Finalizado");
                    this._Finalizado = value;
                    this.SendPropertyChanged("Finalizado");
                }
            }
        }

        public bool? FullDay
        {
            get
            {
                return this._FullDay;
            }
            set
            {
                if (this._FullDay != value)
                {
                    this.SendPropertyChanging("FullDay");
                    this._FullDay = value;
                    this.SendPropertyChanged("FullDay");
                }
            }
        }

        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.SendPropertyChanging("Id");
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                }
            }
        }

        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                if (this._Location != value)
                {
                    this.SendPropertyChanging("Location");
                    this._Location = value;
                    this.SendPropertyChanged("Location");
                }
            }
        }

        public decimal? LongitudSoporte
        {
            get
            {
                return this._LongitudSoporte;
            }
            set
            {
                if (this._LongitudSoporte != value)
                {
                    this.SendPropertyChanging("LongitudSoporte");
                    this._LongitudSoporte = value;
                    this.SendPropertyChanged("LongitudSoporte");
                }
            }
        }

        public decimal? Peso
        {
            get
            {
                return this._Peso;
            }
            set
            {
                if (this._Peso != value)
                {
                    this.SendPropertyChanging("Peso");
                    this._Peso = value;
                    this.SendPropertyChanged("Peso");
                }
            }
        }

        public decimal? PromedioSoporte
        {
            get
            {
                return this._PromedioSoporte;
            }
            set
            {
                if (this._PromedioSoporte != value)
                {
                    this.SendPropertyChanging("PromedioSoporte");
                    this._PromedioSoporte = value;
                    this.SendPropertyChanged("PromedioSoporte");
                }
            }
        }

        public TimeSpan? StarTime
        {
            get
            {
                return this._StarTime;
            }
            set
            {
                if (this._StarTime != value)
                {
                    this.SendPropertyChanging("StarTime");
                    this._StarTime = value;
                    this.SendPropertyChanged("StarTime");
                }
            }
        }

        public DateTime? Start
        {
            get
            {
                return this._Start;
            }
            set
            {
                if (this._Start != value)
                {
                    this.SendPropertyChanging("Start");
                    this._Start = value;
                    this.SendPropertyChanged("Start");
                }
            }
        }

        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if (this._Title != value)
                {
                    this.SendPropertyChanging("Title");
                    this._Title = value;
                    this.SendPropertyChanged("Title");
                }
            }
        }

        public decimal? Volumen
        {
            get
            {
                return this._Volumen;
            }
            set
            {
                if (this._Volumen != value)
                {
                    this.SendPropertyChanging("Volumen");
                    this._Volumen = value;
                    this.SendPropertyChanged("Volumen");
                }
            }
        }

        public string ZoneId
        {
            get
            {
                return this._ZoneId;
            }
            set
            {
                if (this._ZoneId != value)
                {
                    this.SendPropertyChanging("ZoneId");
                    this._ZoneId = value;
                    this.SendPropertyChanged("ZoneId");
                }
            }
        }

        public int? Idempleado
        {
            get
            {
                return this._Idempleado;
            }
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

        public int? Idproyecto
        {
            get
            {
                return this._Idproyecto;
            }
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

        public int? Idtamano
        {
            get
            {
                return this._Idtamano;
            }
            set
            {
                if (this._Idtamano != value)
                {
                    this.SendPropertyChanging("Idtamano");
                    this._Idtamano = value;
                    this.SendPropertyChanged("Idtamano");
                }
            }
        }

        public long? Idtipo
        {
            get
            {
                return this._Idtipo;
            }
            set
            {
                if (this._Idtipo != value)
                {
                    this.SendPropertyChanging("Idtipo");
                    this._Idtipo = value;
                    this.SendPropertyChanged("Idtipo");
                }
            }
        }

        public long? Idunidad
        {
            get
            {
                return this._Idunidad;
            }
            set
            {
                if (this._Idunidad != value)
                {
                    this.SendPropertyChanging("Idunidad");
                    this._Idunidad = value;
                    this.SendPropertyChanged("Idunidad");
                }
            }
        }

        public virtual IList<Resultado> Resultados
        {
            get
            {
                return this._Resultados;
            }
            set
            {
                this._Resultados = value;
            }
        }

        public virtual TamanoEspeciman TamanoEspeciman
        {
            get
            {
                return this._TamanoEspeciman;
            }
            set
            {
                if (this._TamanoEspeciman != value)
                {
                    this.SendPropertyChanging("TamanoEspeciman");
                    this._TamanoEspeciman = value;
                    this.SendPropertyChanged("TamanoEspeciman");
                }
            }
        }

        public virtual Proyecto Proyecto
        {
            get
            {
                return this._Proyecto;
            }
            set
            {
                if (this._Proyecto != value)
                {
                    this.SendPropertyChanging("Proyecto");
                    this._Proyecto = value;
                    this.SendPropertyChanged("Proyecto");
                }
            }
        }

        public virtual TipoEspeciman TipoEspeciman
        {
            get
            {
                return this._TipoEspeciman;
            }
            set
            {
                if (this._TipoEspeciman != value)
                {
                    this.SendPropertyChanging("TipoEspeciman");
                    this._TipoEspeciman = value;
                    this.SendPropertyChanged("TipoEspeciman");
                }
            }
        }

        public virtual UnidadMedida UnidadMedida
        {
            get
            {
                return this._UnidadMedida;
            }
            set
            {
                if (this._UnidadMedida != value)
                {
                    this.SendPropertyChanging("UnidadMedida");
                    this._UnidadMedida = value;
                    this.SendPropertyChanged("UnidadMedida");
                }
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Entry toCompare = obj as Entry;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IdEntry, toCompare.IdEntry))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IdEntry.GetHashCode();
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
    }

}
