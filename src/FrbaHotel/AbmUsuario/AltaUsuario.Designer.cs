namespace FrbaHotel.AbmUsuario
{
    partial class AltaUsuario
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
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.labelCalleObligatoria = new System.Windows.Forms.Label();
            this.labelDireccionObligatoria = new System.Windows.Forms.Label();
            this.labelNumeroDocObligatorio = new System.Windows.Forms.Label();
            this.labelApellidoObligatorio = new System.Windows.Forms.Label();
            this.labelNombreObligatorio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMailObligatorio = new System.Windows.Forms.Label();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.labelDepartamentoInvalido = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.labelPisoInvalido = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCalle = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelLocalidadInvalida = new System.Windows.Forms.Label();
            this.labelNumeroDeCalleInvalido = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelDireccionInvalida = new System.Windows.Forms.Label();
            this.labelNumeroDocInvalido = new System.Windows.Forms.Label();
            this.labelTelefonoInvalido = new System.Windows.Forms.Label();
            this.labelApellidoInvalido = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelNombreInvalido = new System.Windows.Forms.Label();
            this.labelFechaInvalida = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonSeleccionarFecha = new System.Windows.Forms.Button();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMailEnUso = new System.Windows.Forms.Label();
            this.labelMailInvalido = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelUsuarioInvalido = new System.Windows.Forms.Label();
            this.labelContraseñaObligatoria = new System.Windows.Forms.Label();
            this.labelUsuarioObligatorio = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelUsuarioEnUso = new System.Windows.Forms.Label();
            this.textBoxHotel = new System.Windows.Forms.TextBox();
            this.labelHotelObligatorio = new System.Windows.Forms.Label();
            this.buttonSeleccionarHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Checked = true;
            this.checkBoxHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(310, 464);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(110, 17);
            this.checkBoxHabilitado.TabIndex = 193;
            this.checkBoxHabilitado.Text = "Usuario habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // labelCalleObligatoria
            // 
            this.labelCalleObligatoria.AutoSize = true;
            this.labelCalleObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCalleObligatoria.Location = new System.Drawing.Point(29, 304);
            this.labelCalleObligatoria.Name = "labelCalleObligatoria";
            this.labelCalleObligatoria.Size = new System.Drawing.Size(119, 13);
            this.labelCalleObligatoria.TabIndex = 191;
            this.labelCalleObligatoria.Text = "El número es obligatorio";
            this.labelCalleObligatoria.Visible = false;
            // 
            // labelDireccionObligatoria
            // 
            this.labelDireccionObligatoria.AutoSize = true;
            this.labelDireccionObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDireccionObligatoria.Location = new System.Drawing.Point(35, 245);
            this.labelDireccionObligatoria.Name = "labelDireccionObligatoria";
            this.labelDireccionObligatoria.Size = new System.Drawing.Size(130, 13);
            this.labelDireccionObligatoria.TabIndex = 190;
            this.labelDireccionObligatoria.Text = "La dirección es obligatorio";
            this.labelDireccionObligatoria.Visible = false;
            // 
            // labelNumeroDocObligatorio
            // 
            this.labelNumeroDocObligatorio.AutoSize = true;
            this.labelNumeroDocObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDocObligatorio.Location = new System.Drawing.Point(572, 158);
            this.labelNumeroDocObligatorio.Name = "labelNumeroDocObligatorio";
            this.labelNumeroDocObligatorio.Size = new System.Drawing.Size(119, 13);
            this.labelNumeroDocObligatorio.TabIndex = 189;
            this.labelNumeroDocObligatorio.Text = "El número es obligatorio";
            this.labelNumeroDocObligatorio.Visible = false;
            // 
            // labelApellidoObligatorio
            // 
            this.labelApellidoObligatorio.AutoSize = true;
            this.labelApellidoObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelApellidoObligatorio.Location = new System.Drawing.Point(221, 158);
            this.labelApellidoObligatorio.Name = "labelApellidoObligatorio";
            this.labelApellidoObligatorio.Size = new System.Drawing.Size(120, 13);
            this.labelApellidoObligatorio.TabIndex = 188;
            this.labelApellidoObligatorio.Text = "El apellido es obligatorio";
            this.labelApellidoObligatorio.Visible = false;
            // 
            // labelNombreObligatorio
            // 
            this.labelNombreObligatorio.AutoSize = true;
            this.labelNombreObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreObligatorio.Location = new System.Drawing.Point(215, 92);
            this.labelNombreObligatorio.Name = "labelNombreObligatorio";
            this.labelNombreObligatorio.Size = new System.Drawing.Size(119, 13);
            this.labelNombreObligatorio.TabIndex = 187;
            this.labelNombreObligatorio.Text = "El nombre es obligatorio";
            this.labelNombreObligatorio.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 186;
            this.label11.Text = "(*)Campos Obligatorios";
            // 
            // labelMailObligatorio
            // 
            this.labelMailObligatorio.AutoSize = true;
            this.labelMailObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailObligatorio.Location = new System.Drawing.Point(392, 94);
            this.labelMailObligatorio.Name = "labelMailObligatorio";
            this.labelMailObligatorio.Size = new System.Drawing.Size(102, 13);
            this.labelMailObligatorio.TabIndex = 185;
            this.labelMailObligatorio.Text = "El mail es obligatorio";
            this.labelMailObligatorio.Visible = false;
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(143, 341);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(105, 20);
            this.textBoxDepto.TabIndex = 183;
            // 
            // labelDepartamentoInvalido
            // 
            this.labelDepartamentoInvalido.AutoSize = true;
            this.labelDepartamentoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDepartamentoInvalido.Location = new System.Drawing.Point(140, 364);
            this.labelDepartamentoInvalido.Name = "labelDepartamentoInvalido";
            this.labelDepartamentoInvalido.Size = new System.Drawing.Size(111, 13);
            this.labelDepartamentoInvalido.TabIndex = 182;
            this.labelDepartamentoInvalido.Text = "DepartamentoInvalido";
            this.labelDepartamentoInvalido.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 181;
            this.label16.Text = "Departamento:";
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(32, 341);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(105, 20);
            this.textBoxPiso.TabIndex = 180;
            // 
            // labelPisoInvalido
            // 
            this.labelPisoInvalido.AutoSize = true;
            this.labelPisoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPisoInvalido.Location = new System.Drawing.Point(29, 364);
            this.labelPisoInvalido.Name = "labelPisoInvalido";
            this.labelPisoInvalido.Size = new System.Drawing.Size(69, 13);
            this.labelPisoInvalido.TabIndex = 179;
            this.labelPisoInvalido.Text = "Piso  invalido";
            this.labelPisoInvalido.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 178;
            this.label15.Text = "Numero de piso:";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(575, 135);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumeroDocumento.TabIndex = 177;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(395, 135);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(160, 20);
            this.textBoxTelefono.TabIndex = 176;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(395, 71);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail.TabIndex = 175;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(218, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(160, 20);
            this.textBoxNombre.TabIndex = 174;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(218, 135);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(160, 20);
            this.textBoxApellido.TabIndex = 173;
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(32, 396);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(216, 20);
            this.textBoxLocalidad.TabIndex = 172;
            // 
            // textBoxNumeroCalle
            // 
            this.textBoxNumeroCalle.Location = new System.Drawing.Point(32, 281);
            this.textBoxNumeroCalle.Name = "textBoxNumeroCalle";
            this.textBoxNumeroCalle.Size = new System.Drawing.Size(216, 20);
            this.textBoxNumeroCalle.TabIndex = 171;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(32, 223);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(216, 20);
            this.textBoxDireccion.TabIndex = 170;
            // 
            // labelLocalidadInvalida
            // 
            this.labelLocalidadInvalida.AutoSize = true;
            this.labelLocalidadInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLocalidadInvalida.Location = new System.Drawing.Point(29, 419);
            this.labelLocalidadInvalida.Name = "labelLocalidadInvalida";
            this.labelLocalidadInvalida.Size = new System.Drawing.Size(92, 13);
            this.labelLocalidadInvalida.TabIndex = 169;
            this.labelLocalidadInvalida.Text = "Localidad invalida";
            this.labelLocalidadInvalida.Visible = false;
            // 
            // labelNumeroDeCalleInvalido
            // 
            this.labelNumeroDeCalleInvalido.AutoSize = true;
            this.labelNumeroDeCalleInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDeCalleInvalido.Location = new System.Drawing.Point(29, 304);
            this.labelNumeroDeCalleInvalido.Name = "labelNumeroDeCalleInvalido";
            this.labelNumeroDeCalleInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNumeroDeCalleInvalido.TabIndex = 168;
            this.labelNumeroDeCalleInvalido.Text = "Numero invalido";
            this.labelNumeroDeCalleInvalido.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 167;
            this.label13.Text = "(*)Numero de calle:";
            // 
            // labelDireccionInvalida
            // 
            this.labelDireccionInvalida.AutoSize = true;
            this.labelDireccionInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDireccionInvalida.Location = new System.Drawing.Point(29, 245);
            this.labelDireccionInvalida.Name = "labelDireccionInvalida";
            this.labelDireccionInvalida.Size = new System.Drawing.Size(91, 13);
            this.labelDireccionInvalida.TabIndex = 166;
            this.labelDireccionInvalida.Text = "Direccion invalida";
            this.labelDireccionInvalida.Visible = false;
            // 
            // labelNumeroDocInvalido
            // 
            this.labelNumeroDocInvalido.AutoSize = true;
            this.labelNumeroDocInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroDocInvalido.Location = new System.Drawing.Point(572, 158);
            this.labelNumeroDocInvalido.Name = "labelNumeroDocInvalido";
            this.labelNumeroDocInvalido.Size = new System.Drawing.Size(163, 13);
            this.labelNumeroDocInvalido.TabIndex = 165;
            this.labelNumeroDocInvalido.Text = "Numero de identificación invalido";
            this.labelNumeroDocInvalido.Visible = false;
            // 
            // labelTelefonoInvalido
            // 
            this.labelTelefonoInvalido.AutoSize = true;
            this.labelTelefonoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTelefonoInvalido.Location = new System.Drawing.Point(392, 158);
            this.labelTelefonoInvalido.Name = "labelTelefonoInvalido";
            this.labelTelefonoInvalido.Size = new System.Drawing.Size(88, 13);
            this.labelTelefonoInvalido.TabIndex = 164;
            this.labelTelefonoInvalido.Text = "Telefono invalido";
            this.labelTelefonoInvalido.Visible = false;
            // 
            // labelApellidoInvalido
            // 
            this.labelApellidoInvalido.AutoSize = true;
            this.labelApellidoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelApellidoInvalido.Location = new System.Drawing.Point(215, 158);
            this.labelApellidoInvalido.Name = "labelApellidoInvalido";
            this.labelApellidoInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelApellidoInvalido.TabIndex = 163;
            this.labelApellidoInvalido.Text = "Apellido invalido";
            this.labelApellidoInvalido.Visible = false;
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(575, 69);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoDocumento.TabIndex = 162;
            // 
            // labelNombreInvalido
            // 
            this.labelNombreInvalido.AutoSize = true;
            this.labelNombreInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreInvalido.Location = new System.Drawing.Point(215, 94);
            this.labelNombreInvalido.Name = "labelNombreInvalido";
            this.labelNombreInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNombreInvalido.TabIndex = 161;
            this.labelNombreInvalido.Text = "Nombre invalido";
            this.labelNombreInvalido.Visible = false;
            // 
            // labelFechaInvalida
            // 
            this.labelFechaInvalida.AutoSize = true;
            this.labelFechaInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFechaInvalida.Location = new System.Drawing.Point(307, 246);
            this.labelFechaInvalida.Name = "labelFechaInvalida";
            this.labelFechaInvalida.Size = new System.Drawing.Size(76, 13);
            this.labelFechaInvalida.TabIndex = 160;
            this.labelFechaInvalida.Text = "Fecha invalida";
            this.labelFechaInvalida.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(307, 281);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 159;
            // 
            // buttonSeleccionarFecha
            // 
            this.buttonSeleccionarFecha.Location = new System.Drawing.Point(473, 220);
            this.buttonSeleccionarFecha.Name = "buttonSeleccionarFecha";
            this.buttonSeleccionarFecha.Size = new System.Drawing.Size(105, 23);
            this.buttonSeleccionarFecha.TabIndex = 158;
            this.buttonSeleccionarFecha.Text = "Seleccionar Fecha";
            this.buttonSeleccionarFecha.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFecha.Click += new System.EventHandler(this.buttonSeleccionarFecha_Click);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(307, 223);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(160, 20);
            this.textBoxFecha.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 156;
            this.label10.Text = "(*)Fecha de nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 154;
            this.label8.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 153;
            this.label7.Text = "(*)Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 152;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 151;
            this.label5.Text = "(*)Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "(*)Número de identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = "(*)Tipo de indentificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "(*)Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "(*)Nombre:";
            // 
            // labelMailEnUso
            // 
            this.labelMailEnUso.AutoSize = true;
            this.labelMailEnUso.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailEnUso.Location = new System.Drawing.Point(392, 94);
            this.labelMailEnUso.Name = "labelMailEnUso";
            this.labelMailEnUso.Size = new System.Drawing.Size(118, 13);
            this.labelMailEnUso.TabIndex = 146;
            this.labelMailEnUso.Text = "Ese mail ya esta en uso";
            this.labelMailEnUso.Visible = false;
            // 
            // labelMailInvalido
            // 
            this.labelMailInvalido.AutoSize = true;
            this.labelMailInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMailInvalido.Location = new System.Drawing.Point(392, 94);
            this.labelMailInvalido.Name = "labelMailInvalido";
            this.labelMailInvalido.Size = new System.Drawing.Size(106, 13);
            this.labelMailInvalido.TabIndex = 145;
            this.labelMailInvalido.Text = "Ese mail no es valido";
            this.labelMailInvalido.Visible = false;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(600, 497);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(99, 23);
            this.buttonCrear.TabIndex = 144;
            this.buttonCrear.Text = "Crear Usuario";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(71, 497);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 143;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(575, 293);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRoles.TabIndex = 199;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(572, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 198;
            this.label17.Text = "(*)Rol asignado:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(572, 355);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 200;
            this.label18.Text = "(*)Hotel asignado:";
            // 
            // labelUsuarioInvalido
            // 
            this.labelUsuarioInvalido.AutoSize = true;
            this.labelUsuarioInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUsuarioInvalido.Location = new System.Drawing.Point(34, 94);
            this.labelUsuarioInvalido.Name = "labelUsuarioInvalido";
            this.labelUsuarioInvalido.Size = new System.Drawing.Size(82, 13);
            this.labelUsuarioInvalido.TabIndex = 213;
            this.labelUsuarioInvalido.Text = "Usuario invalido";
            this.labelUsuarioInvalido.Visible = false;
            // 
            // labelContraseñaObligatoria
            // 
            this.labelContraseñaObligatoria.AutoSize = true;
            this.labelContraseñaObligatoria.ForeColor = System.Drawing.Color.DarkRed;
            this.labelContraseñaObligatoria.Location = new System.Drawing.Point(34, 158);
            this.labelContraseñaObligatoria.Name = "labelContraseñaObligatoria";
            this.labelContraseñaObligatoria.Size = new System.Drawing.Size(140, 13);
            this.labelContraseñaObligatoria.TabIndex = 211;
            this.labelContraseñaObligatoria.Text = "La contraseña es obligatoria";
            this.labelContraseñaObligatoria.Visible = false;
            // 
            // labelUsuarioObligatorio
            // 
            this.labelUsuarioObligatorio.AutoSize = true;
            this.labelUsuarioObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUsuarioObligatorio.Location = new System.Drawing.Point(35, 94);
            this.labelUsuarioObligatorio.Name = "labelUsuarioObligatorio";
            this.labelUsuarioObligatorio.Size = new System.Drawing.Size(118, 13);
            this.labelUsuarioObligatorio.TabIndex = 210;
            this.labelUsuarioObligatorio.Text = "El usuario es olbigatorio";
            this.labelUsuarioObligatorio.Visible = false;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(38, 135);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(160, 20);
            this.textBoxContraseña.TabIndex = 209;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 208;
            this.label14.Text = "(*)Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(38, 71);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(160, 20);
            this.textBoxUsuario.TabIndex = 207;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 206;
            this.label12.Text = "(*)Usuario:";
            // 
            // labelUsuarioEnUso
            // 
            this.labelUsuarioEnUso.AutoSize = true;
            this.labelUsuarioEnUso.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUsuarioEnUso.Location = new System.Drawing.Point(35, 94);
            this.labelUsuarioEnUso.Name = "labelUsuarioEnUso";
            this.labelUsuarioEnUso.Size = new System.Drawing.Size(111, 13);
            this.labelUsuarioEnUso.TabIndex = 214;
            this.labelUsuarioEnUso.Text = "El usuario esta en uso";
            this.labelUsuarioEnUso.Visible = false;
            // 
            // textBoxHotel
            // 
            this.textBoxHotel.Location = new System.Drawing.Point(575, 373);
            this.textBoxHotel.Name = "textBoxHotel";
            this.textBoxHotel.ReadOnly = true;
            this.textBoxHotel.Size = new System.Drawing.Size(160, 20);
            this.textBoxHotel.TabIndex = 215;
            // 
            // labelHotelObligatorio
            // 
            this.labelHotelObligatorio.AutoSize = true;
            this.labelHotelObligatorio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelHotelObligatorio.Location = new System.Drawing.Point(572, 425);
            this.labelHotelObligatorio.Name = "labelHotelObligatorio";
            this.labelHotelObligatorio.Size = new System.Drawing.Size(107, 13);
            this.labelHotelObligatorio.TabIndex = 216;
            this.labelHotelObligatorio.Text = "El hotel es obligatorio";
            this.labelHotelObligatorio.Visible = false;
            // 
            // buttonSeleccionarHotel
            // 
            this.buttonSeleccionarHotel.Location = new System.Drawing.Point(575, 396);
            this.buttonSeleccionarHotel.Name = "buttonSeleccionarHotel";
            this.buttonSeleccionarHotel.Size = new System.Drawing.Size(104, 23);
            this.buttonSeleccionarHotel.TabIndex = 217;
            this.buttonSeleccionarHotel.Text = "Seleccionar Hotel";
            this.buttonSeleccionarHotel.UseVisualStyleBackColor = true;
            this.buttonSeleccionarHotel.Click += new System.EventHandler(this.buttonSeleccionarHotel_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 538);
            this.Controls.Add(this.buttonSeleccionarHotel);
            this.Controls.Add(this.labelHotelObligatorio);
            this.Controls.Add(this.textBoxHotel);
            this.Controls.Add(this.labelUsuarioEnUso);
            this.Controls.Add(this.labelUsuarioInvalido);
            this.Controls.Add(this.labelContraseñaObligatoria);
            this.Controls.Add(this.labelUsuarioObligatorio);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.labelCalleObligatoria);
            this.Controls.Add(this.labelDireccionObligatoria);
            this.Controls.Add(this.labelNumeroDocObligatorio);
            this.Controls.Add(this.labelApellidoObligatorio);
            this.Controls.Add(this.labelNombreObligatorio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelMailObligatorio);
            this.Controls.Add(this.textBoxDepto);
            this.Controls.Add(this.labelDepartamentoInvalido);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPiso);
            this.Controls.Add(this.labelPisoInvalido);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonAtras);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.Label labelCalleObligatoria;
        private System.Windows.Forms.Label labelDireccionObligatoria;
        private System.Windows.Forms.Label labelNumeroDocObligatorio;
        private System.Windows.Forms.Label labelApellidoObligatorio;
        private System.Windows.Forms.Label labelNombreObligatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMailObligatorio;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.Label labelDepartamentoInvalido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label labelPisoInvalido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxNumeroCalle;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelLocalidadInvalida;
        private System.Windows.Forms.Label labelNumeroDeCalleInvalido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelDireccionInvalida;
        private System.Windows.Forms.Label labelNumeroDocInvalido;
        private System.Windows.Forms.Label labelTelefonoInvalido;
        private System.Windows.Forms.Label labelApellidoInvalido;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.Label labelNombreInvalido;
        private System.Windows.Forms.Label labelFechaInvalida;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonSeleccionarFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMailEnUso;
        private System.Windows.Forms.Label labelMailInvalido;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelUsuarioInvalido;
        private System.Windows.Forms.Label labelContraseñaObligatoria;
        private System.Windows.Forms.Label labelUsuarioObligatorio;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelUsuarioEnUso;
        private System.Windows.Forms.TextBox textBoxHotel;
        private System.Windows.Forms.Label labelHotelObligatorio;
        private System.Windows.Forms.Button buttonSeleccionarHotel;
    }
}