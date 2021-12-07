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
        
        private Categoria _categorias;
        private Empresa _empresa;
        
       
        

        public Empleado(Categoria categoria,Empresa empresa, int idempresa, int idcategoria, long cuil, string nombre, string apellido, DateTime fechanacimeinto) : base(nombre, apellido)
        {

            this.IdCategoria = idcategoria;
            this.IdEmpresa = idempresa;
            this._cuil = cuil;
            this._fechaNacimiento = fechanacimeinto;
            this._categorias = categoria;
            this._empresa = empresa;
            
        }
        public Empleado()
        {

        }
            
        
        public int Id { get => _id; set => _id = value; }
       
        public long Cuil { get => _cuil; set => _cuil = value; }
        
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Categoria Categorias { get => _categorias; set => _categorias = value; }
        public Empresa Empresas { get => _empresa; set => _empresa = value; }

        public override string ToString()
        {
            return Display();
        }
        internal override string Display()
        {

            return $"{this.Nombre}-{this.Apellido}-Cuil:{this._cuil}-{this.Categorias}";
            /*return $"{this.Nombre}-{this.Apellido}-Cuil:{this._cuil}- Empresa: {this.Empresas.DetalleEmpresa}-/{this.Categorias.NombreyConvenio}*/
            
            
        }
        public string DetalleEmpleado
        {
            get
            {
                return $"{this.Nombre}-{this.Apellido}-{this.Empresas.RazonSocial}";
            }
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
