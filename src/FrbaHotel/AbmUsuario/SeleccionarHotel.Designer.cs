namespace FrbaHotel.AbmUsuario
{
    partial class SeleccionarHotel
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
            this.Hoteles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // Hoteles
            // 
            this.Hoteles.AllowUserToAddRows = false;
            this.Hoteles.AllowUserToDeleteRows = false;
            this.Hoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Hoteles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hoteles.Location = new System.Drawing.Point(12, 12);
            this.Hoteles.Name = "Hoteles";
            this.Hoteles.ReadOnly = true;
            this.Hoteles.RowTemplate.ReadOnly = true;
            this.Hoteles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hoteles.Size = new System.Drawing.Size(479, 425);
            this.Hoteles.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hoteles);
            this.Name = "SeleccionarHotel";
            this.Text = "SeleccionarHotel";
            ((System.ComponentModel.ISupportInitialize)(this.Hoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Hoteles;
        private System.Windows.Forms.Button button1;
    }
}