﻿using System;
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
    public partial class MainWindow : Form
    {
        public string Usua { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.BuscarUsuario_2(Usua);

            if (Usuario.Nivel == 0)
            {
                usuarioToolStripMenuItem.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            NombreStrip.Text = Usuario.Nombre.ToString() +" "+ Usuario.Apellido.ToString();
            UsuarioStrip.Text = "("+Usuario.Usuario.ToString() + ")";
            if (Usuario.Nivel == 1)
            {
                NivelStrip.Text = "Administrador.";
            }
            else if (Usuario.Nivel == 0)
            {
                NivelStrip.Text = "Usuario";
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desconectado Satisfactoriamente.");
            this.Close();
            LoginUI Login = new LoginUI();
            Login.ShowDialog();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPersonas rPersona = new Registros.rPersonas();
            rPersona.ShowDialog();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPagos rPago = new Registros.rPagos();
            rPago.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rUsuarios rUsuario = new Registros.rUsuarios();
            rUsuario.ShowDialog();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.cBalance cBalance = new Consultas.cBalance();
            cBalance.ShowDialog();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cPersonas cPersona = new Consultas.cPersonas();
            cPersona.ShowDialog();
        }
    }
}
