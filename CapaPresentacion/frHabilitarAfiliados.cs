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
    public partial class frHabilitarAfiliados : Form
    {
        CLBase objLogica = new CLBase();
        CEAfiliados objAfiliado = new CEAfiliados();
        public frHabilitarAfiliados()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frHabilitarAfiliados_Load(object sender, EventArgs e)
        {
            PopularDGV();
        }

        private void dgvAfiliadosInactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //el objeto dgvcell va a ser nulo cuando el valor de la columna en la que se haya hecho click no sea de tipo dgvlc
            DataGridViewLinkCell objdgvlcell = (DataGridViewLinkCell)dgvAfiliadosInactivos.Rows[e.RowIndex].Cells[e.ColumnIndex];


            if (objdgvlcell.Value.ToString() == "Habilitar")
            {
              objAfiliado.idAfiliado = int.Parse(dgvAfiliadosInactivos.Rows[e.RowIndex].Cells[1].Value.ToString());
              objLogica.HabilitarAfiliado(objAfiliado);
              MessageBox.Show($"Afiliado nro {dgvAfiliadosInactivos.Rows[e.RowIndex].Cells[1].Value} habilitado con éxito");
            }
            PopularDGV();
          
        }

        private void PopularDGV()
        {
            dgvAfiliadosInactivos.DataSource = objLogica.TraerAfiliadosInactivos().Tables["tablaAfiliados"];
        }
    }
}
