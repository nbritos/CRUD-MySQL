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
    public partial class frPlanesAdicionales : Form
    {
        CLBase objLogica = new CLBase();
        CEAfiliados objAfiliado = new CEAfiliados();
        frAgregarPlanesAdicionales objfragregarPlanes = new frAgregarPlanesAdicionales();
        public frPlanesAdicionales()
        {
            InitializeComponent();
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                PopulatePorApellido();
                dgvParaPlanes.Update();
                dgvParaPlanes.Refresh();
            }
            else
            {
                MessageBox.Show("error en alguno de los campos");
            }
        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void PopulatePorApellido()
        {
            objAfiliado.apellido = txtApellido.Text;
            dgvParaPlanes.DataSource = objLogica.BuscarPorApellido(objAfiliado).Tables["tablaAfiliados"];
        }

        private void PopulatePorID()
        {
            objAfiliado.idAfiliado = int.Parse(txtID.Text);
            dgvParaPlanes.DataSource=objLogica.BuscarPorID(objAfiliado).Tables["tablaAfiliados"];
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            PopulatePorID();
            dgvParaPlanes.Update();
            dgvParaPlanes.Refresh();
        }

        private void dgvParaPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //el objeto dgvcell va a ser nulo cuando el valor de la columna en la que se haya hecho click no sea de tipo dgvlc
            DataGridViewLinkCell objdgvlcell = (DataGridViewLinkCell)dgvParaPlanes.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //valido si la celda 6 de la columna fbaja es un string vacio
            if (objdgvlcell.Value.ToString() == "Agregar")
            {
                objAfiliado.idAfiliado = int.Parse(dgvParaPlanes.Rows[e.RowIndex].Cells[1].Value.ToString());
                objAfiliado.nombre = dgvParaPlanes.Rows[e.RowIndex].Cells[2].Value.ToString();
                objAfiliado.apellido = dgvParaPlanes.Rows[e.RowIndex].Cells[3].Value.ToString();
                objAfiliado.idPLan = int.Parse(dgvParaPlanes.Rows[e.RowIndex].Cells[4].Value.ToString());
                objAfiliado.observaciones = dgvParaPlanes.Rows[e.RowIndex].Cells[7].Value.ToString();

                objfragregarPlanes.LoadContact(objAfiliado);
                objfragregarPlanes.ShowDialog();

            }
            else
            {
                MessageBox.Show("excep sin handling");
            }
        }
    }
}
