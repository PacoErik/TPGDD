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
    public partial class SeleccionarRol : Form
    {
        public String rol { get; set; }
        DataTable dtRol = new DataTable();

        public SeleccionarRol(DataTable dtRolesAsignados)
        {
            InitializeComponent();
            rol = null;
            comboBoxRoles.ValueMember = "rol_nombre";
            comboBoxRoles.DataSource = dtRolesAsignados;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            rol = comboBoxRoles.SelectedValue.ToString();
            this.Close();
        }
    }
}
