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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnAutorizar = new Button();
            btnRechazar = new Button();
            dgvReservasPendientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            grpDetalles = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).BeginInit();
            SuspendLayout();
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.FromArgb(43, 62, 80);
            btnAutorizar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAutorizar.ForeColor = Color.White;
            btnAutorizar.Location = new Point(614, 637);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(139, 55);
            btnAutorizar.TabIndex = 0;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.FromArgb(235, 197, 153);
            btnRechazar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRechazar.Location = new Point(829, 637);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(139, 55);
            btnRechazar.TabIndex = 1;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // dgvReservasPendientes
            // 
            dgvReservasPendientes.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasPendientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvReservasPendientes.EnableHeadersVisualStyles = false;
            dgvReservasPendientes.Location = new Point(16, 18);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(737, 593);
            dgvReservasPendientes.TabIndex = 2;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(43, 62, 80);
            Column1.DefaultCellStyle = dataGridViewCellStyle5;
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
            // grpDetalles
            // 
            grpDetalles.BackColor = Color.FromArgb(231, 238, 246);
            grpDetalles.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalles.ForeColor = Color.Black;
            grpDetalles.Location = new Point(829, 18);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(523, 593);
            grpDetalles.TabIndex = 3;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 195, 175);
            ClientSize = new Size(1861, 742);
            Controls.Add(grpDetalles);
            Controls.Add(dgvReservasPendientes);
            Controls.Add(btnRechazar);
            Controls.Add(btnAutorizar);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAutorizar;
        private Button btnRechazar;
        private DataGridView dgvReservasPendientes;
        private GroupBox grpDetalles;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}