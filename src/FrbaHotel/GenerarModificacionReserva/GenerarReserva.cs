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
        DataTable identificaciones = new DataTable();
        DataTable clientes = new DataTable();
        DataTable habitaciones = new DataTable();
        DataTable estados_reserva = new DataTable();

        public GenerarReserva(int id_usuario, string id_hotel)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            reserva.usuario = id_usuario;
            reserva.hotel.ID = Convert.ToInt32(id_hotel);
            btn_cargar_opciones.Text = "Cargar opciones";
            reserva.fecha_que_se_realizo_reserva = Convert.ToDateTime(Main.fecha());
            reserva.fecha_desde = Convert.ToDateTime(Main.fecha());
            reserva.fecha_hasta = Convert.ToDateTime(Main.fecha());
            date_desde.Value = date_desde.MinDate = Convert.ToDateTime(Main.fecha());
            date_hasta.Value = date_hasta.MinDate = Convert.ToDateTime(Main.fecha());
            lbl_error_fecha.Visible = false;
            lbl_error_personas.Visible = false;
            lbl_error_carga_hotel.Visible = false;
            lbl_cliente_inhabilitado.Visible = false;
            reserva.personas = 0;
            //Inicializaciones
            cbox_regimenes.Enabled = false;
            cbox_tipo_identificacion.Enabled = false;
            txtbox_identificacion.Enabled = false;
            txtbox_mail.Enabled = false;
            btn_reservar.Enabled = false;
            lbl_falta_habitaciones_2.Visible = false;
            lbl_falta_habitaciones_1.Visible = false;
            lbl_falta_tipo_id.Visible = false;
            lbl_falta_id.Visible = false;
            lbl_falta_mail.Visible = false;
            lbl_id_incorrecta.Visible = false;
            //Inicializacion de intefaz
            lbl_noches.Text = lbl_precio_base.Text = lbl_recarga_estrellas.Text = String.Empty;
            //Cambio de estructura
            SetearRecargaEstrella();
        }

        private void SetearRecargaEstrella()
        {
            UtilesSQL.llenarTabla(hoteles, "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = '" + reserva.hotel.ID.ToString() + "'");
            reserva.hotel.recarga_estrellas = Convert.ToDouble(hoteles.Rows[0]["hote_recargaEstrella"]);
            lbl_recarga_estrellas.Text = reserva.hotel.recarga_estrellas.ToString();
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
            reserva.cantidad_de_noches = dias.Duration().Days;
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
                    HabilitarRegistroCliente();
                    cbox_disponibles.Enabled = true;
                    cbox_seleccionadas.Enabled = true;
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
            for (int indice = 0; indice < regimenes.Rows.Count - 1; indice++)
            {
                cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"].ToString());
            }
            cbox_regimenes.SelectedIndex = 0;
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = cbox_regimenes.SelectedIndex;
            string precio_base = String.Empty;
            precio_base = regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
            lbl_precio_base.Text = precio_base;
            reserva.precio_base = Convert.ToDouble(precio_base);
            reserva.regimen_seleccionado = Convert.ToInt32(regimenes.Rows[indice_regimen_seleccionado]["regi_codigo"]);
        }

        private bool CargarHabitaciones()
        {

            UtilesSQL.llenarTabla(hoteles, "SELECT * From DERROCHADORES_DE_PAPEL.Habitacion JOIN DERROCHADORES_DE_PAPEL.PeriodoDeCierre ON (peri_hotel = '" + reserva.hotel.ID + "') WHERE (peri_fechaFin >= '" + reserva.fecha_desde + "' AND peri_fechaFin <= '" + reserva.fecha_hasta + "') OR (peri_fechaInicio >= '" + reserva.fecha_desde + "' AND peri_fechaInicio <= '" + reserva.fecha_hasta + "') OR ( peri_fechaInicio <='" + reserva.fecha_desde + "' AND peri_fechaFin >= '" + reserva.fecha_hasta + "') " );
            if (hoteles.Rows.Count == 0)
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

        private void btn_agregar_habitacion_Click(object sender, EventArgs e)
        {
            if (cbox_disponibles.SelectedIndex != 0)
            {
                reserva.habitaciones_reservadas.Add(habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1]);
                habitaciones_disponibles.RemoveAt(cbox_disponibles.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
            }
        }

        private void btn_eliminar_habitacion_Click(object sender, EventArgs e)
        {
            if (cbox_seleccionadas.SelectedIndex != 0)
            {
                habitaciones_disponibles.Add(reserva.habitaciones_reservadas[cbox_seleccionadas.SelectedIndex - 1]);
                reserva.habitaciones_reservadas.RemoveAt(cbox_seleccionadas.SelectedIndex - 1);
                ActualizarComboBoxHabitaciones();
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

        private void HabilitarRegistroCliente()
        {
            cbox_tipo_identificacion.Enabled = true;
            txtbox_identificacion.Enabled = true;
            txtbox_mail.Enabled = true;
            btn_reservar.Enabled = true;
            CargarTipoIdentificacion();
        }

        private void CargarTipoIdentificacion()
        {
            identificaciones = new DataTable();
            cbox_tipo_identificacion.Items.Clear();

            UtilesSQL.llenarTabla(identificaciones, "SELECT * FROM DERROCHADORES_DE_PAPEL.Documento");

            for (int indice = 0; indice < identificaciones.Rows.Count; indice++)
            {
                cbox_tipo_identificacion.Items.Add(identificaciones.Rows[indice]["docu_detalle"]);
            }
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            lbl_falta_id.Visible = txtbox_identificacion.Text == "";
            lbl_falta_mail.Visible = txtbox_mail.Text == "";
            lbl_falta_tipo_id.Visible = cbox_tipo_identificacion.Text == "";
            lbl_id_incorrecta.Visible = !DocumentoValido();
            if ((!lbl_falta_id.Visible) && (!lbl_falta_mail.Visible) && (!lbl_falta_tipo_id.Visible) && (!lbl_id_incorrecta.Visible) && (!lbl_falta_habitaciones_1.Visible) )
            {
                if (!EsCliente())
                {
                    MessageBox.Show("Se debe registrar cliente");
                    RegistrarCliente();
                }
                else
                {
                    reserva.cliente = Convert.ToInt32(clientes.Rows[0]["clie_id"]);
                    AltaReserva();
                    Close();
                    MessageBox.Show("Se genero un reserva en el hotel " + reserva.hotel.ID.ToString() + " desde el dia " + reserva.fecha_desde.ToString() + " hasta el dia " + reserva.fecha_hasta.ToString() + "\n Codigo de reserva: " + reserva.codigo.ToString());
                }
            }
        }

        bool DocumentoValido()
        {
            return txtbox_identificacion.Text.All( char.IsDigit );
        }

        bool EsCliente()
        {
            clientes = new DataTable();
            UtilesSQL.llenarTabla(clientes, "SELECT * FROM DERROCHADORES_DE_PAPEL.Cliente as c WHERE c.clie_mail = '" + txtbox_mail.Text + "' and c.clie_tipoDeDocumento = '" + cbox_tipo_identificacion.SelectedIndex + "' and c.clie_numeroDeDocumento = '" + txtbox_identificacion.Text +"'" );

            if(clientes.Rows.Count != 0)
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(clientes.Rows[0]["clie_habilitado"]) != 1)
                {
                    lbl_cliente_inhabilitado.Visible = true;
                    return false;
                }
                else {
                    return true;
                }

            }
        }

        private void RegistrarCliente()
        {
            Form alta_cliente = new AbmCliente.AltaCliente();
            Hide();
            alta_cliente.ShowDialog();
            Show();
        }

        private void AltaReserva()
        {
            command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Reserva (rese_cliente, rese_cantidadDeNoches, rese_estado, rese_fecha, rese_inicio, rese_fin, rese_hotel, rese_regimen, rese_usuario, rese_cantidadDePersonas) VALUES (@clie, @noches, @estado, @fecha, @incio, @fin, @hotel, @regimen ,@user, @personas) SELECT SCOPE_IDENTITY()");
            command.Parameters.AddWithValue("@clie", reserva.cliente);
            command.Parameters.AddWithValue("@noches", reserva.cantidad_de_noches );
            command.Parameters.AddWithValue("@estado", CargarEstadosDeReserva("RESERVA CORRECTA") );
            command.Parameters.AddWithValue("@fecha", reserva.fecha_que_se_realizo_reserva );
            command.Parameters.AddWithValue("@incio", reserva.fecha_desde);
            command.Parameters.AddWithValue("@fin", reserva.fecha_hasta);
            command.Parameters.AddWithValue("@hotel", reserva.hotel.ID);
            command.Parameters.AddWithValue("@regimen", reserva.regimen_seleccionado);
            command.Parameters.AddWithValue("@user", reserva.usuario);
            command.Parameters.AddWithValue("@cantidad", reserva.personas);

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


    }
}
