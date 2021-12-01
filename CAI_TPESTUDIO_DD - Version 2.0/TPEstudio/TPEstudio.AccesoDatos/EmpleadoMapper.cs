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
    public class EmpleadoMapper
    {
        public List<Empleado> Traer()
        {
            string json = WebHelper.Get("/EstudioContable/Empleados");
            List<Empleado> lst = MapList(json);
            return lst;
        }
        public List<Empleado> MapList(string json)
        {
            List<Empleado>lst= JsonConvert.DeserializeObject<List<Empleado>>(json);
            return lst;
        }
        public Empleado Traerporid(int idEmpleado)
        {
            string json2 = WebHelper.Get("/EstudioContable/Empleados/" + idEmpleado.ToString()); 
            Empleado resultado = MapListporid(json2);
            return resultado;
        }

        public Empleado MapListporid(string json)
        {
            Empleado empleado = JsonConvert.DeserializeObject<Empleado>(json);
            return empleado;
        }
        public TransactionResult Insertar(Empleado empleado)
        {
            NameValueCollection obj = ReverseMap(empleado);
            string json = WebHelper.Post("/EstudioContable/Empleado", obj);
             TransactionResult result =JsonConvert.DeserializeObject<TransactionResult>(json);
            return result;

        }
        public NameValueCollection ReverseMap( Empleado empleado)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCategoria", empleado.IdCategoria.ToString());
            n.Add("idEmpresa", empleado.IdEmpresa.ToString());
            n.Add("cuil", empleado.Cuil.ToString());
            n.Add("Nombre", empleado.Nombre);
            n.Add("Apellido", empleado.Apellido);
            n.Add("FechaNacimiento", empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("FechaAlta", DateTime.Now.ToString("yyyy-MM-dd"));
            n.Add("id", empleado.Id.ToString());
            n.Add("usuario", "880671");
            return n;


        }
    }
}

