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
        //Atributos de la forma
        private Form invocador;

        private DateTime fecha_que_se_realizo_reserva;
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        private int personas;
        private int cantidad_de_noches;
        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        DataTable hoteles = new DataTable();
        DataTable regimenes = new DataTable();
        DataTable tipo_habitaciones = new DataTable();

        public ModificarReserva(Form invocador)
        {
            InitializeComponent();
            this.invocador = invocador;

            this.date_desde.Enabled = false;
            this.date_hasta.Enabled = false;
            this.cbox_hoteles.Enabled = false;
            this.cbox_personas.Enabled = false;
            this.cbox_regimenes.Enabled = false;
            this.cbox_tipos_habitacion.Enabled = false;
            this.lbl_estrellas.Enabled = false;
            this.lbl_noches.Enabled = false;
            this.lbl_precio.Enabled = false;
            this.lbl_recarga_estrellas.Enabled = false;
            this.lbl_precio_base.Enabled = false;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hace de cuenta que estoy modificando algo");
        }

        private void btn_cargarReserva_Click(object sender, EventArgs e)
        {
            if (this.CodigoValido()) {
                this.CargarReserva();
                this.HabilitarModificacion();
            }
        }

        bool CodigoValido() { 
            /*Hacer una vista para fijarse si el codigo es valido-
             * revisar que no ssea una fecha valida
             */
            return true;
        }

        void CargarReserva() {
            /* Se completan los datos cargados
            this.date_desde.Enabled = ;
            this.date_hasta.Enabled = ;
            this.cbox_hoteles.Enabled = ;
            this.cbox_personas.Enabled = ;
            this.cbox_regimenes.Enabled = ;
            this.cbox_tipos_habitacion.Enabled = ;
            this.lbl_estrellas.Enabled = ;
            this.lbl_noches.Enabled = ;
            this.lbl_precio.Enabled = ;
            this.lbl_recarga_estrellas.Enabled = ;
            this.lbl_precio_base.Enabled = ;
             * */
        }

        void HabilitarModificacion() {
            this.date_desde.Enabled = true;
            this.date_hasta.Enabled = true;
            this.cbox_hoteles.Enabled = true;
            this.cbox_personas.Enabled = true;
            this.cbox_regimenes.Enabled = true;
            this.cbox_tipos_habitacion.Enabled = true;
            this.lbl_estrellas.Enabled = true;
            this.lbl_noches.Enabled = true;
            this.lbl_precio.Enabled = true;
            this.lbl_recarga_estrellas.Enabled = true;
            this.lbl_precio_base.Enabled = true;
        }
        
        //Comportamiento del form
        private void date_desde_ValueChanged(object sender, EventArgs e)
        {
            this.fecha_desde = this.date_desde.Value;
            if (date_desde.Value > date_hasta.Value)
            {
                date_hasta.Value = date_desde.Value;
            }
            this.calcular_cantidad_noches();
        }

        private void date_hasta_ValueChanged(object sender, EventArgs e)
        {
            this.fecha_hasta = this.date_hasta.Value;
            if (date_desde.Value > date_hasta.Value)
            {
                date_hasta.Value = date_desde.Value;
            }
            this.calcular_cantidad_noches();
        }

        private void calcular_cantidad_noches()
        {
            TimeSpan dias = this.fecha_hasta - this.fecha_desde;
            this.cantidad_de_noches = dias.Days;
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
            tipo_habitaciones = new DataTable();
            SqlDataAdapter sql_adapter_habitaciones = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.TipoDeHabitacion WHERE tipo_cantidadDePersonas >= " + this.personas.ToString(), conexion);
            sql_adapter_habitaciones.Fill(tipo_habitaciones);

            this.cbox_tipos_habitacion.Items.Clear();

            for (int indice = 0; indice < tipo_habitaciones.Rows.Count - 1; indice++)
            {
                this.cbox_tipos_habitacion.Items.Add(tipo_habitaciones.Rows[indice]["tipo_descripcion"].ToString());
            }

            this.cbox_tipos_habitacion.SelectedIndex = 0;
        }

        private void cbox_tipos_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarHoteles();
            this.cbox_hoteles.Enabled = true;
        }

        private void CargarHoteles()
        {
            this.hoteles = new DataTable();
            int indice_tipo_habitacion_seleccionado = this.cbox_tipos_habitacion.SelectedIndex;
            string tipo_habitacion_seleccionado = this.tipo_habitaciones.Rows[indice_tipo_habitacion_seleccionado]["tipo_codigo"].ToString();

            SqlDataAdapter sql_adapter_hoteles = new SqlDataAdapter("SELECT hote_id, hote_ciudad, hote_recargaEstrella , hote_estrellas,tipo_descripcion, tipo_cantidadDePersonas FROM DERROCHADORES_DE_PAPEL.Hotel, DERROCHADORES_DE_PAPEL.Habitacion, DERROCHADORES_DE_PAPEL.TipoDeHabitacion WHERE hote_id = habi_hotel AND habi_tipo = tipo_codigo AND tipo_codigo = " + tipo_habitacion_seleccionado + " GROUP BY hote_id, hote_ciudad, hote_recargaEstrella, hote_estrellas,tipo_descripcion, tipo_cantidadDePersonas", conexion);
            sql_adapter_hoteles.Fill(hoteles);

            this.cbox_hoteles.Items.Clear();
            int cantidad_hoteles = hoteles.Rows.Count;
            for (int indice = 0; indice < cantidad_hoteles - 1; indice++)
            {
                this.cbox_hoteles.Items.Add("Hotel en " + hoteles.Rows[indice]["hote_id"].ToString() + ", " + hoteles.Rows[indice]["hote_ciudad"].ToString());
            }
        }

        private void CargarRegimenes(string hotel_id_seleccionado)
        {
            this.regimenes = new DataTable();
            SqlDataAdapter sql_adapter_regimenes = new SqlDataAdapter("SELECT hote_id, regi_descripcion, regi_precioBase FROM DERROCHADORES_DE_PAPEL.Hotel as h, DERROCHADORES_DE_PAPEL.RegimenXHotel as rh, DERROCHADORES_DE_PAPEL.Regimen as r WHERE rh.rexh_hotel = h.hote_id AND rh.rexh_regimen = r.regi_codigo AND h.hote_id =  " + hotel_id_seleccionado + " ORDER BY hote_id;", conexion);
            sql_adapter_regimenes.Fill(regimenes);

            this.cbox_regimenes.Items.Clear();

            for (int indice = 0; indice < regimenes.Rows.Count - 1; indice++)
            {
                this.cbox_regimenes.Items.Add(regimenes.Rows[indice]["regi_descripcion"].ToString());
            }

            this.cbox_regimenes.Items.Insert(0, "<No seleccionado>");

        }

        private void cbox_hoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_hotel_seleccionado = this.cbox_hoteles.SelectedIndex;
            string hotel_id_seleccionado = this.hoteles.Rows[indice_hotel_seleccionado]["hote_id"].ToString();
            this.lbl_recarga_estrellas.Text = this.hoteles.Rows[indice_hotel_seleccionado]["hote_recargaEstrella"].ToString();
            this.lbl_estrellas.Text = this.hoteles.Rows[indice_hotel_seleccionado]["hote_estrellas"].ToString();
            this.CargarRegimenes(hotel_id_seleccionado);
            this.cbox_regimenes.Enabled = true;
        }

        private void cbox_regimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_regimen_seleccionado = this.cbox_regimenes.SelectedIndex;

            if (this.cbox_regimenes.SelectedIndex == 0)
            {
                this.lbl_precio_base.Text = regimenes.Rows[1]["regi_precioBase"].ToString();
            }
            else
            {
                this.lbl_precio_base.Text = this.regimenes.Rows[indice_regimen_seleccionado]["regi_precioBase"].ToString();
            }

            this.calcular_precio();
        }

        private void calcular_precio()
        {
            if (this.lbl_precio_base.Text != "" && this.lbl_recarga_estrellas.Text != "" && this.personas != 0)
            {
                this.lbl_precio.Text = ((Convert.ToDouble(this.lbl_precio_base.Text) + Convert.ToDouble(this.lbl_recarga_estrellas.Text)) * Convert.ToDouble(cantidad_de_noches) * Convert.ToDouble(this.personas)).ToString();
            }
        }

        void Reservar()
        {
            /*
             * ESTOY VIENDO COMO HACERLO CON TRANSAQ
             * */
        }
    }
}
