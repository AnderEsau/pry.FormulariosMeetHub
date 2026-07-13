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
            lblDesde = new Label();
            lblHasta = new Label();
            dtpInicio = new DateTimePicker();
            dtpFinal = new DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesde.Location = new Point(20, 65);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(91, 29);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHasta.Location = new Point(521, 65);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(84, 29);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta:";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpInicio.Font = new Font("Arial", 11F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(117, 62);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(214, 33);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFinal
            // 
            dtpFinal.CalendarMonthBackground = Color.FromArgb(235, 197, 153);
            dtpFinal.Font = new Font("Arial", 11F);
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(611, 62);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(238, 33);
            dtpFinal.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 62, 80);
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(575, 652);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(146, 55);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvReporte
            // 
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
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column1, Column2, Column3, Column4, Column5 });
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(16, 182);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.Size = new Size(1265, 430);
            dgvReporte.TabIndex = 19;
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
            // frmReportesP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 195, 175);
            ClientSize = new Size(1296, 742);
            Controls.Add(dgvReporte);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Name = "frmReportesP";
            Text = "Reporte periodico";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFinal;
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
        private PictureBox pcbLogotipo;
    }
}