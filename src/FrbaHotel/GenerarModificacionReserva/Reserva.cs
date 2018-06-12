using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.GenerarModificacionReserva
{
    class Reserva
    {
        public DateTime fecha_que_se_realizo_reserva = new DateTime();
        public DateTime fecha_desde = new DateTime();
        public DateTime fecha_hasta = new DateTime();
        public int personas;
        public int cantidad_de_noches;
        public Hotel hotel = new Hotel();
        public List<Habitacion> habitaciones_reservadas = new List<Habitacion>();
        public double precio;
        public bool regimen_seleccionado = false;
        public double precio_base;
        public int cliente;
        public int usuario;
        
        public void CalcularPrecio()
        {
            double total = this.hotel.recarga_estrellas;
            total += this.precio_base * this.habitaciones_reservadas.Sum(x => Convert.ToDouble(x.cantidad_personas));
            this.precio = total;
        }

        public int PersonasMaximas()
        {
            return this.habitaciones_reservadas.Sum(x => x.cantidad_personas);
        }

        public bool CapacidadSuficiente()
        {
            return this.PersonasMaximas() >= this.personas;
        }
    }

    class Hotel
    {
        public int ID;
        public double recarga_estrellas;
    }

    class Regimen
    {
        public double precio_base;
    }

    class Habitacion
    {
        public int numero;
        public int cantidad_personas;
        public string descripcion;
        public int piso;

        public override string ToString()
        {
            string retorno = string.Empty;
            retorno += "Nro: " + this.numero.ToString() + ". ";
            retorno += "Tipo: " + this.descripcion.ToString() + ". ";
            retorno += "Cantidad de personas: " + this.cantidad_personas.ToString();
            return retorno;
        }
    }
}
