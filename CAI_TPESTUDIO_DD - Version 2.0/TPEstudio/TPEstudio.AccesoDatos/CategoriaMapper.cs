using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.Entidades;

namespace TPEstudio.AccesoDatos
{
    public class CategoriaMapper
    {
        private List<Categoria> _categorias;
    
        public List<Categoria> TraerCategorias()
        {
            return _categorias;
        }
    
    }
}
