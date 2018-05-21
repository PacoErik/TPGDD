using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using FrbaHotel.Login;

namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int loginsIncorrectos = 0;
        private SqlCommand command;
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");


        private void Entrar_Click(object sender, EventArgs e)
        {
            SHA sha256 = new SHA();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Usuario WHERE usur_username = '" + usuarioTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)      //Checkeo que exista el usuario
            {
                MessageBox.Show("No existe el usuario");
            }
            else
            {
                if (ValidarUsuario(dt))         //Checkeo que el usuario este habilitado
                {
                    if (ValidarContraseña(dt))    //checkea que la contraseña sea correcta
                    {
                        LoginCorrecto(sda);
                        this.Close();
                    }
                    else
                    {
                        LoginIncorrecto();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario se encuentra bloqueado");
                }
            }
        }

        private bool ValidarContraseña(DataTable dt)
        {
            SHA sha256 = new SHA();
            return dt.Rows[0][2].ToString() == sha256.GenerarSHA256String(ContraseñaTextBox.Text);
        }

        private bool ValidarUsuario(DataTable dt)
        {
            return dt.Rows[0][15].ToString() == "True";
        }

        private void LoginIncorrecto()
        {
            loginsIncorrectos++;         //incrementa los logins incorrectos (max 3)
            if (loginsIncorrectos != 3)
            {
                MessageBox.Show("Contraseña incorrecta. Intentos restantes: " + (3 - loginsIncorrectos).ToString());
            }
            else
            {
                con.Open();
                command = new SqlCommand("UPDATE DERROCHADORES_DE_PAPEL.Usuario SET usur_habilitado = '0' WHERE usur_username = '" + usuarioTextBox.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Contraseña incorrecta. La cuenta ha sido bloqueada");
            }
        }

        private void LoginCorrecto(SqlDataAdapter sda)
        {
            DataTable dt = new DataTable();
            loginsIncorrectos = 0;
            dt.Clear();
            sda = new SqlDataAdapter("SELECT r.rol_nombre FROM DERROCHADORES_DE_PAPEL.Usuario as u inner join DERROCHADORES_DE_PAPEL.RolXUsuario as rxu ON u.usur_id = rxu.roxu_usuario inner join DERROCHADORES_DE_PAPEL.Rol as r ON rxu.roxu_rol = r.rol_id where usur_username='" + usuarioTextBox.Text + "'", con);
            sda.Fill(dt);
            switch (dt.Rows.Count)
            {
                case 0:
                    MessageBox.Show("Esta cuenta no tiene roles");
                    break;
                case 1:
                    MessageBox.Show("Login exitoso!");
                    break;
                default:
                    Form f1 = new SeleccionRol(usuarioTextBox.Text);
                    f1.ShowDialog();
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
