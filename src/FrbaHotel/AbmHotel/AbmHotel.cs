using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class AbmHotel : Form
    {
        int id;
        DataTable dtHoteles = new DataTable();

        public AbmHotel(int idU)
        {
            UtilesSQL.inicializar();
            id = idU;
            InitializeComponent();
            comboBoxEstrellas.Items.Add("");
            for (int i = 0; i < 6; i++)
            {
                comboBoxEstrellas.Items.Add(i);
            }
            comboBoxEstrellas.SelectedIndex = 0;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AltaHotel(id);
            f1.ShowDialog();
            this.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            dtHoteles.Clear();
            textBoxCiudad.Clear();
            textBoxNombre.Clear();
            textBoxPais.Clear();
            comboBoxEstrellas.SelectedIndex = 0;
            buttonModificarHotel.Enabled = false;
            buttonBajaHotel.Enabled = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dtHoteles.Clear();
            string comString = "SELECT hote_id, hote_nombre, hote_estrellas, hote_pais, hote_ciudad FROM DERROCHADORES_DE_PAPEL.Hotel WHERE ";
            if (!String.IsNullOrEmpty(textBoxNombre.Text))
            {
                comString += "hote_nombre LIKE @nombre AND ";
            }
            if (!String.IsNullOrEmpty(textBoxPais.Text))
            {
                comString += "hote_pais LIKE @pais AND ";
            }
            if (!String.IsNullOrEmpty(textBoxCiudad.Text))
            {
                comString += "hote_ciudad LIKE @ciudad AND ";
            }
            if (comboBoxEstrellas.SelectedIndex != 0)
            {
                comString += "hote_estrellas = @est AND ";
            }
            comString += "1=1";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(comString);
            sda.SelectCommand.Parameters.AddWithValue("@nombre", "%" + textBoxNombre.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@pais", "%" + textBoxPais.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@ciudad", "%" + textBoxCiudad.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@est", comboBoxEstrellas.SelectedIndex - 1);
            sda.Fill(dtHoteles);
            dataGridViewHoteles.DataSource = dtHoteles;
            buttonModificarHotel.Enabled = true;
            buttonBajaHotel.Enabled = true;
        }

        private void buttonModificarHotel_Click(object sender, EventArgs e)
        {
            DataTable dtH = new DataTable();
            string commandString = "SELECT * FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = @id";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@id", dataGridViewHoteles.CurrentRow.Cells[0].Value);
            sda.Fill(dtH);
            this.Hide();
            Form f = new ModificarHotel(dtH);
            limpiarTodo();
            f.ShowDialog();
            this.Show();
        }

        private void buttonBajaHotel_Click(object sender, EventArgs e)
        {
            DataTable dtH = new DataTable();
            string commandString = "SELECT hote_id FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_id = @id";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@id", dataGridViewHoteles.CurrentRow.Cells[0].Value);
            sda.Fill(dtH);
            this.Hide();
            Form f = new BajaHotel(Int32.Parse(dtH.Rows[0][0].ToString()));
            limpiarTodo();
            f.ShowDialog();
            this.Show();
        }
    }
}
