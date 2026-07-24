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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlReporte = new Panel();
            btnVer = new Button();
            btnGenerarPdf = new Button();
            dgvReporte = new DataGridView();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            lblHasta = new Label();
            lblDesde = new Label();
            gbpOpciones = new GroupBox();
            rdbOpcion3 = new RadioButton();
            rdbOpcion2 = new RadioButton();
            rdbOpcion1 = new RadioButton();
            pnlReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            gbpOpciones.SuspendLayout();
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
            lblTitulo.Text = "Reporte Periódico";
            // 
            // pnlReporte
            // 
            pnlReporte.Controls.Add(btnVer);
            pnlReporte.Controls.Add(btnGenerarPdf);
            pnlReporte.Controls.Add(dgvReporte);
            pnlReporte.Controls.Add(dtpFinal);
            pnlReporte.Controls.Add(dtpInicio);
            pnlReporte.Controls.Add(lblHasta);
            pnlReporte.Controls.Add(lblDesde);
            pnlReporte.Dock = DockStyle.Bottom;
            pnlReporte.Location = new Point(0, 182);
            pnlReporte.Name = "pnlReporte";
            pnlReporte.Size = new Size(1135, 413);
            pnlReporte.TabIndex = 76;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(210, 195, 175);
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.FromArgb(42, 36, 33);
            btnVer.Location = new Point(494, 43);
            btnVer.Margin = new Padding(1);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(183, 33);
            btnVer.TabIndex = 73;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnGenerarPdf
            // 
            btnGenerarPdf.BackColor = Color.FromArgb(43, 62, 80);
            btnGenerarPdf.Cursor = Cursors.Hand;
            btnGenerarPdf.FlatAppearance.BorderSize = 0;
            btnGenerarPdf.FlatStyle = FlatStyle.Flat;
            btnGenerarPdf.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPdf.ForeColor = Color.White;
            btnGenerarPdf.Location = new Point(494, 337);
            btnGenerarPdf.Margin = new Padding(1);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(183, 33);
            btnGenerarPdf.TabIndex = 41;
            btnGenerarPdf.Text = "Generar PDF";
            btnGenerarPdf.UseVisualStyleBackColor = false;
            btnGenerarPdf.Click += btnGenerarPdf_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(39, 79);
            dgvReporte.Margin = new Padding(2);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.Size = new Size(1032, 241);
            dgvReporte.TabIndex = 40;
            // 
            // dtpFinal
            // 
            dtpFinal.CalendarFont = new Font("Arial", 12F);
            dtpFinal.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpFinal.Font = new Font("Arial", 11F);
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(431, 9);
            dtpFinal.Margin = new Padding(2);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(168, 24);
            dtpFinal.TabIndex = 39;
            dtpFinal.Visible = false;
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarFont = new Font("Arial", 12F);
            dtpInicio.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpInicio.Font = new Font("Arial", 11F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(90, 10);
            dtpInicio.Margin = new Padding(2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(151, 24);
            dtpInicio.TabIndex = 38;
            dtpInicio.Visible = false;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHasta.ForeColor = Color.FromArgb(63, 95, 132);
            lblHasta.Location = new Point(368, 11);
            lblHasta.Margin = new Padding(2, 0, 2, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(55, 21);
            lblHasta.TabIndex = 37;
            lblHasta.Text = "Hasta:";
            lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDesde.ForeColor = Color.FromArgb(63, 95, 132);
            lblDesde.Location = new Point(22, 12);
            lblDesde.Margin = new Padding(2, 0, 2, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(60, 21);
            lblDesde.TabIndex = 36;
            lblDesde.Text = "Desde:";
            lblDesde.Visible = false;
            // 
            // gbpOpciones
            // 
            gbpOpciones.Controls.Add(rdbOpcion3);
            gbpOpciones.Controls.Add(rdbOpcion2);
            gbpOpciones.Controls.Add(rdbOpcion1);
            gbpOpciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbpOpciones.ForeColor = Color.FromArgb(43, 62, 80);
            gbpOpciones.Location = new Point(22, 59);
            gbpOpciones.Name = "gbpOpciones";
            gbpOpciones.Size = new Size(624, 117);
            gbpOpciones.TabIndex = 77;
            gbpOpciones.TabStop = false;
            gbpOpciones.Text = "Opciones";
            // 
            // rdbOpcion3
            // 
            rdbOpcion3.AutoSize = true;
            rdbOpcion3.Location = new Point(6, 90);
            rdbOpcion3.Name = "rdbOpcion3";
            rdbOpcion3.Size = new Size(446, 25);
            rdbOpcion3.TabIndex = 2;
            rdbOpcion3.TabStop = true;
            rdbOpcion3.Text = "Reporte de reservaciones por rango de fechas específico";
            rdbOpcion3.UseVisualStyleBackColor = true;
            rdbOpcion3.CheckedChanged += rdbOpcion3_CheckedChanged;
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Location = new Point(6, 59);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(280, 25);
            rdbOpcion2.TabIndex = 1;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "Reporte mensual de reservaciones";
            rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Location = new Point(6, 28);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(279, 25);
            rdbOpcion1.TabIndex = 0;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "Reporte semanal de reservaciones";
            rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // frmReportesP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(gbpOpciones);
            Controls.Add(pnlReporte);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmReportesP";
            Text = "Reporte periodico";
            pnlReporte.ResumeLayout(false);
            pnlReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            gbpOpciones.ResumeLayout(false);
            gbpOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbLogotipo;
        private Label lblTitulo;
        private Panel pnlReporte;
        private Button btnGenerarPdf;
        private DataGridView dgvReporte;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private Label lblHasta;
        private Label lblDesde;
        private Button btnVer;
        private GroupBox gbpOpciones;
        private RadioButton rdbOpcion3;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion1;
    }
}