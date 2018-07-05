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
    public partial class ModificarReserva : Form
    {
        private Reserva reserva = new Reserva();
        private List<Habitacion> habitaciones_disponibles = new List<Habitacion>();

        private int usuario;
        private int hotel;

        private SqlCommand command;
        private DataTable dtReserva = new DataTable();
        DataTable hoteles = new DataTable();
        DataTable regimenes = new DataTable();
        DataTable tipo_habitaciones = new DataTable();
        DataTable identificaciones = new DataTable();
        DataTable clientes = new DataTable();
        DataTable habitaciones = new DataTable();
        DataTable dtEstadosReserva = new DataTable();

        public ModificarReserva(int userId, string hotelId)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            usuario = userId;
            hotel = Convert.ToInt32(hotelId);
            //reserva.cliente = userId;
            reserva.hotel.ID = Convert.ToInt32(hotelId);
            CargarEstadosReserva();
            date_desde.MinDate = Convert.ToDateTime(Main.fecha());
            date_hasta.MinDate = Convert.ToDateTime(Main.fecha());

            //btn_cargar_opciones.Enabled = false;
            //Inicializacion de intefaz
            lbl_noches.Text = textBoxPrecioBase.Text = textBoxRecarga.Text = String.Empty;
        }
        private void CargarEstadosReserva()
        {
            dtEstadosReserva = new DataTable();
            UtilesSQL.llenarTabla(dtEstadosReserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva");
        }

        private bool ReservaYaCancelada()
        {
            int estado_actual = Convert.ToInt32(dtReserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR RECEPCION")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR CLIENTE")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR NO-SHOW"));
        }
        private bool ReservaEfectivizada()
        {
            int estado_actual = Convert.ToInt32(dtReserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA EFECTIVIZADA"));
        }
        private int getEstadosDeReserva(string estado_buscado)
        {
            dtEstadosReserva = new DataTable();
            UtilesSQL.llenarTabla(dtEstadosReserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'" );
            return Convert.ToInt32(dtEstadosReserva.Rows[0]["esta_id"]);
        }

        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_reserva.Text))
            {
                if (txtbox_reserva.Text.All(x => char.IsDigit(x)))
                {
                    lbl_error.Visible = false;
                    ValidarReserva();
                }
                else
                {
                    lbl_error.Text = "Código no válido";
                    lbl_error.Visible = true;
                }   
            }
        }
        private void ValidarReserva()
        {
            dtReserva = new DataTable();
            UtilesSQL.llenarTabla(dtReserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '" + txtbox_reserva.Text + "'");
            if (dtReserva.Rows.Count == 0)
            {
                lbl_error.Text = "No se encuentra la reserva";
                lbl_error.Visible = true;
                return;
            }
            if (Convert.ToInt32(dtReserva.Rows[0]["rese_hotel"]) != hotel)
            {
                lbl_error.Text = "La reserva corresponde a otro hotel";
                lbl_error.Visible = true;
                return;
            }
            TimeSpan dias_para_reserva = Convert.ToDateTime(dtReserva.Rows[0]["rese_inicio"]) - Convert.ToDateTime(Main.fecha());
            if (dias_para_reserva.Days <= 1)
            {
                if (dias_para_reserva.Days < 0)
                {
                    lbl_error.Text = "Ya pasó la fecha de reserva";
                }
                else
                {
                    lbl_error.Text = "No se puede modificar a menos de un día";
                }
                lbl_error.Visible = true;
                return;
            }
            if (ReservaYaCancelada())
            {
                lbl_error.Text = "Esta reserva fue cancelada";
                lbl_error.Visible = true;
                return;
            }
            if (ReservaEfectivizada())
            {
                lbl_error.Text = "Esta reserva ya se efectivizó";
                lbl_error.Visible = true;
                return;
            }
            
            txtbox_reserva.Enabled = false;
            btn_cargar_reserva.Enabled = false;
            lbl_cargado_correcto.Visible = true;
            cbox_disponibles.Enabled = true;
            cbox_seleccionadas.Enabled = true;
            date_desde.Enabled = true;
            date_hasta.Enabled = true;
            btn_agregar_habitacion.Enabled = true;
            btn_eliminar_habitacion.Enabled = true;
            btn_modificar.Enabled = true;
            textBoxTotal.Enabled = true;
            numericUpDown.Enabled = true;

            cargarReserva();
        }
        private void cargarReserva()
        {
            reserva.cantidad_de_noches = Convert.ToInt32(dtReserva.Rows[0]["rese_cantidadDeNoches"]);
            reserva.cliente = Convert.ToInt32(dtReserva.Rows[0]["rese_cliente"]);
            reserva.codigo = Convert.ToInt32(dtReserva.Rows[0]["rese_codigo"]);
            reserva.fecha_hasta = Convert.ToDateTime(dtReserva.Rows[0]["rese_fin"]);
            reserva.fecha_desde = Convert.ToDateTime(dtReserva.Rows[0]["rese_inicio"]);
            reserva.hotel.ID = Convert.ToInt32(dtReserva.Rows[0]["rese_hotel"]);
            reserva.regimen_seleccionado = Convert.ToInt32(dtReserva.Rows[0]["rese_regimen"]);
            reserva.personas = Convert.ToInt32(dtReserva.Rows[0]["rese_cantidadDePersonas"]);

            DataTable habitaciones_reservadas = new DataTable();
            UtilesSQL.llenarTabla(habitaciones_reservadas, "SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.TipoDeHabitacion ON (habi_tipo = tipo_codigo) JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON (habi_hotel = rexh_hotel AND habi_piso = rexh_piso AND habi_numero = rexh_numero) WHERE rexh_reserva = '" + reserva.codigo + "'");

            for (int indice = 0; indice < habitaciones_reservadas.Rows.Count; indice++)
            {
                Habitacion habitacion = new Habitacion();
                habitacion.descripcion = habitaciones_reservadas.Rows[indice]["tipo_descripcion"].ToString();
                habitacion.cantidad_personas = Convert.ToInt32(habitaciones_reservadas.Rows[indice]["tipo_cantidadDePersonas"].ToString());
                habitacion.numero = Convert.ToInt32(habitaciones_reservadas.Rows[indice]["habi_numero"].ToString());
                habitacion.piso = Convert.ToInt32(habitaciones_reservadas.Rows[indice]["habi_piso"].ToString());
                reserva.habitaciones_reservadas.Add(habitacion);
            }

            date_desde.Value = reserva.fecha_desde;
            date_hasta.Value = reserva.fecha_hasta;

            numericUpDown.Value = reserva.personas;

            CargarHabitaciones();
            CargarRegimenes();

            DataTable reg_seleccionado = new DataTable();
            UtilesSQL.llenarTabla(reg_seleccionado, "select * from DERROCHADORES_DE_PAPEL.Regimen where regi_codigo = '" + reserva.regimen_seleccionado + "'");
            reserva.precio_base = Convert.ToDouble(reg_seleccionado.Rows[0]["regi_precioBase"]);
            cbox_regimenes.SelectedIndex = cbox_regimenes.Items.IndexOf(reg_seleccionado.Rows[0]["regi_descripcion"]);

            DataTable dt = new DataTable();
            UtilesSQL.llenarTabla(dt, "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = '" + reserva.hotel.ID.ToString() + "'");
            reserva.hotel.recarga_estrellas = Convert.ToDouble(dt.Rows[0][8]);
            textBoxRecarga.Visible = true;
            textBoxRecarga.Text = "U$S" + reserva.hotel.recarga_estrellas.ToString();

            CalcularCantidadNoches();
        }

        private void CargarHabitaciones()
        {
            habitaciones.Clear();
            string consulta = "SELECT h1.habi_numero, h1.habi_piso, th1.tipo_cantidadDePersonas, th1.tipo_descripcion FROM  DERROCHADORES_DE_PAPEL.TipoDeHabitacion as th1 JOIN DERROCHADORES_DE_PAPEL.Habitacion as h1 ON (th1.tipo_codigo = h1.habi_tipo) WHERE h1.habi_hotel = '" + reserva.hotel.ID + "' AND NOT (EXISTS (SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion as h2 JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion as rh2 ON ( rh2.rexh_hotel = h2.habi_hotel AND rh2.rexh_numero = h2.habi_numero AND rh2.rexh_piso = h2.habi_piso) JOIN DERROCHADORES_DE_PAPEL.Reserva as r2 ON (r2.rese_codigo = rh2.rexh_reserva) JOIN DERROCHADORES_DE_PAPEL.EstadoDeReserva as er2 ON (er2.esta_id = r2.rese_estado) WHERE h2.habi_hotel = h1.habi_hotel AND h2.habi_numero = h1.habi_numero AND h2.habi_piso = h1.habi_piso AND ( ((r2.rese_inicio BETWEEN CONVERT(DATETIME, '" + reserva.fecha_desde.ToString("yyyy-MM-dd") + "', 121) AND CONVERT(DATETIME, '" + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "', 121)) OR (r2.rese_fin BETWEEN CONVERT(DATETIME, '" + reserva.fecha_desde.ToString("yyyy-MM-dd") + "', 121) AND CONVERT(DATETIME, '" + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "', 121)) OR (r2.rese_fin <= CONVERT(DATETIME, '" + reserva.fecha_desde.ToString("yyyy-MM-dd") + "', 121) AND r2.rese_fin >= CONVERT(DATETIME, '" + reserva.fecha_hasta.ToString("yyyy-MM-dd") + "', 121)) ) AND (NOT ( (esta_detalle = 'RESERVA CANCELADA POR RECEPCION') OR (esta_detalle = 'RESERVA CANCELADA POR CLIENTE' ) OR (esta_detalle = 'RESERVA CANCELADA POR NO-SHOW')) ) ) ) )";
            UtilesSQL.llenarTabla(habitaciones, consulta);
            habitaciones_disponibles.Clear();
            for (int indice = 0; indice < habitaciones.Rows.Count; indice++)
            {
                Habitacion habitacion = new Habitacion();
                habitacion.descripcion = habitaciones.Rows[indice]["tipo_descripcion"].ToString();
                habitacion.cantidad_personas = Convert.ToInt32(habitaciones.Rows[indice]["tipo_cantidadDePersonas"].ToString());
                habitacion.numero = Convert.ToInt32(habitaciones.Rows[indice]["habi_numero"].ToString());
                habitacion.piso = Convert.ToInt32(habitaciones.Rows[indice]["habi_piso"].ToString());
                habitaciones_disponibles.Add(habitacion);
            }
            ActualizarComboBoxHabitaciones();
        }
        private void ActualizarComboBoxHabitaciones()
        {
            cbox_disponibles.Items.Clear();
            cbox_seleccionadas.Items.Clear();
            cbox_disponibles.Items.Add("<Seleccione habitación para reservar>");
            cbox_seleccionadas.Items.Add("<Seleccione habitación para eliminar>");
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
        private void VerificarCapacidadReserva()
        {
            lbl_falta_habitaciones_2.Visible = lbl_falta_habitaciones_1.Visible = !reserva.CapacidadSuficiente();
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
        }

        private void CalcularCantidadNoches()
        {
            TimeSpan dias = reserva.fecha_hasta - reserva.fecha_desde;
            reserva.cantidad_de_noches = dias.Duration().Days;
            lbl_noches.Text = reserva.cantidad_de_noches.ToString();
            lbl_error_fecha.Visible = reserva.cantidad_de_noches < 1;
            CalcularPrecio();
        }
        private void CalcularPrecio()
        {
            reserva.CalcularPrecio();
            textBoxTotal.Text = "U$S" + reserva.precio.ToString();
        }

        private void VerificarFechasCorrectas()
        {

            if (reserva.fecha_desde > reserva.fecha_hasta)
            {
                date_hasta.Value = date_desde.Value;
            }
            CalcularCantidadNoches();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            String desde = "CONVERT(datetime, \'" + reserva.fecha_desde.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            String hasta = "CONVERT(datetime, \'" + reserva.fecha_hasta.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            UtilesSQL.llenarTabla(dt, "SELECT * FROM DERROCHADORES_DE_PAPEL.PeriodoDeCierre WHERE peri_hotel = " + reserva.hotel.ID + " AND ((peri_fechaFin >= " + desde + " AND peri_fechaFin <= " + hasta + ") OR (peri_fechaInicio >= " + desde + " AND peri_fechaInicio <= " + hasta + ") OR ( peri_fechaInicio <=" + desde + " AND peri_fechaFin >= " + hasta + "))");
            UtilesSQL.llenarTabla(dt2, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_hotel = " + reserva.hotel.ID + " AND rese_cliente = " + reserva.cliente.ToString() + " AND rese_codigo != " + reserva.codigo.ToString() + " AND ((rese_fin >= " + desde + " AND rese_fin <= " + hasta + ") OR (rese_inicio >= " + desde + " AND rese_inicio <= " + hasta + ") OR ( rese_inicio <=" + desde + " AND rese_fin >= " + hasta + "))");

            labelHotelCerrado.Visible = dt.Rows.Count != 0;
            labelReservaYaExistente.Visible = dt2.Rows.Count != 0;
            ValidarTodo();
        }
        private void date_desde_ValueChanged_1(object sender, EventArgs e)
        {
            reserva.fecha_desde = date_desde.Value;
            VerificarFechasCorrectas();
            ResetearHabitaciones();
        }
        private void date_hasta_ValueChanged_1(object sender, EventArgs e)
        {
            reserva.fecha_hasta = date_hasta.Value;
            VerificarFechasCorrectas();
            ResetearHabitaciones();
        }
        private void ResetearHabitaciones()
        {
            CargarHabitaciones();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int32 p = Int32.Parse(numericUpDown.Value.ToString());
            reserva.personas = p;
            label0Personas.Visible = p == 0;
            CalcularPrecio();
            VerificarCapacidadReserva();
            ValidarTodo();
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = cbox_regimenes.SelectedIndex;
            string precio_base = String.Empty;
            precio_base = regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
            textBoxPrecioBase.Text = "U$S" + precio_base;
            reserva.precio_base = Convert.ToDouble(precio_base);
            foreach (DataRow row in regimenes.Rows)
            {
                if (row["regi_descripcion"].ToString() == cbox_regimenes.SelectedItem.ToString())
                {
                    reserva.regimen_seleccionado = Int32.Parse(row[0].ToString());
                }
            }
            CalcularPrecio();
        }

        private void btn_agregar_habitacion_Click_1(object sender, EventArgs e)
        {
            if (cbox_disponibles.SelectedIndex != 0)
            {
                if (reserva.PersonasMaximas() >= reserva.personas)
                {
                    MessageBox.Show("Las habitaciones elegidas ya satisfacen la cantidad de personas estipuladas");
                    return;
                }
                foreach (Habitacion hab in reserva.habitaciones_reservadas)
                {
                    if (habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1].numero == hab.numero && habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1].piso == hab.piso)
                    {
                        MessageBox.Show("Habitación ya agregada");
                        return;
                    }
                }
                reserva.habitaciones_reservadas.Add(habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1]);
                habitaciones_disponibles.RemoveAt(cbox_disponibles.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
                ValidarTodo();
            }
        }
        private void btn_eliminar_habitacion_Click_1(object sender, EventArgs e)
        {
            if (cbox_seleccionadas.SelectedIndex != 0)
            {
                foreach (Habitacion hab in habitaciones_disponibles)
                {
                    if (reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1].numero == hab.numero && reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1].piso == hab.piso)
                    {
                        reserva.habitaciones_reservadas.RemoveAt(cbox_seleccionadas.SelectedIndex - 1);
                        ActualizarComboBoxHabitaciones();
                        return;
                    }
                }
                habitaciones_disponibles.Add(reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1]);
                reserva.habitaciones_reservadas.RemoveAt(cbox_seleccionadas.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
            }
            ValidarTodo();
        }

        private void ValidarTodo()
        {
            if (lbl_error_fecha.Visible || labelHotelCerrado.Visible || label0Personas.Visible || lbl_error_carga_hotel.Visible || lbl_falta_habitaciones_1.Visible || labelReservaYaExistente.Visible)
            {
                btn_modificar.Enabled = false;
            }
            else
            {
                btn_modificar.Enabled = true;
            }
        }
        private void btn_reservar_Click(object sender, EventArgs e)
        {
            String desde = "CONVERT(datetime, \'" + reserva.fecha_desde.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            String hasta = "CONVERT(datetime, \'" + reserva.fecha_hasta.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            DataTable HabInvalidas = new DataTable();
            UtilesSQL.llenarTabla(HabInvalidas, "SELECT habi_numero, habi_piso FROM DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON rexh_hotel = habi_hotel AND habi_piso = rexh_piso AND habi_numero = rexh_numero JOIN DERROCHADORES_DE_PAPEL.Reserva ON rese_codigo = rexh_reserva WHERE habi_hotel = '" + hotel.ToString() + "' AND rese_cliente != '" + reserva.cliente.ToString() + "' AND ((rese_fin >= " + desde + " AND rese_fin <= " + hasta + ") OR (rese_inicio >= " + desde + " AND rese_inicio <= " + hasta + ") OR ( rese_inicio <=" + desde + " AND rese_fin >= " + hasta + "))");
            if (HabInvalidas.Rows.Count != 0)
            {
                for (int i = 0; i < HabInvalidas.Rows.Count; i++)
                {
                    foreach (Habitacion hab in reserva.habitaciones_reservadas)
                    {
                        if (hab.piso.ToString() == HabInvalidas.Rows[i][1].ToString() && hab.numero.ToString() == HabInvalidas.Rows[i][0].ToString())
                        {
                            MessageBox.Show("Hay habitaciones que estan reservadas en ese período");
                            return;
                        }
                    }
                }
            }


            //ELIMINAR las reserva x habitacion que ya estan
            command = UtilesSQL.crearCommand("DELETE FROM DERROCHADORES_DE_PAPEL.ReservaXHabitacion WHERE rexh_reserva = @reserva");
            command.Parameters.AddWithValue("@reserva", reserva.codigo);
            UtilesSQL.ejecutarComandoNonQuery(command);

            //UPDATE la reserva que ya esta
            command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_cantidadDeNoches = @noches , rese_estado = @estado , rese_inicio = CONVERT(DATETIME, @incio, 121), rese_fin = CONVERT(DATETIME, @fin, 121), rese_regimen =  @regimen, rese_cantidadDePersonas = @personas WHERE rese_codigo = @reserva");
            command.Parameters.AddWithValue("@noches", reserva.cantidad_de_noches );
            command.Parameters.AddWithValue("@estado", CargarEstadosDeReserva("RESERVA MODIFICADA") );
            command.Parameters.AddWithValue("@incio", reserva.fecha_desde.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@fin", reserva.fecha_hasta.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
            command.Parameters.AddWithValue("@regimen", reserva.regimen_seleccionado);
            command.Parameters.AddWithValue("@personas", reserva.personas);
            command.Parameters.AddWithValue("@reserva", reserva.codigo);
            UtilesSQL.ejecutarComandoNonQuery(command);

            //PONER LAS NUEVAS RESERVAS X HABITACION
            for (int indice = 0; indice < reserva.habitaciones_reservadas.Count; indice++)
            {
                command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ReservaXHabitacion (rexh_reserva, rexh_hotel, rexh_numero, rexh_piso) VALUES (@reserva, @hotel, @numero, @piso)");
                command.Parameters.AddWithValue("@reserva", reserva.codigo);
                command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
                command.Parameters.AddWithValue("@piso", reserva.habitaciones_reservadas[indice].piso);
                command.Parameters.AddWithValue("@numero", reserva.habitaciones_reservadas[indice].numero);
                UtilesSQL.ejecutarComandoNonQuery(command);
            }

            //Insertar una nueva modificacion
            command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ModificacionReserva (modi_reserva, modi_fechaDeModificacion, modi_usuario) VALUES (@reserva ,CONVERT(DATETIME, @fecha, 121) ,@usuario)");
            command.Parameters.AddWithValue("@reserva", reserva.codigo);
            command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(Main.fecha()).ToString("yyyy-MM-dd HH:mm:ss.fff"));
            command.Parameters.AddWithValue("@usuario", usuario);
            UtilesSQL.ejecutarComandoNonQuery(command);

            MessageBox.Show("Se modifico la reserva correctamente");
            this.Close();
        }
        private int CargarEstadosDeReserva(string estado_buscado)
        {
            dtEstadosReserva = new DataTable();
            UtilesSQL.llenarTabla(dtEstadosReserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'");
            return Convert.ToInt32(dtEstadosReserva.Rows[0]["esta_id"]);
        }

        private void atras_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
