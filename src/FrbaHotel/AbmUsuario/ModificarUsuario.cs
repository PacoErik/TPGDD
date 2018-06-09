﻿using FrbaHotel.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class ModificarUsuario : Form
    {
        SHA sha256 = new SHA();
        bool Valido = true;
        bool teleNull = false;
        bool pisoNull = false;
        bool deptoNull = false;
        bool locNull = false;
        DataTable dtDocu = new DataTable();
        DataTable dtRol = new DataTable();
        DataTable dtHotel = new DataTable();
        DataTable dt;
        int hotelU;

        public ModificarUsuario(DataTable dt1, int hotel)
        {
            hotelU = hotel;
            dt = dt1;
            UtilesSQL.inicializar();
            InitializeComponent();
            cargarComboBox();
            llenarTextBox();
        }
        private void llenarTextBox()
        {
            textBoxUsuario.Text = dt.Rows[0][1].ToString();
            textBoxContraseña.Text = dt.Rows[0][2].ToString();
            textBoxNombre.Text = dt.Rows[0][3].ToString();
            textBoxApellido.Text = dt.Rows[0][4].ToString();
            textBoxMail.Text = dt.Rows[0][5].ToString();
            textBoxTelefono.Text = dt.Rows[0][6].ToString();
            textBoxFecha.Text = DateTime.Parse(dt.Rows[0][7].ToString()).ToString("yyyy-MM-dd HH:mm:ss.fff");
            textBoxDireccion.Text = dt.Rows[0][8].ToString();
            textBoxNumeroCalle.Text = dt.Rows[0][9].ToString();
            textBoxPiso.Text = dt.Rows[0][10].ToString();
            textBoxDepto.Text = dt.Rows[0][11].ToString();
            textBoxLocalidad.Text = dt.Rows[0][12].ToString();
            comboBoxTipoDocumento.SelectedIndex = Int32.Parse(dt.Rows[0][13].ToString()) - 1;
            textBoxNumeroDocumento.Text = dt.Rows[0][14].ToString();
            checkBoxHabilitado.Checked = Convert.ToBoolean(dt.Rows[0][15]);
            textBoxHotel.Text = hotelU.ToString();
        }
        private void cargarComboBox()
        {
            SqlCommand command = UtilesSQL.crearCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento");
            SqlDataReader reader = command.ExecuteReader();
            dtDocu.Columns.Add("docu_detalle", typeof(string));
            dtDocu.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dtDocu;

            SqlCommand command2 = UtilesSQL.crearCommand("SELECT rol_nombre FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre NOT IN (SELECT rol_nombre  from DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre = 'ADMINISTRADOR GENERAL')");
            SqlDataReader reader2 = command2.ExecuteReader();
            dtRol.Columns.Add("rol_nombre", typeof(string));
            dtRol.Load(reader2);

            comboBoxRoles.ValueMember = "rol_nombre";
            comboBoxRoles.DataSource = dtRol;
        }

        private void resetearTextBox()
        {
            labelNombreInvalido.Visible = false;
            labelMailEnUso.Visible = false;
            labelMailInvalido.Visible = false;
            labelFechaInvalida.Visible = false;
            labelApellidoInvalido.Visible = false;
            labelTelefonoInvalido.Visible = false;
            labelDireccionInvalida.Visible = false;
            labelNumeroDeCalleInvalido.Visible = false;
            labelPisoInvalido.Visible = false;
            labelDepartamentoInvalido.Visible = false;
            labelLocalidadInvalida.Visible = false;
            labelTelefonoInvalido.Visible = false;
            labelNombreObligatorio.Visible = false;
            labelApellidoObligatorio.Visible = false;
            labelCalleObligatoria.Visible = false;
            labelDireccionObligatoria.Visible = false;
            labelNumeroDocObligatorio.Visible = false;
            labelMailObligatorio.Visible = false;
            labelContraseñaObligatoria.Visible = false;
            labelUsuarioInvalido.Visible = false;
            labelUsuarioObligatorio.Visible = false;
            labelUsuarioEnUso.Visible = false;
            labelHotelObligatorio.Visible = false;
        }

        private bool checkearDatos()
        {
            Valido = true;
            nombreValido(textBoxNombre.Text);
            mailValido(textBoxMail.Text);
            apellidoValido(textBoxApellido.Text);
            telefonoValido(textBoxTelefono.Text);
            numeroDocumentoValido(textBoxNumeroDocumento.Text);
            direccionValida(textBoxDireccion.Text);
            numeroCalleValido(textBoxNumeroCalle.Text);
            fechaNacimientoValida(textBoxFecha.Text);
            numeroPisoValido(textBoxPiso.Text);
            deptoValido(textBoxDepto.Text);
            localidadValida(textBoxLocalidad.Text);
            usernameValido(textBoxUsuario.Text);
            contraseñaValida(textBoxContraseña.Text);
            hotelValido(textBoxHotel.Text);
            return Valido;
        }

        private bool dateTimeValido(string date)
        {
            try
            {
                DateTime dateTime = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void fechaNacimientoValida(string fecha)
        {
            if (!(dateTimeValido(fecha)))
            {
                labelFechaInvalida.Visible = true;
                Valido = false;
            }
        }
        private void numeroPisoValido(string piso)
        {
            if (string.IsNullOrWhiteSpace(piso))
            {
                pisoNull = true;
            }
            else
            {
                if (!(piso.All(Char.IsDigit)))
                {
                    labelPisoInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void localidadValida(string loc)
        {
            if (string.IsNullOrWhiteSpace(loc))
            {
                locNull = true;
            }
            else
            {
                if (!(loc.All(Char.IsLetter)))
                {
                    labelLocalidadInvalida.Visible = true;
                    Valido = false;
                }
            }
        }
        private void deptoValido(string depto)
        {
            if (string.IsNullOrWhiteSpace(depto))
            {
                deptoNull = true;
            }
            else
            {
                if (!(depto.All(Char.IsLetter)))
                {
                    labelDepartamentoInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void numeroCalleValido(string num)
        {
            if (string.IsNullOrWhiteSpace(num))
            {
                labelCalleObligatoria.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(num.All(Char.IsDigit)))
                {
                    labelNumeroDeCalleInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void direccionValida(string dir)
        {
            if (string.IsNullOrWhiteSpace(dir))
            {
                labelDireccionObligatoria.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(Regex.IsMatch(dir, @"^[\d \w \s]+$")))
                {
                    labelDireccionInvalida.Visible = true;
                    Valido = false;
                }
            }
        }
        private void numeroDocumentoValido(string num)
        {
            if (string.IsNullOrWhiteSpace(num))
            {
                labelNumeroDocObligatorio.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(num.All(Char.IsDigit)))
                {
                    labelNumeroDocInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void nombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                labelNombreObligatorio.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(nombre.All(Char.IsLetter)))
                {
                    labelNombreInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void mailValido(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                labelMailObligatorio.Visible = true;
                Valido = false;
            }
            else
            {
                DataTable dt3 = new DataTable();
                SqlDataAdapter sda = UtilesSQL.crearDataAdapter("select clie_id from DERROCHADORES_DE_PAPEL.Cliente where clie_mail = @mail");
                sda.SelectCommand.Parameters.AddWithValue("@mail", mail);
                sda.Fill(dt3);
                if (dt3.Rows.Count == 0) //El mail no esta en uso
                {
                    if (mail == "")
                    {
                        labelMailObligatorio.Visible = true;
                        Valido = false;
                    }
                    else
                    {
                        try
                        {
                            MailAddress m = new MailAddress(mail);
                        }
                        catch (FormatException)
                        {
                            labelMailInvalido.Visible = true;
                            Valido = false;
                        }
                    }
                }
                else
                {
                    labelMailEnUso.Visible = Enabled;
                    Valido = false;
                }
            }

        }
        private void apellidoValido(string ape)
        {
            if (string.IsNullOrWhiteSpace(ape))
            {
                labelApellidoObligatorio.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(ape.All(Char.IsLetter)))
                {
                    labelApellidoInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void telefonoValido(string tel)
        {
            if (String.IsNullOrEmpty(tel))
            {
                teleNull = true;
            }
            else
            {
                if (!(tel.All(Char.IsDigit)))
                {
                    labelTelefonoInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void usernameValido(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                labelUsuarioObligatorio.Visible = true;
                Valido = false;
            }
            else
            {
                DataTable dtUsuario = new DataTable();
                SqlDataAdapter sda = UtilesSQL.crearDataAdapter("select usur_username from DERROCHADORES_DE_PAPEL.Usuario where usur_username = @user");
                sda.SelectCommand.Parameters.AddWithValue("@user", username);
                sda.Fill(dtUsuario);
                if (dtUsuario.Rows.Count == 0) //El mail no esta en uso
                {
                    if (!(username.All(Char.IsLetter)))
                    {
                        labelUsuarioInvalido.Visible = true;
                        Valido = false;
                    }
                }
                else
                {
                    labelUsuarioEnUso.Visible = Enabled;
                    Valido = false;
                }
            }
        }
        private void contraseñaValida(string contraseña)
        {
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                labelContraseñaObligatoria.Visible = true;
                Valido = false;
            }
        }
        private void hotelValido(string hotel)
        {
            if (string.IsNullOrWhiteSpace(hotel))
            {
                labelHotelObligatorio.Visible = true;
                Valido = false;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que los datos son correctos?", "Esta seguro?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                resetearTextBox();
                checkearDatos();
                if (Valido)
                {
                    realizarCambios();
                }
            }
        }
        private void realizarCambios()
        {
            SqlCommand command1 = UtilesSQL.crearCommand("");
            command1.Parameters.AddWithValue("@user", textBoxUsuario.Text);
            command1.Parameters.AddWithValue("@pass", sha256.GenerarSHA256String(textBoxContraseña.Text));
            command1.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
            command1.Parameters.AddWithValue("@ape", textBoxApellido.Text);
            command1.Parameters.AddWithValue("@mail", textBoxMail.Text);
            if (teleNull)
            { command1.Parameters.AddWithValue("@tel", DBNull.Value); }
            else
            { command1.Parameters.AddWithValue("@tel", textBoxTelefono.Text); }
            command1.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            command1.Parameters.AddWithValue("@calle", textBoxDireccion.Text);
            command1.Parameters.AddWithValue("@numCalle", textBoxNumeroCalle.Text);
            if (pisoNull)
            { command1.Parameters.AddWithValue("@piso", DBNull.Value); }
            else
            { command1.Parameters.AddWithValue("@piso", textBoxPiso.Text); }
            if (deptoNull)
            { command1.Parameters.AddWithValue("@depto", DBNull.Value); }
            else
            { command1.Parameters.AddWithValue("@depto", textBoxDepto.Text); }
            if (locNull)
            { command1.Parameters.AddWithValue("@loc", DBNull.Value); }
            else
            { command1.Parameters.AddWithValue("@loc", textBoxLocalidad.Text); }
            command1.Parameters.AddWithValue("@doc", comboBoxTipoDocumento.SelectedIndex + 1);
            command1.Parameters.AddWithValue("@numDoc", textBoxNumeroDocumento.Text);
            command1.Parameters.AddWithValue("@hab", checkBoxHabilitado.Checked);
            UtilesSQL.ejecutarComandoNonQuery(command1);

            MessageBox.Show("Modificación exitosa!");
            this.Close();
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        private void buttonSeleccionarHotel_Click(object sender, EventArgs e)
        {
            SeleccionarHotel f1 = new SeleccionarHotel();
            f1.ShowDialog();
            textBoxHotel.Text = f1.Hotel;
        }
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
