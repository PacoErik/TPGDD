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

namespace FrbaHotel.AbmHabitacion
{
    public partial class ListadoHabitaciones : Form
    {
        int idH;
        DataTable dtT = new DataTable();
        DataTable dtHab = new DataTable();

        public ListadoHabitaciones(int hoteId)
        {
            idH = hoteId;
            UtilesSQL.inicializar();
            InitializeComponent();
            iniciarComboBox();
        }
        private void iniciarComboBox()
        {
            comboBoxTipoHabitacion.Items.Add("");
            SqlCommand command = UtilesSQL.crearCommand("SELECT tipo_descripcion FROM DERROCHADORES_DE_PAPEL.TipoDeHabitacion");
            SqlDataReader reader = command.ExecuteReader();
            dtT.Columns.Add("docu_detalle", typeof(string));
            dtT.Load(reader);
            dtT.Rows.Add("", "");

            comboBoxTipoHabitacion.ValueMember = "tipo_descripcion";
            comboBoxTipoHabitacion.DisplayMember = "tipo_descripcion";
            comboBoxTipoHabitacion.DataSource = dtT;
            comboBoxTipoHabitacion.SelectedIndex = 5;

            comboBoxUbicacion.Items.Add("");
            comboBoxUbicacion.Items.Add("Vista interna");
            comboBoxUbicacion.Items.Add("Vista al exterior");
            comboBoxUbicacion.SelectedIndex = 0;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void alta_Click(object sender, EventArgs e)
        {
            dtHab.Clear();
            this.Hide();
            AltaHabitacion f1 = new AltaHabitacion(idH);
            f1.ShowDialog();
            this.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int res;
            dtHab.Clear();
            string commandString = "SELECT h.habi_numero, h.habi_piso, habi_frente, ta.tipo_descripcion, h.habi_descripcion, h.habi_estado FROM DERROCHADORES_DE_PAPEL.TipoDeHabitacion AS ta JOIN DERROCHADORES_DE_PAPEL.Habitacion AS h ON h.habi_tipo = ta.tipo_codigo JOIN DERROCHADORES_DE_PAPEL.Hotel AS ho ON ho.hote_id = h.habi_hotel WHERE ";
            if (int.TryParse(textBoxNumero.Text, out res))
            {
                commandString += "h.habi_numero = @num AND ";
            }
            if (int.TryParse(textBoxPiso.Text, out res))
            {
                commandString += "h.habi_piso = @piso AND ";
            }
            if (comboBoxUbicacion.SelectedIndex != 0)
            {
                commandString += "habi_frente = @frente AND ";
            }
            if (comboBoxTipoHabitacion.SelectedIndex != 5)
            {
                commandString += "ta.tipo_descripcion = @desc AND ";
            }
            if (!String.IsNullOrEmpty(richTextBoxDesc.Text))
            {
                commandString += "h.habi_descripcion LIKE @habiDesc AND ";
            }
            commandString += "ho.hote_id = @hote";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@num", textBoxNumero.Text);
            sda.SelectCommand.Parameters.AddWithValue("@piso", textBoxPiso.Text);
            sda.SelectCommand.Parameters.AddWithValue("@frente", comboBoxUbicacion.SelectedIndex);
            sda.SelectCommand.Parameters.AddWithValue("@desc", comboBoxTipoHabitacion.SelectedValue.ToString());
            sda.SelectCommand.Parameters.AddWithValue("@habiDesc", "%" + richTextBoxDesc.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@hote", idH);
            sda.Fill(dtHab);
            dataGridViewHabitaciones.DataSource = dtHab;
            modificacion.Enabled = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dtHab.Clear();
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            comboBoxTipoHabitacion.SelectedIndex = 5;
            comboBoxUbicacion.SelectedIndex = 0;
            textBoxNumero.Text = null;
            textBoxPiso.Text = null;
            richTextBoxDesc.Text = null;
            modificacion.Enabled = false;
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda2 = UtilesSQL.crearDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion AS h JOIN DERROCHADORES_DE_PAPEL.TipoDeHabitacion AS ta ON h.habi_tipo = ta.tipo_codigo WHERE h.habi_numero = @num AND h.habi_hotel = @hotel");
            sda2.SelectCommand.Parameters.AddWithValue("@num", dataGridViewHabitaciones.CurrentRow.Cells[0].Value);
            sda2.SelectCommand.Parameters.AddWithValue("@hotel", idH);
            sda2.Fill(dt);
            this.Hide();
            Form f = new ModificarHabitacion(dt);
            limpiarTodo();
            f.ShowDialog();
            this.Show();
        }
    }
}
