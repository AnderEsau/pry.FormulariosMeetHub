namespace pry.FormulariosMeetHub
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            pnlUsuarios = new Panel();
            cmbEstado = new ComboBox();
            cmbTipo = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtMatricula = new TextBox();
            txtNombreUsuario = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlUsuarios.SuspendLayout();
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
            lblTitulo.Size = new Size(160, 47);
            lblTitulo.TabIndex = 76;
            lblTitulo.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(519, 149);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(513, 268);
            dgvUsuarios.TabIndex = 78;
            dgvUsuarios.SelectionChanged += dgvUsuario_SelectionChanged;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = Color.White;
            pnlUsuarios.BorderStyle = BorderStyle.FixedSingle;
            pnlUsuarios.Controls.Add(cmbEstado);
            pnlUsuarios.Controls.Add(cmbTipo);
            pnlUsuarios.Controls.Add(txtPassword);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Controls.Add(txtMatricula);
            pnlUsuarios.Location = new Point(96, 119);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(323, 326);
            pnlUsuarios.TabIndex = 79;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(47, 265);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(218, 29);
            cmbEstado.TabIndex = 101;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(47, 207);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(218, 29);
            cmbTipo.TabIndex = 98;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(47, 147);
            txtPassword.Margin = new Padding(1);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(218, 29);
            txtPassword.TabIndex = 96;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(47, 85);
            txtUsuario.Margin = new Padding(1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(218, 29);
            txtUsuario.TabIndex = 95;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(47, 25);
            txtMatricula.Margin = new Padding(1);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matrícula del trabajador";
            txtMatricula.Size = new Size(218, 29);
            txtMatricula.TabIndex = 94;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(519, 119);
            txtNombreUsuario.Margin = new Padding(1);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Buscar usuario";
            txtNombreUsuario.Size = new Size(218, 29);
            txtNombreUsuario.TabIndex = 96;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(318, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 48);
            btnEliminar.TabIndex = 100;
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
            btnGuardar.Location = new Point(211, 474);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 48);
            btnGuardar.TabIndex = 99;
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
            btnNuevo.Location = new Point(96, 474);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 48);
            btnNuevo.TabIndex = 98;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombreUsuario);
            Controls.Add(pnlUsuarios);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvUsuarios;
        private Panel pnlUsuarios;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtMatricula;
        private ComboBox cmbTipo;
        private TextBox txtNombreUsuario;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private ComboBox cmbEstado;
    }
}