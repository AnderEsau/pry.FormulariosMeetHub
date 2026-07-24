namespace pry.FormulariosMeetHub
{
    partial class frmEquipamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipamiento));
            lblTitulo = new Label();
            dgvEquipamiento = new DataGridView();
            txtNombreEquipamiento = new TextBox();
            pnlEquipamiento = new Panel();
            cmbSala = new ComboBox();
            txtTipo = new TextBox();
            txtDescripcionEquip = new TextBox();
            txtEquipamiento = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).BeginInit();
            pnlEquipamiento.SuspendLayout();
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
            lblTitulo.Size = new Size(250, 47);
            lblTitulo.TabIndex = 77;
            lblTitulo.Text = "Equipamiento";
            // 
            // dgvEquipamiento
            // 
            dgvEquipamiento.AllowUserToAddRows = false;
            dgvEquipamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipamiento.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamiento.EnableHeadersVisualStyles = false;
            dgvEquipamiento.Location = new Point(407, 138);
            dgvEquipamiento.Margin = new Padding(2);
            dgvEquipamiento.Name = "dgvEquipamiento";
            dgvEquipamiento.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEquipamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipamiento.RowHeadersVisible = false;
            dgvEquipamiento.RowHeadersWidth = 62;
            dgvEquipamiento.Size = new Size(689, 312);
            dgvEquipamiento.TabIndex = 117;
            dgvEquipamiento.SelectionChanged += dgvEquipamiento_SelectionChanged;
            // 
            // txtNombreEquipamiento
            // 
            txtNombreEquipamiento.BackColor = Color.White;
            txtNombreEquipamiento.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEquipamiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreEquipamiento.Location = new Point(407, 106);
            txtNombreEquipamiento.Margin = new Padding(1);
            txtNombreEquipamiento.Name = "txtNombreEquipamiento";
            txtNombreEquipamiento.PlaceholderText = "Buscar equipamiento";
            txtNombreEquipamiento.Size = new Size(218, 29);
            txtNombreEquipamiento.TabIndex = 116;
            txtNombreEquipamiento.TextChanged += txtNombreEquipamiento_TextChanged;
            // 
            // pnlEquipamiento
            // 
            pnlEquipamiento.BackColor = Color.White;
            pnlEquipamiento.Controls.Add(cmbSala);
            pnlEquipamiento.Controls.Add(txtTipo);
            pnlEquipamiento.Controls.Add(txtDescripcionEquip);
            pnlEquipamiento.Controls.Add(txtEquipamiento);
            pnlEquipamiento.Location = new Point(44, 106);
            pnlEquipamiento.Name = "pnlEquipamiento";
            pnlEquipamiento.Size = new Size(323, 344);
            pnlEquipamiento.TabIndex = 114;
            // 
            // cmbSala
            // 
            cmbSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(28, 249);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(272, 29);
            cmbSala.TabIndex = 97;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.White;
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipo.Location = new Point(28, 188);
            txtTipo.Margin = new Padding(1);
            txtTipo.Name = "txtTipo";
            txtTipo.PlaceholderText = "Tipo";
            txtTipo.Size = new Size(272, 29);
            txtTipo.TabIndex = 96;
            // 
            // txtDescripcionEquip
            // 
            txtDescripcionEquip.BackColor = Color.White;
            txtDescripcionEquip.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionEquip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcionEquip.Location = new Point(28, 96);
            txtDescripcionEquip.Margin = new Padding(1);
            txtDescripcionEquip.Multiline = true;
            txtDescripcionEquip.Name = "txtDescripcionEquip";
            txtDescripcionEquip.PlaceholderText = "Descripción";
            txtDescripcionEquip.Size = new Size(272, 74);
            txtDescripcionEquip.TabIndex = 95;
            // 
            // txtEquipamiento
            // 
            txtEquipamiento.BackColor = Color.White;
            txtEquipamiento.BorderStyle = BorderStyle.FixedSingle;
            txtEquipamiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipamiento.Location = new Point(28, 18);
            txtEquipamiento.Margin = new Padding(1);
            txtEquipamiento.Multiline = true;
            txtEquipamiento.Name = "txtEquipamiento";
            txtEquipamiento.PlaceholderText = "Equipamiento";
            txtEquipamiento.Size = new Size(272, 63);
            txtEquipamiento.TabIndex = 94;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(266, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 48);
            btnEliminar.TabIndex = 120;
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
            btnGuardar.Location = new Point(155, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 48);
            btnGuardar.TabIndex = 119;
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
            btnNuevo.Location = new Point(44, 456);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 48);
            btnNuevo.TabIndex = 118;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmEquipamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvEquipamiento);
            Controls.Add(txtNombreEquipamiento);
            Controls.Add(pnlEquipamiento);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEquipamiento";
            Text = "Equipamiento";
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).EndInit();
            pnlEquipamiento.ResumeLayout(false);
            pnlEquipamiento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvEquipamiento;
        private TextBox txtNombreEquipamiento;
        private Panel pnlEquipamiento;
        private ComboBox cmbSala;
        private TextBox txtTipo;
        private TextBox txtDescripcionEquip;
        private TextBox txtEquipamiento;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}