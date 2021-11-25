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
    public class EmpresaMapper
    {
        public List<Empresa> Traer()
        {
            string json = WebHelper.Get("Empresa/880671");
            List < Empresa > lst = MapList(json);
            return lst;
        }
        public List<Empresa> MapList(string json)
        {
            List<Empresa> lst = JsonConvert.DeserializeObject<List<Empresa>>(json);
            return lst;
        }

        public TransactionResult Insertar(Empresa empresa)
        {
            NameValueCollection obj = ReverseMap(empresa);
            string json = WebHelper.Post("empresa", obj);
                TransactionResult lst= JsonConvert.DeserializeObject<TransactionResult>(json);
                
            return lst;
        }
        public NameValueCollection ReverseMap(Empresa empresa)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("razonSocial", empresa.RazonSocial);
            n.Add("cuit", empresa.Cuit.ToString());
            n.Add("domicilio", empresa.Domicilio);
                n.Add("fechaAlta", DateTime.Now.ToString());
            n.Add("usuario", "880671");
            return n;

        }
       
    }
}
