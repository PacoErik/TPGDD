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

        public SeleccionRol(DataTable dataT, Form f)
        {
            f1 = f;
            dt = dataT;
            InitializeComponent();
        }
        
        private void entrar_Click(object sender, EventArgs e)
        {
            
            switch (RolXHotel.CurrentRow.Cells[0].Value.ToString())
            {
                case "ADMINISTRADOR GENERAL":
                    Form f2 = new SeleccionFuncionalidadAdminGral(this);
                    f2.Show();
                    break;
                case "ADMINISTRADOR":
                    Form f5 = new SeleccionFuncionalidadAdmin(this);
                    f5.Show();
                    break;
                case "RECEPCIONISTA":
                    Form f3 = new SeleccionFuncionalidadRecepcionista(this);
                    f3.Show();
                    break;
                case "GUEST":
                    Form f4 = new SeleccionFuncionalidadGuest(this);
                    f4.Show();
                    break;
            }
            this.Close();
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            dt.Columns.Remove("usur_habilitado");
            dt.Columns.Remove("usur_password");
            dt.Columns.Remove("usur_username");
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
