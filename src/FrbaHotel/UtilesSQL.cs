using System;
using System.Collections.Generic;
using System.Data;
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
        public static void ejecutarComandoNonQuery(SqlCommand com)
        {
            com.ExecuteNonQuery();
        }
        public static void llenarTabla(DataTable tabla, String sql)
        {
            SqlDataAdapter sql_adapter = new SqlDataAdapter(sql, conexion);
            sql_adapter.Fill(tabla);
        }
        public static SqlCommand crearCommand(string com)
        {
            return new SqlCommand(com, conexion);
        }
        public static SqlDataAdapter crearDataAdapter(string com)
        {
            return new SqlDataAdapter(com, conexion);
        }
    }
}
