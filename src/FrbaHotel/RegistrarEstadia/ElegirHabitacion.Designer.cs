namespace FrbaHotel.RegistrarConsumible
{
    partial class ElegirHabitacion
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
            this.habitaciones = new System.Windows.Forms.DataGridView();
            this.finalizar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // habitaciones
            // 
            this.habitaciones.AllowUserToAddRows = false;
            this.habitaciones.AllowUserToDeleteRows = false;
            this.habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitaciones.Location = new System.Drawing.Point(48, 57);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.ReadOnly = true;
            this.habitaciones.Size = new System.Drawing.Size(236, 174);
            this.habitaciones.TabIndex = 35;
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(106, 247);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(119, 40);
            this.finalizar.TabIndex = 36;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.volver_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(97, 28);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(138, 23);
            this.agregar.TabIndex = 37;
            this.agregar.Text = "Agregar consumibles";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // ElegirHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 299);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.habitaciones);
            this.Name = "ElegirHabitacion";
            this.Text = "Elija la habitación";
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView habitaciones;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Button agregar;

    }
}