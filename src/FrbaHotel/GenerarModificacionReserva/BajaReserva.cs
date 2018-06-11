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
    public partial class BajaReserva : Form
    {
        private Form invocador;

        public BajaReserva(Form invocador)
        {
            InitializeComponent();

            this.invocador = invocador;
        }

        private void btn_cargarReserva_Click(object sender, EventArgs e)
        {
            
        }

        private bool CodigoValido() { 
            //REVISAR SI EXISTE EN LA BASE DE DATOS
            return true;
        }

        private void CargarReserva() { 
            //CARGAR LA RESERVA
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Si el mensaje no esta vacio
            //Se borra la reserva

        }


    }
}
