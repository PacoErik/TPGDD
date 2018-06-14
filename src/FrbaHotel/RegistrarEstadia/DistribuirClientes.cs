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
    public partial class DistribuirClientes : Form
    {
        public bool correcto = false;
        private DataTable clientes_dt;
        public DataTable distribucion_dt;
        private DataTable habitaciones_dt;

        private String reserva;

        public DistribuirClientes(DataTable clientes_disponibles, String reserva)
        {
            this.reserva = reserva;

            clientes_dt = clientes_disponibles.Copy();
            clientes_dt.Columns.Remove("Mail");

            InitializeComponent();

            clientes.DataSource = clientes_dt;

            distribucion_dt = new DataTable();
            distribucion_dt.Columns.Add("Cliente");
            distribucion_dt.Columns.Add("Apellido");
            distribucion_dt.Columns.Add("Nombre");
            distribucion_dt.Columns.Add("Habitación");
            distribucion_dt.Columns.Add("Piso");
            distribucion.DataSource = distribucion_dt;

            habitaciones_dt = new DataTable();
            UtilesSQL.llenarTabla(habitaciones_dt, "SELECT rexh_numero Número, rexh_piso Piso, tipo_cantidadDePersonas Cantidad FROM DERROCHADORES_DE_PAPEL.ReservaXHabitacion JOIN DERROCHADORES_DE_PAPEL.Habitacion ON rexh_hotel = habi_hotel AND rexh_numero = habi_numero AND rexh_piso = habi_piso JOIN DERROCHADORES_DE_PAPEL.TipoDeHabitacion ON tipo_codigo = habi_tipo WHERE rexh_reserva = "+reserva+" AND rexh_hotel = "+Login.SeleccionFuncionalidad.getHotelId());

            foreach (DataRow hab in habitaciones_dt.Rows)
            {
                habitaciones.Items.Add("Número: " + hab[0].ToString() + " - Piso: " + hab[1].ToString());
            }
            habitaciones.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            correcto = false;
            this.Close();
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            if (clientes.Rows.Count == 0)
            {
                correcto = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Todavía no fueron asignados todos los clientes");
            }
        }

        public bool esCorrecto()
        {
            return correcto;
        }

        public DataTable distribucionClientes()
        {
            return distribucion_dt;
        }

        private void asignar_Click(object sender, EventArgs e)
        {
            DataRow habitacion = habitaciones_dt.Rows[habitaciones.SelectedIndex];

            if (habitacionLlena(habitacion))
            {
                MessageBox.Show("Ya no pueden ingresar más personas a esta habitación");
                return;
            }

            if (clientes.CurrentRow != null)
            {
                DataRow cliente = ((DataRowView)clientes.CurrentRow.DataBoundItem).Row;
                distribucion_dt.Rows.Add(cliente[0].ToString(), cliente[1].ToString(), cliente[2].ToString(), habitacion[0].ToString(), habitacion[1].ToString());
                clientes_dt.Rows.Remove(cliente);
            }

        }

        private bool habitacionLlena(DataRow habitacion)
        {
            int cantidad = 0;
            foreach (DataRow habOcupada in distribucion_dt.Rows)
            {
                if (habOcupada[0].ToString().Equals(habitacion[0].ToString()) && habOcupada[1].ToString().Equals(habitacion[1].ToString()))
                {
                    cantidad++;
                }
            }
 
            return cantidad.ToString().Equals(habitacion[2].ToString());
        }
    }
}
