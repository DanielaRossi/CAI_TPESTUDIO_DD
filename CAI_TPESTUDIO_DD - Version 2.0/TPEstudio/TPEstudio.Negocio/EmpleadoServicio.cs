using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class EmpleadoServicio
    {
        private EmpleadoMapper _empleadoMapper;
        
        public EmpleadoServicio()
        {
            _empleadoMapper = new EmpleadoMapper();
        }

        public List<Empleado> TraerEmpleados()
        {
            return _empleadoMapper.TraerEmpleados();
        }
    }
}
