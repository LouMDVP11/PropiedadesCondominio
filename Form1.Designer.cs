namespace PropiedadesCondominio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgPropiedades = new System.Windows.Forms.DataGridView();
            this.dtgPropietarios = new System.Windows.Forms.DataGridView();
            this.dtgIntermedia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermedia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPropiedades
            // 
            this.dtgPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropiedades.Location = new System.Drawing.Point(12, 50);
            this.dtgPropiedades.Name = "dtgPropiedades";
            this.dtgPropiedades.RowHeadersWidth = 51;
            this.dtgPropiedades.RowTemplate.Height = 24;
            this.dtgPropiedades.Size = new System.Drawing.Size(674, 95);
            this.dtgPropiedades.TabIndex = 0;
            // 
            // dtgPropietarios
            // 
            this.dtgPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropietarios.Location = new System.Drawing.Point(12, 186);
            this.dtgPropietarios.Name = "dtgPropietarios";
            this.dtgPropietarios.RowHeadersWidth = 51;
            this.dtgPropietarios.RowTemplate.Height = 24;
            this.dtgPropietarios.Size = new System.Drawing.Size(674, 95);
            this.dtgPropietarios.TabIndex = 1;
            // 
            // dtgIntermedia
            // 
            this.dtgIntermedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermedia.Location = new System.Drawing.Point(12, 329);
            this.dtgIntermedia.Name = "dtgIntermedia";
            this.dtgIntermedia.RowHeadersWidth = 51;
            this.dtgIntermedia.RowTemplate.Height = 24;
            this.dtgIntermedia.Size = new System.Drawing.Size(488, 146);
            this.dtgIntermedia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Propiedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Propietarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Propietarios y sus cuotas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(532, 329);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(154, 46);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar por cuota de manteimiento";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(532, 381);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(154, 44);
            this.btnReestablecer.TabIndex = 7;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(532, 431);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(154, 44);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 664);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgIntermedia);
            this.Controls.Add(this.dtgPropietarios);
            this.Controls.Add(this.dtgPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propiedades y Propietarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPropiedades;
        private System.Windows.Forms.DataGridView dtgPropietarios;
        private System.Windows.Forms.DataGridView dtgIntermedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnMostrar;
    }
}

