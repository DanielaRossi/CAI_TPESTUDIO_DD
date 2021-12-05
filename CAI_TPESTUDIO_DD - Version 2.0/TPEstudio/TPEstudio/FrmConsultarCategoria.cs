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
            _categorias = _categoriaNegocio.TraerTodas();
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = _categorias;
            CargarCombo();
        }
        private void CargarCombo()
        {
            cmbLiquidación.DataSource = null;
            cmbLiquidación.DataSource = _liquidacionesNegocio.TraerTodas();
            cmbLiquidación.DisplayMember = "Id";
            cmbLiquidación.ValueMember = "Id";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidaciones id = (Liquidaciones)cmbLiquidación.SelectedItem;
                _empleados = empleadoNegocio.TraerTodos();


                foreach (Empleado em in _empleados)
                {
                    if (em.Liq == id)
                    {
                        
                        txtResultado.Text = em.IdCategoria.ToString();
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
