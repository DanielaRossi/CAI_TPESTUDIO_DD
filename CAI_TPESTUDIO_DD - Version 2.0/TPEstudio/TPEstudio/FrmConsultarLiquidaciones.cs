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
            //lstLiquidaciones.DisplayMember = "Mostrar";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidaciones liquidacion = (Liquidaciones)cmbLiquidacion.SelectedItem;


                Liquidaciones l = liquidacionesNegocio.Traerporidliquidacion(liquidacion.Id);

                txtResultado.Text = l.Mostrar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)cmbCategoria.SelectedItem;
            List<Liquidaciones> lst = liquidacionesNegocio.Traerliquidacionesporcategoria(categoria.Id);
            lstLiquidacionporcategoria.DataSource = null;
            lstLiquidacionporcategoria.DataSource = lst;
        }
    }
}
