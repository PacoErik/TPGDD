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
    public partial class SeleccionHotelGuest : Form
    {
        DataTable hoteles_dt;

        public SeleccionHotelGuest()
        {
            InitializeComponent();
            CargarHoteles();
        }

        private void CargarHoteles()
        {
            hoteles_dt = new DataTable();
            UtilesSQL.llenarTabla(hoteles_dt, "SELECT hote_nombre Nombre, hote_id Hotel FROM DERROCHADORES_DE_PAPEL.Usuario JOIN DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel ON usur_id = rouh_usuario JOIN DERROCHADORES_DE_PAPEL.Hotel ON hote_id = rouh_hotel JOIN DERROCHADORES_DE_PAPEL.Rol ON rol_id = rouh_rol WHERE usur_username = \'guest\' AND rouh_habilitado = 1");
            hoteles.DataSource = hoteles_dt;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            String hoteId = hoteles.CurrentRow.Cells[1].Value.ToString();
            this.Hide();
            new SeleccionFuncionalidad(this, 2, hoteId, "").ShowDialog();
            CargarHoteles();
            this.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
