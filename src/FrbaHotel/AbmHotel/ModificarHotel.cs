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
    public partial class ModificarHotel : Form
    {
        DataTable dtH = new DataTable();
        bool Valido = true;
        DataTable dtRegimen = new DataTable();
        DataTable dtRegimen2 = new DataTable();

        public ModificarHotel(DataTable dtHotel)
        {
            dtH = dtHotel;
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
            textBoxNombre.Text = dtH.Rows[0][1].ToString();
            textBoxMail.Text = dtH.Rows[0][2].ToString();
            textBoxTelefono.Text = dtH.Rows[0][3].ToString();
            textBoxDireccion.Text = dtH.Rows[0][4].ToString();
            textBoxNumeroCalle.Text = dtH.Rows[0][5].ToString();
            textBoxLocalidad.Text = dtH.Rows[0][6].ToString();
            comboBoxEstrellas.SelectedIndex = Int32.Parse(dtH.Rows[0][7].ToString());
            textBoxCiudad.Text = dtH.Rows[0][9].ToString();
            textBoxPais.Text = dtH.Rows[0][10].ToString();
            if (!String.IsNullOrEmpty(dtH.Rows[0][11].ToString()))
            { textBoxFecha.Text = DateTime.Parse(dtH.Rows[0][11].ToString()).ToString("yyyy-dd-MM HH:mm:ss.fff"); }

            SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT regi_descripcion FROM DERROCHADORES_DE_PAPEL.Regimen");
            dtRegimen.Columns.Add(new DataColumn("Seleccionado", typeof(bool)));
            sda.Fill(dtRegimen);
            dataGridViewRegimenes.DataSource = dtRegimen;

            string commandString = "SELECT * FROM DERROCHADORES_DE_PAPEL.RegimenXHotel WHERE rexh_hotel = @idH";
            sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@idH", Int32.Parse(dtH.Rows[0][0].ToString()));
            sda.Fill(dtRegimen2);
            int pos = 0;
            int pos2 = 1;
            if (dtRegimen2.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewRegimenes.Rows)
                {
                    if (Int32.Parse(dtRegimen2.Rows[pos][0].ToString()) == pos2)
                    {
                        row.Cells[0].Value = true;
                        pos++;
                    }
                    pos2++;
                }
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd");
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
                DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
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

        private void buttonModificar_Click(object sender, EventArgs e)
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
            //Modifica el hotel
            SqlCommand com = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Hotel SET hote_nombre=@nom, hote_mail=@mail, hote_telefono=@tel, hote_calle=@calle, hote_numeroDeCalle=@numCalle, hote_localidad=@loc, hote_estrellas=@estr, hote_ciudad=@ciudad, hote_pais=@pais, hote_fechaDeCreacion=CONVERT(datetime, @fecha) WHERE hote_id = @id");
            com.Parameters.AddWithValue("@nom", textBoxNombre.Text);
            com.Parameters.AddWithValue("@mail", textBoxMail.Text);
            com.Parameters.AddWithValue("@tel", textBoxTelefono.Text);
            com.Parameters.AddWithValue("@calle", textBoxDireccion.Text);
            com.Parameters.AddWithValue("@numCalle", textBoxNumeroCalle.Text);
            com.Parameters.AddWithValue("@loc", textBoxLocalidad.Text);
            com.Parameters.AddWithValue("@estr", comboBoxEstrellas.SelectedIndex);
            com.Parameters.AddWithValue("@ciudad", textBoxCiudad.Text);
            com.Parameters.AddWithValue("@pais", textBoxPais.Text);
            com.Parameters.AddWithValue("@fecha", textBoxFecha.Text);
            com.Parameters.AddWithValue("@id", Int32.Parse(dtH.Rows[0][0].ToString()));
            UtilesSQL.ejecutarComandoNonQuery(com);
            
            //Modifica los regimenes
            int i = 1;
            SqlCommand com1;
            foreach (DataGridViewRow row in dataGridViewRegimenes.Rows)
            {
                if (row.Cells[0].Value.ToString() == false.ToString()) //Checkea si el regimen esta seleccionado
                {
                    if (!hotelTieneRegimen(i)) //Checkea que no haya huespedes o reservas en ese regimen
                    {
                        com = UtilesSQL.crearCommand("DELETE FROM DERROCHADORES_DE_PAPEL.RegimenXHotel WHERE rexh_regimen = @reg AND rexh_hotel = @hotel");
                        com.Parameters.AddWithValue("@reg", i);
                        com.Parameters.AddWithValue("@hotel", Int32.Parse(dtH.Rows[0][0].ToString()));
                        UtilesSQL.ejecutarComandoNonQuery(com);
                    }
                    else
                    {   //Si hay huespedes o reservas no se modifica ese regimen
                        MessageBox.Show("No es posible desactivar el regimen: " + dtRegimen.Rows[i][1].ToString() + " ya que este hotel tiene reservas o huespedes bajo el mismo");
                    }
                }
                else
                {
                    if (!regimenIncorporado(i)) //Se fija si el regimen no esta en efecto
                    {
                        com1 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.RegimenXHotel VALUES (@reg, @hotel)");
                        com1.Parameters.AddWithValue("@reg", i);
                        com1.Parameters.AddWithValue("@hotel", Int32.Parse(dtH.Rows[0][0].ToString()));
                        UtilesSQL.ejecutarComandoNonQuery(com1);
                    }
                }
                i++;
            }

            MessageBox.Show("Modificación exitosa!");
        }
        private bool regimenIncorporado(int reg)
        {
            for (int i = 0; i < dtRegimen2.Rows.Count; i++)
            {
                if (reg == Int32.Parse(dtRegimen2.Rows[i][0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private bool hotelTieneRegimen(int reg)
        {
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Estadia AS e JOIN DERROCHADORES_DE_PAPEL.Reserva AS r ON r.rese_codigo = e.esta_reserva WHERE e.esta_fechaDeFin > @fecha AND r.rese_fin > @fecha AND r.rese_regimen = @reg AND r.rese_hotel = @hotel");
            sda.SelectCommand.Parameters.AddWithValue("@reg", reg);
            sda.SelectCommand.Parameters.AddWithValue("@fecha", Convert.ToDateTime(Main.fecha()));
            sda.SelectCommand.Parameters.AddWithValue("@hotel", Int32.Parse(dtH.Rows[0][0].ToString()));
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0) //No existen reservas o estadias con ese regimen
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
