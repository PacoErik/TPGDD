namespace FrbaHotel.AbmHotel
{
    partial class AbmHotel
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
            this.buttonModificarHotel = new System.Windows.Forms.Button();
            this.buttonBajaHotel = new System.Windows.Forms.Button();
            this.alta = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewHoteles = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificarHotel
            // 
            this.buttonModificarHotel.Enabled = false;
            this.buttonModificarHotel.Location = new System.Drawing.Point(96, 533);
            this.buttonModificarHotel.Name = "buttonModificarHotel";
            this.buttonModificarHotel.Size = new System.Drawing.Size(141, 23);
            this.buttonModificarHotel.TabIndex = 7;
            this.buttonModificarHotel.Text = "Modificar hotel";
            this.buttonModificarHotel.UseVisualStyleBackColor = true;
            this.buttonModificarHotel.Click += new System.EventHandler(this.buttonModificarHotel_Click);
            // 
            // buttonBajaHotel
            // 
            this.buttonBajaHotel.Enabled = false;
            this.buttonBajaHotel.Location = new System.Drawing.Point(274, 533);
            this.buttonBajaHotel.Name = "buttonBajaHotel";
            this.buttonBajaHotel.Size = new System.Drawing.Size(141, 23);
            this.buttonBajaHotel.TabIndex = 6;
            this.buttonBajaHotel.Text = "Baja de hotel";
            this.buttonBajaHotel.UseVisualStyleBackColor = true;
            this.buttonBajaHotel.Click += new System.EventHandler(this.buttonBajaHotel_Click);
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(332, 568);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(141, 23);
            this.alta.TabIndex = 5;
            this.alta.Text = "Alta de hotel";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(34, 568);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 9;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Pais:";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(283, 92);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(190, 20);
            this.textBoxPais.TabIndex = 64;
            // 
            // comboBoxEstrellas
            // 
            this.comboBoxEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstrellas.Location = new System.Drawing.Point(283, 37);
            this.comboBoxEstrellas.Name = "comboBoxEstrellas";
            this.comboBoxEstrellas.Size = new System.Drawing.Size(190, 21);
            this.comboBoxEstrellas.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cantidad de estrellas:";
            // 
            // dataGridViewHoteles
            // 
            this.dataGridViewHoteles.AllowUserToAddRows = false;
            this.dataGridViewHoteles.AllowUserToDeleteRows = false;
            this.dataGridViewHoteles.AllowUserToOrderColumns = true;
            this.dataGridViewHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteles.Location = new System.Drawing.Point(22, 182);
            this.dataGridViewHoteles.MultiSelect = false;
            this.dataGridViewHoteles.Name = "dataGridViewHoteles";
            this.dataGridViewHoteles.ReadOnly = true;
            this.dataGridViewHoteles.RowTemplate.ReadOnly = true;
            this.dataGridViewHoteles.Size = new System.Drawing.Size(476, 338);
            this.dataGridViewHoteles.TabIndex = 58;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(68, 153);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 57;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ciudad:";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(47, 91);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(190, 20);
            this.textBoxCiudad.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(47, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(190, 20);
            this.textBoxNombre.TabIndex = 53;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(373, 153);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 52;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // AbmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 603);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.comboBoxEstrellas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewHoteles);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonModificarHotel);
            this.Controls.Add(this.buttonBajaHotel);
            this.Controls.Add(this.alta);
            this.Name = "AbmHotel";
            this.Text = "ABM de Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificarHotel;
        private System.Windows.Forms.Button buttonBajaHotel;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewHoteles;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonBuscar;
    }
}