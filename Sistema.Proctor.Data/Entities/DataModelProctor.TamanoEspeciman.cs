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
    public partial class TamanoEspeciman : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idtamano;

        private string _Tamano;

        private IList<Entry> _Entries;

        public TamanoEspeciman()
        {
            this._Entries = new List<Entry>();
            OnCreated();
        }

        public int Idtamano
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

        public string Tamano
        {
            get
            {
                return this._Tamano;
            }
            set
            {
                if (this._Tamano != value)
                {
                    this.SendPropertyChanging("Tamano");
                    this._Tamano = value;
                    this.SendPropertyChanged("Tamano");
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
          TamanoEspeciman toCompare = obj as TamanoEspeciman;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idtamano, toCompare.Idtamano))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idtamano.GetHashCode();
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
