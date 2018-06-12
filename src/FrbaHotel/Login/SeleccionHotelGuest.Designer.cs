namespace FrbaHotel.Login
{
    partial class SeleccionHotelGuest
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
            this.hoteles = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un hotel:";
            // 
            // hoteles
            // 
            this.hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoteles.Location = new System.Drawing.Point(41, 41);
            this.hoteles.Name = "hoteles";
            this.hoteles.Size = new System.Drawing.Size(328, 205);
            this.hoteles.TabIndex = 1;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(41, 280);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(294, 280);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 3;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // SeleccionHotelGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 317);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.hoteles);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionHotelGuest";
            this.Text = "Selección de hotel (GUEST)";
            ((System.ComponentModel.ISupportInitialize)(this.hoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hoteles;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button entrar;
    }
}