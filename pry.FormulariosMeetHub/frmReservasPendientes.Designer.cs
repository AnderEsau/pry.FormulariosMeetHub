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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlReservacionesP = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            grpDetalles = new GroupBox();
            dgvReservasPendientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pnlReservacionesP.SuspendLayout();
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
            pnlReservacionesP.Controls.Add(btnAceptar);
            pnlReservacionesP.Controls.Add(grpDetalles);
            pnlReservacionesP.Controls.Add(dgvReservasPendientes);
            pnlReservacionesP.Dock = DockStyle.Bottom;
            pnlReservacionesP.Location = new Point(0, 59);
            pnlReservacionesP.Name = "pnlReservacionesP";
            pnlReservacionesP.Size = new Size(1119, 497);
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
            btnCancelar.Location = new Point(643, 431);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
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
            btnAceptar.Location = new Point(448, 431);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 33);
            btnAceptar.TabIndex = 36;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = Color.FromArgb(231, 238, 246);
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
            dgvReservasPendientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvReservasPendientes.EnableHeadersVisualStyles = false;
            dgvReservasPendientes.Location = new Point(57, 15);
            dgvReservasPendientes.Margin = new Padding(2);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(516, 356);
            dgvReservasPendientes.TabIndex = 34;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 62, 80);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "text1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "text2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "text3";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(pnlReservacionesP);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            pnlReservacionesP.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}