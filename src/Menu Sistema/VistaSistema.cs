﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.GenerarModificacionReserva;
using FrbaHotel.Login;
using FrbaHotel.AbmUsuario;
using FrbaHotel.AbmRol;
using FrbaHotel.AbmHotel;
using FrbaHotel.AbmHabitacion;
using FrbaHotel.AbmFacturacion;
using FrbaHotel.ListadoEstadistico;
using FrbaHotel.CancelarReserva;
using FrbaHotel.AbmCliente;
using FrbaHotel.RegistrarConsumible;
using FrbaHotel.RegistrarEstadia;
using System.Data.SqlClient;


namespace FrbaHotel.Menu_Sistema
{
    public partial class VistaSistema : Form
    {
        decimal idHotel;
        decimal codigoRol;
        string nombreUsuario;
        bool guest = false;

        public VistaSistema(decimal _idHotel, decimal _codigoRol, string _nombreUsuario)
        {
            InitializeComponent();
            txtFechaSistema.Text = Convert.ToString(DataBase.fechaSistema());
            this.idHotel = _idHotel;
            this.codigoRol = _codigoRol;
            this.nombreUsuario = _nombreUsuario;

            string queryFuncionalidadesUsuario = string.Format("SELECT f.func_detalle as Funcionalidades FROM CAIA_UNLIMITED.Funcionalidad f JOIN CAIA_UNLIMITED.Funcionalidad_X_Rol fr on fr.func_rol_codigo_func = f.func_codigo WHERE fr.func_rol_codigo_rol = '{0}'", _codigoRol);
            DataSet dsFuncionalidadesUsuario = DataBase.realizarConsulta(queryFuncionalidadesUsuario);

            foreach (DataRow unaFuncionalidad in dsFuncionalidadesUsuario.Tables[0].Rows)
            {
                if (unaFuncionalidad["Funcionalidades"].ToString() == "RESERVA")
                {
                    stripReserva.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_ROL")
                {
                    stripRol.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_USUARIO")
                {
                    stripUsuario.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_HOTEL")
                {
                    stripHotel.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_HABITACION")
                {
                    stripHabitacion.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "LISTADO_ESTADISTICO")
                {
                    stripListado.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_CLIENTE")
                {
                    stripHuesped.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ESTADIA")
                {
                    stripEstadia.Visible = true;
                }                
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "CONSUMIBLES")
                {
                    stripConsumibles.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "CANCELAR_RESERVA")
                {
                    stripCancelar_Reserva.Visible = true;
                }
            }
        }

        public VistaSistema()
        {
            InitializeComponent();
            string rol = "Guest";
            string queryFuncionalidadesUsuario = string.Format("SELECT f.func_detalle as Funcionalidades FROM CAIA_UNLIMITED.Funcionalidad f JOIN CAIA_UNLIMITED.Funcionalidad_X_Rol fr on fr.func_rol_codigo_func = f.func_codigo JOIN CAIA_UNLIMITED.Rol ro on (fr.func_rol_codigo_rol = ro.rol_codigo) WHERE ro.rol_nombre = '{0}'",rol);
            DataSet dsFuncionalidadesUsuario = DataBase.realizarConsulta(queryFuncionalidadesUsuario);

            foreach (DataRow unaFuncionalidad in dsFuncionalidadesUsuario.Tables[0].Rows)
            {
                if (unaFuncionalidad["Funcionalidades"].ToString() == "RESERVA")
                {
                    stripReserva.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_ROL")
                {
                    stripRol.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_USUARIO")
                {
                    stripUsuario.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_HOTEL")
                {
                    stripHotel.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_HABITACION")
                {
                    stripHabitacion.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "LISTADO_ESTADISTICO")
                {
                    stripListado.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ABM_CLIENTE")
                {
                    stripHuesped.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "ESTADIA")
                {
                    stripEstadia.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "CONSUMIBLES")
                {
                    stripConsumibles.Visible = true;
                }
                else if (unaFuncionalidad["Funcionalidades"].ToString() == "CANCELAR_RESERVA")
                {
                    stripCancelar_Reserva.Visible = true;
                }
            }
            this.guest = true;
            txtFechaSistema.Text = Convert.ToString(DataBase.fechaSistema());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void generarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!guest)
            {
                new GenerarReserva(this.idHotel,this.nombreUsuario).ShowDialog();
                this.Show();
            }
            else
            {
                new GenerarReserva().ShowDialog();
                this.Show();
            } 
        }

        private void modificarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!guest)
            {
                new ModificarReserva(this.idHotel,this.nombreUsuario).ShowDialog();
                this.Show();
            }
            else
            {
                new ModificarReserva().ShowDialog();
                this.Show();
            }
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUsuario(this.idHotel,this.codigoRol,this.nombreUsuario).Show();
        }

        private void cambiarMiContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cambioContraseña(this.nombreUsuario).ShowDialog();
            this.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Usuario().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void administrarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRol(this.idHotel, this.codigoRol, this.nombreUsuario).Show();  
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearHotel().ShowDialog();
            this.Show();
        }

        private void modificarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FiltrarHotel().ShowDialog();
            this.Show();
        }

        private void bajaHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaHotel().ShowDialog();
            this.Show();
        }

        private void crearHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearHabitacion(Convert.ToString(idHotel)).ShowDialog();
            this.Show();
        }

        private void bajaDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaHabitacion(Convert.ToString(idHotel)).ShowDialog();
            this.Show();
        }

        private void modificarHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuModificacion(Convert.ToString(idHotel)).ShowDialog();
            this.Show();
        }

        private void VistaSistema_Load(object sender, EventArgs e)
        {

        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuCancelarReserva().ShowDialog();
            this.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Crear().ShowDialog();
            this.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuModificarYBaja().ShowDialog();
            this.Show();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuModificarYBaja().ShowDialog();
            this.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuRegistrarEstadia(Convert.ToString(idHotel),nombreUsuario).ShowDialog();
            this.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new MenuRegistrarConsumible(Convert.ToString(idHotel)).ShowDialog();
            this.Show();
        }

        private void stripCancelar_Reserva_Click(object sender, EventArgs e)
        {
            if (!guest)
            {
                new MenuCancelarReserva(Convert.ToString(idHotel),nombreUsuario).ShowDialog();
                this.Show();
            }
            else
            {
                new MenuCancelarReserva().ShowDialog();
                this.Show();
            }
        }

        private void stripListado_Click(object sender, EventArgs e)
        {
            new PeriodoListado().ShowDialog();
            this.Show();
        }

        
    }
}
