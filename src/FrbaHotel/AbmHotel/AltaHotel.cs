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

namespace FrbaHotel.AbmHotel
{
    public partial class AltaHotel : Form
    {
        int userId;
        DataTable dtRegimen = new DataTable();
        bool Valido = true;

        public AltaHotel(int idU)
        {
            userId = idU;
            UtilesSQL.inicializar();
            InitializeComponent();
            cargarCosas();
        }
        private void cargarCosas()
        {
            for (int i = 0; i < 6; i++)
            {
                comboBoxEstrellas.Items.Add(i);
            }
            comboBoxEstrellas.SelectedIndex = 0;
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT regi_descripcion FROM DERROCHADORES_DE_PAPEL.Regimen");
            dtRegimen.Columns.Add(new DataColumn("Seleccionado", typeof(bool)));
            sda.Fill(dtRegimen);
            dataGridViewRegimenes.DataSource = dtRegimen;
        }

        private void resetearLabels()
        {
            labelNombreInvalido.Visible = false;
            labelMailEnUso.Visible = false;
            labelMailInvalido.Visible = false;
            labelFechaInvalida.Visible = false;
            labelTelefonoInvalido.Visible = false;
            labelDireccionInvalida.Visible = false;
            labelNumeroDeCalleInvalido.Visible = false;
            labelCiudadInvalida.Visible = false;
            labelTelefonoInvalido.Visible = false;
            labelNombreObligatorio.Visible = false;
            labelCalleObligatoria.Visible = false;
            labelDireccionObligatoria.Visible = false;
            labelMailObligatorio.Visible = false;
            RegimenInvalido.Visible = false;
            labelCiudadNoEscrita.Visible = false;
            labelNumeroDeCalleObligatorio.Visible = false;
            labelTelefonoNoSeleccionado.Visible = false;
            labelPaisInvalido.Visible = false;
            labelPaisVacio.Visible = false;
            labelLocalidadInvalida.Visible = false;
            labelLocalidadNoIndicada.Visible = false;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-dd-MM HH:mm:ss.fff");
        }


        private bool checkearDatos()
        {
            Valido = true;
            nombreValido(textBoxNombre.Text);
            mailValido(textBoxMail.Text);
            telefonoValido(textBoxTelefono.Text);
            direccionValida(textBoxDireccion.Text);
            numeroCalleValido(textBoxNumeroCalle.Text);
            fechaCreacionValida(textBoxFecha.Text);
            ciudadValida(textBoxCiudad.Text);
            regimenValido();
            localidadValida(textBoxLocalidad.Text);
            paisValido(textBoxPais.Text);
            return Valido;
        }

        private bool dateTimeValido(string date)
        {
            try
            {
                DateTime dateTime = DateTime.ParseExact(date, "yyyy-dd-MM HH:mm:ss.fff", CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void fechaCreacionValida(string fecha)
        {
            if (!(dateTimeValido(fecha)))
            {
                labelFechaInvalida.Visible = true;
                Valido = false;
            }
        }
        private void ciudadValida(string loc)
        {
            if (string.IsNullOrWhiteSpace(loc))
            {
                labelCiudadNoEscrita.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(loc.All(Char.IsLetter)))
                {
                    labelCiudadInvalida.Visible = true;
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
        private void telefonoValido(string tel)
        {
            if (String.IsNullOrEmpty(tel))
            {
                labelTelefonoNoSeleccionado.Visible = true;
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
        private void localidadValida(string loc)
        {
            if (string.IsNullOrWhiteSpace(loc))
            {
                labelLocalidadNoIndicada.Visible = true;
                Valido = false;
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
        private void paisValido(string pais)
        {
            if (string.IsNullOrWhiteSpace(pais))
            {
                labelPaisVacio.Visible = true;
                Valido = false;
            }
            else
            {
                if (!(pais.All(Char.IsLetter)))
                {
                    labelPaisInvalido.Visible = true;
                    Valido = false;
                }
            }
        }
        private void regimenValido()
        {
            Valido = false;
            RegimenInvalido.Visible = true;
            foreach (DataGridViewRow row in dataGridViewRegimenes.Rows) //Se fija que alguno de los regimenes fue seleccionado
            {
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    Valido = true;
                    RegimenInvalido.Visible = false;
                }
            }
        }


        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que los datos son correctos?", "Esta seguro?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                resetearLabels();
                checkearDatos();
                if (Valido)
                {
                    realizarCambios();
                    this.Close();
                }
            }
        }
        private void realizarCambios()
        {
            //Crea el hotel
            SqlCommand com = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Hotel (hote_nombre, hote_mail, hote_telefono, hote_calle, hote_numeroDeCalle, hote_localidad, hote_estrellas, hote_recargaEstrella, hote_ciudad, hote_pais, hote_fechaDeCreacion) VALUES (@nom, @mail, @tel, @calle, @numCalle, @loc, @estr, @recEstr, @ciudad, @pais, @fecha)");
            com.Parameters.AddWithValue("@nom", textBoxNombre.Text);
            com.Parameters.AddWithValue("@mail", textBoxMail.Text);
            com.Parameters.AddWithValue("@tel", textBoxTelefono.Text);
            com.Parameters.AddWithValue("@calle", textBoxDireccion.Text);
            com.Parameters.AddWithValue("@numCalle", textBoxNumeroCalle.Text);
            com.Parameters.AddWithValue("@loc", textBoxLocalidad.Text);
            com.Parameters.AddWithValue("@estr", comboBoxEstrellas.SelectedIndex);
            com.Parameters.AddWithValue("@recEstr", 10);
            com.Parameters.AddWithValue("@ciudad", textBoxCiudad.Text);
            com.Parameters.AddWithValue("@pais", textBoxPais.Text);
            com.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            UtilesSQL.ejecutarComandoNonQuery(com);

            com = UtilesSQL.crearCommand("SELECT COUNT(*) FROM DERROCHADORES_DE_PAPEL.Hotel");
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            var hoteId = dr.GetInt32(0);
            dr.Close();

            //Crea los regimenes que esten seleccionados
            SqlCommand com1;
            int i = 0;
            foreach (DataGridViewRow row in dataGridViewRegimenes.Rows) 
            {
                i++;
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    com1 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.RegimenXHotel VALUES (@reg, @hote)");
                    com1.Parameters.AddWithValue("@reg", i);
                    com1.Parameters.AddWithValue("@hote", hoteId);
                    UtilesSQL.ejecutarComandoNonQuery(com1);
                }
            }

            //Asigna el rol de administrador del hotel al usuario logueado
            SqlCommand com2;
            com2 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel VALUES (2, @user, @hotel, 1)");
            com2.Parameters.AddWithValue("@user", userId);
            com2.Parameters.AddWithValue("@hotel", hoteId);
            UtilesSQL.ejecutarComandoNonQuery(com2);

            //Asigna al usuario guest el rol de guest para el hotel creado
            SqlCommand com3;
            com3 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel VALUES (4, 2, @hotel, 1)");
            com3.Parameters.AddWithValue("@hotel", hoteId);
            UtilesSQL.ejecutarComandoNonQuery(com3);

            MessageBox.Show("Creacion exitosa!");
        }
    }
}
