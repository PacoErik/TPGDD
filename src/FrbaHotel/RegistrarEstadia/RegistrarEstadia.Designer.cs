namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarEstadia
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
            this.checkin = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numero_reserva = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cantidad_noches = new System.Windows.Forms.TextBox();
            this.fecha_reserva = new System.Windows.Forms.TextBox();
            this.fecha_inicio = new System.Windows.Forms.TextBox();
            this.fecha_fin = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.regimen = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reserva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkin
            // 
            this.checkin.Enabled = false;
            this.checkin.Location = new System.Drawing.Point(220, 173);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(121, 23);
            this.checkin.TabIndex = 12;
            this.checkin.Text = "Registrar Check-In";
            this.checkin.UseVisualStyleBackColor = true;
            this.checkin.Click += new System.EventHandler(this.checkin_Click);
            // 
            // checkout
            // 
            this.checkout.Enabled = false;
            this.checkout.Location = new System.Drawing.Point(432, 173);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(121, 23);
            this.checkout.TabIndex = 13;
            this.checkout.Text = "Registrar Check-Out";
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(15, 173);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 14;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código de reserva:";
            // 
            // numero_reserva
            // 
            this.numero_reserva.Location = new System.Drawing.Point(115, 12);
            this.numero_reserva.Name = "numero_reserva";
            this.numero_reserva.Size = new System.Drawing.Size(100, 20);
            this.numero_reserva.TabIndex = 16;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(221, 10);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 17;
            this.ok.Text = "Buscar";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de reserva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Régimen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cantidad de noches:";
            // 
            // cantidad_noches
            // 
            this.cantidad_noches.Location = new System.Drawing.Point(396, 78);
            this.cantidad_noches.Name = "cantidad_noches";
            this.cantidad_noches.ReadOnly = true;
            this.cantidad_noches.Size = new System.Drawing.Size(171, 20);
            this.cantidad_noches.TabIndex = 28;
            // 
            // fecha_reserva
            // 
            this.fecha_reserva.Location = new System.Drawing.Point(396, 52);
            this.fecha_reserva.Name = "fecha_reserva";
            this.fecha_reserva.ReadOnly = true;
            this.fecha_reserva.Size = new System.Drawing.Size(171, 20);
            this.fecha_reserva.TabIndex = 29;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Location = new System.Drawing.Point(396, 103);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.ReadOnly = true;
            this.fecha_inicio.Size = new System.Drawing.Size(171, 20);
            this.fecha_inicio.TabIndex = 30;
            // 
            // fecha_fin
            // 
            this.fecha_fin.Location = new System.Drawing.Point(396, 129);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            this.fecha_fin.Size = new System.Drawing.Size(171, 20);
            this.fecha_fin.TabIndex = 31;
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(57, 52);
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Size = new System.Drawing.Size(219, 20);
            this.cliente.TabIndex = 32;
            // 
            // regimen
            // 
            this.regimen.Location = new System.Drawing.Point(58, 76);
            this.regimen.Name = "regimen";
            this.regimen.ReadOnly = true;
            this.regimen.Size = new System.Drawing.Size(218, 20);
            this.regimen.TabIndex = 33;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(58, 100);
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Size = new System.Drawing.Size(218, 20);
            this.usuario.TabIndex = 34;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(57, 129);
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Size = new System.Drawing.Size(219, 20);
            this.estado.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Reserva:";
            // 
            // reserva
            // 
            this.reserva.Location = new System.Drawing.Point(467, 12);
            this.reserva.Name = "reserva";
            this.reserva.ReadOnly = true;
            this.reserva.Size = new System.Drawing.Size(100, 20);
            this.reserva.TabIndex = 37;
            // 
            // RegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 210);
            this.Controls.Add(this.reserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.regimen);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.fecha_reserva);
            this.Controls.Add(this.cantidad_noches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.numero_reserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Name = "RegistrarEstadia";
            this.Text = "Registrar estadía";
            this.Load += new System.EventHandler(this.RegistrarEstadia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero_reserva;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cantidad_noches;
        private System.Windows.Forms.TextBox fecha_reserva;
        private System.Windows.Forms.TextBox fecha_inicio;
        private System.Windows.Forms.TextBox fecha_fin;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.TextBox regimen;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reserva;
    }
}