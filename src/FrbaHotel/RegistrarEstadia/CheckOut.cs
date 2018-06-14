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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class CheckOut : Form
    {
        DataTable dtModos = new DataTable();
        DataTable dtC = new DataTable();
        DataTable dtF = new DataTable();
        String factId;
        float costoTotal;

        public CheckOut(String factura)
        {
            UtilesSQL.inicializar();
            factId = factura;
            InitializeComponent();
            tarjeta.Enabled = true;
            propietario.Enabled = true;

            costoTotal = 0;

            cargarCosas();
        }
        private void cargarCosas()
        {
            SqlCommand command = UtilesSQL.crearCommand("SELECT modo_descripcion FROM DERROCHADORES_DE_PAPEL.ModoDePago");
            SqlDataReader reader = command.ExecuteReader();
            dtModos.Columns.Add("modo_descripcion", typeof(string));
            dtModos.Load(reader);

            comboBoxFormaDePago.ValueMember = "modo_descripcion";
            comboBoxFormaDePago.DataSource = dtModos;
            comboBoxFormaDePago.SelectedIndex = 0;

            SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT item_descripcion, item_cantidad, item_monto, item_habitacionNumero, item_habitacionPiso FROM DERROCHADORES_DE_PAPEL.ItemDeFactura WHERE item_factura = @fact");
            sda.SelectCommand.Parameters.AddWithValue("@fact", factId);
            sda.Fill(dtC);
            dataGridViewConsumibles.DataSource = dtC;

            sda = UtilesSQL.crearDataAdapter("SELECT fact_fecha, fact_costoTotal, fact_estadia, fact_cliente FROM DERROCHADORES_DE_PAPEL.Factura WHERE fact_numero = @fact");
            sda.SelectCommand.Parameters.AddWithValue("@fact", factId);
            sda.Fill(dtF);

            textBoxFecha.Text = dtF.Rows[0][0].ToString();
            textBoxCostoTotal.Text = dtF.Rows[0][1].ToString();
            textBoxEstadia.Text = dtF.Rows[0][2].ToString();
            textBoxCliente.Text = dtF.Rows[0][3].ToString();

            //calculo de costo total de consumibles
            foreach (DataRow row in dtC.Rows)
            {
                if (row[0].ToString().Equals("1x Descuento por régimen All Inclusive"))
                {
                    costoTotal -= float.Parse(row[2].ToString());
                }
                else
                {
                    costoTotal += float.Parse(row[1].ToString()) * float.Parse(row[2].ToString());
                }

            }
            textBoxCostoTotal.Text = costoTotal.ToString();
        }

        private void comboBoxFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormaDePago.SelectedItem.ToString().Equals("TARJETA DE CREDITO"))
            {
                tarjeta.Enabled = true;
                propietario.Enabled = true;
            }
            else
            {
                propietario.Clear();
                propietario.Enabled = false;
                tarjeta.Clear();
                tarjeta.Enabled = false;
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que los datos son correctos?", "Finalizar factura?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            
            SqlCommand com = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Estadia SET esta_usuarioCheckOut = "+Login.SeleccionFuncionalidad.getUserId()+" WHERE esta_id = @est");
            com.Parameters.AddWithValue("@est", dtF.Rows[0][2].ToString());
            UtilesSQL.ejecutarComandoNonQuery(com);

            if (!comboBoxFormaDePago.SelectedItem.ToString().Equals("TARJETA DE CREDITO"))
            {
                resetearLabels();
                finalizarFactura();
            }
            else
            {
                if (validar())
                {
                    finalizarFacturaTarjeta();
                }
            }
        }
        private void finalizarFactura()
        {
            SqlCommand com = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Factura SET fact_costoTotal = @costo, fact_modoDePago = @modo WHERE fact_estadia = @est");
            com.Parameters.AddWithValue("@costo", costoTotal.ToString());
            com.Parameters.AddWithValue("@modo", comboBoxFormaDePago.SelectedIndex+1);
            com.Parameters.AddWithValue("@est", dtF.Rows[0][2].ToString());
            UtilesSQL.ejecutarComandoNonQuery(com);
        }
        private void finalizarFacturaTarjeta()
        {
            SqlCommand com = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.TarjetaBancaria VALUES (\'@nombre\', @numero)");
            com.Parameters.AddWithValue("@nombre", propietario.Text);
            com.Parameters.AddWithValue("@numero", tarjeta.Text);
            UtilesSQL.ejecutarComandoNonQuery(com);

            SqlCommand com2 = UtilesSQL.crearCommand("SELECT tarj_id FROM DERROCHADORES_DE_PAPEL.TarjetaBancaria WHERE \'@nombre\' = tarj_nombreDeEntidad AND @numero = tarj_numeroDeCuenta");
            com.Parameters.AddWithValue("@nombre", propietario.Text);
            com.Parameters.AddWithValue("@modo", tarjeta.Text);
            String tarjetaId = com2.ExecuteScalar().ToString();

            com = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Factura SET fact_costoTotal = @costo, fact_modoDePago = @modo, fact_tarjeta = @tarj WHERE fact_estadia = @est");
            com.Parameters.AddWithValue("@costo", costoTotal.ToString());
            com.Parameters.AddWithValue("@modo", comboBoxFormaDePago.SelectedIndex+1);
            com.Parameters.AddWithValue("@tarj", tarjetaId);
            com.Parameters.AddWithValue("@est", dtF.Rows[0][2].ToString());
            UtilesSQL.ejecutarComandoNonQuery(com);
        }

        private void resetearLabels()
        {
            labelNumeroVacio.Visible = false;
            labelTarjetaInvalida.Visible = false;
            labelNombreVacio.Visible = false;
            labelNombreInvalido.Visible = false;
        }
        private bool validar()
        {
            bool Valido = true;
            if (String.IsNullOrEmpty(tarjeta.Text))
            {
                labelNumeroVacio.Visible = true;
                Valido = false;
            }
            if (!tarjeta.Text.All(Char.IsDigit))
            {
                labelTarjetaInvalida.Visible = true;
                Valido = false;
            }
            if (String.IsNullOrEmpty(propietario.Text))
            {
                labelNombreVacio.Visible = true;
                Valido = false;
            }
            if (!propietario.Text.All(Char.IsLetter))
            {
                labelNombreInvalido.Visible = true;
                Valido = false;
            }
            return Valido;
        }
    }
}
