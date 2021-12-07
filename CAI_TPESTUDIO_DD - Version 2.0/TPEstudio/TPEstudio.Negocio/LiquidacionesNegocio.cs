using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class LiquidacionesNegocio
    {
        private LiquidacionesMapper liquidacionesMapper;
        private List<Liquidaciones> _liquidaciones;
        private List<Empleado> _empleados;
        private EmpleadoMapper _empleadoMapper;
        private EmpleadoNegocio _empleadoNegocio;

        public LiquidacionesNegocio()
        {
            liquidacionesMapper = new LiquidacionesMapper();
            _empleadoMapper = new EmpleadoMapper();
            _empleados = new List<Empleado>();
            _liquidaciones = new List<Liquidaciones>();
            _empleadoNegocio = new EmpleadoNegocio();

        }
        public List<Liquidaciones> TraerTodas()
        {
            
            _empleados = _empleadoNegocio.TraerTodos();
            _liquidaciones = liquidacionesMapper.Traer();

            foreach (var liquidaciones in _liquidaciones)
            {
                foreach (var empleado in _empleados)
                {
                    if (empleado.Id == liquidaciones.IdEmpleado)
                    {
                        
                        liquidaciones.Empleados = empleado;
                        
                    }
                        
                    


                }


            }



            return _liquidaciones;
            
        }
        public Liquidaciones Traerporidliquidacion(int idLiquidacion)
        {
            Liquidaciones liquidacionporid = null;
            foreach ( Liquidaciones l in _liquidaciones)
            {
                if(l.Id == idLiquidacion)
                {

                    liquidacionporid = l;
                    
                }
            }
            if(liquidacionporid == null)
                    {
                throw new Exception("No hay liquidaciones con ese id.");
            }

            return liquidacionporid;
        }
        public List<Liquidaciones> Traerliquidacionesporcategoria(int idcategoria)
        {
            
            List<Liquidaciones> liquidacionesporcategoria = new List<Liquidaciones>();
            foreach ( Liquidaciones l in _liquidaciones)
            {
                if(l.Empleados.IdCategoria== idcategoria)
                {
                    liquidacionesporcategoria.Add(l);
                }
            }
            if (liquidacionesporcategoria.Count == 0)
            {
                throw new Exception("La categoría seleccionada no tiene liquidaciones.");
            }
            return liquidacionesporcategoria;

        }
        public void Alta(Empleado empleado, int idempleado, int periodo, string codigo, double bruto, double descuentos)
        {
            if (idempleado == 0)
            {
                throw new Exception("Debe seleccionar un empleado.");
            }
            if (periodo == 0)
            {
                throw new Exception("Debe seleccionar un período.");
            }
            //foreach(Liquidaciones li in _liquidaciones)
            //{
            //    if(li.IdEmpleado.Equals(idempleado)&& li.Periodo.Equals(periodo))
            //    {
            //        throw new Exception("Ya ingresó una liquidación para ese mes para ese empleado.");
            //    }
            //}
            Liquidaciones l = new Liquidaciones(empleado, idempleado, codigo, periodo, bruto, descuentos);

            TransactionResult result = liquidacionesMapper.Insertar(l);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }




        }
    }
}
