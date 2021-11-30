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

        public LiquidacionesNegocio()
        {
            liquidacionesMapper = new LiquidacionesMapper();

        }
        public List<Liquidaciones> TraerTodas()
        {
            return liquidacionesMapper.Traer();
        }
        public Liquidaciones Traerporidliquidacion(int idLiquidacion)
        {
            
            return liquidacionesMapper.TraerporidLiquidación(idLiquidacion);
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
