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

namespace CapaPresentacion
{
    
    public partial class frAgregarPlanesAdicionales : Form
    {
        CEAfiliados objAfiliado = new CEAfiliados();
        CLBase objLogica = new CLBase();
        public frAgregarPlanesAdicionales()
        {
            InitializeComponent();
        }

        private void frAgregarPlanesAdicionales_Load(object sender, EventArgs e)
        {
            LoadPlanes();


        }
        public void LoadContact(CEAfiliados paramAfiliado)
        {
            objAfiliado = paramAfiliado;
           
            LimpiarCampos();
            lblNroAfiliado.Text = paramAfiliado.idAfiliado.ToString();
            txtNombre.Text = paramAfiliado.nombre;
            txtApellido.Text = paramAfiliado.apellido;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            lblNroAfiliado.Text = "";
        }

        public void LoadPlanes()
        {
            objLogica.TraerPLanes();
            cbPlan.DataSource = objLogica.TraerPLanes(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarPlanPrincipal(AfiliadoASumar())&&ValidarPlanAdicional(AfiliadoASumar()))
            {
                //objLogica.AgregarPlanAlAfiliado(AfiliadoASumar());
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!!!!");
                LimpiarCampos();
            }
        }

        private bool ValidarPlanPrincipal(CEAfiliados paramAfiliado)
        {
           return objLogica.ValidarPlanPrincipal(paramAfiliado);
        }
            
        private bool ValidarPlanAdicional(CEAfiliados paramAfiliado)
        {
            return objLogica.ValidarPlanAdicional(paramAfiliado);
        }

        private CEAfiliados AfiliadoASumar()
        {
            CEAfiliados objAfiliado = new CEAfiliados();
            objAfiliado.idAfiliado = int.Parse(lblNroAfiliado.Text);
            objAfiliado.idPLan= objLogica.TraerPlanAFiliado(cbPlan.Text);
            return objAfiliado;
        }
    }
}
