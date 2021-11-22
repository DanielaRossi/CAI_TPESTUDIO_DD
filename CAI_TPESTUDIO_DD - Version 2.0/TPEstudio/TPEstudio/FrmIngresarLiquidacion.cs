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
    public partial class FrmIngresarLiquidacion : Form
    {
        private LiquidacionesServicio _liquidacionesServicio;
        public FrmIngresarLiquidacion()
        {
            InitializeComponent();
            _liquidacionesServicio = new LiquidacionesServicio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void FrmIngresarLiquidacion_Load(object sender, EventArgs e)
        {
            CargarListaLiquidaciones();
        }

        private void CargarListaLiquidaciones()
        {

            _lstLiquidaciones.DataSource = _liquidacionesServicio.GetLiquidaciones();
        }
    }
}
