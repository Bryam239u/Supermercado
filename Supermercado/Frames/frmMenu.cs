using Supermercado.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Frames
{
    public partial class frmMenu : Form
    {
        Data datos = new Data();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = datos.TestConnection();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            emp.Show();
            this.Hide();
        }
    }
}
