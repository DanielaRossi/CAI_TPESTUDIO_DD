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
        private CategoriaServicio _categoriaServicio;
        public FrmIngresarCategoria()
        {
            InitializeComponent();
            _categoriaServicio = new CategoriaServicio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngresarCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            _lstCategorias.DataSource = _categoriaServicio.GetCategorias();
            
        }
    }
}
