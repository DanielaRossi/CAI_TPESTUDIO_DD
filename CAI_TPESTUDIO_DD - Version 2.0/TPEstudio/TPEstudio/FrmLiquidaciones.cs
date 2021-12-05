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
    public partial class FrmLiquidaciones : Form
    {
        private FrmIngresarLiquidacion _frmIngresarLiquidacion;
        private FrmConsultarLiquidaciones frmConsultarLiquidaciones;
        public FrmLiquidaciones(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            _frmIngresarLiquidacion = new FrmIngresarLiquidacion();
            _frmIngresarLiquidacion.Owner = this;
            frmConsultarLiquidaciones = new FrmConsultarLiquidaciones(this);
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

        private void _btnIngresarLiquidacion_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _frmIngresarLiquidacion.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void _btnConsultarLiquidacion_Click(object sender, EventArgs e)
        {try
            {
                this.Hide();
                frmConsultarLiquidaciones.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
