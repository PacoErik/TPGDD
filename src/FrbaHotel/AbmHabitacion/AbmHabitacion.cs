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

namespace FrbaHotel.AbmHabitacion
{
    public partial class AbmHabitacion : Form
    {
        DataTable dtHoteles = new DataTable();
        int idUser;

        public AbmHabitacion(int idH)
        {
            idUser = idH;
            UtilesSQL.inicializar();
            InitializeComponent();
            SqlDataAdapter sda = UtilesSQL.crearDataAdapter("SELECT hote_id, hote_nombre, hote_estrellas, hote_ciudad FROM DERROCHADORES_DE_PAPEL.Hotel AS h JOIN DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel AS r ON r.rouh_hotel = h.hote_id WHERE r.rouh_usuario = @user");
            sda.SelectCommand.Parameters.AddWithValue("@user", idUser);
            sda.Fill(dtHoteles);
            Hoteles.DataSource = dtHoteles;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new ListadoHabitaciones(Int32.Parse(Hoteles.CurrentRow.Cells[0].Value.ToString()));
            f1.ShowDialog();
            this.Show();
        }
    }
}
