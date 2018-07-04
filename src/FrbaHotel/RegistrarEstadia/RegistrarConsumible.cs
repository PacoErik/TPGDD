using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class RegistrarConsumible : Form
    {
        DataTable consumibles_dt;
        DataTable consumibles_elegidos_dt;

        String factura;

        public RegistrarConsumible(String numeroDeHabitacion, String pisoDeHabitacion, String estadiaElegida, String factura)
        {
            this.factura = factura;

            InitializeComponent();

            habitacion.Text = numeroDeHabitacion;
            piso.Text = pisoDeHabitacion;
            estadia.Text = estadiaElegida;

            consumibles_dt = new DataTable();
            UtilesSQL.llenarTabla(consumibles_dt, "SELECT cons_codigo, cons_detalle, cons_precio "
                                                 + "FROM DERROCHADORES_DE_PAPEL.Consumible");
            disponibles.DataSource = consumibles_dt;

            consumibles_elegidos_dt = new DataTable();
            consumibles_elegidos_dt.Columns.Add("cons_codigo");
            consumibles_elegidos_dt.Columns.Add("cons_detalle");
            consumibles_elegidos_dt.Columns.Add("cons_precio");
            consumibles_elegidos_dt.Columns.Add("item_cantidad");
            elegidos.DataSource = consumibles_elegidos_dt;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarConsumible_Click(object sender, EventArgs e)
        {
            if (disponibles.CurrentRow == null)
                return;
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
            if (elegidos.CurrentRow != null)
            {
                DataRow consumible = ((DataRowView)elegidos.Rows[elegidos.CurrentCell.RowIndex].DataBoundItem).Row;
                consumibles_dt.Rows.Add(consumible["cons_codigo"].ToString(), consumible["cons_detalle"].ToString(), consumible["cons_precio"].ToString());
                consumibles_elegidos_dt.Rows.Remove(consumible);
            }
        }
        
        private void guardar_Click(object sender, EventArgs e)
        {
            //Validar que se hayan elegido consumibles
            if (consumibles_elegidos_dt.Rows.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos un consumible");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro que desea registrar estos consumibles?", "¿Registrar consumibles?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            //Validar que no se hayan registrado consumibles para la habitación elegida
            SqlCommand com = UtilesSQL.crearCommand("SELECT item_id FROM DERROCHADORES_DE_PAPEL.ItemDeFactura WHERE item_factura = @factura AND item_habitacionNumero = @hab AND item_habitacionPiso = @piso AND item_consumible IS NOT NULL");
            com.Parameters.AddWithValue("@factura", factura);
            com.Parameters.AddWithValue("@hab", habitacion.Text);
            com.Parameters.AddWithValue("@piso", piso.Text);
            object itemPrevio = com.ExecuteScalar();
            if (itemPrevio != null)
            {
                MessageBox.Show("Ya se agregaron items previamente para la habitación elegida");
                return;
            }

            //Agregar cada item correspondiente a los consumibles adquiridos
            float costoTotal = 0;
            foreach (DataRow consumible in consumibles_elegidos_dt.Rows)
            {
                String costo = consumible[2].ToString();
                costo.Replace(',', '.'); //Se reemplaza la coma por un punto para su correcta conversión
                String cantidad = consumible[3].ToString();

                float costoConsumible = float.Parse(costo) * float.Parse(cantidad);
                costoTotal += costoConsumible;

                SqlCommand com2 = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.ItemDeFactura (item_cantidad, item_monto, item_factura, item_descripcion, item_consumible, item_habitacionNumero, item_habitacionPiso) VALUES (@cant, CONVERT(NUMERIC(18,2),@monto), @fact, LTRIM(STR(@cant))+\'x \'+@desc, @cons, @hab, @piso)");
                com2.Parameters.AddWithValue("@cant", consumible[3].ToString());
                com2.Parameters.AddWithValue("@monto", costoConsumible.ToString());
                com2.Parameters.AddWithValue("@fact", factura);
                com2.Parameters.AddWithValue("@desc", consumible[1].ToString());
                com2.Parameters.AddWithValue("@cons", consumible[0].ToString());
                com2.Parameters.AddWithValue("@hab", habitacion.Text);
                com2.Parameters.AddWithValue("@piso", piso.Text);
                UtilesSQL.ejecutarComandoNonQuery(com2);
            }

            MessageBox.Show("Consumibles registrados!");
            this.Close();
        }
    }
}
