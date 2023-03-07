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
    public partial class frModificarAfiliado : Form
    {
        CLBase objLogica = new CLBase();
        CEAfiliados objAfiliado = new CEAfiliados();
        AfiliadoDetails objFormDetails = new AfiliadoDetails();
        public frModificarAfiliado()
        {
            InitializeComponent();
        }

        private void frModificarAfiliado_Load(object sender, EventArgs e)
        {
           dgvAfiliados.DataSource = objLogica.TraerAfiliados().Tables["tablaAfiliados"];
        }

        private void dgvAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //el objeto dgvcell va a ser nulo cuando el valor de la columna en la que se haya hecho click no sea de tipo dgvlc
           DataGridViewLinkCell objdgvlcell = (DataGridViewLinkCell)dgvAfiliados.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //valido si la celda 6 de la columna fbaja es un string vacio
            if (objdgvlcell.Value.ToString() == "Editar"
                && dgvAfiliados.Rows[e.RowIndex].Cells[6].Value.ToString() == string.Empty)
            {
                objAfiliado.idAfiliado = int.Parse(dgvAfiliados.Rows[e.RowIndex].Cells[1].Value.ToString());
                objAfiliado.nombre = dgvAfiliados.Rows[e.RowIndex].Cells[2].Value.ToString();
                objAfiliado.apellido = dgvAfiliados.Rows[e.RowIndex].Cells[3].Value.ToString();
                objAfiliado.idPLan = int.Parse(dgvAfiliados.Rows[e.RowIndex].Cells[4].Value.ToString());
                objAfiliado.observaciones = dgvAfiliados.Rows[e.RowIndex].Cells[7].Value.ToString();


                objFormDetails.LoadContact(objAfiliado);
                objFormDetails.ShowDialog();

            }
            else
            {
                MessageBox.Show("No se puede modificar un afiliado inactivo");
            }
        }

              
    }
}
