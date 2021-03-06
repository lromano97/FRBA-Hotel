﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class CrearHotel : Form
    {
        private void MostrarDG()
        {
            string consulta_regimenes = "select regi_codigo as 'Codigo', regi_descripcion as 'Regimen', regi_precio_base as 'Precio base' from CAIA_UNLIMITED.Regimen";
            DataSet ds = DataBase.realizarConsulta(consulta_regimenes);
            dgRegimenes.DataSource = ds.Tables[0];
        }
        private bool Completo()
        {
            lblCiudad.Visible = false;
            lblDireccion.Visible = false;
            lblEstrellas.Visible = false;
            lblMail.Visible = false;
            lblNombreHotel.Visible = false;
            lblPais.Visible = false;
            lblTelefono.Visible = false;
            lblRegimenes.Visible = false;
            lblFecha.Visible = false;
            int aux;
            if (txtNombreHotel.Text.Trim() == "")
            {
                lblNombreHotel.Visible = true;
            }
            else if (txtMail.Text.Trim() == "")
            {
                lblMail.Visible = true;
            }
            else if (!formatoMailCorrecto())
            {
                lblMail.Visible = true;
                return false;
            }
            else if (txtTelefono.Text.Trim() == "" || !int.TryParse(txtTelefono.Text.Trim(), out aux))
            {
                lblTelefono.Visible = true;
                MessageBox.Show("El numero de telefono debe ser un numero", "Campo invalido", MessageBoxButtons.OK);
                return false;
            }
            else if (txtDireccion.Text.Trim() == "")
            {
                lblDireccion.Visible = true;
            }
            else if (txtNumero.Text.Trim() == "" || !int.TryParse(txtNumero.Text.Trim(), out aux))
            {
                lblDireccion.Visible = true;
                MessageBox.Show("El numero de calle debe ser un numero", "Campo invalido", MessageBoxButtons.OK);
                return false;
            }
            else if (txtCiudad.Text.Trim() == "")
            {
                lblCiudad.Visible = true;
            }
            else if (txtPais.Text.Trim() == "")
            {
                lblPais.Visible = true;
            }
            else if (dgRegimenes.SelectedRows.Count == 0)
            {
                lblRegimenes.Visible = true;
            }
            else if (dtFechaCreacion.Value > DataBase.fechaSistema())
            {
                lblFecha.Visible = true;
            }
            else
            {
                return true;
            }
            MessageBox.Show("Por favor complete los campos que quedaron vacios o erroneos.", "Campos incompletos", MessageBoxButtons.OK);
            return false;
        }

        private bool formatoMailCorrecto()
        {
            Regex expEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!expEmail.IsMatch(txtMail.Text.Trim()))
            {
                MessageBox.Show("Formato de mail ingresado incorrecto", "Campos erroneos", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }


        public CrearHotel()
        {
            InitializeComponent();
            ocultarErrores();
            MostrarDG();
            dtFechaCreacion.Value = DataBase.fechaSistema();
            dgRegimenes.AllowUserToAddRows = false;
            cbEstrellas.SelectedIndex = 0;
        }

        private void ocultarErrores()
        {
            lblCiudad.Visible = false;
            lblDireccion.Visible = false;
            lblEstrellas.Visible = false;
            lblMail.Visible = false;
            lblNombreHotel.Visible = false;
            lblPais.Visible = false;
            lblTelefono.Visible = false;
            lblRegimenes.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Completo())
            {
                string cant_estrellas = cbEstrellas.SelectedItem.ToString().Split(' ')[0];
                string existencia_direccion = String.Format("select * from CAIA_UNLIMITED.Direccion where dire_dom_calle='{0}' and dire_nro_calle={1} and dire_ciudad='{2}' and dire_pais='{3}'", txtDireccion.Text.Trim(), txtNumero.Text.Trim(), txtCiudad.Text.Trim(), txtPais.Text.Trim());
                if (DataBase.realizarConsulta(existencia_direccion).Tables[0].Rows.Count == 0)
                {
                    try
                    {
                        ejecutarStoredProcedure();
                        MessageBox.Show("Hotel creado correctamente.", "Creacion correcta", MessageBoxButtons.OK);
                        reiniciarVista();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo crear el hotel", "Error al crear hotel", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("La direccion ya existe.", "Error de direccion", MessageBoxButtons.OK);
                }
            }
        }

        private void ejecutarStoredProcedure()
        {
                SqlConnection db = DataBase.conectarBD();
                SqlCommand agregarHotel = new SqlCommand("CAIA_UNLIMITED.sp_AlmacenarHotel", db);
                agregarHotel.CommandType = CommandType.StoredProcedure;
                agregarHotel.Parameters.AddWithValue("@nombre_hotel", txtNombreHotel.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@estrellas", cbEstrellas.SelectedIndex + 1);
                agregarHotel.Parameters.AddWithValue("@hote_telefono", txtTelefono.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@calle", txtDireccion.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@numero_calle", Int32.Parse(txtNumero.Text.Trim()));
                agregarHotel.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@pais", txtPais.Text.Trim());
                agregarHotel.Parameters.AddWithValue("@fecha", dtFechaCreacion.Value.ToString("yyyyMMdd"));
                agregarHotel.ExecuteNonQuery();
                string id_hotel = ObtenerIDHotel();
                foreach (DataGridViewRow regimen in dgRegimenes.SelectedRows)
                {
                    SqlCommand agregarRegimenHotel = new SqlCommand("CAIA_UNLIMITED.sp_AgregarRegimenXHotel", db);
                    agregarRegimenHotel.CommandType = CommandType.StoredProcedure;
                    agregarRegimenHotel.Parameters.AddWithValue("@codigo_regimen", regimen.Cells[0].Value.ToString());
                    agregarRegimenHotel.Parameters.AddWithValue("@id_hotel", id_hotel);
                    agregarRegimenHotel.ExecuteNonQuery();
                }
                db.Close();
        }

        private void reiniciarVista()
        {
            txtNumero.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtMail.Clear();
            txtNombreHotel.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
            dtFechaCreacion.Value = DataBase.fechaSistema();
            cbEstrellas.SelectedIndex = 0;
            ocultarErrores();
        }

        private string ObtenerIDHotel()
        {
            string obtener_id_hotel = "select hote_id from CAIA_UNLIMITED.Hotel H join CAIA_UNLIMITED.Direccion D on (H.dire_id = D.dire_id) where hote_nombre ='" + txtNombreHotel.Text.Trim() + "' and hote_mail='" + txtMail.Text.Trim() +
                "' and dire_dom_calle ='" + txtDireccion.Text.Trim() + "' and dire_nro_calle =" + txtNumero.Text.Trim() + " and dire_ciudad= '" + txtCiudad.Text.Trim() + "' and dire_pais= '" + txtPais.Text.Trim() + "' and dire_telefono = " + txtTelefono.Text.Trim();
            DataSet dh = DataBase.realizarConsulta(obtener_id_hotel);
            string id_hotel = dh.Tables[0].Rows[0][0].ToString();
            return id_hotel;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            reiniciarVista();
            ocultarErrores();
        }
    }
}
