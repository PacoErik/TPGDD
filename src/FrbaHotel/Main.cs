using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Main : Form
    {
        static String fechaDelSistema;

        public Main()
        {
            fechaDelSistema = Properties.Settings.Default["fechaDelSistema"].ToString();
            UtilesSQL.inicializar();
            InitializeComponent();
        }

        public static String fecha()
        {
            return fechaDelSistema;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Huesped_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTable roles = new DataTable();
            UtilesSQL.llenarTabla(roles, "SELECT u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre, u.usur_id, ruh.rouh_hotel from DERROCHADORES_DE_PAPEL.Usuario as u  inner join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel as ruh ON u.usur_id = ruh.rouh_usuario inner join DERROCHADORES_DE_PAPEL.Hotel as h ON h.hote_id = ruh.rouh_hotel inner join DERROCHADORES_DE_PAPEL.Rol as r ON r.rol_id = ruh.rouh_rol WHERE u.usur_username = \'guest\' AND ruh.rouh_habilitado = 1 GROUP BY u.usur_username, u.usur_password, u.usur_habilitado, r.rol_nombre, h.hote_nombre, u.usur_id, ruh.rouh_hotel");
            switch (roles.Rows.Count) //Si tiene mas de un rol, pregunta a cual rol quiere loguearse
            {
                case 0:
                    MessageBox.Show("Esta cuenta no tiene ningún rol");
                    break;
                case 1:
                    Form f2 = new Login.SeleccionFuncionalidad(this, int.Parse(roles.Rows[0][5].ToString()), roles.Rows[0][6].ToString());
                    f2.ShowDialog();
                    break;
                default:
                    Login.SeleccionRol f1 = new Login.SeleccionRol(roles, this);
                    f1.ShowDialog();
                    if (f1.resultado) //Se fija que la seleccion de rol fue exitosa
                    {
                        Form f3 = new Login.SeleccionFuncionalidad(this, f1.idU, f1.hoteId);
                        f3.ShowDialog();
                    }
                    break;
            }
        }
        private void Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Login.Login(this);
            f1.ShowDialog();
            this.Show();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
