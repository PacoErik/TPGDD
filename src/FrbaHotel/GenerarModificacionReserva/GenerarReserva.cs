﻿using System;
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
        bool hotel_fijo;
        //Reserva
        private Reserva reserva = new Reserva();
        private List<Habitacion> habitaciones_disponibles = new List<Habitacion>();

        //SQL
        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        private SqlDataAdapter sda;
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
            this.hotel_fijo = true;
            this.InicializarTodo();
            this.reserva.usuario = id_usuario;
            this.reserva.hotel.ID = Convert.ToInt32(id_hotel);
            this.btn_cargar_opciones.Text = "Cargar opciones";
        }

        private void InicializarTodo()
        {
            this.reserva.fecha_que_se_realizo_reserva = DateTime.Today;
            this.reserva.fecha_desde = DateTime.Today;
            this.reserva.fecha_hasta = DateTime.Today;
            this.date_desde.MinDate = DateTime.Today;
            this.date_hasta.MinDate = DateTime.Today;
            this.lbl_error_fecha.Visible = false;
            this.lbl_error_personas.Visible = false;
            this.lbl_error_carga_hotel.Visible = false;
            this.reserva.personas = 0;

            //Inicializaciones
            this.cbox_regimenes.Enabled = false;
            this.cbox_tipo_identificacion.Enabled = false;
            this.txtbox_identificacion.Enabled = false;
            this.txtbox_mail.Enabled = false;
            this.btn_reservar.Enabled = false;
            this.lbl_falta_habitaciones_2.Visible = false;
            this.lbl_falta_habitaciones_1.Visible = false;
            this.lbl_falta_tipo_id.Visible = false;
            this.lbl_falta_id.Visible = false;
            this.lbl_falta_mail.Visible = false;
            this.lbl_id_incorrecta.Visible = false;

            //Inicializacion de intefaz
            this.lbl_noches.Text = this.lbl_precio_base.Text = this.lbl_recarga_estrellas.Text = String.Empty;

            //Cambio de estructura
            this.grid_hoteles.Visible = false;
            /*
            this.CargarRegimenes();
            this.CargarHabitaciones();
            this.HabilitarRegistroCliente();
             * */
            this.lbl_recarga_estrellas.Text = reserva.hotel.recarga_estrellas.ToString();
        }
        /*
        private void SetearUsuarioGuest()
        {
            DataTable usuario = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Usuario WHERE usur_username = 'guest'", conexion);
            sda.Fill(usuario);
            this.reserva.usuario = Convert.ToInt32(usuario.Rows[0]["usur_id"]);
        }
        */

        private void date_desde_ValueChanged(object sender, EventArgs e)
        {
            this.reserva.fecha_desde = this.date_desde.Value;
            this.VerificarFechasCorrectas();
        }

        private void date_hasta_ValueChanged(object sender, EventArgs e)
        {
            this.reserva.fecha_hasta = this.date_hasta.Value;
            this.VerificarFechasCorrectas();
        }

        private void VerificarFechasCorrectas()
        {
            if (reserva.fecha_desde > reserva.fecha_hasta)
            {
                this.date_hasta.Value = this.date_desde.Value;
            }
            this.CalcularCantidadNoches();
        }

        private void CalcularCantidadNoches()
        {
            TimeSpan dias = this.reserva.fecha_hasta - this.reserva.fecha_desde;
            this.reserva.cantidad_de_noches = dias.Days;
            this.lbl_noches.Text = this.reserva.cantidad_de_noches.ToString();
            this.lbl_error_fecha.Visible = reserva.cantidad_de_noches < 1;
        }

        private void txtbox_personas_TextChanged(object sender, EventArgs e)
        {
            string entrada = this.txtbox_personas.Text;
            if (entrada.Length > 0)
            {
                if (CantidadValida(entrada))
                {
                    this.reserva.personas = Convert.ToInt32(entrada);
                    this.lbl_error_personas.Visible = false;
                }
                else
                {
                    this.lbl_error_personas.Visible = true;
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
            if (this.reserva.personas == 0 || this.reserva.cantidad_de_noches == 0)
            {
                this.lbl_error_carga_hotel.Visible = true;
            }
            else
            {
                this.lbl_error_carga_hotel.Visible = false;
                this.CargarHabitaciones();
                this.CargarRegimenes();
                this.HabilitarRegistroCliente();

                this.cbox_disponibles.Enabled = true;
                this.cbox_seleccionadas.Enabled = true;

                /*
                this.cbox_tipo_identificacion.Enabled = true;
                this.txtbox_identificacion.Enabled = true;
                this.txtbox_mail.Enabled = true;
                 * */
            }
        }
        /*
        private void btn_cargar_hoteles_Click(object sender, EventArgs e)
        {
            if (this.reserva.personas == 0 || this.reserva.cantidad_de_noches == 0)
            {
                this.lbl_error_carga_hotel.Visible = true;
            }
            else
            {
                this.lbl_error_carga_hotel.Visible = false;
                //this.CargarHoteles();
                this.cbox_tipo_identificacion.Enabled = true;
                this.txtbox_identificacion.Enabled = true;
                this.txtbox_mail.Enabled = true;
            }
        }
        */
        /*
        private void CargarHoteles()
        {
            if (!hotel_fijo)
            {
                this.hoteles = new DataTable();
                this.sda = new SqlDataAdapter("SELECT hote_id as ID, hote_ciudad as Ciudad, hote_estrellas as Estrellas, hote_calle as Calle, hote_recargaEstrella as Recarga FROM DERROCHADORES_DE_PAPEL.Hotel", conexion);
                this.sda.Fill(this.hoteles);
                this.grid_hoteles.DataSource = hoteles;
                this.HabilitarRegistroCliente();
            }
            else 
            {
                this.CargarRegimenes();
                this.CargarHabitaciones();
                this.HabilitarRegistroCliente();
                this.lbl_recarga_estrellas.Text = reserva.hotel.recarga_estrellas.ToString();
            }

        }
  */
        /*
        private void grid_hoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.reserva.hotel.ID = Convert.ToInt32(this.hoteles.Rows[e.RowIndex]["ID"]);
            this.reserva.hotel.recarga_estrellas = Convert.ToDouble(this.hoteles.Rows[e.RowIndex]["Recarga"]);
            
            this.CargarRegimenes();
            this.CargarHabitaciones();

            this.lbl_recarga_estrellas.Text = reserva.hotel.recarga_estrellas.ToString();
        }
        */
        private void CargarRegimenes()
        {
            this.cbox_regimenes.Enabled = true;
            this.regimenes = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.RegimenXHotel as rh JOIN DERROCHADORES_DE_PAPEL.Regimen as r ON ( rh.rexh_regimen = r.regi_codigo AND rh.rexh_hotel = " + reserva.hotel.ID.ToString() + ")", conexion);
            this.sda.Fill(regimenes);

            this.cbox_regimenes.Items.Clear();

            this.cbox_regimenes.Items.Insert(0, "<No seleccionado>");

            for (int indice = 0; indice < regimenes.Rows.Count - 1; indice++)
            {
                this.cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"].ToString());
            }

            this.cbox_regimenes.SelectedIndex = 0;
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = this.cbox_regimenes.SelectedIndex;
            string precio_base = String.Empty;
            if (this.cbox_regimenes.SelectedIndex == 0)
            {
                precio_base = regimenes.Rows[1]["regi_precioBase"].ToString();
                this.lbl_precio_base.Text = precio_base;
                this.reserva.precio_base = Convert.ToDouble(precio_base);
                this.reserva.regimen_seleccionado = false;
            }
            else
            {
                precio_base = this.regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
                this.lbl_precio_base.Text = precio_base;
                this.reserva.precio_base = Convert.ToDouble(precio_base);
                this.reserva.regimen_seleccionado = true;
            }
        }

        private void CargarHabitaciones()
        {
            this.habitaciones = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion as h, DERROCHADORES_DE_PAPEL.TipoDeHabitacion as t WHERE h.habi_tipo = t.tipo_codigo AND h.habi_hotel = " + this.reserva.hotel.ID.ToString(), conexion);
            this.sda.Fill(habitaciones);

            for (int indice = 0; indice < this.habitaciones.Rows.Count; indice++ )
            {
                Habitacion habitacion = new Habitacion();
                habitacion.descripcion = this.habitaciones.Rows[indice]["tipo_descripcion"].ToString();
                habitacion.cantidad_personas = Convert.ToInt32(this.habitaciones.Rows[indice]["tipo_cantidadDePersonas"].ToString());
                habitacion.numero = Convert.ToInt32(this.habitaciones.Rows[indice]["habi_numero"].ToString());
                this.habitaciones_disponibles.Add(habitacion);
            }

            this.ActualizarComboBoxHabitaciones();
        }

        private void btn_agregar_habitacion_Click(object sender, EventArgs e)
        {
            if (this.cbox_disponibles.SelectedIndex != 0)
            {
                this.reserva.habitaciones_reservadas.Add(this.habitaciones_disponibles[cbox_disponibles.SelectedIndex - 1]);
                this.habitaciones_disponibles.RemoveAt(cbox_disponibles.SelectedIndex - 1);
                this.ActualizarComboBoxHabitaciones();
            }
        }

        private void btn_eliminar_habitacion_Click(object sender, EventArgs e)
        {
            if (this.cbox_seleccionadas.SelectedIndex != 0)
            {
                this.habitaciones_disponibles.Add(this.reserva.habitaciones_reservadas[this.cbox_seleccionadas.SelectedIndex - 1]);
                this.reserva.habitaciones_reservadas.RemoveAt(this.cbox_seleccionadas.SelectedIndex - 1);
                this.ActualizarComboBoxHabitaciones();
            }
        }

        private void ActualizarComboBoxHabitaciones()
        {
            this.cbox_disponibles.Items.Clear();
            this.cbox_seleccionadas.Items.Clear();

            this.cbox_disponibles.Items.Add("<Seleccionar habitacion para reservar>");
            this.cbox_seleccionadas.Items.Add("<Seleccionar habitacion para eliminar>");

            for (int indice = 0; indice < this.habitaciones_disponibles.Count; indice++) 
            {
                this.cbox_disponibles.Items.Add(this.habitaciones_disponibles[indice].ToString());
            }

            for (int indice = 0; indice < this.reserva.habitaciones_reservadas.Count; indice++)
            {
                this.cbox_seleccionadas.Items.Add(this.reserva.habitaciones_reservadas[indice].ToString());
            }

            this.cbox_disponibles.SelectedIndex = 0;
            this.cbox_seleccionadas.SelectedIndex = 0;

            this.CalcularPrecio();
            this.VerificarCapacidadReserva();
        }

        private void CalcularPrecio()
        {
            this.reserva.CalcularPrecio();
            this.lbl_precio.Text = this.reserva.precio.ToString();
            
        }

        private void VerificarCapacidadReserva()
        {
            this.lbl_falta_habitaciones_2.Visible = this.lbl_falta_habitaciones_1.Visible = !this.reserva.CapacidadSuficiente();
        }

        void HabilitarRegistroCliente()
        {
            this.cbox_tipo_identificacion.Enabled = true;
            this.txtbox_identificacion.Enabled = true;
            this.txtbox_mail.Enabled = true;
            this.btn_reservar.Enabled = true;
            this.CargarTipoIdentificacion();
        }

        private void CargarTipoIdentificacion()
        {
            this.identificaciones = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Documento", conexion);
            this.sda.Fill(this.identificaciones);

            this.cbox_tipo_identificacion.Items.Clear();

            for (int indice = 0; indice < this.identificaciones.Rows.Count; indice++)
            {
                this.cbox_tipo_identificacion.Items.Add(identificaciones.Rows[indice]["docu_detalle"]);
            }

        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            this.lbl_falta_id.Visible = this.txtbox_identificacion.Text == "";
            this.lbl_falta_mail.Visible = this.txtbox_mail.Text == "";
            this.lbl_falta_tipo_id.Visible = this.cbox_tipo_identificacion.Text == "";
            this.lbl_id_incorrecta.Visible = !this.DocumentoValido();

            if ((!this.lbl_falta_id.Visible) && (!this.lbl_falta_mail.Visible) && (!this.lbl_falta_tipo_id.Visible) && (!this.lbl_id_incorrecta.Visible) )
            {
                if (!this.EsCliente())
                {
                    MessageBox.Show("Se debe registrar cliente");
                    this.RegistrarCliente();
                }
                else
                {
                    this.reserva.cliente = Convert.ToInt32(this.clientes.Rows[0]["clie_codigo"]);
                    this.AltaReserva();
                }
            }
        }

        bool DocumentoValido()
        {
            return this.txtbox_identificacion.Text.All( char.IsDigit );
        }

        bool EsCliente()
        {
            this.clientes = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Cliente as c WHERE c.clie_mail = '" + this.txtbox_mail.Text.ToString() + "'" , conexion);
            sda.Fill(clientes);
            return clientes.Rows.Count != 0;
        }

        private void RegistrarCliente()
        {
            Form alta_cliente = new AbmCliente.AltaCliente();
            this.Hide();
            alta_cliente.ShowDialog();
            this.Show();
        }

        private void AltaReserva()
        {
            conexion.Open();
            command = new SqlCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Reserva (rese_cliente, rese_cantidadDeNoches, rese_estado, rese_fecha, rese_fin, rese_hotel, rese_inicio, rese_regimen, rese_usuario) VALUES (@clie, @noches, @estado, @fecha, @incio, @fin, @hotel, @user)", conexion);
            command.Parameters.AddWithValue("@clie", this.reserva.cliente);
            command.Parameters.AddWithValue("@noches", this.reserva.cantidad_de_noches );
            command.Parameters.AddWithValue("@estado", this.CargarEstadosDeReserva("RESERVA CORRECTA") );
            command.Parameters.AddWithValue("@fecha", this.reserva.fecha_que_se_realizo_reserva );
            command.Parameters.AddWithValue("@incio", this.reserva.fecha_desde);
            command.Parameters.AddWithValue("@fin", this.reserva.fecha_hasta);
            command.Parameters.AddWithValue("@hotel", this.reserva.hotel.ID);
            command.Parameters.AddWithValue("@user", this.reserva.usuario);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        private int CargarEstadosDeReserva(string estado_buscado)
        {
            this.estados_reserva = new DataTable();
            sda = new SqlDataAdapter("SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado +"'", conexion);
            sda.Fill(estados_reserva);
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }




        private void atras_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }


    }
}
