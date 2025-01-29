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
    public partial class UnidadMedida : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private long _Idunidad;

        private string _Descripcion;

        private string _Simbolo;

        private IList<Entry> _Entries;

        public UnidadMedida()
        {
            this._Entries = new List<Entry>();
            OnCreated();
        }

        public long Idunidad
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

        public string Simbolo
        {
            get
            {
                return this._Simbolo;
            }
            set
            {
                if (this._Simbolo != value)
                {
                    this.SendPropertyChanging("Simbolo");
                    this._Simbolo = value;
                    this.SendPropertyChanged("Simbolo");
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
          UnidadMedida toCompare = obj as UnidadMedida;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idunidad, toCompare.Idunidad))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idunidad.GetHashCode();
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
