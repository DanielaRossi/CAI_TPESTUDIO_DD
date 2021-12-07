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
    public partial class FrmConsultarCategoria : Form
    {
        private List<Categoria> _categorias;
        private CategoriaNegocio _categoriaNegocio;
        private LiquidacionesNegocio _liquidacionesNegocio;
        private EmpleadoNegocio empleadoNegocio;
        private List<Empleado> _empleados;
        
        public FrmConsultarCategoria(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _categoriaNegocio = new CategoriaNegocio();
            _liquidacionesNegocio = new LiquidacionesNegocio();
            empleadoNegocio = new EmpleadoNegocio();
        }

        private void button1_Click(object sender, EventArgs e)
        {try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void FrmConsultarCategoria_Load(object sender, EventArgs e)
        {
            
            CargarLista();
            CargarCombo();
        }
        private void CargarCombo()
        {
            
            cmbLiquidación.DataSource = null;
            cmbLiquidación.DataSource = _liquidacionesNegocio.TraerTodas();
            //cmbLiquidación.DisplayMember = "Mostrar";
            cmbLiquidación.DisplayMember = "Detalledeliquidacion";
            cmbLiquidación.ValueMember = "Id";
            
        }
        private void CargarLista()
        {
            _categorias = _categoriaNegocio.TraerTodas();
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = _categorias;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidaciones l = (Liquidaciones)cmbLiquidación.SelectedItem;
                //_empleados = empleadoNegocio.TraerTodos();
                List<Liquidaciones> lst=_liquidacionesNegocio.TraerTodas();


                foreach (Liquidaciones liq in lst)
                {
                    if (liq.Empleados.Categorias.Id.Equals(l.Empleados.Categorias.Id))
                    {
                        
                        txtResultado.Text = liq.Empleados.Categorias.NombreyConvenio.ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
