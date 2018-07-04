namespace FrbaHotel.RegistrarEstadia
{
    partial class ElegirClientes
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
            this.reservaElegida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadDePersonas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.responsable = new System.Windows.Forms.TextBox();
            this.clientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.continuar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva:";
            // 
            // reservaElegida
            // 
            this.reservaElegida.Location = new System.Drawing.Point(77, 10);
            this.reservaElegida.Name = "reservaElegida";
            this.reservaElegida.ReadOnly = true;
            this.reservaElegida.Size = new System.Drawing.Size(100, 20);
            this.reservaElegida.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de personas:";
            // 
            // cantidadDePersonas
            // 
            this.cantidadDePersonas.Location = new System.Drawing.Point(135, 39);
            this.cantidadDePersonas.Name = "cantidadDePersonas";
            this.cantidadDePersonas.ReadOnly = true;
            this.cantidadDePersonas.Size = new System.Drawing.Size(42, 20);
            this.cantidadDePersonas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Responsable:";
            // 
            // responsable
            // 
            this.responsable.Location = new System.Drawing.Point(94, 71);
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            this.responsable.Size = new System.Drawing.Size(178, 20);
            this.responsable.TabIndex = 5;
            // 
            // clientes
            // 
            this.clientes.AllowUserToAddRows = false;
            this.clientes.AllowUserToDeleteRows = false;
            this.clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes.Location = new System.Drawing.Point(19, 122);
            this.clientes.MultiSelect = false;
            this.clientes.Name = "clientes";
            this.clientes.ReadOnly = true;
            this.clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientes.Size = new System.Drawing.Size(474, 182);
            this.clientes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Acompañantes:";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(19, 320);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 8;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(320, 39);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(148, 34);
            this.agregar.TabIndex = 9;
            this.agregar.Text = "Agregar cliente";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(418, 320);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(75, 23);
            this.continuar.TabIndex = 10;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(218, 320);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar cliente";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ElegirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidadDePersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservaElegida);
            this.Controls.Add(this.label1);
            this.Name = "ElegirClientes";
            this.Text = "Elegir clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reservaElegida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadDePersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox responsable;
        private System.Windows.Forms.DataGridView clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}