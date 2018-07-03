using FrbaHotel.Login;
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
        DataTable dtRoles = new DataTable();
        DataTable dtHotel = new DataTable();
        DataTable dtUsuario;
        int hotelU;
        string rol;

        public ModificarUsuario(DataTable dt1, int hotel)
        {
            hotelU = hotel;
            dtUsuario = dt1;
            UtilesSQL.inicializar();
            InitializeComponent();
            monthCalendar.MaxSelectionCount = 1;
            cargarCosas();
            llenarTextBox();
        }
        private void llenarTextBox()
        {
            textBoxContraseña.Text = dtUsuario.Rows[0][2].ToString();
            textBoxContraseña2.Text = dtUsuario.Rows[0][2].ToString();
            textBoxNombre.Text = dtUsuario.Rows[0][3].ToString();
            textBoxApellido.Text = dtUsuario.Rows[0][4].ToString();
            textBoxMail.Text = dtUsuario.Rows[0][5].ToString();
            textBoxTelefono.Text = dtUsuario.Rows[0][6].ToString();
            if (!String.IsNullOrEmpty(dtUsuario.Rows[0][7].ToString()))
            {
                DateTime fechaUser = DateTime.Parse(dtUsuario.Rows[0][7].ToString());
                textBoxFecha.Text = fechaUser.ToString("yyyy-dd-MM");
                monthCalendar.TodayDate = fechaUser;
                monthCalendar.SelectionStart = fechaUser;
            }
            else
            {
                monthCalendar.TodayDate = DateTime.Parse(Main.fecha());
                monthCalendar.SelectionStart = DateTime.Parse(Main.fecha());
            }
            textBoxDireccion.Text = dtUsuario.Rows[0][8].ToString();
            textBoxNumeroCalle.Text = dtUsuario.Rows[0][9].ToString();
            textBoxPiso.Text = dtUsuario.Rows[0][10].ToString();
            textBoxDepto.Text = dtUsuario.Rows[0][11].ToString();
            textBoxLocalidad.Text = dtUsuario.Rows[0][12].ToString();
            if (!String.IsNullOrEmpty(dtUsuario.Rows[0][13].ToString()))
            {
                comboBoxTipoDocumento.SelectedIndex = Int32.Parse(dtUsuario.Rows[0][13].ToString()) - 1;
            }
            textBoxNumeroDocumento.Text = dtUsuario.Rows[0][14].ToString();
            checkBoxHabilitado.Checked = Convert.ToBoolean(dtUsuario.Rows[0][15]);
        }
        private void cargarCosas()
        {
            SqlCommand command = UtilesSQL.crearCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento");
            SqlDataReader reader = command.ExecuteReader();
            dtDocu.Columns.Add("docu_detalle", typeof(string));
            dtDocu.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dtDocu;

            SqlCommand command2 = UtilesSQL.crearCommand("SELECT rol_nombre FROM DERROCHADORES_DE_PAPEL.Rol AS r JOIN DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel AS ru ON r.rol_id = ru.rouh_rol JOIN DERROCHADORES_DE_PAPEL.Usuario AS u ON ru.rouh_usuario = u.usur_id WHERE rol_nombre NOT IN (SELECT rol_nombre from DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre = 'ADMINISTRADOR GENERAL' OR rol_nombre = 'GUEST') AND u.usur_id = @user AND ru.rouh_hotel = @hote");
            command2.Parameters.AddWithValue("@user", dtUsuario.Rows[0][0].ToString());
            command2.Parameters.AddWithValue("@hote", hotelU);
            SqlDataReader reader2 = command2.ExecuteReader();
            dtRoles.Columns.Add("rol_nombre", typeof(string));
            dtRoles.Load(reader2);

            dataGridViewRoles.DataSource = dtRoles;
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
            labelContraseñaCoinciden.Visible = false;
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
            contraseñaValida(textBoxContraseña.Text);
            return Valido;
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
        private void contraseñaValida(string contraseña)
        {
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                labelContraseñaObligatoria.Visible = true;
                Valido = false;
            }
            else if (textBoxContraseña2.Text != contraseña)
            {
                labelContraseñaCoinciden.Visible = true;
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
            SqlCommand command1 = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Usuario SET usur_password = @pass, usur_nombre = @nom, usur_apellido = @ape, usur_mail = @mail, usur_telefono = @tel, usur_fechaDeNacimiento = CONVERT(datetime, @fecha, 121), usur_calle = @calle, usur_numeroDeCalle = @numCalle, usur_piso = @piso, usur_departamento = @depto, usur_localidad = @loc, usur_tipoDeDocumento = @doc, usur_numeroDeDocumento = @numDoc, usur_habilitado = @hab WHERE usur_id = @id");
            if (textBoxContraseña.Text == dtUsuario.Rows[0][2].ToString())
            { command1.Parameters.AddWithValue("@pass", textBoxContraseña.Text); }
            else
            { command1.Parameters.AddWithValue("@pass", sha256.GenerarSHA256String(textBoxContraseña.Text)); }
            command1.Parameters.AddWithValue("@nom", textBoxNombre.Text);
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
            command1.Parameters.AddWithValue("@id", dtUsuario.Rows[0][0].ToString());
            UtilesSQL.ejecutarComandoNonQuery(command1);

            SqlCommand command2 = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel SET rouh_habilitado = 0 WHERE rouh_usuario = @user AND rouh_hotel = @hotel");
            command2.Parameters.AddWithValue("@user", dtUsuario.Rows[0][0].ToString());
            command2.Parameters.AddWithValue("@hotel", hotelU);
            UtilesSQL.ejecutarComandoNonQuery(command2);

            foreach (DataGridViewRow row in dataGridViewRoles.Rows)
            {
                command2 = UtilesSQL.crearCommand("DERROCHADORES_DE_PAPEL.ModificarRolesUsuario");
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("@rol", SqlDbType.NVarChar).Value = row.Cells[0].Value.ToString();
                command2.Parameters.AddWithValue("@hotel", SqlDbType.BigInt).Value = hotelU;
                command2.Parameters.AddWithValue("@user", SqlDbType.BigInt).Value = dtUsuario.Rows[0][0];
                UtilesSQL.ejecutarComandoNonQuery(command2);
            }

            MessageBox.Show("Modificación exitosa!");
            this.Close();
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd");
        }
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarRol_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = UtilesSQL.crearCommand("SELECT rol_nombre FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre NOT IN (SELECT rol_nombre  from DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre = 'ADMINISTRADOR GENERAL' OR rol_nombre = 'GUEST')");
            SqlDataReader reader2 = command2.ExecuteReader();
            DataTable dtRol = new DataTable();
            dtRol.Columns.Add("rol_nombre", typeof(string));
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dtRol.Columns["rol_nombre"];
            dtRol.PrimaryKey = keyColumns;
            dtRol.Load(reader2);

            foreach (DataRow row in dtRoles.Rows)
            {
                for (int i = 0; i < dtRol.Rows.Count; i++)
                {
                    if (dtRol.Rows[i][0].ToString() == row[0].ToString())
                    {
                        dtRol.Rows.RemoveAt(i);
                    }
                }
            }

            if (dtRol.Rows.Count == 0)
            {
                MessageBox.Show("No hay mas roles para agregar");
                return;
            }
            else
            {
                SeleccionarRol f1 = new SeleccionarRol(dtRol);
                f1.ShowDialog();
                rol = f1.rol;
                if (f1.rol != null)
                {
                    dtRoles.Rows.Add(rol);
                }
            }
        }
        private void buttonQuitarRol_Click(object sender, EventArgs e)
        {
            if (dtRoles.Rows.Count != 0)
            {
                dtRoles.Rows.RemoveAt(dataGridViewRoles.CurrentCell.RowIndex);
            }
        }
    }
}
