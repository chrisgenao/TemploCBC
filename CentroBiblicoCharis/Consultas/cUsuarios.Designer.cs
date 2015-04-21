namespace CentroBiblicoCharis.Consultas
{
    partial class cUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPorComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarPorTextBox = new System.Windows.Forms.TextBox();
            this.BuscarPorButton = new System.Windows.Forms.Button();
            this.UsuarioGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // BuscarPorComboBox
            // 
            this.BuscarPorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorComboBox.FormattingEnabled = true;
            this.BuscarPorComboBox.Items.AddRange(new object[] {
            "IdUsuario",
            "Nombre",
            "Apellido",
            "Usuario",
            "Mail",
            "Nivel"});
            this.BuscarPorComboBox.Location = new System.Drawing.Point(80, 14);
            this.BuscarPorComboBox.Name = "BuscarPorComboBox";
            this.BuscarPorComboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarPorComboBox.TabIndex = 2;
            // 
            // BuscarPorTextBox
            // 
            this.BuscarPorTextBox.Location = new System.Drawing.Point(226, 14);
            this.BuscarPorTextBox.Name = "BuscarPorTextBox";
            this.BuscarPorTextBox.Size = new System.Drawing.Size(229, 20);
            this.BuscarPorTextBox.TabIndex = 3;
            this.BuscarPorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarPorTextBox_KeyPress);
            // 
            // BuscarPorButton
            // 
            this.BuscarPorButton.Location = new System.Drawing.Point(461, 12);
            this.BuscarPorButton.Name = "BuscarPorButton";
            this.BuscarPorButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarPorButton.TabIndex = 4;
            this.BuscarPorButton.Text = "Buscar";
            this.BuscarPorButton.UseVisualStyleBackColor = true;
            this.BuscarPorButton.Click += new System.EventHandler(this.BuscarPorButton_Click);
            // 
            // UsuarioGridView
            // 
            this.UsuarioGridView.AllowUserToAddRows = false;
            this.UsuarioGridView.AllowUserToDeleteRows = false;
            this.UsuarioGridView.AllowUserToOrderColumns = true;
            this.UsuarioGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioGridView.Location = new System.Drawing.Point(12, 41);
            this.UsuarioGridView.Name = "UsuarioGridView";
            this.UsuarioGridView.ReadOnly = true;
            this.UsuarioGridView.Size = new System.Drawing.Size(524, 250);
            this.UsuarioGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(70, 301);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 7;
            this.CantidadTextBox.Text = "0";
            this.CantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(392, 299);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 8;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(473, 299);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 9;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // cUsuarios
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuarioGridView);
            this.Controls.Add(this.BuscarPorButton);
            this.Controls.Add(this.BuscarPorTextBox);
            this.Controls.Add(this.BuscarPorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cUsuarios";
            this.ShowIcon = false;
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.cUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPorComboBox;
        private System.Windows.Forms.TextBox BuscarPorTextBox;
        private System.Windows.Forms.Button BuscarPorButton;
        private System.Windows.Forms.DataGridView UsuarioGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}