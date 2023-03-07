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
    public partial class frBajaAfiliado : Form
    {
        CEAfiliados objAfiliado = new CEAfiliados();
        CLBase objLogica = new CLBase();
        public frBajaAfiliado()
        {
            InitializeComponent();
        }

     
        public void CargarBaja()
        {
            objAfiliado.idAfiliado = int.Parse(lblNroAfiliado.Text);
            objAfiliado.fBaja = dtpBaja.Value;
        }

        public void EnviarBaja(CEAfiliados paramAfiliado)
        {
            objLogica.BajaAfiliado(paramAfiliado);
        }

        private void frBajaAfiliado_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadContact(CEAfiliados paramAfiliado)
        {
            objAfiliado = paramAfiliado;
           
            lblNroAfiliado.Text = paramAfiliado.idAfiliado.ToString();
            txtNombre.Text = paramAfiliado.nombre;
            txtApellido.Text = paramAfiliado.apellido;
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objAfiliado.idAfiliado = int.Parse(lblNroAfiliado.Text);
            objAfiliado.fBaja= dtpBaja.Value;

            objLogica.BajaAfiliado(objAfiliado);

            MessageBox.Show("baja realizada con éxito");
        }
    }
}
