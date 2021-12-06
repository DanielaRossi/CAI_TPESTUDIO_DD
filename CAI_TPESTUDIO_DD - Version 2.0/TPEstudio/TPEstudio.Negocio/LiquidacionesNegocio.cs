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

        public LiquidacionesNegocio()
        {
            liquidacionesMapper = new LiquidacionesMapper();
            _empleadoMapper = new EmpleadoMapper();
            _empleados = new List<Empleado>();
            _liquidaciones = new List<Liquidaciones>();

        }
        public List<Liquidaciones> TraerTodas()
        {
            _liquidaciones = liquidacionesMapper.Traer();
            _empleados = _empleadoMapper.Traer();

            foreach (var liquidaciones in _liquidaciones)
            {
                foreach (var empleado in _empleados)
                {
                    if (empleado.Id == liquidaciones.IdEmpleado)
                        //empleado.Liq = liquidaciones;
                        liquidaciones.Empleados = empleado;
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
            foreach(Liquidaciones l in liquidacionesMapper.Traer())
            {
                foreach(Empleado e in _empleadoMapper.Traer())
                {
                    if(e.IdCategoria == idcategoria)
                    {
                        liquidacionesporcategoria.Add(l);
                    }
                }
                //if (l.Empleados.Categorias.Id == idcategoria)
                //{
                //    
                //}
            }
            return liquidacionesporcategoria;
        }
        public void Alta(int idempleado, int periodo, string codigo, double bruto, double descuentos)
        {

            Liquidaciones l = new Liquidaciones(idempleado, codigo, periodo, bruto, descuentos);

            TransactionResult result = liquidacionesMapper.Insertar(l);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }




        }
    }
}
