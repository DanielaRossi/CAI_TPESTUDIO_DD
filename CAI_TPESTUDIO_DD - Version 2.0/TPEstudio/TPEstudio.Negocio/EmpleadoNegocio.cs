using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEstudio.AccesoDatos;
using TPEstudio.Entidades;

namespace TPEstudio.Negocio
{
    public class EmpleadoNegocio
    {
        private EmpleadoMapper _empleadoMapper;
        private LiquidacionesMapper _liquidacionesMapper;
        private CategoriaMapper _categoriaMapper;
        private List<Empleado> _empleado;
        private List<Liquidaciones> _liquidaciones;
        private List<Categoria> _categorias;
        public EmpleadoNegocio()
        {
            _empleadoMapper = new EmpleadoMapper();
            _liquidacionesMapper = new LiquidacionesMapper();
            _liquidaciones = new List<Liquidaciones>();
            _empleado = new List<Empleado>();
            _categoriaMapper = new CategoriaMapper();
            _categorias = new List<Categoria>();
        }
        public List<Empleado> TraerTodos()
        {
            try
            {
                //_liquidaciones = _liquidacionesMapper.Traer();
                //_empleado = _empleadoMapper.Traer();
                //_categorias = _categoriaMapper.Traer();


                foreach (var empleado in _empleadoMapper.Traer())
                {
                    //    foreach (var liquidaciones in _liquidaciones)
                    //    {
                    //        if (empleado.Id == liquidaciones.IdEmpleado)
                    //            empleado.Liq = liquidaciones;
                    //    }
                    foreach (var categoria in _categoriaMapper.Traer()) 
                {
                    if (empleado.IdCategoria == categoria.Id)
                        empleado.Categorias = categoria;
                }


                }


                return _empleado;
            }
            catch(Exception ex)
            {
                throw new Exception("No se puedo traer a los empleados");
            }
            

            
        }
        public Empleado TraerEmpleadosporId(int idEmpleado)
        {
            try
            {

                return _empleadoMapper.Traerporid(idEmpleado);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo traer a los empleados");
            }



        }
        //public Empleado TraerEmpleadosporEmpresa(int idEmpresa)
        //{
        //    try
        //    {

        //        _empleado = _empleadoMapper.Traer();
        //        Empleado resultado = null;

        //        foreach (var empleado in _empleado)
        //        {

        //            if (empleado.IdEmpresa == idEmpresa)
        //                resultado = empleado;



        //        }


        //        return resultado;


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("No se puedo traer a los empleados");
        //    }



        //}
        public List<Empleado> TraerEmpleadosporempresa(Empresa empresa)
        {
            List<Empleado> _empleadosporempresa = new List<Empleado>();
            foreach (Empleado em in _empleadoMapper.Traer())
            {
                if (em.IdEmpresa.Equals(empresa.Id))
                {
                    _empleadosporempresa.Add(em);
                }

            }
            if (_empleadosporempresa.Count == 0)
            {
                throw new Exception("No hay empleados en la empresa.");
            }
            return _empleadosporempresa;
        }

        public void Alta(Categoria categoria,Empresa empresa, long cuil,string nombre,string apellido, DateTime fechanacimiento)
        {
            if (cuil > 99999999999 || cuil < 11111111111)
            {
                throw new Exception("El cuil del empleado debe tener 11 dígitos.");
            }
            if (categoria.Id == 0)
            {
                throw new Exception("Seleccione una categoría.");
            }
            if (empresa.Id == 0)
            {
                throw new Exception("Seleccione una empresa.");
            }

            Empleado empleado = new Empleado(categoria,empresa.Id, categoria.Id,cuil, nombre, apellido, fechanacimiento);
            
            foreach(Empleado e in _empleadoMapper.Traer())
            {
                if(empleado.Cuil.Equals(e.Cuil)&& empleado.IdEmpresa.Equals(e.IdEmpresa))
                {
                    throw new Exception("El empleado ya está registrado en la empresa.");
                }
            }

            TransactionResult result = _empleadoMapper.Insertar(empleado);
            if(!result.IsOk)
            {
                throw new Exception("No se puede dar de alta el empleado por" + result.Error);

            }
        }
    }
}
