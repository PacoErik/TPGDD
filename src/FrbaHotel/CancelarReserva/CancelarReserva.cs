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
        private long usuario;
        private long hotel;
        private string codigo;
        private string tipo_cancelacion;
        private DataTable reserva = new DataTable();
        public CancelarReserva(long userId, string hotelId)
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            usuario = userId;
            hotel = Convert.ToInt64(hotelId);
            SetearTipoCancelacion();
        }

        private void SetearTipoCancelacion()
        { 
            //Se fija si el usuario es recepción o un "guest"
            if(usuario == 2)
            {
                tipo_cancelacion = "RESERVA CANCELADA POR CLIENTE";
            }
            else
            {
                tipo_cancelacion = "RESERVA CANCELADA POR RECEPCION";
            }
        }

        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbox_codigo.Text))
            {
                lbl_error.Text = "Por favor ingrese una reserva";
                lbl_error.Visible = true;
                return;
            }
            double num;
            if (!double.TryParse(txtbox_codigo.Text, out num))
            {
                lbl_error.Text = "Reserva inválida";
                lbl_error.Visible = true;
                return;
            }
            CargarReserva(txtbox_codigo.Text);
        }
        private void CargarReserva(string codigo_reserva)
        {
            reserva = new DataTable();
            UtilesSQL.llenarTabla(reserva, "SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '"+ codigo_reserva +"'" );
            if (reserva.Rows.Count == 0)
            {
                lbl_error.Text = "No se encuentra la reserva";
                lbl_error.Visible = true;
                return;
            }
            if (Convert.ToInt64(reserva.Rows[0]["rese_hotel"]) != hotel)
            {
                lbl_error.Text = "La reserva corresponde a otro hotel";
                lbl_error.Visible = true;
                return;
            }
            if (ReservaYaCancelada())
            {
                lbl_error.Text = "Ya se canceló esta reserva";
                lbl_error.Visible = true;
                return;
            }
            if (ReservaEfectivizada())
            {
                lbl_error.Text = "Esta reserva ya se efectivizó";
                lbl_error.Visible = true;
                return;
            }
            if (Convert.ToDateTime(Main.fecha()) > Convert.ToDateTime(reserva.Rows[0]["rese_inicio"]))
            {
                lbl_error.Text = "La reserva ya caducó";
                lbl_error.Visible = true;
                return;
            }
            TimeSpan dias_para_reserva = Convert.ToDateTime(Main.fecha()) - Convert.ToDateTime(reserva.Rows[0]["rese_inicio"]);
            if (dias_para_reserva.Duration().Days <= 1)
            {
                lbl_error.Text = "No se puede cancelar a menos de un día";
                lbl_error.Visible = true;
                return;
            }
            txtbox_codigo.ReadOnly = true;
            btn_cargar_reserva.Enabled = false;
            lbl_error.Visible = false;
            codigo = txtbox_codigo.Text;
            lbl_cargado_correcto.Visible = true;
            lbl_ingrese_motivo.Visible = true;
            txtbox_motivo.Enabled = true;
            enviar.Enabled = true;
        }
        private bool ReservaYaCancelada()
        {
            int estado_actual = Convert.ToInt32(reserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR RECEPCION")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR CLIENTE")) || (estado_actual == getEstadosDeReserva("RESERVA CANCELADA POR NO-SHOW"));
        }
        private bool ReservaEfectivizada()
        {
            int estado_actual = Convert.ToInt32(reserva.Rows[0]["rese_estado"]);
            return (estado_actual == getEstadosDeReserva("RESERVA EFECTIVIZADA"));
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            //txtbox_motivo tiene MaxLength = 255, así que no hay que verificar eso 
            labelMotivo.Visible = false;
            if (!String.IsNullOrWhiteSpace(txtbox_motivo.Text))
            {
                SqlCommand command = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.CancelacionReserva (canc_reserva, canc_motivo, canc_fechaDeCancelacion, canc_usuario) VALUES (@reserva, @motivo, CONVERT(DATETIME, @fecha), @user)");
                command.Parameters.AddWithValue("@reserva", Convert.ToInt64(codigo));
                command.Parameters.AddWithValue("@motivo", txtbox_motivo.Text);
                command.Parameters.AddWithValue("@fecha", Main.fecha());
                command.Parameters.AddWithValue("@user", usuario);
                UtilesSQL.ejecutarComandoNonQuery(command);

                SqlCommand command2 = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_estado = @estado WHERE rese_codigo = @reserva");
                command2.Parameters.AddWithValue("@reserva", Convert.ToInt64(codigo));
                command2.Parameters.AddWithValue("@estado", getEstadosDeReserva(tipo_cancelacion));
                UtilesSQL.ejecutarComandoNonQuery(command2);
                MessageBox.Show("Se canceló la reserva " + codigo);
                Close();
            }
            else
            {
                labelMotivo.Visible = true;
            }
        }

        private int getEstadosDeReserva(string estado_buscado)
        {
            DataTable estados_reserva = new DataTable();
            UtilesSQL.llenarTabla(estados_reserva, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = '" + estado_buscado + "'");
            return Convert.ToInt32(estados_reserva.Rows[0]["esta_id"]);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
