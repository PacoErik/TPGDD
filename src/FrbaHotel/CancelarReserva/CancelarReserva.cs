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

        private SqlCommand command;
        private DataTable reserva = new DataTable();
        private DataTable estados_reserva = new DataTable();
        public CancelarReserva(int userId, string hotelId)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            usuario = userId;
            hotel = Convert.ToInt32(hotelId);
            lbl_error.Visible = false;
            lbl_cargado_correcto.Visible = false;
            lbl_ingrese_motivo.Visible = false;
            txtbox_motivo.Enabled = false;
            SetearTipoCancelacion();
            CargarEstadosReserva();
        }

        private void CargarEstadosReserva()
        {
            estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva");
        }

        private void SetearTipoCancelacion()
        { 
            if(usuario == GetUsuarioGuest())
            {
                tipo_cancelacion = "RESERVA CANCELADA POR CLIENTE";
            }else{
                tipo_cancelacion = "RESERVA CANCELADA POR RECEPCION";
            }
        }

        private int GetUsuarioGuest()
        {
            DataTable user = new DataTable();
            UtilesSQL.llenarTabla(user, "SELECT * FROM DERROCHADORES_DE_PAPEL.Usuario WHERE usur_username = 'guest'");
            return Convert.ToInt32(user.Rows[0]["usur_id"]);
        }

        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if(txtbox_codigo.Text != "")
            {
                CargarReserva(txtbox_codigo.Text);
            }
        }

        private void CargarReserva(string codigo_reserva)
        {
            reserva = new DataTable();
            UtilesSQL.llenarTabla(reserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '"+ codigo_reserva +"'" );
            if (reserva.Rows.Count == 0)
            {
                lbl_error.Text = "No se encuentra la reserva";
                lbl_error.Visible = true;
            }
            else {
                if (Convert.ToInt32(reserva.Rows[0]["rese_hotel"]) != hotel)
                {
                    lbl_error.Text = "La reserva correspondea otro hotel";
                    lbl_error.Visible = true;
                }
                else
                {
                    TimeSpan dias_para_reserva = Convert.ToDateTime(Main.fecha()) - Convert.ToDateTime(reserva.Rows[0]["rese_inicio"]);
                    if (dias_para_reserva.Duration().Days <= 1)
                    {
                        lbl_error.Text = "No se puede cancelar a menos de un dia";
                        lbl_error.Visible = true;
                    }
                    else
                    {
                        if (!ReservaYaCancelada())
                        {
                            lbl_error.Visible = false;
                            codigo = txtbox_codigo.Text;
                            lbl_cargado_correcto.Visible = true;
                            lbl_ingrese_motivo.Visible = true;
                            txtbox_motivo.Enabled = true;
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
            int estado_actual = Convert.ToInt32(reserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR RECEPCION")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR CLIENTE")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR NO-SHOW"));
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if (txtbox_motivo.Text != "")
            {
                if (txtbox_motivo.Text.Length > 255)
                {
                    MessageBox.Show("Motivo muy largo");
                }
                else {
                    command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.CancelacionReserva (canc_reserva, canc_motivo, canc_fechaDeCancelacion, canc_usuario) VALUES (@reserva, @motivo, @fecha, @user)");
                    command.Parameters.AddWithValue("@reserva", Convert.ToInt32(codigo));
                    command.Parameters.AddWithValue("@motivo", txtbox_motivo.Text);
                    command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(Main.fecha()));
                    command.Parameters.AddWithValue("@user", usuario);
                    UtilesSQL.ejecutarComandoNonQuery(command);

                    command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_estado = @estado WHERE rese_codigo = @reserva");
                    command.Parameters.AddWithValue("@reserva", Convert.ToInt32(codigo));
                    command.Parameters.AddWithValue("@estado", getEstadosDeReserva(tipo_cancelacion));
                    UtilesSQL.ejecutarComandoNonQuery(command);
                    MessageBox.Show("Se elimino la reserva " + codigo);
                    Close();
                }
            }
        }

        private int getEstadosDeReserva(string estado_buscado)
        {
            DataTable estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'");
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
