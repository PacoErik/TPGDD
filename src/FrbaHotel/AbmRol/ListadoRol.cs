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
    public partial class ListadoRol : Form
    {
        private DataTable roles_dt;
        private DataTable funcionalidades_dt;

        public ListadoRol()
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
            UtilesSQL.llenarTabla(roles_dt, "SELECT rol_id Rol, rol_nombre Nombre, (CASE WHEN rol_activo = 1 THEN \'Habilitado\' ELSE \'Deshabilitado\' END) Estado FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre LIKE \'%" + nombre.Text + "%\' AND rol_activo = "+(habilitado.Checked ? "1":"0")+"");
        }

        private void roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                funcionalidades_dt.Clear();
                UtilesSQL.llenarTabla(funcionalidades_dt, "SELECT func_id Funcionalidad, func_detalle Detalle FROM DERROCHADORES_DE_PAPEL.Funcionalidad JOIN DERROCHADORES_DE_PAPEL.FuncionalidadXRol ON fxro_funcionalidad = func_id AND fxro_rol = " + roles.Rows[e.RowIndex].Cells["Rol"].Value.ToString());
            }   
        }
    }
}
