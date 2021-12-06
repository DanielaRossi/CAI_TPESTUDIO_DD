using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private string _convenio;
        private double _sueldoBasico;

        public Categoria(string nombre, string convenio, double sueldoBasico)
        {
           
            _nombre = nombre;
            _convenio = convenio;
            _sueldoBasico = sueldoBasico;
        }
        public Categoria() { }


        

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Convenio { get => _convenio; set => _convenio = value; }
        public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }

        public override string ToString()
        {
            return $"{this._id}){this.Convenio}-{this._nombre}-Sueldo Basico{this._sueldoBasico.ToString("0.00")}";

        }
        public string NombreyConvenio
        {
            get
            {
                return $"{this._nombre}-{this._convenio}";
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Categoria))
                return false;
            Categoria categoriaacomparar = (Categoria)obj;
            if (categoriaacomparar._id == this._id)
                return true;
            else
                return false;
        }



    }
}
