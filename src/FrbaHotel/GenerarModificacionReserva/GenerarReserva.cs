using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : Form
    {
        //Reserva
        private Reserva reserva = new Reserva();
        private List<Habitacion> habitaciones_disponibles = new List<Habitacion>();

        //SQL
        private SqlCommand command;
        //Tablas
        DataTable hoteles = new DataTable();
        DataTable regimenes = new DataTable();
        DataTable tipo_habitaciones = new DataTable();
        DataTable habitaciones = new DataTable();
        DataTable estados_reserva = new DataTable();

        public GenerarReserva(int id_usuario, string id_hotel)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            reserva.usuario = id_usuario;
            reserva.hotel.ID = Convert.ToInt32(id_hotel);
            btn_cargar_opciones.Text = "Cargar opciones";
            DateTime fecha = Convert.ToDateTime(Main.fecha());
            //DateTime fecha = DateTime.ParseExact(Main.fecha(), "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            reserva.fecha_que_se_realizo_reserva = fecha;
            reserva.fecha_desde = fecha;
            reserva.fecha_hasta = fecha;
            date_desde.Value = date_desde.MinDate = fecha;
            date_hasta.Value = date_hasta.MinDate = fecha;
            lbl_error_fecha.Visible = false;
            lbl_error_personas.Visible = false;
            lbl_error_carga_hotel.Visible = false;
            reserva.personas = 0;
            //Inicializaciones
            cbox_regimenes.Enabled = false;
            btn_reservar.Enabled = false;
            lbl_falta_habitaciones_2.Visible = false;
            lbl_falta_habitaciones_1.Visible = false;
            //Inicializacion de intefaz
            lbl_noches.Text = precio_base.Text = recarga_por_estrellas.Text = String.Empty;
            //Cambio de estructura
            SetearRecargaEstrella();
        }

        private void SetearRecargaEstrella()
        {
            UtilesSQL.llenarTabla(hoteles, "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = '" + reserva.hotel.ID.ToString() + "'");
            reserva.hotel.recarga_estrellas = Convert.ToDouble(hoteles.Rows[0]["hote_recargaEstrella"]);
            recarga_por_estrellas.Text = reserva.hotel.recarga_estrellas.ToString()+"U$S";
        }

        private void date_desde_ValueChanged(object sender, EventArgs e)
        {
            reserva.fecha_desde = date_desde.Value;
            VerificarFechasCorrectas();
        }

        private void date_hasta_ValueChanged(object sender, EventArgs e)
        {
            reserva.fecha_hasta = date_hasta.Value;
            VerificarFechasCorrectas();
        }

        private void VerificarFechasCorrectas()
        {
            if (reserva.fecha_desde > reserva.fecha_hasta)
            {
                date_hasta.Value = date_desde.Value;
            }
            CalcularCantidadNoches();
        }

        private void CalcularCantidadNoches()
        {
            TimeSpan dias = reserva.fecha_hasta - reserva.fecha_desde;
            reserva.cantidad_de_noches = (reserva.fecha_hasta - reserva.fecha_desde).TotalDays;
            lbl_noches.Text = reserva.cantidad_de_noches.ToString();
            lbl_error_fecha.Visible = reserva.cantidad_de_noches < 1;
        }

        private void txtbox_personas_TextChanged(object sender, EventArgs e)
        {
            string entrada = txtbox_personas.Text;
            if (entrada.Length > 0)
            {
                if (CantidadValida(entrada))
                {
                    reserva.personas = Convert.ToInt32(entrada);
                    lbl_error_personas.Visible = false;
                }
                else
                {
                    lbl_error_personas.Visible = true;
                }
            }
        }

        private bool CantidadValida(string texto)
        {
            if (texto.All(x => char.IsDigit(x)))
            {
                return Convert.ToInt32(texto) > 0;
            }
            else
            {
            return false;
            }
        }

        private void btn_cargar_opciones_Click(object sender, EventArgs e)
        {
            if (reserva.personas == 0 || reserva.cantidad_de_noches == 0)
            {
                lbl_error_carga_hotel.Text = "FALTAN DATOS";
                lbl_error_carga_hotel.Visible = true;
            }
            else
            {
                if (CargarHabitaciones())
                {

                    lbl_error_carga_hotel.Visible = false;
                    CargarRegimenes();
                    cbox_disponibles.Enabled = true;
                    cbox_seleccionadas.Enabled = true;
                    btn_agregar_habitacion.Enabled = true;
                    btn_eliminar_habitacion.Enabled = true;
                    btn_cargar_opciones.Enabled = false;
                    date_desde.Enabled = false;
                    date_hasta.Enabled = false;
                    txtbox_personas.Enabled = false;
                }
                else
                {
                    lbl_error_carga_hotel.Text = "HABITACIONES INSUFICIENTES";
                    lbl_error_carga_hotel.Visible = true;
                }
            }
        }
       
        private void CargarRegimenes()
        {
            cbox_regimenes.Enabled = true;
            regimenes = new DataTable();
            UtilesSQL.llenarTabla(regimenes, "SELECT * FROM DERROCHADORES_DE_PAPEL.RegimenXHotel as rh JOIN DERROCHADORES_DE_PAPEL.Regimen as r ON ( rh.rexh_regimen = r.regi_codigo AND rh.rexh_hotel = " + reserva.hotel.ID.ToString() + ")");
            cbox_regimenes.Items.Clear();
            for (int indice = 0; indice < regimenes.Rows.Count; indice++)
            {
                cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"].ToString());
            }
            cbox_regimenes.SelectedIndex = 0;
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = cbox_regimenes.SelectedIndex;
            string preciobase = String.Empty;
            preciobase = regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
            precio_base.Text = preciobase + "U$S";
            reserva.precio_base = Convert.ToDouble(preciobase);
            reserva.regimen_seleccionado = Convert.ToInt32(regimenes.Rows[indice_regimen_seleccionado]["regi_codigo"]);
            reserva.CalcularPrecio();
            precio_total.Text = reserva.precio.ToString() + "U$S";
        }

        private bool CargarHabitaciones()
        {
            hoteles = new DataTable();
            String desde = "CONVERT(datetime, \'" + reserva.fecha_desde.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            String hasta = "CONVERT(datetime, \'" + reserva.fecha_hasta.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            UtilesSQL.llenarTabla(hoteles, "SELECT * From DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.PeriodoDeCierre ON (peri_hotel = '" + reserva.hotel.ID + "') WHERE (peri_fechaFin >= "+desde+" AND peri_fechaFin <= " + hasta + ") OR (peri_fechaInicio >= " + desde+ " AND peri_fechaInicio <= " + hasta+ ") OR ( peri_fechaInicio <=" + desde+ " AND peri_fechaFin >= " + hasta+ ") " );
            if (hoteles.Rows.Count != 0)
            {
                lbl_error_carga_hotel.Text = "HOTEL CERRADO POR ESAS FECHAS";
                lbl_error_carga_hotel.Visible = true;
                return false;
            }
            else
            {
                habitaciones.Clear();

                string consulta = "SELECT h1.habi_numero, h1.habi_piso, th1.tipo_cantidadDePersonas, th1.tipo_descripcion FROM  DERROCHADORES_DE_PAPEL.TipoDeHabitacion as th1 JOIN DERROCHADORES_DE_PAPEL.Habitacion as h1 ON (th1.tipo_codigo = h1.habi_tipo) WHERE h1.habi_hotel = @hotel AND NOT (EXISTS (SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion as h2 JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion as rh2 ON ( rh2.rexh_hotel = h2.habi_hotel AND rh2.rexh_numero = h2.habi_numero AND rh2.rexh_piso = h2.habi_piso) JOIN DERROCHADORES_DE_PAPEL.Reserva as r2 ON (r2.rese_codigo = rh2.rexh_reserva) JOIN DERROCHADORES_DE_PAPEL.EstadoDeReserva as er2 ON (er2.esta_id = r2.rese_estado) WHERE h2.habi_hotel = h1.habi_hotel AND h2.habi_numero = h1.habi_numero AND h2.habi_piso = h1.habi_piso AND ( ((r2.rese_inicio BETWEEN CONVERT(datetime,@fechaDesde, 121) AND CONVERT(datetime,@fechaHasta, 121)) OR (r2.rese_fin BETWEEN CONVERT(datetime,@fechaDesde, 121) AND CONVERT(datetime,@fechaHasta, 121)) OR (r2.rese_fin <= CONVERT(datetime,@fechaDesde, 121) AND r2.rese_fin >= CONVERT(datetime,@fechaHasta, 121)) ) AND (NOT ( (esta_detalle = 'RESERVA CANCELADA POR RECEPCION') OR (esta_detalle = 'RESERVA CANCELADA POR CLIENTE' ) OR (esta_detalle = 'RESERVA CANCELADA POR NO-SHOW')) ) ) ) )";
                SqlDataAdapter sda = UtilesSQL.crearDataAdapter(consulta);
                sda.SelectCommand.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
                sda.SelectCommand.Parameters.AddWithValue("@fechaDesde", reserva.fecha_desde.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                sda.SelectCommand.Parameters.AddWithValue("@fechaHasta", reserva.fecha_hasta.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                sda.Fill(habitaciones);

                habitaciones_disponibles = new List<Habitacion>();
                /*if (habitaciones_disponibles.Count == 0)
                {
                    return false;
                }*/
                if (habitaciones.Rows.Count == 0)
                    return false;
                if (habitaciones.Select().Sum(hab => Int32.Parse(hab[2].ToString())) < reserva.personas)
                    return false;
                  
                for (int indice = 0; indice < habitaciones.Rows.Count; indice++)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.descripcion = habitaciones.Rows[indice]["tipo_descripcion"].ToString();
                    habitacion.cantidad_personas = Convert.ToInt32(habitaciones.Rows[indice]["tipo_cantidadDePersonas"].ToString());
                    habitacion.numero = Convert.ToInt32(habitaciones.Rows[indice]["habi_numero"].ToString());
                    habitacion.piso = Convert.ToInt32(habitaciones.Rows[indice]["habi_piso"].ToString());
                    habitaciones_disponibles.Add(habitacion);
                }
                reserva.habitaciones_reservadas.Clear();
                ActualizarComboBoxHabitaciones();
                return true;
            }

        }

        private void btn_agregar_habitacion_Click(object sender, EventArgs e)
        {
            if (cbox_disponibles.SelectedIndex > 0)
            {
                if (reserva.PersonasMaximas() >= reserva.personas)
                {
                    MessageBox.Show("Las habitaciones elegidas ya satisfacen la cantidad de personas estipuladas");
                    return;
                }
                reserva.habitaciones_reservadas.Add(habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1]);
                habitaciones_disponibles.RemoveAt(cbox_disponibles.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
                if (reserva.PersonasMaximas() >= reserva.personas)
                {
                    btn_reservar.Enabled = true;
                }
            }
        }

        private void btn_eliminar_habitacion_Click(object sender, EventArgs e)
        {
            if (cbox_seleccionadas.SelectedIndex > 0)
            {
                habitaciones_disponibles.Add(reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1]);
                reserva.habitaciones_reservadas.RemoveAt(cbox_seleccionadas.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
                if (reserva.PersonasMaximas() < reserva.personas)
                {
                    btn_reservar.Enabled = false;
                }
            }
        }

        private void ActualizarComboBoxHabitaciones()
        {
            cbox_disponibles.Items.Clear();
            cbox_seleccionadas.Items.Clear();
            cbox_disponibles.Items.Add("<Seleccionar habitacion para reservar>");
            cbox_seleccionadas.Items.Add("<Seleccionar habitacion para eliminar>");
            for (int indice = 0; indice < habitaciones_disponibles.Count; indice++) 
            {
                cbox_disponibles.Items.Add(habitaciones_disponibles[indice].ToString());
            }
            for (int indice = 0; indice < reserva.habitaciones_reservadas.Count; indice++)
            {
                cbox_seleccionadas.Items.Add(reserva.habitaciones_reservadas[indice].ToString());
            }
            cbox_disponibles.SelectedIndex = 0;
            cbox_seleccionadas.SelectedIndex = 0;
            CalcularPrecio();
            VerificarCapacidadReserva();
        }

        private void CalcularPrecio()
        {
            reserva.CalcularPrecio();
            precio_total.Text = reserva.precio.ToString()+"U$S";
        }

        private void VerificarCapacidadReserva()
        {
            lbl_falta_habitaciones_2.Visible = lbl_falta_habitaciones_1.Visible = !reserva.CapacidadSuficiente();
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            if (clie_nombre.Text.Length.Equals(0))
            {
                MessageBox.Show("Se debe registrar cliente");
                return;
            }
            if (lbl_falta_habitaciones_1.Visible)
            {
                MessageBox.Show("Debe elegir bien las habitaciones");
                return;
            }
            //verificar que no haya otra reserva
            DataTable reservas = new DataTable();
            UtilesSQL.llenarTabla(reservas, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_usuario = " + reserva.cliente.ToString() + " AND rese_estado IN (1,2,6) AND ((rese_inicio <= CONVERT(datetime,'" + reserva.fecha_desde.ToString("yyyy-MM-dd") + "',121) AND CONVERT(datetime,'" + reserva.fecha_desde.ToString("yyyy-MM-dd") + "',121) <= rese_fin) OR (rese_inicio <= CONVERT(datetime,'" + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "',121) AND CONVERT(datetime,'" + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "',121) <= rese_fin))");
            if (reservas.Rows.Count > 0)
            {
                MessageBox.Show("El usuario ya tiene otra reserva en esas fechas");
                return;
            }
            AltaReserva();
            MessageBox.Show("Se genero un reserva en el hotel " + reserva.hotel.ID.ToString() + " desde el dia " + reserva.fecha_desde.ToString("yyyy-MM-dd") + " hasta el dia " + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "\n Codigo de reserva: " + reserva.codigo.ToString()); 
            Close();
        }

        private void AltaReserva()
        {
            command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Reserva (rese_cliente, rese_cantidadDeNoches, rese_estado, rese_fecha, rese_inicio, rese_fin, rese_hotel, rese_regimen, rese_usuario, rese_cantidadDePersonas) VALUES (@clie, @noches, @estado, CONVERT(datetime,@fecha, 121), CONVERT(datetime,@incio, 121), CONVERT(datetime,@fin, 121), @hotel, @regimen ,@user, @personas) SELECT SCOPE_IDENTITY()");
            command.Parameters.AddWithValue("@clie", reserva.cliente);
            command.Parameters.AddWithValue("@noches", reserva.cantidad_de_noches );
            command.Parameters.AddWithValue("@estado", CargarEstadosDeReserva("RESERVA CORRECTA") );
            command.Parameters.AddWithValue("@fecha", reserva.fecha_que_se_realizo_reserva.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            command.Parameters.AddWithValue("@incio", reserva.fecha_desde.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            command.Parameters.AddWithValue("@fin", reserva.fecha_hasta.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
            command.Parameters.AddWithValue("@regimen", reserva.regimen_seleccionado);
            command.Parameters.AddWithValue("@user", reserva.usuario);
            command.Parameters.AddWithValue("@personas", reserva.personas);

            reserva.codigo = Convert.ToInt32(command.ExecuteScalar());

            for (int indice = 0; indice < reserva.habitaciones_reservadas.Count; indice++)
            {
                command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ReservaXHabitacion (rexh_reserva, rexh_hotel, rexh_numero, rexh_piso) VALUES (@reserva, @hotel, @numero, @piso)");
                command.Parameters.AddWithValue("@reserva", reserva.codigo);
                command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
                command.Parameters.AddWithValue("@piso", reserva.habitaciones_reservadas[indice].piso);
                command.Parameters.AddWithValue("@numero", reserva.habitaciones_reservadas[indice].numero);
                UtilesSQL.ejecutarComandoNonQuery(command);
            }
        }

        private int CargarEstadosDeReserva(string estado_buscado)
        {
            estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'");
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void atras_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarEstadia.ElegirCliente elegir = new RegistrarEstadia.ElegirCliente();
            elegir.ShowDialog();
            if (elegir.estaElegido())
            {
                reserva.cliente = Int32.Parse(elegir.id());
                clie_nombre.Text = elegir.nombre();
                clie_apellido.Text = elegir.apellido();
                clie_mail.Text = elegir.mail();
            }
            Show();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            clie_nombre.Clear();
            clie_apellido.Clear();
            clie_mail.Clear();
            cbox_disponibles.Items.Clear();
            cbox_seleccionadas.Items.Clear();
            cbox_disponibles.Enabled = false;
            cbox_seleccionadas.Enabled = false;
            btn_agregar_habitacion.Enabled = false;
            btn_eliminar_habitacion.Enabled = false;
            precio_total.Text = "";
            precio_base.Text = "";

            DateTime fecha = reserva.fecha_que_se_realizo_reserva;
            reserva.fecha_desde = fecha;
            reserva.fecha_hasta = fecha;
            date_desde.Value = date_desde.MinDate = fecha;
            date_hasta.Value = date_hasta.MinDate = fecha;
            lbl_error_fecha.Visible = false;
            lbl_error_personas.Visible = false;
            lbl_error_carga_hotel.Visible = false;
            reserva.personas = 0;
            //Inicializaciones
            cbox_regimenes.Enabled = false;
            btn_reservar.Enabled = false;
            lbl_falta_habitaciones_2.Visible = false;
            lbl_falta_habitaciones_1.Visible = false;
            //Inicializacion de intefaz
            lbl_noches.Text = "";

            cbox_regimenes.Items.Clear();
            txtbox_personas.Clear();
            btn_cargar_opciones.Enabled = true;

            date_desde.Enabled = true;
            date_hasta.Enabled = true;
            txtbox_personas.Enabled = true;
        }


    }
}
