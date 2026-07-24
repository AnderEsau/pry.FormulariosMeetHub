namespace pry.FormulariosMeetHub
{
    partial class frmSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalas));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlSalas = new Panel();
            txtAforo = new TextBox();
            txtDescripcion = new TextBox();
            txtSala = new TextBox();
            txtNombreSala = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dgvSalas = new DataGridView();
            pnlSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
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
            lblTitulo.Size = new Size(103, 47);
            lblTitulo.TabIndex = 76;
            lblTitulo.Text = "Salas";
            // 
            // pnlSalas
            // 
            pnlSalas.BackColor = Color.White;
            pnlSalas.Controls.Add(txtAforo);
            pnlSalas.Controls.Add(txtDescripcion);
            pnlSalas.Controls.Add(txtSala);
            pnlSalas.Location = new Point(44, 106);
            pnlSalas.Name = "pnlSalas";
            pnlSalas.Size = new Size(323, 253);
            pnlSalas.TabIndex = 77;
            // 
            // txtAforo
            // 
            txtAforo.BackColor = Color.White;
            txtAforo.BorderStyle = BorderStyle.FixedSingle;
            txtAforo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAforo.Location = new Point(27, 197);
            txtAforo.Margin = new Padding(1);
            txtAforo.Name = "txtAforo";
            txtAforo.PlaceholderText = "Aforo";
            txtAforo.Size = new Size(272, 29);
            txtAforo.TabIndex = 93;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(27, 67);
            txtDescripcion.Margin = new Padding(1);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(272, 97);
            txtDescripcion.TabIndex = 92;
            // 
            // txtSala
            // 
            txtSala.BackColor = Color.White;
            txtSala.BorderStyle = BorderStyle.FixedSingle;
            txtSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSala.Location = new Point(27, 18);
            txtSala.Margin = new Padding(1);
            txtSala.Name = "txtSala";
            txtSala.PlaceholderText = "Nombre de la sala";
            txtSala.Size = new Size(272, 29);
            txtSala.TabIndex = 91;
            // 
            // txtNombreSala
            // 
            txtNombreSala.BackColor = Color.White;
            txtNombreSala.BorderStyle = BorderStyle.FixedSingle;
            txtNombreSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreSala.Location = new Point(428, 103);
            txtNombreSala.Margin = new Padding(1);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.PlaceholderText = "Buscar sala";
            txtNombreSala.Size = new Size(218, 29);
            txtNombreSala.TabIndex = 103;
            txtNombreSala.TextChanged += txtNombreSala_TextChanged;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 62, 80);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(266, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 48);
            btnEliminar.TabIndex = 123;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(155, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 48);
            btnGuardar.TabIndex = 122;
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
            btnNuevo.Location = new Point(44, 365);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 48);
            btnNuevo.TabIndex = 121;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalas.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.Location = new Point(428, 135);
            dgvSalas.Margin = new Padding(2);
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 62;
            dgvSalas.Size = new Size(662, 312);
            dgvSalas.TabIndex = 124;
            dgvSalas.SelectionChanged += dgvSalas_SelectionChanged;
            // 
            // frmSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(dgvSalas);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombreSala);
            Controls.Add(pnlSalas);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSalas";
            Text = "Salas";
            pnlSalas.ResumeLayout(false);
            pnlSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlSalas;
        private TextBox txtAforo;
        private TextBox txtDescripcion;
        private TextBox txtSala;
        private TextBox txtNombreSala;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvSalas;
    }
}