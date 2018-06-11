using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            foreach (DataRow consumible in consumibles_elegidos_dt.Rows)
            {

            }
        }

        private void estadia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reiniciarHabitaciones();
                //Validar que el texto de la estadía represente un número
                int estadia_n;
                if (!Int32.TryParse(estadia.Text, out estadia_n))
                {
                    MessageBox.Show("Debe ingresar un número correcto de estadía");
                    return;
                }
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
                    return;
                }
                estadia_elegida = estadia.Text;
                for (int indice = 0; indice < habitaciones_dt.Rows.Count; indice++)
                {
                    habitaciones.Items.Add("Número: " + habitaciones_dt.Rows[indice]["habi_numero"] + " - Piso: " + habitaciones_dt.Rows[indice]["habi_piso"]);
                }

                MessageBox.Show("Elija la habitación para la cual se realizará la compra");
            }
        }

        private void disponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int cantidad;
                RecibirEntrada:
                String resultado = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántas unidades del producto va a agregar?", "Cantidad de consumibles", "1");
                if (resultado.Equals("")) {
                    return;
                }
                if (!Int32.TryParse(resultado, out cantidad))
                {
                    goto RecibirEntrada;
                }

                DataRow consumible = ((DataRowView)disponibles.Rows[e.RowIndex].DataBoundItem).Row;
                consumibles_elegidos_dt.Rows.Add(consumible["cons_codigo"].ToString(), consumible["cons_detalle"].ToString(), consumible["cons_precio"].ToString(), cantidad.ToString());
                consumibles_dt.Rows.Remove(consumible);
            }
        }

        private void elegidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow consumible = ((DataRowView)elegidos.Rows[e.RowIndex].DataBoundItem).Row;
                consumibles_dt.Rows.Add(consumible["cons_codigo"].ToString(), consumible["cons_detalle"].ToString(), consumible["cons_precio"].ToString());
                consumibles_elegidos_dt.Rows.Remove(consumible);
            }
        }
    }
}
