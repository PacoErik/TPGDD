using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class SeleccionarHotel : Form
    {
        public String Hotel { get; set; }
        SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT hote_id, hote_nombre, hote_estrellas, hote_ciudad FROM DERROCHADORES_DE_PAPEL.Hotel");
        DataTable dt = new DataTable();

        public SeleccionarHotel()
        {
            InitializeComponent();
            UtilesSQL.inicializar();
            sda.Fill(dt);
            Hoteles.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel = Hoteles.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
