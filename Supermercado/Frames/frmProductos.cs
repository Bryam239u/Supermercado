using ImageMagick;
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
    public partial class frmProductos : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos order by id");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int cId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos WHERE id = " + cId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtbImg.Text = ds.Tables[0].Rows[0]["imagen"].ToString();
                txtbMarca.Text = ds.Tables[0].Rows[0]["marca"].ToString();
                txtbGrupo.Text = ds.Tables[0].Rows[0]["grupo"].ToString();
                txtbPeso.Text = ds.Tables[0].Rows[0]["peso"].ToString();
                txtbPrecio_U.Text = ds.Tables[0].Rows[0]["precio_unidad"].ToString();
                txtbStock.Text = ds.Tables[0].Rows[0]["stock"].ToString();
                txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                comboBox1.SelectedItem = ds.Tables[0].Rows[0]["id_proveedor"].ToString();

                id = cId;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtbNombre.Text = "";
            txtbCodigo.Text = "";
            txtbImg.Text = "";
            txtbMarca.Text = "";
            txtbGrupo.Text = "";
            txtbPeso.Text = "";
            txtbPrecio_U.Text = "";
            txtbStock.Text = "";
            txtbTipo.Text = "";
            comboBox1.Text = "";

            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            String res = datos.GetValue("SELECT COUNT(*) FROM proveedores");
            int n = int.Parse(res);
            for(int i = 1; i <= n; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO productos " +
                    "(id_proveedor, codigo, imagen, nombre, marca, tipo, grupo, peso, precio_unidad, stock) VALUES (" +
                    "" + comboBox1.Text + "," +          
                    "'" + txtbCodigo.Text + "'," +
                    "'" + txtbImg.Text + "'," +     
                    "'" + txtbNombre.Text + "'," +
                    "'" + txtbMarca.Text + "'," +
                    "'" + txtbTipo.Text + "'," +
                    "'" + txtbGrupo.Text + "'," +
                    "" + txtbPeso.Text+ "," +     
                    "" + txtbPrecio_U.Text+ "," +
                    "" + txtbStock.Text + ")";    

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
                string queryup = "UPDATE productos SET " +
                    "id_proveedor = " + comboBox1.Text + ", " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "imagen = '" + txtbImg.Text + "', " +      
                    "nombre = '" + txtbNombre.Text + "', " +
                    "marca = '" + txtbMarca.Text + "', " +
                    "tipo = '" + txtbTipo.Text + "', " +
                    "grupo = '" + txtbGrupo.Text + "', " +
                    "peso = " + txtbPeso.Text + ", " +       
                    "precio_unidad = " + txtbPrecio_U.Text+ ", " +
                    "stock = " + txtbStock.Text + " " +         
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
            int Id = Convert.ToInt32(dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
            Data datos = new Data();
            String img = datos.GetValue("SELECT imagen FROM productos WHERE id =" +Id);
            using (var image = new MagickImage(img))
            {
                using (var ms = new System.IO.MemoryStream(image.ToByteArray(MagickFormat.Bmp)))
                {
                    pbImg.Image = new Bitmap(ms);
                }
            }
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM productos WHERE id = " + r);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos Where " +
            "codigo like '" + txtBuscar.Text + "%' OR " +
            "imagen like '" + txtBuscar.Text + "%' OR " +
            "nombre like '" + txtBuscar.Text + "%' OR " +
            "marca like '" + txtBuscar.Text + "%' OR " +
            "tipo like '" + txtBuscar.Text + "%' OR " +
            "grupo like '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
