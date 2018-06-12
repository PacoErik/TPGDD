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

namespace FrbaHotel.AbmRol
{
    public partial class ModificacionRolElegido : Form
    {
        DataTable actuales_dt;
        DataTable disponibles_dt;
        String id_inicial;
        String nombre_inicial;
        String estado_inicial;
        DataTable funcionalidades_inicial;
        DataTable funcionalidades;
            
        public ModificacionRolElegido(String idRol, String nombre, String estado)
        {
            InitializeComponent();

            id_inicial = idRol;
            nombre_inicial = nombre; 
            textBox1.Text = nombre;
            estado_inicial = estado; 

            habilitado.Checked = estado.Equals("Habilitado");

            funcionalidades = new DataTable();
            UtilesSQL.llenarTabla(funcionalidades, "SELECT * FROM DERROCHADORES_DE_PAPEL.Funcionalidad WHERE func_detalle != \'ABM DE USUARIO\'" );
            funcionalidades_inicial = new DataTable();
            UtilesSQL.llenarTabla(funcionalidades_inicial, "SELECT func_id, func_detalle FROM DERROCHADORES_DE_PAPEL.Funcionalidad JOIN DERROCHADORES_DE_PAPEL.FuncionalidadXRol ON func_id = fxro_funcionalidad AND fxro_rol = "+idRol);

            actuales_dt = new DataTable();
            disponibles_dt = new DataTable();

            actuales.DataSource = actuales_dt;
            disponibles.DataSource = disponibles_dt;

            inicializarFuncionalidades();
        }

        private void inicializarFuncionalidades()
        {
            actuales_dt = funcionalidades_inicial.Copy();
            actuales.DataSource = actuales_dt;

            disponibles_dt = funcionalidades_inicial.Clone();
            disponibles_dt.Clear();

            for (int indice = 0; indice < funcionalidades.Rows.Count - 1; indice++)
            {
                if (!dataTableContiene(funcionalidades.Rows[indice], funcionalidades_inicial)) 
                {
                    disponibles_dt.Rows.Add(funcionalidades.Rows[indice].ItemArray);
                }
            }
            disponibles.DataSource = disponibles_dt;
        }

        private bool dataTableContiene(DataRow fila, DataTable tabla)
        {
            foreach (DataRow otraFila in tabla.Rows) 
            {
                if (otraFila[0].ToString().Equals(fila[0].ToString())) return true;
            }
            return false;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            habilitado.Checked = estado_inicial.Equals("Habilitado");
            inicializarFuncionalidades();
            textBox1.Text = nombre_inicial;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //Se validan los campos
            NotificadorErrores errores = new NotificadorErrores();
            if (textBox1.TextLength == 0)
                errores.agregarError("El rol no puede contener un nombre vacío");
            if (textBox1.TextLength > 50)
                errores.agregarError("El nombre del rol no puede superar los 50 caracteres");
            if (actuales_dt.Rows.Count == 0)
                errores.agregarError("Debe elegir al menos una funcionalidad");
            
            if (errores.hayError())
            {
                errores.mostrarErrores();
                return;
            }

            int resultado;

            //Se actualiza el nombre
            if (!textBox1.Text.Equals(nombre_inicial))
            {
                resultado = UtilesSQL.ejecutarComandoNonQuery("UPDATE DERROCHADORES_DE_PAPEL.Rol SET rol_nombre = \'" + textBox1.Text + "\'" + "WHERE rol_id = " + id_inicial);
                if (resultado <= 0)
                {
                    MessageBox.Show("Hubo un error al intentar modificar el rol, elija otro nombre");
                    return;
                }
            }

            //Se actualiza el estado
            if (habilitado.Checked != estado_inicial.Equals("Habilitado"))
            {
                resultado = UtilesSQL.ejecutarComandoNonQuery("UPDATE DERROCHADORES_DE_PAPEL.Rol SET rol_activo = " + (habilitado.Checked ? "1":"0") + "WHERE rol_id = "+id_inicial);
                if (resultado <= 0)
                {
                    MessageBox.Show("Hubo un error al intentar modificar el estado del rol");
                    return;
                }
            }

            //Se agregan las funcionalidades elegidas para el ROL y se borran las removidas.
            foreach (DataRow fila in funcionalidades.Rows)
            {
                if (!dataTableContiene(fila, funcionalidades_inicial) && dataTableContiene(fila, actuales_dt))
                {
                    // Es una funcionalidad nueva
                    resultado = UtilesSQL.ejecutarComandoNonQuery("INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol) VALUES ("+fila["func_id"].ToString()+","+id_inicial+")");
                    if (resultado <= 0)
                    {
                        MessageBox.Show("Hubo un error al intentar agregar la funcionalidad "+fila["func_detalle"].ToString());
                        return;
                    }
                }
                else if (dataTableContiene(fila, funcionalidades_inicial) && !dataTableContiene(fila, actuales_dt)) 
                {
                    // Es una funcionalidad removida
                    resultado = UtilesSQL.ejecutarComandoNonQuery("DELETE FROM DERROCHADORES_DE_PAPEL.FuncionalidadXRol WHERE fxro_rol = " + id_inicial + " AND fxro_funcionalidad = " + fila["func_id"].ToString());
                   
                    if (resultado <= 0)
                    {
                        MessageBox.Show("Hubo un error al intentar quitar la funcionalidad " + fila["func_detalle"].ToString());
                        return;
                    }
                }
            }

            MessageBox.Show("Se modificó el rol con éxito");

            this.Close();
        }

        private void elegidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void disponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && disponibles_dt.Rows.Count > 0)
            {
                DataRow funcionalidad = ((DataRowView)disponibles.Rows[e.RowIndex].DataBoundItem).Row;
                actuales_dt.Rows.Add(funcionalidad.ItemArray);
                disponibles_dt.Rows.Remove(funcionalidad);
            }
        }

        private void actuales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && actuales_dt.Rows.Count > 0)
            {
                DataRow funcionalidad = ((DataRowView)actuales.Rows[e.RowIndex].DataBoundItem).Row;
                disponibles_dt.Rows.Add(funcionalidad.ItemArray);
                actuales_dt.Rows.Remove(funcionalidad);
            }
        }
    }
}
