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
            this.piso = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.habitaciones = new System.Windows.Forms.DataGridView();
            this.volver = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(132, 60);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(47, 20);
            this.piso.TabIndex = 33;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(132, 30);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(47, 20);
            this.numero.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Número de piso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Número de habitación:";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(200, 42);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 34;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // habitaciones
            // 
            this.habitaciones.AllowUserToAddRows = false;
            this.habitaciones.AllowUserToDeleteRows = false;
            this.habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitaciones.Location = new System.Drawing.Point(50, 97);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.ReadOnly = true;
            this.habitaciones.Size = new System.Drawing.Size(236, 141);
            this.habitaciones.TabIndex = 35;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(13, 256);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 36;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(188, 256);
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
            this.Controls.Add(this.volver);
            this.Controls.Add(this.habitaciones);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ElegirHabitacion";
            this.Text = "Elija la habitación";
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView habitaciones;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button agregar;

    }
}