using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstudio
{
    public partial class FrmEmpleados : Form
    {

        private FrmIngresarEmpleado _frmIngresarEmpleado;
        public FrmEmpleados(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _frmIngresarEmpleado = new FrmIngresarEmpleado();
            _frmIngresarEmpleado.Owner = this;
            
            
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void _btnIngresarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmIngresarEmpleado.Show();
        }
    }
}
