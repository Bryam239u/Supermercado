using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Supermercado.Clases
{
    internal class Data
    {
        private string connectionString = "Host=localhost;Port=5432;Username=admin;Password=bryam;Database=Supermercado";

        public NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al" + "conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión exitosa a la base de datos.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error al conectar a la base de datos.");
                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al probar la conexión: " + ex.Message);
                return false;
            }

        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                NpgsqlCommand conn = new NpgsqlCommand(query, GetConnection());
                conn.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataSet getAllData(string command)
        {
            DataSet dataSet = new DataSet();
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command, GetConnection());
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al obtener los datos: " + Ex.Message);
                return null;
            }
        }

        public String GetValue(string query)
        {
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(query, GetConnection());
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor: " + ex.Message);
                return null;
            }
        }
    }
}
