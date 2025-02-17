﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 15/2/2025 8:53:34 PM
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
    public partial class Empleado : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idempleado;

        private string _Apellido;

        private string _Cedula;

        private string _Direccion;

        private DateTime? _FIngreso;

        private DateTime? _FNacimiento;

        private string _Nombre;

        private IList<Ensayo> _Ensayos;

        private IList<EnsayoProctor> _EnsayoProctors;

        public Empleado()
        {
            this._Ensayos = new List<Ensayo>();
            this._EnsayoProctors = new List<EnsayoProctor>();
            OnCreated();
        }

        public int Idempleado
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

        public string Apellido
        {
            get
            {
                return this._Apellido;
            }
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
            get
            {
                return this._Cedula;
            }
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
            get
            {
                return this._Direccion;
            }
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
            get
            {
                return this._FIngreso;
            }
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
            get
            {
                return this._FNacimiento;
            }
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
            get
            {
                return this._Nombre;
            }
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

        public virtual IList<Ensayo> Ensayos
        {
            get
            {
                return this._Ensayos;
            }
            set
            {
                this._Ensayos = value;
            }
        }

        public virtual IList<EnsayoProctor> EnsayoProctors
        {
            get
            {
                return this._EnsayoProctors;
            }
            set
            {
                this._EnsayoProctors = value;
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

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
