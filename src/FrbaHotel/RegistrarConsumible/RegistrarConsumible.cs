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

namespace FrbaHotel.RegistrarConsumible
{
    public partial class RegistrarConsumible : Form
    {
        DataTable estadias_dt;
        DataTable habitaciones_dt;
        DataTable consumibles_dt;
        DataTable consumibles_elegidos_dt;
        String estadia_elegida;

        public RegistrarConsumible()
        {
            UtilesSQL.inicializar();
            String hotel = Login.SeleccionFuncionalidad.getHotelId();
            InitializeComponent();
            estadias_dt = new DataTable();
            consumibles_dt = new DataTable();
            UtilesSQL.llenarTabla(estadias_dt, "SELECT esta_id, habi_numero, habi_piso "
                                            + "FROM DERROCHADORES_DE_PAPEL.Estadia JOIN "
                                                + "DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON esta_reserva = rexh_reserva JOIN "
                                                + "DERROCHADORES_DE_PAPEL.Habitacion ON rexh_hotel = habi_hotel AND "
                                                                                    + "rexh_numero = habi_numero AND "
                                                                                    + "rexh_piso = habi_piso "
                                                + "WHERE habi_hotel = "+hotel);
            UtilesSQL.llenarTabla(consumibles_dt, "SELECT cons_codigo, cons_detalle, cons_precio "
                                                 + "FROM DERROCHADORES_DE_PAPEL.Consumible");
            disponibles.DataSource = consumibles_dt;
            reiniciarHabitaciones();
            consumibles_elegidos_dt = new DataTable();
            consumibles_elegidos_dt.Columns.Add("cons_codigo");
            consumibles_elegidos_dt.Columns.Add("cons_detalle");
            consumibles_elegidos_dt.Columns.Add("cons_precio");
            consumibles_elegidos_dt.Columns.Add("item_cantidad");
            elegidos.DataSource = consumibles_elegidos_dt;
        }

        private void reiniciarHabitaciones()
        {
            habitaciones.Items.Clear();
            habitaciones.Items.Add("Ninguna");
            habitaciones.SelectedIndex = 0;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            reiniciarHabitaciones();
            ElegirEstadia f1 = new ElegirEstadia();
            f1.ShowDialog();
            if (!f1.IsDisposed || f1.numeroE == null)
            {
                estadia.Text = f1.numeroE;

                //Llenar las habitaciones en base a la estadía ingresada
                habitaciones.Items.Clear();
                habitaciones_dt = new DataTable();
                habitaciones_dt.Columns.Add("esta_id");
                habitaciones_dt.Columns.Add("habi_numero");
                habitaciones_dt.Columns.Add("habi_piso");
                estadias_dt.Select().Where(row => row["esta_id"].ToString() == estadia.Text).CopyToDataTable(habitaciones_dt, LoadOption.PreserveChanges);
                if (habitaciones_dt.Rows.Count == 0)
                {
                    reiniciarHabitaciones();
                    MessageBox.Show("La estadía ingresada no existe en este hotel");
                    estadia.Clear();
                    return;
                }
                //estadia_elegida = estadia.Text;
                for (int indice = 0; indice < habitaciones_dt.Rows.Count; indice++)
                {
                    habitaciones.Items.Add("Número: " + habitaciones_dt.Rows[indice]["habi_numero"] + " - Piso: " + habitaciones_dt.Rows[indice]["habi_piso"]);
                }
            }
        }

