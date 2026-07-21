namespace pry.FormulariosMeetHub
{
    partial class frmReservasPendientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlReservacionesP = new Panel();
            btnRechazar = new Button();
            btnAutorizar = new Button();
            grpDetalles = new GroupBox();
            lblMotivo = new Label();
            lblDescripcion = new Label();
            lblTotalAsistentes = new Label();
            lblTipoEvento = new Label();
            lblHoraFin = new Label();
            lblFechaInicio = new Label();
            txtMotivo = new TextBox();
            txtDescripcion = new TextBox();
            txtTotalAsistentes = new TextBox();
            txtTipoEvento = new TextBox();
            txtHoraFin = new TextBox();
            txtHoraInicio = new TextBox();
            dgvReservasPendientes = new DataGridView();
            pnlReservacionesP.SuspendLayout();
            grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 62, 80);
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(537, 71);
            lblTitulo.TabIndex = 74;
            lblTitulo.Text = "Reservas Pendientes";
            // 
            // pnlReservacionesP
            // 
            pnlReservacionesP.Controls.Add(btnRechazar);
            pnlReservacionesP.Controls.Add(btnAutorizar);
            pnlReservacionesP.Controls.Add(grpDetalles);
            pnlReservacionesP.Controls.Add(dgvReservasPendientes);
            pnlReservacionesP.Dock = DockStyle.Bottom;
            pnlReservacionesP.Location = new Point(0, 99);
            pnlReservacionesP.Margin = new Padding(4, 5, 4, 5);
            pnlReservacionesP.Name = "pnlReservacionesP";
            pnlReservacionesP.Size = new Size(1599, 828);
            pnlReservacionesP.TabIndex = 75;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.FromArgb(210, 195, 175);
            btnRechazar.Cursor = Cursors.Hand;
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazar.ForeColor = Color.FromArgb(42, 36, 33);
            btnRechazar.Location = new Point(919, 718);
            btnRechazar.Margin = new Padding(1, 2, 1, 2);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(160, 55);
            btnRechazar.TabIndex = 37;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.FromArgb(43, 62, 80);
            btnAutorizar.Cursor = Cursors.Hand;
            btnAutorizar.FlatAppearance.BorderSize = 0;
            btnAutorizar.FlatStyle = FlatStyle.Flat;
            btnAutorizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorizar.ForeColor = Color.White;
            btnAutorizar.Location = new Point(640, 718);
            btnAutorizar.Margin = new Padding(1, 2, 1, 2);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(160, 55);
            btnAutorizar.TabIndex = 36;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = Color.FromArgb(231, 238, 246);
            grpDetalles.Controls.Add(lblMotivo);
            grpDetalles.Controls.Add(lblDescripcion);
            grpDetalles.Controls.Add(lblTotalAsistentes);
            grpDetalles.Controls.Add(lblTipoEvento);
            grpDetalles.Controls.Add(lblHoraFin);
            grpDetalles.Controls.Add(lblFechaInicio);
            grpDetalles.Controls.Add(txtMotivo);
            grpDetalles.Controls.Add(txtDescripcion);
            grpDetalles.Controls.Add(txtTotalAsistentes);
            grpDetalles.Controls.Add(txtTipoEvento);
            grpDetalles.Controls.Add(txtHoraFin);
            grpDetalles.Controls.Add(txtHoraInicio);
            grpDetalles.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalles.ForeColor = Color.FromArgb(63, 95, 132);
            grpDetalles.Location = new Point(976, 25);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(523, 593);
            grpDetalles.TabIndex = 35;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(30, 480);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(218, 32);
            lblMotivo.TabIndex = 11;
            lblMotivo.Text = "Motivo del Evento:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(30, 383);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(266, 32);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripción del Evento:";
            // 
            // lblTotalAsistentes
            // 
            lblTotalAsistentes.AutoSize = true;
            lblTotalAsistentes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAsistentes.Location = new Point(30, 276);
            lblTotalAsistentes.Name = "lblTotalAsistentes";
            lblTotalAsistentes.Size = new Size(224, 32);
            lblTotalAsistentes.TabIndex = 9;
            lblTotalAsistentes.Text = "Total de Asistentes:";
            // 
            // lblTipoEvento
            // 
            lblTipoEvento.AutoSize = true;
            lblTipoEvento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoEvento.Location = new Point(30, 173);
            lblTipoEvento.Name = "lblTipoEvento";
            lblTipoEvento.Size = new Size(182, 32);
            lblTipoEvento.TabIndex = 8;
            lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraFin.Location = new Point(310, 69);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(147, 32);
            lblHoraFin.TabIndex = 7;
            lblHoraFin.Text = "Hora de Fin:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicio.Location = new Point(30, 69);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(182, 32);
            lblFechaInicio.TabIndex = 6;
            lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ControlLight;
            txtMotivo.Location = new Point(30, 515);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.Size = new Size(462, 49);
            txtMotivo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.ControlLight;
            txtDescripcion.Location = new Point(30, 418);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(462, 49);
            txtDescripcion.TabIndex = 4;
            // 
            // txtTotalAsistentes
            // 
            txtTotalAsistentes.BackColor = SystemColors.ControlLight;
            txtTotalAsistentes.Location = new Point(30, 311);
            txtTotalAsistentes.Name = "txtTotalAsistentes";
            txtTotalAsistentes.ReadOnly = true;
            txtTotalAsistentes.Size = new Size(462, 49);
            txtTotalAsistentes.TabIndex = 3;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.BackColor = SystemColors.ControlLight;
            txtTipoEvento.Location = new Point(30, 208);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(462, 49);
            txtTipoEvento.TabIndex = 2;
            // 
            // txtHoraFin
            // 
            txtHoraFin.BackColor = SystemColors.ControlLight;
            txtHoraFin.Location = new Point(310, 104);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.ReadOnly = true;
            txtHoraFin.Size = new Size(182, 49);
            txtHoraFin.TabIndex = 1;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = SystemColors.ControlLight;
            txtHoraInicio.Location = new Point(30, 104);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ReadOnly = true;
            txtHoraInicio.Size = new Size(182, 49);
            txtHoraInicio.TabIndex = 0;
            // 
            // dgvReservasPendientes
            // 
            dgvReservasPendientes.AllowUserToAddRows = false;
            dgvReservasPendientes.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasPendientes.EnableHeadersVisualStyles = false;
            dgvReservasPendientes.Location = new Point(54, 25);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservasPendientes.RowHeadersVisible = false;
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(737, 593);
            dgvReservasPendientes.TabIndex = 34;
            dgvReservasPendientes.SelectionChanged += dgvReservasPendientes_SelectionChanged;
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1599, 927);
            Controls.Add(pnlReservacionesP);
            Controls.Add(lblTitulo);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            pnlReservacionesP.ResumeLayout(false);
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Panel pnlReservacionesP;
        private Button btnRechazar;
        private Button btnAutorizar;
        private GroupBox grpDetalles;
        private DataGridView dgvReservasPendientes;
        private TextBox txtHoraFin;
        private TextBox txtHoraInicio;
        private TextBox txtTotalAsistentes;
        private TextBox txtTipoEvento;
        private TextBox txtMotivo;
        private TextBox txtDescripcion;
        private Label lblFechaInicio;
        private Label lblMotivo;
        private Label lblDescripcion;
        private Label lblTotalAsistentes;
        private Label lblTipoEvento;
        private Label lblHoraFin;
    }
}