using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class ElegirClientes : Form
    {
        String estadia_id;
        String reserva;
        int cantidad_personas;

        public bool correcto { get; set; }
        public DataTable distribucionClientes_dt { get; set; }

        public ElegirClientes(String cliente_id, String cliente_apellido, String cliente_nombre, String reserva, int cantidad_personas, Form f)
        {
            this.reserva = reserva;
            this.cantidad_personas = cantidad_personas;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public bool estaBien()
        {
            return correcto;
        }

        public DataTable distribucionClientes()
        {
            return distribucionClientes_dt;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            correcto = false;
            this.Close();
        }
    }
}
