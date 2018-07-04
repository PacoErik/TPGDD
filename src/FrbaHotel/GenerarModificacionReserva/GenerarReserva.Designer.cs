namespace FrbaHotel.GenerarModificacionReserva
{
    partial class GenerarReserva
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
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.cbox_regimenes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.atras_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.lbl_error_fecha = new System.Windows.Forms.Label();
            this.lbl_error_personas = new System.Windows.Forms.Label();
            this.btn_cargar_opciones = new System.Windows.Forms.Button();
            this.lbl_error_carga_hotel = new System.Windows.Forms.Label();
            this.cbox_disponibles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_seleccionadas = new System.Windows.Forms.ComboBox();
            this.btn_agregar_habitacion = new System.Windows.Forms.Button();
            this.btn_eliminar_habitacion = new System.Windows.Forms.Button();
            this.lbl_falta_habitaciones_2 = new System.Windows.Forms.Label();
            this.lbl_falta_habitaciones_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.recarga_por_estrellas = new System.Windows.Forms.TextBox();
            this.precio_total = new System.Windows.Forms.TextBox();
            this.precio_base = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clie_mail = new System.Windows.Forms.TextBox();
            this.clie_apellido = new System.Windows.Forms.TextBox();
            this.clie_nombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.labelHotelCerrado = new System.Windows.Forms.Label();
            this.numericUpDownPersonas = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // date_desde
            // 
            this.date_desde.Location = new System.Drawing.Point(9, 32);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 2;
            this.date_desde.ValueChanged += new System.EventHandler(this.date_desde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // date_hasta
            // 
            this.date_hasta.Location = new System.Drawing.Point(9, 76);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 5;
            this.date_hasta.ValueChanged += new System.EventHandler(this.date_hasta_ValueChanged);
            // 
            // cbox_regimenes
            // 
            this.cbox_regimenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_regimenes.FormattingEnabled = true;
            this.cbox_regimenes.Location = new System.Drawing.Point(9, 164);
            this.cbox_regimenes.Name = "cbox_regimenes";
            this.cbox_regimenes.Size = new System.Drawing.Size(197, 21);
            this.cbox_regimenes.TabIndex = 6;
            this.cbox_regimenes.SelectedIndexChanged += new System.EventHandler(this.cbox_regimenes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Regimen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio base (Régimen)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Recarga por estrellas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad de personas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cantidad de noches:";
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(344, 38);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(13, 13);
            this.lbl_noches.TabIndex = 21;
            this.lbl_noches.Text = "0";
            // 
            // atras_Button
            // 
            this.atras_Button.Location = new System.Drawing.Point(9, 525);
            this.atras_Button.Name = "atras_Button";
            this.atras_Button.Size = new System.Drawing.Size(75, 23);
            this.atras_Button.TabIndex = 22;
            this.atras_Button.Text = "Atras";
            this.atras_Button.UseVisualStyleBackColor = true;
            this.atras_Button.Click += new System.EventHandler(this.atras_Button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio total:";
            // 
            // btn_reservar
            // 
            this.btn_reservar.Location = new System.Drawing.Point(359, 525);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(150, 23);
            this.btn_reservar.TabIndex = 31;
            this.btn_reservar.Text = "Generar Reserva";
            this.btn_reservar.UseVisualStyleBackColor = true;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // lbl_error_fecha
            // 
            this.lbl_error_fecha.AutoSize = true;
            this.lbl_error_fecha.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_fecha.Location = new System.Drawing.Point(233, 59);
            this.lbl_error_fecha.Name = "lbl_error_fecha";
            this.lbl_error_fecha.Size = new System.Drawing.Size(183, 13);
            this.lbl_error_fecha.TabIndex = 32;
            this.lbl_error_fecha.Text = "DEBE SER ALMENOS UNA NOCHE";
            // 
            // lbl_error_personas
            // 
            this.lbl_error_personas.AutoSize = true;
            this.lbl_error_personas.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_personas.Location = new System.Drawing.Point(122, 140);
            this.lbl_error_personas.Name = "lbl_error_personas";
            this.lbl_error_personas.Size = new System.Drawing.Size(171, 13);
            this.lbl_error_personas.TabIndex = 34;
            this.lbl_error_personas.Text = "LA CANTIDAD NO PUEDE SER 0";
            // 
            // btn_cargar_opciones
            // 
            this.btn_cargar_opciones.Location = new System.Drawing.Point(372, 110);
            this.btn_cargar_opciones.Name = "btn_cargar_opciones";
            this.btn_cargar_opciones.Size = new System.Drawing.Size(116, 23);
            this.btn_cargar_opciones.TabIndex = 35;
            this.btn_cargar_opciones.Text = "Cargar opciones";
            this.btn_cargar_opciones.UseVisualStyleBackColor = true;
            this.btn_cargar_opciones.Click += new System.EventHandler(this.btn_cargar_opciones_Click);
            // 
            // lbl_error_carga_hotel
            // 
            this.lbl_error_carga_hotel.AutoSize = true;
            this.lbl_error_carga_hotel.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_carga_hotel.Location = new System.Drawing.Point(328, 172);
            this.lbl_error_carga_hotel.Name = "lbl_error_carga_hotel";
            this.lbl_error_carga_hotel.Size = new System.Drawing.Size(88, 13);
            this.lbl_error_carga_hotel.TabIndex = 36;
            this.lbl_error_carga_hotel.Text = "FALTAN DATOS";
            // 
            // cbox_disponibles
            // 
            this.cbox_disponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_disponibles.Enabled = false;
            this.cbox_disponibles.FormattingEnabled = true;
            this.cbox_disponibles.Location = new System.Drawing.Point(145, 20);
            this.cbox_disponibles.Name = "cbox_disponibles";
            this.cbox_disponibles.Size = new System.Drawing.Size(275, 21);
            this.cbox_disponibles.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Habitaciones disponibles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Habitaciones seleccionadas";
            // 
            // cbox_seleccionadas
            // 
            this.cbox_seleccionadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_seleccionadas.Enabled = false;
            this.cbox_seleccionadas.FormattingEnabled = true;
            this.cbox_seleccionadas.Location = new System.Drawing.Point(145, 47);
            this.cbox_seleccionadas.Name = "cbox_seleccionadas";
            this.cbox_seleccionadas.Size = new System.Drawing.Size(276, 21);
            this.cbox_seleccionadas.TabIndex = 40;
            // 
            // btn_agregar_habitacion
            // 
            this.btn_agregar_habitacion.Enabled = false;
            this.btn_agregar_habitacion.Location = new System.Drawing.Point(426, 18);
            this.btn_agregar_habitacion.Name = "btn_agregar_habitacion";
            this.btn_agregar_habitacion.Size = new System.Drawing.Size(63, 23);
            this.btn_agregar_habitacion.TabIndex = 42;
            this.btn_agregar_habitacion.Text = "Agregar";
            this.btn_agregar_habitacion.UseVisualStyleBackColor = true;
            this.btn_agregar_habitacion.Click += new System.EventHandler(this.btn_agregar_habitacion_Click);
            // 
            // btn_eliminar_habitacion
            // 
            this.btn_eliminar_habitacion.Enabled = false;
            this.btn_eliminar_habitacion.Location = new System.Drawing.Point(427, 45);
            this.btn_eliminar_habitacion.Name = "btn_eliminar_habitacion";
            this.btn_eliminar_habitacion.Size = new System.Drawing.Size(62, 23);
            this.btn_eliminar_habitacion.TabIndex = 43;
            this.btn_eliminar_habitacion.Text = "Eliminar";
            this.btn_eliminar_habitacion.UseVisualStyleBackColor = true;
            this.btn_eliminar_habitacion.Click += new System.EventHandler(this.btn_eliminar_habitacion_Click);
            // 
            // lbl_falta_habitaciones_2
            // 
            this.lbl_falta_habitaciones_2.AutoSize = true;
            this.lbl_falta_habitaciones_2.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_2.Location = new System.Drawing.Point(204, 82);
            this.lbl_falta_habitaciones_2.Name = "lbl_falta_habitaciones_2";
            this.lbl_falta_habitaciones_2.Size = new System.Drawing.Size(269, 13);
            this.lbl_falta_habitaciones_2.TabIndex = 44;
            this.lbl_falta_habitaciones_2.Text = "NO ALCANZAN PARA LA CANTIDAD DE PERSONAS";
            // 
            // lbl_falta_habitaciones_1
            // 
            this.lbl_falta_habitaciones_1.AutoSize = true;
            this.lbl_falta_habitaciones_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_1.Location = new System.Drawing.Point(6, 82);
            this.lbl_falta_habitaciones_1.Name = "lbl_falta_habitaciones_1";
            this.lbl_falta_habitaciones_1.Size = new System.Drawing.Size(201, 13);
            this.lbl_falta_habitaciones_1.TabIndex = 45;
            this.lbl_falta_habitaciones_1.Text = "LAS HABITACIONES SELECCIONADAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPersonas);
            this.groupBox1.Controls.Add(this.labelHotelCerrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_hasta);
            this.groupBox1.Controls.Add(this.cbox_regimenes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_noches);
            this.groupBox1.Controls.Add(this.lbl_error_carga_hotel);
            this.groupBox1.Controls.Add(this.lbl_error_fecha);
            this.groupBox1.Controls.Add(this.btn_cargar_opciones);
            this.groupBox1.Controls.Add(this.lbl_error_personas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 213);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de reserva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbox_disponibles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_falta_habitaciones_2);
            this.groupBox2.Controls.Add(this.lbl_falta_habitaciones_1);
            this.groupBox2.Controls.Add(this.cbox_seleccionadas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_eliminar_habitacion);
            this.groupBox2.Controls.Add(this.btn_agregar_habitacion);
            this.groupBox2.Location = new System.Drawing.Point(9, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 107);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección de habitaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.recarga_por_estrellas);
            this.groupBox3.Controls.Add(this.precio_total);
            this.groupBox3.Controls.Add(this.precio_base);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 79);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costo de alojamiento";
            // 
            // recarga_por_estrellas
            // 
            this.recarga_por_estrellas.Location = new System.Drawing.Point(122, 51);
            this.recarga_por_estrellas.Name = "recarga_por_estrellas";
            this.recarga_por_estrellas.ReadOnly = true;
            this.recarga_por_estrellas.Size = new System.Drawing.Size(100, 20);
            this.recarga_por_estrellas.TabIndex = 26;
            // 
            // precio_total
            // 
            this.precio_total.Location = new System.Drawing.Point(344, 36);
            this.precio_total.Name = "precio_total";
            this.precio_total.ReadOnly = true;
            this.precio_total.Size = new System.Drawing.Size(100, 20);
            this.precio_total.TabIndex = 25;
            // 
            // precio_base
            // 
            this.precio_base.Location = new System.Drawing.Point(122, 25);
            this.precio_base.Name = "precio_base";
            this.precio_base.ReadOnly = true;
            this.precio_base.Size = new System.Drawing.Size(100, 20);
            this.precio_base.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.clie_mail);
            this.groupBox4.Controls.Add(this.clie_apellido);
            this.groupBox4.Controls.Add(this.clie_nombre);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 90);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Elegir cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clie_mail
            // 
            this.clie_mail.Location = new System.Drawing.Point(65, 64);
            this.clie_mail.Name = "clie_mail";
            this.clie_mail.ReadOnly = true;
            this.clie_mail.Size = new System.Drawing.Size(188, 20);
            this.clie_mail.TabIndex = 5;
            // 
            // clie_apellido
            // 
            this.clie_apellido.Location = new System.Drawing.Point(65, 39);
            this.clie_apellido.Name = "clie_apellido";
            this.clie_apellido.ReadOnly = true;
            this.clie_apellido.Size = new System.Drawing.Size(188, 20);
            this.clie_apellido.TabIndex = 4;
            // 
            // clie_nombre
            // 
            this.clie_nombre.Location = new System.Drawing.Point(65, 13);
            this.clie_nombre.Name = "clie_nombre";
            this.clie_nombre.ReadOnly = true;
            this.clie_nombre.Size = new System.Drawing.Size(188, 20);
            this.clie_nombre.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre:";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(190, 525);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 50;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // labelHotelCerrado
            // 
            this.labelHotelCerrado.AutoSize = true;
            this.labelHotelCerrado.ForeColor = System.Drawing.Color.Red;
            this.labelHotelCerrado.Location = new System.Drawing.Point(233, 83);
            this.labelHotelCerrado.Name = "labelHotelCerrado";
            this.labelHotelCerrado.Size = new System.Drawing.Size(201, 13);
            this.labelHotelCerrado.TabIndex = 100;
            this.labelHotelCerrado.Text = "HOTEL CERRADO POR ESAS FECHAS";
            this.labelHotelCerrado.Visible = false;
            // 
            // numericUpDownPersonas
            // 
            this.numericUpDownPersonas.Location = new System.Drawing.Point(122, 118);
            this.numericUpDownPersonas.Name = "numericUpDownPersonas";
            this.numericUpDownPersonas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPersonas.TabIndex = 101;
            this.numericUpDownPersonas.ValueChanged += new System.EventHandler(this.numericUpDownPersonas_ValueChanged);
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 560);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.atras_Button);
            this.Name = "GenerarReserva";
            this.Text = "Generar reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.ComboBox cbox_regimenes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_noches;
        private System.Windows.Forms.Button atras_Button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Label lbl_error_fecha;
        private System.Windows.Forms.Label lbl_error_personas;
        private System.Windows.Forms.Button btn_cargar_opciones;
        private System.Windows.Forms.Label lbl_error_carga_hotel;
        private System.Windows.Forms.ComboBox cbox_disponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_seleccionadas;
        private System.Windows.Forms.Button btn_agregar_habitacion;
        private System.Windows.Forms.Button btn_eliminar_habitacion;
        private System.Windows.Forms.Label lbl_falta_habitaciones_2;
        private System.Windows.Forms.Label lbl_falta_habitaciones_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clie_mail;
        private System.Windows.Forms.TextBox clie_apellido;
        private System.Windows.Forms.TextBox clie_nombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox recarga_por_estrellas;
        private System.Windows.Forms.TextBox precio_total;
        private System.Windows.Forms.TextBox precio_base;
        private System.Windows.Forms.Label labelHotelCerrado;
        private System.Windows.Forms.NumericUpDown numericUpDownPersonas;
    }
}