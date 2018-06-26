using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class ModificarCliente : Form
    {
        bool Valido;
        private SqlCommand command;
        private SqlCommand command2;
        DataTable dt;
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        Form f1;
        int id;
        bool teleNull = false;
        bool pisoNull = false;
        bool deptoNull = false;
        bool locNull = false;

        public ModificarCliente(Form f, DataTable DataT)
        {
            UtilesSQL.inicializar();
            id = Int32.Parse(DataT.Rows[0][13].ToString());
            dt = DataT;
            f1 = f;
            InitializeComponent();
            llenarTextBoxs();
        }
        private void llenarTextBoxs()
        {
            cargarComboBox();
            comboBoxNacionalidad.SelectedIndex = Int32.Parse(dt.Rows[0][0].ToString()) - 1;
            textBoxNombre.Text = dt.Rows[0][1].ToString();
            textBoxApellido.Text = dt.Rows[0][2].ToString();
            textBoxMail.Text = dt.Rows[0][3].ToString();
            textBoxTelefono.Text = dt.Rows[0][4].ToString();
            textBoxFecha.Text = DateTime.Parse(dt.Rows[0][5].ToString()).ToString("yyyy-MM-dd");
            textBoxDireccion.Text = dt.Rows[0][6].ToString();
            textBoxNumeroCalle.Text = dt.Rows[0][7].ToString();
            textBoxPiso.Text = dt.Rows[0][8].ToString();
            textBoxDepto.Text = dt.Rows[0][9].ToString();
            textBoxLocalidad.Text = dt.Rows[0][10].ToString();
            comboBoxTipoDocumento.SelectedIndex = Int32.Parse(dt.Rows[0][11].ToString())-1;
            textBoxNumeroDocumento.Text = dt.Rows[0][12].ToString();
        }
        private void cargarComboBox()
        {
            dt2.Clear();
            dt3.Clear();
            command = UtilesSQL.crearCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento");
            SqlDataReader reader;

            reader = command.ExecuteReader();
            dt2.Columns.Add("docu_detalle", typeof(string));
            dt2.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dt2;

            SqlDataReader reader2;
            command2 = UtilesSQL.crearCommand("SELECT naci_detalle from DERROCHADORES_DE_PAPEL.Nacionalidad");
            reader2 = command2.ExecuteReader();
            dt3.Columns.Add("naci_detalle", typeof(string));
            dt3.Load(reader2);

            comboBoxNacionalidad.ValueMember = "naci_detalle";
            comboBoxNacionalidad.DataSource = dt3;
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
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
                DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
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
            if (piso == null)
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
                dt4.Clear();
                SqlDataAdapter sda = UtilesSQL.crearDataAdapter("select clie_id from DERROCHADORES_DE_PAPEL.Cliente where clie_mail = @mail");
                sda.SelectCommand.Parameters.AddWithValue("@mail", mail);
                sda.Fill(dt3);
                if (dt4.Rows.Count == 0) //El mail no esta en uso
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
                else
                {
                    if(dt4.Rows[0][0].ToString() == id.ToString())  //el mail esta en uso pero por ese usuario
                    {
                        labelMailEnUso.Visible = Enabled;
                        Valido = false;
                    }
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
            command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Cliente SET clie_nombre = @nom, clie_apellido = @ape, clie_mail = @mail, clie_telefono = @tel, clie_tipoDeDocumento = @doc, clie_numeroDeDocumento = @numeroDoc, clie_calle = @calle, clie_numeroDeCalle = @numCalle, clie_piso = @piso, clie_departamento = @depto, clie_localidad = @loc, clie_nacionalidad = @nac, clie_fechaDeNacimiento = CONVERT(datetime, @fecha), clie_habilitado = @habilitado WHERE clie_id = @id");
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
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Cambios exitosos!");
            f1.Show();
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
    }
}
