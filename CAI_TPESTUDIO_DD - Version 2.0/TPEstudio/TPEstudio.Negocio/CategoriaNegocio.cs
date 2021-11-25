using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;
using TPEstudio.Entidades.Enums;
using TPEstudio.Entidades.Expection;

namespace TPEstudio.Negocio
{
    public class CategoriaNegocio
    {
        private CategoriaMapper _categoriaMapper;
        public CategoriaNegocio()
        {
            _categoriaMapper = new CategoriaMapper();
        }
        public List<Categoria> TraerTodas()
        {
            return _categoriaMapper.Traer();
        }
        public void Alta(string nombre, ConvenioEnum convenio, double sueldobasico)
        {
            if (sueldobasico < 1000)
            {
                throw new SueldoBasicoFueraLimiteExpection();
            }
            Categoria c= new Categoria(nombre, convenio.ToString(), sueldobasico);
            TransactionResult result= _categoriaMapper.Insertar(c);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }
            

        }
    }
}
