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

namespace FrbaHotel.Login
{
    public partial class SeleccionRol : Form
    {
        public SeleccionRol(string usuario)
        {
            user = usuario;
            InitializeComponent();
        }

        private void rolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
            rolesComboBox.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT r.rol_nombre FROM DERROCHADORES_DE_PAPEL.Usuario as u inner join DERROCHADORES_DE_PAPEL.RolXUsuario as rxu ON u.usur_id = rxu.roxu_usuario inner join DERROCHADORES_DE_PAPEL.Rol as r ON rxu.roxu_rol = r.rol_id where usur_username='" + user + "'", con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)      //Añade los roles al combo box
            {
                rolesComboBox.Items.Add(dr["rol_nombre"].ToString());
            }
        }

        public string user { get; set; }
    }
}
