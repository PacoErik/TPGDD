namespace FrbaHotel
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Huesped = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.fechaSistema = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cambiarFecha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Huesped
            // 
            this.Huesped.Location = new System.Drawing.Point(69, 77);
            this.Huesped.Name = "Huesped";
            this.Huesped.Size = new System.Drawing.Size(150, 38);
            this.Huesped.TabIndex = 0;
            this.Huesped.Text = "Huesped";
            this.Huesped.UseVisualStyleBackColor = true;
            this.Huesped.Click += new System.EventHandler(this.Huesped_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(69, 167);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(150, 38);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            this.Usuario.UseVisualStyleBackColor = true;
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(69, 250);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(150, 38);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // fechaSistema
            // 
            this.fechaSistema.AutoSize = true;
            this.fechaSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaSistema.Location = new System.Drawing.Point(44, 16);
            this.fechaSistema.Name = "fechaSistema";
            this.fechaSistema.Size = new System.Drawing.Size(46, 15);
            this.fechaSistema.TabIndex = 3;
            this.fechaSistema.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaSistema);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 34);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha del sistema";
            // 
            // cambiarFecha
            // 
            this.cambiarFecha.Location = new System.Drawing.Point(94, 355);
            this.cambiarFecha.Name = "cambiarFecha";
            this.cambiarFecha.Size = new System.Drawing.Size(93, 23);
            this.cambiarFecha.TabIndex = 5;
            this.cambiarFecha.Text = "Cambiar fecha";
            this.cambiarFecha.UseVisualStyleBackColor = true;
            this.cambiarFecha.Click += new System.EventHandler(this.cambiarFecha_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 382);
            this.Controls.Add(this.cambiarFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Huesped);
            this.Name = "Main";
            this.Text = "Bienvenido!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Huesped;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label fechaSistema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cambiarFecha;
    }
}

