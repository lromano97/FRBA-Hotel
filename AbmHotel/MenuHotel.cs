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
    public partial class MenuHotel : Form
    {
        public MenuHotel()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearHotel().Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}