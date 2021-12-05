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
    public partial class FrmEmpresas : Form
    {

        private FrmIngresarNuevaEmpresa _frmIngresarNuevaEmpresa;
        private FrmConsultarEmpresa _frmConsultarEmpresa;

        public FrmEmpresas(Form propietario)
        {
            this.Owner= propietario;
            InitializeComponent();
            _frmIngresarNuevaEmpresa = new FrmIngresarNuevaEmpresa();
            _frmIngresarNuevaEmpresa.Owner = this;
            _frmConsultarEmpresa = new FrmConsultarEmpresa(this);
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void _btnIngresarEmpresa_Click(object sender, EventArgs e)
        {try
            {
                this.Hide();
                _frmIngresarNuevaEmpresa.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void _btnConsultarEmpresas_Click(object sender, EventArgs e)
        {try
            {
                _frmConsultarEmpresa.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
