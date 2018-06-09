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
        int id;
        string hotelId;
        SqlCommand com;
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

        public SeleccionFuncionalidad(Form f, int id_usuario, string hoteU)
        {
            hotelId = hoteU;
            id = id_usuario;
            f1 = f;
            UtilesSQL.inicializar();
            InitializeComponent();
            inicializarComboBox();
        }

        private void inicializarComboBox()
        {
            com = UtilesSQL.crearCommand("select f.func_detalle, u.rouh_hotel from DERROCHADORES_DE_PAPEL.FuncionalidadXRol as fxr  join DERROCHADORES_DE_PAPEL.Funcionalidad as f on f.func_id = fxro_funcionalidad  join DERROCHADORES_DE_PAPEL.Rol as r ON r.rol_id = fxr.fxro_rol  left join DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel as u ON u.rouh_rol = r.rol_id  where u.rouh_usuario = @id AND u.rouh_hotel = @hote group by f.func_detalle, u.rouh_hotel");
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@hote", hotelId);
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
            Form f1 = new AbmHotel.AbmHotel();
            f1.ShowDialog();
        }
        private void Gestion_de_habitaciones()
        {
            Form f1 = new AbmHabitacion.AbmHabitacion();
            f1.ShowDialog();
        }
        private void Registrar_regimen_de_estadia()
        {
            Form f1 = new AbmRegimen.AbmRegimen();
            f1.ShowDialog();
        }
        private void Cancelar_reserva()
        {
            Form f1 = new CancelarReserva.CancelarReserva();
            f1.ShowDialog();
        }
        private void Registrar_estadia()
        {
            Form f1 = new RegistrarEstadia.RegistrarEstadia();
            f1.ShowDialog();
        }
        private void Registrar_consumibles()
        {
            Form f1 = new RegistrarConsumible.RegistrarConsumible();
            f1.ShowDialog();
        }
        private void Listado_estadistico()
        {
            Form f1 = new ListadoEstadistico.ListadoEstadistico();
            f1.ShowDialog();
        }
        private void Generar_o_modificar_una_reserva()
        {
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva(this);
            f1.ShowDialog();
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
                case "REGISTRAR CONSUMIBLES":
                    Registrar_consumibles();
                    break;
                case "LISTADO ESTADISTICO":
                    Listado_estadistico();
                    break;
            }
            this.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
    }
}
