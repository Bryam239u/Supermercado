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
    public partial class frmEmpleados : Form
    {
        Data datos = new Data();
        int id = -1;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "nombre as \"Nombre\", " +
                "apellido as \"Apellido\"," +
                "edad as \"Edad\"," +
                "fecha_nac as \"Fecha de Nacimiento\"," +
                "tipo_doc as \"Tipo de Documento\", " +
                "nro_doc as \"Numero de Documento\", " +
                "cuil as \"Cuil\"," +
                "direccion as \"Direccion\"," +
                "nro_tel_princ as \"Numero Telefonico Principal\", " +
                "nro_tel_sec as \"Numero Telefonico Secundario\", " +
                "email as \"Email\", " +
                "cargo as \"Cargo\"," +
                "antiguedad as \"Antiguedad\"," +
                "fecha_ingreso as \"Fecha de Ingreso\"," +
                "salario_anual \"Salario Anual\" FROM empleados order by id");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM empleados WHERE id = " + Id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                txtbNombre.Text = row["nombre"].ToString();
                txtbApellido.Text = row["apellido"].ToString();
                txtbEdad.Text = row["edad"].ToString();
                txtbFecha_nac.Text = row["fecha_nac"].ToString();
                txtbTipo_doc.Text = row["tipo_doc"].ToString();
                txtbNro_doc.Text = row["nro_doc"].ToString();
                txtbCuil.Text = row["cuil"].ToString();
                txtbDireccion.Text = row["direccion"].ToString();
                mtxtbNro_tel_princ.Text = row["nro_tel_princ"].ToString();
                mtxtbNro_tel_sec.Text = row["nro_tel_sec"].ToString();
                txtbEmail.Text = row["email"].ToString();
                txtbCargo.Text = row["cargo"].ToString();
                txtbAntiguedad.Text = row["antiguedad"].ToString();
                txtbFecha_ingreso.Text = row["fecha_ingreso"].ToString();
                txtbSalario_anual.Text = row["salario_anual"].ToString();

                id = Id;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos del empleado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtbNombre.Text = "";
            txtbApellido.Text = "";
            txtbEdad.Text = "";
            txtbFecha_nac.Text = "";
            txtbTipo_doc.Text = "";
            txtbNro_doc.Text = "";
            txtbCuil.Text = "";
            txtbDireccion.Text = "";
            mtxtbNro_tel_princ.Text = "";
            mtxtbNro_tel_sec.Text = "";
            txtbEmail.Text = "";
            txtbCargo.Text = "";
            txtbAntiguedad.Text = "";
            txtbFecha_ingreso.Text = "";
            txtbSalario_anual.Text = "";
            btnAgregar.Text = "Agregar";
            id = -1;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Data datos = new Data();

            if (id == -1)
            {
                string queryInsert = "INSERT INTO empleados " +
                    "(nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, " +
                    "cuil, direccion, nro_tel_princ, nro_tel_sec, email, cargo," +
                    "antiguedad, fecha_ingreso, salario_anual) VALUES (" +
                    "'" + txtbNombre.Text + "', " +
                    "'" + txtbApellido.Text + "', " +
                    txtbEdad.Text + ", " +
                    "'" + txtbFecha_nac.Text + "', " +
                    "'" + txtbTipo_doc.Text + "', " +
                    "'" + txtbNro_doc.Text + "', " +
                    "'" + txtbCuil.Text + "', " +
                    "'" + txtbDireccion.Text + "', " +
                    "'" + mtxtbNro_tel_princ.Text + "', " +
                    "'" + mtxtbNro_tel_sec.Text + "', " +
                    "'" + txtbEmail.Text + "', " +
                    "'" + txtbCargo.Text + "', " +
                    "'" + txtbAntiguedad.Text + "', " +
                    "'" + txtbFecha_ingreso.Text + "', " +
                    txtbSalario_anual.Text + ")";

                resultado = datos.ExecuteQuery(queryInsert);

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
                string queryUpdate = "UPDATE empleados SET " +
                    "nombre = '" + txtbNombre.Text + "', " +
                    "apellido = '" + txtbApellido.Text + "', " +
                    "edad = " + txtbEdad.Text + ", " +
                    "fecha_nac = '" + txtbFecha_nac.Text + "', " +
                    "tipo_doc = '" + txtbTipo_doc.Text + "', " +
                    "nro_doc = '" + txtbNro_doc.Text + "', " +
                    "cuil = '" + txtbCuil.Text + "', " +
                    "direccion = '" + txtbDireccion.Text + "', " +
                    "nro_tel_princ = '" + mtxtbNro_tel_princ.Text + "', " +
                    "nro_tel_sec = '" + mtxtbNro_tel_sec.Text + "', " +
                    "email = '" + txtbEmail.Text + "', " +
                    "cargo = '" + txtbCargo.Text + "', " +
                    "antiguedad = '" + txtbAntiguedad.Text + "', " +
                    "fecha_ingreso = '" + txtbFecha_ingreso.Text + "', " +
                    "salario_anual = " + txtbSalario_anual.Text + " " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryUpdate);

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
            int Id = Convert.ToInt32(dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminarTSM_Click(object sender, EventArgs e)
        {
            string r = dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM empleados WHERE id = " + r);
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
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
               "nombre as \"Nombre\", " +
               "apellido as \"Apellido\"," +
               "edad as \"Edad\"," +
               "fecha_nac as \"Fecha de Nacimiento\"," +
               "tipo_doc as \"Tipo de Documento\", " +
               "nro_doc as \"Numero de Documento\", " +
               "cuil as \"Cuil\"," +
               "direccion as \"Direccion\"," +
               "nro_tel_princ as \"Numero Telefonico Principal\", " +
               "nro_tel_sec as \"Numero Telefonico Secundario\", " +
               "email as \"Email\", " +
               "cargo as \"Cargo\"," +
               "antiguedad as \"Antiguedad\"," +
               "fecha_ingreso as \"Fecha de Ingreso\"," +
               "salario_anual as \"Salario Anual\" FROM empleados " +

               // Cláusula WHERE buscando en todos los campos de texto
               "WHERE nombre like '" + txtBuscar.Text + "%' OR " +
               "apellido like '" + txtBuscar.Text + "%' OR " +
               "tipo_doc like '" + txtBuscar.Text + "%' OR " +
               "nro_doc like '" + txtBuscar.Text + "%' OR " +
               "cuil like '" + txtBuscar.Text + "%' OR " +
               "direccion like '" + txtBuscar.Text + "%' OR " +
               "nro_tel_princ like '" + txtBuscar.Text + "%' OR " +
               "nro_tel_sec like '" + txtBuscar.Text + "%' OR " +
               "email like '" + txtBuscar.Text + "%' OR " +
               "cargo like '" + txtBuscar.Text + "%' OR " +
               "antiguedad like '" + txtBuscar.Text + "%';");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
