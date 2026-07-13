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
            txtResponsable = new TextBox();
            cmbSala = new ComboBox();
            lblDetalles = new Label();
            cmbDepartamentos = new ComboBox();
            lblFechaR = new Label();
            dtpReserva = new DateTimePicker();
            lblFechaF = new Label();
            cmbHoraInicio = new ComboBox();
            cmbHoraTermino = new ComboBox();
            cmbEvento = new ComboBox();
            txtDescripcion = new TextBox();
            cmbAsistentes = new ComboBox();
            lblNota = new Label();
            txtDetalles = new TextBox();
            pcbNota = new PictureBox();
            pcbResponsable = new PictureBox();
            pcbSala = new PictureBox();
            pcbDepartamentos = new PictureBox();
            dtpFormalizacion = new DateTimePicker();
            btnAceptar = new Button();
            btnCancelar = new Button();
            pnlNota = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcbNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).BeginInit();
            pnlNota.SuspendLayout();
            SuspendLayout();
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.White;
            txtResponsable.Font = new Font("Segoe UI", 12F);
            txtResponsable.ForeColor = SystemColors.WindowText;
            txtResponsable.Location = new Point(61, 30);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.PlaceholderText = "Responsable de la Reserva";
            txtResponsable.Size = new Size(299, 29);
            txtResponsable.TabIndex = 1;
            // 
            // cmbSala
            // 
            cmbSala.BackColor = Color.White;
            cmbSala.Font = new Font("Segoe UI", 12F);
            cmbSala.ForeColor = Color.Gray;
            cmbSala.FormattingEnabled = true;
            cmbSala.ItemHeight = 21;
            cmbSala.Items.AddRange(new object[] { "Sala 1", "Sala 2", "Sala 3" });
            cmbSala.Location = new Point(61, 79);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(299, 29);
            cmbSala.TabIndex = 2;
            cmbSala.Text = "Sala:";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Font = new Font("Segoe UI", 12F);
            lblDetalles.ForeColor = Color.FromArgb(43, 62, 80);
            lblDetalles.Location = new Point(61, 121);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(99, 21);
            lblDetalles.TabIndex = 3;
            lblDetalles.Text = "Detalles sala:";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.BackColor = Color.White;
            cmbDepartamentos.Font = new Font("Segoe UI", 12F);
            cmbDepartamentos.ForeColor = Color.Gray;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Items.AddRange(new object[] { "Contabilidad", "Administracion", "Ingenieria Civil", "Agrobiotecnologia", "Mecatronica", "Mecanica", "Ingenieria en Desarrollo de Software Multiplataforma" });
            cmbDepartamentos.Location = new Point(61, 192);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(299, 29);
            cmbDepartamentos.TabIndex = 5;
            cmbDepartamentos.Text = "Àrea Academica/Departamento";
            // 
            // lblFechaR
            // 
            lblFechaR.AutoSize = true;
            lblFechaR.Font = new Font("Segoe UI", 12F);
            lblFechaR.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaR.Location = new Point(61, 240);
            lblFechaR.Name = "lblFechaR";
            lblFechaR.Size = new Size(132, 21);
            lblFechaR.TabIndex = 6;
            lblFechaR.Text = "Fecha De Reserva";
            // 
            // dtpReserva
            // 
            dtpReserva.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpReserva.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpReserva.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpReserva.Font = new Font("Segoe UI", 12F);
            dtpReserva.Location = new Point(61, 263);
            dtpReserva.Name = "dtpReserva";
            dtpReserva.Size = new Size(299, 29);
            dtpReserva.TabIndex = 7;
            // 
            // lblFechaF
            // 
            lblFechaF.AutoSize = true;
            lblFechaF.Font = new Font("Segoe UI", 12F);
            lblFechaF.ForeColor = Color.FromArgb(43, 62, 80);
            lblFechaF.Location = new Point(61, 297);
            lblFechaF.Name = "lblFechaF";
            lblFechaF.Size = new Size(174, 21);
            lblFechaF.TabIndex = 8;
            lblFechaF.Text = "Fecha De Formalización";
            // 
            // cmbHoraInicio
            // 
            cmbHoraInicio.BackColor = Color.White;
            cmbHoraInicio.Font = new Font("Segoe UI", 12F);
            cmbHoraInicio.ForeColor = Color.Gray;
            cmbHoraInicio.FormattingEnabled = true;
            cmbHoraInicio.Location = new Point(565, 30);
            cmbHoraInicio.Name = "cmbHoraInicio";
            cmbHoraInicio.Size = new Size(250, 29);
            cmbHoraInicio.TabIndex = 10;
            cmbHoraInicio.Text = "Hora Inicio:";
            // 
            // cmbHoraTermino
            // 
            cmbHoraTermino.BackColor = Color.White;
            cmbHoraTermino.Font = new Font("Segoe UI", 12F);
            cmbHoraTermino.ForeColor = Color.Gray;
            cmbHoraTermino.FormattingEnabled = true;
            cmbHoraTermino.Location = new Point(565, 79);
            cmbHoraTermino.Name = "cmbHoraTermino";
            cmbHoraTermino.Size = new Size(250, 29);
            cmbHoraTermino.TabIndex = 11;
            cmbHoraTermino.Text = "Hora Termino:";
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = Color.White;
            cmbEvento.Font = new Font("Segoe UI", 12F);
            cmbEvento.ForeColor = Color.Gray;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "Escolar", "Guvernamental", "Externo" });
            cmbEvento.Location = new Point(565, 130);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(250, 29);
            cmbEvento.TabIndex = 12;
            cmbEvento.Text = "Tipo de Evento:";
            cmbEvento.UseWaitCursor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(565, 185);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 29);
            txtDescripcion.TabIndex = 13;
            txtDescripcion.Text = "Descripción del evento";
            // 
            // cmbAsistentes
            // 
            cmbAsistentes.BackColor = Color.White;
            cmbAsistentes.Font = new Font("Segoe UI", 12F);
            cmbAsistentes.ForeColor = Color.Gray;
            cmbAsistentes.FormattingEnabled = true;
            cmbAsistentes.Location = new Point(565, 237);
            cmbAsistentes.Name = "cmbAsistentes";
            cmbAsistentes.Size = new Size(250, 29);
            cmbAsistentes.TabIndex = 14;
            cmbAsistentes.Text = "Total de Asistentes:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.FromArgb(43, 62, 80);
            lblNota.Location = new Point(76, 9);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(50, 21);
            lblNota.TabIndex = 17;
            lblNota.Text = "Nota:";
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.White;
            txtDetalles.Font = new Font("Segoe UI", 12F);
            txtDetalles.ForeColor = SystemColors.WindowText;
            txtDetalles.Location = new Point(61, 150);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(299, 29);
            txtDetalles.TabIndex = 22;
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
            // pcbResponsable
            // 
            pcbResponsable.Image = (Image)resources.GetObject("pcbResponsable.Image");
            pcbResponsable.Location = new Point(15, 21);
            pcbResponsable.Name = "pcbResponsable";
            pcbResponsable.Size = new Size(40, 40);
            pcbResponsable.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbResponsable.TabIndex = 24;
            pcbResponsable.TabStop = false;
            // 
            // pcbSala
            // 
            pcbSala.Image = (Image)resources.GetObject("pcbSala.Image");
            pcbSala.Location = new Point(15, 72);
            pcbSala.Name = "pcbSala";
            pcbSala.Size = new Size(40, 40);
            pcbSala.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSala.TabIndex = 25;
            pcbSala.TabStop = false;
            // 
            // pcbDepartamentos
            // 
            pcbDepartamentos.Image = (Image)resources.GetObject("pcbDepartamentos.Image");
            pcbDepartamentos.Location = new Point(15, 186);
            pcbDepartamentos.Name = "pcbDepartamentos";
            pcbDepartamentos.Size = new Size(40, 40);
            pcbDepartamentos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDepartamentos.TabIndex = 26;
            pcbDepartamentos.TabStop = false;
            // 
            // dtpFormalizacion
            // 
            dtpFormalizacion.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFormalizacion.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpFormalizacion.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpFormalizacion.Font = new Font("Segoe UI", 12F);
            dtpFormalizacion.Location = new Point(61, 321);
            dtpFormalizacion.Name = "dtpFormalizacion";
            dtpFormalizacion.Size = new Size(299, 29);
            dtpFormalizacion.TabIndex = 29;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 62, 80);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(439, 394);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 33);
            btnAceptar.TabIndex = 30;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 195, 175);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(42, 36, 33);
            btnCancelar.Location = new Point(634, 394);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlNota
            // 
            pnlNota.Controls.Add(pcbNota);
            pnlNota.Controls.Add(lblNota);
            pnlNota.Location = new Point(950, 18);
            pnlNota.Name = "pnlNota";
            pnlNota.Size = new Size(232, 279);
            pnlNota.TabIndex = 32;
            // 
            // frmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1303, 445);
            Controls.Add(pnlNota);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dtpFormalizacion);
            Controls.Add(pcbDepartamentos);
            Controls.Add(pcbSala);
            Controls.Add(pcbResponsable);
            Controls.Add(txtDetalles);
            Controls.Add(cmbAsistentes);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbEvento);
            Controls.Add(cmbHoraTermino);
            Controls.Add(cmbHoraInicio);
            Controls.Add(lblFechaF);
            Controls.Add(dtpReserva);
            Controls.Add(lblFechaR);
            Controls.Add(cmbDepartamentos);
            Controls.Add(lblDetalles);
            Controls.Add(cmbSala);
            Controls.Add(txtResponsable);
            ForeColor = Color.Gray;
            Name = "frmReservaciones";
            Text = "Reservaciones";
            ((System.ComponentModel.ISupportInitialize)pcbNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).EndInit();
            pnlNota.ResumeLayout(false);
            pnlNota.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox txtResponsable;
        internal ComboBox cmbSala;
        internal Label lblDetalles;
        internal ComboBox cmbDepartamentos;
        internal Label lblFechaR;
        internal DateTimePicker dtpReserva;
        internal Label lblFechaF;
        internal ComboBox cmbHoraInicio;
        internal ComboBox cmbHoraTermino;
        internal ComboBox cmbEvento;
        internal TextBox txtDescripcion;
        internal ComboBox cmbAsistentes;
        internal Label lblNota;
        internal TextBox txtDetalles;
        private PictureBox pcbNota;
        private PictureBox pcbResponsable;
        private PictureBox pcbSala;
        private PictureBox pcbDepartamentos;
        internal DateTimePicker dtpFormalizacion;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel pnlNota;
    }
}