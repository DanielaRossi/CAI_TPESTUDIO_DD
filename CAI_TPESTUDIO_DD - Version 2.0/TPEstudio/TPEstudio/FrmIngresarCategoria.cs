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
    public partial class FrmIngresarCategoria : Form
    {
        private CategoriaNegocio _categoriaNegocio;
        public FrmIngresarCategoria()
        {
            InitializeComponent();
            _categoriaNegocio = new CategoriaNegocio();
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
                string nombre = _txtNombre.Text;
                string convenio = txtConvenio.Text;
                double sueldo = Convert.ToDouble(txtsueldo.Text);

                _categoriaNegocio.Alta(nombre, convenio, sueldo);

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede ingresar la categoria.");
            }
        }
        private void Limpiar()
        {
            _txtNombre.Clear();
            txtConvenio.Clear();
            txtsueldo.Clear();
        }

        private void FrmIngresarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
