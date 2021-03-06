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
        public void Alta(string razon, long cuit, string domicilio)
        {
            if(cuit>99999999999|| cuit < 11111111111)
            {
                throw new Exception("La cuit de la empresa debe tener 11 dígitos.");
            }
            
                Empresa e = new Empresa(razon, cuit, domicilio);

            foreach (Empresa empresa in empresaMapper.Traer())
            {
                if (empresa.Cuit.Equals(e.Cuit))
                {

                    throw new Exception("La empresa ya existe.");
                }
            }


            TransactionResult result = empresaMapper.Insertar(e);

                if (!result.IsOk)
                {
                    throw new Exception("Error al dar de alta. Detalle: " + result.Error);
                }
            
            
            
            
        }
              
    }
}
