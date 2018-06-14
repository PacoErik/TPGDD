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
        int cantidad_personas;
        DataTable dtH = new DataTable();
        String factura;
        String cliente_id;
        String cliente_nombre;
        String cliente_apellido;
        String cliente_mail;

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

            UtilesSQL.llenarTabla(reserva_dt, "SELECT rese_codigo, clie_apellido, regi_descripcion, usur_username, esta_detalle, rese_fecha, rese_cantidadDeNoches, rese_inicio, rese_fin, clie_id, rese_cantidadDePersonas, clie_nombre, clie_mail "
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

            cliente_id = reserva_dt.Rows[0][9].ToString();
            cliente_apellido = reserva_dt.Rows[0][1].ToString();
            cliente_nombre = reserva_dt.Rows[0][11].ToString();
            cliente_mail = reserva_dt.Rows[0][12].ToString();

            reserva.Text = reserva_dt.Rows[0][0].ToString();
            cliente.Text = cliente_apellido+", "+cliente_nombre;
            regimen.Text = reserva_dt.Rows[0][2].ToString();
            usuario.Text = reserva_dt.Rows[0][3].ToString();
            estado.Text = reserva_dt.Rows[0][4].ToString();
            fecha_reserva.Text = reserva_dt.Rows[0][5].ToString();
            cantidad_noches.Text = reserva_dt.Rows[0][6].ToString();
            fecha_inicio.Text = reserva_dt.Rows[0][7].ToString();
            fecha_fin.Text = reserva_dt.Rows[0][8].ToString();

            cantidad_personas = Convert.ToInt32(reserva_dt.Rows[0][10].ToString());
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
                    UtilesSQL.ejecutarComandoNonQuery("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_estado = (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = \'RESERVA CANCELADA POR RECEPCION\')");
                    estado.Text = "RESERVA CANCELADA POR RECEPCION";
                    return;
                }

                DataTable distribucionClientes_dt;

                //Cargamos y distribuimos los clientes en caso de que sean más que uno
                //Si es solo 1, se asume que solo tiene una habitación reservada y se lo asigna a ella

                if (cantidad_personas > 1)
                {
                    this.Hide();
                    ElegirClientes elegirClientes = new ElegirClientes(cliente_id, cliente_apellido, cliente_nombre, cliente_mail, reserva.Text, cantidad_personas);
                    elegirClientes.ShowDialog();
                    this.Show();
                    if (elegirClientes.esCorrecto())
                    {
                        distribucionClientes_dt = elegirClientes.getDistribucionClientes_dt().Copy();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else 
                {
                    distribucionClientes_dt = new DataTable();
                    UtilesSQL.llenarTabla(distribucionClientes_dt, "SELECT rese_cliente, NULL, NULL, rexh_numero, rexh_piso FROM DERROCHADORES_DE_PAPEL.Reserva JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON rexh_reserva = rese_codigo WHERE rese_codigo = " + reserva.Text);
                }

                //Se efectiviza la reserva
                UtilesSQL.ejecutarComandoNonQuery("UPDATE DERROCHADORES_DE_PAPEL.Reserva SET rese_estado = (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = \'RESERVA EFECTIVIZADA\')");

                //Se genera la estadía
                SqlCommand comando = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Estadia (esta_fechaDeInicio, esta_fechaDeFin, esta_cantidadDeNoches, esta_reserva, esta_usuarioCheckIn, esta_usuarioCheckOut) VALUES (@inicio, @fin, @noches, @reserva, @usuarioCheckIn, NULL)");
                comando.Parameters.AddWithValue("@inicio", fecha_inicio.Text);
                comando.Parameters.AddWithValue("@fin", fecha_fin.Text);
                comando.Parameters.AddWithValue("@noches", cantidad_noches.Text);
                comando.Parameters.AddWithValue("@reserva", reserva.Text);
                comando.Parameters.AddWithValue("@usuarioCheckIn", Login.SeleccionFuncionalidad.getUserId());
                comando.ExecuteNonQuery();

                comando = UtilesSQL.crearCommand("SELECT esta_id FROM DERROCHADORES_DE_PAPEL.Estadia WHERE esta_reserva = " + reserva.Text);
                String estadia_id = comando.ExecuteScalar().ToString();
                
                //Se asignan los clientes a la estadía
                foreach (DataRow cliente in distribucionClientes_dt.Rows)
                {
                    UtilesSQL.ejecutarComandoNonQuery("INSERT INTO DERROCHADORES_DE_PAPEL.EstadiaXCliente (esxc_estadia, esxc_cliente, esxc_hotel, esxc_numero, esxc_piso) VALUES ("+estadia_id+","+cliente[0].ToString()+","+Login.SeleccionFuncionalidad.getHotelId()+","+cliente[3].ToString()+","+cliente[4].ToString()+")");
                }

                //Se actualiza la reserva en pantalla
                MessageBox.Show("El check-in se realizó con éxito");
                estado.Text = "RESERVA EFECTIVIZADA";
            }
            else if (estado.Text.Equals("RESERVA EFECTIVIZADA"))
            {
                MessageBox.Show("La reserva ya tuvo su check-in previamente");
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
            UtilesSQL.llenarTabla(dtH, "SELECT h.habi_numero, h.habi_piso, e.esta_id FROM DERROCHADORES_DE_PAPEL.Habitacion AS h JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion AS rh ON rh.rexh_piso = h.habi_piso AND rh.rexh_numero = h.habi_numero JOIN DERROCHADORES_DE_PAPEL.Reserva AS r ON r.rese_codigo = rh.rexh_reserva JOIN DERROCHADORES_DE_PAPEL.Estadia AS e ON e.esta_id = r.rese_codigo WHERE rh.rexh_reserva = '" + reserva.Text + "' AND e.esta_usuarioCheckOut IS NULL GROUP BY h.habi_numero, h.habi_piso, e.esta_id");
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
                com.Parameters.AddWithValue("@fecha", Main.fecha());
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
