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
        DataTable dt = new DataTable();
        SHA sha256 = new SHA();
        private string usuario;


        private void Entrar_Click(object sender, EventArgs e)
        {
            if (loginsIncorrectos != 0 && usuario != usuarioTextBox.Text) { loginsIncorrectos = 0; }      //reinicia los logins invalidos si trato de logear con otro usuario
            usuario = usuarioTextBox.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre from DERROCHADORES_DE_PAPEL.Usuario as u  inner join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel as ruh ON u.usur_id = ruh.rouh_usuario inner join DERROCHADORES_DE_PAPEL.Hotel as h ON h.hote_id = ruh.rouh_hotel inner join DERROCHADORES_DE_PAPEL.Rol as r ON r.rol_id = ruh.rouh_rol WHERE u.usur_username = '" + usuario + "' GROUP BY u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre", con);
            sda.Fill(dt);
            if (dt.Rows.Count == 0)      //Checkeo que exista el usuario
            {
                MessageBox.Show("No existe el usuario o no tiene ningún rol");
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
            return dt.Rows[0][1].ToString() == sha256.GenerarSHA256String(ContraseñaTextBox.Text);
        }

        private bool ValidarUsuario(DataTable dt)
        {
            return dt.Rows[0][2].ToString() == "True";
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
            dt.Clear();
        }

        private void LoginCorrecto(SqlDataAdapter sda)
        {
            loginsIncorrectos = 0;
            switch (dt.Rows.Count)
            {
                case 0:
                    MessageBox.Show("Esta cuenta no tiene ningún rol");
                    break;
                case 1:
                    MessageBox.Show("Login exitoso!");

                    break;
                default:
                    Form f1 = new SeleccionRol(dt);
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
