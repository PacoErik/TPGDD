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

namespace FrbaHotel.CancelarReserva
{
    public partial class CancelarReserva : Form
    {
        private int usuario;
        private int hotel;
        private string codigo;
        private string tipo_cancelacion;

        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        private SqlCommand command;
        private SqlDataAdapter sda;

        private DataTable reserva = new DataTable();
        private DataTable estados_reserva = new DataTable();
        public CancelarReserva(int userId, string hotelId)
        {
            InitializeComponent();
            this.usuario = userId;
            this.hotel = Convert.ToInt32(hotelId);
            this.lbl_error.Visible = false;
            this.lbl_cargado_correcto.Visible = false;
            this.lbl_ingrese_motivo.Visible = false;
            this.txtbox_motivo.Enabled = false;
            this.SetearTipoCancelacion();
            this.CargarEstadosReserva();
        }

        private void CargarEstadosReserva()
        {
            this.estados_reserva = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva", conexion);
            this.sda.Fill(this.estados_reserva);
        }

        private void SetearTipoCancelacion()
        { 
            if(this.usuario == this.GetUsuarioGuest())
            {
                this.tipo_cancelacion = "RESERVA CANCELADA POR CLIENTE";
            }else{
                this.tipo_cancelacion = "RESERVA CANCELADA POR RECEPCION";
            }
        }

        private int GetUsuarioGuest()
        {
            DataTable user = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Usuario WHERE usur_username = 'guest'", conexion);
            sda.Fill(user);
            return Convert.ToInt32(user.Rows[0]["usur_id"]);
        }

        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if(this.txtbox_codigo.Text != "")
            {
                this.CargarReserva(this.txtbox_codigo.Text);
            }
        }

        private void CargarReserva(string codigo_reserva)
        {
            this.reserva = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '"+ codigo_reserva +"'", conexion);
            this.sda.Fill(this.reserva);
            if (this.reserva.Rows.Count == 0)
            {
                this.lbl_error.Text = "No se encuentra la reserva";
                this.lbl_error.Visible = true;
            }
            else {
                TimeSpan dias_para_reserva = DateTime.Today - Convert.ToDateTime(this.reserva.Rows[0]["rese_inicio"]);
                if (dias_para_reserva.Days <= 1)
                {
                    this.lbl_error.Text = "No se puede cancelar a menos de un dia";
                    this.lbl_error.Visible = true;
                }
                else
                {
                    if (!this.ReservaYaCancelada())
                    {
                        this.lbl_error.Visible = false;
                        this.codigo = this.txtbox_codigo.Text;
                        this.lbl_cargado_correcto.Visible = true;
                        this.lbl_ingrese_motivo.Visible = true;
                        this.txtbox_motivo.Enabled = true;
                    }
                    else {
                        this.lbl_error.Text = "Ya se cancelo esta reserva";
                        this.lbl_error.Visible = true;
                    }
                }
            }
                
        }

        private bool ReservaYaCancelada()
        {
            int estado_actual = Convert.ToInt32(this.reserva.Rows[0]["rese_estado"]);
            return (estado_actual == this.getEstadosDeReserva("RESERVA CANCELADA POR RECEPCION")) || (estado_actual == this.getEstadosDeReserva("RESERVA CANCELADA POR CLIENTE")) || (estado_actual == this.getEstadosDeReserva("RESERVA CANCELADA POR NO-SHOW"));
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if (this.txtbox_motivo.Text != "")
            {
                if (this.txtbox_motivo.Text.Length > 255)
                {
                    MessageBox.Show("Motivo muy largo");
                }
                else {
                    conexion.Open();
                    command = new SqlCommand("INSERT INTO DERROCHADORES_DE_PAPEL.CancelacionReserva (canc_reserva, canc_motivo, canc_fechaDeCancelacion, canc_usuario) VALUES (@reserva, @motivo, @fecha, @user)", conexion);
                    command.Parameters.AddWithValue("@reserva", Convert.ToInt32(this.codigo));
                    command.Parameters.AddWithValue("@motivo", this.txtbox_motivo.Text);
                    command.Parameters.AddWithValue("@fecha", DateTime.Today);
                    command.Parameters.AddWithValue("@user", this.usuario);
                    command.ExecuteNonQuery();
                    conexion.Close();

                    conexion.Open();
                    command = new SqlCommand("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_estado = @estado WHERE rese_codigo = @reserva", conexion);
                    command.Parameters.AddWithValue("@reserva", Convert.ToInt32(this.codigo));
                    command.Parameters.AddWithValue("@estado", this.getEstadosDeReserva(this.tipo_cancelacion));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la reserva " + this.codigo);
                    conexion.Close();
                    this.Close();
                }
            }
        }

 

        private int getEstadosDeReserva(string estado_buscado)
        {
            DataTable estados_reserva = new DataTable();
            sda = new SqlDataAdapter("SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'", conexion);
            sda.Fill(estados_reserva);
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
