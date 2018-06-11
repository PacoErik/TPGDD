using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.GenerarModificacionReserva
{
    class Reserva
    {
        public DateTime fecha_que_se_realizo_reserva;
        public DateTime fecha_desde;
        public DateTime fecha_hasta;
        public int personas;
        public int cantidad_de_noches;
        public string hotel_seleccionado;
    }
}
