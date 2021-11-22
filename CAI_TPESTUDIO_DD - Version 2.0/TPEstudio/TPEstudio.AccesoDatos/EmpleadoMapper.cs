using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.Entidades;
namespace TPEstudio.AccesoDatos
{
    public class EmpleadoMapper
    {
        private List<Empleado> _empleados;

        public List <Empleado> TraerEmpleados()
        {
            return _empleados;
        }
    }
}
