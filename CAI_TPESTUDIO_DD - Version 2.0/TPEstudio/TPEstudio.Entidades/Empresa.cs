using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class Empresa
    {
        private int _id;
        private string _razonSocial;
        private long _cuit;
        private string _domicilio;
        private DateTime _fechaAlta;

        public int Id { get => _id; set => _id = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public long Cuit { get => _cuit; set => _cuit = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public Empresa( string razonSocial, long cuit, string domicilio)
        {
            
            _razonSocial = razonSocial;
            _cuit = cuit;
            _domicilio = domicilio;
            _fechaAlta = DateTime.Today;
            
        }
        
        public override string ToString()
        {
            return $"{this.Id}) {this.RazonSocial}- Cuil: {this.Cuit}-Domicilio: {this._domicilio}-Fecha de alta: { this._fechaAlta}";
        }
        public string DetalleEmpresa
        {
            get
            {
                return $"{this._razonSocial}";
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Empresa))
                return false;
            Empresa empresaacomparar = (Empresa)obj;
            if (empresaacomparar._id == this._id)
                return true;
            else
                return false;
        }
    }
}
