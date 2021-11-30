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
    public partial class FrmConsultarEmpleados : Form
    {
        private EmpleadoNegocio _empleadoNegocio;
        private List<Empleado> _empleados;
        public FrmConsultarEmpleados(Form propietario)
        {
            InitializeComponent();
            _empleadoNegocio = new EmpleadoNegocio();
            this.Owner = propietario;
        }

        private void FrmConsultarEmpleados_Load(object sender, EventArgs e)
        {
            CargarLista();

        }
        private void CargarLista()
        {
            lstEmpleados.DataSource = null;
            lstEmpleados.DataSource = _empleadoNegocio.TraerTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
