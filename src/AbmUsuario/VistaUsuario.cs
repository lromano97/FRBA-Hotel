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
using System.Security.Cryptography;
using FrbaHotel;
using System.Globalization;
using System.Web;

namespace FrbaHotel.AbmUsuario
{
    public partial class VistaUsuario : Form
    {
        decimal idHotel;
        DataSet _dsRoles;
        DataSet _dsHoteles;

        private byte[] encryptPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding encoder = Encoding.UTF8;
                return hash.ComputeHash(encoder.GetBytes(password));
            }
        }

        private void limpiarErrores()
        {
            lblErrorBirthday.Visible = false;
            lblErrorBlock.Visible = false;
            lbllistBoxNoItem.Visible = false;
            lblErrorBlockNumber.Visible = false;
            lblErrorCity.Visible = false;
            lblErrorCountry.Visible = false;
            lblErrorDepartamento.Visible = false;
            lblErrorDocument.Visible = false;
            lblErrorDocumentType.Visible = false;
            lblErrorHotel.Visible = false;
            lblErrorNacionality.Visible = false;
            lblErrorNoField.Visible = false;
            lblErrorNoName.Visible = false;
            lblErrorNoSurname.Visible = false;
            lblErrorDateFormat.Visible = false;
            lblErrorPiso.Visible = false;
            lblErrorPW.Visible = false;
            lblErrorRole.Visible = false;
            lblErrorUser.Visible = false;
            lblBirthdayPost.Visible = false;
            lblErrorNumberValue.Visible = false;
            lblErrorMail.Visible = false;
            lblErrorTelefono.Visible = false;
        }

        private void limpiarTextBox()
        {
            textBoxBirthday.Clear();
            textBoxBlock.Clear();
            textBoxBlockNumber.Clear();
            textBoxCity.Clear();
            textBoxCountry.Clear();
            textBoxDepartamento.Clear();
            textBoxDocument.Clear();
            textBoxDocumentType.Clear();
            textBoxNacionality.Clear();
            textBoxPiso.Clear();
            textBoxPW.Clear();
            textBoxSurname.Clear();
            textBoxUser.Clear();
            textBoxUserName.Clear();
            textBoxTelefono.Clear();
            textBoxMail.Clear();
        }

        private void limpiarListBox()
        {
            listBoxHoteles.Items.Clear();
            listBoxRoles.Items.Clear();
        }

        private void cargarComboBoxRol()
        {
            string roles = "SELECT rol_codigo, rol_nombre FROM CAIA_UNLIMITED.Rol";
            DataSet dsRoles = DataBase.realizarConsulta(roles);
            this._dsRoles = dsRoles;

            foreach (DataRow unRol in dsRoles.Tables[0].Rows)
            {
                comboRoles.Items.Add((string)unRol["rol_nombre"]);
            }
            if (comboRoles.Items.Count > 0)
            {
                comboRoles.SelectedIndex = 0;
            }
        }

        private void cargarComboBoxHotel()
        {
            string hoteles = "SELECT hote_id, CONCAT(hote_id, '-', hote_nombre) as Hotel FROM CAIA_UNLIMITED.Hotel";
            DataSet dsHoteles = DataBase.realizarConsulta(hoteles);
            this._dsHoteles = dsHoteles;

            foreach (DataRow unHotel in dsHoteles.Tables[0].Rows)
            {
                comboBoxHoteles.Items.Add((string)unHotel["Hotel"]);
            }
            if (comboBoxHoteles.Items.Count > 0)
            {
                comboBoxHoteles.SelectedIndex = 0;
            }
        }
        
        public VistaUsuario(decimal _idHotel)
        {
            InitializeComponent();
            this.idHotel = _idHotel;
            lblBloqMayus.Visible = false;
            limpiarErrores();
            cargarComboBoxRol();
            cargarComboBoxHotel();
            string viewModificacion = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id", this.idHotel);
            DataSet dsViewModificacion = DataBase.realizarConsulta(viewModificacion);
            dataGridViewModificarUsuarios.DataSource = dsViewModificacion.Tables[0];
            string viewEliminar = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id WHERE u.usur_habilitado = 1", this.idHotel);
            DataSet dsViewEliminar = DataBase.realizarConsulta(viewEliminar);
            dataGridViewEliminarUsuarios.DataSource = dsViewEliminar.Tables[0];
            DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            botonModificar.HeaderText = "Seleccionar";
            botonModificar.Text = "            Modificar          ";
            botonModificar.UseColumnTextForButtonValue = true;
            dataGridViewModificarUsuarios.Columns.Add(botonModificar);
            DataGridViewButtonColumn botonEliminar = new DataGridViewButtonColumn();
            botonEliminar.HeaderText = "Seleccionar";
            botonEliminar.Text = "            Eliminar          ";
            botonEliminar.UseColumnTextForButtonValue = true;
            dataGridViewEliminarUsuarios.Columns.Add(botonEliminar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboRoles.SelectedItem != null)
            {
                listBoxRoles.Items.Add(comboRoles.SelectedItem);
                listBoxRoles.SelectedIndex = 0;
                comboRoles.Items.Remove(comboRoles.SelectedItem);
                if (comboRoles.Items.Count > 0)
                    comboRoles.SelectedIndex = 0;
                else
                    comboRoles.ResetText();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxBirthday.Text = monthCalendar.SelectionStart.ToShortDateString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarErrores();
            limpiarTextBox();
            limpiarListBox();
            cargarComboBoxRol();
            cargarComboBoxHotel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonQuitarRol_Click(object sender, EventArgs e)
        {
            if (listBoxRoles.SelectedItem != null)
            {
                comboRoles.Items.Add(listBoxRoles.SelectedItem);
                comboRoles.Sorted = true;
                listBoxRoles.Items.Remove(listBoxRoles.SelectedItem);
                comboRoles.SelectedIndex = 0;
                if (listBoxRoles.Items.Count > 0)
                    listBoxRoles.SelectedIndex = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPW_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblBloqMayus.Visible = true;
            }
            else
            {
                lblBloqMayus.Visible = false;
            }
        }

        private void buttonAgregarHotel_Click(object sender, EventArgs e)
        {
            if (comboBoxHoteles.SelectedItem != null)
            {
                listBoxHoteles.Items.Add(comboBoxHoteles.SelectedItem);
                listBoxHoteles.SelectedIndex = 0;
                comboBoxHoteles.Items.Remove(comboBoxHoteles.SelectedItem);
                if (comboBoxHoteles.Items.Count > 0)
                    comboBoxHoteles.SelectedIndex = 0;
                else
                    comboBoxHoteles.ResetText();
            }
        }

        private void buttonQuitarHotel_Click(object sender, EventArgs e)
        {
            if (listBoxHoteles.SelectedItem != null)
            {
                comboBoxHoteles.Items.Add(listBoxHoteles.SelectedItem);
                comboBoxHoteles.Sorted = true;
                listBoxHoteles.Items.Remove(listBoxHoteles.SelectedItem);
                comboBoxHoteles.SelectedIndex = 0;
                if (listBoxHoteles.Items.Count > 0)
                    listBoxHoteles.SelectedIndex = 0;
            }
        }

        private void comboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            limpiarErrores();

            DateTime Result;
            int parsedValue;
            DateTimeFormatInfo info = new DateTimeFormatInfo ( );
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture ( "en-US" );
            info.ShortDatePattern = "dd/MM/yyyy";
            if ( !(DateTime.TryParse ( textBoxBirthday.Text.Trim(), info, DateTimeStyles.None, out Result )) )
            {
                lblErrorDateFormat.Visible = true;
                lblErrorBirthday.Visible = true;
            }
            else if (!int.TryParse(textBoxDocument.Text.Trim(), out parsedValue))
            {
                lblErrorNumberValue.Visible = true;
                lblErrorDocument.Visible = true;
            }
            else if (listBoxHoteles.Items.Count == 0)
            {
                lbllistBoxNoItem.Visible = true;
                lblErrorHotel.Visible = true;
            }
            else if ((DateTime.Compare(DateTime.Now, DateTime.Parse(textBoxBirthday.Text.Trim())))<=0)
            {
                lblErrorBirthday.Visible = true;
                lblBirthdayPost.Visible = true;
            }
            else if (listBoxRoles.Items.Count == 0)
            {
                lbllistBoxNoItem.Visible = true;
                lblErrorRole.Visible = true;
            }
            else if (!int.TryParse(textBoxBlockNumber.Text.Trim(), out parsedValue))
            {
                lblErrorNumberValue.Visible = true;
                lblErrorBlockNumber.Visible = true;
            }
            else if (textBoxPiso.Text != "" && (!int.TryParse(textBoxPiso.Text.Trim(), out parsedValue)))
            {
                lblErrorNumberValue.Visible = true;
                lblErrorPiso.Visible = true;
            }
            else if (textBoxUserName.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorNoName.Visible = true;
            }
            else if (textBoxPW.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorPW.Visible = true;
            }
            else if (textBoxMail.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorMail.Visible = true;
            }
            else if (textBoxBlock.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorBlock.Visible = true;
            }
            else if (textBoxBlockNumber.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorBlockNumber.Visible = true;
            }
            else if (textBoxUser.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorUser.Visible = true;
            }
            else if (textBoxSurname.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorNoSurname.Visible = true;
            }
            else if (textBoxNacionality.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorNacionality.Visible = true;
            }
            else if (textBoxBirthday.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorBirthday.Visible = true;
            }
            else if (textBoxDocument.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorDocument.Visible = true;
            }
            else if (textBoxDocumentType.Text == "")
            {
                lblErrorNoField.Visible = true;
                lblErrorDocumentType.Visible = true;
            }
            else
            {
                string usuarioExistente = string.Format("SELECT COUNT(*) FROM CAIA_UNLIMITED.Usuario WHERE usur_username = '{0}'", textBoxUser.Text.Trim());

                SqlConnection connection = DataBase.conectarBD();
                SqlCommand commUser = new SqlCommand(usuarioExistente, connection);
                Int32 countUsuarios = Convert.ToInt32(commUser.ExecuteScalar());
                if (countUsuarios > 0)
                {
                    connection.Close();
                    MessageBox.Show("Ya existe un nombre de usuario con el nombre indicado. Intente con otro nombre.");
                    lblErrorUser.Visible = true;
                }
                else
                {
                    string datosExistentes = string.Format("SELECT COUNT(*) FROM CAIA_UNLIMITED.Huesped WHERE hues_mail = '{0}' AND hues_documento = '{1}'", textBoxMail.Text.Trim(), textBoxDocument.Text.Trim());
                    SqlCommand commDatos = new SqlCommand(datosExistentes, connection);
                    Int32 countDatos = Convert.ToInt32(commDatos.ExecuteScalar());
                    connection.Close();

                    if (countDatos > 0)
                    {
                        MessageBox.Show("Ya existe un mail y documento especificados. Intente con otros datos.");
                        lblErrorMail.Visible = true;
                        lblErrorDocument.Visible = true;
                    }
                    else
                    {
                        RolitiesCollection rc = new RolitiesCollection();
                        foreach (string rol in listBoxRoles.Items)
                        {
                            for (int i = 0; i < this._dsRoles.Tables[0].Rows.Count; i++)
                            {
                                if (((string)(_dsRoles.Tables[0].Rows[i]["rol_nombre"])) == rol)
                                {
                                    rc.Add(new Rolities { Roles = ((decimal)(this._dsRoles.Tables[0].Rows[i]["rol_codigo"])) });
                                }
                            }
                        }

                        HotelitiesCollection hc = new HotelitiesCollection();
                        foreach (string hotel in listBoxHoteles.Items)
                        {
                            for (int i = 0; i < this._dsHoteles.Tables[0].Rows.Count; i++)
                            {

                                if (((string)(_dsHoteles.Tables[0].Rows[i]["Hotel"])) == hotel)
                                {
                                    hc.Add(new Hotelities { Hoteles = ((decimal)(this._dsHoteles.Tables[0].Rows[i]["hote_id"])) });
                                }
                            }
                        }

                        try
                        {
                            SqlConnection createConnection = DataBase.conectarBD();
                            SqlCommand insertCommand = new SqlCommand("[CAIA_UNLIMITED].sp_CrearUsuarios", createConnection);
                            insertCommand.CommandType = CommandType.StoredProcedure;
                            insertCommand.Parameters.AddWithValue("@username", textBoxUser.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@password", encryptPassword(textBoxPW.Text.Trim()));
                            insertCommand.Parameters.AddWithValue("@name", textBoxUserName.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@apellido", textBoxSurname.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@nacionalidad", textBoxNacionality.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@tipoDocumento", textBoxDocumentType.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@documento", Decimal.Parse(textBoxDocument.Text.Trim()));
                            insertCommand.Parameters.AddWithValue("@fechaNacimiento", DateTime.Parse(textBoxBirthday.Text.Trim()));

                            if (textBoxCountry.Text.Trim() == "")
                            {
                                insertCommand.Parameters.AddWithValue("@pais", DBNull.Value);
                            }
                            else
                            {
                                insertCommand.Parameters.AddWithValue("@pais", textBoxCountry.Text.Trim());
                            }

                            if (textBoxCity.Text.Trim() == "")
                            {
                                insertCommand.Parameters.AddWithValue("@ciudad", DBNull.Value);
                            }
                            else
                            {
                                insertCommand.Parameters.AddWithValue("@ciudad", textBoxCity.Text.Trim());
                            }

                            insertCommand.Parameters.AddWithValue("@calle", textBoxBlock.Text.Trim());
                            insertCommand.Parameters.AddWithValue("@numeroCalle", textBoxBlockNumber.Text.Trim());

                            if (textBoxPiso.Text.Trim() == "")
                            {
                                insertCommand.Parameters.AddWithValue("@piso", DBNull.Value);
                            }
                            else
                            {
                                insertCommand.Parameters.AddWithValue("@piso", Decimal.Parse(textBoxPiso.Text.Trim()));
                            }

                            if (textBoxDepartamento.Text.Trim() == "")
                            {
                                insertCommand.Parameters.AddWithValue("@departamento", DBNull.Value);
                            }
                            else
                            {
                                insertCommand.Parameters.AddWithValue("@departamento", textBoxDepartamento.Text.Trim());
                            }

                            if (textBoxTelefono.Text.Trim() == "")
                            {
                                insertCommand.Parameters.AddWithValue("@telefono", DBNull.Value);
                            }
                            else
                            {
                                insertCommand.Parameters.AddWithValue("@telefono", Decimal.Parse(textBoxTelefono.Text.Trim()));
                            }

                            insertCommand.Parameters.AddWithValue("@mail", textBoxMail.Text.Trim());
                            SqlParameter listRolesParam = insertCommand.Parameters.AddWithValue("@lista_Roles", rc);
                            listRolesParam.SqlDbType = SqlDbType.Structured;
                            listRolesParam.TypeName = "[CAIA_UNLIMITED].RolesLista";
                            SqlParameter listHotelesParam = insertCommand.Parameters.AddWithValue("@lista_Hoteles", hc);
                            listHotelesParam.SqlDbType = SqlDbType.Structured;
                            listHotelesParam.TypeName = "[CAIA_UNLIMITED].HotelesLista";
                            insertCommand.ExecuteNonQuery();
                            createConnection.Close();

                            string viewModificacion = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id", this.idHotel);
                            DataSet dsViewModificacion = DataBase.realizarConsulta(viewModificacion);
                            dataGridViewModificarUsuarios.DataSource = dsViewModificacion.Tables[0];
                            string viewEliminar = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id WHERE u.usur_habilitado = 1", this.idHotel);
                            DataSet dsViewEliminar = DataBase.realizarConsulta(viewEliminar);
                            dataGridViewEliminarUsuarios.DataSource = dsViewEliminar.Tables[0];

                            MessageBox.Show("Usuario creado exitosamente!");
                            limpiarErrores();
                            limpiarListBox();
                            limpiarTextBox();
                            cargarComboBoxRol();
                            cargarComboBoxHotel();
                        }
                        catch (Exception errorDB)
                        {
                            MessageBox.Show(errorDB.Message);
                        }
                    }
                }

            }
        }

        private void dataGridViewModificarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    new VistaUsuarioModificar(dataGridViewModificarUsuarios.Rows[e.RowIndex].Cells).ShowDialog();
                    string viewModificacion = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id", this.idHotel);
                    DataSet dsViewModificacion = DataBase.realizarConsulta(viewModificacion);
                    dataGridViewModificarUsuarios.DataSource = dsViewModificacion.Tables[0];
                    string viewEliminar = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id WHERE u.usur_habilitado = 1", this.idHotel);
                    DataSet dsViewEliminar = DataBase.realizarConsulta(viewEliminar);
                    dataGridViewEliminarUsuarios.DataSource = dsViewEliminar.Tables[0];
                    this.Show();
                }
            }
            catch (IndexOutOfRangeException iorem)
            {

            }
        }

        private void dataGridViewEliminarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    string usuarioNombre = dataGridViewEliminarUsuarios.Rows[e.RowIndex].Cells["NombreDeUsuario"].Value.ToString();
                    string usuarioMail = dataGridViewEliminarUsuarios.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                    decimal usuarioDocumento = Decimal.Parse(dataGridViewEliminarUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString());
                    SqlConnection createConnection = DataBase.conectarBD();
                    SqlCommand insertCommand = new SqlCommand("[CAIA_UNLIMITED].sp_EliminarUsuarios", createConnection);
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    insertCommand.Parameters.AddWithValue("@username", usuarioNombre);
                    insertCommand.Parameters.AddWithValue("@mail", usuarioMail);
                    insertCommand.Parameters.AddWithValue("@documento", usuarioDocumento);        
                    insertCommand.ExecuteNonQuery();
                    createConnection.Close();
                    string viewModificacion = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id", this.idHotel);
                    DataSet dsViewModificacion = DataBase.realizarConsulta(viewModificacion);
                    dataGridViewModificarUsuarios.DataSource = dsViewModificacion.Tables[0];
                    string viewEliminar = string.Format("SELECT u.usur_username as NombreDeUsuario, u.usur_habilitado as Habilitado, h.hues_nombre as Nombre, h.hues_apellido as Apellido, h.hues_documento_tipo as TipoDocumento, h.hues_documento Documento, h.hues_nacimiento as Nacimiento, h.hues_mail as Mail, d.dire_id as idDireccion, d.dire_telefono as Telefono, d.dire_dom_calle as Calle, d.dire_nro_calle as NumeroCalle, d.dire_piso Piso, d.dire_dpto as Departamento, d.dire_ciudad as Ciudad FROM CAIA_UNLIMITED.Usuario u JOIN CAIA_UNLIMITED.Usuario_X_Hotel uh on (u.usur_username = uh.usur_hote_username AND uh.usur_hote_id = '{0}') JOIN CAIA_UNLIMITED.Direccion d on d.dire_id = u.dire_id JOIN CAIA_UNLIMITED.Huesped h on h.dire_id = d.dire_id WHERE u.usur_habilitado = 1", this.idHotel);
                    DataSet dsViewEliminar = DataBase.realizarConsulta(viewEliminar);
                    dataGridViewEliminarUsuarios.DataSource = dsViewEliminar.Tables[0];
                    MessageBox.Show("Rol eliminado exitosamente!");
                }
            }
            catch (IndexOutOfRangeException ioree)
            {

            }
        }
    }
}