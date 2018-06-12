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

        public GenerarModificacionReserva(int usuario, string hotel)
        {
            InitializeComponent();
            this.id_usuario = usuario;
            this.id_hotel = hotel;
            this.baja.Visible = false;
        }

    

        private void alta_Click(object sender, EventArgs e)
        {
            Form alta = new GenerarReserva(id_usuario, id_hotel);
            this.Hide();
            alta.ShowDialog();
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
            Form baja = new CancelarReserva.CancelarReserva(id_usuario, id_hotel);
            this.Hide();
            baja.ShowDialog();
            this.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
