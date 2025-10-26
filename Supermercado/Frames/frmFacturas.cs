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
    public partial class frmFacturas : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtbNumero.Text = "";
            txtbCodigo.Text = "";
            dtpFecha.Text = "";
            dtpHora.Text = "";
            txtbImporte_total.Text = "";
            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "numero as \"Numero\", " +
                "codigo as \"Codigo\"," +
                "fecha as \"Fecha\", " +
                "hora as \"Hora\", " +
                "importe_total \"Importe Total\" FROM facturas order by id");
            if (ds != null)
            {
                dgvFacturas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas WHERE id = " + Id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNumero.Text = ds.Tables[0].Rows[0]["numero"].ToString();
                txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                dtpFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                dtpHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                txtbImporte_total.Text = ds.Tables[0].Rows[0]["importe_total"].ToString();

                id = Id;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar la factura.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            txtbNumero.Focus();
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO facturas " +
                    "(numero, codigo, fecha, hora, importe_total) VALUES (" +
                    "'" + txtbNumero.Text + "'," +
                    "'" + txtbCodigo.Text + "'," +
                    "'" + dtpFecha.Text + "'," +
                    "'" + dtpHora.Text + "'," +
                    "'" + txtbImporte_total.Text + "')";


                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE facturas SET " +
                    "numero = '" + txtbNumero.Text + "', " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "fecha = '" + dtpFecha.Text + "', " +
                    "hora = '" + dtpHora.Text + "', " +
                    "importe_total = '" + txtbImporte_total.Text + "'" +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int Id = Convert.ToInt32(dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM facturas WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas Where numero like '" + txtBuscar.Text + "%' OR codigo like '" + txtBuscar.Text 
                + "%';");
            if (ds != null)
            {
                dgvFacturas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
