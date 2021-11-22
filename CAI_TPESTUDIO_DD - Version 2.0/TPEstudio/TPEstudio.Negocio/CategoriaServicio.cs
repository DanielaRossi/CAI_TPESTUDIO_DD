using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class CategoriaServicio
    {
        private CategoriaMapper _categoriaMapper;

        public CategoriaServicio()
        {
            _categoriaMapper = new CategoriaMapper();
        }

        public List <Categoria> GetCategorias()
        {
           return _categoriaMapper.TraerCategorias();
        }
    }
}
