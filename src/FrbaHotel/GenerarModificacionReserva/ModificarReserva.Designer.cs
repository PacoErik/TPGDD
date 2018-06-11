namespace FrbaHotel.GenerarModificacionReserva
{
    partial class ModificarReserva
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
            this.txtbox_codigo = new System.Windows.Forms.TextBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox_personas = new System.Windows.Forms.ComboBox();
            this.cbox_tipos_habitacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_recarga_estrellas = new System.Windows.Forms.Label();
            this.lbl_precio_base = new System.Windows.Forms.Label();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_regimenes = new System.Windows.Forms.ComboBox();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.cbox_hoteles = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_cargarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de reserva";
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(16, 30);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(269, 20);
            this.txtbox_codigo.TabIndex = 1;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(16, 378);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(417, 28);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(85, 343);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(47, 13);
            this.lbl_precio.TabIndex = 46;
            this.lbl_precio.Text = "PRECIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Precio total:";
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(127, 169);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(13, 13);
            this.lbl_noches.TabIndex = 44;
            this.lbl_noches.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad de noches:";
            // 
            // cbox_personas
            // 
            this.cbox_personas.FormattingEnabled = true;
            this.cbox_personas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbox_personas.Location = new System.Drawing.Point(351, 88);
            this.cbox_personas.Name = "cbox_personas";
            this.cbox_personas.Size = new System.Drawing.Size(141, 21);
            this.cbox_personas.TabIndex = 42;
            // 
            // cbox_tipos_habitacion
            // 
            this.cbox_tipos_habitacion.FormattingEnabled = true;
            this.cbox_tipos_habitacion.Location = new System.Drawing.Point(351, 132);
            this.cbox_tipos_habitacion.Name = "cbox_tipos_habitacion";
            this.cbox_tipos_habitacion.Size = new System.Drawing.Size(141, 21);
            this.cbox_tipos_habitacion.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tipo de habitacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cantidad de personas";
            // 
            // lbl_recarga_estrellas
            // 
            this.lbl_recarga_estrellas.AutoSize = true;
            this.lbl_recarga_estrellas.Location = new System.Drawing.Point(305, 310);
            this.lbl_recarga_estrellas.Name = "lbl_recarga_estrellas";
            this.lbl_recarga_estrellas.Size = new System.Drawing.Size(35, 13);
            this.lbl_recarga_estrellas.TabIndex = 38;
            this.lbl_recarga_estrellas.Text = "label9";
            // 
            // lbl_precio_base
            // 
            this.lbl_precio_base.AutoSize = true;
            this.lbl_precio_base.Location = new System.Drawing.Point(225, 310);
            this.lbl_precio_base.Name = "lbl_precio_base";
            this.lbl_precio_base.Size = new System.Drawing.Size(35, 13);
            this.lbl_precio_base.TabIndex = 37;
            this.lbl_precio_base.Text = "label8";
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(384, 237);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(81, 13);
            this.lbl_estrellas.TabIndex = 36;
            this.lbl_estrellas.Text = "<ESTRELLAS>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Estrellas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Recarga por estrellas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Precio base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Regimen";
            // 
            // cbox_regimenes
            // 
            this.cbox_regimenes.FormattingEnabled = true;
            this.cbox_regimenes.Location = new System.Drawing.Point(19, 290);
            this.cbox_regimenes.Name = "cbox_regimenes";
            this.cbox_regimenes.Size = new System.Drawing.Size(197, 21);
            this.cbox_regimenes.TabIndex = 31;
            // 
            // date_hasta
            // 
            this.date_hasta.Location = new System.Drawing.Point(16, 132);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Desde";
            // 
            // date_desde
            // 
            this.date_desde.Location = new System.Drawing.Point(16, 88);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 27;
            // 
            // cbox_hoteles
            // 
            this.cbox_hoteles.FormattingEnabled = true;
            this.cbox_hoteles.Location = new System.Drawing.Point(19, 237);
            this.cbox_hoteles.Name = "cbox_hoteles";
            this.cbox_hoteles.Size = new System.Drawing.Size(292, 21);
            this.cbox_hoteles.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Hotel";
            // 
            // btn_cargarReserva
            // 
            this.btn_cargarReserva.Location = new System.Drawing.Point(291, 28);
            this.btn_cargarReserva.Name = "btn_cargarReserva";
            this.btn_cargarReserva.Size = new System.Drawing.Size(121, 23);
            this.btn_cargarReserva.TabIndex = 47;
            this.btn_cargarReserva.Text = "Cargar reserva";
            this.btn_cargarReserva.UseVisualStyleBackColor = true;
            this.btn_cargarReserva.Click += new System.EventHandler(this.btn_cargarReserva_Click);
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 417);
            this.Controls.Add(this.btn_cargarReserva);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_noches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbox_personas);
            this.Controls.Add(this.cbox_tipos_habitacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_recarga_estrellas);
            this.Controls.Add(this.lbl_precio_base);
            this.Controls.Add(this.lbl_estrellas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_regimenes);
            this.Controls.Add(this.date_hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_desde);
            this.Controls.Add(this.cbox_hoteles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.txtbox_codigo);
            this.Controls.Add(this.label1);
            this.Name = "ModificarReserva";
            this.Text = "ModificarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_noches;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbox_personas;
        private System.Windows.Forms.ComboBox cbox_tipos_habitacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_recarga_estrellas;
        private System.Windows.Forms.Label lbl_precio_base;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_regimenes;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.ComboBox cbox_hoteles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_cargarReserva;
    }
}