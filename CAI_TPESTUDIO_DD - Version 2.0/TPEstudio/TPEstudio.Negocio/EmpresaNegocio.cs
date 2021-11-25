using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class EmpresaNegocio
    {
        private EmpresaMapper empresaMapper;

        public EmpresaNegocio()
        {
            empresaMapper = new EmpresaMapper();

        }
        public List<Empresa> TraerTodas()
        {
            return empresaMapper.Traer();
        }
        public TransactionResult Alta(string razon, long cuit, string domicilio)
        {
            Empresa e = new Empresa(razon, cuit, domicilio);

            TransactionResult result = empresaMapper.Insertar(e);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }
            return result;
        }
              
    }
}
