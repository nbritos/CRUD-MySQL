using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CapaPresentacion
{
    public partial class AfiliadoDetails : Form
    {
        CEAfiliados objAfiliado = new CEAfiliados();
        CLBase objLogica = new CLBase();
        public AfiliadoDetails()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void LoadContact(CEAfiliados paramAfiliado)
        {
            objAfiliado = paramAfiliado;
            if (paramAfiliado!=null)
            {
                LimpiarCampos();
                lblNroAfiliado.Text = paramAfiliado.idAfiliado.ToString();
                txtNombre.Text = paramAfiliado.nombre;
                txtApellido.Text = paramAfiliado.apellido;
                txtObservaciones.Text = paramAfiliado.observaciones;
            }
        }

        private void TraerPlanes()
        {
            objLogica.TraerPLanes();
            cbPlan.DataSource = objLogica.TraerPLanes();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            cbPlan.SelectedItem = null;
        }

        private void AfiliadoDetails_Load(object sender, EventArgs e)
        {
            TraerPlanes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                objLogica.Update(UpdatearAfiliado());
                MessageBox.Show("Afiliado actualizado con exito", "Vamos los pibes");
                LimpiarCampos();
            
        }

        private CEAfiliados UpdatearAfiliado()
        {
            CEAfiliados objAfiliado = new CEAfiliados();
            objAfiliado.idAfiliado = int.Parse(lblNroAfiliado.Text);
            objAfiliado.nombre = txtNombre.Text;
            objAfiliado.apellido = txtApellido.Text;
            objAfiliado.idPLan = objLogica.TraerPlanAFiliado(cbPlan.Text);
            objAfiliado.observaciones = txtObservaciones.Text;

            return objAfiliado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frBajaAfiliado objfrBajaAfiliado = new frBajaAfiliado();
            objAfiliado.idAfiliado = int.Parse(lblNroAfiliado.Text);
            objAfiliado.nombre = txtNombre.Text;
            objAfiliado.apellido= txtApellido.Text;
            if (ValidarFBaja())
            {
                objfrBajaAfiliado.LoadContact(objAfiliado);
                objfrBajaAfiliado.StartPosition = FormStartPosition.CenterScreen;
                objfrBajaAfiliado.ShowDialog();

            }
        }

        private bool ValidarFBaja()
        {
            return true;
        }
    }
}
