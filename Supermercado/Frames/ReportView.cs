using CrystalAdd;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            GenerarReporte reporte = new GenerarReporte();
            ReportDocument imprime;
            imprime = reporte.CrearReporte();
            crystalReportViewer1.ReportSource = imprime;
            crystalReportViewer1.RefreshReport();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Close();
        }
    }
}
