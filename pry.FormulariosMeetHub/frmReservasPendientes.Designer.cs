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
            btnAceptar = new Button();
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
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(537, 71);
            lblTitulo.TabIndex = 74;
            lblTitulo.Text = "Reservas Pendientes";
            // 
            // pnlReservacionesP
            // 
            pnlReservacionesP.Controls.Add(btnCancelar);
            pnlReservacionesP.Controls.Add(btnAceptar);
            pnlReservacionesP.Controls.Add(grpDetalles);
            pnlReservacionesP.Controls.Add(dgvReservasPendientes);
            pnlReservacionesP.Dock = DockStyle.Bottom;
            pnlReservacionesP.Location = new Point(0, 99);
            pnlReservacionesP.Margin = new Padding(4, 5, 4, 5);
            pnlReservacionesP.Name = "pnlReservacionesP";
            pnlReservacionesP.Size = new Size(1599, 828);
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
            btnCancelar.Location = new Point(919, 718);
            btnCancelar.Margin = new Padding(1, 2, 1, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 55);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 62, 80);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(640, 718);
            btnAceptar.Margin = new Padding(1, 2, 1, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(160, 55);
            btnAceptar.TabIndex = 36;
            btnAceptar.Text = "Autorizar";
            btnAceptar.UseVisualStyleBackColor = false;
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
            grpDetalles.Location = new Point(976, 25);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(523, 593);
            grpDetalles.TabIndex = 35;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.ControlLight;
            txtMotivo.Location = new Point(30, 322);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.Size = new Size(462, 49);
            txtMotivo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.ControlLight;
            txtDescripcion.Location = new Point(30, 241);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(462, 49);
            txtDescripcion.TabIndex = 4;
            // 
            // txtTotalAsistentes
            // 
            txtTotalAsistentes.BackColor = SystemColors.ControlLight;
            txtTotalAsistentes.Location = new Point(303, 153);
            txtTotalAsistentes.Name = "txtTotalAsistentes";
            txtTotalAsistentes.ReadOnly = true;
            txtTotalAsistentes.Size = new Size(189, 49);
            txtTotalAsistentes.TabIndex = 3;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.BackColor = SystemColors.ControlLight;
            txtTipoEvento.Location = new Point(30, 153);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(187, 49);
            txtTipoEvento.TabIndex = 2;
            // 
            // txtHoraFin
            // 
            txtHoraFin.BackColor = SystemColors.ControlLight;
            txtHoraFin.Location = new Point(342, 65);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.ReadOnly = true;
            txtHoraFin.Size = new Size(150, 49);
            txtHoraFin.TabIndex = 1;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = SystemColors.ControlLight;
            txtHoraInicio.Location = new Point(30, 65);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ReadOnly = true;
            txtHoraInicio.Size = new Size(150, 49);
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
        private Button btnCancelar;
        private Button btnAceptar;
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