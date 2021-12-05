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
        public Empleado TraerEmpleadosporId(int idEmpleado)
        {
            try
            {

                return _empleadoMapper.Traerporid(idEmpleado);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo traer a los empleados");
            }



        }
        public Empleado TraerEmpleadosporEmpresa(int idEmpresa)
        {
            try
            {
                
                _empleado = _empleadoMapper.Traer();
                Empleado resultado = null;

                foreach (var empleado in _empleado)
                {

                    if (empleado.IdEmpresa == idEmpresa)
                        resultado = empleado;
                    


                }


                return resultado;


            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo traer a los empleados");
            }



        }
        public void Alta(Categoria categoria,Empresa empresa, long cuil,string nombre,string apellido, DateTime fechanacimiento)
        {
            if (cuil > 99999999999 || cuil < 11111111111)
            {
                throw new Exception("El cuil del empleado debe tener 11 dígitos.");
            }
            Empleado empleado = new Empleado(empresa.Id, categoria.Id,cuil, nombre, apellido, fechanacimiento);
            //empleado.NombreEmpresa = empresa.RazonSocial;

            TransactionResult result = _empleadoMapper.Insertar(empleado);
            if(!result.IsOk)
            {
                throw new Exception("No se puede dar de alta el empleado por" + result.Error);

            }
        }
    }
}
