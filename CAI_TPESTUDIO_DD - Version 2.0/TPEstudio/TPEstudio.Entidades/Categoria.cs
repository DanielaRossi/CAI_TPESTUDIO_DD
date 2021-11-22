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

        public Categoria(int id, string nombre, string convenio, double sueldoBasico)
        {
            _id = id;
            _nombre = nombre;
            _convenio = convenio;
            _sueldoBasico = sueldoBasico;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Convenio { get => _convenio; set => _convenio = value; }
        public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }

        public override string ToString()
        {
            return this._id.ToString() + this._nombre + this._convenio + this._sueldoBasico.ToString();
        }
    }
}
