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

namespace FrbaHotel.AbmHotel
{
    public partial class BajaHotel : Form
    {
        int idH;

        public BajaHotel(int hoteId)
        {
            UtilesSQL.inicializar();
            idH = hoteId;
            InitializeComponent();
            richTextBoxMotivo.MaxLength = 255;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            textBoxFecha.Text = seleccionarFecha();
        }
        private void buttonFecha2_Click(object sender, EventArgs e)
        {
            textBoxFecha2.Text = seleccionarFecha();
        }
        private string seleccionarFecha()
        {
            SeleccionarFecha f1 = new SeleccionarFecha();
            f1.ShowDialog();
            return f1.fecha;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (fechaValida(textBoxFecha.Text) && fechaValida2(textBoxFecha2.Text))
            {
                SqlCommand com = UtilesSQL.crearCommand("DERROCHADORES_DE_PAPEL.CrearBajaHotel");
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@hotel", SqlDbType.BigInt).Value = idH;
                com.Parameters.AddWithValue("@fechaI", SqlDbType.DateTime).Value = textBoxFecha.Text;
                com.Parameters.AddWithValue("@fechaF", SqlDbType.DateTime).Value = textBoxFecha2.Text;
                com.Parameters.AddWithValue("@motivo", SqlDbType.NVarChar).Value = richTextBoxMotivo.Text;
                int resultado = (int)com.ExecuteScalar();

                if (resultado == 1)
                {
                    MessageBox.Show("Baja exitosa!");
                    this.Close();
                }
                else { MessageBox.Show("Este hotel tiene resservas o huespedes en esas fechas por lo que no se pudo realizar la baja"); }
            }
        }
        private bool dateTimeValido(string date)
        {
            try
            {
                DateTime dateTime = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool fechaValida(string fecha)
        {
            if (!(dateTimeValido(fecha)))
            {
                labelFechaInvalida.Visible = true;
                return false;
            }
            return true;
        }
        private bool fechaValida2(string fecha)
        {
            if (!(dateTimeValido(fecha)))
            {
                labelFechaInvalida2.Visible = true;
                return false;
            }
            return true;
        }


    }
}
