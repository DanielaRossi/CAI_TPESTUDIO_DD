using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class EmpleadoNegocio
    {
        private EmpleadoMapper _empleadoMapper;
        public EmpleadoNegocio()
        {
            _empleadoMapper = new EmpleadoMapper();
        }
        public List<Empleado> TraerTodos()
        {
            return _empleadoMapper.Traer();
        }
        public void Alta(Categoria categoria,Empresa empresa, long cuit,string nombre,string apellido, DateTime fechanacimiento)
        {
            Empleado empleado = new Empleado(empresa.Id, categoria.Id,cuit, nombre, apellido, fechanacimiento);
            TransactionResult result = _empleadoMapper.Insertar(empleado);
            if(!result.IsOk)
            {
                throw new Exception("No se puede dar de alta el empleado por" + result.Error);

            }
        }
    }
}
