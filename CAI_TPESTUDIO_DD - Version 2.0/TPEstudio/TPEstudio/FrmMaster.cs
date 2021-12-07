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
    public partial class FrmMaster : Form
    {
        private FrmEmpresas _frmEmpresas;
        private FrmEmpleados _frmEmpleados;
        private FrmCategorias _frmCategorias;
        private FrmLiquidaciones _frmLiquidaciones;
        public FrmMaster()
        {
            InitializeComponent();
            _frmEmpresas = new FrmEmpresas(this);
            _frmEmpleados = new FrmEmpleados(this);
            _frmCategorias = new FrmCategorias(this);
            _frmLiquidaciones = new FrmLiquidaciones(this);
            
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _frmLiquidaciones.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                _frmEmpresas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Hide();
                _frmEmpleados.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Hide();
                _frmCategorias.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
