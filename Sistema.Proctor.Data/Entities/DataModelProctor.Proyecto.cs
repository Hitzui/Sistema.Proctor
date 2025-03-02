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
    public partial class Proyecto : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

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

        private int? _CreatedBy;

        private DateTime _CreatedAt;

        private int? _UpdatedBy;

        private DateTime _UpdatedAt;

        private Cliente _Cliente;

        private IList<Entry> _Entries;

        public Proyecto()
        {
            this._Entries = new List<Entry>();
            OnCreated();
        }

        public int Idproyecto
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

        public bool Activo
        {
            get
            {
                return this._Activo;
            }
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
            get
            {
                return this._CodigoProyecto;
            }
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
            get
            {
                return this._Descripcion;
            }
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
            get
            {
                return this._DescripcionMezcla;
            }
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
            get
            {
                return this._FechaFin;
            }
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
            get
            {
                return this._FechaInicio;
            }
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
            get
            {
                return this._FechaMuestreo;
            }
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
            get
            {
                return this._ProecedenciaConcreto;
            }
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
            get
            {
                return this._UbicacionMuestra;
            }
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
            get
            {
                return this._UbicacionProyecto;
            }
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
            get
            {
                return this._Idcliente;
            }
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

        public int? CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                if (this._CreatedBy != value)
                {
                    this.SendPropertyChanging("CreatedBy");
                    this._CreatedBy = value;
                    this.SendPropertyChanged("CreatedBy");
                }
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return this._CreatedAt;
            }
            set
            {
                if (this._CreatedAt != value)
                {
                    this.SendPropertyChanging("CreatedAt");
                    this._CreatedAt = value;
                    this.SendPropertyChanged("CreatedAt");
                }
            }
        }

        public int? UpdatedBy
        {
            get
            {
                return this._UpdatedBy;
            }
            set
            {
                if (this._UpdatedBy != value)
                {
                    this.SendPropertyChanging("UpdatedBy");
                    this._UpdatedBy = value;
                    this.SendPropertyChanged("UpdatedBy");
                }
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                return this._UpdatedAt;
            }
            set
            {
                if (this._UpdatedAt != value)
                {
                    this.SendPropertyChanging("UpdatedAt");
                    this._UpdatedAt = value;
                    this.SendPropertyChanged("UpdatedAt");
                }
            }
        }

        public virtual Cliente Cliente
        {
            get
            {
                return this._Cliente;
            }
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

        public virtual IList<Entry> Entries
        {
            get
            {
                return this._Entries;
            }
            set
            {
                this._Entries = value;
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

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
    }

}
