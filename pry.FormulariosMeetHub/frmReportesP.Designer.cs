namespace pry.FormulariosMeetHub
{
    partial class frmReportesP
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlReporte = new Panel();
            btnGuardar = new Button();
            dgvReporte = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            lblHasta = new Label();
            lblDesde = new Label();
            pnlReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
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
            lblTitulo.Size = new Size(317, 47);
            lblTitulo.TabIndex = 75;
            lblTitulo.Text = "Reporte Periodico";
            // 
            // pnlReporte
            // 
            pnlReporte.Controls.Add(btnGuardar);
            pnlReporte.Controls.Add(dgvReporte);
            pnlReporte.Controls.Add(dtpFinal);
            pnlReporte.Controls.Add(dtpInicio);
            pnlReporte.Controls.Add(lblHasta);
            pnlReporte.Controls.Add(lblDesde);
            pnlReporte.Dock = DockStyle.Bottom;
            pnlReporte.Location = new Point(0, 82);
            pnlReporte.Name = "pnlReporte";
            pnlReporte.Size = new Size(1119, 474);
            pnlReporte.TabIndex = 76;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 62, 80);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(520, 411);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 33);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvReporte
            // 
            dgvReporte.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column1, Column2, Column3, Column4, Column5 });
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(23, 82);
            dgvReporte.Margin = new Padding(2);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.Size = new Size(1074, 258);
            dgvReporte.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "text1";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "text2";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "text3";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "text4";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "text5";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "text6";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "text7";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "text8";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // dtpFinal
            // 
            dtpFinal.CalendarFont = new Font("Arial", 12F);
            dtpFinal.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpFinal.Font = new Font("Arial", 11F);
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(432, 15);
            dtpFinal.Margin = new Padding(2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(168, 24);
            dtpFinal.TabIndex = 39;
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarFont = new Font("Arial", 12F);
            dtpInicio.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpInicio.Font = new Font("Arial", 11F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(91, 16);
            dtpInicio.Margin = new Padding(2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(151, 24);
            dtpInicio.TabIndex = 38;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHasta.ForeColor = Color.FromArgb(63, 95, 132);
            lblHasta.Location = new Point(369, 17);
            lblHasta.Margin = new Padding(2, 0, 2, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(55, 21);
            lblHasta.TabIndex = 37;
            lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDesde.ForeColor = Color.FromArgb(63, 95, 132);
            lblDesde.Location = new Point(23, 18);
            lblDesde.Margin = new Padding(2, 0, 2, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(60, 21);
            lblDesde.TabIndex = 36;
            lblDesde.Text = "Desde:";
            // 
            // frmReportesP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(pnlReporte);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "frmReportesP";
            Text = "Reporte periodico";
            pnlReporte.ResumeLayout(false);
            pnlReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbLogotipo;
        private Label lblTitulo;
        private Panel pnlReporte;
        private Button btnGuardar;
        private DataGridView dgvReporte;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private Label lblHasta;
        private Label lblDesde;
    }
}