namespace pry.FormulariosMeetHub
{
    partial class frmAreaDpto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreaDpto));
            lblTitulo = new Label();
            txtNombreArea = new TextBox();
            pnlAreaDpto = new Panel();
            txtDescripcion = new TextBox();
            txtArea = new TextBox();
            dgvAreaDpto = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            pnlAreaDpto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAreaDpto).BeginInit();
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
            lblTitulo.Size = new Size(616, 71);
            lblTitulo.TabIndex = 77;
            lblTitulo.Text = "Áreas y Departamentos";
            // 
            // txtNombreArea
            // 
            txtNombreArea.BackColor = Color.White;
            txtNombreArea.BorderStyle = BorderStyle.FixedSingle;
            txtNombreArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreArea.Location = new Point(833, 187);
            txtNombreArea.Margin = new Padding(1, 2, 1, 2);
            txtNombreArea.Name = "txtNombreArea";
            txtNombreArea.PlaceholderText = "Buscar Área/Departamento";
            txtNombreArea.Size = new Size(311, 39);
            txtNombreArea.TabIndex = 103;
            txtNombreArea.TextChanged += txtNombreArea_TextChanged;
            // 
            // pnlAreaDpto
            // 
            pnlAreaDpto.BackColor = Color.White;
            pnlAreaDpto.BorderStyle = BorderStyle.FixedSingle;
            pnlAreaDpto.Controls.Add(txtDescripcion);
            pnlAreaDpto.Controls.Add(txtArea);
            pnlAreaDpto.Location = new Point(91, 240);
            pnlAreaDpto.Margin = new Padding(4, 5, 4, 5);
            pnlAreaDpto.Name = "pnlAreaDpto";
            pnlAreaDpto.Size = new Size(458, 207);
            pnlAreaDpto.TabIndex = 102;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(30, 120);
            txtDescripcion.Margin = new Padding(1, 2, 1, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(388, 39);
            txtDescripcion.TabIndex = 95;
            // 
            // txtArea
            // 
            txtArea.BackColor = Color.White;
            txtArea.BorderStyle = BorderStyle.FixedSingle;
            txtArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(30, 38);
            txtArea.Margin = new Padding(1, 2, 1, 2);
            txtArea.Name = "txtArea";
            txtArea.PlaceholderText = "Nombre del Área/Departamento";
            txtArea.Size = new Size(388, 39);
            txtArea.TabIndex = 94;
            // 
            // dgvAreaDpto
            // 
            dgvAreaDpto.AllowUserToAddRows = false;
            dgvAreaDpto.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAreaDpto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAreaDpto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAreaDpto.EnableHeadersVisualStyles = false;
            dgvAreaDpto.Location = new Point(833, 240);
            dgvAreaDpto.Name = "dgvAreaDpto";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAreaDpto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAreaDpto.RowHeadersVisible = false;
            dgvAreaDpto.RowHeadersWidth = 62;
            dgvAreaDpto.Size = new Size(729, 372);
            dgvAreaDpto.TabIndex = 101;
            dgvAreaDpto.SelectionChanged += dgvAreaDpto_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(407, 473);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 80);
            btnEliminar.TabIndex = 106;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(249, 473);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 80);
            btnGuardar.TabIndex = 105;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(90, 473);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(144, 80);
            btnNuevo.TabIndex = 104;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // frmAreaDpto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1621, 992);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombreArea);
            Controls.Add(pnlAreaDpto);
            Controls.Add(dgvAreaDpto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAreaDpto";
            Text = "Áreas y Departamentos";
            pnlAreaDpto.ResumeLayout(false);
            pnlAreaDpto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAreaDpto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombreArea;
        private Panel pnlAreaDpto;
        private TextBox txtArea;
        private DataGridView dgvAreaDpto;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}