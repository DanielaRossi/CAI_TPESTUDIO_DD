using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.Entidades;

namespace TPEstudio.AccesoDatos
{
    public class CategoriaMapper
    {
        public List<Categoria> Traer()
        {
            string json = WebHelper.Get("/EstudioContable/Categorias");
            List<Categoria> lst = MapList(json);
            return lst;
        }
        public List<Categoria> MapList(string json)
        {
            List<Categoria> lst = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return lst;
        }

        public TransactionResult Insertar(Categoria categoria)
        {
            NameValueCollection obj =  MapRever(categoria);
            string json= WebHelper.Post("/EstudioContable/Categoria", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
                
        }
        public NameValueCollection MapRever(Categoria categoria)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", categoria.Nombre);
            n.Add("Convenio", categoria.Convenio);
            n.Add("SueldoBasico", categoria.SueldoBasico.ToString("0.00"));
            n.Add("Usuario", "880671");
            n.Add("Id", categoria.Id.ToString());
            return n;
        }

    }
}
    
