using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {
        DataTable reserva_dt;

        public RegistrarEstadia()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarEstadia_Load(object sender, EventArgs e)
        {

        }

        private void limpiarTodo()
        {
            reserva.Clear();
            cliente.Clear();
            regimen.Clear();
            usuario.Clear();
            estado.Clear();
            fecha_reserva.Clear();
            cantidad_noches.Clear();
            fecha_inicio.Clear();
            fecha_fin.Clear();
            checkin.Enabled = false;
            checkout.Enabled = false;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            limpiarTodo();

            if (!numero_reserva.Text.All(char.IsDigit) || numero_reserva.TextLength == 0)
            {
                MessageBox.Show("Ingrese un número de reserva válido");
                return;
            }

            reserva_dt = new DataTable();
            UtilesSQL.llenarTabla(reserva_dt, "SELECT rese_codigo, clie_apellido+' ,'+clie_nombre, regi_descripcion, usur_username, esta_detalle, rese_fecha, rese_cantidadDeNoches, rese_inicio, rese_fin "
                                            + "FROM DERROCHADORES_DE_PAPEL.Reserva JOIN "
                                                + "DERROCHADORES_DE_PAPEL.Cliente ON rese_cliente = clie_id JOIN "
                                                + "DERROCHADORES_DE_PAPEL.Regimen ON rese_regimen = regi_codigo JOIN "
                                                + "DERROCHADORES_DE_PAPEL.Usuario ON rese_usuario = usur_id JOIN "
                                                + "DERROCHADORES_DE_PAPEL.EstadoDeReserva ON rese_estado = esta_id "
                                            + "WHERE rese_hotel = "+Login.SeleccionFuncionalidad.getHotelId()+" AND rese_codigo = "+numero_reserva.Text);

            if (reserva_dt.Rows.Count == 0)
            {
                MessageBox.Show("No existe una reserva con ese código en este hotel");
                return;
            }

            checkin.Enabled = true;
            checkout.Enabled = true;

            DataRow reserva_fila = reserva_dt.Rows[0];
            reserva.Text = reserva_dt.Rows[0][0].ToString();
            cliente.Text = reserva_dt.Rows[0][1].ToString();
            regimen.Text = reserva_dt.Rows[0][2].ToString();
            usuario.Text = reserva_dt.Rows[0][3].ToString();
            estado.Text = reserva_dt.Rows[0][4].ToString();
            fecha_reserva.Text = reserva_dt.Rows[0][5].ToString();
            cantidad_noches.Text = reserva_dt.Rows[0][6].ToString();
            fecha_inicio.Text = reserva_dt.Rows[0][7].ToString();
            fecha_fin.Text = reserva_dt.Rows[0][8].ToString();
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            if (estado.Text.Equals("RESERVA CORRECTA") || estado.Text.Equals("RESERVA MODIFICADA"))
            {
                DateTime fechaActual = DateTime.Parse(Main.fecha());
                DateTime fechaInicio = DateTime.Parse(fecha_inicio.Text);
                if (fechaActual < fechaInicio)
                {
                    MessageBox.Show("Todavía no es la fecha correcta para hacer el check-in");
                    return;
                }
                if (fechaActual > fechaInicio)
                {
                    MessageBox.Show("La fecha para hacer el check-in ya pasó. La reserva será cancelada");
                    return;
                }

                //Se efectiviza la reserva
                //Se genera la factura inicial
                //Se cargan los demás huéspedes que acompañan al cliente original
                //Se distribuyen los huéspedes en las habitaciones
            }
            else if (estado.Text.Equals("RESERVA EFECTIVIZADA"))
            {
                MessageBox.Show("La reserva ya tuvo su check-in correspondiente");
                return;
            }
            else
            {
                MessageBox.Show("La reserva fue cancelada. No es posible hacer check-in");
                return;
            }
        }

        private void checkout_Click(object sender, EventArgs e)
        {

        }
    }
}
