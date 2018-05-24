namespace FrbaHotel.Login
{
    partial class SeleccionFuncionalidadAdmin
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
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(53, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Gestion de regimen de estadia";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Gestion_regimen_de_estadia_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Gestion de habitaciones";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Gestion_de_habitaciones_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Gestion de hotel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Gestion_de_hoteles_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gestion de usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Gestion_de_usuarios_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(105, 227);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 13;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // SeleccionFuncionalidadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Name = "SeleccionFuncionalidadAdmin";
            this.Text = "SeleccionFuncionalidadAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Salir;
    }
}