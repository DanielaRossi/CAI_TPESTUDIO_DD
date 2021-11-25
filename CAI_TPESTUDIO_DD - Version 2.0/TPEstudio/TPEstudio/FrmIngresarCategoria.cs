using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstudio.Entidades.Enums;
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
                ValidacionesIngreso();
                string nombre = _txtNombre.Text;
                ConvenioEnum convenio = (ConvenioEnum)cmbConvenio.SelectedItem;
                double sueldo = Convert.ToDouble(txtsueldo.Text);



                _categoriaNegocio.Alta(nombre, convenio, sueldo);
                MessageBox.Show(" La categoría se agregó con exito.");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ValidacionesIngreso()
        {
            string nombre = _txtNombre.Text;
            ConvenioEnum convenio = (ConvenioEnum)cmbConvenio.SelectedItem;
            string sueldo = txtsueldo.Text;
            double Salidasueldo = 0;

            if ((int)convenio == 0)
            {
                throw new Exception("Seleccione un convenio");
            }
            Validaciones.ValidarVacio(nombre, "Nombre");
            Validaciones.ValidarDouble(sueldo, ref Salidasueldo);
            

        }
        private void Limpiar()
        {
            _txtNombre.Clear();
            cmbConvenio.SelectedIndex = 0;
            txtsueldo.Clear();
        }

        private void FrmIngresarCategoria_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void CargarCombo()
        {
            cmbConvenio.DataSource = Enum.GetValues(typeof(ConvenioEnum));
                
        }
    }
}