        private void buttonAgregarConsumible_Click(object sender, EventArgs e)
        {
            int cantidad;
            RecibirEntrada:
                String resultado = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántas unidades del producto va a agregar?", "Cantidad de consumibles", "1");
                if (resultado.Equals(""))
                {
                    return;
                }
                if (!Int32.TryParse(resultado, out cantidad))
                {
                    goto RecibirEntrada;
                }

                DataRow consumible = ((DataRowView)disponibles.Rows[disponibles.CurrentCell.RowIndex].DataBoundItem).Row;
                consumibles_elegidos_dt.Rows.Add(consumible["cons_codigo"].ToString(), consumible["cons_detalle"].ToString(), consumible["cons_precio"].ToString(), cantidad.ToString());
                consumibles_dt.Rows.Remove(consumible);
        }
        private void buttonQuitarConsumible_Click(object sender, EventArgs e)
        {
            DataRow consumible = ((DataRowView)elegidos.Rows[elegidos.CurrentCell.RowIndex].DataBoundItem).Row;
            consumibles_dt.Rows.Add(consumible["cons_codigo"].ToString(), consumible["cons_detalle"].ToString(), consumible["cons_precio"].ToString());
            consumibles_elegidos_dt.Rows.Remove(consumible);
        }
        
        private void guardar_Click(object sender, EventArgs e)
        {
            if (habitaciones.SelectedIndex < 0)
            {
                MessageBox.Show("Debe elegir una habitación");
                return;
            }
            if (estadia.Text.Equals("") || habitaciones.SelectedItem.Equals("Ninguna"))
            {
                MessageBox.Show("Debe ingresar un número de estadía válido");
                return;
            }
            if (consumibles_elegidos_dt.Rows.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos un consumible");
                return;
            }

            SqlCommand com = UtilesSQL.crearCommand("SELECT f.fact_numero FROM DERROCHADORES_DE_PAPEL.Factura AS f JOIN DERROCHADORES_DE_PAPEL.Estadia AS e ON e.esta_id = f.fact_estadia WHERE e.esta_id = @estadia AND e.esta_usuarioCheckOut IS NOT NULL");
            com.Parameters.AddWithValue("@estadia", estadia.Text);
            String factura = (String) com.ExecuteScalar();
            if (String.IsNullOrEmpty(factura))
            {
                MessageBox.Show("La estadia ingresada ya hizo el check-out");
                return;
            
            }
            int costoTotal = 0;
            foreach (DataRow consumible in consumibles_elegidos_dt.Rows)
            {
                int costoConsumible = Int32.Parse(consumible[2].ToString()) * Int32.Parse(consumible[3].ToString());
                costoTotal += costoConsumible;

                MessageBox.Show(consumible[0].ToString());
                SqlCommand com2 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ItemDeFactura (item_cantidad, item_monto, item_factura, item_descripcion, item_consumible) VALUES (@cant, @monto, @fact, @desc, @cons)");
                com2.Parameters.AddWithValue("@cant", consumible[3].ToString());
                com2.Parameters.AddWithValue("@monto", costoConsumible);
                com2.Parameters.AddWithValue("@fact", factura);
                com2.Parameters.AddWithValue("@desc", consumible[1].ToString());
                com2.Parameters.AddWithValue("@cons", consumible[0].ToString());
                UtilesSQL.ejecutarComandoNonQuery(com2);
            }


            SqlCommand com3 = UtilesSQL.crearCommand("SELECT re.regi_descripcion FROM DERROCHADORES_DE_PAPEL.Estadia AS e JOIN DERROCHADORES_DE_PAPEL.Reserva AS r ON e.esta_reserva = r.rese_codigo JOIN DERROCHADORES_DE_PAPEL.Regimen AS re ON re.regi_codigo = r.rese_regimen WHERE esta_id = @est");
            com3.Parameters.AddWithValue("@est", estadia.Text);
            String regimen = (String)com3.ExecuteScalar();
            if (!String.IsNullOrEmpty(regimen) && regimen == "All inclusive")
            {
                com3 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ItemDeFactura (item_cantidad, item_monto, item_factura, item_descripcion, item_consumible) VALUES (1, @monto, @fact, @desc, NULL)");
                com3.Parameters.AddWithValue("@monto", costoTotal);
                com3.Parameters.AddWithValue("@fact", factura);
                com3.Parameters.AddWithValue("@desc", "descuento por régimen de estadía");
                UtilesSQL.ejecutarComandoNonQuery(com3);
            }

            MessageBox.Show("Consumibles registrados!");
        }
    }
}
