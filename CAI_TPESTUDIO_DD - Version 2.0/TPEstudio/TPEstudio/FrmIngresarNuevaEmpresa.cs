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
    public partial class FrmIngresarNuevaEmpresa : Form
    {
        private EmpresaNegocio _empresaNegocio;
        public FrmIngresarNuevaEmpresa()
        {
            InitializeComponent();
            _empresaNegocio = new EmpresaNegocio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string razon = _txtRazonSocial.Text;
                long cuit = Convert.ToInt64(_txtCuit.Text);
                string domicilio = _txtDomicilio.Text;
                _empresaNegocio.Alta(razon, cuit, domicilio);
                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puedo agregar la empresa");
            }

        }
        private void Limpiar()
        {
            _txtCuit.Clear();
            _txtDomicilio.Clear();
            _txtRazonSocial.Clear();
        }

        private void FrmIngresarNuevaEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
