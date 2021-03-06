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
using FrbaHotel.AbmFacturacion;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class MenuRegistrarConsumible : Form
    {

        string idHotelActual;
        public MenuRegistrarConsumible(string idHotel)
        {
            InitializeComponent();
            cbxConsumible.DataSource = DataBase.realizarConsulta("select * from CAIA_UNLIMITED.Consumible").Tables[0];
            cbxConsumible.DisplayMember = "cons_descripcion";
            cbxConsumible.ValueMember = "cons_descripcion";
            idHotelActual = idHotel;
        }

        private void btnAgregar_Consumible_Click(object sender, EventArgs e)
        {
            if (camposCompletosCantidad())
            {
                if (camposValidosCantidad())
                {
                    if (noEsRepetido())
                    {
                        string consumible = Convert.ToString(cbxConsumible.SelectedValue);
                        string cantidad = txtCantidad.Text;
                        string consultaPrecio = string.Format("select cons_precio from CAIA_UNLIMITED.Consumible where cons_descripcion='{0}'", consumible);
                        DataTable precioObtenido = DataBase.realizarConsulta(consultaPrecio).Tables[0];
                        string precio = precioObtenido.Rows[0][0].ToString();

                        string[] formato = { consumible, cantidad, precio };
                        var listViewItem = new ListViewItem(formato);
                        listaConsumibles.Items.Add(listViewItem);
                        cbxConsumible.SelectedIndex = 0;
                        txtCantidad.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete la cantidad de consumibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool noEsRepetido()
        {
            
            
            for (int i = 0; i < listaConsumibles.Items.Count; i++)
            {
                if(listaConsumibles.Items[i].SubItems[0].Text==Convert.ToString(cbxConsumible.SelectedValue))
                {

                    int cantidad = Convert.ToInt32(listaConsumibles.Items[i].SubItems[1].Text);
                    int cantidad2 =Convert.ToInt32(txtCantidad.Text.Trim());

                    listaConsumibles.Items[i].SubItems[1].Text = Convert.ToString(cantidad + cantidad2);
                    cbxConsumible.SelectedIndex = 0;
                    txtCantidad.Text = "";
                    return false;
                }

            }

            return true;
        }


        private bool camposCompletosCantidad()
        {
            if (txtCantidad.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private bool camposValidosCantidad()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, @"^\d+$"))
            {
                MessageBox.Show("Solo se permiten valores numericos en cantidad de consumibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }

        private void btnAgregar_Reserva_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                if (camposValidos())
                {
                    string codigoEstadiaIngresado = string.Format("select esta_codigo from CAIA_UNLIMITED.Estadia where esta_codigo='{0}'", txtCodigo_Estadia.Text);

                    if (DataBase.realizarConsulta(codigoEstadiaIngresado).Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("El codigo estadia es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string fechaEgresoEstadiaIngresado = string.Format("select esta_fecha_fin from CAIA_UNLIMITED.Estadia where esta_codigo='{0}'", txtCodigo_Estadia.Text);
                        DataTable fechaEgresoEstadia = DataBase.realizarConsulta(fechaEgresoEstadiaIngresado).Tables[0];
                        if (DBNull.Value.Equals(fechaEgresoEstadia.Rows[0][0]))
                        {
                        MessageBox.Show("Todavia no se registro el egreso de la estadia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string codigoReservaIngresado = string.Format("select rese_codigo from CAIA_UNLIMITED.Estadia where esta_codigo='{0}'", txtCodigo_Estadia.Text);
                            DataTable codigoReservObtenido = DataBase.realizarConsulta(codigoReservaIngresado).Tables[0];
                            string codigoReserva = codigoReservObtenido.Rows[0][0].ToString();

                            if (perteneceAlHotel(codigoReserva))
                            {
                                string codEstadiaIngresado = string.Format("select cons_esta_codigo_esta from CAIA_UNLIMITED.Consumible_X_Estadia where cons_esta_codigo_esta='{0}'", txtCodigo_Estadia.Text);

                                if (DataBase.realizarConsulta(codEstadiaIngresado).Tables[0].Rows.Count == 0)
                                {
                                    string habitacionesBuscadas = String.Format("select habi_rese_numero from CAIA_UNLIMITED.Habitacion_X_Reserva X join CAIA_UNLIMITED.Estadia E on (X.habi_rese_codigo = E.rese_codigo) where E.esta_codigo='{0}'", txtCodigo_Estadia.Text.Trim());
                                    DataTable habitacionesObtenidas = DataBase.realizarConsulta(habitacionesBuscadas).Tables[0];

                                    foreach (DataRow habitacion in habitacionesObtenidas.Rows)
                                    {
                                        string habitacionSeleccionada = habitacion[0].ToString();

                                        lstHabitaciones.Items.Add(habitacionSeleccionada);

                                    }
                                                                        
                                    //HOTEL
                                    string consultaDireccionHotel = string.Format("select dire_id from CAIA_UNLIMITED.Hotel where hote_id='{0}'", idHotelActual);
                                    DataTable direccionHotelObtenido = DataBase.realizarConsulta(consultaDireccionHotel).Tables[0];
                                    string idDireccionHotel = direccionHotelObtenido.Rows[0][0].ToString();

                                    string consultaDireccion = string.Format("select dire_dom_calle from CAIA_UNLIMITED.Direccion where dire_id='{0}'", idDireccionHotel);
                                    DataTable direccionObtenida = DataBase.realizarConsulta(consultaDireccion).Tables[0];
                                    string direccion = direccionObtenida.Rows[0][0].ToString();

                                    string consultaNumeroDireccion = string.Format("select dire_nro_calle from CAIA_UNLIMITED.Direccion where dire_id='{0}'", idDireccionHotel);
                                    DataTable numeroDireccionObtenida = DataBase.realizarConsulta(consultaNumeroDireccion).Tables[0];
                                    string numeroDireccion = numeroDireccionObtenida.Rows[0][0].ToString();

                                    txtHotel.Text = direccion + " " + numeroDireccion;

                                    //REGIMEN
                                    string consultaRegimenId = string.Format("select regi_descripcion from CAIA_UNLIMITED.Regimen R join CAIA_UNLIMITED.Reserva X on (R.regi_codigo = X.regi_codigo) join CAIA_UNLIMITED.Estadia E on (X.rese_codigo = E.rese_codigo) where E.esta_codigo='{0}'", txtCodigo_Estadia.Text);
                                    DataTable regimenID = DataBase.realizarConsulta(consultaRegimenId).Tables[0];
                                    txtRegimen.Text = regimenID.Rows[0][0].ToString();

                                    btnIngresar_Consumibles.Enabled = true;

                                }
                                else
                                {
                                    MessageBox.Show("Ya se registraron el/los consumible/s en esta estadia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Complete el codigo de estadia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool perteneceAlHotel(string codigoReserva)
        {
            string codigoHotel = String.Format("select habi_rese_codigo from CAIA_UNLIMITED.Habitacion_X_Reserva where habi_rese_codigo='{0}' and habi_rese_id='{1}'", codigoReserva, idHotelActual);

            if (DataBase.realizarConsulta(codigoHotel).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("El codigo de estadia no corresponde al hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private bool camposCompletos()
        {
            if (txtCodigo_Estadia.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private bool camposValidos()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodigo_Estadia.Text, @"^\d+$"))
            {
                MessageBox.Show("Solo se permiten valores numericos en el codigo de estadia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }


        private void btnEliminar_Consumible_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listaConsumibles.SelectedItems)
            {
                listaConsumibles.Items.Remove(eachItem);
            }
        }

        private void btnIngresar_Consumibles_Click(object sender, EventArgs e)
        {
            SqlConnection db = DataBase.conectarBD();

            if (listaConsumibles.Items.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que desea registrar esto/s consumible/s?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    foreach (ListViewItem eachItem in listaConsumibles.Items)
                    {

                        string consultaCodigo = string.Format("select cons_codigo from CAIA_UNLIMITED.Consumible where cons_descripcion='{0}' and cons_precio='{1}'", eachItem.SubItems[0].Text.Trim(), Convert.ToDouble(eachItem.SubItems[2].Text.Trim()));
                        DataTable codigoObtenido = DataBase.realizarConsulta(consultaCodigo).Tables[0];
                        string codigoConsumible = codigoObtenido.Rows[0][0].ToString();

                        SqlCommand registrarConsumible = new SqlCommand("CAIA_UNLIMITED.sp_RegistrarConsumible", db);
                        registrarConsumible.CommandType = CommandType.StoredProcedure;
                        registrarConsumible.Parameters.AddWithValue("@codigo_Estadia", txtCodigo_Estadia.Text.Trim());
                        registrarConsumible.Parameters.AddWithValue("@codigo_Consumible", Convert.ToInt32(codigoConsumible));
                        registrarConsumible.Parameters.AddWithValue("@cantidad", Convert.ToInt32(eachItem.SubItems[1].Text.Trim()));


                        registrarConsumible.ExecuteNonQuery();



                    }                    

                    MessageBox.Show("Consumibles registrados correctamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Facturacion(txtCodigo_Estadia.Text.Trim()).ShowDialog();
                    limpiarFormulario();
                    this.Close();
                    db.Close();
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que no desea registrar consumible/s?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    new Facturacion(txtCodigo_Estadia.Text.Trim()).ShowDialog();
                    limpiarFormulario();
                    this.Close();
                }
            }
        }

        private void limpiarFormulario()
        {
            txtCodigo_Estadia.Clear();
                    txtCantidad.Clear();
                    lstHabitaciones.Clear();
                    txtHotel.Clear();
                    txtRegimen.Clear();
                    cbxConsumible.SelectedIndex = 0;
                    listaConsumibles.Items.Clear();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo_Estadia.Clear();
            txtCantidad.Clear();
            lstHabitaciones.Clear();
            txtHotel.Clear();
            txtRegimen.Clear();
            cbxConsumible.SelectedIndex = 0;
            listaConsumibles.Items.Clear();
        }

        private void listaConsumibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
    }
}
