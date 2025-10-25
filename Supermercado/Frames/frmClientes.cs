using ImageMagick.Drawing;
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

        private void limpiar()
        {
            txtbNombre.Text = "";
            txtbApellido.Text = "";
            txtbTipo_doc.Text = "";
            txtbNro_doc.Text = "";
            mtxtbNro_tel_princ.Text = "";
            mtxtbNro_tel_sec.Text = "";
            txtbEmail.Text = "";
            btnAgregar.Text = "Agregar";
            id = -1;
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

        private void cargarDatos(int cId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM clientes WHERE id = " + cId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtbApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtbTipo_doc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
                txtbNro_doc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
                mtxtbNro_tel_princ.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtxtbNro_tel_sec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtbEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                id = cId;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO clientes " +
                    "(nombre, apellido, tipo_doc, nro_doc, nro_tel_princ, nro_tel_sec, email) VALUES (" +
                    "'" + txtbNombre.Text + "'," +
                    "'" + txtbApellido.Text + "'," +
                    "'" + txtbTipo_doc.Text + "'," +
                    "'" + txtbNro_doc.Text + "'," +
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
                string queryup = "UPDATE clientes SET " +
                    "nombre = '" + txtbNombre.Text + "', " +
                    "apellido = '" + txtbApellido.Text + "', " +
                    "tipo_doc = '" + txtbTipo_doc.Text + "', " +
                    "nro_doc = '" + txtbNro_doc.Text + "', " +
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Close();
        }

        private void editarTSM_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM clientes WHERE id = " + r);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM clientes Where nombre like '" + txtBuscar.Text + "%' OR apellido like '" + txtBuscar.Text + "%' OR " +
                "tipo_doc like '" + txtBuscar.Text + "%' OR nro_doc like '" + txtBuscar.Text + "%' OR nro_tel_princ like '" + txtBuscar.Text + "%' OR nro_tel_sec like '" 
                + txtBuscar.Text + "%' OR email like '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
