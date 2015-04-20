using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using BLL;
using System.Data.SqlClient;

namespace CentroBiblicoCharis.Reportes
{
    public partial class iPagos : Form
    {
        private Pagos Pago = new Pagos();

        
        public iPagos()
        {
            InitializeComponent();
        }

        private void iPagos_Load(object sender, EventArgs e)
        {
            ReporteTest1 objRpt;
            // Creating object of our report.
            objRpt = new ReporteTest1();

            String ConnStr = @"Data Source=.\sqlexpress;Initial Catalog=CentroBiblicoCharisDB;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(ConnStr);

            String Query1 = @"Select * from Pagos where IdPago = (SELECT MAX(IdPago) from Pagos)";

            SqlDataAdapter adapter = new SqlDataAdapter(Query1, ConnStr);

            DataSet Ds = new DataSet();

            // here my_dt is the name of the DataTable which we 
            // created in the designer view.
            adapter.Fill(Ds, "Pagos");

            if (Ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data Found", "CrystalReportWithOracle");
                return;
            }

            // Setting data source of our report object
            objRpt.SetDataSource(Ds);

            CrystalDecisions.CrystalReports.Engine.TextObject root;
            root = (CrystalDecisions.CrystalReports.Engine.TextObject)
                 objRpt.ReportDefinition.ReportObjects["txt_header"];
            root.Text = "Sample Report By Using Data Table!!";

            // Binding the crystalReportViewer with our report object. 
            crystalReportViewer1.ReportSource = objRpt;
        }

    }
}
