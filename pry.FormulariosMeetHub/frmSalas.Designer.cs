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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalas));
            lblTitulo = new Label();
            pnlSalas = new Panel();
            txtAforo = new TextBox();
            txtDescripcion = new TextBox();
            txtSala = new TextBox();
            txtNombreSala = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dgvSalas = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
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
            txtNombreSala.Location = new Point(445, 103);
            txtNombreSala.Margin = new Padding(1);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.PlaceholderText = "Buscar sala";
            txtNombreSala.Size = new Size(218, 29);
            txtNombreSala.TabIndex = 103;
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
            // dgvSalas
            // 
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
            dgvSalas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.Location = new Point(445, 135);
            dgvSalas.Margin = new Padding(2);
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 62;
            dgvSalas.Size = new Size(647, 224);
            dgvSalas.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 62, 80);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn4.HeaderText = "text1";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "text2";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "text3";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
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
            // 
            // frmSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvSalas);
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
        private DataGridView dgvSalas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}