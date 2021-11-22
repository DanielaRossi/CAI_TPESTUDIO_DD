using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.Entidades;
namespace TPEstudio.AccesoDatos
{
    public class LiquidacionMapper
    {
        private List<Liquidaciones> _liquidaciones;

        public List<Liquidaciones> TraerLiquidaciones()
        {
            return _liquidaciones;
        }
    }
}
