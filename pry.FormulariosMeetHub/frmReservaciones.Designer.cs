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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pcbSala = new PictureBox();
            txtDetalles = new TextBox();
            lblDetalles = new Label();
            cmbSala = new ComboBox();
            dgvReservaciones = new DataGridView();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblFecha = new Label();
            panel1 = new Panel();
            lblEstadoR = new Label();
            lblFolio = new Label();
            lblHoraTermino = new Label();
            lblHoraInicio = new Label();
            txtEstadoR = new TextBox();
            txtOtro = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            txtFolio = new TextBox();
            btnAgregar = new Button();
            cmbTipoResponsable = new ComboBox();
            pnlNota = new Panel();
            pcbNota = new PictureBox();
            lblNota = new Label();
            btnReservar = new Button();
            pcbResponsable = new PictureBox();
            txtDescripcion = new TextBox();
            cmbEvento = new ComboBox();
            txtResponsable = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbSala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            panel1.SuspendLayout();
            pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).BeginInit();
            SuspendLayout();
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
            // pcbSala
            // 
            pcbSala.Image = (Image)resources.GetObject("pcbSala.Image");
            pcbSala.Location = new Point(32, 64);
            pcbSala.Name = "pcbSala";
            pcbSala.Size = new Size(40, 40);
            pcbSala.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSala.TabIndex = 87;
            pcbSala.TabStop = false;
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.White;
            txtDetalles.Font = new Font("Segoe UI", 12F);
            txtDetalles.ForeColor = SystemColors.WindowText;
            txtDetalles.Location = new Point(78, 132);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.ReadOnly = true;
            txtDetalles.ScrollBars = ScrollBars.Vertical;
            txtDetalles.Size = new Size(299, 53);
            txtDetalles.TabIndex = 85;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDetalles.ForeColor = Color.FromArgb(43, 62, 80);
            lblDetalles.Location = new Point(78, 108);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(142, 21);
            lblDetalles.TabIndex = 78;
            lblDetalles.Text = "Detalles de la sala:";
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
            cmbSala.Location = new Point(78, 71);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(299, 29);
            cmbSala.TabIndex = 77;
            cmbSala.SelectedIndexChanged += cmbSala_SelectedIndexChanged;
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.AllowUserToAddRows = false;
            dgvReservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservaciones.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservaciones.EnableHeadersVisualStyles = false;
            dgvReservaciones.Location = new Point(11, 240);
            dgvReservaciones.Margin = new Padding(2);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservaciones.RowHeadersVisible = false;
            dgvReservaciones.RowHeadersWidth = 62;
            dgvReservaciones.Size = new Size(689, 278);
            dgvReservaciones.TabIndex = 118;
            dgvReservaciones.CellFormatting += dgvHorario_CellFormatting;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(210, 195, 175);
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.FromArgb(42, 36, 33);
            btnAnterior.Location = new Point(135, 208);
            btnAnterior.Margin = new Padding(1);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(92, 27);
            btnAnterior.TabIndex = 121;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(210, 195, 175);
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.FromArgb(42, 36, 33);
            btnSiguiente.Location = new Point(481, 208);
            btnSiguiente.Margin = new Padding(1);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(92, 27);
            btnSiguiente.TabIndex = 122;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(42, 36, 33);
            lblFecha.Location = new Point(253, 213);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 16);
            lblFecha.TabIndex = 123;
            lblFecha.Text = "---------";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblEstadoR);
            panel1.Controls.Add(lblFolio);
            panel1.Controls.Add(lblHoraTermino);
            panel1.Controls.Add(lblHoraInicio);
            panel1.Controls.Add(txtEstadoR);
            panel1.Controls.Add(txtOtro);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtFolio);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cmbTipoResponsable);
            panel1.Controls.Add(pnlNota);
            panel1.Controls.Add(btnReservar);
            panel1.Controls.Add(pcbResponsable);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(cmbEvento);
            panel1.Controls.Add(txtResponsable);
            panel1.Location = new Point(720, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 596);
            panel1.TabIndex = 124;
            // 
            // lblEstadoR
            // 
            lblEstadoR.AutoSize = true;
            lblEstadoR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstadoR.ForeColor = Color.FromArgb(43, 62, 80);
            lblEstadoR.Location = new Point(233, 28);
            lblEstadoR.Name = "lblEstadoR";
            lblEstadoR.Size = new Size(148, 21);
            lblEstadoR.TabIndex = 144;
            lblEstadoR.Text = "Estado de Reserva:";
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFolio.ForeColor = Color.FromArgb(43, 62, 80);
            lblFolio.Location = new Point(52, 28);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(50, 21);
            lblFolio.TabIndex = 143;
            lblFolio.Text = "Folio:";
            // 
            // lblHoraTermino
            // 
            lblHoraTermino.AutoSize = true;
            lblHoraTermino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHoraTermino.ForeColor = Color.FromArgb(43, 62, 80);
            lblHoraTermino.Location = new Point(249, 253);
            lblHoraTermino.Name = "lblHoraTermino";
            lblHoraTermino.Size = new Size(113, 21);
            lblHoraTermino.TabIndex = 142;
            lblHoraTermino.Text = "Hora Termino:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHoraInicio.ForeColor = Color.FromArgb(43, 62, 80);
            lblHoraInicio.Location = new Point(55, 253);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(94, 21);
            lblHoraInicio.TabIndex = 141;
            lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtEstadoR
            // 
            txtEstadoR.BackColor = Color.White;
            txtEstadoR.Font = new Font("Segoe UI", 12F);
            txtEstadoR.ForeColor = SystemColors.WindowText;
            txtEstadoR.Location = new Point(236, 52);
            txtEstadoR.Name = "txtEstadoR";
            txtEstadoR.PlaceholderText = "Disponible";
            txtEstadoR.ReadOnly = true;
            txtEstadoR.Size = new Size(150, 29);
            txtEstadoR.TabIndex = 140;
            // 
            // txtOtro
            // 
            txtOtro.BackColor = Color.White;
            txtOtro.Font = new Font("Segoe UI", 12F);
            txtOtro.ForeColor = SystemColors.WindowText;
            txtOtro.Location = new Point(55, 213);
            txtOtro.Name = "txtOtro";
            txtOtro.PlaceholderText = "Especifique el tipo de evento";
            txtOtro.Size = new Size(310, 29);
            txtOtro.TabIndex = 139;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "   hh:00 tt";
            dateTimePicker2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(249, 277);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(116, 26);
            dateTimePicker2.TabIndex = 138;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "   hh:00 tt";
            dateTimePicker1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(55, 277);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(116, 26);
            dateTimePicker1.TabIndex = 137;
            // 
            // txtFolio
            // 
            txtFolio.BackColor = Color.White;
            txtFolio.Font = new Font("Segoe UI", 12F);
            txtFolio.ForeColor = SystemColors.WindowText;
            txtFolio.Location = new Point(55, 52);
            txtFolio.Name = "txtFolio";
            txtFolio.PlaceholderText = "Nuevo";
            txtFolio.ReadOnly = true;
            txtFolio.Size = new Size(150, 29);
            txtFolio.TabIndex = 136;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(358, 94);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(37, 33);
            btnAgregar.TabIndex = 135;
            btnAgregar.UseVisualStyleBackColor = false;
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
            cmbTipoResponsable.Location = new Point(55, 97);
            cmbTipoResponsable.Name = "cmbTipoResponsable";
            cmbTipoResponsable.Size = new Size(299, 29);
            cmbTipoResponsable.TabIndex = 134;
            // 
            // pnlNota
            // 
            pnlNota.Controls.Add(pcbNota);
            pnlNota.Controls.Add(lblNota);
            pnlNota.Location = new Point(55, 397);
            pnlNota.Name = "pnlNota";
            pnlNota.Size = new Size(310, 134);
            pnlNota.TabIndex = 133;
            // 
            // pcbNota
            // 
            pcbNota.Image = (Image)resources.GetObject("pcbNota.Image");
            pcbNota.Location = new Point(7, 11);
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
            lblNota.Location = new Point(53, 2);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(244, 126);
            lblNota.TabIndex = 17;
            lblNota.Text = "Nota: \r\nLa adecuación de los\r\nespacios debe ser solicitada\r\npor la persona interesada\r\na la Dirección de Administración\r\ny Finanzas";
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(43, 62, 80);
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatAppearance.BorderSize = 0;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservar.ForeColor = Color.White;
            btnReservar.Location = new Point(108, 535);
            btnReservar.Margin = new Padding(1);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(217, 33);
            btnReservar.TabIndex = 132;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            // 
            // pcbResponsable
            // 
            pcbResponsable.Image = (Image)resources.GetObject("pcbResponsable.Image");
            pcbResponsable.Location = new Point(9, 90);
            pcbResponsable.Name = "pcbResponsable";
            pcbResponsable.Size = new Size(40, 40);
            pcbResponsable.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbResponsable.TabIndex = 131;
            pcbResponsable.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = SystemColors.WindowText;
            txtDescripcion.Location = new Point(55, 321);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del evento";
            txtDescripcion.Size = new Size(310, 67);
            txtDescripcion.TabIndex = 130;
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = Color.White;
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbEvento.ForeColor = SystemColors.WindowText;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "Seleccione el Tipo de Evento:", "Platica", "Curso", "Presentación", "Simposio", "Seminario", "Reunión", "Taller", "Mesa Redonda", "Coloquio", "Conferencia", "Foro", "Videoconferencia", "Congreso", "Otro" });
            cmbEvento.Location = new Point(55, 178);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(310, 29);
            cmbEvento.TabIndex = 129;
            cmbEvento.UseWaitCursor = true;
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.White;
            txtResponsable.Font = new Font("Segoe UI", 12F);
            txtResponsable.ForeColor = SystemColors.WindowText;
            txtResponsable.Location = new Point(55, 132);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.PlaceholderText = "Responsable de la Reserva";
            txtResponsable.Size = new Size(299, 29);
            txtResponsable.TabIndex = 126;
            // 
            // frmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(panel1);
            Controls.Add(lblFecha);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(dgvReservaciones);
            Controls.Add(pcbSala);
            Controls.Add(txtDetalles);
            Controls.Add(lblDetalles);
            Controls.Add(cmbSala);
            Controls.Add(lblTitulo);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReservaciones";
            Text = "Reservaciones";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)pcbSala).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlNota.ResumeLayout(false);
            pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbResponsable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal DateTimePicker dtpFormalizacion;
        internal DateTimePicker dtpReserva;
        private PictureBox pcbDepartamentos;
        internal ComboBox cmbDepartamentos;
        private Label lblTitulo;
        private PictureBox pcbSala;
        internal TextBox txtDetalles;
        internal Label lblDetalles;
        internal ComboBox cmbSala;
        private DataGridView dgvReservaciones;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblFecha;
        private Panel panel1;
        internal TextBox txtFolio;
        private Button btnAgregar;
        internal ComboBox cmbTipoResponsable;
        private Panel pnlNota;
        private PictureBox pcbNota;
        internal Label lblNota;
        private Button btnReservar;
        private PictureBox pcbResponsable;
        internal TextBox txtDescripcion;
        internal ComboBox cmbEvento;
        internal TextBox txtResponsable;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        internal TextBox txtOtro;
        internal Label lblFolio;
        internal Label lblHoraTermino;
        internal Label lblHoraInicio;
        internal TextBox txtEstadoR;
        internal Label lblEstadoR;
    }
}