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
        private int id_usuario;
        private string id_hotel;
        private bool es_guest;

        public GenerarModificacionReserva(int usuario, string hotel)
        {
            InitializeComponent();
            this.id_usuario = usuario;
            this.id_hotel = hotel;
            this.es_guest = false;
        }

        public GenerarModificacionReserva()
        {
            InitializeComponent();
            this.es_guest = true;
        }

        private void alta_Click(object sender, EventArgs e)
        {
            Form reserva;
            if (es_guest)
            {
                reserva = new GenerarReserva();
            }else {
                reserva = new GenerarReserva(id_usuario, Convert.ToInt32(id_hotel));
            }
            this.Hide();
            reserva.ShowDialog();
            this.Show();
        }

        private void modificacion_Click(object sender, EventArgs e)
        {
            //Form modificacion;
            //if (es_guest)
            //{
            //    modificacion = new GenerarReserva();
            //}
            //else
            //{
            //    modificacion = new GenerarReserva(id_usuario, Convert.ToInt32(id_hotel));
            //}
            this.Hide();
            this.Show();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            //Form baja;
            //if (es_guest)
            //{
            //    baja = new CancelarReserva.CancelarReserva();
            //}
            //else
            //{
            //    baja = new CancelarReserva.CancelarReserva(id_usuario, Convert.ToInt32(id_hotel));
            //}
            this.Hide();
            //reserva.ShowDialog();
            this.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
