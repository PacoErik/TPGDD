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

namespace FrbaHotel.AbmUsuario
{
    public partial class AbmUsuario : Form
    {
        Form f;
        string hotelId;
        SqlCommand command;
        string commandString;
        DataTable dtRoles = new DataTable();
        DataTable dtUsuarios = new DataTable();
        DataTable dtDocumentos = new DataTable();

        public AbmUsuario(string hotel)
        {
            hotelId = hotel;
            UtilesSQL.inicializar();
            InitializeComponent();
            cargarRoles();
        }
        private void cargarRoles()
        {
            command = UtilesSQL.crearCommand("select rol_nombre from DERROCHADORES_DE_PAPEL.Rol");
            SqlDataReader reader = command.ExecuteReader();
            dtRoles.Columns.Add("rol_nombre", typeof(string));
            dtRoles.Rows.Add("");
            dtRoles.Load(reader);

            comboBoxRol.ValueMember = "rol_nombre";
            comboBoxRol.DataSource = dtRoles;
        }
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.Rows.Clear();
            dtUsuarios.Clear();
            buttonModificarUsuario.Enabled = false;
            comboBoxRol.SelectedIndex = 0;
            checkBox.Checked = true;
            textBoxUsuario.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int res;
            dtUsuarios.Clear();
            commandString = "SELECT u.usur_username, u.usur_nombre, u.usur_apellido, u.usur_mail, u.usur_telefono, u.usur_fechaDeNacimiento, u.usur_calle, u.usur_numeroDeCalle, u.usur_numeroDeDocumento FROM DERROCHADORES_DE_PAPEL.Usuario AS u join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel AS ruh ON u.usur_id = ruh.rouh_usuario  join DERROCHADORES_DE_PAPEL.Hotel AS h ON h.hote_id = ruh.rouh_hotel join DERROCHADORES_DE_PAPEL.Rol AS r ON r.rol_id = ruh.rouh_rol WHERE ";
            if (!String.IsNullOrEmpty(textBoxNombre.Text))
            {
                commandString += "u.usur_nombre LIKE @nom and ";
            }
            if (!String.IsNullOrEmpty(textBoxApellido.Text))
            {
                commandString += "u.usur_apellido LIKE @ape and ";
            }
            if (!String.IsNullOrEmpty(comboBoxRol.SelectedValue.ToString()))
            {
                commandString += "ruh.rouh_rol = @rol and ";
            }
            if (int.TryParse(textBoxTelefono.Text, out res))
            {
                commandString += "u.usur_telefono LIKE @tel and ";
            }
            if (!String.IsNullOrEmpty(textBoxEmail.Text))
            {
                commandString += "u.usur_mail = @mail and ";
            }
            if (checkBox.Checked)
            {
                commandString += "u.usur_habilitado = @hab and ";
            }
            else
            {
                commandString += "u.usur_habilitado = @noHab and ";
            }
            if (!String.IsNullOrEmpty(textBoxUsuario.Text))
            {
                commandString += "u.usur_username LIKE @usur and ";
            }
            commandString += "h.hote_id = @hotel AND NOT usur_id = 2";
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter(commandString);
            sda.SelectCommand.Parameters.AddWithValue("@nom", "%" + textBoxNombre.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@ape", "%" + textBoxApellido.Text + "%");
            sda.SelectCommand.Parameters.AddWithValue("@rol", comboBoxRol.SelectedIndex);
            sda.SelectCommand.Parameters.AddWithValue("@tel", textBoxTelefono.Text);
            sda.SelectCommand.Parameters.AddWithValue("@mail", textBoxEmail.Text);
            sda.SelectCommand.Parameters.AddWithValue("@hab", 1);
            sda.SelectCommand.Parameters.AddWithValue("@noHab", 0);
            sda.SelectCommand.Parameters.AddWithValue("@usur", "%" + textBoxUsuario.Text +"%");
            sda.SelectCommand.Parameters.AddWithValue("@hotel", hotelId);
            sda.Fill(dtUsuarios);
            dataGridViewUsuarios.DataSource = dtUsuarios;
            buttonModificarUsuario.Enabled = true;
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            this.Hide();
            f = new AltaUsuario();
            f.ShowDialog();
            this.Show();
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            DataTable dtU = new DataTable();
            commandString = "SELECT * FROM DERROCHADORES_DE_PAPEL.Usuario WHERE usur_username = @usur";
            SqlDataAdapter sda2 = UtilesSQL.crearDataAdapter(commandString);
            sda2.SelectCommand.Parameters.AddWithValue("@usur", dataGridViewUsuarios.CurrentRow.Cells[0].Value);
            sda2.Fill(dtU);
            this.Hide();
            f = new ModificarUsuario(dtU, Int32.Parse(hotelId));
            limpiarTodo();
            f.ShowDialog();
            this.Show();
        }
    }
}
