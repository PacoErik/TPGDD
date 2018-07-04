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
        public Login(Form MainF)
        {
            MainForm = MainF;
            UtilesSQL.inicializar();
            InitializeComponent();
        }

        Form MainForm;
        private int loginsIncorrectos = 0;
        private SqlCommand command;
        DataTable dt = new DataTable();
        SHA sha256 = new SHA();
        private string usuario;
        SqlDataAdapter sda;


        private void Entrar_Click(object sender, EventArgs e)
        {
            if (loginsIncorrectos != 0 && usuario != usuarioTextBox.Text) { loginsIncorrectos = 0; }      //reinicia los logins invalidos si trato de logear con otro usuario
            usuario = usuarioTextBox.Text;
            sda = UtilesSQL.crearDataAdapter("SELECT u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre, u.usur_id, ruh.rouh_hotel from DERROCHADORES_DE_PAPEL.Usuario as u  inner join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel as ruh ON u.usur_id = ruh.rouh_usuario inner join DERROCHADORES_DE_PAPEL.Hotel as h ON h.hote_id = ruh.rouh_hotel inner join DERROCHADORES_DE_PAPEL.Rol as r ON r.rol_id = ruh.rouh_rol WHERE u.usur_username = @usuario AND ruh.rouh_habilitado = 1 GROUP BY u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre, u.usur_id, ruh.rouh_hotel");
            sda.SelectCommand.Parameters.AddWithValue("@usuario", usuario);
            sda.Fill(dt);
            if (dt.Rows.Count == 0)      //Checkeo que exista el usuario
            {
                MessageBox.Show("No existe el usuario o no tiene asignado ningún rol");
            }
            else
            {
                if (ValidarUsuario(dt))         //Checkeo que el usuario este habilitado
                {
                    if (ValidarContraseña(dt))    //checkea que la contraseña sea correcta
                    {
                        LoginCorrecto(sda);
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
            return dt.Rows[0][2].ToString() == true.ToString();
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
                command = UtilesSQL.crearCommand("UPDATE DERROCHADORES_DE_PAPEL.Usuario SET usur_habilitado = '0' WHERE usur_username = @user");
                command.Parameters.AddWithValue("@user", usuarioTextBox.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Contraseña incorrecta. La cuenta ha sido bloqueada");
            }
            dt.Clear();
        }
        private void LoginCorrecto(SqlDataAdapter sda)
        {
            this.Hide();
            ContraseñaTextBox.Clear();
            usuarioTextBox.Clear();
            loginsIncorrectos = 0;
            switch (dt.Rows.Count) //Si tiene mas de un rol, pregunta a cual rol quiere loguearse
            {
                case 0:
                    MessageBox.Show("Esta cuenta no tiene ningún rol");
                    break;
                case 1:
                    Form f2 = new SeleccionFuncionalidad(this, int.Parse(dt.Rows[0][5].ToString()), dt.Rows[0][6].ToString(), "");
                    f2.ShowDialog();
                    break;
                default:
                    SeleccionRol f1 = new SeleccionRol(dt, this);
                    f1.ShowDialog();
                    if (f1.resultado) //Se fija que la seleccion de rol fue exitosa
                    {
                        Form f3 = new SeleccionFuncionalidad(this, f1.idU, f1.hoteId, f1.rolElegido);
                        f3.ShowDialog();
                    }
                    break;
            }
            this.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
        }
    }
}
