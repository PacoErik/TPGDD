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
    public partial class ElegirCliente : Form
    {
        private SqlCommand command;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtM = new DataTable();
        string commandString;
        Form f;

        public bool elegido = false;
        String cliente_id;
        String cliente_apellido;
        String cliente_nombre;
        String cliente_mail;

        public ElegirCliente()
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
            f = new AbmCliente.AltaCliente();
            f.ShowDialog();
            this.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            elegido = false;
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            dt2.Clear();
            commandString = "SELECT c.clie_id Cliente, c.clie_apellido Apellido, c.clie_nombre Nombre, c.clie_mail Mail, c.clie_numeroDeDocumento Documento, d.docu_detalle TipoDocumento FROM DERROCHADORES_DE_PAPEL.Cliente AS c JOIN DERROCHADORES_DE_PAPEL.Documento AS d ON c.clie_tipoDeDocumento = d.docu_tipo WHERE ";
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
                commandString += "c.clie_mail = @mail and ";
            }
            if (!String.IsNullOrEmpty(textBoxNumeroIdentificacion.Text)) 
            { 
                commandString += "c.clie_numeroDeDocumento = @numDoc and ";
            }
            if (!String.IsNullOrEmpty(comboBoxTipoDocumento.SelectedValue.ToString())) 
            { 
                commandString += "d.docu_detalle = @doc and ";
            }
            commandString += "c.clie_habilitado = 1";

            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@nom", "%" + textBoxNombre.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@ape", "%" + textBoxApellido.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@mail", textBoxEmail.Text);
            sda.SelectCommand.Parameters.AddWithValue("@numDoc", textBoxNumeroIdentificacion.Text);
            sda.SelectCommand.Parameters.AddWithValue("@doc", comboBoxTipoDocumento.SelectedText);
            sda.Fill(dt2);
            dataGridViewClientes.DataSource = dt2;
            seleccionar.Enabled = true;
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            seleccionar.Enabled = false;
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

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow.Index >= 0)
            {
                DataRow cliente = ((DataRowView)dataGridViewClientes.CurrentRow.DataBoundItem).Row;
                cliente_id = cliente[0].ToString();
                cliente_apellido = cliente[1].ToString();
                cliente_nombre = cliente[2].ToString();
                cliente_mail = cliente[3].ToString();

                elegido = true;
                this.Close();
            }
        }

        public String id()
        {
            return cliente_id;
        }


        public String apellido()
        {
            return cliente_apellido;
        }


        public String nombre()
        {
            return cliente_nombre;
        }


        public String mail()
        {
            return cliente_mail;
        }

        public bool estaElegido()
        {
            return elegido;
        }
    }
}
