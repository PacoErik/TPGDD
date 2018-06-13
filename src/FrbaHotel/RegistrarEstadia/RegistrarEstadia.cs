using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataTable dtH = new DataTable();
        String factura;

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
            UtilesSQL.llenarTabla(reserva_dt, "SELECT rese_codigo, clie_apellido+' ,'+clie_nombre, regi_descripcion, usur_username, esta_detalle, rese_fecha, rese_cantidadDeNoches, rese_inicio, rese_fin, clie_id "
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
            if (!estado.Text.Equals("RESERVA EFECTIVIZADA"))
            {
                MessageBox.Show("La reserva no hizo el check-in");
                return;
            }

            //Checkea que no se haya realizado el check out
            dtH.Clear();
            UtilesSQL.llenarTabla(dtH, "SELECT h.habi_numero, h.habi_piso, e.esta_id FROM DERROCHADORES_DE_PAPEL.Habitacion AS h JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion AS rh ON rh.rexh_piso = h.habi_piso AND rh.rexh_numero = h.habi_numero JOIN DERROCHADORES_DE_PAPEL.Reserva AS r ON r.rese_codigo = rh.rexh_reserva JOIN DERROCHADORES_DE_PAPEL.Estadia AS e ON e.esta_id = r.rese_codigo WHERE rh.rexh_reserva = '" + reserva.Text + "' AND e.esta_usuarioCheckOut = NULL GROUP BY h.habi_numero, h.habi_piso, e.esta_id");
            if (dtH.Rows.Count == 0)
            {
                MessageBox.Show("Esta reserva ya realizo el check out.");
                return;
            }
            
            
            SqlCommand com = UtilesSQL.crearCommand("SELECT f.fact_numero FROM DERROCHADORES_DE_PAPEL.Factura AS f JOIN DERROCHADORES_DE_PAPEL.Estadia AS e ON e.esta_id = f.fact_estadia WHERE e.esta_id = @estadia");
            com.Parameters.AddWithValue("@estadia", dtH.Rows[0][2].ToString());
            factura = com.ExecuteScalar().ToString();
            if (String.IsNullOrEmpty(factura))
            {
                //Crea la factura para poder iniciar el proceso de check out
                com = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Factura (fact_fecha, fact_estadia, fact_cliente) VALUES (@fecha, @estadia, @cliente)");
                com.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-dd-MM HH:mm:ss.fff"));
                com.Parameters.AddWithValue("@estadia", dtH.Rows[0][2].ToString());
                com.Parameters.AddWithValue("@cliente", reserva_dt.Rows[0][9].ToString());
                UtilesSQL.ejecutarComandoNonQuery(com);

                com = UtilesSQL.crearCommand("SELECT f.fact_numero FROM DERROCHADORES_DE_PAPEL.Factura AS f JOIN DERROCHADORES_DE_PAPEL.Estadia AS e ON e.esta_id = f.fact_estadia WHERE e.esta_id = @estadia");
                com.Parameters.AddWithValue("@estadia", dtH.Rows[0][2].ToString());
                factura = com.ExecuteScalar().ToString();
            }

            Consumibles();
        }
        private void Consumibles()
        {
            //Si ya registro consumibles va directo al check out, sino pregunta
            SqlCommand com = UtilesSQL.crearCommand("SELECT item_id FROM DERROCHADORES_DE_PAPEL.ItemDeFactura WHERE item_factura = @factura AND item_habitacionNumero = @hab AND item_habitacionPiso = @piso AND item_consumible IS NOT NULL");
            com.Parameters.AddWithValue("@factura", factura);
            com.Parameters.AddWithValue("@hab", dtH.Rows[0][0].ToString());
            com.Parameters.AddWithValue("@piso", dtH.Rows[0][1].ToString());
            object itemPrevio = com.ExecuteScalar();
            if (itemPrevio != null)
            {
                this.Hide();
                Form f1 = new CheckOut(factura);
                f1.ShowDialog();
                this.Close();
            }
            var confirmResult = MessageBox.Show("Desea registrar consumibles?", "Registrar consumibles?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                Form f1 = new RegistrarConsumible.RegistrarConsumible(dtH.Rows[0][0].ToString(), dtH.Rows[0][1].ToString(), dtH.Rows[0][2].ToString());
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form f1 = new CheckOut(factura);
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
