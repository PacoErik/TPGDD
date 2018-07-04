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

            sda = UtilesSQL.crearDataAdapter("SELECT fact_fecha, fact_costoTotal, fact_estadia, fact_cliente, clie_apellido, clie_nombre FROM DERROCHADORES_DE_PAPEL.Factura JOIN DERROCHADORES_DE_PAPEL.Cliente ON clie_id = fact_cliente WHERE fact_numero = @fact");
            sda.SelectCommand.Parameters.AddWithValue("@fact", factId);
            sda.Fill(dtF);

            textBoxFecha.Text = dtF.Rows[0][0].ToString();
            textBoxCostoTotal.Text = dtF.Rows[0][1].ToString()+"U$S";
            textBoxEstadia.Text = dtF.Rows[0][2].ToString();
            textBoxCliente.Text = dtF.Rows[0][4].ToString() + ", " + dtF.Rows[0][5].ToString();

            //calculo de costo total de consumibles
            foreach (DataRow row in dtC.Rows)
            {
                if (row[0].ToString().Equals("1x Descuento por régimen All Inclusive"))
                {
                    costoTotal -= float.Parse(row[2].ToString());
                }
                else
                {
                    costoTotal += float.Parse(row[2].ToString());
                }

            }
            textBoxCostoTotal.Text = costoTotal.ToString()+"U$S";
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

            if (!comboBoxFormaDePago.Text.Equals("TARJETA DE CREDITO"))
            {
                resetearLabels();
                finalizarFactura();
                MessageBox.Show("Check out completado!");
                this.Close();
            }
            else
            {
                if (validar())
                {
                    finalizarFacturaTarjeta();
                    MessageBox.Show("Check out completado!");
                    this.Close();
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
            SqlCommand com = UtilesSQL.crearCommand("INSERT INTO DERROCHADORES_DE_PAPEL.TarjetaBancaria VALUES (@nombre, @numero)");
            com.Parameters.AddWithValue("@nombre", propietario.Text);
            com.Parameters.AddWithValue("@numero", tarjeta.Text);
            UtilesSQL.ejecutarComandoNonQuery(com);

            SqlCommand com2 = UtilesSQL.crearCommand("SELECT tarj_id FROM DERROCHADORES_DE_PAPEL.TarjetaBancaria WHERE @nombre = tarj_nombreDeEntidad AND @numero = tarj_numeroDeCuenta");
            com2.Parameters.AddWithValue("@nombre", propietario.Text);
            com2.Parameters.AddWithValue("@numero", tarjeta.Text);
            String tarjetaId = com2.ExecuteScalar().ToString();

            SqlCommand com3 = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Factura SET fact_costoTotal = @costo, fact_modoDePago = @modo, fact_tarjeta = @tarj WHERE fact_estadia = @est");
            com3.Parameters.AddWithValue("@costo", costoTotal.ToString());
            com3.Parameters.AddWithValue("@modo", comboBoxFormaDePago.SelectedIndex+1);
            com3.Parameters.AddWithValue("@tarj", tarjetaId);
            com3.Parameters.AddWithValue("@est", dtF.Rows[0][2].ToString());
            UtilesSQL.ejecutarComandoNonQuery(com3);
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
            if (!propietario.Text.All(l => Char.IsLetter(l) || Char.IsWhiteSpace(l)))
            {
                labelNombreInvalido.Visible = true;
                Valido = false;
            }
            return Valido;
        }

        private void comboBoxFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormaDePago.Text == "TARJETA DE CREDITO")
            {
                tarjeta.ReadOnly = false;
                propietario.ReadOnly = false;
            }
            else
            {
                tarjeta.Clear();
                tarjeta.ReadOnly = true;
                propietario.Clear();
                propietario.ReadOnly = true;
            }
        }
    }
}
