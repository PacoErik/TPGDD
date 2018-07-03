using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        DataTable resultados_dt;

        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            if (anio.SelectedIndex < 0 || trimestre.SelectedIndex < 0 || tipoDeListado.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, elija un año, trimestre y un tipo de listado para poder listar");
                return;
            }

            resultados_dt = new DataTable();

            switch (tipoDeListado.Text)
            {
                case "HOTELES CON MAYOR CANTIDAD DE RESERVAS CANCELADAS":
                    UtilesSQL.llenarTabla(resultados_dt, "SELECT TOP 5 hote_id Hotel, hote_nombre Nombre, COUNT(*) \'Cantidad canceladas\' "
                                                        + "FROM DERROCHADORES_DE_PAPEL.CancelacionReserva JOIN "
                                                        + "DERROCHADORES_DE_PAPEL.Reserva ON canc_reserva = rese_codigo JOIN "
                                                        + "DERROCHADORES_DE_PAPEL.Hotel ON rese_hotel = hote_id "
                                                        + "WHERE YEAR(canc_fechaDeCancelacion) = "+anio.SelectedItem+" AND "
                                                        + "MONTH(canc_fechaDeCancelacion) BETWEEN "+rangoDeMeses()+" "
                                                        + "GROUP BY hote_id, hote_nombre "
                                                        + "ORDER BY 3 DESC");
                    break;
                case "HOTELES CON MAYOR CANTIDAD DE CONSUMIBLES FACTURADOS":
                    UtilesSQL.llenarTabla(resultados_dt, "SELECT TOP 5 hote_id Hotel, hote_nombre Nombre, SUM(item_cantidad) \'Cantidad consumibles\' "
                                                        +"FROM DERROCHADORES_DE_PAPEL.ItemDeFactura JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Factura ON item_factura = fact_numero JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Estadia ON esta_id = fact_estadia JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Reserva ON rese_codigo = esta_reserva JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Hotel ON hote_id = rese_hotel "
                                                        +"WHERE item_consumible IS NOT NULL AND "
                                                            +"YEAR(fact_fecha) = "+anio.SelectedItem+" AND "
                                                            +"MONTH(fact_fecha) BETWEEN "+rangoDeMeses()+" "
                                                        +"GROUP BY hote_id, hote_nombre "
                                                        +"ORDER BY 3 DESC");
                    break;
                case "HOTELES CON MAYOR CANTIDAD DE DIAS FUERA DE SERVICIO":
                    UtilesSQL.llenarTabla(resultados_dt, "SELECT TOP 5 hote_id Hotel, hote_nombre Nombre, ISNULL(SUM(DATEDIFF(DAY, peri_fechaInicio, peri_fechaFin)),0) \'Días sin servicio\' "
                                                        +"FROM DERROCHADORES_DE_PAPEL.Hotel LEFT JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.PeriodoDeCierre ON peri_hotel = hote_id "
                                                        +"WHERE (peri_fechaInicio IS NOT NULL AND "
                                                            +"MONTH(peri_fechaInicio) BETWEEN "+rangoDeMeses()+" AND "
                                                            +"YEAR(peri_fechaInicio) = "+anio.SelectedItem+") OR "
                                                            +"peri_fechaInicio IS NULL "
                                                        +"GROUP BY hote_id, hote_nombre "
                                                        +"ORDER BY 3 DESC");
                    break;
                case "HABITACIONES CON MAYOR CANTIDAD DE DIAS Y VECES QUE FUERON OCUPADAS":
                    UtilesSQL.llenarTabla(resultados_dt, "SELECT TOP 5 hote_id Hotel, hote_nombre Nombre, habi_piso Piso, habi_numero Número, COUNT(*) \'Cantidad de veces ocupada\', SUM(DATEDIFF(DAY, esta_fechaDeInicio, esta_fechaDeFin)) \'Días ocupada\' "
                                                        +"FROM DERROCHADORES_DE_PAPEL.Hotel JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Habitacion ON hote_id = habi_hotel JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.ReservaXHabitacion ON rexh_hotel = habi_hotel AND "
                                                                                                        +"rexh_numero = habi_numero AND "
                                                                                                        +"rexh_piso = habi_piso JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Reserva ON rese_codigo = rexh_reserva JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Estadia ON esta_reserva = rese_codigo "
                                                        +"WHERE YEAR(esta_fechaDeInicio) = "+anio.SelectedItem+" AND "
                                                                +"MONTH(esta_fechaDeInicio) BETWEEN "+rangoDeMeses()+" "
                                                        +"GROUP BY hote_id, hote_nombre, habi_piso, habi_numero "
                                                        +"ORDER BY 6 DESC, 5 DESC");
                    break;
                case "CLIENTES CON MAYOR CANTIDAD DE PUNTOS":
                    UtilesSQL.llenarTabla(resultados_dt, "SELECT TOP 5 clie_nombre Nombre, clie_apellido Apellido,SUM(CASE WHEN item_consumible IS NULL THEN CONVERT(INT,item_monto) ELSE 0 END)/20+SUM(CASE WHEN item_consumible IS NOT NULL THEN CONVERT(INT,item_monto) ELSE 0 END)/10 \'Puntos totales\',SUM(CASE WHEN item_consumible IS NULL THEN CONVERT(INT,item_monto) ELSE 0 END)/20 \'Puntos estadías\', SUM(CASE WHEN item_consumible IS NOT NULL THEN CONVERT(INT,item_monto) ELSE 0 END)/10 \'Puntos consumibles\' "
                                                        +"FROM DERROCHADORES_DE_PAPEL.Cliente JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.Factura ON fact_cliente = clie_id JOIN "
                                                            +"DERROCHADORES_DE_PAPEL.ItemDeFactura ON item_factura = fact_numero "
                                                        +"WHERE YEAR(fact_fecha) = "+anio.SelectedItem+" AND "
                                                                +"MONTH(fact_fecha) BETWEEN "+rangoDeMeses()+" "
                                                        +"GROUP BY clie_id, clie_nombre, clie_apellido "
                                                        +"ORDER BY 3 DESC");
                    break;
            }

            resultados.DataSource = resultados_dt;
        }

        private String rangoDeMeses()
        {
            int mesInicial = trimestre.SelectedIndex * 3 + 1;
            int mesFinal = mesInicial + 2;
            return mesInicial.ToString()+" AND "+mesFinal.ToString();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
