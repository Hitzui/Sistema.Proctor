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
    public partial class EnsayoProctor : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idensayo;

        private int _Idempleado;

        private int? _Idmuestra;

        private DateTime? _FechaEnsayo;

        private string _Norma;

        private string _MetodoUtilizado;

        private float? _PesoMartilloLb;

        private float? _PesoMaterialG;

        private float? _TemperaturaSecado;

        private decimal? _DiametroMoldeCm;

        private decimal? _AlturaMoldeCm;

        private int? _NumCapas;

        private int? _NumGolpes;

        private string _TipoProctor;

        private decimal? _DensidadMaxima;

        private decimal? _HumedadOptima;

        private int? _CreatedBy;

        private DateTime _CreatedAt;

        private int? _UpdatedBy;

        private DateTime _UpdatedAt;

        private Empleado _Empleado;

        private IList<ResultadosProctor> _ResultadosProctors;

        public EnsayoProctor()
        {
            this._DensidadMaxima = 0.0000m;
            this._HumedadOptima = 0.0000m;
            this._ResultadosProctors = new List<ResultadosProctor>();
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

        public string Norma
        {
            get
            {
                return this._Norma;
            }
            set
            {
                if (this._Norma != value)
                {
                    this.SendPropertyChanging("Norma");
                    this._Norma = value;
                    this.SendPropertyChanged("Norma");
                }
            }
        }

        public string MetodoUtilizado
        {
            get
            {
                return this._MetodoUtilizado;
            }
            set
            {
                if (this._MetodoUtilizado != value)
                {
                    this.SendPropertyChanging("MetodoUtilizado");
                    this._MetodoUtilizado = value;
                    this.SendPropertyChanged("MetodoUtilizado");
                }
            }
        }

        public float? PesoMartilloLb
        {
            get
            {
                return this._PesoMartilloLb;
            }
            set
            {
                if (this._PesoMartilloLb != value)
                {
                    this.SendPropertyChanging("PesoMartilloLb");
                    this._PesoMartilloLb = value;
                    this.SendPropertyChanged("PesoMartilloLb");
                }
            }
        }

        public float? PesoMaterialG
        {
            get
            {
                return this._PesoMaterialG;
            }
            set
            {
                if (this._PesoMaterialG != value)
                {
                    this.SendPropertyChanging("PesoMaterialG");
                    this._PesoMaterialG = value;
                    this.SendPropertyChanged("PesoMaterialG");
                }
            }
        }

        public float? TemperaturaSecado
        {
            get
            {
                return this._TemperaturaSecado;
            }
            set
            {
                if (this._TemperaturaSecado != value)
                {
                    this.SendPropertyChanging("TemperaturaSecado");
                    this._TemperaturaSecado = value;
                    this.SendPropertyChanged("TemperaturaSecado");
                }
            }
        }

        public decimal? DiametroMoldeCm
        {
            get
            {
                return this._DiametroMoldeCm;
            }
            set
            {
                if (this._DiametroMoldeCm != value)
                {
                    this.SendPropertyChanging("DiametroMoldeCm");
                    this._DiametroMoldeCm = value;
                    this.SendPropertyChanged("DiametroMoldeCm");
                }
            }
        }

        public decimal? AlturaMoldeCm
        {
            get
            {
                return this._AlturaMoldeCm;
            }
            set
            {
                if (this._AlturaMoldeCm != value)
                {
                    this.SendPropertyChanging("AlturaMoldeCm");
                    this._AlturaMoldeCm = value;
                    this.SendPropertyChanged("AlturaMoldeCm");
                }
            }
        }

        public int? NumCapas
        {
            get
            {
                return this._NumCapas;
            }
            set
            {
                if (this._NumCapas != value)
                {
                    this.SendPropertyChanging("NumCapas");
                    this._NumCapas = value;
                    this.SendPropertyChanged("NumCapas");
                }
            }
        }

        public int? NumGolpes
        {
            get
            {
                return this._NumGolpes;
            }
            set
            {
                if (this._NumGolpes != value)
                {
                    this.SendPropertyChanging("NumGolpes");
                    this._NumGolpes = value;
                    this.SendPropertyChanged("NumGolpes");
                }
            }
        }

        public string TipoProctor
        {
            get
            {
                return this._TipoProctor;
            }
            set
            {
                if (this._TipoProctor != value)
                {
                    this.SendPropertyChanging("TipoProctor");
                    this._TipoProctor = value;
                    this.SendPropertyChanged("TipoProctor");
                }
            }
        }

        public decimal? DensidadMaxima
        {
            get
            {
                return this._DensidadMaxima;
            }
            set
            {
                if (this._DensidadMaxima != value)
                {
                    this.SendPropertyChanging("DensidadMaxima");
                    this._DensidadMaxima = value;
                    this.SendPropertyChanged("DensidadMaxima");
                }
            }
        }

        public decimal? HumedadOptima
        {
            get
            {
                return this._HumedadOptima;
            }
            set
            {
                if (this._HumedadOptima != value)
                {
                    this.SendPropertyChanging("HumedadOptima");
                    this._HumedadOptima = value;
                    this.SendPropertyChanged("HumedadOptima");
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

        public virtual IList<ResultadosProctor> ResultadosProctors
        {
            get
            {
                return this._ResultadosProctors;
            }
            set
            {
                this._ResultadosProctors = value;
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          EnsayoProctor toCompare = obj as EnsayoProctor;
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
