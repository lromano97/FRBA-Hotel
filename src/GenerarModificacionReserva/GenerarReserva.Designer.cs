﻿namespace FrbaHotel.GenerarModificacionReserva
{
    partial class GenerarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarPaso = new System.Windows.Forms.Button();
            this.calendarInicio = new System.Windows.Forms.MonthCalendar();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.calendarFin = new System.Windows.Forms.MonthCalendar();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.lblErrorFechaInicio = new System.Windows.Forms.Label();
            this.lblErrorHotel = new System.Windows.Forms.Label();
            this.labelTpoHabitacion = new System.Windows.Forms.Label();
            this.lblErrorTipoHabitacion = new System.Windows.Forms.Label();
            this.cbxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.cbxRegimenEstadia = new System.Windows.Forms.ComboBox();
            this.lblResumenReserva = new System.Windows.Forms.Label();
            this.btnCheckear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblErrorPaso1 = new System.Windows.Forms.Label();
            this.lblerrorfechas = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.comboHoteles = new System.Windows.Forms.ComboBox();
            this.lblErrorFechaFin = new System.Windows.Forms.Label();
            this.listBoxTipoHabitacion = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMostrarHabitaciones = new System.Windows.Forms.ListBox();
            this.textBoxNumeroDireccion = new System.Windows.Forms.TextBox();
            this.lblNumeroDireccion = new System.Windows.Forms.Label();
            this.lblNroDireccion = new System.Windows.Forms.Label();
            this.btnSeleccionarHotel = new System.Windows.Forms.Button();
            this.textBoxHotel = new System.Windows.Forms.TextBox();
            this.txbRegimen = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.btnRegimenSeleccionar = new System.Windows.Forms.Button();
            this.lbllistBoxNoItem = new System.Windows.Forms.Label();
            this.lblErrorNoField = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.lblErrorNumberValue = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblErrorPais = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblErrorCiudad = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumentoCliente = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblErrorDocumento = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Realizar Reserva";
            // 
            // btnConfirmarPaso
            // 
            this.btnConfirmarPaso.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmarPaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarPaso.Enabled = false;
            this.btnConfirmarPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPaso.Location = new System.Drawing.Point(1019, 603);
            this.btnConfirmarPaso.Name = "btnConfirmarPaso";
            this.btnConfirmarPaso.Size = new System.Drawing.Size(160, 42);
            this.btnConfirmarPaso.TabIndex = 334;
            this.btnConfirmarPaso.Text = "Confirmar Datos";
            this.btnConfirmarPaso.UseVisualStyleBackColor = false;
            this.btnConfirmarPaso.Visible = false;
            this.btnConfirmarPaso.Click += new System.EventHandler(this.btnConfirmarPaso_Click);
            // 
            // calendarInicio
            // 
            this.calendarInicio.Location = new System.Drawing.Point(34, 335);
            this.calendarInicio.Name = "calendarInicio";
            this.calendarInicio.TabIndex = 333;
            this.calendarInicio.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarInicio_DateChanged);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(66, 306);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(132, 20);
            this.labelFechaInicio.TabIndex = 336;
            this.labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // calendarFin
            // 
            this.calendarFin.Location = new System.Drawing.Point(359, 335);
            this.calendarFin.Name = "calendarFin";
            this.calendarFin.TabIndex = 337;
            this.calendarFin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarFin_DateChanged);
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(367, 306);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(184, 20);
            this.labelFechaFin.TabIndex = 338;
            this.labelFechaFin.Text = "Fecha de Finalizacion";
            // 
            // lblErrorFechaInicio
            // 
            this.lblErrorFechaInicio.AutoSize = true;
            this.lblErrorFechaInicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFechaInicio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaInicio.Location = new System.Drawing.Point(43, 308);
            this.lblErrorFechaInicio.Name = "lblErrorFechaInicio";
            this.lblErrorFechaInicio.Size = new System.Drawing.Size(17, 22);
            this.lblErrorFechaInicio.TabIndex = 339;
            this.lblErrorFechaInicio.Text = "*";
            this.lblErrorFechaInicio.Visible = false;
            // 
            // lblErrorHotel
            // 
            this.lblErrorHotel.AutoSize = true;
            this.lblErrorHotel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHotel.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHotel.Location = new System.Drawing.Point(12, 16);
            this.lblErrorHotel.Name = "lblErrorHotel";
            this.lblErrorHotel.Size = new System.Drawing.Size(17, 22);
            this.lblErrorHotel.TabIndex = 340;
            this.lblErrorHotel.Text = "*";
            // 
            // labelTpoHabitacion
            // 
            this.labelTpoHabitacion.AutoSize = true;
            this.labelTpoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTpoHabitacion.Location = new System.Drawing.Point(34, 81);
            this.labelTpoHabitacion.Name = "labelTpoHabitacion";
            this.labelTpoHabitacion.Size = new System.Drawing.Size(164, 20);
            this.labelTpoHabitacion.TabIndex = 341;
            this.labelTpoHabitacion.Text = "Tipo de Habitacion:";
            // 
            // lblErrorTipoHabitacion
            // 
            this.lblErrorTipoHabitacion.AutoSize = true;
            this.lblErrorTipoHabitacion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipoHabitacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipoHabitacion.Location = new System.Drawing.Point(11, 81);
            this.lblErrorTipoHabitacion.Name = "lblErrorTipoHabitacion";
            this.lblErrorTipoHabitacion.Size = new System.Drawing.Size(17, 22);
            this.lblErrorTipoHabitacion.TabIndex = 342;
            this.lblErrorTipoHabitacion.Text = "*";
            // 
            // cbxTipoHabitacion
            // 
            this.cbxTipoHabitacion.FormattingEnabled = true;
            this.cbxTipoHabitacion.Location = new System.Drawing.Point(204, 80);
            this.cbxTipoHabitacion.Name = "cbxTipoHabitacion";
            this.cbxTipoHabitacion.Size = new System.Drawing.Size(154, 21);
            this.cbxTipoHabitacion.TabIndex = 343;
            this.cbxTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cbxTipoHabitacion_SelectedIndexChanged);
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegimen.Location = new System.Drawing.Point(34, 245);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(176, 20);
            this.labelRegimen.TabIndex = 344;
            this.labelRegimen.Text = "Regimen de Estadia:";
            // 
            // cbxRegimenEstadia
            // 
            this.cbxRegimenEstadia.FormattingEnabled = true;
            this.cbxRegimenEstadia.Location = new System.Drawing.Point(216, 244);
            this.cbxRegimenEstadia.Name = "cbxRegimenEstadia";
            this.cbxRegimenEstadia.Size = new System.Drawing.Size(139, 21);
            this.cbxRegimenEstadia.TabIndex = 345;
            // 
            // lblResumenReserva
            // 
            this.lblResumenReserva.AutoSize = true;
            this.lblResumenReserva.Location = new System.Drawing.Point(106, 563);
            this.lblResumenReserva.Name = "lblResumenReserva";
            this.lblResumenReserva.Size = new System.Drawing.Size(10, 13);
            this.lblResumenReserva.TabIndex = 346;
            this.lblResumenReserva.Text = " ";
            // 
            // btnCheckear
            // 
            this.btnCheckear.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheckear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckear.Location = new System.Drawing.Point(34, 603);
            this.btnCheckear.Name = "btnCheckear";
            this.btnCheckear.Size = new System.Drawing.Size(177, 43);
            this.btnCheckear.TabIndex = 347;
            this.btnCheckear.Text = "Checkear Reserva";
            this.btnCheckear.UseVisualStyleBackColor = false;
            this.btnCheckear.Click += new System.EventHandler(this.btnCheckear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(698, 606);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 36);
            this.btnLimpiar.TabIndex = 348;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblErrorPaso1
            // 
            this.lblErrorPaso1.AutoSize = true;
            this.lblErrorPaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaso1.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPaso1.Location = new System.Drawing.Point(47, 563);
            this.lblErrorPaso1.Name = "lblErrorPaso1";
            this.lblErrorPaso1.Size = new System.Drawing.Size(488, 20);
            this.lblErrorPaso1.TabIndex = 351;
            this.lblErrorPaso1.Text = "*Ya hay una reserva dentro de los dias que ha seleccionado";
            this.lblErrorPaso1.Visible = false;
            this.lblErrorPaso1.Click += new System.EventHandler(this.lblErrorPaso1_Click);
            // 
            // lblerrorfechas
            // 
            this.lblerrorfechas.AutoSize = true;
            this.lblerrorfechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorfechas.ForeColor = System.Drawing.Color.Red;
            this.lblerrorfechas.Location = new System.Drawing.Point(47, 543);
            this.lblerrorfechas.Name = "lblerrorfechas";
            this.lblerrorfechas.Size = new System.Drawing.Size(504, 20);
            this.lblerrorfechas.TabIndex = 353;
            this.lblerrorfechas.Text = "*Verifique que la fecha de fin sea mayor que la fecha de inicio";
            this.lblerrorfechas.Visible = false;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(34, 16);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(57, 20);
            this.lblHotel.TabIndex = 357;
            this.lblHotel.Text = "Hotel:";
            // 
            // comboHoteles
            // 
            this.comboHoteles.FormattingEnabled = true;
            this.comboHoteles.Location = new System.Drawing.Point(95, 18);
            this.comboHoteles.Margin = new System.Windows.Forms.Padding(2);
            this.comboHoteles.Name = "comboHoteles";
            this.comboHoteles.Size = new System.Drawing.Size(270, 21);
            this.comboHoteles.TabIndex = 358;
            // 
            // lblErrorFechaFin
            // 
            this.lblErrorFechaFin.AutoSize = true;
            this.lblErrorFechaFin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFechaFin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaFin.Location = new System.Drawing.Point(344, 306);
            this.lblErrorFechaFin.Name = "lblErrorFechaFin";
            this.lblErrorFechaFin.Size = new System.Drawing.Size(17, 22);
            this.lblErrorFechaFin.TabIndex = 359;
            this.lblErrorFechaFin.Text = "*";
            this.lblErrorFechaFin.Visible = false;
            // 
            // listBoxTipoHabitacion
            // 
            this.listBoxTipoHabitacion.FormattingEnabled = true;
            this.listBoxTipoHabitacion.Location = new System.Drawing.Point(38, 112);
            this.listBoxTipoHabitacion.Name = "listBoxTipoHabitacion";
            this.listBoxTipoHabitacion.Size = new System.Drawing.Size(177, 121);
            this.listBoxTipoHabitacion.TabIndex = 360;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(234, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 32);
            this.btnAgregar.TabIndex = 361;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(234, 192);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(98, 31);
            this.btnQuitar.TabIndex = 362;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxMostrarHabitaciones);
            this.groupBox1.Controls.Add(this.textBoxNumeroDireccion);
            this.groupBox1.Controls.Add(this.lblNumeroDireccion);
            this.groupBox1.Controls.Add(this.lblNroDireccion);
            this.groupBox1.Controls.Add(this.btnSeleccionarHotel);
            this.groupBox1.Controls.Add(this.textBoxHotel);
            this.groupBox1.Controls.Add(this.txbRegimen);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Controls.Add(this.btnRegimenSeleccionar);
            this.groupBox1.Controls.Add(this.lbllistBoxNoItem);
            this.groupBox1.Controls.Add(this.lblErrorNoField);
            this.groupBox1.Controls.Add(this.textBoxPais);
            this.groupBox1.Controls.Add(this.lblErrorNumberValue);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblErrorPais);
            this.groupBox1.Controls.Add(this.textBoxCiudad);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblErrorCiudad);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblErrorDireccion);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblErrorTelefono);
            this.groupBox1.Controls.Add(this.comboBoxTipoDocumentoCliente);
            this.groupBox1.Controls.Add(this.lblTipoDocumentoCliente);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.lblDocumento);
            this.groupBox1.Controls.Add(this.lblErrorDocumento);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblErrorMail);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblErrorApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblErrorNombre);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.listBoxTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblErrorFechaFin);
            this.groupBox1.Controls.Add(this.comboHoteles);
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.lblerrorfechas);
            this.groupBox1.Controls.Add(this.lblErrorPaso1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCheckear);
            this.groupBox1.Controls.Add(this.lblResumenReserva);
            this.groupBox1.Controls.Add(this.cbxRegimenEstadia);
            this.groupBox1.Controls.Add(this.labelRegimen);
            this.groupBox1.Controls.Add(this.cbxTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblErrorTipoHabitacion);
            this.groupBox1.Controls.Add(this.labelTpoHabitacion);
            this.groupBox1.Controls.Add(this.lblErrorHotel);
            this.groupBox1.Controls.Add(this.lblErrorFechaInicio);
            this.groupBox1.Controls.Add(this.labelFechaFin);
            this.groupBox1.Controls.Add(this.calendarFin);
            this.groupBox1.Controls.Add(this.labelFechaInicio);
            this.groupBox1.Controls.Add(this.calendarInicio);
            this.groupBox1.Controls.Add(this.btnConfirmarPaso);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 646);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 403;
            this.label2.Text = "Habitaciones";
            // 
            // listBoxMostrarHabitaciones
            // 
            this.listBoxMostrarHabitaciones.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxMostrarHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMostrarHabitaciones.FormattingEnabled = true;
            this.listBoxMostrarHabitaciones.ItemHeight = 20;
            this.listBoxMostrarHabitaciones.Location = new System.Drawing.Point(546, 80);
            this.listBoxMostrarHabitaciones.Name = "listBoxMostrarHabitaciones";
            this.listBoxMostrarHabitaciones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMostrarHabitaciones.Size = new System.Drawing.Size(252, 124);
            this.listBoxMostrarHabitaciones.TabIndex = 402;
            // 
            // textBoxNumeroDireccion
            // 
            this.textBoxNumeroDireccion.Location = new System.Drawing.Point(1037, 412);
            this.textBoxNumeroDireccion.Name = "textBoxNumeroDireccion";
            this.textBoxNumeroDireccion.Size = new System.Drawing.Size(140, 20);
            this.textBoxNumeroDireccion.TabIndex = 401;
            this.textBoxNumeroDireccion.Visible = false;
            // 
            // lblNumeroDireccion
            // 
            this.lblNumeroDireccion.AutoSize = true;
            this.lblNumeroDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDireccion.Location = new System.Drawing.Point(876, 410);
            this.lblNumeroDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroDireccion.Name = "lblNumeroDireccion";
            this.lblNumeroDireccion.Size = new System.Drawing.Size(156, 20);
            this.lblNumeroDireccion.TabIndex = 400;
            this.lblNumeroDireccion.Text = "Numero Direccion:";
            this.lblNumeroDireccion.Visible = false;
            // 
            // lblNroDireccion
            // 
            this.lblNroDireccion.AutoSize = true;
            this.lblNroDireccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblNroDireccion.Location = new System.Drawing.Point(862, 412);
            this.lblNroDireccion.Name = "lblNroDireccion";
            this.lblNroDireccion.Size = new System.Drawing.Size(17, 22);
            this.lblNroDireccion.TabIndex = 399;
            this.lblNroDireccion.Text = "*";
            this.lblNroDireccion.Visible = false;
            // 
            // btnSeleccionarHotel
            // 
            this.btnSeleccionarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarHotel.Location = new System.Drawing.Point(375, 33);
            this.btnSeleccionarHotel.Name = "btnSeleccionarHotel";
            this.btnSeleccionarHotel.Size = new System.Drawing.Size(113, 32);
            this.btnSeleccionarHotel.TabIndex = 398;
            this.btnSeleccionarHotel.Text = "Seleccionar";
            this.btnSeleccionarHotel.UseVisualStyleBackColor = true;
            this.btnSeleccionarHotel.Click += new System.EventHandler(this.btnSeleccionarHotel_Click);
            // 
            // textBoxHotel
            // 
            this.textBoxHotel.Location = new System.Drawing.Point(96, 46);
            this.textBoxHotel.Name = "textBoxHotel";
            this.textBoxHotel.ReadOnly = true;
            this.textBoxHotel.Size = new System.Drawing.Size(269, 20);
            this.textBoxHotel.TabIndex = 397;
            // 
            // txbRegimen
            // 
            this.txbRegimen.Location = new System.Drawing.Point(216, 271);
            this.txbRegimen.Name = "txbRegimen";
            this.txbRegimen.ReadOnly = true;
            this.txbRegimen.Size = new System.Drawing.Size(139, 20);
            this.txbRegimen.TabIndex = 396;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.Location = new System.Drawing.Point(1000, 480);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(179, 34);
            this.buttonBuscarCliente.TabIndex = 395;
            this.buttonBuscarCliente.Text = "Buscar Cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Visible = false;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegimenSeleccionar
            // 
            this.btnRegimenSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegimenSeleccionar.Location = new System.Drawing.Point(359, 255);
            this.btnRegimenSeleccionar.Name = "btnRegimenSeleccionar";
            this.btnRegimenSeleccionar.Size = new System.Drawing.Size(113, 32);
            this.btnRegimenSeleccionar.TabIndex = 394;
            this.btnRegimenSeleccionar.Text = "Seleccionar";
            this.btnRegimenSeleccionar.UseVisualStyleBackColor = true;
            this.btnRegimenSeleccionar.Click += new System.EventHandler(this.btnRegimenSeleccionar_Click);
            // 
            // lbllistBoxNoItem
            // 
            this.lbllistBoxNoItem.AutoSize = true;
            this.lbllistBoxNoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistBoxNoItem.ForeColor = System.Drawing.Color.Red;
            this.lbllistBoxNoItem.Location = new System.Drawing.Point(47, 583);
            this.lbllistBoxNoItem.Name = "lbllistBoxNoItem";
            this.lbllistBoxNoItem.Size = new System.Drawing.Size(411, 20);
            this.lbllistBoxNoItem.TabIndex = 393;
            this.lbllistBoxNoItem.Text = "*Debe de agregar, al menos, un tipo de habitacion";
            this.lbllistBoxNoItem.Visible = false;
            // 
            // lblErrorNoField
            // 
            this.lblErrorNoField.AutoSize = true;
            this.lblErrorNoField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNoField.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNoField.Location = new System.Drawing.Point(574, 543);
            this.lblErrorNoField.Name = "lblErrorNoField";
            this.lblErrorNoField.Size = new System.Drawing.Size(164, 20);
            this.lblErrorNoField.TabIndex = 64;
            this.lblErrorNoField.Text = "*Campo Obligatorio";
            this.lblErrorNoField.Visible = false;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(905, 445);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(153, 20);
            this.textBoxPais.TabIndex = 392;
            this.textBoxPais.Visible = false;
            this.textBoxPais.TextChanged += new System.EventHandler(this.textBoxPais_TextChanged);
            // 
            // lblErrorNumberValue
            // 
            this.lblErrorNumberValue.AutoSize = true;
            this.lblErrorNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNumberValue.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumberValue.Location = new System.Drawing.Point(574, 563);
            this.lblErrorNumberValue.Name = "lblErrorNumberValue";
            this.lblErrorNumberValue.Size = new System.Drawing.Size(540, 20);
            this.lblErrorNumberValue.TabIndex = 63;
            this.lblErrorNumberValue.Text = "*No puede ingresar valores no numericos en los campos marcados";
            this.lblErrorNumberValue.Visible = false;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(852, 443);
            this.lblPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(48, 20);
            this.lblPais.TabIndex = 391;
            this.lblPais.Text = "Pais:";
            this.lblPais.Visible = false;
            // 
            // lblErrorPais
            // 
            this.lblErrorPais.AutoSize = true;
            this.lblErrorPais.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPais.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPais.Location = new System.Drawing.Point(838, 445);
            this.lblErrorPais.Name = "lblErrorPais";
            this.lblErrorPais.Size = new System.Drawing.Size(17, 22);
            this.lblErrorPais.TabIndex = 390;
            this.lblErrorPais.Text = "*";
            this.lblErrorPais.Visible = false;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(667, 445);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(153, 20);
            this.textBoxCiudad.TabIndex = 389;
            this.textBoxCiudad.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(594, 443);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(70, 20);
            this.lblCity.TabIndex = 388;
            this.lblCity.Text = "Ciudad:";
            this.lblCity.Visible = false;
            this.lblCity.Click += new System.EventHandler(this.label31_Click);
            // 
            // lblErrorCiudad
            // 
            this.lblErrorCiudad.AutoSize = true;
            this.lblErrorCiudad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCiudad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCiudad.Location = new System.Drawing.Point(572, 443);
            this.lblErrorCiudad.Name = "lblErrorCiudad";
            this.lblErrorCiudad.Size = new System.Drawing.Size(17, 22);
            this.lblErrorCiudad.TabIndex = 387;
            this.lblErrorCiudad.Text = "*";
            this.lblErrorCiudad.Visible = false;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(1024, 374);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(153, 20);
            this.textBoxDireccion.TabIndex = 386;
            this.textBoxDireccion.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(930, 372);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 20);
            this.lblDireccion.TabIndex = 385;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(911, 374);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(17, 22);
            this.lblErrorDireccion.TabIndex = 384;
            this.lblErrorDireccion.Text = "*";
            this.lblErrorDireccion.Visible = false;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(683, 410);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(153, 20);
            this.textBoxTelefono.TabIndex = 383;
            this.textBoxTelefono.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(594, 410);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 20);
            this.lblTelefono.TabIndex = 382;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Visible = false;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTelefono.Location = new System.Drawing.Point(572, 410);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(17, 22);
            this.lblErrorTelefono.TabIndex = 381;
            this.lblErrorTelefono.Text = "*";
            this.lblErrorTelefono.Visible = false;
            // 
            // comboBoxTipoDocumentoCliente
            // 
            this.comboBoxTipoDocumentoCliente.FormattingEnabled = true;
            this.comboBoxTipoDocumentoCliente.Location = new System.Drawing.Point(744, 374);
            this.comboBoxTipoDocumentoCliente.Name = "comboBoxTipoDocumentoCliente";
            this.comboBoxTipoDocumentoCliente.Size = new System.Drawing.Size(153, 21);
            this.comboBoxTipoDocumentoCliente.TabIndex = 377;
            this.comboBoxTipoDocumentoCliente.Visible = false;
            // 
            // lblTipoDocumentoCliente
            // 
            this.lblTipoDocumentoCliente.AutoSize = true;
            this.lblTipoDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumentoCliente.Location = new System.Drawing.Point(594, 373);
            this.lblTipoDocumentoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDocumentoCliente.Name = "lblTipoDocumentoCliente";
            this.lblTipoDocumentoCliente.Size = new System.Drawing.Size(145, 20);
            this.lblTipoDocumentoCliente.TabIndex = 376;
            this.lblTipoDocumentoCliente.Text = "Tipo Documento:";
            this.lblTipoDocumentoCliente.Visible = false;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(959, 335);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(153, 20);
            this.textBoxDocumento.TabIndex = 374;
            this.textBoxDocumento.Visible = false;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(848, 335);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(106, 20);
            this.lblDocumento.TabIndex = 373;
            this.lblDocumento.Text = "Documento:";
            this.lblDocumento.Visible = false;
            // 
            // lblErrorDocumento
            // 
            this.lblErrorDocumento.AutoSize = true;
            this.lblErrorDocumento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDocumento.Location = new System.Drawing.Point(826, 335);
            this.lblErrorDocumento.Name = "lblErrorDocumento";
            this.lblErrorDocumento.Size = new System.Drawing.Size(17, 22);
            this.lblErrorDocumento.TabIndex = 372;
            this.lblErrorDocumento.Text = "*";
            this.lblErrorDocumento.Visible = false;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(645, 337);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(153, 20);
            this.textBoxMail.TabIndex = 371;
            this.textBoxMail.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(594, 337);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 20);
            this.lblMail.TabIndex = 370;
            this.lblMail.Text = "Mail:";
            this.lblMail.Visible = false;
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(572, 337);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(17, 22);
            this.lblErrorMail.TabIndex = 369;
            this.lblErrorMail.Text = "*";
            this.lblErrorMail.Visible = false;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(958, 303);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(153, 20);
            this.textBoxApellido.TabIndex = 368;
            this.textBoxApellido.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(876, 304);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 20);
            this.lblApellido.TabIndex = 367;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellido.Location = new System.Drawing.Point(854, 304);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(17, 22);
            this.lblErrorApellido.TabIndex = 366;
            this.lblErrorApellido.Text = "*";
            this.lblErrorApellido.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(676, 303);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(153, 20);
            this.textBoxNombre.TabIndex = 365;
            this.textBoxNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(594, 304);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 364;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(572, 304);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(17, 22);
            this.lblErrorNombre.TabIndex = 363;
            this.lblErrorNombre.Text = "*";
            this.lblErrorNombre.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 404;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(401, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 405;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerarReserva";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarPaso;
        private System.Windows.Forms.MonthCalendar calendarInicio;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.MonthCalendar calendarFin;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label lblErrorFechaInicio;
        private System.Windows.Forms.Label lblErrorHotel;
        private System.Windows.Forms.Label labelTpoHabitacion;
        private System.Windows.Forms.Label lblErrorTipoHabitacion;
        private System.Windows.Forms.ComboBox cbxTipoHabitacion;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.ComboBox cbxRegimenEstadia;
        private System.Windows.Forms.Label lblResumenReserva;
        private System.Windows.Forms.Button btnCheckear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblErrorPaso1;
        private System.Windows.Forms.Label lblerrorfechas;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox comboHoteles;
        private System.Windows.Forms.Label lblErrorFechaFin;
        private System.Windows.Forms.ListBox listBoxTipoHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblErrorPais;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblErrorCiudad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumentoCliente;
        private System.Windows.Forms.Label lblTipoDocumentoCliente;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblErrorDocumento;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblErrorNoField;
        private System.Windows.Forms.Label lblErrorNumberValue;
        private System.Windows.Forms.Label lbllistBoxNoItem;
        private System.Windows.Forms.Button btnRegimenSeleccionar;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox txbRegimen;
        private System.Windows.Forms.TextBox textBoxHotel;
        private System.Windows.Forms.Button btnSeleccionarHotel;
        private System.Windows.Forms.TextBox textBoxNumeroDireccion;
        private System.Windows.Forms.Label lblNumeroDireccion;
        private System.Windows.Forms.Label lblNroDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMostrarHabitaciones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}