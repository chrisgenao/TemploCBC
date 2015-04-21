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
    public partial class cUsuarios : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cUsuarios()
        {
            InitializeComponent();
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void BuscarPorButton_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdUsuario
            {
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdUsuario = " + BuscarPorTextBox.Text;
                }
            }


            else if (BuscarPorComboBox.SelectedIndex == 1) //Nombre
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Nombre like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) //Apellido
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Apellido like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) // Usuario
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Usuario like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 4) //Mail
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Mail like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 5) //Nivel
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Nivel = " + BuscarPorTextBox.Text;
                }
            dt = Usuario.Listar("IdUsuario, Nombre, Apellido, Usuario, Mail, Nivel, Fecha", filtro);
            UsuarioGridView.DataSource = dt;
            CantidadTextBox.Text = UsuarioGridView.RowCount.ToString();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            int index;

            index = UsuarioGridView.CurrentRow.Index;

            datoEncontrado = (int)UsuarioGridView.CurrentRow.Cells["IdUsuario"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BuscarPorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
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
