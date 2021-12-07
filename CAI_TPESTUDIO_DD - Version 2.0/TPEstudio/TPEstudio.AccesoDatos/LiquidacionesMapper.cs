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
    public class LiquidacionesMapper
    {
        public List<Liquidaciones> Traer()
        {
            string json = WebHelper.Get("/EstudioContable/Liquidaciones");
            List<Liquidaciones> lst = MapList(json);
            return lst;
        }
        public List<Liquidaciones> MapList(string json)
        {
            List<Liquidaciones> lst = JsonConvert.DeserializeObject<List<Liquidaciones>>(json);
            return lst;
        }
        


        public TransactionResult Insertar(Liquidaciones liquidaciones)
        {
            NameValueCollection obj = ReverseMap(liquidaciones);
            string json = WebHelper.Post("/EstudioContable/Liquidacion", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        public NameValueCollection ReverseMap(Liquidaciones liquidaciones)
        {
            NameValueCollection nv = new NameValueCollection();
            nv.Add("idEmpleado", liquidaciones.IdEmpleado.ToString());
            nv.Add("periodo", liquidaciones.Periodo.ToString());
            nv.Add("codigotransferencia", liquidaciones.CodigoTransferencia.ToString());
            nv.Add("bruto", liquidaciones.Bruto.ToString());
            nv.Add("descuentos", liquidaciones.Descuentos.ToString());
            nv.Add("fechaAlta", DateTime.Now.ToString());
            nv.Add("usuario", "880671");
            nv.Add("id", liquidaciones.Id.ToString());
            return nv;

        }
    }
}
