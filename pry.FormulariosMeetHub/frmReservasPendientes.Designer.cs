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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservasPendientes));
            btnAceptar = new Button();
            btnRechazar = new Button();
            dgvReservasPendientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            grpDetalles = new GroupBox();
            pcbLogotipo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(235, 197, 153);
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAceptar.Location = new Point(500, 382);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 33);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Autorizar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.FromArgb(235, 197, 153);
            btnRechazar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRechazar.Location = new Point(684, 382);
            btnRechazar.Margin = new Padding(2);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(97, 33);
            btnRechazar.TabIndex = 1;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // dgvReservasPendientes
            // 
            dgvReservasPendientes.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasPendientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvReservasPendientes.EnableHeadersVisualStyles = false;
            dgvReservasPendientes.Location = new Point(11, 11);
            dgvReservasPendientes.Margin = new Padding(2);
            dgvReservasPendientes.Name = "dgvReservasPendientes";
            dgvReservasPendientes.RowHeadersWidth = 62;
            dgvReservasPendientes.Size = new Size(516, 356);
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
            // Column3
            // 
            Column3.HeaderText = "text3";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // grpDetalles
            // 
            grpDetalles.BackColor = SystemColors.ControlDark;
            grpDetalles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetalles.Location = new Point(580, 11);
            grpDetalles.Margin = new Padding(2);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(2);
            grpDetalles.Size = new Size(366, 356);
            grpDetalles.TabIndex = 3;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles de la Reserva:";
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(1201, 0);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(102, 104);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 17;
            pcbLogotipo.TabStop = false;
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 220, 228);
            ClientSize = new Size(1303, 445);
            Controls.Add(pcbLogotipo);
            Controls.Add(grpDetalles);
            Controls.Add(dgvReservasPendientes);
            Controls.Add(btnRechazar);
            Controls.Add(btnAceptar);
            Margin = new Padding(2);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            ((System.ComponentModel.ISupportInitialize)dgvReservasPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnRechazar;
        private DataGridView dgvReservasPendientes;
        private GroupBox grpDetalles;
        private PictureBox pcbLogotipo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}