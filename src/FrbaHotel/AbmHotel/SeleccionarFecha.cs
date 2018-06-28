using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class SeleccionarFecha : Form
    {
        public string fecha { get; set; }

        public SeleccionarFecha()
        {
            InitializeComponent();
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.TodayDate = DateTime.Parse(Main.fecha());
            monthCalendar.SelectionStart = DateTime.Parse(Main.fecha());
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            fecha = monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            this.Close();
        }
    }
}
