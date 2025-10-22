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
    public partial class frmClientes : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM clientes order by id");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
