﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 29/1/2025 9:33:11 AM
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
    public partial class Muestra : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idmuestra;

        private int? _Idproyecto;

        private string _SondeoNumero;

        private string _MuestraNumero;

        private string _Coordenadas;

        private string _LadoBanda;

        private string _DescripcionMaterial;

        private int? _Idcliente;

        private int? _Idempleado;

        private DateTime? _FechaEnsayo;

        private string _CoordeandasZ;

        private string _CodigoIngreso;

        private Cliente _Cliente;

        private Empleado _Empleado;

        private Proyecto _Proyecto;

        private IList<EnsayoProctor> _EnsayoProctors;

        public Muestra()
        {
            this._EnsayoProctors = new List<EnsayoProctor>();
            OnCreated();
        }

        public int Idmuestra
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

        public string SondeoNumero
        {
            get
            {
                return this._SondeoNumero;
            }
            set
            {
                if (this._SondeoNumero != value)
                {
                    this.SendPropertyChanging("SondeoNumero");
                    this._SondeoNumero = value;
                    this.SendPropertyChanged("SondeoNumero");
                }
            }
        }

        public string MuestraNumero
        {
            get
            {
                return this._MuestraNumero;
            }
            set
            {
                if (this._MuestraNumero != value)
                {
                    this.SendPropertyChanging("MuestraNumero");
                    this._MuestraNumero = value;
                    this.SendPropertyChanged("MuestraNumero");
                }
            }
        }

        public string Coordenadas
        {
            get
            {
                return this._Coordenadas;
            }
            set
            {
                if (this._Coordenadas != value)
                {
                    this.SendPropertyChanging("Coordenadas");
                    this._Coordenadas = value;
                    this.SendPropertyChanged("Coordenadas");
                }
            }
        }

        public string LadoBanda
        {
            get
            {
                return this._LadoBanda;
            }
            set
            {
                if (this._LadoBanda != value)
                {
                    this.SendPropertyChanging("LadoBanda");
                    this._LadoBanda = value;
                    this.SendPropertyChanged("LadoBanda");
                }
            }
        }

        public string DescripcionMaterial
        {
            get
            {
                return this._DescripcionMaterial;
            }
            set
            {
                if (this._DescripcionMaterial != value)
                {
                    this.SendPropertyChanging("DescripcionMaterial");
                    this._DescripcionMaterial = value;
                    this.SendPropertyChanged("DescripcionMaterial");
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

        public DateTime? FechaEnsayo
        {
            get
            {
                return this._FechaEnsayo;
            }
            set
            {
                if (this._FechaEnsayo != value)
                {
                    this.SendPropertyChanging("FechaEnsayo");
                    this._FechaEnsayo = value;
                    this.SendPropertyChanged("FechaEnsayo");
                }
            }
        }

        public string CoordeandasZ
        {
            get
            {
                return this._CoordeandasZ;
            }
            set
            {
                if (this._CoordeandasZ != value)
                {
                    this.SendPropertyChanging("CoordeandasZ");
                    this._CoordeandasZ = value;
                    this.SendPropertyChanged("CoordeandasZ");
                }
            }
        }

        public string CodigoIngreso
        {
            get
            {
                return this._CodigoIngreso;
            }
            set
            {
                if (this._CodigoIngreso != value)
                {
                    this.SendPropertyChanging("CodigoIngreso");
                    this._CodigoIngreso = value;
                    this.SendPropertyChanged("CodigoIngreso");
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
          Muestra toCompare = obj as Muestra;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idmuestra, toCompare.Idmuestra))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idmuestra.GetHashCode();
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
