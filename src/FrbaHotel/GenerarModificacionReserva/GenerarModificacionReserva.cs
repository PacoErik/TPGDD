using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarModificacionReserva : Form
    {
        private Form invocador;
        public GenerarModificacionReserva(Form invocador)
        {
            this.invocador = invocador;
            InitializeComponent();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reserva = new GenerarReserva(this);
            reserva.ShowDialog();
            this.Show();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reserva = new GenerarModificacionReserva(this);
            reserva.ShowDialog();
            this.Show();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reserva = new CancelarReserva.CancelarReserva();
            reserva.ShowDialog();
            this.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.invocador.Show();
            this.Close();
        }


    }
}
