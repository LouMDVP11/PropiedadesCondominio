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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermedia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPropiedades
            // 
            this.dtgPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropiedades.Location = new System.Drawing.Point(57, 68);
            this.dtgPropiedades.Name = "dtgPropiedades";
            this.dtgPropiedades.RowHeadersWidth = 51;
            this.dtgPropiedades.RowTemplate.Height = 24;
            this.dtgPropiedades.Size = new System.Drawing.Size(690, 95);
            this.dtgPropiedades.TabIndex = 0;
            // 
            // dtgPropietarios
            // 
            this.dtgPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropietarios.Location = new System.Drawing.Point(57, 204);
            this.dtgPropietarios.Name = "dtgPropietarios";
            this.dtgPropietarios.RowHeadersWidth = 51;
            this.dtgPropietarios.RowTemplate.Height = 24;
            this.dtgPropietarios.Size = new System.Drawing.Size(690, 95);
            this.dtgPropietarios.TabIndex = 1;
            // 
            // dtgIntermedia
            // 
            this.dtgIntermedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermedia.Location = new System.Drawing.Point(57, 338);
            this.dtgIntermedia.Name = "dtgIntermedia";
            this.dtgIntermedia.RowHeadersWidth = 51;
            this.dtgIntermedia.RowTemplate.Height = 24;
            this.dtgIntermedia.Size = new System.Drawing.Size(690, 146);
            this.dtgIntermedia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Propiedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Propietarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Propietarios y sus cuotas";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(422, 497);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(154, 46);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar por cuota de manteimiento";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(593, 499);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(154, 44);
            this.btnReestablecer.TabIndex = 7;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPropiedadToolStripMenuItem,
            this.registrarPropietarioToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarPropiedadToolStripMenuItem
            // 
            this.registrarPropiedadToolStripMenuItem.Name = "registrarPropiedadToolStripMenuItem";
            this.registrarPropiedadToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.registrarPropiedadToolStripMenuItem.Text = "🏚 Registrar propiedad";
            this.registrarPropiedadToolStripMenuItem.Click += new System.EventHandler(this.registrarPropiedadToolStripMenuItem_Click);
            // 
            // registrarPropietarioToolStripMenuItem
            // 
            this.registrarPropietarioToolStripMenuItem.Name = "registrarPropietarioToolStripMenuItem";
            this.registrarPropietarioToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.registrarPropietarioToolStripMenuItem.Text = "👩🏻‍🤝‍🧑🏻 Registrar propietario";
            this.registrarPropietarioToolStripMenuItem.Click += new System.EventHandler(this.registrarPropietarioToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.actualizarToolStripMenuItem.Text = "↻ Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.mostrarDatosToolStripMenuItem.Text = "📝 Mostrar datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 552);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgIntermedia);
            this.Controls.Add(this.dtgPropietarios);
            this.Controls.Add(this.dtgPropiedades);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propiedades y Propietarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermedia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarPropiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPropietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
    }
}

