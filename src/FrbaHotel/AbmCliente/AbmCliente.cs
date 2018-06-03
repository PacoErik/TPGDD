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
        int index;
        private SqlCommand command;
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtM = new DataTable();
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
            limpiarTodo();
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
            if (comboBoxTipoDocumento.SelectedValue.ToString() != "") { commandString += "d.docu_detalle = '" + comboBoxTipoDocumento.SelectedValue.ToString() + "' and "; }
            commandString += "c.clie_habilitado = 1";

            SqlDataAdapter sda = new SqlDataAdapter(commandString, con);
            sda.Fill(dt2);
            dataGridViewClientes.DataSource = dt2;
            buttonModificarCliente.Enabled = true;
            buttonDarDeBaja.Enabled = true;
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            index = dataGridViewClientes.CurrentCell.RowIndex;
            commandString = "SELECT clie_nacionalidad, clie_nombre, clie_apellido, clie_mail, clie_telefono, clie_fechaDeNacimiento, clie_calle, clie_numeroDeCalle, clie_piso, clie_departamento, clie_localidad, clie_tipoDeDocumento, clie_numeroDeDocumento, clie_id FROM DERROCHADORES_DE_PAPEL.Cliente WHERE clie_mail = '" + dt2.Rows[index][2].ToString() + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(commandString, con);
            sda2.Fill(dtM);
            this.Hide();
            Form f1 = new ModificarCliente(this, dtM);
            limpiarTodo();
            f1.Show();
        }

        private void darDeBaja_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que quiere dar de baja el cliente?", "Esta seguro?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                index = dataGridViewClientes.CurrentCell.RowIndex;
                con.Open();
                command = new SqlCommand("UPDATE DERROCHADORES_DE_PAPEL.Cliente set clie_habilitado = 0 WHERE clie_mail = '" + dt2.Rows[index][2].ToString() + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El usuario ha sido dado de baja");
                limpiarTodo();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void limpiarTodo()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxEmail.Clear();
            textBoxNumeroIdentificacion.Clear();
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Rows.Clear();
            dt2.Clear();
            comboBoxTipoDocumento.SelectedIndex = 0;
            buttonModificarCliente.Enabled = false;
            buttonDarDeBaja.Enabled = false;
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
