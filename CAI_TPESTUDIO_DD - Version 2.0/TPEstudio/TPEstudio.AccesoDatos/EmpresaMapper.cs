using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.Entidades;


namespace TPEstudio.AccesoDatos
{
    public class EmpresaMapper
    {
        private List<Empresa> _empresas;




        public List<Empresa> TraerEmpresas()
        {
            return _empresas;
        }
    }
}
