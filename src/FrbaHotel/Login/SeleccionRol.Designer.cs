namespace FrbaHotel.Login
{
    partial class SeleccionRol
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
            this.Entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.RolXHotel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RolXHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(296, 242);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 2;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseMnemonic = false;
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un rol de la tabla:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(38, 242);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseMnemonic = false;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // RolXHotel
            // 
            this.RolXHotel.AllowUserToAddRows = false;
            this.RolXHotel.AllowUserToDeleteRows = false;
            this.RolXHotel.AllowUserToOrderColumns = true;
            this.RolXHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RolXHotel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RolXHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolXHotel.Location = new System.Drawing.Point(12, 38);
            this.RolXHotel.MultiSelect = false;
            this.RolXHotel.Name = "RolXHotel";
            this.RolXHotel.ReadOnly = true;
            this.RolXHotel.RowTemplate.ReadOnly = true;
            this.RolXHotel.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RolXHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RolXHotel.Size = new System.Drawing.Size(386, 180);
            this.RolXHotel.TabIndex = 4;
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 289);
            this.Controls.Add(this.RolXHotel);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRol";
            this.Text = "Seleccion de rol";
            this.Load += new System.EventHandler(this.SeleccionRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolXHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView RolXHotel;
    }
}