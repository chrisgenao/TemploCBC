namespace CentroBiblicoCharis.Registros
{
    partial class rPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.PersonaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrupoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CelulaTextBox = new System.Windows.Forms.TextBox();
            this.CedulaTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BalancePTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PagaraTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // PersonaComboBox
            // 
            this.PersonaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonaComboBox.FormattingEnabled = true;
            this.PersonaComboBox.Items.AddRange(new object[] {
            "IdPersona",
            "Nombre"});
            this.PersonaComboBox.Location = new System.Drawing.Point(42, 12);
            this.PersonaComboBox.Name = "PersonaComboBox";
            this.PersonaComboBox.Size = new System.Drawing.Size(171, 21);
            this.PersonaComboBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrupoTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CelulaTextBox);
            this.groupBox1.Controls.Add(this.CedulaTextBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Persona";
            // 
            // GrupoTextBox
            // 
            this.GrupoTextBox.Location = new System.Drawing.Point(152, 129);
            this.GrupoTextBox.Name = "GrupoTextBox";
            this.GrupoTextBox.ReadOnly = true;
            this.GrupoTextBox.Size = new System.Drawing.Size(100, 20);
            this.GrupoTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grupo #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Celula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cedula:";
            // 
            // CelulaTextBox
            // 
            this.CelulaTextBox.Location = new System.Drawing.Point(152, 103);
            this.CelulaTextBox.Name = "CelulaTextBox";
            this.CelulaTextBox.ReadOnly = true;
            this.CelulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CelulaTextBox.TabIndex = 5;
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(152, 77);
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.ReadOnly = true;
            this.CedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CedulaTextBox.TabIndex = 4;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(152, 51);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(152, 25);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(238, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 33);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BalancePTextBox
            // 
            this.BalancePTextBox.Location = new System.Drawing.Point(172, 25);
            this.BalancePTextBox.Name = "BalancePTextBox";
            this.BalancePTextBox.ReadOnly = true;
            this.BalancePTextBox.Size = new System.Drawing.Size(100, 20);
            this.BalancePTextBox.TabIndex = 11;
            this.BalancePTextBox.TextChanged += new System.EventHandler(this.BalancePTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Balance Pendiente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pagara:";
            // 
            // PagaraTextBox
            // 
            this.PagaraTextBox.Location = new System.Drawing.Point(172, 51);
            this.PagaraTextBox.Name = "PagaraTextBox";
            this.PagaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.PagaraTextBox.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarButton);
            this.groupBox2.Controls.Add(this.GuardarButton);
            this.groupBox2.Controls.Add(this.PagaraTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BalancePTextBox);
            this.groupBox2.Location = new System.Drawing.Point(319, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 169);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Pago";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(148, 116);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(137, 47);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Actualizar/Imprimir";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButton.Image")));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.Location = new System.Drawing.Point(6, 116);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(137, 47);
            this.LimpiarButton.TabIndex = 17;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // rPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PersonaComboBox);
            this.Controls.Add(this.label1);
            this.Name = "rPagos";
            this.Text = "Registro de Pagos";
            this.Load += new System.EventHandler(this.rPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PersonaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox GrupoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CelulaTextBox;
        private System.Windows.Forms.TextBox CedulaTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox BalancePTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PagaraTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button GuardarButton;
    }
}