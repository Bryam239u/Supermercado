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
    public partial class frmProveedores : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtbEmpresas.Text = "";
            txtbTipo_Productos.Text = "";
            txtbDireccion.Text = "";
            mtxtbNro_tel_princ.Text = "";
            mtxtbNro_tel_sec.Text = "";
            txtbEmail.Text = "";
            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM proveedores order by id");
            if (ds != null)
            {
                dgvProveedores.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM proveedores WHERE id = " + Id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbEmpresas.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
                txtbTipo_Productos.Text = ds.Tables[0].Rows[0]["tipo_producto"].ToString();
                txtbDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                mtxtbNro_tel_princ.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtxtbNro_tel_sec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtbEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                id = Id;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO proveedores " +
                    "(empresa, tipo_producto, direccion, nro_tel_princ, nro_tel_sec, email) VALUES (" +
                    "'" + txtbEmpresas.Text + "'," +
                    "'" + txtbTipo_Productos.Text + "'," +
                    "'" + txtbDireccion.Text + "'," +
                    "'" + mtxtbNro_tel_princ.Text + "'," +
                    "'" + mtxtbNro_tel_sec.Text + "'," +
                    "'" + txtbEmail.Text + "')";

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
                string queryup = "UPDATE proveedores SET " +
                    "empresa = '" + txtbEmpresas.Text + "', " +
                    "tipo_producto = '" + txtbTipo_Productos.Text + "', " +
                    "direccion = '" + txtbDireccion.Text + "', " +
                    "nro_tel_princ = '" + mtxtbNro_tel_princ.Text + "', " +
                    "nro_tel_sec = '" + mtxtbNro_tel_sec.Text + "', " +
                    "email = '" + txtbEmail.Text + "' " +
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
            int Id = Convert.ToInt32(dgvProveedores[0, dgvProveedores.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvProveedores[0, dgvProveedores.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM proveedores WHERE id = " + r);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM proveedores Where empresa like '" + txtBuscar.Text + "%' OR tipo_producto like '" + txtBuscar.Text + "%' OR " +
                "direccion like '" + txtBuscar.Text + "%' OR nro_tel_princ like '" + txtBuscar.Text + "%' OR nro_tel_sec like '"
                + txtBuscar.Text + "%' OR email like '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvProveedores.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
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
