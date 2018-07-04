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
    public partial class ElegirHabitacion : Form
    {
        DataTable habitaciones_dt;
        String factura;
        String estadia;

        public ElegirHabitacion(String factura, DataTable habitacionesDisponibles)
        {
            this.factura = factura;

            InitializeComponent();
            habitaciones_dt = habitacionesDisponibles.Copy();
            estadia = habitaciones_dt.Rows[0][2].ToString();
            habitaciones_dt.Columns.RemoveAt(2);

            habitaciones.DataSource = habitaciones_dt;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que quiere terminar la carga de consumibles?", "Finalizar carga", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //En caso de ser un régimen "All inclusive" hay que netear los costos de los consumibles 
                SqlCommand com3 = UtilesSQL.crearCommand("SELECT re.regi_descripcion FROM DERROCHADORES_DE_PAPEL.Estadia AS e JOIN DERROCHADORES_DE_PAPEL.Reserva AS r ON e.esta_reserva = r.rese_codigo JOIN DERROCHADORES_DE_PAPEL.Regimen AS re ON re.regi_codigo = r.rese_regimen WHERE esta_id = @est");
                com3.Parameters.AddWithValue("@est", estadia);
                object regimen = com3.ExecuteScalar();
                if (regimen != null)
                {
                    if (regimen.ToString().Equals("All inclusive") || regimen.ToString().Equals("All Inclusive moderado"))
                    {
                        //Creamos el item de factura con el descuento
                        UtilesSQL.ejecutarComandoNonQuery("INSERT INTO DERROCHADORES_DE_PAPEL.ItemDeFactura (item_cantidad, item_monto, item_factura, item_descripcion, item_consumible, item_habitacionNumero, item_habitacionPiso) "
                                                                + "SELECT 1, SUM(item_monto), item_factura, '1x Descuento por régimen All Inclusive', NULL, MAX(item_habitacionNumero), MAX(item_habitacionPiso) "
                                                                + "FROM DERROCHADORES_DE_PAPEL.ItemDeFactura "
                                                                + "WHERE item_factura = " + factura + " AND item_consumible IS NOT NULL "
                                                                + "GROUP BY item_factura");
                    }

                }
                this.Close();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (habitaciones.Rows.Count > 0)
            {
                String numeroHabitacion = habitaciones.CurrentRow.Cells[0].Value.ToString();
                String numeroPiso = habitaciones.CurrentRow.Cells[1].Value.ToString();
                this.Hide();
                new RegistrarConsumible(numeroHabitacion, numeroPiso, estadia, factura).ShowDialog();
                this.Show();
            }
        }
    }
}
