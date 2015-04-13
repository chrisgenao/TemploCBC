using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CentroBiblicoCharis.Consultas
{
    public partial class cBalance : Form
    {
        private Etapas Etapa = new Etapas();

        public cBalance()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBalance_Load(object sender, EventArgs e)
        {
            EtapaComboBox.DataSource = Etapa.Listar("IdEtapa, Nombre", "1=1");
            EtapaComboBox.ValueMember = "IdEtapa";
            EtapaComboBox.DisplayMember = "Nombre";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
