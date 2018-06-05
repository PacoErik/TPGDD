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
    public partial class SeleccionFuncionalidadGuest : Form
    {
        Form f1;

        public SeleccionFuncionalidadGuest(Form f)
        {
            f1 = f;
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void Cancelar_reserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new CancelarReserva.CancelarReserva();
            f1.ShowDialog();
        }

        private void Generar_o_modificar_una_reserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva(this);
            f1.ShowDialog();
        }
    }
}
