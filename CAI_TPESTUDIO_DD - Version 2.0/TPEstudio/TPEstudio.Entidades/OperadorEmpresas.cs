using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class OperadorEmpresas
    {
        public List<Empresa> _empresas;
        private int _cantidadempresas;
        public OperadorEmpresas(List<Empresa>lst)
        {
            this._empresas = lst;
        }
        public List<Empresa> Empresas
        {
            get
            {
                return _empresas;
            }
        }
        public int Cantidad
        {
            get
            {
                if (_empresas != null)
                {
                    return _empresas.Count;
                }
                else
                {
                    return 0;
                }
                
            }
        }
    }
}
