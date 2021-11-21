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

namespace TPEstudio
{
    public partial class FrmIngresarNuevaEmpresa : Form
    {

        private List<Empresa> _empresas;
        public FrmIngresarNuevaEmpresa()
        {
            InitializeComponent();
            
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
                Validaciones();
        //Para mejorar         Empresa empresa = new Empresa(Convert.ToInt32(this._txtId), this._txtRazonSocial, Convert.ToInt32(this._txtCuit), this._txtDomicilio, DateTime.UtcNow("DD-MM_YYYY");

            }catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar la empresa");
            }

        }

        private void Validaciones()
        {
            throw new NotImplementedException();
        }
    }
}
