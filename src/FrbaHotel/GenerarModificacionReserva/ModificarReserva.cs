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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarReserva : Form
    {

        private Reserva reserva = new Reserva();
        private List<Habitacion> habitaciones_disponibles = new List<Habitacion>();

        private int usuario;
        private int hotel;
        private string codigo;

        private SqlCommand command;
        private DataTable tabla_reserva = new DataTable();
        DataTable hoteles = new DataTable();
        DataTable regimenes = new DataTable();
        DataTable tipo_habitaciones = new DataTable();
        DataTable identificaciones = new DataTable();
        DataTable clientes = new DataTable();
        DataTable habitaciones = new DataTable();
        DataTable estados_reserva = new DataTable();

        public ModificarReserva(int userId, string hotelId)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            usuario = userId;
            hotel = Convert.ToInt32(hotelId);
            //reserva.cliente = userId;
            reserva.hotel.ID = Convert.ToInt32(hotelId);
            lbl_error.Visible = false;
            lbl_cargado_correcto.Visible = false;
            CargarEstadosReserva();

            date_desde.MinDate = Convert.ToDateTime(Main.fecha());
            date_hasta.MinDate = Convert.ToDateTime(Main.fecha());
            date_desde.Enabled = false;
            date_desde.Enabled = false;
            lbl_error_fecha.Visible = false;
            lbl_error_personas.Visible = false;
            lbl_error_carga_hotel.Visible = false;
            //Inicializaciones
            cbox_regimenes.Enabled = false;
            btn_reservar.Enabled = false;
            lbl_falta_habitaciones_2.Visible = false;
            lbl_falta_habitaciones_1.Visible = false;

            cbox_disponibles.Enabled = false;
            cbox_seleccionadas.Enabled = false;
            date_desde.Enabled = false;
            date_hasta.Enabled = false;
            lbl_error_carga_hotel.Visible = false;
            lbl_error_fecha.Visible = false;
            lbl_error_personas.Visible = false;
            btn_agregar_habitacion.Enabled = false;
            btn_eliminar_habitacion.Enabled = false;
            btn_reservar.Enabled = false;
            lbl_precio.Visible = false;
            txtbox_personas.Enabled = false;
            //btn_cargar_opciones.Enabled = false;
            //Inicializacion de intefaz
            lbl_noches.Text = lbl_precio_base.Text = lbl_recarga_estrellas.Text = String.Empty;
            //Cambio de estructura
        }

        private void CargarEstadosReserva()
        {
            estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva");
        }

        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if (txtbox_reserva.Text != "")
            {
                if (txtbox_reserva.Text.All(x => char.IsDigit(x)))
                {
                    CargarReserva(txtbox_reserva.Text);
                }
                else
                {
                    lbl_error.Text = "Codigo no valido";
                    lbl_error.Visible = true;
                }   
            }
        }

        private void CargarReserva(string codigo_reserva)
        {
            tabla_reserva = new DataTable();
            UtilesSQL.llenarTabla(tabla_reserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '" + codigo_reserva + "'");
            if (tabla_reserva.Rows.Count == 0)
            {
                lbl_error.Text = "No se encuentra la reserva";
                lbl_error.Visible = true;
            }
            else
            {
                if (Convert.ToInt32(tabla_reserva.Rows[0]["rese_hotel"]) != hotel)
                {
                    lbl_error.Text = "La reserva correspondea otro hotel";
                    lbl_error.Visible = true;
                }
                else
                {
                    TimeSpan dias_para_reserva = Convert.ToDateTime(tabla_reserva.Rows[0]["rese_inicio"]) - Convert.ToDateTime(Main.fecha());
                    if (dias_para_reserva.Days <= 1)
                    {
                        if (dias_para_reserva.Days < 0)
                        {
                            lbl_error.Text = "Ya paso la fecha de reserva";
                        }
                        else
                        {
                            lbl_error.Text = "No se puede modificar a menos de un dia";
                        }
                        lbl_error.Visible = true;
                    }
                    else
                    {
                        if (!ReservaYaCancelada())
                        {
                            lbl_error.Visible = false;
                            codigo = txtbox_codigo.Text;
                            lbl_cargado_correcto.Visible = true;
                            cbox_disponibles.Enabled = true;
                            cbox_seleccionadas.Enabled = true;
                            date_desde.Enabled = true;
                            date_hasta.Enabled = true;
                            //lbl_error_carga_hotel.Visible = true;
                            //lbl_error_fecha.Visible = true;
                            //lbl_error_personas.Visible = true;
                            btn_agregar_habitacion.Enabled = true;
                            btn_eliminar_habitacion.Enabled = true;
                            btn_reservar.Enabled = true;
                            lbl_precio.Visible = true;
                            lbl_precio.Enabled = true;
                            txtbox_personas.Enabled = true;

                            reserva.codigo = Convert.ToInt32(txtbox_reserva.Text);
                            reserva.cantidad_de_noches = Convert.ToInt32(tabla_reserva.Rows[0]["rese_cantidadDeNoches"]);
                            reserva.cliente = Convert.ToInt32(tabla_reserva.Rows[0]["rese_cliente"]);
                            reserva.codigo = Convert.ToInt32(tabla_reserva.Rows[0]["rese_codigo"]);
                            reserva.fecha_hasta = Convert.ToDateTime(tabla_reserva.Rows[0]["rese_fin"]);
                            reserva.fecha_desde = Convert.ToDateTime(tabla_reserva.Rows[0]["rese_inicio"]);
                            reserva.hotel.ID = Convert.ToInt32(tabla_reserva.Rows[0]["rese_hotel"]);
                            reserva.regimen_seleccionado = Convert.ToInt32(tabla_reserva.Rows[0]["rese_regimen"]);
                            reserva.personas = Convert.ToInt32(tabla_reserva.Rows[0]["rese_cantidadDePersonas"]);

                            DataTable habitaciones_reservadas = new DataTable();
                            UtilesSQL.llenarTabla(habitaciones_reservadas, "SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.TipoDeHabitacion ON (habi_tipo = tipo_codigo) JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON (habi_hotel = rexh_hotel AND habi_piso = rexh_piso AND habi_numero = rexh_numero) WHERE rexh_reserva = '" + reserva.codigo + "'");

                            for(int indice = 0; indice < habitaciones_reservadas.Rows.Count; indice++)
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
                            
                            cbox_disponibles.Enabled = true;
                            cbox_seleccionadas.Enabled = true;

                            txtbox_personas.Text = reserva.personas.ToString();

                            CargarHabitaciones();
                            CargarRegimenes();

                            DataTable reg_seleccionado = new DataTable();
                            UtilesSQL.llenarTabla(reg_seleccionado, "select * from DERROCHADORES_DE_PAPEL.Regimen where regi_codigo = '"+ reserva.regimen_seleccionado +"'");
                            reserva.precio_base = Convert.ToDouble(reg_seleccionado.Rows[0]["regi_precioBase"]);

                            UtilesSQL.llenarTabla(hoteles, "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = '" + reserva.hotel.ID + "'");

                            reserva.hotel.recarga_estrellas = Convert.ToDouble(hoteles.Rows[0]["hote_recargaEstrella"]);

                            CalcularCantidadNoches();
                            CalcularPrecio();
                        }
                        else
                        {
                            lbl_error.Text = "Ya se cancelo esta reserva";
                            lbl_error.Visible = true;
                        }
                    }
                }
            }
        }

        private bool ReservaYaCancelada()
        {
            int estado_actual = Convert.ToInt32(tabla_reserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR RECEPCION")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR CLIENTE")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR NO-SHOW"));
        }

        private int getEstadosDeReserva(string estado_buscado)
        {
            estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'" );
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void SetearRecargaEstrella()
        {
            UtilesSQL.llenarTabla(hoteles, "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = '" + reserva.hotel.ID.ToString() + "'");
            reserva.hotel.recarga_estrellas = Convert.ToDouble(hoteles.Rows[0]["hote_recargaEstrella"]);
            lbl_recarga_estrellas.Text = reserva.hotel.recarga_estrellas.ToString();
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
            reserva.cantidad_de_noches = dias.Days;
            lbl_noches.Text = reserva.cantidad_de_noches.ToString();
            lbl_error_fecha.Visible = reserva.cantidad_de_noches < 1;
            CalcularPrecio();
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

        private bool CargarHabitaciones()
        {
            hoteles = new DataTable();
            UtilesSQL.llenarTabla(hoteles, "SELECT * From DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.PeriodoDeCierre ON (peri_hotel = '" + reserva.hotel.ID + "') WHERE (peri_fechaFin >= '" + reserva.fecha_desde + "' AND peri_fechaFin <= '" + reserva.fecha_hasta + "') OR (peri_fechaInicio >= '" + reserva.fecha_desde + "' AND peri_fechaInicio <= '" + reserva.fecha_hasta + "') OR ( peri_fechaInicio <='" + reserva.fecha_desde + "' AND peri_fechaFin >= '" + reserva.fecha_hasta + "') ");
            if (hoteles.Rows.Count != 0)
            {
                lbl_error_carga_hotel.Text = "HOTEL CERRADO POR ESAS FECHAS";
                lbl_error_carga_hotel.Visible = true;
                return false;
            }
            else
            {
                habitaciones.Clear();
                string consulta = "SELECT h1.habi_numero, h1.habi_piso, th1.tipo_cantidadDePersonas, th1.tipo_descripcion FROM  DERROCHADORES_DE_PAPEL.TipoDeHabitacion as th1 JOIN DERROCHADORES_DE_PAPEL.Habitacion as h1 ON (th1.tipo_codigo = h1.habi_tipo) WHERE h1.habi_hotel = '" + reserva.hotel.ID + "' AND NOT (EXISTS (SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion as h2 JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion as rh2 ON ( rh2.rexh_hotel = h2.habi_hotel AND rh2.rexh_numero = h2.habi_numero AND rh2.rexh_piso = h2.habi_piso) JOIN DERROCHADORES_DE_PAPEL.Reserva as r2 ON (r2.rese_codigo = rh2.rexh_reserva) JOIN DERROCHADORES_DE_PAPEL.EstadoDeReserva as er2 ON (er2.esta_id = r2.rese_estado) WHERE h2.habi_hotel = h1.habi_hotel AND h2.habi_numero = h1.habi_numero AND h2.habi_piso = h1.habi_piso AND ( ((r2.rese_inicio BETWEEN '" + reserva.fecha_desde + "' AND '" + reserva.fecha_hasta + "') OR (r2.rese_fin BETWEEN '" + reserva.fecha_desde + "' AND '" + reserva.fecha_hasta + "') OR (r2.rese_fin <= '" + reserva.fecha_desde + "' AND r2.rese_fin >= '" + reserva.fecha_hasta + "') ) AND (NOT ( (esta_detalle = 'RESERVA CANCELADA POR RECEPCION') OR (esta_detalle = 'RESERVA CANCELADA POR CLIENTE' ) OR (esta_detalle = 'RESERVA CANCELADA POR NO-SHOW')) ) ) ) )";
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
                return true;
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
            lbl_precio.Text = reserva.precio.ToString();
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
            for (int indice = 0; indice < regimenes.Rows.Count - 1; indice++)
            {
                cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"].ToString());
            }

        }

        private void txtbox_personas_TextChanged_1(object sender, EventArgs e)
        {
            string entrada = txtbox_personas.Text;
            if (entrada.Length > 0)
            {
                if (CantidadValida(entrada))
                {
                    reserva.personas = Convert.ToInt32(entrada);
                    lbl_error_personas.Visible = false;
                    //CalcularPrecio();
                }
                else
                {
                    lbl_error_personas.Visible = true;
                }
            }
            
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = cbox_regimenes.SelectedIndex;
            string precio_base = String.Empty;
            precio_base = regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
            lbl_precio_base.Text = precio_base;
            reserva.precio_base = Convert.ToDouble(precio_base);
            CalcularPrecio();
        }

        private void btn_agregar_habitacion_Click_1(object sender, EventArgs e)
        {
            if (cbox_disponibles.SelectedIndex != 0)
            {
                reserva.habitaciones_reservadas.Add(habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1]);
                habitaciones_disponibles.RemoveAt(cbox_disponibles.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
            }
        }

        private void btn_eliminar_habitacion_Click_1(object sender, EventArgs e)
        {
            if (cbox_seleccionadas.SelectedIndex != 0)
            {
                habitaciones_disponibles.Add(reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1]);
                reserva.habitaciones_reservadas.RemoveAt(cbox_seleccionadas.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
            }
        }

        private void date_desde_ValueChanged_1(object sender, EventArgs e)
        {
            reserva.fecha_desde = date_desde.Value;
            VerificarFechasCorrectas();
        }

        private void date_hasta_ValueChanged_1(object sender, EventArgs e)
        {
            reserva.fecha_hasta = date_hasta.Value;
            VerificarFechasCorrectas();
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            //ELIMINAR las reserva x habitacion que ya estan
            command = UtilesSQL.crearCommand("DELETE FROM DERROCHADORES_DE_PAPEL.ReservaXHabitacion WHERE rexh_reserva = '" + reserva.codigo + "'");
            UtilesSQL.ejecutarComandoNonQuery(command);

            //Updatear la reserva que ya esta
            command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_cantidadDeNoches = @noches , rese_estado = @estado , rese_inicio = @incio, rese_fin = @fin, rese_regimen =  @regimen, rese_cantidadDePersonas = @personas WHERE rese_codigo = '"+ reserva.codigo +"'");
            command.Parameters.AddWithValue("@noches", reserva.cantidad_de_noches );
            command.Parameters.AddWithValue("@estado", CargarEstadosDeReserva("RESERVA MODIFICADA") );
            command.Parameters.AddWithValue("@incio", reserva.fecha_desde);
            command.Parameters.AddWithValue("@fin", reserva.fecha_hasta);
            command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
            command.Parameters.AddWithValue("@regimen", reserva.regimen_seleccionado);
            command.Parameters.AddWithValue("@personas", reserva.personas);
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
            command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ModificacionReserva (modi_reserva, modi_fechaDeModificacion, modi_usuario) VALUES (@reserva ,@fecha ,@usuario)");
            command.Parameters.AddWithValue("@reserva", reserva.codigo);
            command.Parameters.AddWithValue("@fecha",  Convert.ToDateTime(Main.fecha()));
            command.Parameters.AddWithValue("@usuario", usuario);
            UtilesSQL.ejecutarComandoNonQuery(command);

            MessageBox.Show("Se modifico la reserva correctamente");
            this.Close();
        }

        private int CargarEstadosDeReserva(string estado_buscado)
        {
            estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'");
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void atras_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
