using CrystalDecisions.CrystalReports.Engine;
using Npgsql;
using Supermercado;
using Supermercado.Frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalAdd
{
    public class GenerarReporte
    {
        private string connectionString = "Host=localhost;Port=5432;Username=admin;Password=bryam;Database=Supermercado";

        public ReportDocument CrearReporte()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string Query = @"SELECT
                        c.id AS id,
                        c.nombre AS nombre,
                        c.apellido AS apellido,
                        p.id AS id_producto,
                        p.nombre AS nombre_producto,
                        p.marca,
                        vp.cantidad
                        FROM clientes c
                        INNER JOIN compras_clientes cc ON c.id = cc.id_cliente
                        INNER JOIN ventas v ON cc.id_venta = v.id
                        INNER JOIN ventas_productos vp ON v.id = vp.id_venta
                        INNER JOIN productos p ON vp.id_producto = p.id;";

                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(Query, connection);

                    DataSet ds = new DataSet1();
                    dataAdapter.Fill(ds, "ClientesProducto");

                    ReportDocument reporte = new ReportDocument();

                    reporte.Load(@"C:\Users\jaram\source\repos\Supermercado\Supermercado\InformeC.rpt");
                    reporte.SetDataSource(ds.Tables["ClientesProducto"]);
                    return reporte;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar el reporte: " + ex.Message);
                }
            }
        }
    }
}
