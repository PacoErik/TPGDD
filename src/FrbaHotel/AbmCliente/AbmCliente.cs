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
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtM = new DataTable();
        string commandString;
        Form f;
        

        public AbmCliente()
        {
            UtilesSQL.inicializar();
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
            f = new AltaCliente();
            f.ShowDialog();
            this.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            buttonModificarCliente.Enabled = false;
            dt2.Clear();
            commandString = "SELECT c.clie_nombre, c.clie_apellido, c.clie_mail, c.clie_numeroDeDocumento, d.docu_detalle, c.clie_habilitado FROM DERROCHADORES_DE_PAPEL.Cliente AS c JOIN DERROCHADORES_DE_PAPEL.Documento AS d ON c.clie_tipoDeDocumento = d.docu_tipo WHERE ";
            if (!String.IsNullOrEmpty(textBoxNombre.Text)) 
            { 
                commandString += "c.clie_nombre LIKE @nom and ";
            }
            if (!String.IsNullOrEmpty(textBoxApellido.Text)) 
            { 
                commandString += "c.clie_apellido LIKE @ape and ";
            }
            if (!String.IsNullOrEmpty(textBoxEmail.Text)) 
            { 
                commandString += "c.clie_mail LIKE @mail and ";
            }
            if (!String.IsNullOrEmpty(textBoxNumeroIdentificacion.Text)) 
            { 
                commandString += "c.clie_numeroDeDocumento LIKE @numDoc and ";
            }
            if (!String.IsNullOrEmpty(comboBoxTipoDocumento.SelectedValue.ToString())) 
            { 
                commandString += "d.docu_detalle = @doc and ";
            }
            if (checkBox.Checked)
            {
                commandString += "c.clie_habilitado = @hab and ";
            }
            commandString += "1=1";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@nom", "%" + textBoxNombre.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@ape", "%" + textBoxApellido.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@mail", "%" + textBoxEmail.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@numDoc", "%" + textBoxNumeroIdentificacion.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@doc", comboBoxTipoDocumento.SelectedValue.ToString());
            sda.SelectCommand.Parameters.AddWithValue("@hab", 1);
            sda.Fill(dt2);
            dataGridViewClientes.DataSource = dt2;
            if (dt2.Rows.Count != 0)
            {
                buttonModificarCliente.Enabled = true;
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            dtM = new DataTable();
            UtilesSQL.llenarTabla(dtM, "SELECT clie_nacionalidad, clie_nombre, clie_apellido, clie_mail, clie_telefono, clie_fechaDeNacimiento, clie_calle, clie_numeroDeCalle, clie_piso, clie_departamento, clie_localidad, clie_tipoDeDocumento, clie_numeroDeDocumento, clie_id FROM DERROCHADORES_DE_PAPEL.Cliente WHERE clie_mail = '" + dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() + "'");
            this.Hide();
            f = new ModificarCliente(this, dtM);
            limpiarTodo();
            f.ShowDialog();
        }

        private void darDeBaja_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que quiere dar de baja el cliente?", "Esta seguro?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Cliente set clie_habilitado = 0 WHERE clie_mail = '" + dataGridViewClientes.CurrentRow.Cells[2].Value.ToString() + "'");
                command.ExecuteNonQuery();
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
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarTipoDocumento()
        {
            command = UtilesSQL.crearCommand("select docu_detalle from DERROCHADORES_DE_PAPEL.Documento");
            SqlDataReader reader;

            reader = command.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("docu_detalle", typeof(string));
            dt.Rows.Add("");
            dt.Load(reader);

            comboBoxTipoDocumento.ValueMember = "docu_detalle";
            comboBoxTipoDocumento.DataSource = dt;
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
