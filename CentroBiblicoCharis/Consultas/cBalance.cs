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
        private Ingresos Ingreso = new Ingresos();
        private Personas Persona = new Personas();

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
            RecolectarTextBox.Text = 0.ToString();
            label8.Visible = false;
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = Ingreso.Listar("*", "1=1");
            DataTable dt2 = new DataTable();
            dt2 = Persona.Listar("IdPersona, Nombre, Balance, Fecha", "1=1");
            DataTable dt3 = new DataTable();
            dt3 = Etapa.ListarEtapa("MontoPendiente", "1");
            label7.Visible = false;
            IngresosGridView.DataSource = dt1;
            PromesasGridView.DataSource = dt2;

            CantidadPromesasTextBox.Text = PromesasGridView.RowCount.ToString();
            PromesasTextBox.Text = dt2.Compute("Sum(Balance)", "1=1").ToString();
            CantidadIngresosTextBox.Text = IngresosGridView.RowCount.ToString();
            IngresosTextBox.Text = dt1.Compute("Sum(Monto)", "1=1").ToString();
            RecolectarTextBox.Text = dt3.Rows[0]["MontoPendiente"].ToString();

            tabControl1.Visible = true;
            RecolectarTextBox.Visible = true;
            label6.Visible = true;

            double x = Convert.ToDouble(RecolectarTextBox.Text);
            double y = Convert.ToDouble(IngresosTextBox.Text);

            if (x == y)
            {
                tabControl1.Visible = false;
                RecolectarTextBox.Visible = false;
                label6.Visible = false;
                label8.Visible = true;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void IngresosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
