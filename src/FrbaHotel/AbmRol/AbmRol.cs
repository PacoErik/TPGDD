﻿using System;
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
    public partial class AbmRol : Form
    {
        public AbmRol()
        {
            InitializeComponent();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new AltaRol();
            f1.ShowDialog();
        }

        private void baja_Click(object sender, EventArgs e)
        {

        }

        private void modificacion_Click(object sender, EventArgs e)
        {

        }

        private void listado_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {

        }
    }
}