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
    public partial class rUsuarios : Form
    {
        private Usuarios Usuario = new Usuarios();
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            NivelComboBox.SelectedIndex = 0;  
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Boolean paso = false;

             if (NombreTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(NombreTextBox, "Debe Introducir un Nombre.");
                NombreTextBox.Focus();
                return;
            }

            if (ApellidoTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ApellidoTextBox, "Debe Introducir un Apellido.");
                ApellidoTextBox.Focus();
                return;
            }
            if (UsuarioTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UsuarioTextBox, "Debe Introducir un Usuario.");
                UsuarioTextBox.Focus();
                return;
            }

            if (PWTextBox.Text.Trim().Length == 0)
            {

                errorProvider1.SetError(PWTextBox, "Debe Introducir una Contraseña.");
                PWTextBox.Focus();
                return;
            }

            if (PW2TextBox.Text.Trim().Length == 0)
            {

                errorProvider1.SetError(PWTextBox, "Debe Introducir una Contraseña.");
                PW2TextBox.Focus();
                return;
            }

            if (MailTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(MailTextBox, "Debe Introducir un Correo.");
                MailTextBox.Focus();
                return;
            }
            else if (String.Compare(PWTextBox.Text, PW2TextBox.Text, true) == 0)
            {
                Usuario.IdUsuario = Utilitarios.ToInt(IDTextBox.Text);
                Usuario.Nombre = NombreTextBox.Text;
                Usuario.Apellido = ApellidoTextBox.Text;
                Usuario.Usuario = UsuarioTextBox.Text;
                Usuario.Contra = PWTextBox.Text;
                Usuario.Mail = MailTextBox.Text;
                Usuario.Nivel = Utilitarios.ToInt(NivelComboBox.SelectedItem.ToString());

                if (Usuario.IdUsuario > 0)
                {
                    //Editando
                    paso = Usuario.Modificar();
                }
                else
                {
                    //Insertando
                    paso = Usuario.Insertar();
                }
            }

            if (paso)
            {
                IDTextBox.Clear();
                NombreTextBox.Clear();
                ApellidoTextBox.Clear();
                UsuarioTextBox.Clear();
                PW2TextBox.Clear();
                PWTextBox.Clear();
                MailTextBox.Clear();
                NivelComboBox.SelectedIndex = 0;
                MessageBox.Show("Usuario Guardado.");
            }
            else
            {
                MessageBox.Show("Ha Ocurrido un Error, Compruebe el usuario y la contraseña.");
            }
           
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar))
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void UsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PWTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PW2TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar) || e.KeyChar == 45 || e.KeyChar == 46 || e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            UsuarioTextBox.Clear();
            PW2TextBox.Clear();
            PWTextBox.Clear();
            MailTextBox.Clear();
            NivelComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IDTextBox.Text) == 0)
            {
                Consultas.cUsuarios cUsuario = new Consultas.cUsuarios();

                result = cUsuario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IDTextBox.Text = cUsuario.DatoEncontrado.ToString();
                }
                else
                {
                    IDTextBox.Clear();
                }

                if (Usuario.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
                {

                    IDTextBox.Text = Usuario.IdUsuario.ToString();
                    NombreTextBox.Text = Usuario.Nombre.ToString();
                    ApellidoTextBox.Text = Usuario.Apellido.ToString();
                    UsuarioTextBox.Text = Usuario.Usuario.ToString();
                    PWTextBox.Text = Usuario.Contra.ToString();
                    MailTextBox.Text = Usuario.Mail.ToString();
                    NivelComboBox.SelectedIndex = Convert.ToInt32(Usuario.Nivel.ToString());
                }
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }
            if (Usuario.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Usuario Borrado.");
        }
    }
}
