using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.CancelarReserva
{
    public partial class CancelarReserva : Form
    {
        private int usuario;
        private int hotel;

        private SqlConnection conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
        private SqlCommand command;
        private SqlDataAdapter sda;

        private DataTable reserva = new DataTable();

        public CancelarReserva()
        {
            InitializeComponent();
            this.Inicializar();
        }

        public CancelarReserva(int userId, string hotelId)
        {
            InitializeComponent();
            this.usuario = userId;
            this.hotel = Convert.ToInt32(hotelId);
            this.Inicializar();
        }

        private void Inicializar()
        {
            this.lbl_error.Visible = false;
            this.lbl_cargado_correcto.Visible = false;
            this.lbl_ingrese_motivo.Visible = false;
        }


        private void btn_cargar_reserva_Click(object sender, EventArgs e)
        {
            if(this.txtbox_codigo.Text != "")
            {
                this.CargarReserva(this.txtbox_codigo.Text);
            }
        }

        private void CargarReserva(string codigo_reserva)
        {
            this.reserva = new DataTable();
            this.sda = new SqlDataAdapter("SELECT * FROM DERROCHADORES_DE_PAPEL.Reserva WHERE rese_codigo = '"+ codigo_reserva +"'", conexion);
            this.sda.Fill(this.reserva);
            if (this.reserva.Rows.Count == 0)
            {
                this.lbl_error.Text = "No se encuentra la reserva";
                this.lbl_error.Visible = true;
            }
            else {
                TimeSpan dias_para_reserva = DateTime.Today - Convert.ToDateTime(this.reserva.Rows[0]["rese_inicio"]);
                if (dias_para_reserva.Days <= 1)
                {
                    this.lbl_error.Text = "No se puede cancelar a menos de un dia";
                    this.lbl_error.Visible = true;
                }
                else
                {
                    this.lbl_cargado_correcto.Visible = true;
                    this.lbl_ingrese_motivo.Visible = true;
                }
            }
                
        }


        private void enviar_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {

        }



    }
}
