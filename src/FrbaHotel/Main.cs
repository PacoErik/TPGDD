﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Main : Form
    {
        static String fechaDelSistema;

        public Main()
        {
            fechaDelSistema = Properties.Settings.Default["fechaDelSistema"].ToString();
            UtilesSQL.inicializar();
            InitializeComponent();
        }

        public static String fecha()
        {
            return fechaDelSistema;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Huesped_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new GenerarModificacionReserva.GenerarModificacionReserva();
            f1.ShowDialog();
            this.Show();
        }
        private void Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Login.Login(this);
            f1.ShowDialog();
            this.Show();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
