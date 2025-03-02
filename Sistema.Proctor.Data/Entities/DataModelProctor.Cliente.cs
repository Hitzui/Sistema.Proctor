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
    public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Idcliente;

        private string _Celular;

        private string _Ciudad;

        private string _Contacto;

        private string _Departamento;

        private string _Direccion;

        private string _Email;

        private DateTime? _FIngreso;

        private string _NombreAbreviado;

        private string _NombreComercial;

        private string _Ruc;

        private string _Telefono;

        private int? _CreatedBy;

        private DateTime _CreatedAt;

        private int? _UpdatedBy;

        private DateTime _UpdatedAt;

        private IList<Proyecto> _Proyectos;

        public Cliente()
        {
            this._Proyectos = new List<Proyecto>();
            OnCreated();
        }

        public int Idcliente
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

        public string Celular
        {
            get
            {
                return this._Celular;
            }
            set
            {
                if (this._Celular != value)
                {
                    this.SendPropertyChanging("Celular");
                    this._Celular = value;
                    this.SendPropertyChanged("Celular");
                }
            }
        }

        public string Ciudad
        {
            get
            {
                return this._Ciudad;
            }
            set
            {
                if (this._Ciudad != value)
                {
                    this.SendPropertyChanging("Ciudad");
                    this._Ciudad = value;
                    this.SendPropertyChanged("Ciudad");
                }
            }
        }

        public string Contacto
        {
            get
            {
                return this._Contacto;
            }
            set
            {
                if (this._Contacto != value)
                {
                    this.SendPropertyChanging("Contacto");
                    this._Contacto = value;
                    this.SendPropertyChanged("Contacto");
                }
            }
        }

        public string Departamento
        {
            get
            {
                return this._Departamento;
            }
            set
            {
                if (this._Departamento != value)
                {
                    this.SendPropertyChanging("Departamento");
                    this._Departamento = value;
                    this.SendPropertyChanged("Departamento");
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

        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if (this._Email != value)
                {
                    this.SendPropertyChanging("Email");
                    this._Email = value;
                    this.SendPropertyChanged("Email");
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

        public string NombreAbreviado
        {
            get
            {
                return this._NombreAbreviado;
            }
            set
            {
                if (this._NombreAbreviado != value)
                {
                    this.SendPropertyChanging("NombreAbreviado");
                    this._NombreAbreviado = value;
                    this.SendPropertyChanged("NombreAbreviado");
                }
            }
        }

        public string NombreComercial
        {
            get
            {
                return this._NombreComercial;
            }
            set
            {
                if (this._NombreComercial != value)
                {
                    this.SendPropertyChanging("NombreComercial");
                    this._NombreComercial = value;
                    this.SendPropertyChanged("NombreComercial");
                }
            }
        }

        public string Ruc
        {
            get
            {
                return this._Ruc;
            }
            set
            {
                if (this._Ruc != value)
                {
                    this.SendPropertyChanging("Ruc");
                    this._Ruc = value;
                    this.SendPropertyChanged("Ruc");
                }
            }
        }

        public string Telefono
        {
            get
            {
                return this._Telefono;
            }
            set
            {
                if (this._Telefono != value)
                {
                    this.SendPropertyChanging("Telefono");
                    this._Telefono = value;
                    this.SendPropertyChanged("Telefono");
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

        public virtual IList<Proyecto> Proyectos
        {
            get
            {
                return this._Proyectos;
            }
            set
            {
                this._Proyectos = value;
            }
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Cliente toCompare = obj as Cliente;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Idcliente, toCompare.Idcliente))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Idcliente.GetHashCode();
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
