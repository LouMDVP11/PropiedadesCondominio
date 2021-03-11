namespace PropiedadesCondominio
{
    partial class frmDatos
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblPropietarioMasPropiedades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCuotasAltas = new System.Windows.Forms.ListBox();
            this.lbCuotasBajas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCuotaAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datos de propietarios y sus propiedades";
            // 
            // lblPropietarioMasPropiedades
            // 
            this.lblPropietarioMasPropiedades.AutoSize = true;
            this.lblPropietarioMasPropiedades.Location = new System.Drawing.Point(14, 99);
            this.lblPropietarioMasPropiedades.Name = "lblPropietarioMasPropiedades";
            this.lblPropietarioMasPropiedades.Size = new System.Drawing.Size(225, 17);
            this.lblPropietarioMasPropiedades.TabIndex = 21;
            this.lblPropietarioMasPropiedades.Text = "Propietario con más propiedades: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Propietario con más propiedades: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "3 Cuotas de mantenimiento más altas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "3 Cuotas de mantenimiento más bajas:";
            // 
            // lbCuotasAltas
            // 
            this.lbCuotasAltas.FormattingEnabled = true;
            this.lbCuotasAltas.ItemHeight = 16;
            this.lbCuotasAltas.Location = new System.Drawing.Point(19, 203);
            this.lbCuotasAltas.Name = "lbCuotasAltas";
            this.lbCuotasAltas.Size = new System.Drawing.Size(355, 84);
            this.lbCuotasAltas.TabIndex = 28;
            // 
            // lbCuotasBajas
            // 
            this.lbCuotasBajas.FormattingEnabled = true;
            this.lbCuotasBajas.ItemHeight = 16;
            this.lbCuotasBajas.Location = new System.Drawing.Point(406, 203);
            this.lbCuotasBajas.Name = "lbCuotasBajas";
            this.lbCuotasBajas.Size = new System.Drawing.Size(355, 84);
            this.lbCuotasBajas.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Propietario con la cuota más alta:\r\n";
            // 
            // lblCuotaAlta
            // 
            this.lblCuotaAlta.AutoSize = true;
            this.lblCuotaAlta.Location = new System.Drawing.Point(16, 349);
            this.lblCuotaAlta.Name = "lblCuotaAlta";
            this.lblCuotaAlta.Size = new System.Drawing.Size(215, 17);
            this.lblCuotaAlta.TabIndex = 30;
            this.lblCuotaAlta.Text = "Propietario con la cuota más alta\r\n";
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCuotaAlta);
            this.Controls.Add(this.lbCuotasBajas);
            this.Controls.Add(this.lbCuotasAltas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPropietarioMasPropiedades);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPropietarioMasPropiedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbCuotasAltas;
        private System.Windows.Forms.ListBox lbCuotasBajas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCuotaAlta;
    }
}