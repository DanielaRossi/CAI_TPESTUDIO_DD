using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;


namespace TPEstudio.Negocio
{
    public class EmpresaServicio
    {
        private EmpresaMapper _empresaMapper;

        public EmpresaServicio()
        {
            _empresaMapper = new EmpresaMapper();
        }

        public List<Empresa> GetEmpresas()
        {
            return _empresaMapper.TraerEmpresas();
        }
    }
}
