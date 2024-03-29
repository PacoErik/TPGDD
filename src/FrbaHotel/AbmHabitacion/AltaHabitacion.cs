﻿using System;
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
    public partial class AltaHabitacion : Form
    {
        bool Valido;
        DataTable dtT = new DataTable();
        int idH;

        public AltaHabitacion(int id)
        {
            UtilesSQL.inicializar();
            idH = id;
            InitializeComponent();
            iniciarComboBox();
            richTextBoxDesc.MaxLength = 50;
        }
        private void iniciarComboBox()
        {
            comboBoxTipoHabitacion.Items.Add("");
            SqlCommand command = UtilesSQL.crearCommand("SELECT tipo_descripcion, tipo_codigo FROM DERROCHADORES_DE_PAPEL.TipoDeHabitacion");
            SqlDataReader reader = command.ExecuteReader();
            dtT.Columns.Add("docu_detalle", typeof(string));
            dtT.Load(reader);

            comboBoxTipoHabitacion.ValueMember = "tipo_codigo";
            comboBoxTipoHabitacion.DisplayMember = "tipo_descripcion";
            comboBoxTipoHabitacion.DataSource = dtT;
            comboBoxTipoHabitacion.SelectedIndex = 0;

            comboBoxUbicacion.Items.Add("Vista interna");
            comboBoxUbicacion.Items.Add("Vista al exterior");
            comboBoxUbicacion.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
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
            SqlCommand com = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.Habitacion VALUES (@hote, @num, @piso, @frente, @desc, @tipo, @hab)");
            com.Parameters.AddWithValue("@hote", idH);
            com.Parameters.AddWithValue("@num", textBoxNumero.Text);
            com.Parameters.AddWithValue("@piso", textBoxPiso.Text);
            com.Parameters.AddWithValue("@frente", comboBoxUbicacion.SelectedIndex);
            com.Parameters.AddWithValue("@desc", richTextBoxDesc.Text);
            com.Parameters.AddWithValue("@tipo", comboBoxTipoHabitacion.SelectedValue.ToString());
            com.Parameters.AddWithValue("@hab", checkBoxHabilitada.Checked);
            UtilesSQL.ejecutarComandoNonQuery(com);

            MessageBox.Show("Creación exitosa!");
        }

        private void resetearLabels()
        {
            labelNumeroInvalido.Visible = false;
            labelNumeroInvalido2.Visible = false;
            labelPisoInvalido.Visible = false;
        }
        private void checkearDatos()
        {
            Valido = true;
            if (!(textBoxPiso.Text.All(Char.IsDigit)) || String.IsNullOrEmpty(textBoxPiso.Text))
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
                sda.SelectCommand.Parameters.AddWithValue("@hote", idH);
                sda.SelectCommand.Parameters.AddWithValue("@num", textBoxNumero.Text);
                sda.Fill(dt);
                if (dt.Rows.Count != 0) //No hay otra habitacion con el mismo número
                {
                    labelNumeroInvalido2.Visible = true;
                    Valido = false;
                }
            }
        }
    }
}
