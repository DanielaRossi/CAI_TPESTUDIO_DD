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
    public partial class FrmIngresarNuevaEmpresa : Form
    {
        private EmpresaServicio _empresaServicio;
        private List<Empresa> _empresas;
        public FrmIngresarNuevaEmpresa()
        {
            InitializeComponent();
            _empresaServicio = new EmpresaServicio(); 
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

        private void ListaEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngresarNuevaEmpresa_Load(object sender, EventArgs e)
        {
            CargarListaEmpresas();
        }

        private void CargarListaEmpresas()
        {
            _lstEmpresas.DataSource = _empresaServicio.GetEmpresas();
        }
    }
}
