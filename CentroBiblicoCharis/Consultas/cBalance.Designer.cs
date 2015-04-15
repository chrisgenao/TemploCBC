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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.EtapaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PromesasGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IngresosGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromesasGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(568, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Etapa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(487, 22);
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
            this.EtapaComboBox.Size = new System.Drawing.Size(421, 21);
            this.EtapaComboBox.TabIndex = 1;
            this.EtapaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PromesasGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 239);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Promesas";
            // 
            // PromesasGridView
            // 
            this.PromesasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromesasGridView.Location = new System.Drawing.Point(9, 19);
            this.PromesasGridView.Name = "PromesasGridView";
            this.PromesasGridView.Size = new System.Drawing.Size(258, 214);
            this.PromesasGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IngresosGridView);
            this.groupBox3.Location = new System.Drawing.Point(291, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 239);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Ingresos";
            // 
            // IngresosGridView
            // 
            this.IngresosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosGridView.Location = new System.Drawing.Point(6, 19);
            this.IngresosGridView.Name = "IngresosGridView";
            this.IngresosGridView.Size = new System.Drawing.Size(277, 214);
            this.IngresosGridView.TabIndex = 1;
            // 
            // cBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cBalance";
            this.ShowIcon = false;
            this.Text = "Balance General";
            this.Load += new System.EventHandler(this.cBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PromesasGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngresosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EtapaComboBox;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PromesasGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView IngresosGridView;
    }
}