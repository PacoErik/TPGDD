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
    public partial class AltaRol : Form
    {
        DataTable funcionalidades;
            
        public AltaRol()
        {
            InitializeComponent();

            funcionalidades = new DataTable();
            UtilesSQL.llenarTabla(funcionalidades, "SELECT * FROM DERROCHADORES_DE_PAPEL.Funcionalidad" );

            inicializarFuncionalidades();
        }

        private void inicializarFuncionalidades()
        {
            disponibles.Items.Clear();
            elegidas.Items.Clear();

            for (int indice = 0; indice < funcionalidades.Rows.Count - 1; indice++)
            {
                if (!funcionalidades.Rows[indice]["func_detalle"].Equals("ABM DE USUARIO"))
                {
                    disponibles.Items.Add(funcionalidades.Rows[indice]["func_detalle"]);
                }

            }
        }

        private String stringFuncionalidades()
        {
            //Aplana las funcionalidades a un texto con cada funcionalidad separada por coma
            //con el fin de ser utilizada en una consulta SQL con el operador IN
            String textoFuncionalidades = "\'"+funcionalidades.Rows[0]["func_detalle"]+"\'";
            for (int i = 0; i < funcionalidades.Rows.Count; i++)
            {
                String detalle = funcionalidades.Rows[i]["func_detalle"].ToString();
                if (elegidas.Items.Contains(detalle))
                {
                    textoFuncionalidades += ",\'" + detalle + "\'";
                }
            }
            return textoFuncionalidades;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            habilitado.Checked = true;
            inicializarFuncionalidades();
            textBox1.Clear();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //Se validan los campos
            NotificadorErrores errores = new NotificadorErrores();
            if (textBox1.TextLength == 0)
                errores.agregarError("El rol no puede contener un nombre vacío");
            if (textBox1.TextLength > 50)
                errores.agregarError("El nombre del rol no puede superar los 50 caracteres");
            if (elegidas.Items.Count == 0)
                errores.agregarError("Debe elegir al menos una funcionalidad");

            if (errores.hayError())
            {
                errores.mostrarErrores();
                return;
            }

            //Se agrega el ROL
            int resultado = UtilesSQL.ejecutarComandoNonQuery("INSERT INTO DERROCHADORES_DE_PAPEL.Rol (rol_nombre, rol_activo)" 
                                                               +" VALUES (\'"+textBox1.Text+"\',"+(habilitado.Checked ? "1":"0")+")");
            if (resultado <= 0) 
            {
                MessageBox.Show("Hubo un error al intentar agregar el rol, elija otro nombre");
                return;
            }

            //Se agregan las funcionalidades elegidas para el ROL
            resultado = UtilesSQL.ejecutarComandoNonQuery("INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol)"
	                                                       +" SELECT func_id, rol_id"
	                                                       +" FROM DERROCHADORES_DE_PAPEL.Funcionalidad, DERROCHADORES_DE_PAPEL.Rol"
	                                                       +" WHERE rol_nombre = \'"+textBox1.Text+"\' AND func_detalle IN ("+stringFuncionalidades()+")");
            if (resultado <= 0)
            {
                MessageBox.Show("Hubo un error al intentar agregar funcionalidades");
                return;
            }

            MessageBox.Show("Se agregó el rol con éxito");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //La funcionalidad elegida se saca de las disponibles y se la pone en las elegidas
            elegidas.Items.Add(disponibles.SelectedItem);
            disponibles.Items.Remove(disponibles.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Viceversa de la función anterior
            disponibles.Items.Add(elegidas.SelectedItem);
            elegidas.Items.Remove(elegidas.SelectedItem);
        }

        private void elegidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
