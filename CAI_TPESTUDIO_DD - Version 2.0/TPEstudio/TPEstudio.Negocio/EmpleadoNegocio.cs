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
        private LiquidacionesMapper _liquidacionesMapper;
        private List<Empleado> _empleado;
        private List<Liquidaciones> _liquidaciones;
        public EmpleadoNegocio()
        {
            _empleadoMapper = new EmpleadoMapper();
            _liquidacionesMapper = new LiquidacionesMapper();
            _liquidaciones = new List<Liquidaciones>();
            _empleado = new List<Empleado>();
        }
        public List<Empleado> TraerTodos()
        {
            try
            {
                _liquidaciones = _liquidacionesMapper.Traer();
                _empleado = _empleadoMapper.Traer();

                foreach (var empleado in _empleado)
                {
                    foreach (var liquidaciones in _liquidaciones)
                    {
                        if (empleado.Id == liquidaciones.IdEmpleado)
                            empleado.Liq = liquidaciones;
                    }


                }


                return _empleado;
            }
            catch(Exception ex)
            {
                throw new Exception("No se puedo traer a los empleados");
            }
            

            
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
