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
        public double cantidad_de_noches;
        public Hotel hotel = new Hotel();
        public List<Habitacion> habitaciones_reservadas = new List<Habitacion>();
        public double precio;
        public int regimen_seleccionado;
        public double precio_base;
        public int cliente;
        public int usuario;
        public int codigo;
        public void CalcularPrecio()
        {
            double total = hotel.recarga_estrellas;
            total += precio_base * habitaciones_reservadas.Sum(x => Convert.ToDouble(x.cantidad_personas)) * cantidad_de_noches;
            precio = total;
        }

        public int PersonasMaximas()
        {
            return habitaciones_reservadas.Sum(x => x.cantidad_personas);
        }

        public bool CapacidadSuficiente()
        {
            return PersonasMaximas() >= personas;
        }
    }

    class Hotel
    {
        public int ID;
        public double recarga_estrellas;
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
            retorno += "Nro: " + numero.ToString() + ". ";
            retorno += "Tipo: " + descripcion.ToString() + ". ";
            retorno += "Cantidad de personas: " + cantidad_personas.ToString();
            return retorno;
        }
    }
}
