﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 10/2/2025 10:03:56 AM
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
    public partial class TipoFalla : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _IdTipoFalla;

        private string _Descripcion;

        private IList<Resultado> _Resultados;

        public TipoFalla()
        {
            this._Resultados = new List<Resultado>();
            OnCreated();
        }

        public int IdTipoFalla
        {
            get
            {
                return this._IdTipoFalla;
            }
            set
            {
                if (this._IdTipoFalla != value)
                {
                    this.SendPropertyChanging("IdTipoFalla");
                    this._IdTipoFalla = value;
                    this.SendPropertyChanged("IdTipoFalla");
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

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          TipoFalla toCompare = obj as TipoFalla;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IdTipoFalla, toCompare.IdTipoFalla))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IdTipoFalla.GetHashCode();
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
