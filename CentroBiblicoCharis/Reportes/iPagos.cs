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
            DataTable dt = new DataTable();
            DataSet ds = new DataSet("Pagos");
            dt = Pago.ListarPago();
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Ejemplo1.xml");
        }

    }
}
