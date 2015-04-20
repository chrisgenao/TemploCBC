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

namespace CentroBiblicoCharis.Registros
{
    public partial class rPersonas : Form
    {
        private Grupos Grupo = new Grupos();
        private Celulas Celula = new Celulas();
        private Personas Persona = new Personas();
        DataTable dt = new DataTable();


        public rPersonas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rPersonas_Load(object sender, EventArgs e)
        {
            dt = Grupo.Listar("Monto", "1=1");
            FormaPagoComboBox.SelectedIndex = 0;
            GrupoComboBox.DataSource = Grupo.Listar("IdGrupo, Nombre", "1=1");
            GrupoComboBox.ValueMember = "IdGrupo";
            GrupoComboBox.DisplayMember = "Nombre";
            SiguienteButton.Visible = false;
            CelulaComboBox.DataSource = Celula.Listar("IdCelula, Nombre", "1=1");
            CelulaComboBox.ValueMember = "Nombre";
            CelulaComboBox.DisplayMember = "Nombre";
        }

        private void GrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grupo.Listar("Monto", "1=1");

            if (GrupoComboBox.SelectedIndex == 0)
            {
                MontoTextBox.Text = dt.Rows[0]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 1)
            {
                MontoTextBox.Text = dt.Rows[1]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 2)
            {
                MontoTextBox.Text = dt.Rows[2]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 3)
            {
                MontoTextBox.Text = dt.Rows[3]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 4)
            {
                MontoTextBox.Text = dt.Rows[4]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 5)
            {
                MontoTextBox.Text = dt.Rows[5]["Monto"].ToString();
            }
            if (GrupoComboBox.SelectedIndex == 6)
            {
                MontoTextBox.Text = dt.Rows[6]["Monto"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Boolean paso = false;

            if (NombreTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(NombreTextBox, errorProvider1, "Por favor, llena esta casilla.");
            }

            if (CedulaTextBox.MaskFull == false)
            {
                errorProvider2.SetError(CedulaTextBox, "Debe llenar esta casilla");
            }

            else
            {


                Persona.Nombre = NombreTextBox.Text;
                Persona.Celula = CelulaComboBox.SelectedValue.ToString();
                Persona.Cedula = CedulaTextBox.Text;
                Persona.Grupo = Convert.ToInt32(GrupoComboBox.SelectedValue);
                Persona.FormaPago = FormaPagoComboBox.SelectedItem.ToString();
                Persona.Balance = Convert.ToInt32(MontoTextBox.Text.ToString());

                errorProvider1.Clear();
                errorProvider2.Clear();

                if (Persona.IdPersona > 0)
                {
                    //Editando
                    paso = Persona.Modificar();
                }
                else
                {
                    //Insertando
                    paso = Persona.Insertar();
                }

                if (paso)
                {
                    MessageBox.Show("Persona Guardada.");
                    SiguienteButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error Guardando la Persona.");

                }
            }
        }

        private void CedulaTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            CelulaComboBox.SelectedIndex = 0;
            CedulaTextBox.ResetText();
            GrupoComboBox.SelectedIndex = 0;
            FormaPagoComboBox.SelectedIndex = 0;
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }
            if (Persona.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Persona Borrada.");
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rPagos rPago = new rPagos();
            rPago.ShowDialog();
        }

        private void FormaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IDTextBox.Text) == 0)
            {
                Consultas.cPersonas cPersona = new Consultas.cPersonas();

                result = cPersona.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IDTextBox.Text = cPersona.DatoEncontrado.ToString();
                }
                else
                {
                    IDTextBox.Clear();
                }
                if (Persona.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
                {
                    if (Persona.Celula == "Andy Caceres")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 0;
                        CedulaTextBox.Text = Persona.Cedula;
                        GrupoComboBox.SelectedIndex = Persona.Grupo;

                        }
                }
            }
        }
    }
}

