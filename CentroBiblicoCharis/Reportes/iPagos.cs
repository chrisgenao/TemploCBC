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

//todo: Terminar Consultas (Balance General >> Promesas(clase))

namespace CentroBiblicoCharis.Reportes
{
    public partial class iPagos : Form
    {
        public iPagos()
        {
            InitializeComponent();
        }

        private void iPagos_Load(object sender, EventArgs e)
        {
            Reportest1.Refresh();
        }
    }
}
