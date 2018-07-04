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

namespace FrbaHotel.Login
{
    public partial class SeleccionFuncionalidad : Form
    {
        Form f1;
        static int idUser;
        static string hotelId;
        SqlCommand com;
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        string rolElegido;

        public SeleccionFuncionalidad(Form f, int id_usuario, string hoteU, string rol)
        {
            hotelId = hoteU;
            idUser = id_usuario;
            f1 = f;
            rolElegido = rol;
            UtilesSQL.inicializar();
            InitializeComponent();
            inicializarComboBox();
        }

        public static string getHotelId() 
        {
            return hotelId;
        }

        public static string getUserId()
        {
            return idUser.ToString();
        }

        private void inicializarComboBox()
        {
            com = UtilesSQL.crearCommand("select f.func_detalle, u.rouh_hotel from DERROCHADORES_DE_PAPEL.FuncionalidadXRol as fxr  join DERROCHADORES_DE_PAPEL.Funcionalidad as f on f.func_id = fxro_funcionalidad  join DERROCHADORES_DE_PAPEL.Rol as r ON r.rol_id = fxr.fxro_rol  left join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel as u ON u.rouh_rol = r.rol_id  where u.rouh_usuario = @id AND u.rouh_hotel = @hote AND r.rol_nombre LIKE @rol group by f.func_detalle, u.rouh_hotel");
            com.Parameters.AddWithValue("@id", idUser);
            com.Parameters.AddWithValue("@hote", hotelId);
            MessageBox.Show(rolElegido);
            com.Parameters.AddWithValue("@rol", "%"+rolElegido);
            da.SelectCommand = com;
            da.Fill(ds);
            comboBoxFuncionalidad.DisplayMember = "func_detalle";
            comboBoxFuncionalidad.ValueMember = "func_detalle";
            comboBoxFuncionalidad.DataSource = ds.Tables[0];
        }

        private void Gestion_de_roles()
        {
            Form f1 = new AbmRol.AbmRol();
            f1.ShowDialog();
        }
        private void Gestion_de_usuarios()
        {
            Form f1 = new AbmUsuario.AbmUsuario(hotelId);
            f1.ShowDialog();
        }
        private void Gestion_de_clientes()
        {
            Form f1 = new AbmCliente.AbmCliente();
            f1.ShowDialog();
        }
        private void Gestion_de_hotel()
        {
            Form f1 = new AbmHotel.AbmHotel(idUser);
            f1.ShowDialog();
        }
        private void Gestion_de_habitaciones()
        {
            Form f1 = new AbmHabitacion.ListadoHabitaciones(Int32.Parse(hotelId));
            f1.ShowDialog();
        }
        private void Cancelar_reserva()
        {
            Form f1 = new CancelarReserva.CancelarReserva(idUser, hotelId);
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
        private void Registrar_estadia()
        {
            Form f1 = new RegistrarEstadia.RegistrarEstadia();
            f1.ShowDialog();
        }
        private void Listado_estadistico()
        {
            Form f1 = new ListadoEstadistico.ListadoEstadistico();
            f1.ShowDialog();
        }
        private void Generar_o_modificar_una_reserva()
        {
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva(idUser, hotelId);
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (comboBoxFuncionalidad.Text)  //Según la funcionalidad el id del usuario y hotel son necesarios o no
            {
                case "ABM DE ROL":
                    Gestion_de_roles();
                    break;
                case "ABM DE USUARIO":
                    Gestion_de_usuarios();
                    break;
                case "ABM DE CLIENTE":
                    Gestion_de_clientes();
                    break;
                case "ABM DE HOTEL":
                    Gestion_de_hotel();
                    break;
                case "ABM DE HABITACION":
                    Gestion_de_habitaciones();
                    break;
                case "ABM REGIMEN DE ESTADIA":
                    Registrar_estadia();
                    break;
                case "GENERAR O MODIFICAR UNA RESERVA":
                    Generar_o_modificar_una_reserva();
                    break;
                case "CANCELAR RESERVA":
                    Cancelar_reserva();
                    break;
                case "REGISTRAR ESTADIA":
                    Registrar_estadia();
                    break;
                case "LISTADO ESTADISTICO":
                    Listado_estadistico();
                    break;
            }
            this.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
