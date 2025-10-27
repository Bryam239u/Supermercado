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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    MessageBox.Show("Registro agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //FACTURAS DETALLES

        private void limpiarF()
        {
            cbIdF.Text = "";
            cbTipo.Text = "";
            txtbDescF.Text = "";
            txtbCosto.Text = "";
            cbMetodoP.Text = "";
            txtbDescPago.Text = "";
            txtbIva.Text = "";
            btnAgregar2.Text = "Agregar";
            id = -1;
            cbIdF.Enabled = true;
        }

        private void mostrarDatosF()
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas_detalles order by id");
            if (ds != null)
            {
                dgvFacDet.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosF(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas_detalles WHERE id = " + Id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbIdF.Text = ds.Tables[0].Rows[0]["id_factura"].ToString();
                cbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                txtbDescF.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
                txtbCosto.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
                txtbIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
                cbMetodoP.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
                txtbDescPago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();

                id = Id;
                btnAgregar2.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar la factura.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            mostrarDatosF();
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab.SelectedTab == FacDet)
            {
                mostrarDatosF();
                String res = datos.GetValue("SELECT COUNT(*) FROM facturas");
                int n = int.Parse(res);
                for (int i = 1; i <= n; i++)
                {
                    cbIdF.Items.Add(i.ToString());
                }
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO facturas_detalles " +
                    "(id_factura, tipo, descr_factura, costo_asoc, iva, medio_de_pago, descr_pago) VALUES (" +
                    "" + cbIdF.Text + "," +                          
                    "'" + cbTipo.Text + "'," +                        
                    "'" + txtbDescF.Text + "'," +                      
                    "" + txtbCosto.Text + "," +       
                    "" + txtbIva.Text + "," +         
                    "'" + cbMetodoP.Text + "'," +                      
                    "'" + txtbDescPago.Text + "')";                   

                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarF();
                    mostrarDatosF();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE facturas_detalles SET " +
                    "id_factura = " + cbIdF.Text + ", " +              
                    "tipo = '" + cbTipo.Text + "', " +                 
                    "descr_factura = '" + txtbDescF.Text + "', " +     
                    "costo_asoc = " + txtbCosto.Text + ", " + 
                    "iva = " + txtbIva.Text + ", " +         
                    "medio_de_pago = '" + cbMetodoP.Text + "', " +     
                    "descr_pago = '" + txtbDescPago.Text + "' " +   
                    "WHERE id = " + id; 

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarF();
                    mostrarDatosF();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvFacDet[0, dgvFacDet.CurrentCell.RowIndex].Value);
            cargarDatosF(Id);
            cbIdF.Enabled = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM facturas_detalles WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatosF();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM facturas_detalles Where " +
            "descr_factura like '" + txtBuscar2.Text + "%' OR " +
            "descr_pago like '" + txtBuscar2.Text + "%';");
            if (ds != null)
            {
                dgvFacDet.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
