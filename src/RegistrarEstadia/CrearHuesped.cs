﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class CrearHuesped : Form
    {
        string codigoReserva;
        public CrearHuesped(string mail, string tipo, string numero,string cod)
        {
            InitializeComponent();
            codigoReserva=cod;
            txtEmail.Text=mail;
            txtTipo_Identificacion.Text=tipo;
            txtNumero_Identificacion.Text=numero;
        }

        private bool camposCompletos()
        {
            if (txtApellido.Text.Trim() == "")
            {
                return false;
            }
            if (txtNombre.Text.Trim()=="")
            {
                return false;
            } 
            if (txtNumero_Identificacion.Text.Trim()=="")
            {
                return false;
            } 
            if (txtTipo_Identificacion.Text.Trim()=="")
            {
                return false;
            } 
            if (txtEmail.Text.Trim()=="")
            {
                return false;
            } 
          
            if (txtCalle.Text.Trim()=="")
            {
                return false;
            } 
            if (txtCalle_Nro.Text.Trim()=="")
            {
                return false;
            } 
            if (txtPiso.Text.Trim()=="")
            {
                return false;
            } 
            if (txtDpto.Text.Trim()=="")
            {
                return false;
            } 
            if (txtCiudad.Text.Trim()=="")
            {
                return false;
            }
            if (txtPais.Text.Trim()== "")
            {
                return false;
            } 
            if (txtTelefono.Text.Trim()=="")
            {
                return false;
            }
            if (txtNacimiento.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }


        private void RestaurarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumero_Identificacion.Clear();
            txtTipo_Identificacion.Clear();
            txtEmail.Clear();
            txtNacionalidad.Clear();
            txtCalle.Clear();
            txtCalle_Nro.Clear();
            txtPiso.Clear();
            txtDpto.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtPais.Clear();
            txtNacimiento.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {

                string email_ingresado = String.Format("SELECT hues_mail FROM CAIA_UNLIMITED.Huesped  where hues_mail='{0}'", txtEmail.Text.Trim());
                string documento_ingresado = String.Format("SELECT hues_documento FROM CAIA_UNLIMITED.Huesped WHERE hues_documento = '{0}'  AND hues_documento_tipo = '{1}'",txtNumero_Identificacion.Text.Trim(), txtTipo_Identificacion.Text.Trim());
               
                if (DataBase.realizarConsulta(email_ingresado).Tables[0].Rows.Count == 0)
                {
                    if (DataBase.realizarConsulta(documento_ingresado).Tables[0].Rows.Count == 0)
                    {
                        ejecutarStoredProcedureCrear();
                        MessageBox.Show("Cliente " + txtNombre + " ingresado correctamente.");
                        this.Hide();
                        new Registrar(codigoReserva).Show();
                    }else
                    {
                        MessageBox.Show("El tipo y numero de identificacion ingresado ya existe.");
                    }
                }else
                {
                    MessageBox.Show("El mail ingresado ya existe.");
                }
                                
            }
            else
            {
                MessageBox.Show("Complete todo los campos");
            }


        }

        private void ejecutarStoredProcedureCrear()
        {
            SqlConnection db = DataBase.conectarBD();
            SqlCommand crearCliente = new SqlCommand("sp_CrearHuesped", db);
            crearCliente.CommandType = CommandType.StoredProcedure;
            crearCliente.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
            crearCliente.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
            crearCliente.Parameters.AddWithValue("@documento", txtNumero_Identificacion.Text.Trim());
            crearCliente.Parameters.AddWithValue("@tipo", txtTipo_Identificacion.Text.Trim());
            crearCliente.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
            crearCliente.Parameters.AddWithValue("@fecha_nacimiento", DateTime.Parse(txtNacimiento.Text));
            crearCliente.Parameters.AddWithValue("@nacionalidad", txtNacionalidad.Text.Trim());
            crearCliente.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
            crearCliente.Parameters.AddWithValue("@calle_nro", txtCalle_Nro.Text.Trim());
            crearCliente.Parameters.AddWithValue("@piso", txtPiso.Text.Trim());
            crearCliente.Parameters.AddWithValue("@dpto", txtDpto.Text.Trim());
            crearCliente.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
            crearCliente.Parameters.AddWithValue("@pais", txtPais.Text.Trim());
            crearCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
            crearCliente.ExecuteNonQuery();
            db.Close();
        }  
                

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtNacimiento.Text = calendario.SelectionStart.ToShortDateString();
        }
    }
    }
}