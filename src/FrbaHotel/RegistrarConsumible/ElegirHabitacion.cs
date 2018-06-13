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
    public partial class ElegirHabitacion : Form
    {
        DataTable habitaciones_dt;

        public ElegirHabitacion()
        {
            InitializeComponent();
            habitaciones_dt = new DataTable();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            habitaciones_dt = new DataTable();
            UtilesSQL.llenarTabla(habitaciones_dt, "SELECT habi_numero Habitación, habi_piso Piso FROM DERROCHADORES_DE_PAPEL.Habitacion WHERE habi_hotel = " + Login.SeleccionFuncionalidad.getHotelId() + " AND STR(habi_numero) LIKE \'%" + numero.Text + "%\' AND STR(habi_piso) LIKE \'%" + piso.Text + "%\'");
            habitaciones.DataSource = habitaciones_dt;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (habitaciones.Rows.Count > 0)
            {
                String numeroHabitacion = habitaciones.CurrentRow.Cells[0].Value.ToString();
                String numeroPiso = habitaciones.CurrentRow.Cells[1].Value.ToString();
                String estadia = obtenerEstadia(numeroHabitacion, numeroPiso);
                if (estadia == null)
                {
                    MessageBox.Show("No se encontró una estadía activa para esta habitación");
                    return;
                }
                this.Hide();
                new RegistrarConsumible(numeroHabitacion, numeroPiso, estadia).ShowDialog();
                this.Show();
            }
        }

        private String obtenerEstadia(String numeroDeHabitacion, String pisoDeHabitacion)
        {
            DataTable estadia_dt = new DataTable();
            String hotel = Login.SeleccionFuncionalidad.getHotelId();
            String fecha = Main.fecha();
            UtilesSQL.llenarTabla(estadia_dt, "SELECT esta_id FROM DERROCHADORES_DE_PAPEL.Estadia JOIN DERROCHADORES_DE_PAPEL.Reserva ON rese_codigo = esta_reserva JOIN DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON rexh_reserva = rese_codigo AND rexh_hotel = " + hotel + " AND rexh_numero = " + numeroDeHabitacion + " AND rexh_piso = " + pisoDeHabitacion + " WHERE rese_estado = 6 AND CONVERT(datetime,\'"+fecha+"\') BETWEEN rese_inicio AND rese_fin");

            if (estadia_dt.Rows.Count == 0)
            {
                return null;
            }

            return estadia_dt.Rows[0][0].ToString();
        }
    }
}
