namespace CentroBiblicoCharis.Registros
{
    partial class rPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPersonas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CelulaComboBox = new System.Windows.Forms.ComboBox();
            this.CedulaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.GrupoComboBox = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SiguienteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "# Grupo de Promesa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forma de Pago";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormaPagoComboBox);
            this.groupBox1.Controls.Add(this.MontoTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CelulaComboBox);
            this.groupBox1.Controls.Add(this.CedulaTextBox);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.GrupoComboBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormaPagoComboBox
            // 
            this.FormaPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagoComboBox.FormattingEnabled = true;
            this.FormaPagoComboBox.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual",
            "Trimestral",
            "Semestral",
            "A termino"});
            this.FormaPagoComboBox.Location = new System.Drawing.Point(140, 146);
            this.FormaPagoComboBox.Name = "FormaPagoComboBox";
            this.FormaPagoComboBox.Size = new System.Drawing.Size(99, 21);
            this.FormaPagoComboBox.TabIndex = 24;
            this.FormaPagoComboBox.SelectedIndexChanged += new System.EventHandler(this.FormaPagoComboBox_SelectedIndexChanged);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(140, 172);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.ReadOnly = true;
            this.MontoTextBox.Size = new System.Drawing.Size(126, 20);
            this.MontoTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto Promesa:";
            // 
            // CelulaComboBox
            // 
            this.CelulaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CelulaComboBox.FormattingEnabled = true;
            this.CelulaComboBox.Items.AddRange(new object[] {
            "IdCelula",
            "Nombre"});
            this.CelulaComboBox.Location = new System.Drawing.Point(140, 67);
            this.CelulaComboBox.Name = "CelulaComboBox";
            this.CelulaComboBox.Size = new System.Drawing.Size(100, 21);
            this.CelulaComboBox.TabIndex = 18;
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(140, 93);
            this.CedulaTextBox.Mask = "000-0000000-0";
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.Size = new System.Drawing.Size(88, 20);
            this.CedulaTextBox.TabIndex = 17;
            this.CedulaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CedulaTextBox_MaskInputRejected);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(189, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 29);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GrupoComboBox
            // 
            this.GrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupoComboBox.FormattingEnabled = true;
            this.GrupoComboBox.Items.AddRange(new object[] {
            "IdGrupo",
            "Nombre"});
            this.GrupoComboBox.Location = new System.Drawing.Point(140, 119);
            this.GrupoComboBox.Name = "GrupoComboBox";
            this.GrupoComboBox.Size = new System.Drawing.Size(100, 21);
            this.GrupoComboBox.TabIndex = 14;
            this.GrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupoComboBox_SelectedIndexChanged);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(140, 41);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(126, 20);
            this.NombreTextBox.TabIndex = 11;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(140, 14);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(43, 20);
            this.IDTextBox.TabIndex = 10;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButton.Image")));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.Location = new System.Drawing.Point(41, 258);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 34);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButton.Image")));
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.Location = new System.Drawing.Point(203, 258);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 34);
            this.BorrarButton.TabIndex = 12;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(122, 258);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 34);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // SiguienteButton
            // 
            this.SiguienteButton.Image = ((System.Drawing.Image)(resources.GetObject("SiguienteButton.Image")));
            this.SiguienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SiguienteButton.Location = new System.Drawing.Point(284, 258);
            this.SiguienteButton.Name = "SiguienteButton";
            this.SiguienteButton.Size = new System.Drawing.Size(75, 34);
            this.SiguienteButton.TabIndex = 14;
            this.SiguienteButton.Text = "Siguiente";
            this.SiguienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SiguienteButton.UseVisualStyleBackColor = true;
            this.SiguienteButton.Click += new System.EventHandler(this.SiguienteButton_Click);
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 304);
            this.Controls.Add(this.SiguienteButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rPersonas";
            this.ShowIcon = false;
            this.Text = "Registro de Persona";
            this.Load += new System.EventHandler(this.rPersonas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox GrupoComboBox;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ComboBox CelulaComboBox;
        private System.Windows.Forms.MaskedTextBox CedulaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button SiguienteButton;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.ComboBox FormaPagoComboBox;
    }
}