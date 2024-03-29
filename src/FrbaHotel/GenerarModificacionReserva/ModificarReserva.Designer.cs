﻿namespace FrbaHotel.GenerarModificacionReserva
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
            this.lbl_falta_habitaciones_1 = new System.Windows.Forms.Label();
            this.lbl_falta_habitaciones_2 = new System.Windows.Forms.Label();
            this.btn_eliminar_habitacion = new System.Windows.Forms.Button();
            this.btn_agregar_habitacion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_seleccionadas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_disponibles = new System.Windows.Forms.ComboBox();
            this.lbl_error_carga_hotel = new System.Windows.Forms.Label();
            this.lbl_error_fecha = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.atras_Button = new System.Windows.Forms.Button();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_regimenes = new System.Windows.Forms.ComboBox();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_codigo = new System.Windows.Forms.TextBox();
            this.btn_cargar_reserva = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbox_reserva = new System.Windows.Forms.TextBox();
            this.lbl_cargado_correcto = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxRecarga = new System.Windows.Forms.TextBox();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.labelHotelCerrado = new System.Windows.Forms.Label();
            this.label0Personas = new System.Windows.Forms.Label();
            this.labelReservaYaExistente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_falta_habitaciones_1
            // 
            this.lbl_falta_habitaciones_1.AutoSize = true;
            this.lbl_falta_habitaciones_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_1.Location = new System.Drawing.Point(240, 380);
            this.lbl_falta_habitaciones_1.Name = "lbl_falta_habitaciones_1";
            this.lbl_falta_habitaciones_1.Size = new System.Drawing.Size(201, 13);
            this.lbl_falta_habitaciones_1.TabIndex = 85;
            this.lbl_falta_habitaciones_1.Text = "LAS HABITACIONES SELECCIONADAS";
            this.lbl_falta_habitaciones_1.Visible = false;
            // 
            // lbl_falta_habitaciones_2
            // 
            this.lbl_falta_habitaciones_2.AutoSize = true;
            this.lbl_falta_habitaciones_2.ForeColor = System.Drawing.Color.Red;
            this.lbl_falta_habitaciones_2.Location = new System.Drawing.Point(240, 393);
            this.lbl_falta_habitaciones_2.Name = "lbl_falta_habitaciones_2";
            this.lbl_falta_habitaciones_2.Size = new System.Drawing.Size(269, 13);
            this.lbl_falta_habitaciones_2.TabIndex = 84;
            this.lbl_falta_habitaciones_2.Text = "NO ALCANZAN PARA LA CANTIDAD DE PERSONAS";
            this.lbl_falta_habitaciones_2.Visible = false;
            // 
            // btn_eliminar_habitacion
            // 
            this.btn_eliminar_habitacion.Enabled = false;
            this.btn_eliminar_habitacion.Location = new System.Drawing.Point(439, 340);
            this.btn_eliminar_habitacion.Name = "btn_eliminar_habitacion";
            this.btn_eliminar_habitacion.Size = new System.Drawing.Size(62, 23);
            this.btn_eliminar_habitacion.TabIndex = 83;
            this.btn_eliminar_habitacion.Text = "Eliminar";
            this.btn_eliminar_habitacion.UseVisualStyleBackColor = true;
            this.btn_eliminar_habitacion.Click += new System.EventHandler(this.btn_eliminar_habitacion_Click_1);
            // 
            // btn_agregar_habitacion
            // 
            this.btn_agregar_habitacion.Enabled = false;
            this.btn_agregar_habitacion.Location = new System.Drawing.Point(438, 313);
            this.btn_agregar_habitacion.Name = "btn_agregar_habitacion";
            this.btn_agregar_habitacion.Size = new System.Drawing.Size(63, 23);
            this.btn_agregar_habitacion.TabIndex = 82;
            this.btn_agregar_habitacion.Text = "Agregar";
            this.btn_agregar_habitacion.UseVisualStyleBackColor = true;
            this.btn_agregar_habitacion.Click += new System.EventHandler(this.btn_agregar_habitacion_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Habitaciones seleccionadas:";
            // 
            // cbox_seleccionadas
            // 
            this.cbox_seleccionadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_seleccionadas.Enabled = false;
            this.cbox_seleccionadas.FormattingEnabled = true;
            this.cbox_seleccionadas.Location = new System.Drawing.Point(157, 342);
            this.cbox_seleccionadas.Name = "cbox_seleccionadas";
            this.cbox_seleccionadas.Size = new System.Drawing.Size(276, 21);
            this.cbox_seleccionadas.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Habitaciones disponibles:";
            // 
            // cbox_disponibles
            // 
            this.cbox_disponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_disponibles.Enabled = false;
            this.cbox_disponibles.FormattingEnabled = true;
            this.cbox_disponibles.Location = new System.Drawing.Point(157, 315);
            this.cbox_disponibles.Name = "cbox_disponibles";
            this.cbox_disponibles.Size = new System.Drawing.Size(275, 21);
            this.cbox_disponibles.TabIndex = 78;
            // 
            // lbl_error_carga_hotel
            // 
            this.lbl_error_carga_hotel.AutoSize = true;
            this.lbl_error_carga_hotel.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_carga_hotel.Location = new System.Drawing.Point(312, 274);
            this.lbl_error_carga_hotel.Name = "lbl_error_carga_hotel";
            this.lbl_error_carga_hotel.Size = new System.Drawing.Size(88, 13);
            this.lbl_error_carga_hotel.TabIndex = 77;
            this.lbl_error_carga_hotel.Text = "FALTAN DATOS";
            this.lbl_error_carga_hotel.Visible = false;
            // 
            // lbl_error_fecha
            // 
            this.lbl_error_fecha.AutoSize = true;
            this.lbl_error_fecha.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_fecha.Location = new System.Drawing.Point(240, 169);
            this.lbl_error_fecha.Name = "lbl_error_fecha";
            this.lbl_error_fecha.Size = new System.Drawing.Size(186, 13);
            this.lbl_error_fecha.TabIndex = 73;
            this.lbl_error_fecha.Text = "DEBE SER AL MENOS UNA NOCHE";
            this.lbl_error_fecha.Visible = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(348, 523);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(150, 23);
            this.btn_modificar.TabIndex = 72;
            this.btn_modificar.Text = "Modificar Reserva";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Precio total:";
            // 
            // atras_Button
            // 
            this.atras_Button.Location = new System.Drawing.Point(16, 523);
            this.atras_Button.Name = "atras_Button";
            this.atras_Button.Size = new System.Drawing.Size(75, 23);
            this.atras_Button.TabIndex = 63;
            this.atras_Button.Text = "Atras";
            this.atras_Button.UseVisualStyleBackColor = true;
            this.atras_Button.Click += new System.EventHandler(this.atras_Button_Click);
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(351, 148);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(13, 13);
            this.lbl_noches.TabIndex = 62;
            this.lbl_noches.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cantidad de noches:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Cantidad de personas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Recarga por estrellas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Precio base (Régimen):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Regimen:";
            // 
            // cbox_regimenes
            // 
            this.cbox_regimenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_regimenes.Enabled = false;
            this.cbox_regimenes.FormattingEnabled = true;
            this.cbox_regimenes.Location = new System.Drawing.Point(16, 274);
            this.cbox_regimenes.Name = "cbox_regimenes";
            this.cbox_regimenes.Size = new System.Drawing.Size(200, 21);
            this.cbox_regimenes.TabIndex = 54;
            this.cbox_regimenes.SelectedIndexChanged += new System.EventHandler(this.cbox_regimenes_SelectedIndexChanged);
            // 
            // date_hasta
            // 
            this.date_hasta.Enabled = false;
            this.date_hasta.Location = new System.Drawing.Point(16, 186);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 53;
            this.date_hasta.ValueChanged += new System.EventHandler(this.date_hasta_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Desde";
            // 
            // date_desde
            // 
            this.date_desde.Enabled = false;
            this.date_desde.Location = new System.Drawing.Point(16, 142);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 50;
            this.date_desde.ValueChanged += new System.EventHandler(this.date_desde_ValueChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, -245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Código de reserva:";
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(325, -248);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(158, 20);
            this.txtbox_codigo.TabIndex = 86;
            // 
            // btn_cargar_reserva
            // 
            this.btn_cargar_reserva.Location = new System.Drawing.Point(315, 10);
            this.btn_cargar_reserva.Name = "btn_cargar_reserva";
            this.btn_cargar_reserva.Size = new System.Drawing.Size(99, 23);
            this.btn_cargar_reserva.TabIndex = 90;
            this.btn_cargar_reserva.Text = "Cargar reserva";
            this.btn_cargar_reserva.UseVisualStyleBackColor = true;
            this.btn_cargar_reserva.Click += new System.EventHandler(this.btn_cargar_reserva_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Código de reserva:";
            // 
            // txtbox_reserva
            // 
            this.txtbox_reserva.Location = new System.Drawing.Point(113, 12);
            this.txtbox_reserva.MaxLength = 18;
            this.txtbox_reserva.Name = "txtbox_reserva";
            this.txtbox_reserva.Size = new System.Drawing.Size(158, 20);
            this.txtbox_reserva.TabIndex = 88;
            // 
            // lbl_cargado_correcto
            // 
            this.lbl_cargado_correcto.AutoSize = true;
            this.lbl_cargado_correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_cargado_correcto.Location = new System.Drawing.Point(110, 38);
            this.lbl_cargado_correcto.Name = "lbl_cargado_correcto";
            this.lbl_cargado_correcto.Size = new System.Drawing.Size(114, 16);
            this.lbl_cargado_correcto.TabIndex = 93;
            this.lbl_cargado_correcto.Text = "Reserva cargada";
            this.lbl_cargado_correcto.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(20, 40);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(46, 13);
            this.lbl_error.TabIndex = 91;
            this.lbl_error.Text = "ERROR";
            this.lbl_error.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Enabled = false;
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(138, 226);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(78, 23);
            this.numericUpDown.TabIndex = 94;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(157, 478);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 96;
            // 
            // textBoxRecarga
            // 
            this.textBoxRecarga.Location = new System.Drawing.Point(157, 426);
            this.textBoxRecarga.Name = "textBoxRecarga";
            this.textBoxRecarga.ReadOnly = true;
            this.textBoxRecarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecarga.TabIndex = 97;
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(157, 452);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.ReadOnly = true;
            this.textBoxPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioBase.TabIndex = 98;
            // 
            // labelHotelCerrado
            // 
            this.labelHotelCerrado.AutoSize = true;
            this.labelHotelCerrado.ForeColor = System.Drawing.Color.Red;
            this.labelHotelCerrado.Location = new System.Drawing.Point(240, 193);
            this.labelHotelCerrado.Name = "labelHotelCerrado";
            this.labelHotelCerrado.Size = new System.Drawing.Size(201, 13);
            this.labelHotelCerrado.TabIndex = 99;
            this.labelHotelCerrado.Text = "HOTEL CERRADO POR ESAS FECHAS";
            this.labelHotelCerrado.Visible = false;
            // 
            // label0Personas
            // 
            this.label0Personas.AutoSize = true;
            this.label0Personas.ForeColor = System.Drawing.Color.Red;
            this.label0Personas.Location = new System.Drawing.Point(240, 236);
            this.label0Personas.Name = "label0Personas";
            this.label0Personas.Size = new System.Drawing.Size(167, 13);
            this.label0Personas.TabIndex = 100;
            this.label0Personas.Text = "NO PUEDEN SER 0 PERSONAS";
            this.label0Personas.Visible = false;
            // 
            // labelReservaYaExistente
            // 
            this.labelReservaYaExistente.AutoSize = true;
            this.labelReservaYaExistente.ForeColor = System.Drawing.Color.Red;
            this.labelReservaYaExistente.Location = new System.Drawing.Point(240, 217);
            this.labelReservaYaExistente.Name = "labelReservaYaExistente";
            this.labelReservaYaExistente.Size = new System.Drawing.Size(230, 13);
            this.labelReservaYaExistente.TabIndex = 101;
            this.labelReservaYaExistente.Text = "YA TIENE UNA RESERVA EN ESAS FECHAS";
            this.labelReservaYaExistente.Visible = false;
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 550);
            this.Controls.Add(this.labelReservaYaExistente);
            this.Controls.Add(this.label0Personas);
            this.Controls.Add(this.labelHotelCerrado);
            this.Controls.Add(this.textBoxPrecioBase);
            this.Controls.Add(this.textBoxRecarga);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lbl_cargado_correcto);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cargar_reserva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbox_reserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_codigo);
            this.Controls.Add(this.lbl_falta_habitaciones_1);
            this.Controls.Add(this.lbl_falta_habitaciones_2);
            this.Controls.Add(this.btn_eliminar_habitacion);
            this.Controls.Add(this.btn_agregar_habitacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_seleccionadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_disponibles);
            this.Controls.Add(this.lbl_error_carga_hotel);
            this.Controls.Add(this.lbl_error_fecha);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.atras_Button);
            this.Controls.Add(this.lbl_noches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_regimenes);
            this.Controls.Add(this.date_hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_desde);
            this.Name = "ModificarReserva";
            this.Text = "Modificar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_falta_habitaciones_1;
        private System.Windows.Forms.Label lbl_falta_habitaciones_2;
        private System.Windows.Forms.Button btn_eliminar_habitacion;
        private System.Windows.Forms.Button btn_agregar_habitacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_seleccionadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_disponibles;
        private System.Windows.Forms.Label lbl_error_carga_hotel;
        private System.Windows.Forms.Label lbl_error_fecha;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button atras_Button;
        private System.Windows.Forms.Label lbl_noches;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_regimenes;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.Button btn_cargar_reserva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbox_reserva;
        private System.Windows.Forms.Label lbl_cargado_correcto;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxRecarga;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.Label labelHotelCerrado;
        private System.Windows.Forms.Label label0Personas;
        private System.Windows.Forms.Label labelReservaYaExistente;
    }
}