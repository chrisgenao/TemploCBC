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

namespace CentroBiblicoCharis
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();

            Utilitarios.ValidarTextBoxVacio(UsuarioTextBox, errorProvider1, "Error, Por favor Ingresa un Usuario");
            if (UsuarioTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UsuarioTextBox, "Debe Introducir un Usuario.");
                UsuarioTextBox.Focus();
                return;
            }

            if (PasswordTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(PasswordTextBox, "Debe Introducir una Contraseña.");
                UsuarioTextBox.Focus();
                return;
            }

            if (UsuarioTextBox.Text.Trim().Length > 0 && PasswordTextBox.Text.Trim().Length > 0)
            {
                Usuario.BuscarUsuario(UsuarioTextBox.Text, PasswordTextBox.Text);

                if (UsuarioTextBox.Text == Usuario.Usuario && PasswordTextBox.Text == Usuario.Contra)
                {
                    MainWindow MainWindow = new MainWindow();
                    MessageBox.Show("Bienvenido, Dios Le Bendiga.");
                    MainWindow.Usua = Usuario.Usuario;
                    MainWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                    UsuarioTextBox.Focus();
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias, Dios le bendiga.");
            this.Close();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
        }
    }
}
