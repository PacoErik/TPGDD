using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class BajaRol : Form
    {

        DataTable roles_dt;
        DataTable funcionalidades_dt;

        public BajaRol()
        {
            roles_dt = new DataTable();
            funcionalidades_dt = new DataTable();
            InitializeComponent();
            roles.DataSource = roles_dt;
            funcionalidades.DataSource = funcionalidades_dt;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            habilitado.Checked = true;
            roles_dt.Clear();
            funcionalidades_dt.Clear();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            roles_dt.Clear();
            funcionalidades_dt.Clear();
            UtilesSQL.llenarTabla(roles_dt, "SELECT rol_id Rol, rol_nombre Nombre, (CASE WHEN rol_activo = 1 THEN \'Habilitado\' ELSE \'Deshabilitado\' END) Estado, NULL Eliminar FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre LIKE \'%" + nombre.Text + "%\' AND rol_activo = " + (habilitado.Checked ? "1" : "0") + "");
        }

        private void roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar las funcionalidades del rol cuando se hace click en el número de rol
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                funcionalidades_dt.Clear();
                UtilesSQL.llenarTabla(funcionalidades_dt, "SELECT func_id Funcionalidad, func_detalle Detalle FROM DERROCHADORES_DE_PAPEL.Funcionalidad JOIN DERROCHADORES_DE_PAPEL.FuncionalidadXRol ON fxro_funcionalidad = func_id AND fxro_rol = " + roles.Rows[e.RowIndex].Cells["Rol"].Value.ToString());
            }
            //Confirmar que el usuario quiere deshabilitar el rol cuando aprieta en la columna Eliminar
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataRow rol = ((DataRowView)roles.Rows[e.RowIndex].DataBoundItem).Row;
                String nombre_rol = rol["Nombre"].ToString();
                if (MessageBox.Show("¿Está seguro de que quiere eliminar el rol "+nombre_rol+"?", "Eliminar el rol", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = UtilesSQL.ejecutarComandoNonQuery("DERROCHADORES_DE_PAPEL.EliminarRol " + rol["Rol"].ToString());
                    if (resultado > 0)
                    {
                        funcionalidades_dt.Clear();
                        roles_dt.Rows.Remove(rol);
                        MessageBox.Show("Se eliminó satisfactoriamente el rol " + nombre_rol);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el rol porque hay usuarios que dependen de él");
                    }
                }

            }
        }
    }
}
