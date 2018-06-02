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
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_hoteles = new System.Windows.Forms.ComboBox();
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.cbox_regimenes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_precio_base = new System.Windows.Forms.Label();
            this.lbl_recarga_estrellas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_tipos_habitacion = new System.Windows.Forms.ComboBox();
            this.cbox_personas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.atras_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // cbox_hoteles
            // 
            this.cbox_hoteles.FormattingEnabled = true;
            this.cbox_hoteles.Location = new System.Drawing.Point(15, 174);
            this.cbox_hoteles.Name = "cbox_hoteles";
            this.cbox_hoteles.Size = new System.Drawing.Size(292, 21);
            this.cbox_hoteles.TabIndex = 1;
            this.cbox_hoteles.SelectedIndexChanged += new System.EventHandler(this.cbox_hoteles_SelectedIndexChanged);
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
            this.cbox_regimenes.Location = new System.Drawing.Point(15, 227);
            this.cbox_regimenes.Name = "cbox_regimenes";
            this.cbox_regimenes.Size = new System.Drawing.Size(197, 21);
            this.cbox_regimenes.TabIndex = 6;
            this.cbox_regimenes.SelectedIndexChanged += new System.EventHandler(this.cbox_regimenes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Regimen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Recarga por estrellas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estrellas:";
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(380, 174);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(81, 13);
            this.lbl_estrellas.TabIndex = 11;
            this.lbl_estrellas.Text = "<ESTRELLAS>";
            // 
            // lbl_precio_base
            // 
            this.lbl_precio_base.AutoSize = true;
            this.lbl_precio_base.Location = new System.Drawing.Point(221, 247);
            this.lbl_precio_base.Name = "lbl_precio_base";
            this.lbl_precio_base.Size = new System.Drawing.Size(35, 13);
            this.lbl_precio_base.TabIndex = 12;
            this.lbl_precio_base.Text = "label8";
            // 
            // lbl_recarga_estrellas
            // 
            this.lbl_recarga_estrellas.AutoSize = true;
            this.lbl_recarga_estrellas.Location = new System.Drawing.Point(312, 247);
            this.lbl_recarga_estrellas.Name = "lbl_recarga_estrellas";
            this.lbl_recarga_estrellas.Size = new System.Drawing.Size(35, 13);
            this.lbl_recarga_estrellas.TabIndex = 13;
            this.lbl_recarga_estrellas.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad de personas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de habitacion:";
            // 
            // cbox_tipos_habitacion
            // 
            this.cbox_tipos_habitacion.FormattingEnabled = true;
            this.cbox_tipos_habitacion.Location = new System.Drawing.Point(347, 69);
            this.cbox_tipos_habitacion.Name = "cbox_tipos_habitacion";
            this.cbox_tipos_habitacion.Size = new System.Drawing.Size(141, 21);
            this.cbox_tipos_habitacion.TabIndex = 18;
            this.cbox_tipos_habitacion.SelectedIndexChanged += new System.EventHandler(this.cbox_tipos_habitacion_SelectedIndexChanged);
            // 
            // cbox_personas
            // 
            this.cbox_personas.FormattingEnabled = true;
            this.cbox_personas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_personas.Location = new System.Drawing.Point(347, 25);
            this.cbox_personas.Name = "cbox_personas";
            this.cbox_personas.Size = new System.Drawing.Size(141, 21);
            this.cbox_personas.TabIndex = 19;
            this.cbox_personas.SelectedIndexChanged += new System.EventHandler(this.cbox_personas_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cantidad de noches:";
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(123, 106);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(54, 13);
            this.lbl_noches.TabIndex = 21;
            this.lbl_noches.Text = "<noches>";
            // 
            // atras_Button
            // 
            this.atras_Button.Location = new System.Drawing.Point(15, 470);
            this.atras_Button.Name = "atras_Button";
            this.atras_Button.Size = new System.Drawing.Size(75, 23);
            this.atras_Button.TabIndex = 22;
            this.atras_Button.Text = "Atras";
            this.atras_Button.UseVisualStyleBackColor = true;
            this.atras_Button.Click += new System.EventHandler(this.atras_Button_Click);
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 505);
            this.Controls.Add(this.atras_Button);
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
            this.Controls.Add(this.label1);
            this.Name = "GenerarReserva";
            this.Text = "Generar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_hoteles;
        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.ComboBox cbox_regimenes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_precio_base;
        private System.Windows.Forms.Label lbl_recarga_estrellas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox_tipos_habitacion;
        private System.Windows.Forms.ComboBox cbox_personas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_noches;
        private System.Windows.Forms.Button atras_Button;
    }
}