using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class LiquidacionesServicio
    {
        private LiquidacionMapper _liquiacionMapper;

        public LiquidacionesServicio()
        {
            _liquiacionMapper = new LiquidacionMapper();
        }

        public List <Liquidaciones> GetLiquidaciones()
        {
            return _liquiacionMapper.TraerLiquidaciones();
        }

    }
}
