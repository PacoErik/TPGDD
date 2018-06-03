namespace FrbaHotel.AbmCliente
{
    partial class AltaCliente
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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNumeroDocInvalido = new System.Windows.Forms.Label();
            this.labelTelefonoInvalido = new System.Windows.Forms.Label();
            this.labelApellidoInvalido = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelNombreInvalido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMailEnUso = new System.Windows.Forms.Label();
            this.labelMailInvalido = new System.Windows.Forms.Label();
            this.labelFechaInvalida = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonSeleccionarFecha = new System.Windows.Forms.Button();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.labelDepartamentoInvalido = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.labelPisoInvalido = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCalle = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelLocalidadInvalida = new System.Windows.Forms.Label();
            this.labelNumeroDeCalleInvalido = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelDireccionInvalida = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(94, 476);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 22;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(426, 476);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(99, 23);
            this.buttonCrear.TabIndex = 23;
            this.buttonCrear.Text = "Crear Usuario";
            this.buttonCrear.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(390, 91);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumeroDocumento.TabIndex = 94;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(210, 91);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(160, 20);
            this.textBoxTelefono.TabIndex = 93;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(210, 27);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail.TabIndex = 92;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(33, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(160, 20);
            this.textBoxNombre.TabIndex = 91;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(33, 91);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(160, 20);
            this.textBoxApellido.TabIndex = 90;
            // 
            // labelNumeroDocInvalido
            // 
            this.labelNumeroDocInvalido.AutoSize = true;
            this.labelNumeroDocInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDocInvalido.Location = new System.Drawing.Point(387, 114);
            this.labelNumeroDocInvalido.Name = "labelNumeroDocInvalido";
            this.labelNumeroDocInvalido.Size = new System.Drawing.Size(163, 13);
            this.labelNumeroDocInvalido.TabIndex = 89;
            this.labelNumeroDocInvalido.Text = "Numero de identificación invalido";
            this.labelNumeroDocInvalido.Visible = false;
            // 
            // labelTelefonoInvalido
            // 
            this.labelTelefonoInvalido.AutoSize = true;
            this.labelTelefonoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTelefonoInvalido.Location = new System.Drawing.Point(207, 114);
            this.labelTelefonoInvalido.Name = "labelTelefonoInvalido";
            this.labelTelefonoInvalido.Size = new System.Drawing.Size(88, 13);
            this.labelTelefonoInvalido.TabIndex = 88;
            this.labelTelefonoInvalido.Text = "Telefono invalido";
            this.labelTelefonoInvalido.Visible = false;
            // 
            // labelApellidoInvalido
            // 
            this.labelApellidoInvalido.AutoSize = true;
            this.labelApellidoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelApellidoInvalido.Location = new System.Drawing.Point(30, 114);
            this.labelApellidoInvalido.Name = "labelApellidoInvalido";
            this.labelApellidoInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelApellidoInvalido.TabIndex = 87;
            this.labelApellidoInvalido.Text = "Apellido invalido";
            this.labelApellidoInvalido.Visible = false;
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(390, 25);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoDocumento.TabIndex = 86;
            // 
            // labelNombreInvalido
            // 
            this.labelNombreInvalido.AutoSize = true;
            this.labelNombreInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreInvalido.Location = new System.Drawing.Point(30, 50);
            this.labelNombreInvalido.Name = "labelNombreInvalido";
            this.labelNombreInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNombreInvalido.TabIndex = 85;
            this.labelNombreInvalido.Text = "Nombre invalido";
            this.labelNombreInvalido.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Numero de identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tipo de indentificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nombre:";
            // 
            // labelMailEnUso
            // 
            this.labelMailEnUso.AutoSize = true;
            this.labelMailEnUso.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailEnUso.Location = new System.Drawing.Point(207, 50);
            this.labelMailEnUso.Name = "labelMailEnUso";
            this.labelMailEnUso.Size = new System.Drawing.Size(118, 13);
            this.labelMailEnUso.TabIndex = 78;
            this.labelMailEnUso.Text = "Ese mail ya esta en uso";
            this.labelMailEnUso.Visible = false;
            // 
            // labelMailInvalido
            // 
            this.labelMailInvalido.AutoSize = true;
            this.labelMailInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailInvalido.Location = new System.Drawing.Point(207, 50);
            this.labelMailInvalido.Name = "labelMailInvalido";
            this.labelMailInvalido.Size = new System.Drawing.Size(106, 13);
            this.labelMailInvalido.TabIndex = 77;
            this.labelMailInvalido.Text = "Ese mail no es valido";
            this.labelMailInvalido.Visible = false;
            // 
            // labelFechaInvalida
            // 
            this.labelFechaInvalida.AutoSize = true;
            this.labelFechaInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFechaInvalida.Location = new System.Drawing.Point(286, 195);
            this.labelFechaInvalida.Name = "labelFechaInvalida";
            this.labelFechaInvalida.Size = new System.Drawing.Size(76, 13);
            this.labelFechaInvalida.TabIndex = 99;
            this.labelFechaInvalida.Text = "Fecha invalida";
            this.labelFechaInvalida.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(310, 228);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 98;
            // 
            // buttonSeleccionarFecha
            // 
            this.buttonSeleccionarFecha.Location = new System.Drawing.Point(463, 169);
            this.buttonSeleccionarFecha.Name = "buttonSeleccionarFecha";
            this.buttonSeleccionarFecha.Size = new System.Drawing.Size(84, 23);
            this.buttonSeleccionarFecha.TabIndex = 97;
            this.buttonSeleccionarFecha.Text = "Seleccionar";
            this.buttonSeleccionarFecha.UseVisualStyleBackColor = true;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(286, 172);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(160, 20);
            this.textBoxFecha.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(33, 411);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(216, 21);
            this.comboBoxNacionalidad.TabIndex = 116;
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(144, 290);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(105, 20);
            this.textBoxDepto.TabIndex = 115;
            // 
            // labelDepartamentoInvalido
            // 
            this.labelDepartamentoInvalido.AutoSize = true;
            this.labelDepartamentoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDepartamentoInvalido.Location = new System.Drawing.Point(141, 313);
            this.labelDepartamentoInvalido.Name = "labelDepartamentoInvalido";
            this.labelDepartamentoInvalido.Size = new System.Drawing.Size(111, 13);
            this.labelDepartamentoInvalido.TabIndex = 114;
            this.labelDepartamentoInvalido.Text = "DepartamentoInvalido";
            this.labelDepartamentoInvalido.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 113;
            this.label16.Text = "Departamento:";
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(33, 290);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(105, 20);
            this.textBoxPiso.TabIndex = 112;
            // 
            // labelPisoInvalido
            // 
            this.labelPisoInvalido.AutoSize = true;
            this.labelPisoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPisoInvalido.Location = new System.Drawing.Point(30, 313);
            this.labelPisoInvalido.Name = "labelPisoInvalido";
            this.labelPisoInvalido.Size = new System.Drawing.Size(69, 13);
            this.labelPisoInvalido.TabIndex = 111;
            this.labelPisoInvalido.Text = "Piso  invalido";
            this.labelPisoInvalido.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 110;
            this.label15.Text = "Numero de piso:";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(33, 345);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(216, 20);
            this.textBoxLocalidad.TabIndex = 109;
            // 
            // textBoxNumeroCalle
            // 
            this.textBoxNumeroCalle.Location = new System.Drawing.Point(33, 230);
            this.textBoxNumeroCalle.Name = "textBoxNumeroCalle";
            this.textBoxNumeroCalle.Size = new System.Drawing.Size(216, 20);
            this.textBoxNumeroCalle.TabIndex = 108;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(33, 172);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(216, 20);
            this.textBoxDireccion.TabIndex = 107;
            // 
            // labelLocalidadInvalida
            // 
            this.labelLocalidadInvalida.AutoSize = true;
            this.labelLocalidadInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLocalidadInvalida.Location = new System.Drawing.Point(30, 368);
            this.labelLocalidadInvalida.Name = "labelLocalidadInvalida";
            this.labelLocalidadInvalida.Size = new System.Drawing.Size(92, 13);
            this.labelLocalidadInvalida.TabIndex = 106;
            this.labelLocalidadInvalida.Text = "Localidad invalida";
            this.labelLocalidadInvalida.Visible = false;
            // 
            // labelNumeroDeCalleInvalido
            // 
            this.labelNumeroDeCalleInvalido.AutoSize = true;
            this.labelNumeroDeCalleInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDeCalleInvalido.Location = new System.Drawing.Point(30, 253);
            this.labelNumeroDeCalleInvalido.Name = "labelNumeroDeCalleInvalido";
            this.labelNumeroDeCalleInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNumeroDeCalleInvalido.TabIndex = 105;
            this.labelNumeroDeCalleInvalido.Text = "Numero invalido";
            this.labelNumeroDeCalleInvalido.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 104;
            this.label13.Text = "Numero de calle:";
            // 
            // labelDireccionInvalida
            // 
            this.labelDireccionInvalida.AutoSize = true;
            this.labelDireccionInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDireccionInvalida.Location = new System.Drawing.Point(30, 194);
            this.labelDireccionInvalida.Name = "labelDireccionInvalida";
            this.labelDireccionInvalida.Size = new System.Drawing.Size(91, 13);
            this.labelDireccionInvalida.TabIndex = 103;
            this.labelDireccionInvalida.Text = "Direccion invalida";
            this.labelDireccionInvalida.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Nacionalidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Dirección:";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 523);
            this.Controls.Add(this.comboBoxNacionalidad);
            this.Controls.Add(this.textBoxDepto);
            this.Controls.Add(this.labelDepartamentoInvalido);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPiso);
            this.Controls.Add(this.labelPisoInvalido);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.textBoxNumeroCalle);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelLocalidadInvalida);
            this.Controls.Add(this.labelNumeroDeCalleInvalido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelDireccionInvalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelFechaInvalida);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonSeleccionarFecha);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelNumeroDocInvalido);
            this.Controls.Add(this.labelTelefonoInvalido);
            this.Controls.Add(this.labelApellidoInvalido);
            this.Controls.Add(this.comboBoxTipoDocumento);
            this.Controls.Add(this.labelNombreInvalido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMailEnUso);
            this.Controls.Add(this.labelMailInvalido);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonAtras);
            this.Name = "AltaCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNumeroDocInvalido;
        private System.Windows.Forms.Label labelTelefonoInvalido;
        private System.Windows.Forms.Label labelApellidoInvalido;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.Label labelNombreInvalido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMailEnUso;
        private System.Windows.Forms.Label labelMailInvalido;
        private System.Windows.Forms.Label labelFechaInvalida;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonSeleccionarFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.Label labelDepartamentoInvalido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label labelPisoInvalido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxNumeroCalle;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelLocalidadInvalida;
        private System.Windows.Forms.Label labelNumeroDeCalleInvalido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelDireccionInvalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}