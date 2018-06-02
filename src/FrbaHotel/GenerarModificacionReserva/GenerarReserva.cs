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
        private DateTime fecha_que_se_realizo_reserva;
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        private int personas;
        private int cantidad_de_noches;
        //private SqlCommand command;
        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        DataTable hoteles = new DataTable();
        DataTable regimenes = new DataTable();
        DataTable tipo_habitaciones = new DataTable();
        public GenerarReserva(Form invocador)
        {
            InitializeComponent();
            fecha_que_se_realizo_reserva = DateTime.Today;
            fecha_desde = DateTime.Today;
            fecha_hasta = DateTime.Today;
            date_desde.MinDate = DateTime.Today;
            date_hasta.MinDate = DateTime.Today;

            //Inicializaciones
            this.cbox_tipos_habitacion.Enabled = false;
            this.cbox_regimenes.Enabled = false;
            this.cbox_hoteles.Enabled = false;

            //Inicializacion de intefaz
            this.cbox_hoteles.Text = "<Seleccione hotel>";
            this.cbox_personas.Text = "<Numero de personas>";
            this.lbl_noches.Text = this.lbl_estrellas.Text = this.lbl_precio_base.Text = this.lbl_recarga_estrellas.Text = String.Empty;
        }

        private void date_desde_ValueChanged(object sender, EventArgs e)
        {
            this.fecha_desde = this.date_desde.Value;
            if (date_desde.Value > date_hasta.Value)
            {
                date_hasta.Value = date_desde.Value;
            }
            //this.CargarHoteles();
            this.calcular_cantidad_noches();
        }

        private void date_hasta_ValueChanged(object sender, EventArgs e)
        {
            this.fecha_hasta = this.date_hasta.Value;
            if (date_desde.Value > date_hasta.Value)
            {
                date_hasta.Value = date_desde.Value;
            }
            //this.CargarHoteles();
            this.calcular_cantidad_noches();
        }

        private void calcular_cantidad_noches()
        {
            this.cantidad_de_noches = this.date_desde.Value.Day - this.date_hasta.Value.Day;
            this.lbl_noches.Text = this.cantidad_de_noches.ToString();
        }


        private void cbox_personas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.personas = Convert.ToInt32(cbox_personas.Text);
            cbox_tipos_habitacion.Enabled = true;
            this.CargarTipoHabitaciones();
        }

        private void CargarTipoHabitaciones()
        {
            SqlDataAdapter sql_adapter_habitaciones = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.TipoDeHabitacion WHERE tipo_cantidadDePersonas >= " + this.personas.ToString(), conexion);
            sql_adapter_habitaciones.Fill(tipo_habitaciones);

            for (int indice = 0; indice < tipo_habitaciones.Rows.Count - 1; indice++)
            {
                cbox_tipos_habitacion.Items.Add(tipo_habitaciones.Rows[indice]["tipo_descripcion"]);
            }
        }

        private void cbox_tipos_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarHoteles();
            this.cbox_hoteles.Enabled = true;
        }

        private void CargarHoteles()
        {
            int indice_tipo_habitacion_seleccionado = this.cbox_tipos_habitacion.SelectedIndex;
            string tipo_habitacion_seleccionado = this.tipo_habitaciones.Rows[indice_tipo_habitacion_seleccionado]["tipo_codigo"].ToString();

            SqlDataAdapter sql_adapter_hoteles = new SqlDataAdapter("SELECT hote_id, hote_ciudad, hote_recargaEstrella , hote_estrellas,tipo_descripcion, tipo_cantidadDePersonas FROM DERROCHADORES_DE_PAPEL.Hotel, DERROCHADORES_DE_PAPEL.Habitacion, DERROCHADORES_DE_PAPEL.TipoDeHabitacion WHERE hote_id = habi_hotel AND habi_tipo = tipo_codigo AND tipo_codigo = " + tipo_habitacion_seleccionado + " GROUP BY hote_id, hote_ciudad, hote_recargaEstrella, hote_estrellas,tipo_descripcion, tipo_cantidadDePersonas", conexion);
            sql_adapter_hoteles.Fill(hoteles);
            this.refresh_cbox_hoteles();
        }

        private void refresh_cbox_hoteles()
        {
            int cantidad_hoteles = hoteles.Rows.Count;
            for (int indice = 0; indice < cantidad_hoteles-1; indice++) {
                this.cbox_hoteles.Items.Add("Hotel en " + hoteles.Rows[indice]["hote_id"].ToString() + ", " + hoteles.Rows[indice]["hote_ciudad"].ToString());
            }
        }

        private void refresh_cbox_regimenes(string hotel_id_seleccionado)
        {
            SqlDataAdapter sql_adapter_regimenes = new SqlDataAdapter("SELECT hote_id, regi_descripcion, regi_precioBase FROM DERROCHADORES_DE_PAPEL.Hotel as h, DERROCHADORES_DE_PAPEL.RegimenXHotel as rh, DERROCHADORES_DE_PAPEL.Regimen as r WHERE rh.rexh_hotel = h.hote_id AND rh.rexh_regimen = r.regi_codigo AND h.hote_id =  " + hotel_id_seleccionado + " ORDER BY hote_id;", conexion);
            sql_adapter_regimenes.Fill(regimenes);

            for (int indice = 0; indice < regimenes.Rows.Count - 1; indice++)
            {
                this.cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"]);
            }

        }

        private void cbox_hoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_hotel_seleccionado = this.cbox_hoteles.SelectedIndex;
            string hotel_id_seleccionado = this.hoteles.Rows[indice_hotel_seleccionado]["hote_id"].ToString();
            this.refresh_cbox_regimenes(hotel_id_seleccionado);
            this.lbl_recarga_estrellas.Text = this.hoteles.Rows[indice_hotel_seleccionado]["hote_recargaEstrella"].ToString();
            this.lbl_estrellas.Text = this.hoteles.Rows[indice_hotel_seleccionado]["hote_estrellas"].ToString();
            this.cbox_regimenes.Enabled = true;
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = this.cbox_regimenes.SelectedIndex;
            this.lbl_precio_base.Text = this.regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
        }

        private void atras_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
