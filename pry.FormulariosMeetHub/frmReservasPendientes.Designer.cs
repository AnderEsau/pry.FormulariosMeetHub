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
            btnAceptar = new Button();
            btnRechazar = new Button();
            dgvReservasPendientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            grpDetalles = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(235, 197, 153);
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAceptar.Location = new Point(215, 368);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(139, 55);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.FromArgb(235, 197, 153);
            btnRechazar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRechazar.Location = new Point(421, 368);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(139, 55);
            btnRechazar.TabIndex = 1;
            btnRechazar.Text = "RECHAZA";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // dgvReservasPendientes
            // 
            dgvReservasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasPendientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvReservasPendientes.Location = new Point(36, 12);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(359, 328);
            dgvReservasPendientes.TabIndex = 2;
            // 
            // Column1
            // 
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
            // grpDetalles
            // 
            grpDetalles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetalles.Location = new Point(466, 28);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(300, 215);
            grpDetalles.TabIndex = 3;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDetalles);
            Controls.Add(dgvReservasPendientes);
            Controls.Add(btnRechazar);
            Controls.Add(btnAceptar);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnRechazar;
        private DataGridView dgvReservasPendientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox grpDetalles;
    }
}