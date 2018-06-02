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

namespace FrbaHotel.AbmCliente
{
    public partial class AbmCliente : Form
    {
        private SqlCommand command;
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        string commandString;
        

        public AbmCliente()
        {
            InitializeComponent();
        }

        private void AbmCliente_Load(object sender, EventArgs e)
        {
            cargarTipoDocumento();
        }

        private void crearCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AltaCliente();
            f1.ShowDialog();
            this.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            commandString = "SELECT c.clie_nombre, c.clie_apellido, c.clie_mail, c.clie_numeroDeDocumento, d.docu_detalle FROM DERROCHADORES_DE_PAPEL.Cliente AS c JOIN DERROCHADORES_DE_PAPEL.Documento AS d ON c.clie_tipoDeDocumento = d.docu_tipo WHERE ";
            if (!String.IsNullOrEmpty(textBoxNombre.Text)) { commandString += "c.clie_nombre = '" + textBoxNombre.Text + "' and "; }
            if (!String.IsNullOrEmpty(textBoxApellido.Text)) { commandString += "c.clie_apellido = '" + textBoxApellido.Text + "' and "; }
            if (!String.IsNullOrEmpty(textBoxEmail.Text)) { commandString += "c.clie_mail = '" + textBoxEmail.Text + "' and "; }
            if (!String.IsNullOrEmpty(textBoxNumeroIdentificacion.Text)) { commandString += "c.clie_numeroDeDocumento = '" + textBoxNumeroIdentificacion.Text + "' and "; }
            if (comboBoxTipoDocumento.SelectedValue.ToString() == "")
                { commandString += "c.clie_tipoDeDocumento = d.docu_tipo"; }
                else{ commandString += "d.docu_detalle = '" + comboBoxTipoDocumento.SelectedValue.ToString() + "'"; }

            SqlDataAdapter sda = new SqlDataAdapter(commandString, con);
            sda.Fill(dt2);
            dataGridViewClientes.DataSource = dt2;
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void darDeBaja_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxEmail.Clear();
            textBoxNumeroIdentificacion.Clear();
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Rows.Clear();
            dt2.Clear();
            comboBoxTipoDocumento.SelectedIndex = 0;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTipoDocumento()
        {
            con.Open();
            command = new SqlCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento", con);
            SqlDataReader reader;

            reader = command.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("docu_detalle", typeof(string));
            dt.Rows.Add("");
            dt.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dt;

            con.Close();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
