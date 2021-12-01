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
    public partial class FrmConsultarLiquidaciones : Form
    {
        private LiquidacionesNegocio liquidacionesNegocio;
        private CategoriaNegocio categoriaNegocio;
        
        public FrmConsultarLiquidaciones(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            liquidacionesNegocio = new LiquidacionesNegocio();
            categoriaNegocio = new CategoriaNegocio();
        }

        private void FrmConsultarLiquidaciones_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarCombo();

        }
        private void CargarCombo()
        {
            cmbLiquidacion.DataSource = null;
            cmbLiquidacion.DataSource = liquidacionesNegocio.TraerTodas();
            cmbLiquidacion.DisplayMember = "Mostrar";
            cmbLiquidacion.ValueMember = "Id";
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = categoriaNegocio.TraerTodas();
            cmbCategoria.DisplayMember = "NombreyConvenio";
            cmbCategoria.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void CargarLista()
        {
            lstLiquidaciones.DataSource = null;
            lstLiquidaciones.DataSource = liquidacionesNegocio.TraerTodas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idliquidacion = cmbLiquidacion.SelectedIndex;
            
            
            Liquidaciones l= liquidacionesNegocio.Traerporidliquidacion(idliquidacion);
            txtResultado.Text = l.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
