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
        private FrmConsultarEmpleados _frmConsultarEmpleados;
        public FrmEmpleados(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _frmIngresarEmpleado = new FrmIngresarEmpleado();
            _frmIngresarEmpleado.Owner = this;
            
            _frmConsultarEmpleados = new FrmConsultarEmpleados(this);
            _frmConsultarEmpleados.Owner = this;

            
            
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnIngresarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _frmIngresarEmpleado.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void _btnConsultarEmpleado_Click(object sender, EventArgs e)
        {try
            {
                this.Hide();
                _frmConsultarEmpleados.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }
    }
}
