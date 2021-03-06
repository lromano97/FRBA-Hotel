﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class BajaHabitacion : Form
    {
        string hotel_id;
        private void MostrarDG()
        {
            string nueva_consulta = "select habi_numero as 'Numero de habitacion', habi_piso as 'Piso', habi_frente 'Ubicacion', habi_habilitado as 'Habilitada' from CAIA_UNLIMITED.Habitacion where hote_id=" + hotel_id.ToString();
            DataSet ds_habitaciones = DataBase.realizarConsulta(nueva_consulta);
            dgBajaHabitacion.DataSource = ds_habitaciones.Tables[0];
            dgBajaHabitacion.AllowUserToAddRows = false;
        }

        public BajaHabitacion(string hotelId)
        {
            InitializeComponent();
            hotel_id = hotelId;
            MostrarDG();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string numero_habitacion = dgBajaHabitacion.SelectedRows[0].Cells[0].Value.ToString();
            string estado_actual = dgBajaHabitacion.SelectedRows[0].Cells[3].Value.ToString();
            if (estado_actual != "False")
            {
                string baja_habitacion = "update CAIA_UNLIMITED.Habitacion set habi_habilitado = 0 where habi_numero =" + numero_habitacion + " and hote_id=" + hotel_id.ToString();
                DataBase.procedureBD(baja_habitacion);
                MessageBox.Show("Baja de habitacion exitosa.", "Baja exitosa", MessageBoxButtons.OK);
                MostrarDG();
            }
           
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string numero_habitacion = dgBajaHabitacion.SelectedRows[0].Cells[0].Value.ToString();
            string estado_actual = dgBajaHabitacion.SelectedRows[0].Cells[3].Value.ToString();
            Console.WriteLine(estado_actual);
            if (estado_actual != "True") 
            {
                string alta_habitacion = "update CAIA_UNLIMITED.Habitacion set habi_habilitado = 1 where habi_numero =" + numero_habitacion + " and hote_id=" + hotel_id.ToString();
                DataBase.procedureBD(alta_habitacion);
                MessageBox.Show("Alta de habitacion exitosa.", "Alta exitosa", MessageBoxButtons.OK);
                MostrarDG();
            }         
        }
    }
}
