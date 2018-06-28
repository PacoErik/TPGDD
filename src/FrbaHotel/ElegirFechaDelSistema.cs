using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class ElegirFechaDelSistema : Form
    {
        public ElegirFechaDelSistema()
        {
            InitializeComponent();
            String fecha = Main.fecha();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.SelectionStart = DateTime.ParseExact(fecha, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            monthCalendar1.SelectionEnd = DateTime.ParseExact(fecha, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.cambiarFechaDelSistema(monthCalendar1.SelectionStart.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            this.Close();
        }
    }
}
