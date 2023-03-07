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
            dgvAfiliadosInactivos.DataSource = objLogica.TraerAfiliadosInactivos().Tables["tablaAfiliados"];

        }
    }
}
