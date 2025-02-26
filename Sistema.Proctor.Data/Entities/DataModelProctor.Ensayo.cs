﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 26/2/2025 1:32:31 PM
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
    public partial class Ensayo : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idensayo;

        private int? _EdadReal;

        private DateTime? _FechaIngreso;

        private DateTime? _FechaPrevista;

        private DateTime? _FechaReal;

        private int? _Idempleado;

        private int? _Idtipoensayo;

        private int? _Idmuestra;

        private Empleado _Empleado;

        private Muestra _Muestra;

        private TipoEnsayo _TipoEnsayo;

        public Ensayo()
        {
            OnCreated();
        }

        public int Idensayo
        {
            get
            {
                return this._Idensayo;
            }
            set
            {
                if (this._Idensayo != value)
                {
                    this.SendPropertyChanging("Idensayo");
                    this._Idensayo = value;
                    this.SendPropertyChanged("Idensayo");
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

        public DateTime? FechaIngreso
        {
            get
            {
                return this._FechaIngreso;
            }
            set
            {
                if (this._FechaIngreso != value)
                {
                    this.SendPropertyChanging("FechaIngreso");
                    this._FechaIngreso = value;
                    this.SendPropertyChanged("FechaIngreso");
                }
            }
        }

        public DateTime? FechaPrevista
        {
            get
            {
                return this._FechaPrevista;
            }
            set
            {
                if (this._FechaPrevista != value)
                {
                    this.SendPropertyChanging("FechaPrevista");
                    this._FechaPrevista = value;
                    this.SendPropertyChanged("FechaPrevista");
                }
            }
        }

        public DateTime? FechaReal
        {
            get
            {
                return this._FechaReal;
            }
            set
            {
                if (this._FechaReal != value)
                {
                    this.SendPropertyChanging("FechaReal");
                    this._FechaReal = value;
                    this.SendPropertyChanged("FechaReal");
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

        public int? Idtipoensayo
        {
            get
            {
                return this._Idtipoensayo;
            }
            set
            {
                if (this._Idtipoensayo != value)
                {
                    this.SendPropertyChanging("Idtipoensayo");
                    this._Idtipoensayo = value;
                    this.SendPropertyChanged("Idtipoensayo");
                }
            }
        }

        public int? Idmuestra
        {
            get
            {
                return this._Idmuestra;
            }
            set
            {
                if (this._Idmuestra != value)
                {
                    this.SendPropertyChanging("Idmuestra");
                    this._Idmuestra = value;
                    this.SendPropertyChanged("Idmuestra");
                }
            }
        }

        public virtual Empleado Empleado
        {
            get
            {
                return this._Empleado;
            }
            set
            {
                if (this._Empleado != value)
                {
                    this.SendPropertyChanging("Empleado");
                    this._Empleado = value;
                    this.SendPropertyChanged("Empleado");
                }
            }
        }

        public virtual Muestra Muestra
        {
            get
            {
                return this._Muestra;
            }
            set
            {
                if (this._Muestra != value)
                {
                    this.SendPropertyChanging("Muestra");
                    this._Muestra = value;
                    this.SendPropertyChanged("Muestra");
                }
            }
        }

        public virtual TipoEnsayo TipoEnsayo
        {
            get
            {
                return this._TipoEnsayo;
            }
            set
            {
                if (this._TipoEnsayo != value)
                {
                    this.SendPropertyChanging("TipoEnsayo");
                    this._TipoEnsayo = value;
                    this.SendPropertyChanged("TipoEnsayo");
                }
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Ensayo toCompare = obj as Ensayo;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idensayo, toCompare.Idensayo))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idensayo.GetHashCode();
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
