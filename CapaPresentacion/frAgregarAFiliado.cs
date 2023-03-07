using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frAgregarAFiliado : Form
    {
        CLBase objLogica = new CLBase();

        public frAgregarAFiliado()
        {
            InitializeComponent();
        }

        private void frAgregarAFiliado_Load(object sender, EventArgs e)
        {
            objLogica.TraerPLanes();
            cbPlan.DataSource = objLogica.TraerPLanes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                objLogica.Create(CrearAfiliado());
                MessageBox.Show("Afiliado cargado con exito", "Bien ahi guachin");
                LimpiarCampos();
            }
        }


        private CEAfiliados CrearAfiliado()
        {
            CEAfiliados objAfiliado = new CEAfiliados();
            objAfiliado.nombre = txtNombre.Text;
            objAfiliado.apellido = txtApellido.Text;
            objAfiliado.idPLan = objLogica.TraerPlanAFiliado(cbPlan.Text);
            objAfiliado.fAlta = dtp.Value;
            objAfiliado.observaciones = txtObservaciones.Text;

            return objAfiliado;
        }

        private bool ValidarDatos()
        {
            bool resultado = true;
            if (txtNombre.Text==string.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            else if (txtApellido.Text == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }
            return resultado;
        }
        public void LimpiarCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
