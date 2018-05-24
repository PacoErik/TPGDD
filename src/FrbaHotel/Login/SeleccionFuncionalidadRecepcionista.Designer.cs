namespace FrbaHotel.Login
{
    partial class SeleccionFuncionalidadRecepcionista
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
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(54, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(182, 35);
            this.button11.TabIndex = 15;
            this.button11.Text = "Registrar consumibles";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Registrar_consumible_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(54, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "Registrar estadia";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Registrar_estadia_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(54, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "Cancelar reserva";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Cancelar_reserva_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "Generar o modificar reserva";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Generar_o_modificar_una_reserva_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(108, 227);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // SeleccionFuncionalidadRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "SeleccionFuncionalidadRecepcionista";
            this.Text = "SeleccionFuncionalidadRecepcionista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Salir;
    }
}