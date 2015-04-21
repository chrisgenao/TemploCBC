namespace CentroBiblicoCharis.Consultas
{
    partial class cBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cBalance));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.EtapaComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CantidadPromesasTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PromesasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PromesasGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CantidadIngresosTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresosTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresosGridView = new System.Windows.Forms.DataGridView();
            this.RecolectarTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromesasGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etapa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerarButton);
            this.groupBox1.Controls.Add(this.EtapaComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Etapa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(546, 22);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(75, 23);
            this.GenerarButton.TabIndex = 2;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // EtapaComboBox
            // 
            this.EtapaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EtapaComboBox.FormattingEnabled = true;
            this.EtapaComboBox.Items.AddRange(new object[] {
            "IdEtapa",
            "Nombre"});
            this.EtapaComboBox.Location = new System.Drawing.Point(50, 24);
            this.EtapaComboBox.Name = "EtapaComboBox";
            this.EtapaComboBox.Size = new System.Drawing.Size(490, 21);
            this.EtapaComboBox.TabIndex = 1;
            this.EtapaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 350);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CantidadPromesasTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.PromesasTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.PromesasGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Promesas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CantidadPromesasTextBox
            // 
            this.CantidadPromesasTextBox.Location = new System.Drawing.Point(89, 299);
            this.CantidadPromesasTextBox.Name = "CantidadPromesasTextBox";
            this.CantidadPromesasTextBox.ReadOnly = true;
            this.CantidadPromesasTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadPromesasTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Cantidad:";
            // 
            // PromesasTextBox
            // 
            this.PromesasTextBox.Location = new System.Drawing.Point(513, 299);
            this.PromesasTextBox.Name = "PromesasTextBox";
            this.PromesasTextBox.ReadOnly = true;
            this.PromesasTextBox.Size = new System.Drawing.Size(100, 20);
            this.PromesasTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Promesas:";
            // 
            // PromesasGridView
            // 
            this.PromesasGridView.AllowUserToAddRows = false;
            this.PromesasGridView.AllowUserToDeleteRows = false;
            this.PromesasGridView.AllowUserToOrderColumns = true;
            this.PromesasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromesasGridView.Location = new System.Drawing.Point(6, 6);
            this.PromesasGridView.Name = "PromesasGridView";
            this.PromesasGridView.ReadOnly = true;
            this.PromesasGridView.Size = new System.Drawing.Size(607, 286);
            this.PromesasGridView.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CantidadIngresosTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.IngresosTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.IngresosGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingresos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CantidadIngresosTextBox
            // 
            this.CantidadIngresosTextBox.Location = new System.Drawing.Point(89, 298);
            this.CantidadIngresosTextBox.Name = "CantidadIngresosTextBox";
            this.CantidadIngresosTextBox.ReadOnly = true;
            this.CantidadIngresosTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadIngresosTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Cantidad:";
            // 
            // IngresosTextBox
            // 
            this.IngresosTextBox.Location = new System.Drawing.Point(513, 298);
            this.IngresosTextBox.Name = "IngresosTextBox";
            this.IngresosTextBox.ReadOnly = true;
            this.IngresosTextBox.Size = new System.Drawing.Size(100, 20);
            this.IngresosTextBox.TabIndex = 5;
            this.IngresosTextBox.TextChanged += new System.EventHandler(this.IngresosTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Ingresos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IngresosGridView
            // 
            this.IngresosGridView.AllowUserToAddRows = false;
            this.IngresosGridView.AllowUserToDeleteRows = false;
            this.IngresosGridView.AllowUserToOrderColumns = true;
            this.IngresosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosGridView.Location = new System.Drawing.Point(6, 6);
            this.IngresosGridView.Name = "IngresosGridView";
            this.IngresosGridView.ReadOnly = true;
            this.IngresosGridView.Size = new System.Drawing.Size(607, 286);
            this.IngresosGridView.TabIndex = 3;
            // 
            // RecolectarTextBox
            // 
            this.RecolectarTextBox.Location = new System.Drawing.Point(539, 446);
            this.RecolectarTextBox.Name = "RecolectarTextBox";
            this.RecolectarTextBox.ReadOnly = true;
            this.RecolectarTextBox.Size = new System.Drawing.Size(100, 20);
            this.RecolectarTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pendiente a Recolectar:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(0, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "**Genere la Etapa para Verificar el Monto Pentiende**";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(14, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(625, 55);
            this.label8.TabIndex = 8;
            this.label8.Text = "     ETAPA COMPLETADA!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 478);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RecolectarTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cBalance";
            this.Text = "Balance General";
            this.Load += new System.EventHandler(this.cBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromesasGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EtapaComboBox;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView PromesasGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView IngresosGridView;
        private System.Windows.Forms.TextBox CantidadIngresosTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngresosTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadPromesasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PromesasTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RecolectarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}