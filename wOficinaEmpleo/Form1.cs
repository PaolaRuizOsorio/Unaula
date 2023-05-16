using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wOficinaEmpleo
{
    public partial class frmOficinaEmpleo : Form
    {
        public frmOficinaEmpleo()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void buscarEmpleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleo empleo = new frmBuscarEmpleo();
            empleo.MdiParent = this;
            empleo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEmpleado = this.ActiveMdiChild;
            if (frmEmpleado != null)
            {
                frmEmpleado.Close();
            }
            else
            {
                this.Close();
            }

            Form frmBuscarEmpleo = this.ActiveMdiChild;
            if (frmBuscarEmpleo != null)
            {
                frmBuscarEmpleo.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEmpleado = this.ActiveMdiChild;

            if (frmEmpleado != null)
            {
                frmEmpleado.Close();
            }

            Form frmBuscarEmpleo = this.ActiveMdiChild;

            if (frmBuscarEmpleo != null)
            {
                frmBuscarEmpleo.Close();
            }

        }
    }
}


