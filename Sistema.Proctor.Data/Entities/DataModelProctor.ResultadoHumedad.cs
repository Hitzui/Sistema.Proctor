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
    public partial class ResultadoHumedad : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idresultadohumedad;

        private decimal? _ProfundidadInicial;

        private decimal? _ProfundidadFinal;

        private string _TaraNo;

        private decimal? _PesoTara;

        private decimal? _PesoHumedoTara;

        private decimal? _PesoSecoTara;

        private decimal? _PesoAgua;

        private decimal? _Humedad;

        private int? _Consecutivo;

        private int? _Idensayohumedad;

        private EnsayoHumedad _EnsayoHumedad;

        public ResultadoHumedad()
        {
            this._ProfundidadInicial = 0.00m;
            this._ProfundidadFinal = 0.00m;
            OnCreated();
        }

        public int Idresultadohumedad
        {
            get
            {
                return this._Idresultadohumedad;
            }
            set
            {
                if (this._Idresultadohumedad != value)
                {
                    this.SendPropertyChanging("Idresultadohumedad");
                    this._Idresultadohumedad = value;
                    this.SendPropertyChanged("Idresultadohumedad");
                }
            }
        }

        public decimal? ProfundidadInicial
        {
            get
            {
                return this._ProfundidadInicial;
            }
            set
            {
                if (this._ProfundidadInicial != value)
                {
                    this.SendPropertyChanging("ProfundidadInicial");
                    this._ProfundidadInicial = value;
                    this.SendPropertyChanged("ProfundidadInicial");
                }
            }
        }

        public decimal? ProfundidadFinal
        {
            get
            {
                return this._ProfundidadFinal;
            }
            set
            {
                if (this._ProfundidadFinal != value)
                {
                    this.SendPropertyChanging("ProfundidadFinal");
                    this._ProfundidadFinal = value;
                    this.SendPropertyChanged("ProfundidadFinal");
                }
            }
        }

        public string TaraNo
        {
            get
            {
                return this._TaraNo;
            }
            set
            {
                if (this._TaraNo != value)
                {
                    this.SendPropertyChanging("TaraNo");
                    this._TaraNo = value;
                    this.SendPropertyChanged("TaraNo");
                }
            }
        }

        public decimal? PesoTara
        {
            get
            {
                return this._PesoTara;
            }
            set
            {
                if (this._PesoTara != value)
                {
                    this.SendPropertyChanging("PesoTara");
                    this._PesoTara = value;
                    this.SendPropertyChanged("PesoTara");
                }
            }
        }

        public decimal? PesoHumedoTara
        {
            get
            {
                return this._PesoHumedoTara;
            }
            set
            {
                if (this._PesoHumedoTara != value)
                {
                    this.SendPropertyChanging("PesoHumedoTara");
                    this._PesoHumedoTara = value;
                    this.SendPropertyChanged("PesoHumedoTara");
                }
            }
        }

        public decimal? PesoSecoTara
        {
            get
            {
                return this._PesoSecoTara;
            }
            set
            {
                if (this._PesoSecoTara != value)
                {
                    this.SendPropertyChanging("PesoSecoTara");
                    this._PesoSecoTara = value;
                    this.SendPropertyChanged("PesoSecoTara");
                }
            }
        }

        public decimal? PesoAgua
        {
            get
            {
                return this._PesoAgua;
            }
            set
            {
                if (this._PesoAgua != value)
                {
                    this.SendPropertyChanging("PesoAgua");
                    this._PesoAgua = value;
                    this.SendPropertyChanged("PesoAgua");
                }
            }
        }

        public decimal? Humedad
        {
            get
            {
                return this._Humedad;
            }
            set
            {
                if (this._Humedad != value)
                {
                    this.SendPropertyChanging("Humedad");
                    this._Humedad = value;
                    this.SendPropertyChanged("Humedad");
                }
            }
        }

        public int? Consecutivo
        {
            get
            {
                return this._Consecutivo;
            }
            set
            {
                if (this._Consecutivo != value)
                {
                    this.SendPropertyChanging("Consecutivo");
                    this._Consecutivo = value;
                    this.SendPropertyChanged("Consecutivo");
                }
            }
        }

        public int? Idensayohumedad
        {
            get
            {
                return this._Idensayohumedad;
            }
            set
            {
                if (this._Idensayohumedad != value)
                {
                    this.SendPropertyChanging("Idensayohumedad");
                    this._Idensayohumedad = value;
                    this.SendPropertyChanged("Idensayohumedad");
                }
            }
        }

        public virtual EnsayoHumedad EnsayoHumedad
        {
            get
            {
                return this._EnsayoHumedad;
            }
            set
            {
                if (this._EnsayoHumedad != value)
                {
                    this.SendPropertyChanging("EnsayoHumedad");
                    this._EnsayoHumedad = value;
                    this.SendPropertyChanged("EnsayoHumedad");
                }
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          ResultadoHumedad toCompare = obj as ResultadoHumedad;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idresultadohumedad, toCompare.Idresultadohumedad))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idresultadohumedad.GetHashCode();
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
