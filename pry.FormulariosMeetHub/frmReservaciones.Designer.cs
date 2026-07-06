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
            pcbLogotipo = new PictureBox();
            txtDetalles = new TextBox();
            pcbNota = new PictureBox();
            pcbResponsable = new PictureBox();
            pcbSala = new PictureBox();
            pcbDepartamentos = new PictureBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dtpFormalizacion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.FromArgb(231, 238, 246);
            txtResponsable.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResponsable.ForeColor = SystemColors.WindowText;
            txtResponsable.Location = new Point(61, 30);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.PlaceholderText = "Responsable de la Reserva";
            txtResponsable.Size = new Size(299, 26);
            txtResponsable.TabIndex = 1;
            // 
            // cmbSala
            // 
            cmbSala.BackColor = Color.FromArgb(231, 238, 246);
            cmbSala.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSala.ForeColor = Color.Gray;
            cmbSala.FormattingEnabled = true;
            cmbSala.ItemHeight = 19;
            cmbSala.Items.AddRange(new object[] { "Sala 1", "Sala 2", "Sala 3" });
            cmbSala.Location = new Point(61, 79);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(299, 27);
            cmbSala.TabIndex = 2;
            cmbSala.Text = "Sala:";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalles.ForeColor = Color.Gray;
            lblDetalles.Location = new Point(61, 121);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(111, 19);
            lblDetalles.TabIndex = 3;
            lblDetalles.Text = "Detalles sala:";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.BackColor = Color.FromArgb(231, 238, 246);
            cmbDepartamentos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDepartamentos.ForeColor = Color.Gray;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Items.AddRange(new object[] { "Contabilidad", "Administracion", "Ingenieria Civil", "Agrobiotecnologia", "Mecatronica", "Mecanica", "Ingenieria en Desarrollo de Software Multiplataforma" });
            cmbDepartamentos.Location = new Point(61, 192);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(299, 27);
            cmbDepartamentos.TabIndex = 5;
            cmbDepartamentos.Text = "Àrea Academica/Departamento";
            // 
            // lblFechaR
            // 
            lblFechaR.AutoSize = true;
            lblFechaR.Font = new Font("Arial", 11F);
            lblFechaR.ForeColor = Color.Black;
            lblFechaR.Location = new Point(61, 240);
            lblFechaR.Name = "lblFechaR";
            lblFechaR.Size = new Size(131, 17);
            lblFechaR.TabIndex = 6;
            lblFechaR.Text = "Fecha De Reserva";
            // 
            // dtpReserva
            // 
            dtpReserva.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpReserva.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpReserva.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpReserva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpReserva.Location = new Point(61, 263);
            dtpReserva.Name = "dtpReserva";
            dtpReserva.Size = new Size(299, 26);
            dtpReserva.TabIndex = 7;
            // 
            // lblFechaF
            // 
            lblFechaF.AutoSize = true;
            lblFechaF.Font = new Font("Arial", 11F);
            lblFechaF.ForeColor = Color.Black;
            lblFechaF.Location = new Point(61, 301);
            lblFechaF.Name = "lblFechaF";
            lblFechaF.Size = new Size(168, 17);
            lblFechaF.TabIndex = 8;
            lblFechaF.Text = "Fecha De Formalización";
            // 
            // cmbHoraInicio
            // 
            cmbHoraInicio.BackColor = Color.FromArgb(231, 238, 246);
            cmbHoraInicio.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbHoraInicio.ForeColor = Color.Gray;
            cmbHoraInicio.FormattingEnabled = true;
            cmbHoraInicio.Location = new Point(565, 29);
            cmbHoraInicio.Name = "cmbHoraInicio";
            cmbHoraInicio.Size = new Size(250, 27);
            cmbHoraInicio.TabIndex = 10;
            cmbHoraInicio.Text = "Hora Inicio:";
            // 
            // cmbHoraTermino
            // 
            cmbHoraTermino.BackColor = Color.FromArgb(231, 238, 246);
            cmbHoraTermino.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbHoraTermino.ForeColor = Color.Gray;
            cmbHoraTermino.FormattingEnabled = true;
            cmbHoraTermino.Location = new Point(565, 79);
            cmbHoraTermino.Name = "cmbHoraTermino";
            cmbHoraTermino.Size = new Size(250, 27);
            cmbHoraTermino.TabIndex = 11;
            cmbHoraTermino.Text = "Hora Termino:";
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = Color.FromArgb(231, 238, 246);
            cmbEvento.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEvento.ForeColor = Color.Gray;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "Escolar", "Guvernamental", "Externo" });
            cmbEvento.Location = new Point(565, 149);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(250, 27);
            cmbEvento.TabIndex = 12;
            cmbEvento.Text = "Tipo de Evento:";
            cmbEvento.UseWaitCursor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(231, 238, 246);
            txtDescripcion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(565, 192);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 26);
            txtDescripcion.TabIndex = 13;
            txtDescripcion.Text = "Descripción del evento";
            // 
            // cmbAsistentes
            // 
            cmbAsistentes.BackColor = Color.FromArgb(231, 238, 246);
            cmbAsistentes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAsistentes.ForeColor = Color.Gray;
            cmbAsistentes.FormattingEnabled = true;
            cmbAsistentes.Location = new Point(565, 260);
            cmbAsistentes.Name = "cmbAsistentes";
            cmbAsistentes.Size = new Size(250, 27);
            cmbAsistentes.TabIndex = 14;
            cmbAsistentes.Text = "Total de Asistentes:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.Black;
            lblNota.Location = new Point(1026, 27);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(51, 19);
            lblNota.TabIndex = 17;
            lblNota.Text = "Nota:";
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(1200, 0);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(102, 104);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 21;
            pcbLogotipo.TabStop = false;
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.FromArgb(231, 238, 246);
            txtDetalles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDetalles.ForeColor = SystemColors.WindowText;
            txtDetalles.Location = new Point(61, 150);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(299, 26);
            txtDetalles.TabIndex = 22;
            // 
            // pcbNota
            // 
            pcbNota.Image = (Image)resources.GetObject("pcbNota.Image");
            pcbNota.Location = new Point(970, 27);
            pcbNota.Name = "pcbNota";
            pcbNota.Size = new Size(40, 40);
            pcbNota.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(235, 197, 153);
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(520, 394);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 33);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(235, 197, 153);
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(374, 394);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 33);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // dtpFormalizacion
            // 
            dtpFormalizacion.CalendarFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFormalizacion.CalendarForeColor = Color.FromArgb(63, 95, 132);
            dtpFormalizacion.CalendarTitleBackColor = Color.FromArgb(231, 238, 246);
            dtpFormalizacion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFormalizacion.Location = new Point(61, 321);
            dtpFormalizacion.Name = "dtpFormalizacion";
            dtpFormalizacion.Size = new Size(299, 26);
            dtpFormalizacion.TabIndex = 29;
            // 
            // frmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 220, 228);
            ClientSize = new Size(1303, 445);
            Controls.Add(dtpFormalizacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(pcbDepartamentos);
            Controls.Add(pcbSala);
            Controls.Add(pcbResponsable);
            Controls.Add(pcbNota);
            Controls.Add(txtDetalles);
            Controls.Add(pcbLogotipo);
            Controls.Add(lblNota);
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
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDepartamentos).EndInit();
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
        private PictureBox pcbLogotipo;
        internal TextBox txtDetalles;
        private PictureBox pcbNota;
        private PictureBox pcbResponsable;
        private PictureBox pcbSala;
        private PictureBox pcbDepartamentos;
        private Button btnCancelar;
        private Button btnAceptar;
        internal DateTimePicker dtpFormalizacion;
    }
}