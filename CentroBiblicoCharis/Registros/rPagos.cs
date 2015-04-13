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

namespace CentroBiblicoCharis.Registros
{
    public partial class rPagos : Form
    {
        private Personas Persona = new Personas();
        private Etapas Etapa = new Etapas();

        DataTable dt = new DataTable();
        public rPagos()
        {
            InitializeComponent();
        }

        private void rPagos_Load(object sender, EventArgs e)
        {
            ActualizarComboBox();
            GuardarButton.Visible = false;
            PagaraTextBox.ReadOnly = true;
            LimpiarButton.Visible = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           Boolean paso = false;

           dt = Persona.Listar("IdPersona, Nombre, Cedula, Celula, Grupo, Balance", "IdPersona = "+PersonaComboBox.SelectedValue.ToString());

           IDTextBox.Text = dt.Rows[0]["IdPersona"].ToString();
           NombreTextBox.Text = dt.Rows[0]["Nombre"].ToString();
           CedulaTextBox.Text = dt.Rows[0]["Cedula"].ToString();
           CelulaTextBox.Text = dt.Rows[0]["Celula"].ToString();
           GrupoTextBox.Text = dt.Rows[0]["Grupo"].ToString();
           BalancePTextBox.Text = dt.Rows[0]["Balance"].ToString();
           paso = true;

           if (paso)
           {
               GuardarButton.Visible = true;
               PagaraTextBox.ReadOnly = false;
               LimpiarButton.Visible = true;
           }
           
           //CantidadTextBox.Text = DataGridView.RowCount.ToString();
           // 
           // string filtro = "1=1";
        }

        private void BalancePTextBox_TextChanged(object sender, EventArgs e)
        {
       //     int x;
       //     int y;
       //
       //     x = Convert.ToInt32(BalancePTextBox.Text);
       //     y = Convert.ToInt32(PagaraTextBox.Text);
       //     BalanceRTextBox.Text = (x - y).ToString();
        }

        private void GuardarButton_Click (object sender, EventArgs e)
        {
            Boolean paso = false;

            if (PagaraTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(PagaraTextBox, errorProvider1, "Es Obligatorio Llenar esta Casilla.");
            }
            else
            {
                int x = Convert.ToInt32(BalancePTextBox.Text);
                int y = Convert.ToInt32(PagaraTextBox.Text);

                Persona.Balance = x - y;
                paso = true;
                Persona.ModificarPago(Convert.ToInt32(IDTextBox.Text));

            }
            if (paso)
            {
                dt = Persona.Listar("Balance", "IdPersona = " + IDTextBox.Text);
                BalancePTextBox.Text = dt.Rows[0]["Balance"].ToString();
                BalancePTextBox.Refresh();
                Etapa.AfectarBalance(1, Convert.ToDouble(PagaraTextBox.Text));
                PagaraTextBox.Clear();
                ActualizarComboBox();
                MessageBox.Show("Pago Realizado");
                //todo: Imprimir Factura.
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error Haciendo el Pago");
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            
            IDTextBox.Clear();
            NombreTextBox.Clear();
            CedulaTextBox.Clear();
            CelulaTextBox.Clear();
            GrupoTextBox.Clear();
            BalancePTextBox.Clear();
            PagaraTextBox.Clear();
            PagaraTextBox.ReadOnly = true;
            LimpiarButton.Visible = false;
            GuardarButton.Visible = false;
            ActualizarComboBox();
        }

        private void ActualizarComboBox()
        {
            PersonaComboBox.DataSource = Persona.Listar("IdPersona, Nombre", "Balance>0");
            PersonaComboBox.ValueMember = "IdPersona";
            PersonaComboBox.DisplayMember = "Nombre";
        }
    }
}