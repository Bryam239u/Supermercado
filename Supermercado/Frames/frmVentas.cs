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
    public partial class frmVentas : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            cbEmp.Text = "";
            cbFac.Text = "";

            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM Ventas order by id");
            if (ds != null)
            {
                dgvVentas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int cId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM ventas WHERE id = " + cId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbEmp.SelectedItem = ds.Tables[0].Rows[0]["id_empleado"].ToString();
                cbFac.SelectedItem = ds.Tables[0].Rows[0]["id_factura"].ToString();

                id = cId;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO ventas " +
                    "(id_empleado, id_factura) VALUES (" +
                    "" + cbEmp.Text + "," + cbFac.Text + ")";

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
            else
            {
                string queryup = "UPDATE clientes SET " +
                    "id_empleado = '" + cbEmp.Text + "', " +
                    "id_factura = '" + cbFac.Text + "' " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarTSM_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM Ventas WHERE id = " + r);
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
        //VENTAS PRODUCTOS

        private void limpiarV()
        {
            cbVenta.Text = "";
            cbProducto.Text = "";
            txtbCantidad.Text = "";

            btnAgregar.Text = "Agregar";
            id = -1;
            cbVenta.Enabled = true;
            cbProducto.Enabled = true;
        }

        private void mostrarDatosV()
        {
            DataSet ds = datos.getAllData("SELECT * FROM ventas_productos order by id");
            if (ds != null)
            {
                dgvVenProd.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosV(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM ventas_productos WHERE id = " + Id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbVenta.SelectedItem = ds.Tables[0].Rows[0]["id_venta"].ToString();
                cbProducto.SelectedItem = ds.Tables[0].Rows[0]["id_producto"].ToString();
                txtbCantidad.Text = ds.Tables[0].Rows[0]["cantidad"].ToString();

                id = Id;
                btnAgregar2.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tab.SelectedTab == VentProd)
            {
                mostrarDatosV();
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO ventas_productos " +
                    "(id_venta, id_producto, cantidad) VALUES (" +
                    "" + cbVenta.Text + "," + cbProducto.Text + ", "+txtbCantidad.Text+")";

                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarV();
                    mostrarDatosV();
                }
                else
                {
                    MessageBox.Show("Error al agregar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE ventas_productos SET " +
                    "id_venta = " + cbVenta.Text + ", " +
                    "id_producto = " + cbProducto.Text + ", " +
                    "cantidad = " + txtbCantidad.Text + " " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarV();
                    mostrarDatosV();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvVenProd[0, dgvVenProd.CurrentCell.RowIndex].Value);
            cargarDatosV(Id);
            cbVenta.Enabled = false;
            cbProducto.Enabled = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string r = dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM ventas_productos WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Se elimino el registro con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatosV();
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

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
