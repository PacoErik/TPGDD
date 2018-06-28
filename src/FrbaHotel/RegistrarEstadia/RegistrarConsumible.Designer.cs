namespace FrbaHotel.RegistrarConsumible
{
    partial class RegistrarConsumible
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
            this.label1 = new System.Windows.Forms.Label();
            this.estadia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.disponibles = new System.Windows.Forms.DataGridView();
            this.elegidos = new System.Windows.Forms.DataGridView();
            this.guardar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.buttonAgregarConsumible = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonQuitarConsumible = new System.Windows.Forms.Button();
            this.habitacion = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elegidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de estadía:";
            // 
            // estadia
            // 
            this.estadia.Location = new System.Drawing.Point(129, 30);
            this.estadia.Name = "estadia";
            this.estadia.ReadOnly = true;
            this.estadia.Size = new System.Drawing.Size(100, 20);
            this.estadia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Habitación:";
            // 
            // disponibles
            // 
            this.disponibles.AllowUserToAddRows = false;
            this.disponibles.AllowUserToDeleteRows = false;
            this.disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disponibles.Location = new System.Drawing.Point(12, 154);
            this.disponibles.MultiSelect = false;
            this.disponibles.Name = "disponibles";
            this.disponibles.ReadOnly = true;
            this.disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disponibles.Size = new System.Drawing.Size(378, 160);
            this.disponibles.TabIndex = 16;
            // 
            // elegidos
            // 
            this.elegidos.AllowUserToAddRows = false;
            this.elegidos.AllowUserToDeleteRows = false;
            this.elegidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elegidos.Location = new System.Drawing.Point(392, 154);
            this.elegidos.MultiSelect = false;
            this.elegidos.Name = "elegidos";
            this.elegidos.ReadOnly = true;
            this.elegidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elegidos.Size = new System.Drawing.Size(382, 160);
            this.elegidos.TabIndex = 18;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(699, 374);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 20;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(12, 374);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 22;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // buttonAgregarConsumible
            // 
            this.buttonAgregarConsumible.Location = new System.Drawing.Point(42, 320);
            this.buttonAgregarConsumible.Name = "buttonAgregarConsumible";
            this.buttonAgregarConsumible.Size = new System.Drawing.Size(118, 23);
            this.buttonAgregarConsumible.TabIndex = 24;
            this.buttonAgregarConsumible.Text = "Agregar consumible";
            this.buttonAgregarConsumible.UseVisualStyleBackColor = true;
            this.buttonAgregarConsumible.Click += new System.EventHandler(this.buttonAgregarConsumible_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Consumibles elegidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Consumibles disponibles:";
            // 
            // buttonQuitarConsumible
            // 
            this.buttonQuitarConsumible.Location = new System.Drawing.Point(412, 320);
            this.buttonQuitarConsumible.Name = "buttonQuitarConsumible";
            this.buttonQuitarConsumible.Size = new System.Drawing.Size(118, 23);
            this.buttonQuitarConsumible.TabIndex = 25;
            this.buttonQuitarConsumible.Text = "Quitar consumible";
            this.buttonQuitarConsumible.UseVisualStyleBackColor = true;
            this.buttonQuitarConsumible.Click += new System.EventHandler(this.buttonQuitarConsumible_Click);
            // 
            // habitacion
            // 
            this.habitacion.Location = new System.Drawing.Point(129, 57);
            this.habitacion.Name = "habitacion";
            this.habitacion.ReadOnly = true;
            this.habitacion.Size = new System.Drawing.Size(100, 20);
            this.habitacion.TabIndex = 26;
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(129, 84);
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Size = new System.Drawing.Size(100, 20);
            this.piso.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Piso:";
            // 
            // RegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.buttonQuitarConsumible);
            this.Controls.Add(this.buttonAgregarConsumible);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.elegidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.disponibles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.estadia);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarConsumible";
            this.Text = "Registrar consumible";
            ((System.ComponentModel.ISupportInitialize)(this.disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elegidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox estadia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView disponibles;
        private System.Windows.Forms.DataGridView elegidos;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button buttonAgregarConsumible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonQuitarConsumible;
        private System.Windows.Forms.TextBox habitacion;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.Label label3;
    }
}