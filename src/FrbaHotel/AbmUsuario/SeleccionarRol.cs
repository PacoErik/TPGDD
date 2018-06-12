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

namespace FrbaHotel.AbmUsuario
{
    public partial class SeleccionarRol : Form
    {
        public String rol { get; set; }
        DataTable dtRol = new DataTable();

        public SeleccionarRol(DataTable dtRolesAsignados)
        {
            InitializeComponent();

            SqlCommand command2 = UtilesSQL.crearCommand("SELECT rol_nombre FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre NOT IN (SELECT rol_nombre  from DERROCHADORES_DE_PAPEL.Rol WHERE rol_nombre = 'ADMINISTRADOR GENERAL' OR rol_nombre = 'GUEST')");
            SqlDataReader reader2 = command2.ExecuteReader();
            dtRol.Columns.Add("rol_nombre", typeof(string));
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dtRol.Columns["rol_nombre"];
            dtRol.PrimaryKey = keyColumns;
            dtRol.Load(reader2);

            
            foreach (DataRow row in dtRolesAsignados.Rows)
            {
                for (int i = 0; i < dtRol.Rows.Count; i++)
                {
                    if (dtRol.Rows[i][0].ToString() == row[0].ToString())
                    {
                        dtRol.Rows.RemoveAt(i);
                    }
                }
            }

            comboBoxRoles.ValueMember = "rol_nombre";
            comboBoxRoles.DataSource = dtRol;

            if (comboBoxRoles.Items.Count == 0)
            {
                MessageBox.Show("No hay mas roles para agregar");
                this.Close();
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            rol = comboBoxRoles.SelectedValue.ToString();
            this.Close();
        }
    }
}
