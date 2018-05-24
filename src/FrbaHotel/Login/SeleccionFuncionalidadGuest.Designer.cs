namespace FrbaHotel.Login
{
    partial class SeleccionFuncionalidadGuest
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(54, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "Cancelar reserva";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Cancelar_reserva_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 94);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "Generar o modificar reserva";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Generar_o_modificar_una_reserva_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(102, 227);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // SeleccionFuncionalidadGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "SeleccionFuncionalidadGuest";
            this.Text = "SeleccionFuncionalidadGuest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Salir;
    }
}