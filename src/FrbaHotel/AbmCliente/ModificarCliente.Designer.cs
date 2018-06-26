namespace FrbaHotel.AbmCliente
{
    partial class ModificarCliente
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
            this.labelMailInvalido = new System.Windows.Forms.Label();
            this.labelMailEnUso = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonSeleccionarFecha = new System.Windows.Forms.Button();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFechaInvalida = new System.Windows.Forms.Label();
            this.labelNombreInvalido = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelApellidoInvalido = new System.Windows.Forms.Label();
            this.labelTelefonoInvalido = new System.Windows.Forms.Label();
            this.labelNumeroDocInvalido = new System.Windows.Forms.Label();
            this.labelDireccionInvalida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelNumeroDeCalleInvalido = new System.Windows.Forms.Label();
            this.labelLocalidadInvalida = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCalle = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.labelPisoInvalido = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.labelDepartamentoInvalido = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            this.labelMailObligatorio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNombreObligatorio = new System.Windows.Forms.Label();
            this.labelApellidoObligatorio = new System.Windows.Forms.Label();
            this.labelNumeroDocObligatorio = new System.Windows.Forms.Label();
            this.labelDireccionObligatoria = new System.Windows.Forms.Label();
            this.labelCalleObligatoria = new System.Windows.Forms.Label();
            this.labelNacionalidadObligatoria = new System.Windows.Forms.Label();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelMailInvalido
            // 
            this.labelMailInvalido.AutoSize = true;
            this.labelMailInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailInvalido.Location = new System.Drawing.Point(214, 95);
            this.labelMailInvalido.Name = "labelMailInvalido";
            this.labelMailInvalido.Size = new System.Drawing.Size(106, 13);
            this.labelMailInvalido.TabIndex = 32;
            this.labelMailInvalido.Text = "Ese mail no es valido";
            this.labelMailInvalido.Visible = false;
            // 
            // labelMailEnUso
            // 
            this.labelMailEnUso.AutoSize = true;
            this.labelMailEnUso.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailEnUso.Location = new System.Drawing.Point(214, 95);
            this.labelMailEnUso.Name = "labelMailEnUso";
            this.labelMailEnUso.Size = new System.Drawing.Size(118, 13);
            this.labelMailEnUso.TabIndex = 33;
            this.labelMailEnUso.Text = "Ese mail ya está en uso";
            this.labelMailEnUso.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(315, 276);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 55;
            // 
            // buttonSeleccionarFecha
            // 
            this.buttonSeleccionarFecha.Location = new System.Drawing.Point(468, 217);
            this.buttonSeleccionarFecha.Name = "buttonSeleccionarFecha";
            this.buttonSeleccionarFecha.Size = new System.Drawing.Size(84, 23);
            this.buttonSeleccionarFecha.TabIndex = 54;
            this.buttonSeleccionarFecha.Text = "Seleccionar";
            this.buttonSeleccionarFecha.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFecha.Click += new System.EventHandler(this.buttonSeleccionarFecha_Click);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(291, 220);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(160, 20);
            this.textBoxFecha.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "(*)Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "(*)Nacionalidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "(*)Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "(*)Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "(*)Número de identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "(*)Tipo de indentificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "(*)Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "(*)Nombre:";
            // 
            // labelFechaInvalida
            // 
            this.labelFechaInvalida.AutoSize = true;
            this.labelFechaInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFechaInvalida.Location = new System.Drawing.Point(291, 243);
            this.labelFechaInvalida.Name = "labelFechaInvalida";
            this.labelFechaInvalida.Size = new System.Drawing.Size(76, 13);
            this.labelFechaInvalida.TabIndex = 56;
            this.labelFechaInvalida.Text = "Fecha inválida";
            this.labelFechaInvalida.Visible = false;
            // 
            // labelNombreInvalido
            // 
            this.labelNombreInvalido.AutoSize = true;
            this.labelNombreInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreInvalido.Location = new System.Drawing.Point(37, 95);
            this.labelNombreInvalido.Name = "labelNombreInvalido";
            this.labelNombreInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNombreInvalido.TabIndex = 57;
            this.labelNombreInvalido.Text = "Nombre invalido";
            this.labelNombreInvalido.Visible = false;
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(397, 70);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoDocumento.TabIndex = 58;
            // 
            // labelApellidoInvalido
            // 
            this.labelApellidoInvalido.AutoSize = true;
            this.labelApellidoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelApellidoInvalido.Location = new System.Drawing.Point(37, 159);
            this.labelApellidoInvalido.Name = "labelApellidoInvalido";
            this.labelApellidoInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelApellidoInvalido.TabIndex = 59;
            this.labelApellidoInvalido.Text = "Apellido inválido";
            this.labelApellidoInvalido.Visible = false;
            // 
            // labelTelefonoInvalido
            // 
            this.labelTelefonoInvalido.AutoSize = true;
            this.labelTelefonoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTelefonoInvalido.Location = new System.Drawing.Point(214, 159);
            this.labelTelefonoInvalido.Name = "labelTelefonoInvalido";
            this.labelTelefonoInvalido.Size = new System.Drawing.Size(88, 13);
            this.labelTelefonoInvalido.TabIndex = 60;
            this.labelTelefonoInvalido.Text = "Teléfono inválido";
            this.labelTelefonoInvalido.Visible = false;
            // 
            // labelNumeroDocInvalido
            // 
            this.labelNumeroDocInvalido.AutoSize = true;
            this.labelNumeroDocInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDocInvalido.Location = new System.Drawing.Point(394, 159);
            this.labelNumeroDocInvalido.Name = "labelNumeroDocInvalido";
            this.labelNumeroDocInvalido.Size = new System.Drawing.Size(163, 13);
            this.labelNumeroDocInvalido.TabIndex = 61;
            this.labelNumeroDocInvalido.Text = "Numero de identificación inválido";
            this.labelNumeroDocInvalido.Visible = false;
            // 
            // labelDireccionInvalida
            // 
            this.labelDireccionInvalida.AutoSize = true;
            this.labelDireccionInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDireccionInvalida.Location = new System.Drawing.Point(37, 240);
            this.labelDireccionInvalida.Name = "labelDireccionInvalida";
            this.labelDireccionInvalida.Size = new System.Drawing.Size(91, 13);
            this.labelDireccionInvalida.TabIndex = 62;
            this.labelDireccionInvalida.Text = "Direccion inválida";
            this.labelDireccionInvalida.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "(*)Numero de calle:";
            // 
            // labelNumeroDeCalleInvalido
            // 
            this.labelNumeroDeCalleInvalido.AutoSize = true;
            this.labelNumeroDeCalleInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDeCalleInvalido.Location = new System.Drawing.Point(37, 299);
            this.labelNumeroDeCalleInvalido.Name = "labelNumeroDeCalleInvalido";
            this.labelNumeroDeCalleInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNumeroDeCalleInvalido.TabIndex = 65;
            this.labelNumeroDeCalleInvalido.Text = "Numero invalido";
            this.labelNumeroDeCalleInvalido.Visible = false;
            // 
            // labelLocalidadInvalida
            // 
            this.labelLocalidadInvalida.AutoSize = true;
            this.labelLocalidadInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLocalidadInvalida.Location = new System.Drawing.Point(37, 414);
            this.labelLocalidadInvalida.Name = "labelLocalidadInvalida";
            this.labelLocalidadInvalida.Size = new System.Drawing.Size(92, 13);
            this.labelLocalidadInvalida.TabIndex = 66;
            this.labelLocalidadInvalida.Text = "Localidad inválida";
            this.labelLocalidadInvalida.Visible = false;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(40, 218);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(216, 20);
            this.textBoxDireccion.TabIndex = 68;
            // 
            // textBoxNumeroCalle
            // 
            this.textBoxNumeroCalle.Location = new System.Drawing.Point(40, 276);
            this.textBoxNumeroCalle.Name = "textBoxNumeroCalle";
            this.textBoxNumeroCalle.Size = new System.Drawing.Size(216, 20);
            this.textBoxNumeroCalle.TabIndex = 69;
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(40, 391);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(216, 20);
            this.textBoxLocalidad.TabIndex = 70;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(40, 136);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(160, 20);
            this.textBoxApellido.TabIndex = 72;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(40, 70);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(160, 20);
            this.textBoxNombre.TabIndex = 73;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(217, 72);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail.TabIndex = 74;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(217, 136);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(160, 20);
            this.textBoxTelefono.TabIndex = 75;
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(397, 136);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumeroDocumento.TabIndex = 76;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(134, 545);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 77;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(406, 545);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 78;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(40, 336);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(105, 20);
            this.textBoxPiso.TabIndex = 81;
            // 
            // labelPisoInvalido
            // 
            this.labelPisoInvalido.AutoSize = true;
            this.labelPisoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPisoInvalido.Location = new System.Drawing.Point(37, 359);
            this.labelPisoInvalido.Name = "labelPisoInvalido";
            this.labelPisoInvalido.Size = new System.Drawing.Size(69, 13);
            this.labelPisoInvalido.TabIndex = 80;
            this.labelPisoInvalido.Text = "Piso  invalido";
            this.labelPisoInvalido.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 320);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Numero de piso:";
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(151, 336);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(105, 20);
            this.textBoxDepto.TabIndex = 84;
            // 
            // labelDepartamentoInvalido
            // 
            this.labelDepartamentoInvalido.AutoSize = true;
            this.labelDepartamentoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDepartamentoInvalido.Location = new System.Drawing.Point(148, 359);
            this.labelDepartamentoInvalido.Name = "labelDepartamentoInvalido";
            this.labelDepartamentoInvalido.Size = new System.Drawing.Size(111, 13);
            this.labelDepartamentoInvalido.TabIndex = 83;
            this.labelDepartamentoInvalido.Text = "DepartamentoInvalido";
            this.labelDepartamentoInvalido.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(148, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Departamento:";
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(40, 457);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(216, 21);
            this.comboBoxNacionalidad.TabIndex = 85;
            // 
            // labelMailObligatorio
            // 
            this.labelMailObligatorio.AutoSize = true;
            this.labelMailObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailObligatorio.Location = new System.Drawing.Point(214, 95);
            this.labelMailObligatorio.Name = "labelMailObligatorio";
            this.labelMailObligatorio.Size = new System.Drawing.Size(102, 13);
            this.labelMailObligatorio.TabIndex = 86;
            this.labelMailObligatorio.Text = "El mail es obligatorio";
            this.labelMailObligatorio.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 87;
            this.label11.Text = "(*)Campos Obligatorios";
            // 
            // labelNombreObligatorio
            // 
            this.labelNombreObligatorio.AutoSize = true;
            this.labelNombreObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreObligatorio.Location = new System.Drawing.Point(37, 93);
            this.labelNombreObligatorio.Name = "labelNombreObligatorio";
            this.labelNombreObligatorio.Size = new System.Drawing.Size(119, 13);
            this.labelNombreObligatorio.TabIndex = 88;
            this.labelNombreObligatorio.Text = "El nombre es obligatorio";
            this.labelNombreObligatorio.Visible = false;
            // 
            // labelApellidoObligatorio
            // 
            this.labelApellidoObligatorio.AutoSize = true;
            this.labelApellidoObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelApellidoObligatorio.Location = new System.Drawing.Point(37, 159);
            this.labelApellidoObligatorio.Name = "labelApellidoObligatorio";
            this.labelApellidoObligatorio.Size = new System.Drawing.Size(120, 13);
            this.labelApellidoObligatorio.TabIndex = 89;
            this.labelApellidoObligatorio.Text = "El apellido es obligatorio";
            this.labelApellidoObligatorio.Visible = false;
            // 
            // labelNumeroDocObligatorio
            // 
            this.labelNumeroDocObligatorio.AutoSize = true;
            this.labelNumeroDocObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDocObligatorio.Location = new System.Drawing.Point(394, 159);
            this.labelNumeroDocObligatorio.Name = "labelNumeroDocObligatorio";
            this.labelNumeroDocObligatorio.Size = new System.Drawing.Size(119, 13);
            this.labelNumeroDocObligatorio.TabIndex = 90;
            this.labelNumeroDocObligatorio.Text = "El número es obligatorio";
            this.labelNumeroDocObligatorio.Visible = false;
            // 
            // labelDireccionObligatoria
            // 
            this.labelDireccionObligatoria.AutoSize = true;
            this.labelDireccionObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDireccionObligatoria.Location = new System.Drawing.Point(37, 240);
            this.labelDireccionObligatoria.Name = "labelDireccionObligatoria";
            this.labelDireccionObligatoria.Size = new System.Drawing.Size(130, 13);
            this.labelDireccionObligatoria.TabIndex = 91;
            this.labelDireccionObligatoria.Text = "La dirección es obligatorio";
            this.labelDireccionObligatoria.Visible = false;
            // 
            // labelCalleObligatoria
            // 
            this.labelCalleObligatoria.AutoSize = true;
            this.labelCalleObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCalleObligatoria.Location = new System.Drawing.Point(37, 299);
            this.labelCalleObligatoria.Name = "labelCalleObligatoria";
            this.labelCalleObligatoria.Size = new System.Drawing.Size(119, 13);
            this.labelCalleObligatoria.TabIndex = 92;
            this.labelCalleObligatoria.Text = "El número es olbigatorio";
            this.labelCalleObligatoria.Visible = false;
            // 
            // labelNacionalidadObligatoria
            // 
            this.labelNacionalidadObligatoria.AutoSize = true;
            this.labelNacionalidadObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNacionalidadObligatoria.Location = new System.Drawing.Point(37, 481);
            this.labelNacionalidadObligatoria.Name = "labelNacionalidadObligatoria";
            this.labelNacionalidadObligatoria.Size = new System.Drawing.Size(147, 13);
            this.labelNacionalidadObligatoria.TabIndex = 93;
            this.labelNacionalidadObligatoria.Text = "La nacionalidad es obligatoria";
            this.labelNacionalidadObligatoria.Visible = false;
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Checked = true;
            this.checkBoxHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(315, 461);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkBoxHabilitado.TabIndex = 143;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 592);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.labelNacionalidadObligatoria);
            this.Controls.Add(this.labelCalleObligatoria);
            this.Controls.Add(this.labelDireccionObligatoria);
            this.Controls.Add(this.labelNumeroDocObligatorio);
            this.Controls.Add(this.labelApellidoObligatorio);
            this.Controls.Add(this.labelNombreObligatorio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelMailObligatorio);
            this.Controls.Add(this.comboBoxNacionalidad);
            this.Controls.Add(this.textBoxDepto);
            this.Controls.Add(this.labelDepartamentoInvalido);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPiso);
            this.Controls.Add(this.labelPisoInvalido);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.textBoxNumeroCalle);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelLocalidadInvalida);
            this.Controls.Add(this.labelNumeroDeCalleInvalido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelDireccionInvalida);
            this.Controls.Add(this.labelNumeroDocInvalido);
            this.Controls.Add(this.labelTelefonoInvalido);
            this.Controls.Add(this.labelApellidoInvalido);
            this.Controls.Add(this.comboBoxTipoDocumento);
            this.Controls.Add(this.labelNombreInvalido);
            this.Controls.Add(this.labelFechaInvalida);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonSeleccionarFecha);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMailEnUso);
            this.Controls.Add(this.labelMailInvalido);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMailInvalido;
        private System.Windows.Forms.Label labelMailEnUso;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonSeleccionarFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFechaInvalida;
        private System.Windows.Forms.Label labelNombreInvalido;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.Label labelApellidoInvalido;
        private System.Windows.Forms.Label labelTelefonoInvalido;
        private System.Windows.Forms.Label labelNumeroDocInvalido;
        private System.Windows.Forms.Label labelDireccionInvalida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelNumeroDeCalleInvalido;
        private System.Windows.Forms.Label labelLocalidadInvalida;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNumeroCalle;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label labelPisoInvalido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.Label labelDepartamentoInvalido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.Label labelMailObligatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNombreObligatorio;
        private System.Windows.Forms.Label labelApellidoObligatorio;
        private System.Windows.Forms.Label labelNumeroDocObligatorio;
        private System.Windows.Forms.Label labelDireccionObligatoria;
        private System.Windows.Forms.Label labelCalleObligatoria;
        private System.Windows.Forms.Label labelNacionalidadObligatoria;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;


    }
}