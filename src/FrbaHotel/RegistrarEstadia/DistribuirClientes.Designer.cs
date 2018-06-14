namespace FrbaHotel.RegistrarEstadia
{
    partial class DistribuirClientes
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
            this.habitaciones = new System.Windows.Forms.ComboBox();
            this.clientes = new System.Windows.Forms.DataGridView();
            this.asignar = new System.Windows.Forms.Button();
            this.distribucion = new System.Windows.Forms.DataGridView();
            this.volver = new System.Windows.Forms.Button();
            this.finalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitación candidata:";
            // 
            // habitaciones
            // 
            this.habitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.habitaciones.FormattingEnabled = true;
            this.habitaciones.Location = new System.Drawing.Point(364, 31);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(121, 21);
            this.habitaciones.TabIndex = 1;
            // 
            // clientes
            // 
            this.clientes.AllowUserToAddRows = false;
            this.clientes.AllowUserToDeleteRows = false;
            this.clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes.Location = new System.Drawing.Point(26, 70);
            this.clientes.Name = "clientes";
            this.clientes.ReadOnly = true;
            this.clientes.Size = new System.Drawing.Size(332, 150);
            this.clientes.TabIndex = 2;
            this.clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // asignar
            // 
            this.asignar.Location = new System.Drawing.Point(364, 129);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(75, 23);
            this.asignar.TabIndex = 3;
            this.asignar.Text = "Asignar";
            this.asignar.UseVisualStyleBackColor = true;
            this.asignar.Click += new System.EventHandler(this.asignar_Click);
            // 
            // distribucion
            // 
            this.distribucion.AllowUserToAddRows = false;
            this.distribucion.AllowUserToDeleteRows = false;
            this.distribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distribucion.Location = new System.Drawing.Point(445, 70);
            this.distribucion.Name = "distribucion";
            this.distribucion.ReadOnly = true;
            this.distribucion.Size = new System.Drawing.Size(480, 150);
            this.distribucion.TabIndex = 4;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(26, 237);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 5;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(656, 237);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(75, 23);
            this.finalizar.TabIndex = 6;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // DistribuirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 272);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.distribucion);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.habitaciones);
            this.Controls.Add(this.label1);
            this.Name = "DistribuirClientes";
            this.Text = "Distribuir clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox habitaciones;
        private System.Windows.Forms.DataGridView clientes;
        private System.Windows.Forms.Button asignar;
        private System.Windows.Forms.DataGridView distribucion;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button finalizar;
    }
}