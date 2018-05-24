namespace FrbaHotel.GenerarModificacionReserva
{
    partial class GenerarModificacionReserva
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
            this.atras = new System.Windows.Forms.Button();
            this.modificacion = new System.Windows.Forms.Button();
            this.alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(17, 214);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(62, 34);
            this.atras.TabIndex = 9;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // modificacion
            // 
            this.modificacion.Location = new System.Drawing.Point(73, 128);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(141, 23);
            this.modificacion.TabIndex = 7;
            this.modificacion.Text = "Modificar reserva";
            this.modificacion.UseVisualStyleBackColor = true;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(73, 70);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(141, 23);
            this.alta.TabIndex = 5;
            this.alta.Text = "Generar reserva";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // GenerarModificacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.alta);
            this.Name = "GenerarModificacionReserva";
            this.Text = "Generar/Modificar Reserva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button modificacion;
        private System.Windows.Forms.Button alta;
    }
}