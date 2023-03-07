using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frPrincipal : Form
    {
        CLBase objLogicaBase = new CLBase();

        public frPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void agregarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAgregarAFiliado objfrAgregarAFiliado = new frAgregarAFiliado();
            objfrAgregarAFiliado.MdiParent=this;
            objfrAgregarAFiliado.StartPosition = FormStartPosition.CenterScreen;
            objfrAgregarAFiliado.Show();

        }

        private void modificarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frModificarAfiliado objfrmodificarafiliado = new frModificarAfiliado();
            objfrmodificarafiliado.MdiParent = this;
            objfrmodificarafiliado.StartPosition = FormStartPosition.CenterScreen;
            objfrmodificarafiliado.Show();
        }

        private void darDeBajaAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void habilitarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frHabilitarAfiliados objfrHabilitar = new frHabilitarAfiliados();
            objfrHabilitar.MdiParent = this;
            objfrHabilitar.StartPosition = FormStartPosition.CenterScreen;
            objfrHabilitar.Show();
        }
    }
}
