using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    public class UtilesSQL
    {
        private static SqlConnection conexion;

        public UtilesSQL() { }
        public static void inicializar() 
        {
            conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");
            conexion.Open();
        }
        public static int ejecutarComandoNonQuery(String sql)
        {
            SqlCommand comando = new SqlCommand()
            {
                Connection = conexion,
                CommandText = sql
            };
            int resultado;
            try
            {
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                resultado = -1;
            }
            return resultado;
        }
    }
}
