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
    public partial class frmCompras : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmCompras()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            cbVenta.Text = "";
            cbCliente.Text = "";

            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM compras_clientes order by id");
            if (ds != null)
            {
                dgvCompras.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int cId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM compras_clientes WHERE id = " + cId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbVenta.SelectedItem = ds.Tables[0].Rows[0]["id_venta"].ToString();
                cbCliente.SelectedItem = ds.Tables[0].Rows[0]["id_cliente"].ToString();

                id = cId;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            String res = datos.GetValue("SELECT COUNT(*) FROM ventas");
            int n = int.Parse(res);
            for (int i = 1; i <= n; i++)
            {
                cbVenta.Items.Add(i.ToString());
            }
            String res1 = datos.GetValue("SELECT COUNT(*) FROM clientes");
            int n1 = int.Parse(res1);
            for (int i = 1; i <= n1; i++)
            {
                cbCliente.Items.Add(i.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO compras_clientes " +
                    "(id_venta, id_cliente) VALUES (" +
                    "" + cbVenta.Text + "," + cbCliente.Text + ")";

                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al agregar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM compras_clientes WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Se elimino el registro con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Close();
        }
    }
}
