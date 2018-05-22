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
        DataTable dt;

        public SeleccionRol(DataTable dataT)
        {
            dt = dataT;
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
            rolesComboBox.Items.Clear();
            foreach (DataRow dr in dt.Rows)      //Añade los roles al combo box
            {
                rolesComboBox.Items.Add(dr["rol_nombre"].ToString()+","+dr["hote_nombre"].ToString());
            }
        }

        public string user { get; set; }

    }
}
