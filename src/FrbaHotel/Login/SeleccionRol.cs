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
        Form f1;
        int id;

        public SeleccionRol(DataTable dataT, Form f)
        {
            id = int.Parse(dataT.Rows[0][5].ToString());
            f1 = f;
            dt = dataT;
            InitializeComponent();
        }
        
        private void entrar_Click(object sender, EventArgs e)
        {
            Form f2 = new SeleccionFuncionalidad(this, id, RolXHotel.CurrentRow.Cells[2].Value.ToString());
            f2.Show();
            this.Close();
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            dt.Columns.Remove("usur_habilitado");
            dt.Columns.Remove("usur_password");
            dt.Columns.Remove("usur_username");
            dt.Columns.Remove("usur_id");
            RolXHotel.DataSource = dt;
        }

        public string user { get; set; }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
   }
}
