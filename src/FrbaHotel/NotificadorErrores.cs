using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class NotificadorErrores
    {
        String errores;
        public NotificadorErrores() 
        {
            errores = "";
        }
        public void agregarError(String textoError)
        {
            errores += "\n- " + textoError;
        }
        public void mostrarErrores()
        {
            MessageBox.Show("Debe corregir lo siguiente:"+errores);
        }
        public bool hayError()
        {
            return !errores.Equals("");
        }
    }
}
