using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class SeleccionFuncionalidadAdmin : Form
    {
        public SeleccionFuncionalidadAdmin()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gestion_de_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmUsuario.AbmUsuario();
            f1.ShowDialog();
        }

        private void Gestion_de_hoteles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmHotel.AbmHotel();
            f1.ShowDialog();
        }

        private void Gestion_de_habitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmHabitacion.AbmHabitacion();
            f1.ShowDialog();
        }

        private void Gestion_regimen_de_estadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmRegimen.AbmRegimen();
            f1.ShowDialog();
        }
    }
}
