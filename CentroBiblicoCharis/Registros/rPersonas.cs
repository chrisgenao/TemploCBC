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
                MontoTextBox.ReadOnly = false;
            }
            if (GrupoComboBox.SelectedIndex == 1)
            {
                MontoTextBox.Text = dt.Rows[1]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 2)
            {
                MontoTextBox.Text = dt.Rows[2]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 3)
            {
                MontoTextBox.Text = dt.Rows[3]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 4)
            {
                MontoTextBox.Text = dt.Rows[4]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 5)
            {
                MontoTextBox.Text = dt.Rows[5]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 6)
            {
                MontoTextBox.Text = dt.Rows[6]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
            }
            if (GrupoComboBox.SelectedIndex == 7)
            {
                MontoTextBox.Text = dt.Rows[7]["Monto"].ToString();
                MontoTextBox.ReadOnly = true;
                
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
                Persona.Grupo = Convert.ToInt32(GrupoComboBox.SelectedIndex.ToString());
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
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();

                    }
                    else if (Persona.Celula == "Ana Celia Cabrera")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 1;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Arelis Holguin")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 2;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Alina E. Sánchez")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 3;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Daniela Santos")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 4;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Damaris Perez")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 5;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Evelin Coronado")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 6;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Elias Santos")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 7;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Franchesca Piña")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 8;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Glenny Marte")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 9;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Grisanna Polanco")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 10;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Janet Guzman")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 11;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "José Miguel Reyes")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 12;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Juana Iris Then")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 13;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Julio Torres")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 14;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Loammi Victorino")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 15;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Maria E. Brito")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 16;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Maira Martinez")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 17;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Maria Isabel Hilario")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 18;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Mariela Gonzales")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 19;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Migdalia Ferreira")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 20;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Niurka Reyes")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 21;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Lourdres Maria")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 22;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Rafael Ivan Jorge")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 23;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Tony Santos")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 24;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Yanilda Mercado")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 25;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                    else if (Persona.Celula == "Ninguna")
                    {
                        IDTextBox.Text = Persona.IdPersona.ToString();
                        NombreTextBox.Text = Persona.Nombre.ToString();
                        CelulaComboBox.SelectedIndex = 26;
                        CedulaTextBox.Text = Persona.Cedula.ToString();
                        GrupoComboBox.SelectedIndex = Convert.ToInt32(Persona.Grupo.ToString());
                        FormaPagoComboBox.SelectedItem = Persona.FormaPago.ToString();
                    }
                }
            }
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

