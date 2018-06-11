﻿using System;
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
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            fecha = monthCalendar.SelectionEnd.ToString("yyyy-MM-dd HH:mm:ss.fff");
            this.Close();
        }
    }
}
