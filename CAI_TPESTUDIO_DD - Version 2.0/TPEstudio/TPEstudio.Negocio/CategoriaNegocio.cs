using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

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
        public void Alta(string nombre, string convenio, double sueldobasico)
        {
            Categoria c= new Categoria(nombre, convenio, sueldobasico);
            TransactionResult result= _categoriaMapper.Insertar(c);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }

        }
    }
}
