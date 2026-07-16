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
            btnCancelar = new Button();
            btnAutorizar = new Button();
            grpDetalles = new GroupBox();
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
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(353, 47);
            lblTitulo.TabIndex = 74;
            lblTitulo.Text = "Reservas Pendientes";
            // 
            // pnlReservacionesP
            // 
            pnlReservacionesP.Controls.Add(btnCancelar);
            pnlReservacionesP.Controls.Add(btnAutorizar);
            pnlReservacionesP.Controls.Add(grpDetalles);
            pnlReservacionesP.Controls.Add(dgvReservasPendientes);
            pnlReservacionesP.Dock = DockStyle.Bottom;
            pnlReservacionesP.Location = new Point(0, 74);
            pnlReservacionesP.Name = "pnlReservacionesP";
            pnlReservacionesP.Size = new Size(1103, 443);
            pnlReservacionesP.TabIndex = 75;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 195, 175);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(42, 36, 33);
            btnCancelar.Location = new Point(640, 400);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.FromArgb(43, 62, 80);
            btnAutorizar.Cursor = Cursors.Hand;
            btnAutorizar.FlatAppearance.BorderSize = 0;
            btnAutorizar.FlatStyle = FlatStyle.Flat;
            btnAutorizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorizar.ForeColor = Color.White;
            btnAutorizar.Location = new Point(445, 400);
            btnAutorizar.Margin = new Padding(1);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(112, 33);
            btnAutorizar.TabIndex = 36;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = Color.FromArgb(231, 238, 246);
            grpDetalles.Controls.Add(txtMotivo);
            grpDetalles.Controls.Add(txtDescripcion);
            grpDetalles.Controls.Add(txtTotalAsistentes);
            grpDetalles.Controls.Add(txtTipoEvento);
            grpDetalles.Controls.Add(txtHoraFin);
            grpDetalles.Controls.Add(txtHoraInicio);
            grpDetalles.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalles.ForeColor = Color.FromArgb(63, 95, 132);
            grpDetalles.Location = new Point(683, 15);
            grpDetalles.Margin = new Padding(2);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(2);
            grpDetalles.Size = new Size(366, 356);
            grpDetalles.TabIndex = 35;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ControlLight;
            txtMotivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtMotivo.Location = new Point(21, 193);
            txtMotivo.Margin = new Padding(2);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.Size = new Size(325, 31);
            txtMotivo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.ControlLight;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.Location = new Point(21, 145);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(325, 31);
            txtDescripcion.TabIndex = 4;
            // 
            // txtTotalAsistentes
            // 
            txtTotalAsistentes.BackColor = SystemColors.ControlLight;
            txtTotalAsistentes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTotalAsistentes.Location = new Point(212, 92);
            txtTotalAsistentes.Margin = new Padding(2);
            txtTotalAsistentes.Name = "txtTotalAsistentes";
            txtTotalAsistentes.ReadOnly = true;
            txtTotalAsistentes.Size = new Size(134, 29);
            txtTotalAsistentes.TabIndex = 3;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.BackColor = SystemColors.ControlLight;
            txtTipoEvento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTipoEvento.Location = new Point(21, 92);
            txtTipoEvento.Margin = new Padding(2);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(132, 29);
            txtTipoEvento.TabIndex = 2;
            // 
            // txtHoraFin
            // 
            txtHoraFin.BackColor = SystemColors.ControlLight;
            txtHoraFin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtHoraFin.Location = new Point(239, 39);
            txtHoraFin.Margin = new Padding(2);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.ReadOnly = true;
            txtHoraFin.Size = new Size(106, 29);
            txtHoraFin.TabIndex = 1;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = SystemColors.ControlLight;
            txtHoraInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoraInicio.Location = new Point(21, 39);
            txtHoraInicio.Margin = new Padding(2);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ReadOnly = true;
            txtHoraInicio.Size = new Size(106, 29);
            txtHoraInicio.TabIndex = 0;
            // 
            // dgvReservasPendientes
            // 
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
            dgvReservasPendientes.Location = new Point(38, 15);
            dgvReservasPendientes.Margin = new Padding(2);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(516, 356);
            dgvReservasPendientes.TabIndex = 34;
            dgvReservasPendientes.SelectionChanged += dgvReservasPendientes_SelectionChanged;
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1103, 517);
            Controls.Add(pnlReservacionesP);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Button btnCancelar;
        private Button btnAutorizar;
        private GroupBox grpDetalles;
        private DataGridView dgvReservasPendientes;
        private TextBox txtHoraFin;
        private TextBox txtHoraInicio;
        private TextBox txtTotalAsistentes;
        private TextBox txtTipoEvento;
        private TextBox txtMotivo;
        private TextBox txtDescripcion;
    }
}