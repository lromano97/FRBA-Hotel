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
using System.Text.RegularExpressions;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class CrearHuesped : Form
    {
        private Registrar formulario;
        string codigoReserva;
        public CrearHuesped(string cod, Registrar formuRegistrar)
        {
            InitializeComponent();
            codigoReserva=cod;            
            btnCrear.DialogResult = DialogResult.OK;

            this.formulario = formuRegistrar;
        }

        private bool camposCompletos()
        {
            if (txtApellido.Text.Trim() == "")
            {
                lblApellido.Visible = true;
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                lblNombre.Visible = true;
                return false;
            }
            if (txtNumero_Identificacion.Text.Trim() == "")
            {
                lblIdentificacion.Visible = true;
                return false;
            }
            if (txtTipo_Identificacion.Text.Trim() == "")
            {
                lblTipo.Visible = true;
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                lblMail.Visible = true;
                return false;
            }

            if (txtCalle.Text.Trim() == "")
            {
                lblCalle.Visible = true;
                return false;
            }
            if (txtCalle_Nro.Text.Trim() == "")
            {
                lblNro.Visible = true;
                return false;
            }

            if (txtNacionalidad.Text.Trim() == "")
            {
                lblNacionalidad.Visible = true;
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
            reestrablecerLabels();
            if (camposCompletos())
            {
                if (camposValidos())
                {
                    if (formatoMailCorrecto())
                    {
                        string email_ingresado = String.Format("SELECT hues_mail FROM CAIA_UNLIMITED.Huesped  where hues_mail='{0}'", txtEmail.Text.Trim());
                        string documento_ingresado = String.Format("SELECT hues_documento FROM CAIA_UNLIMITED.Huesped WHERE hues_documento = '{0}'  AND hues_documento_tipo = '{1}'", txtNumero_Identificacion.Text.Trim(), txtTipo_Identificacion.Text.Trim());

                        if (DataBase.realizarConsulta(email_ingresado).Tables[0].Rows.Count == 0)
                        {
                            if (DataBase.realizarConsulta(documento_ingresado).Tables[0].Rows.Count == 0)
                            {
                                ejecutarStoredProcedureCrear();
                                MessageBox.Show("Cliente " + txtNombre.Text.Trim() + " ingresado correctamente.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                string[] formato = { txtEmail.Text.Trim(), txtTipo_Identificacion.Text.Trim(), txtNumero_Identificacion.Text.Trim() };
                                var listViewItem = new ListViewItem(formato);
                                formulario.listaHuesped.Items.Add(listViewItem);
                                DataSet huespedes = DataBase.realizarConsulta("select hues_mail as 'Mail', hues_nombre as 'Nombre', hues_apellido as 'Apellido', hues_documento as 'Documento', hues_documento_tipo as 'Tipo'  from CAIA_UNLIMITED.Huesped where hues_habilitado=1 ");
                                formulario.dgClientes.DataSource = huespedes.Tables[0];
                                
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("El tipo y numero de identificacion ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El mail ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Complete todo los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void reestrablecerLabels()
        {
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblIdentificacion.Visible = false;
            lblTipo.Visible = false;
            lblNacimiento.Visible = false;
            lblNacionalidad.Visible = false;
            lblMail.Visible = false;
            lblCalle.Visible = false;
            lblNro.Visible = false;
        }


        private bool formatoMailCorrecto()
        {
            Regex expEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!expEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Formato de mail ingresado incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool camposValidos()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNumero_Identificacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Solo se permiten valores numericos en el numero de identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtTelefono.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("Solo se permiten valores numericos en el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCalle_Nro.Text, @"^\d+$"))
            {
                MessageBox.Show("Solo se permiten valores numericos en el numero de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtPiso.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPiso.Text, @"^\d+$"))
                {
                    MessageBox.Show("Solo se permiten valores numericos en el piso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;

        }

        private void ejecutarStoredProcedureCrear()
        {
            SqlConnection db = DataBase.conectarBD();
            SqlCommand crearCliente = new SqlCommand("CAIA_UNLIMITED.sp_CrearHuesped", db);
            crearCliente.CommandType = CommandType.StoredProcedure;
            crearCliente.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
            crearCliente.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
            crearCliente.Parameters.AddWithValue("@documento", txtNumero_Identificacion.Text.Trim());
            crearCliente.Parameters.AddWithValue("@tipo", txtTipo_Identificacion.Text.Trim());
            crearCliente.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
            if (txtNacimiento.Text.Trim() != "")
            {
                crearCliente.Parameters.AddWithValue("@fecha_nacimiento", DateTime.Parse(txtNacimiento.Text));
            }
            else
            {
                crearCliente.Parameters.AddWithValue("@fecha_nacimiento", txtNacimiento.Text);
            }
            crearCliente.Parameters.AddWithValue("@nacionalidad", txtNacionalidad.Text.Trim());
            crearCliente.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
            crearCliente.Parameters.AddWithValue("@calle_nro", txtCalle_Nro.Text.Trim());
            if (txtPiso.Text.Trim() == "")
            {
                crearCliente.Parameters.AddWithValue("@piso", DBNull.Value);
            }
            else
            {
                crearCliente.Parameters.AddWithValue("@piso", Convert.ToInt32(txtPiso.Text.Trim()));
            }


            crearCliente.Parameters.AddWithValue("@dpto", txtDpto.Text.Trim());
            crearCliente.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
            crearCliente.Parameters.AddWithValue("@pais", txtPais.Text.Trim());
            crearCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
            crearCliente.ExecuteNonQuery();
            db.Close();
        }


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            txtNacimiento.Text = calendario.SelectionStart.ToShortDateString();
        }

    }
}
