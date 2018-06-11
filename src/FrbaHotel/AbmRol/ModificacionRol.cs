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
    public partial class ModificacionRol : Form
    {
        private DataTable roles_dt;

        public ModificacionRol()
        {
            roles_dt = new DataTable();
            InitializeComponent();
            roles.DataSource = roles_dt;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            habilitado.Checked = true;
            roles_dt.Clear();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            roles_dt.Clear();
            UtilesSQL.llenarTabla(roles_dt, "SELECT rol_id Rol, rol_nombre Nombre, (CASE WHEN rol_activo = 1 THEN \'Habilitado\' ELSE \'Deshabilitado\' END) Estado, NULL Modificar FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre LIKE \'%" + nombre.Text + "%\' AND rol_activo = " + (habilitado.Checked ? "1" : "0") + "");
        }

        private void roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rol = roles.Rows[e.RowIndex];
                if (e.ColumnIndex == 3 && MessageBox.Show("¿Está seguro de que quiere modificar el rol?", "Modificar el rol", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable funcionalidades_dt = new DataTable();
                    UtilesSQL.llenarTabla(funcionalidades_dt, "SELECT func_id, func_detalle FROM DERROCHADORES_DE_PAPEL.Funcionalidad JOIN DERROCHADORES_DE_PAPEL.FuncionalidadXRol ON func_id = fxro_funcionalidad AND fxro_rol = " + rol.Cells["Rol"].Value.ToString());
                    new ModificacionRolElegido(rol.Cells["Rol"].Value.ToString(), rol.Cells["Nombre"].Value.ToString(), rol.Cells["Estado"].Value.ToString(), funcionalidades_dt).Show();
                    roles_dt.Clear();
                }   
            }
        }
    }
}
