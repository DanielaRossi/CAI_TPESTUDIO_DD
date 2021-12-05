using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class Empleado : Persona
    {
        private int _id;
        private int _idEmpresa;
        private int _idCategoria;
        private long _cuil;
      
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private Liquidaciones _liquidacion;
        //private string _nombreEmpresa;
       
        

        public Empleado(int idEmpresa, int idCategoria, long cuil, string nombre, string apellido, DateTime fechanacimeinto) : base(nombre, apellido)
        {

            this._idCategoria = idCategoria;
            this._idEmpresa = idEmpresa;
            this._cuil = cuil;
            this._fechaNacimiento = fechanacimeinto;
        }
            
        public Liquidaciones Liq { get => _liquidacion; set => _liquidacion = value; }
        public int Id { get => _id; set => _id = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public long Cuil { get => _cuil; set => _cuil = value; }
        
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public string NombreEmpresa { get => _nombreEmpresa; set => _nombreEmpresa = value; }
           
        public override string ToString()
        {
            return Display();
        }
        internal override string Display()
        {
            
                return $"{this._id}){this.Nombre}-{this.Apellido}-Cuil:{this._cuil}-Empresa:{this._nombreEmpresa}";
            
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Empleado))
                return false;
            Empleado empleadoacomparar = (Empleado)obj;
            if (empleadoacomparar._id == this._id)
                return true;
            else
                return false;
        }
    }
}
