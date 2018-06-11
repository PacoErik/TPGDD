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
        public Main()
        {
            UtilesSQL.inicializar();
            InitializeComponent();
        }

        private void Huesped_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva(this);
            f1.ShowDialog();
            this.Show();
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
