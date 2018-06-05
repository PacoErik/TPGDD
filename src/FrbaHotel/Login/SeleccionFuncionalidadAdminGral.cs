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
    public partial class SeleccionFuncionalidadAdminGral : Form
    {
        Form f1;

        public SeleccionFuncionalidadAdminGral(Form f)
        {
            f1 = f;
            InitializeComponent();
        }

        private void Gestion_de_roles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmRol.AbmRol();
            f1.ShowDialog();
        }

        private void Gestion_de_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmUsuario.AbmUsuario();
            f1.ShowDialog();
        }

        private void Gestion_de_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmCliente.AbmCliente();
            f1.ShowDialog();
        }

        private void Gestion_de_hotel_Click(object sender, EventArgs e)
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

        private void Registrar_regimen_de_estadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AbmRegimen.AbmRegimen();
            f1.ShowDialog();
        }

        private void Cancelar_reserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new CancelarReserva.CancelarReserva();
            f1.ShowDialog();
        }

        private void Registrar_estadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new RegistrarEstadia.RegistrarEstadia();
            f1.ShowDialog();
        }

        private void Registrar_consumibles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new RegistrarConsumible.RegistrarConsumible();
            f1.ShowDialog();
        }

        private void Listado_estadistico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new ListadoEstadistico.ListadoEstadistico();
            f1.ShowDialog();
        }

        private void Generar_o_modificar_una_reserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva(this);
            f1.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
    }
}
