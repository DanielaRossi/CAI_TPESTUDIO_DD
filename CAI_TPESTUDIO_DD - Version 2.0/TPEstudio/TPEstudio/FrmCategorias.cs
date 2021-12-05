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
    public partial class FrmCategorias : Form
    {

        private FrmIngresarCategoria _frmIngresarCategoria;
        private FrmConsultarCategoria frmConsultarCategoria;
        public FrmCategorias(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            _frmIngresarCategoria = new FrmIngresarCategoria();
            _frmIngresarCategoria.Owner = this;
            frmConsultarCategoria = new FrmConsultarCategoria(this);

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void _btnIngresarCategoria_Click(object sender, EventArgs e)
        {try
            {
                this.Hide();
                _frmIngresarCategoria.Show();
            }
            catch (Exception ex) { MessageBox.Show("No se puede ingresar una nueva categoría por el momento."); } 
        }

        private void _btnConsultarCategoria_Click(object sender, EventArgs e)
        {try
            {
                this.Hide();
                frmConsultarCategoria.Show();
            }
            catch (Exception ex) { MessageBox.Show("No se puede consultar las categorías por el momento."); } 
        }
    }
}
