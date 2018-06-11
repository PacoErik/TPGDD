namespace FrbaHotel.AbmHabitacion
{
    partial class AbmHabitacion
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
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.Hoteles = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(307, 464);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 8;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // Hoteles
            // 
            this.Hoteles.AllowUserToAddRows = false;
            this.Hoteles.AllowUserToDeleteRows = false;
            this.Hoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Hoteles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hoteles.Location = new System.Drawing.Point(12, 12);
            this.Hoteles.MultiSelect = false;
            this.Hoteles.Name = "Hoteles";
            this.Hoteles.ReadOnly = true;
            this.Hoteles.RowTemplate.ReadOnly = true;
            this.Hoteles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hoteles.Size = new System.Drawing.Size(479, 425);
            this.Hoteles.TabIndex = 7;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(99, 464);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // AbmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 495);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.Hoteles);
            this.Name = "AbmHabitacion";
            this.Text = "ABM de Habitación";
            ((System.ComponentModel.ISupportInitialize)(this.Hoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.DataGridView Hoteles;
        private System.Windows.Forms.Button buttonVolver;

    }
}