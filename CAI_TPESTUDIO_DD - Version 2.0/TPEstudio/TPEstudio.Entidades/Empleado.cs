using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class Empleado : Persona
    {
        private int _idEmpleado;
        private int _idEmpresa;
        private int _idCategoria;
        private long _cuil;
      
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;

        public Empleado(int idEmpleado, int idEmpresa, int idCategoria, long cuil, DateTime fechanacimeinto, DateTime fechaalta, bool activo, int id, string nombre, string apellido, string direccion, long telefono, string mail) : base(id, nombre, apellido, direccion, telefono, mail)
        {
            this._idEmpleado = idEmpleado;
            this._idCategoria = idCategoria;
            this._idEmpresa = idEmpresa;
            this._cuil = cuil;
            this._fechaNacimiento = fechanacimeinto;
            this._fechaAlta = fechaalta;
            this._activo = activo;
        }

        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public long Cuil { get => _cuil; set => _cuil = value; }
        
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
