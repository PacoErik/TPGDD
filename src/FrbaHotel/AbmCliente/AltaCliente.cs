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

namespace FrbaHotel.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private SqlCommand command;
        private SqlCommand command2;
        bool Valido = true;
        bool teleNull = false;
        bool pisoNull = false;
        bool deptoNull = false;
        bool locNull = false;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataReader reader;
        SqlDataReader reader2;

        public AltaCliente()
        {
            UtilesSQL.inicializar();
            InitializeComponent();
            cargarComboBox();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarComboBox()
        {
            command = UtilesSQL.crearCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento");
            reader = command.ExecuteReader();
            dt.Columns.Add("docu_detalle", typeof(string));
            dt.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dt;

            command2 = UtilesSQL.crearCommand("SELECT naci_detalle from DERROCHADORES_DE_PAPEL.Nacionalidad");
            reader2 = command2.ExecuteReader();
            dt2.Columns.Add("naci_detalle", typeof(string));
            dt2.Load(reader2);

            comboBoxNacionalidad.ValueMember = "naci_detalle";
            comboBoxNacionalidad.DataSource = dt2;
        }

        private bool checkearDatos()
        {
            Valido = true;
            nacionalidadValida(comboBoxNacionalidad.Text);
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
            return Valido;
        }
       
        private void nacionalidadValida(string nac)
        {
            if (string.IsNullOrWhiteSpace(nac))
            {
                labelNacionalidadObligatoria.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(nac.All(Char.IsLetter)))
                {
                    labelNumeroDeCalleInvalido.Visible = true;
                    Valido = false;
                }
            }
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
       
        private void realizarCambios()
        {
            command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Cliente (clie_nombre, clie_apellido, clie_mail, clie_telefono, clie_fechaDeNacimiento, clie_calle, clie_numeroDeCalle, clie_piso, clie_departamento, clie_localidad, clie_tipoDeDocumento, clie_numeroDeDocumento, clie_habilitado, clie_nacionalidad) VALUES (@nom, @ape, @mail, @tel, @fecha, @calle, @numCalle, @piso, @depto, @loc, @doc, @numeroDoc, @habilitado, @nac)");
            command.Parameters.AddWithValue("@nom", textBoxNombre.Text);
            command.Parameters.AddWithValue("@ape", textBoxApellido.Text);
            command.Parameters.AddWithValue("@mail", textBoxMail.Text);
            if (teleNull)
            { command.Parameters.AddWithValue("@tel", DBNull.Value);}
            else
            { command.Parameters.AddWithValue("@tel", textBoxTelefono.Text); }
            command.Parameters.AddWithValue("@doc", comboBoxTipoDocumento.SelectedIndex + 1);
            command.Parameters.AddWithValue("@numeroDoc", textBoxNumeroDocumento.Text);
            command.Parameters.AddWithValue("@calle", textBoxDireccion.Text);
            command.Parameters.AddWithValue("@numCalle", textBoxNumeroCalle.Text);
            if (pisoNull)
            { command.Parameters.AddWithValue("@piso", DBNull.Value); }
            else
            { command.Parameters.AddWithValue("@piso", textBoxPiso.Text); }
            if (deptoNull)
            { command.Parameters.AddWithValue("@depto", DBNull.Value); }
            else
            { command.Parameters.AddWithValue("@depto", textBoxDepto.Text); }
            if (locNull)
            { command.Parameters.AddWithValue("@loc", DBNull.Value); }
            else
            { command.Parameters.AddWithValue("@loc", textBoxLocalidad.Text); }
            command.Parameters.AddWithValue("@nac", comboBoxNacionalidad.SelectedIndex + 1);
            command.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            command.Parameters.AddWithValue("@habilitado", checkBoxHabilitado.Checked);
            UtilesSQL.ejecutarComandoNonQuery(command);
            MessageBox.Show("Creación exitosa!");
            this.Close();
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
            labelNacionalidadObligatoria.Visible = false;
            teleNull = false;
            pisoNull = false;
            deptoNull = false;
            locNull = false;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
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

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}