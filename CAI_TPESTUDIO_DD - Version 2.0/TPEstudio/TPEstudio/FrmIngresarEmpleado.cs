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
using ConsolaUtils;

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
            try
            {
                this.Hide();
                this.Owner.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            cmbEmpresa.SelectedIndex = 0;
        }
        private void CargarCombos()
        {
            List<Categoria> Categorialst = _categoriaNegocio.TraerTodas();
            Categorialst.Insert(0, new Categoria("--Seleccione-- ","", 0));
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = Categorialst;
            
           
            cmbCategoria.DisplayMember = "NombreyConvenio";
            cmbCategoria.ValueMember = "Id";
            List<Empresa> Empresalst = _empresaNegocio.TraerTodas();
            Empresalst.Insert(0, new Empresa("--Seleccione-- ", 0, ""));

            cmbEmpresa.DataSource = null;
            cmbEmpresa.DataSource = Empresalst;
            cmbEmpresa.DisplayMember = "RazonSocial";
            cmbEmpresa.ValueMember = "Id";
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = _txtNombre.Text;
                string apellido = _txtApellido.Text;
                Validaciones.ValidarVacio(nombre, " Nombre");
                Validaciones.ValidarVacio(apellido, " Apellido");
                long cuil = 0;
                Validaciones.ValidarLong(_txtDni.Text, ref cuil);
                DateTime fechanacimiento = DateTime.Now;
                Validaciones.ValidarFecha(_txtLegajo.Text, ref fechanacimiento);
                Categoria categoria = (Categoria)cmbCategoria.SelectedItem;
                Empresa empresa = (Empresa)cmbEmpresa.SelectedItem;
                

                _empleadoNegocio.Alta(categoria, empresa, cuil, nombre, apellido, fechanacimiento);
                
                MessageBox.Show("El empleado se agregó con exito");
                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
