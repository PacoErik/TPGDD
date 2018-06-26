using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Main : Form
    {
        static String fechaDelSistema;

        public Main()
        {
            fechaDelSistema = Properties.Settings.Default["FechaDelSistema"].ToString();
            UtilesSQL.inicializar();
            InitializeComponent();
            fechaSistema.Text = fechaDelSistema.ToString();
        }

        public static String fecha()
        {
            return fechaDelSistema;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Huesped_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionHotelGuest().ShowDialog();
            this.Show();
        }
        private void Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Login.Login(this);
            f1.ShowDialog();
            this.Show();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarFecha_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ElegirFechaDelSistema().ShowDialog();
            fechaSistema.Text = fechaDelSistema;
            this.Show();
        }

        public static void cambiarFechaDelSistema(String fechaNueva) 
        {
            fechaDelSistema = fechaNueva;
        }
    }
}
