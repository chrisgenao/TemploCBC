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
    public partial class cPersonas : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }
        
        public cPersonas()
        {
            InitializeComponent();
        }

        private void cPersonas_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Personas Persona = new Personas();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)
            {
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdPersona = " + BuscarPorTextBox.Text;
                }
            }

            else if (BuscarPorComboBox.SelectedIndex == 1) //Loteria
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Nombre like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) // Tanda
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Cedula like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) //Jugada
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Celula like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 4) //Primer_Lugar
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Grupo = " + BuscarPorTextBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 5) //Segundo_Lugar
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    
                    filtro = "FormaPago like '%" + BuscarPorTextBox.Text + "%'";
                }
            dt = Persona.Listar("*", filtro);
            PersonaGridView.DataSource = dt;
            CantidadTextBox.Text = PersonaGridView.RowCount.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;

            index = PersonaGridView.CurrentRow.Index;

            datoEncontrado = (int)PersonaGridView.CurrentRow.Cells["IdPersona"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
