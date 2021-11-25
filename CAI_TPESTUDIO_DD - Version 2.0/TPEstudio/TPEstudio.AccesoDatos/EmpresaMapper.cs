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
            string json = WebHelper.Get("/EstudioContable/Empresas/880671");
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
            string json = WebHelper.Post("/EstudioContable/Empresa", obj);
            TransactionResult lst= JsonConvert.DeserializeObject<TransactionResult>(json);
                
            return lst;
        }
        public NameValueCollection ReverseMap(Empresa empresa)
        {
            NameValueCollection nv = new NameValueCollection();
            nv.Add("razonSocial", empresa.RazonSocial);
            nv.Add("cuit", empresa.Cuit.ToString());
            nv.Add("domicilio", empresa.Domicilio);
            nv.Add("id", empresa.Id.ToString());
            nv.Add("fechaAlta", DateTime.Now.ToString());
            nv.Add("usuario", "880671");
            return nv;

        }
       
    }
}
