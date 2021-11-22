using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstudio.Negocio;

namespace TPEstudio
{
    public partial class FrmIngresarEmpleado : Form
    {

        private EmpleadoServicio _empleadoServicio;
        public FrmIngresarEmpleado()
        {
            InitializeComponent();
            _empleadoServicio = new EmpleadoServicio();
            
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();

        }

        private void FrmIngresarEmpleado_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();
        }

        private void CargarListaEmpleados()
        {
            _empleadoServicio.TraerEmpleados();
        }
    }
}
