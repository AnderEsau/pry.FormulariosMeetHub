namespace pry.FormulariosMeetHub
{
    partial class frmReservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaciones));
            pnlReservaciones = new Panel();
            cmbTipoResponsable = new ComboBox();
            pnlNota = new Panel();
            pcbNota = new PictureBox();
            lblNota = new Label();
            btnAceptar = new Button();
            pcbSala = new PictureBox();
            pcbResponsable = new PictureBox();
            txtDetalles = new TextBox();
            txtDescripcion = new TextBox();
            cmbEvento = new ComboBox();
            cmbHoraTermino = new ComboBox();
            cmbHoraInicio = new ComboBox();
            lblFechaS = new Label();
            lblFechaR = new Label();
            lblDetalles = new Label();
            cmbSala = new ComboBox();
            txtResponsable = new TextBox();
            lblTitulo = new Label();
            dtpSolicitud = new DateTimePicker();
            dtpFechaR = new DateTimePicker();
            pnlReservaciones.SuspendLayout();
            pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).BeginInit();
            SuspendLayout();
            // 
            // pnlReservaciones
            // 
            pnlReservaciones.Controls.Add(dtpFechaR);
            pnlReservaciones.Controls.Add(dtpSolicitud);
            pnlReservaciones.Controls.Add(cmbTipoResponsable);
            pnlReservaciones.Controls.Add(pnlNota);
            pnlReservaciones.Controls.Add(btnAceptar);
            pnlReservaciones.Controls.Add(pcbSala);
            pnlReservaciones.Controls.Add(pcbResponsable);
            pnlReservaciones.Controls.Add(txtDetalles);
            pnlReservaciones.Controls.Add(txtDescripcion);
            pnlReservaciones.Controls.Add(cmbEvento);
            pnlReservaciones.Controls.Add(cmbHoraTermino);
            pnlReservaciones.Controls.Add(cmbHoraInicio);
            pnlReservaciones.Controls.Add(lblFechaS);
            pnlReservaciones.Controls.Add(lblFechaR);
            pnlReservaciones.Controls.Add(lblDetalles);
            pnlReservaciones.Controls.Add(cmbSala);
            pnlReservaciones.Controls.Add(txtResponsable);
            pnlReservaciones.Dock = DockStyle.Bottom;
            pnlReservaciones.Location = new Point(0, 59);
            pnlReservaciones.Name = "pnlReservaciones";
            pnlReservaciones.Size = new Size(1119, 497);
            pnlReservaciones.TabIndex = 1;
            // 
            // cmbTipoResponsable
            // 
            cmbTipoResponsable.BackColor = Color.White;
            cmbTipoResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoResponsable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoResponsable.ForeColor = SystemColors.WindowText;
            cmbTipoResponsable.FormattingEnabled = true;
            cmbTipoResponsable.ItemHeight = 21;
            cmbTipoResponsable.Items.AddRange(new object[] { "--Seleccione el tipo de responsable--", "Externo", "Alumno", "Trabajador" });
            cmbTipoResponsable.Location = new Point(85, 18);
            cmbTipoResponsable.Name = "cmbTipoResponsable";
            cmbTipoResponsable.Size = new Size(299, 29);
            cmbTipoResponsable.TabIndex = 73;
            // 
            // pnlNota
            // 
            pnlNota.Controls.Add(pcbNota);
            pnlNota.Controls.Add(lblNota);
            pnlNota.Location = new Point(460, 155);
            pnlNota.Name = "pnlNota";
            pnlNota.Size = new Size(328, 155);
            pnlNota.TabIndex = 72;
            // 
            // pcbNota
            // 
            pcbNota.Image = (Image)resources.GetObject("pcbNota.Image");
            pcbNota.Location = new Point(20, 9);
            pcbNota.Name = "pcbNota";
            pcbNota.Size = new Size(40, 40);
            pcbNota.SizeMode = PictureBoxSizeMode.Zoom;
            pcbNota.TabIndex = 23;
            pcbNota.TabStop = false;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.FromArgb(43, 62, 80);
            lblNota.Location = new Point(76, 9);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(244, 126);
            lblNota.TabIndex = 17;
            lblNota.Text = "Nota: \r\nLa adecuación de los\r\nespacios debe ser solicitada\r\npor la persona interesada\r\na la Dirección de Administración\r\ny Finanzas";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 62, 80);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(461, 400);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(217, 33);
            btnAceptar.TabIndex = 70;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pcbSala
            // 
            pcbSala.Image = (Image)resources.GetObject("pcbSala.Image");
            pcbSala.Location = new Point(39, 135);
            pcbSala.Name = "pcbSala";
            pcbSala.Size = new Size(40, 40);
            pcbSala.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSala.TabIndex = 67;
            pcbSala.TabStop = false;
            // 
            // pcbResponsable
            // 
            pcbResponsable.Image = (Image)resources.GetObject("pcbResponsable.Image");
            pcbResponsable.Location = new Point(39, 67);
            pcbResponsable.Name = "pcbResponsable";
            pcbResponsable.Size = new Size(40, 40);
            pcbResponsable.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbResponsable.TabIndex = 66;
            pcbResponsable.TabStop = false;
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.White;
            txtDetalles.Font = new Font("Segoe UI", 12F);
            txtDetalles.ForeColor = SystemColors.WindowText;
            txtDetalles.Location = new Point(85, 232);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.ReadOnly = true;
            txtDetalles.ScrollBars = ScrollBars.Vertical;
            txtDetalles.Size = new Size(299, 23);
            txtDetalles.TabIndex = 65;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = SystemColors.WindowText;
            txtDescripcion.Location = new Point(834, 215);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del evento";
            txtDescripcion.Size = new Size(250, 29);
            txtDescripcion.TabIndex = 63;
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = Color.White;
            cmbEvento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbEvento.ForeColor = SystemColors.WindowText;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "Escolar", "Guvernamental", "Externo" });
            cmbEvento.Location = new Point(834, 155);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(250, 29);
            cmbEvento.TabIndex = 62;
            cmbEvento.Text = "Tipo de Evento:";
            cmbEvento.UseWaitCursor = true;
            // 
            // cmbHoraTermino
            // 
            cmbHoraTermino.BackColor = Color.White;
            cmbHoraTermino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbHoraTermino.ForeColor = SystemColors.WindowText;
            cmbHoraTermino.FormattingEnabled = true;
            cmbHoraTermino.Location = new Point(834, 90);
            cmbHoraTermino.Name = "cmbHoraTermino";
            cmbHoraTermino.Size = new Size(250, 29);
            cmbHoraTermino.TabIndex = 61;
            cmbHoraTermino.Text = "Hora Termino:";
            // 
            // cmbHoraInicio
            // 
            cmbHoraInicio.BackColor = Color.White;
            cmbHoraInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbHoraInicio.ForeColor = SystemColors.WindowText;
            cmbHoraInicio.FormattingEnabled = true;
            cmbHoraInicio.Location = new Point(834, 30);
            cmbHoraInicio.Name = "cmbHoraInicio";
            cmbHoraInicio.Size = new Size(250, 29);
            cmbHoraInicio.TabIndex = 60;
            cmbHoraInicio.Text = "Hora Inicio:";
            // 
            // lblFechaS
            // 
            lblFechaS.AutoSize = true;
            lblFechaS.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFechaS.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaS.Location = new Point(461, 10);
            lblFechaS.Name = "lblFechaS";
            lblFechaS.Size = new Size(141, 21);
            lblFechaS.TabIndex = 59;
            lblFechaS.Text = "Fecha de solicitud";
            // 
            // lblFechaR
            // 
            lblFechaR.AutoSize = true;
            lblFechaR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFechaR.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaR.Location = new Point(461, 78);
            lblFechaR.Name = "lblFechaR";
            lblFechaR.Size = new Size(133, 21);
            lblFechaR.TabIndex = 57;
            lblFechaR.Text = "Fecha de reserva";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDetalles.ForeColor = Color.FromArgb(43, 62, 80);
            lblDetalles.Location = new Point(85, 203);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(103, 21);
            lblDetalles.TabIndex = 55;
            lblDetalles.Text = "Detalles sala:";
            // 
            // cmbSala
            // 
            cmbSala.BackColor = Color.White;
            cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSala.ForeColor = SystemColors.WindowText;
            cmbSala.FormattingEnabled = true;
            cmbSala.ItemHeight = 21;
            cmbSala.Items.AddRange(new object[] { "--Seleccione la sala--", "Sala 1", "Sala 2", "Sala 3" });
            cmbSala.Location = new Point(85, 142);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(299, 29);
            cmbSala.TabIndex = 54;
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.White;
            txtResponsable.Font = new Font("Segoe UI", 12F);
            txtResponsable.ForeColor = SystemColors.WindowText;
            txtResponsable.Location = new Point(85, 78);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.PlaceholderText = "Responsable de la Reserva";
            txtResponsable.Size = new Size(299, 29);
            txtResponsable.TabIndex = 53;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 62, 80);
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 47);
            lblTitulo.TabIndex = 73;
            lblTitulo.Text = "Reservaciones";
            // 
            // dtpSolicitud
            // 
            dtpSolicitud.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpSolicitud.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpSolicitud.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpSolicitud.Font = new Font("Segoe UI", 12F);
            dtpSolicitud.Location = new Point(460, 34);
            dtpSolicitud.Name = "dtpSolicitud";
            dtpSolicitud.Size = new Size(299, 29);
            dtpSolicitud.TabIndex = 74;
            // 
            // dtpFechaR
            // 
            dtpFechaR.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaR.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpFechaR.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpFechaR.Font = new Font("Segoe UI", 12F);
            dtpFechaR.Location = new Point(460, 111);
            dtpFechaR.Name = "dtpFechaR";
            dtpFechaR.Size = new Size(299, 29);
            dtpFechaR.TabIndex = 75;
            // 
            // frmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(lblTitulo);
            Controls.Add(pnlReservaciones);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReservaciones";
            Text = "Reservaciones";
            pnlReservaciones.ResumeLayout(false);
            pnlReservaciones.PerformLayout();
            pnlNota.ResumeLayout(false);
            pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlReservaciones;
        private Panel pnlNota;
        private PictureBox pcbNota;
        internal Label lblNota;
        private Button btnAceptar;
        internal DateTimePicker dtpFormalizacion;
        internal DateTimePicker dtpReserva;
        private PictureBox pcbDepartamentos;
        private PictureBox pcbSala;
        private PictureBox pcbResponsable;
        internal TextBox txtDetalles;
        internal TextBox txtDescripcion;
        internal ComboBox cmbEvento;
        internal ComboBox cmbHoraTermino;
        internal ComboBox cmbHoraInicio;
        internal Label lblFechaS;
        internal Label lblFechaR;
        internal ComboBox cmbDepartamentos;
        internal Label lblDetalles;
        internal ComboBox cmbSala;
        internal TextBox txtResponsable;
        private Label lblTitulo;
        internal ComboBox cmbTipoResponsable;
        internal DateTimePicker dtpSolicitud;
        internal DateTimePicker dtpFechaR;
    }
}