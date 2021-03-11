namespace PropiedadesCondominio
{
    partial class frmPropiedades
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDPI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgPropiedades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(491, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 34);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Registrar una propiedad\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "DPI";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(313, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // cmbDPI
            // 
            this.cmbDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDPI.FormattingEnabled = true;
            this.cmbDPI.Location = new System.Drawing.Point(60, 67);
            this.cmbDPI.Name = "cmbDPI";
            this.cmbDPI.Size = new System.Drawing.Size(169, 24);
            this.cmbDPI.TabIndex = 23;
            this.cmbDPI.SelectedIndexChanged += new System.EventHandler(this.cmbDPI_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Número de Propiedad";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(178, 109);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(89, 22);
            this.txtNumeroCasa.TabIndex = 24;
            this.txtNumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCasa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cuota de Mantenimiento";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(472, 109);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(113, 22);
            this.txtCuota.TabIndex = 26;
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Propiedades registradas";
            // 
            // dtgPropiedades
            // 
            this.dtgPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropiedades.Location = new System.Drawing.Point(27, 212);
            this.dtgPropiedades.Name = "dtgPropiedades";
            this.dtgPropiedades.RowHeadersWidth = 51;
            this.dtgPropiedades.RowTemplate.Height = 24;
            this.dtgPropiedades.Size = new System.Drawing.Size(609, 120);
            this.dtgPropiedades.TabIndex = 28;
            // 
            // frmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(659, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgPropiedades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.cmbDPI);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPropiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Propiedades";
            this.Load += new System.EventHandler(this.frmPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgPropiedades;
    }
}