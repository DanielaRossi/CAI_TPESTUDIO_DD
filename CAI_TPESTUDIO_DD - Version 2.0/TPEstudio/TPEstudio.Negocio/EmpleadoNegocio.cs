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
        public void Alta(int categoria,int empresa, long cuit,string nombre,string apellido, DateTime fechaNacimiento)
        {

        }
    }
}
