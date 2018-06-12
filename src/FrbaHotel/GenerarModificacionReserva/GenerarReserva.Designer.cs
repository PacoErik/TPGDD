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
            this.lbl_precio_base = new System.Windows.Forms.Label();
            this.lbl_recarga_estrellas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.atras_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbox_identificacion = new System.Windows.Forms.TextBox();
            this.txtbox_mail = new System.Windows.Forms.TextBox();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.lbl_error_fecha = new System.Windows.Forms.Label();
            this.txtbox_personas = new System.Windows.Forms.TextBox();
            this.lbl_error_personas = new System.Windows.Forms.Label();
            this.btn_cargar_hoteles = new System.Windows.Forms.Button();
            this.lbl_error_carga_hotel = new System.Windows.Forms.Label();
            this.grid_hoteles = new System.Windows.Forms.DataGridView();
            this.cbox_disponibles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_seleccionadas = new System.Windows.Forms.ComboBox();
            this.btn_agregar_habitacion = new System.Windows.Forms.Button();
            this.btn_eliminar_habitacion = new System.Windows.Forms.Button();
            this.cbox_tipo_identificacion = new System.Windows.Forms.ComboBox();
            this.lbl_falta_habitaciones_2 = new System.Windows.Forms.Label();
            this.lbl_falta_habitaciones_1 = new System.Windows.Forms.Label();
            this.lbl_falta_tipo_id = new System.Windows.Forms.Label();
            this.lbl_falta_id = new System.Windows.Forms.Label();
            this.lbl_falta_mail = new System.Windows.Forms.Label();
            this.lbl_id_incorrecta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // date_desde
            // 
            this.date_desde.Location = new System.Drawing.Point(12, 25);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 2;
            this.date_desde.ValueChanged += new System.EventHandler(this.date_desde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // date_hasta
            // 
            this.date_hasta.Location = new System.Drawing.Point(12, 69);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 5;
            this.date_hasta.ValueChanged += new System.EventHandler(this.date_hasta_ValueChanged);
            // 
            // cbox_regimenes
            // 
            this.cbox_regimenes.FormattingEnabled = true;
            this.cbox_regimenes.Location = new System.Drawing.Point(12, 434);
            this.cbox_regimenes.Name = "cbox_regimenes";
            this.cbox_regimenes.Size = new System.Drawing.Size(197, 21);
            this.cbox_regimenes.TabIndex = 6;
            this.cbox_regimenes.SelectedIndexChanged += new System.EventHandler(this.cbox_regimenes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Regimen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Recarga por estrellas";
            // 
            // lbl_precio_base
            // 
            this.lbl_precio_base.AutoSize = true;
            this.lbl_precio_base.Location = new System.Drawing.Point(15, 536);
            this.lbl_precio_base.Name = "lbl_precio_base";
            this.lbl_precio_base.Size = new System.Drawing.Size(35, 13);
            this.lbl_precio_base.TabIndex = 12;
            this.lbl_precio_base.Text = "label8";
            // 
            // lbl_recarga_estrellas
            // 
            this.lbl_recarga_estrellas.AutoSize = true;
            this.lbl_recarga_estrellas.Location = new System.Drawing.Point(95, 536);
            this.lbl_recarga_estrellas.Name = "lbl_recarga_estrellas";
            this.lbl_recarga_estrellas.Size = new System.Drawing.Size(35, 13);
            this.lbl_recarga_estrellas.TabIndex = 13;
            this.lbl_recarga_estrellas.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad de personas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cantidad de noches:";
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(347, 31);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(13, 13);
            this.lbl_noches.TabIndex = 21;
            this.lbl_noches.Text = "0";
            // 
            // atras_Button
            // 
            this.atras_Button.Location = new System.Drawing.Point(12, 788);
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
            this.label11.Location = new System.Drawing.Point(12, 559);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio total:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(81, 559);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(47, 13);
            this.lbl_precio.TabIndex = 24;
            this.lbl_precio.Text = "PRECIO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 588);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tipo Identificacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(153, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Identificacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 646);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mail";
            // 
            // txtbox_identificacion
            // 
            this.txtbox_identificacion.Location = new System.Drawing.Point(156, 605);
            this.txtbox_identificacion.Name = "txtbox_identificacion";
            this.txtbox_identificacion.Size = new System.Drawing.Size(176, 20);
            this.txtbox_identificacion.TabIndex = 29;
            // 
            // txtbox_mail
            // 
            this.txtbox_mail.Location = new System.Drawing.Point(58, 643);
            this.txtbox_mail.Name = "txtbox_mail";
            this.txtbox_mail.Size = new System.Drawing.Size(414, 20);
            this.txtbox_mail.TabIndex = 30;
            // 
            // btn_reservar
            // 
            this.btn_reservar.Location = new System.Drawing.Point(350, 679);
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
            this.lbl_error_fecha.Location = new System.Drawing.Point(236, 75);
            this.lbl_error_fecha.Name = "lbl_error_fecha";
            this.lbl_error_fecha.Size = new System.Drawing.Size(183, 13);
            this.lbl_error_fecha.TabIndex = 32;
            this.lbl_error_fecha.Text = "DEBE SER ALMENOS UNA NOCHE";
            // 
            // txtbox_personas
            // 
            this.txtbox_personas.Location = new System.Drawing.Point(128, 110);
            this.txtbox_personas.Name = "txtbox_personas";
            this.txtbox_personas.Size = new System.Drawing.Size(84, 20);
            this.txtbox_personas.TabIndex = 33;
            this.txtbox_personas.TextChanged += new System.EventHandler(this.txtbox_personas_TextChanged);
            // 
            // lbl_error_personas
            // 
            this.lbl_error_personas.AutoSize = true;
            this.lbl_error_personas.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_personas.Location = new System.Drawing.Point(236, 113);
            this.lbl_error_personas.Name = "lbl_error_personas";
            this.lbl_error_personas.Size = new System.Drawing.Size(111, 13);
            this.lbl_error_personas.TabIndex = 34;
            this.lbl_error_personas.Text = "ENTRADA INVALIDA";
            // 
            // btn_cargar_hoteles
            // 
            this.btn_cargar_hoteles.Location = new System.Drawing.Point(384, 103);
            this.btn_cargar_hoteles.Name = "btn_cargar_hoteles";
            this.btn_cargar_hoteles.Size = new System.Drawing.Size(116, 23);
            this.btn_cargar_hoteles.TabIndex = 35;
            this.btn_cargar_hoteles.Text = "Cargar hoteles";
            this.btn_cargar_hoteles.UseVisualStyleBackColor = true;
            this.btn_cargar_hoteles.Click += new System.EventHandler(this.btn_cargar_hoteles_Click);
            // 
            // lbl_error_carga_hotel
            // 
            this.lbl_error_carga_hotel.AutoSize = true;
            this.lbl_error_carga_hotel.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_carga_hotel.Location = new System.Drawing.Point(358, 134);
            this.lbl_error_carga_hotel.Name = "lbl_error_carga_hotel";
            this.lbl_error_carga_hotel.Size = new System.Drawing.Size(88, 13);
            this.lbl_error_carga_hotel.TabIndex = 36;
            this.lbl_error_carga_hotel.Text = "FALTAN DATOS";
            // 
            // grid_hoteles
            // 
            this.grid_hoteles.AllowUserToAddRows = false;
            this.grid_hoteles.AllowUserToDeleteRows = false;
            this.grid_hoteles.AllowUserToResizeColumns = false;
            this.grid_hoteles.AllowUserToResizeRows = false;
            this.grid_hoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_hoteles.Location = new System.Drawing.Point(12, 157);
            this.grid_hoteles.Name = "grid_hoteles";
            this.grid_hoteles.ReadOnly = true;
            this.grid_hoteles.Size = new System.Drawing.Size(488, 254);
            this.grid_hoteles.TabIndex = 37;
            this.grid_hoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hoteles_CellContentClick);
            // 
            // cbox_disponibles
            // 
            this.cbox_disponibles.FormattingEnabled = true;
            this.cbox_disponibles.Location = new System.Drawing.Point(156, 466);
            this.cbox_disponibles.Name = "cbox_disponibles";
            this.cbox_disponibles.Size = new System.Drawing.Size(275, 21);
            this.cbox_disponibles.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Habitaciones disponibles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Habitaciones seleccionadas";
            // 
            // cbox_seleccionadas
            // 
            this.cbox_seleccionadas.FormattingEnabled = true;
            this.cbox_seleccionadas.Location = new System.Drawing.Point(156, 493);
            this.cbox_seleccionadas.Name = "cbox_seleccionadas";
            this.cbox_seleccionadas.Size = new System.Drawing.Size(276, 21);
            this.cbox_seleccionadas.TabIndex = 40;
            // 
            // btn_agregar_habitacion
            // 
            this.btn_agregar_habitacion.Location = new System.Drawing.Point(437, 464);
            this.btn_agregar_habitacion.Name = "btn_agregar_habitacion";
            this.btn_agregar_habitacion.Size = new System.Drawing.Size(63, 23);
            this.btn_agregar_habitacion.TabIndex = 42;
            this.btn_agregar_habitacion.Text = "Agregar";
            this.btn_agregar_habitacion.UseVisualStyleBackColor = true;
            this.btn_agregar_habitacion.Click += new System.EventHandler(this.btn_agregar_habitacion_Click);
            // 
            // btn_eliminar_habitacion
            // 
            this.btn_eliminar_habitacion.Location = new System.Drawing.Point(438, 491);
            this.btn_eliminar_habitacion.Name = "btn_eliminar_habitacion";
            this.btn_eliminar_habitacion.Size = new System.Drawing.Size(62, 23);
            this.btn_eliminar_habitacion.TabIndex = 43;
            this.btn_eliminar_habitacion.Text = "Eliminar";
            this.btn_eliminar_habitacion.UseVisualStyleBackColor = true;
            this.btn_eliminar_habitacion.Click += new System.EventHandler(this.btn_eliminar_habitacion_Click);
            // 
            // cbox_tipo_identificacion
            // 
            this.cbox_tipo_identificacion.FormattingEnabled = true;
            this.cbox_tipo_identificacion.Location = new System.Drawing.Point(29, 605);
            this.cbox_tipo_identificacion.Name = "cbox_tipo_identificacion";
            this.cbox_tipo_identificacion.Size = new System.Drawing.Size(91, 21);
            this.cbox_tipo_identificacion.TabIndex = 28;
            // 
            // lbl_falta_habitaciones_2
            // 
            this.lbl_falta_habitaciones_2.AutoSize = true;
            this.lbl_falta_habitaciones_2.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_2.Location = new System.Drawing.Point(231, 547);
            this.lbl_falta_habitaciones_2.Name = "lbl_falta_habitaciones_2";
            this.lbl_falta_habitaciones_2.Size = new System.Drawing.Size(269, 13);
            this.lbl_falta_habitaciones_2.TabIndex = 44;
            this.lbl_falta_habitaciones_2.Text = "NO ALCANZAN PARA LA CANTIDAD DE PERSONAS";
            // 
            // lbl_falta_habitaciones_1
            // 
            this.lbl_falta_habitaciones_1.AutoSize = true;
            this.lbl_falta_habitaciones_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_1.Location = new System.Drawing.Point(231, 534);
            this.lbl_falta_habitaciones_1.Name = "lbl_falta_habitaciones_1";
            this.lbl_falta_habitaciones_1.Size = new System.Drawing.Size(201, 13);
            this.lbl_falta_habitaciones_1.TabIndex = 45;
            this.lbl_falta_habitaciones_1.Text = "LAS HABITACIONES SELECCIONADAS";
            // 
            // lbl_falta_tipo_id
            // 
            this.lbl_falta_tipo_id.AutoSize = true;
            this.lbl_falta_tipo_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_tipo_id.Location = new System.Drawing.Point(21, 684);
            this.lbl_falta_tipo_id.Name = "lbl_falta_tipo_id";
            this.lbl_falta_tipo_id.Size = new System.Drawing.Size(115, 13);
            this.lbl_falta_tipo_id.TabIndex = 46;
            this.lbl_falta_tipo_id.Text = "Falta tipo identificacion";
            // 
            // lbl_falta_id
            // 
            this.lbl_falta_id.AutoSize = true;
            this.lbl_falta_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_id.Location = new System.Drawing.Point(21, 708);
            this.lbl_falta_id.Name = "lbl_falta_id";
            this.lbl_falta_id.Size = new System.Drawing.Size(95, 13);
            this.lbl_falta_id.TabIndex = 47;
            this.lbl_falta_id.Text = "Falta identificacion";
            // 
            // lbl_falta_mail
            // 
            this.lbl_falta_mail.AutoSize = true;
            this.lbl_falta_mail.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_mail.Location = new System.Drawing.Point(21, 755);
            this.lbl_falta_mail.Name = "lbl_falta_mail";
            this.lbl_falta_mail.Size = new System.Drawing.Size(51, 13);
            this.lbl_falta_mail.TabIndex = 48;
            this.lbl_falta_mail.Text = "Falta mail";
            // 
            // lbl_id_incorrecta
            // 
            this.lbl_id_incorrecta.AutoSize = true;
            this.lbl_id_incorrecta.ForeColor = System.Drawing.Color.Red;
            this.lbl_id_incorrecta.Location = new System.Drawing.Point(21, 733);
            this.lbl_id_incorrecta.Name = "lbl_id_incorrecta";
            this.lbl_id_incorrecta.Size = new System.Drawing.Size(120, 13);
            this.lbl_id_incorrecta.TabIndex = 49;
            this.lbl_id_incorrecta.Text = "Identificacion incorrecta";
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 823);
            this.Controls.Add(this.lbl_id_incorrecta);
            this.Controls.Add(this.lbl_falta_mail);
            this.Controls.Add(this.lbl_falta_id);
            this.Controls.Add(this.lbl_falta_tipo_id);
            this.Controls.Add(this.lbl_falta_habitaciones_1);
            this.Controls.Add(this.lbl_falta_habitaciones_2);
            this.Controls.Add(this.btn_eliminar_habitacion);
            this.Controls.Add(this.btn_agregar_habitacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_seleccionadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_disponibles);
            this.Controls.Add(this.grid_hoteles);
            this.Controls.Add(this.lbl_error_carga_hotel);
            this.Controls.Add(this.btn_cargar_hoteles);
            this.Controls.Add(this.lbl_error_personas);
            this.Controls.Add(this.txtbox_personas);
            this.Controls.Add(this.lbl_error_fecha);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.txtbox_mail);
            this.Controls.Add(this.txtbox_identificacion);
            this.Controls.Add(this.cbox_tipo_identificacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.atras_Button);
            this.Controls.Add(this.lbl_noches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_recarga_estrellas);
            this.Controls.Add(this.lbl_precio_base);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_regimenes);
            this.Controls.Add(this.date_hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_desde);
            this.Name = "GenerarReserva";
            this.Text = "Generar reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_hoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbl_precio_base;
        private System.Windows.Forms.Label lbl_recarga_estrellas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_noches;
        private System.Windows.Forms.Button atras_Button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbox_identificacion;
        private System.Windows.Forms.TextBox txtbox_mail;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Label lbl_error_fecha;
        private System.Windows.Forms.TextBox txtbox_personas;
        private System.Windows.Forms.Label lbl_error_personas;
        private System.Windows.Forms.Button btn_cargar_hoteles;
        private System.Windows.Forms.Label lbl_error_carga_hotel;
        private System.Windows.Forms.DataGridView grid_hoteles;
        private System.Windows.Forms.ComboBox cbox_disponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_seleccionadas;
        private System.Windows.Forms.Button btn_agregar_habitacion;
        private System.Windows.Forms.Button btn_eliminar_habitacion;
        private System.Windows.Forms.ComboBox cbox_tipo_identificacion;
        private System.Windows.Forms.Label lbl_falta_habitaciones_2;
        private System.Windows.Forms.Label lbl_falta_habitaciones_1;
        private System.Windows.Forms.Label lbl_falta_tipo_id;
        private System.Windows.Forms.Label lbl_falta_id;
        private System.Windows.Forms.Label lbl_falta_mail;
        private System.Windows.Forms.Label lbl_id_incorrecta;
    }
}