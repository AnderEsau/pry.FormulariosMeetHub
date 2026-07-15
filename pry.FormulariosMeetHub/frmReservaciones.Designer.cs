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
            pnlNota = new Panel();
            pcbNota = new PictureBox();
            lblNota = new Label();
            btnAceptar = new Button();
            dtpFormalizacion = new DateTimePicker();
            pcbDepartamentos = new PictureBox();
            pcbSala = new PictureBox();
            pcbResponsable = new PictureBox();
            txtDetalles = new TextBox();
            cmbAsistentes = new ComboBox();
            txtDescripcion = new TextBox();
            cmbEvento = new ComboBox();
            cmbHoraTermino = new ComboBox();
            cmbHoraInicio = new ComboBox();
            lblFechaF = new Label();
            dtpReserva = new DateTimePicker();
            lblFechaR = new Label();
            cmbDepartamentos = new ComboBox();
            lblDetalles = new Label();
            cmbSala = new ComboBox();
            txtResponsable = new TextBox();
            lblTitulo = new Label();
            pnlReservaciones.SuspendLayout();
            pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).BeginInit();
            SuspendLayout();
            // 
            // pnlReservaciones
            // 
            pnlReservaciones.Controls.Add(pnlNota);
            pnlReservaciones.Controls.Add(btnAceptar);
            pnlReservaciones.Controls.Add(dtpFormalizacion);
            pnlReservaciones.Controls.Add(pcbDepartamentos);
            pnlReservaciones.Controls.Add(pcbSala);
            pnlReservaciones.Controls.Add(pcbResponsable);
            pnlReservaciones.Controls.Add(txtDetalles);
            pnlReservaciones.Controls.Add(cmbAsistentes);
            pnlReservaciones.Controls.Add(txtDescripcion);
            pnlReservaciones.Controls.Add(cmbEvento);
            pnlReservaciones.Controls.Add(cmbHoraTermino);
            pnlReservaciones.Controls.Add(cmbHoraInicio);
            pnlReservaciones.Controls.Add(lblFechaF);
            pnlReservaciones.Controls.Add(dtpReserva);
            pnlReservaciones.Controls.Add(lblFechaR);
            pnlReservaciones.Controls.Add(cmbDepartamentos);
            pnlReservaciones.Controls.Add(lblDetalles);
            pnlReservaciones.Controls.Add(cmbSala);
            pnlReservaciones.Controls.Add(txtResponsable);
            pnlReservaciones.Dock = DockStyle.Bottom;
            pnlReservaciones.Location = new Point(0, 59);
            pnlReservaciones.Name = "pnlReservaciones";
            pnlReservaciones.Size = new Size(1119, 497);
            pnlReservaciones.TabIndex = 1;
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
            // dtpFormalizacion
            // 
            dtpFormalizacion.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFormalizacion.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpFormalizacion.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpFormalizacion.Font = new Font("Segoe UI", 12F);
            dtpFormalizacion.Location = new Point(460, 90);
            dtpFormalizacion.Name = "dtpFormalizacion";
            dtpFormalizacion.Size = new Size(299, 29);
            dtpFormalizacion.TabIndex = 69;
            // 
            // pcbDepartamentos
            // 
            pcbDepartamentos.Image = (Image)resources.GetObject("pcbDepartamentos.Image");
            pcbDepartamentos.Location = new Point(39, 270);
            pcbDepartamentos.Name = "pcbDepartamentos";
            pcbDepartamentos.Size = new Size(40, 40);
            pcbDepartamentos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDepartamentos.TabIndex = 68;
            pcbDepartamentos.TabStop = false;
            // 
            // pcbSala
            // 
            pcbSala.Image = (Image)resources.GetObject("pcbSala.Image");
            pcbSala.Location = new Point(39, 96);
            pcbSala.Name = "pcbSala";
            pcbSala.Size = new Size(40, 40);
            pcbSala.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSala.TabIndex = 67;
            pcbSala.TabStop = false;
            // 
            // pcbResponsable
            // 
            pcbResponsable.Image = (Image)resources.GetObject("pcbResponsable.Image");
            pcbResponsable.Location = new Point(39, 21);
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
            txtDetalles.Location = new Point(85, 193);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(299, 29);
            txtDetalles.TabIndex = 65;
            // 
            // cmbAsistentes
            // 
            cmbAsistentes.BackColor = Color.White;
            cmbAsistentes.Font = new Font("Segoe UI", 12F);
            cmbAsistentes.ForeColor = Color.Gray;
            cmbAsistentes.FormattingEnabled = true;
            cmbAsistentes.Location = new Point(834, 276);
            cmbAsistentes.Name = "cmbAsistentes";
            cmbAsistentes.Size = new Size(250, 29);
            cmbAsistentes.TabIndex = 64;
            cmbAsistentes.Text = "Total de Asistentes:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(834, 215);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 29);
            txtDescripcion.TabIndex = 63;
            txtDescripcion.Text = "Descripción del evento";
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = Color.White;
            cmbEvento.Font = new Font("Segoe UI", 12F);
            cmbEvento.ForeColor = Color.Gray;
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
            cmbHoraTermino.Font = new Font("Segoe UI", 12F);
            cmbHoraTermino.ForeColor = Color.Gray;
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
            cmbHoraInicio.Font = new Font("Segoe UI", 12F);
            cmbHoraInicio.ForeColor = Color.Gray;
            cmbHoraInicio.FormattingEnabled = true;
            cmbHoraInicio.Location = new Point(834, 30);
            cmbHoraInicio.Name = "cmbHoraInicio";
            cmbHoraInicio.Size = new Size(250, 29);
            cmbHoraInicio.TabIndex = 60;
            cmbHoraInicio.Text = "Hora Inicio:";
            // 
            // lblFechaF
            // 
            lblFechaF.AutoSize = true;
            lblFechaF.Font = new Font("Segoe UI", 12F);
            lblFechaF.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaF.Location = new Point(460, 66);
            lblFechaF.Name = "lblFechaF";
            lblFechaF.Size = new Size(174, 21);
            lblFechaF.TabIndex = 59;
            lblFechaF.Text = "Fecha De Formalización";
            // 
            // dtpReserva
            // 
            dtpReserva.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpReserva.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpReserva.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpReserva.Font = new Font("Segoe UI", 12F);
            dtpReserva.Location = new Point(460, 32);
            dtpReserva.Name = "dtpReserva";
            dtpReserva.Size = new Size(299, 29);
            dtpReserva.TabIndex = 58;
            // 
            // lblFechaR
            // 
            lblFechaR.AutoSize = true;
            lblFechaR.Font = new Font("Segoe UI", 12F);
            lblFechaR.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaR.Location = new Point(460, 9);
            lblFechaR.Name = "lblFechaR";
            lblFechaR.Size = new Size(132, 21);
            lblFechaR.TabIndex = 57;
            lblFechaR.Text = "Fecha De Reserva";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.BackColor = Color.White;
            cmbDepartamentos.Font = new Font("Segoe UI", 12F);
            cmbDepartamentos.ForeColor = Color.Gray;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Items.AddRange(new object[] { "Contabilidad", "Administracion", "Ingenieria Civil", "Agrobiotecnologia", "Mecatronica", "Mecanica", "Ingenieria en Desarrollo de Software Multiplataforma" });
            cmbDepartamentos.Location = new Point(85, 276);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(299, 29);
            cmbDepartamentos.TabIndex = 56;
            cmbDepartamentos.Text = "Área Academica/Departamento";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Font = new Font("Segoe UI", 12F);
            lblDetalles.ForeColor = Color.FromArgb(43, 62, 80);
            lblDetalles.Location = new Point(85, 164);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(99, 21);
            lblDetalles.TabIndex = 55;
            lblDetalles.Text = "Detalles sala:";
            // 
            // cmbSala
            // 
            cmbSala.BackColor = Color.White;
            cmbSala.Font = new Font("Segoe UI", 12F);
            cmbSala.ForeColor = Color.Gray;
            cmbSala.FormattingEnabled = true;
            cmbSala.ItemHeight = 21;
            cmbSala.Items.AddRange(new object[] { "Sala 1", "Sala 2", "Sala 3" });
            cmbSala.Location = new Point(85, 103);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(299, 29);
            cmbSala.TabIndex = 54;
            cmbSala.Text = "Sala:";
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.White;
            txtResponsable.Font = new Font("Segoe UI", 12F);
            txtResponsable.ForeColor = SystemColors.WindowText;
            txtResponsable.Location = new Point(85, 30);
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
            // frmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(lblTitulo);
            Controls.Add(pnlReservaciones);
            ForeColor = Color.Gray;
            Name = "frmReservaciones";
            Text = "Reservaciones";
            pnlReservaciones.ResumeLayout(false);
            pnlReservaciones.PerformLayout();
            pnlNota.ResumeLayout(false);
            pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).EndInit();
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
        private PictureBox pcbDepartamentos;
        private PictureBox pcbSala;
        private PictureBox pcbResponsable;
        internal TextBox txtDetalles;
        internal ComboBox cmbAsistentes;
        internal TextBox txtDescripcion;
        internal ComboBox cmbEvento;
        internal ComboBox cmbHoraTermino;
        internal ComboBox cmbHoraInicio;
        internal Label lblFechaF;
        internal DateTimePicker dtpReserva;
        internal Label lblFechaR;
        internal ComboBox cmbDepartamentos;
        internal Label lblDetalles;
        internal ComboBox cmbSala;
        internal TextBox txtResponsable;
        private Label lblTitulo;
    }
}