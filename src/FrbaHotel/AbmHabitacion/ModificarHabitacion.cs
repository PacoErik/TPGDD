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
    public partial class ModificarHabitacion : Form
    {
        DataTable dtH = new DataTable();
        bool Valido;

        public ModificarHabitacion(DataTable dt)
        {
            UtilesSQL.inicializar();
            dtH = dt;
            InitializeComponent();
            richTextBoxDesc.MaxLength = 50;
            checkBoxHabilitada.Checked = Convert.ToBoolean(dtH.Rows[0][6]);

            comboBoxUbicacion.Items.Add("Vista interna");
            comboBoxUbicacion.Items.Add("Vista al exterior");
            comboBoxUbicacion.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que los datos son correctos?", "Esta seguro?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                resetearLabels();
                checkearDatos();
                if (Valido)
                {
                    realizarCambios();
                    this.Close();
                }
            }
        }
        private void realizarCambios()
        {
            SqlCommand com = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Habitacion SET habi_estado = @hab, habi_numero = @num, habi_piso = @piso, habi_frente = @ubicacion, habi_descripcion = @desc WHERE habi_hotel = @hote AND habi_numero = @numO AND habi_piso = @pisoO");
            com.Parameters.AddWithValue("@hote", dtH.Rows[0][0]);
            com.Parameters.AddWithValue("@num", textBoxNumero.Text);
            com.Parameters.AddWithValue("@numO", dtH.Rows[0][1]);
            com.Parameters.AddWithValue("@piso", textBoxPiso.Text);
            com.Parameters.AddWithValue("@pisoO", dtH.Rows[0][2]);
            com.Parameters.AddWithValue("@ubicacion", comboBoxUbicacion.SelectedIndex);
            com.Parameters.AddWithValue("@desc", richTextBoxDesc.Text);
            com.Parameters.AddWithValue("@hab", checkBoxHabilitada.Checked);
            UtilesSQL.ejecutarComandoNonQuery(com);
           
            MessageBox.Show("Modificación exitosa!");
        }

        private void checkearDatos()
        {
            Valido = true;
            if(!(textBoxPiso.Text.All(Char.IsDigit)) || String.IsNullOrEmpty(textBoxPiso.Text))
            {
                labelPisoInvalido.Visible = true;
                Valido = false;
            }
            if (!(textBoxNumero.Text.All(Char.IsDigit)) || String.IsNullOrEmpty(textBoxNumero.Text))
            {
                labelNumeroInvalido.Visible = true;
                Valido = false;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Habitacion WHERE habi_hotel = @hote AND habi_numero = @num");
                sda.SelectCommand.Parameters.AddWithValue("@hote", dtH.Rows[0][0]);
                sda.SelectCommand.Parameters.AddWithValue("@num", dtH.Rows[0][1]);
                sda.Fill(dt);
                if (dt.Rows.Count != 0) //No hay otra habitacion con el mismo número
                {
                    labelNumeroInvalido2.Visible = true;
                    Valido = false;
                }
            }
        }
        private void resetearLabels()
        {
            labelNumeroInvalido.Visible = false;
            labelPisoInvalido.Visible = false;
            labelNumeroInvalido2.Visible = false;
        }
    }
}
