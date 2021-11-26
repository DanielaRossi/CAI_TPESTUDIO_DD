using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstudio.Entidades;
using TPEstudio.Negocio;

namespace TPEstudio
{
    public partial class FrmIngresarEmpleado : Form
    {
        private EmpleadoNegocio _empleadoNegocio;
        private CategoriaNegocio _categoriaNegocio;
        private EmpresaNegocio _empresaNegocio;
        
        public FrmIngresarEmpleado()
        {
            InitializeComponent();
            _empleadoNegocio = new EmpleadoNegocio();
            _categoriaNegocio = new CategoriaNegocio();
            _empresaNegocio = new EmpresaNegocio();

            
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();

        }

        private void FrmIngresarEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        public void Limpiar()
        {
            _txtApellido.Clear();
            _txtNombre.Clear();
            _txtLegajo.Clear();
            _txtDni.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbEmpresa.SelectedItem = 0;
        }
        private void CargarCombos()
        {
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = _categoriaNegocio.TraerTodas();
            cmbEmpresa.DataSource = null;
            cmbEmpresa.DataSource = _empresaNegocio.TraerTodas();
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = _txtNombre.Text;
                string apellido = _txtApellido.Text;
                int cuit = 0;
                Validaciones.ValidarInt(_txtDni.Text, ref cuit);
                DateTime fechanacimiento = DateTime.Now;
                Validaciones.ValidarFecha(_txtLegajo.Text, ref fechanacimiento);
                Categoria categoria = (Categoria)cmbCategoria.SelectedItem;
                Empresa empresa = (Empresa)cmbEmpresa.SelectedItem;

                _empleadoNegocio.Alta(categoria, empresa, Convert.ToInt64(cuit), nombre, apellido, fechanacimiento);
                Limpiar();
                MessageBox.Show("El empleado se agregó con exito");

            }
            catch(Exception ex)
            {

            }
        }
    }
}
