using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades.Expection
{
    public class SueldoBasicoFueraLimiteExpection : Exception
    {
        public SueldoBasicoFueraLimiteExpection():base("El sueldo basico no puede ser menor que 1000.") { }
        
        
    }
}
