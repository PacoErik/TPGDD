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
    public partial class ElegirClientes : Form
    {
        public bool correcto = false;
        public DataTable distribucionClientes_dt;

        String cliente_id;
        String cliente_apellido;
        String cliente_nombre;
        String cliente_mail;
        String reserva;
        String hoteId;
        String fecha_desde;
        String fecha_hasta;
        int cantidad_personas;

        private DataTable clientes_dt;

        public ElegirClientes(String cliente_id, String cliente_apellido, String cliente_nombre, String cliente_mail, String reserva, int cantidad_personas, string idH, string fechaD, string fechaH)
        {
            correcto = false;

            this.cliente_id = cliente_id;
            this.cliente_apellido = cliente_apellido;
            this.cliente_nombre = cliente_nombre;
            this.cliente_mail = cliente_mail;
            this.reserva = reserva;
            this.cantidad_personas = cantidad_personas;
            this.hoteId = idH;
            this.fecha_desde = fechaD;
            this.fecha_hasta = fechaH;

            InitializeComponent();

            reservaElegida.Text = reserva;
            cantidadDePersonas.Text = cantidad_personas.ToString();
            responsable.Text = cliente_apellido + ", " + cliente_nombre;

            clientes_dt = new DataTable();
            clientes_dt.Columns.Add("Cliente");
            clientes_dt.Columns.Add("Apellido");
            clientes_dt.Columns.Add("Nombre");
            clientes_dt.Columns.Add("Mail");
            clientes_dt.Rows.Add(cliente_id, cliente_apellido, cliente_nombre, cliente_mail);
            clientes.DataSource = clientes_dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientes_dt.Rows.Count == cantidad_personas)
            {
                this.Hide();
                DistribuirClientes distribucion = new DistribuirClientes(clientes_dt, reserva);
                distribucion.ShowDialog();
                if (distribucion.esCorrecto())
                {
                    distribucionClientes_dt = distribucion.distribucionClientes().Copy();
                    correcto = true;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Falta agregar más personas");
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            correcto = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clientes_dt.Rows.Count < cantidad_personas)
            {
                this.Hide();
                ElegirCliente elegir = new ElegirCliente();
                elegir.ShowDialog();
                if (elegir.estaElegido())
                {
                    if (yaExisteCliente(elegir.id()))
                    {
                        MessageBox.Show("Ese cliente ya fue agregado previamente o forma parte de otra estadía en la misma fecha");
                    }
                    else
                    {
                        clientes_dt.Rows.Add(elegir.id(), elegir.apellido(), elegir.nombre(), elegir.mail());
                        buttonEliminar.Enabled = true;
                    }
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("No se pueden agregar más personas");
            }

        }

        public bool esCorrecto()
        {
            return correcto;
        }

        public DataTable getDistribucionClientes_dt()
        {
            return distribucionClientes_dt;
        }

        private bool yaExisteCliente(String idC)
        {
            DataTable dt = new DataTable();
            String desde = "CONVERT(datetime, \'" + DateTime.Parse(fecha_desde).ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            String hasta = "CONVERT(datetime, \'" + DateTime.Parse(fecha_hasta).ToString("yyyy-MM-dd HH:mm:ss.fff") + "\',121)";
            UtilesSQL.llenarTabla(dt, "SELECT * FROM DERROCHADORES_DE_PAPEL.Estadia JOIN DERROCHADORES_DE_PAPEL.EstadiaXCliente ON esxc_estadia = esta_id JOIN DERROCHADORES_DE_PAPEL.Reserva ON rese_codigo = esta_reserva WHERE esxc_cliente = " + idC + " AND esxc_hotel = " + hoteId + " AND esta_reserva = " + reserva + " AND ((rese_fin >= " + desde + " AND rese_fin <= " + hasta + ") OR (rese_inicio >= " + desde + " AND rese_inicio <= " + hasta + ") OR ( rese_inicio <=" + desde + " AND rese_fin >= " + hasta + "))");
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            foreach (DataRow cliente in clientes_dt.Rows)
            {
                if (cliente[0].ToString().Equals(idC))
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (clientes.CurrentRow.Cells[0].Value.ToString() == cliente_id)
            {
                MessageBox.Show("No se puede eliminar al cliente que creó la reserva");
                return;
            }
            clientes_dt.DefaultView[clientes.CurrentRow.Index].Delete();
            if (clientes_dt.Rows.Count <= 1)
            {
                buttonEliminar.Enabled = false;
            }
        }
    }
}
