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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreaDpto));
            lblTitulo = new Label();
            txtNombreArea = new TextBox();
            pnlAreaDpto = new Panel();
            txtDescripcion = new TextBox();
            txtMatricula = new TextBox();
            dgvUsuarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            pnlAreaDpto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            lblTitulo.Size = new Size(407, 47);
            lblTitulo.TabIndex = 77;
            lblTitulo.Text = "Áreas y Departamentos";
            // 
            // txtNombreArea
            // 
            txtNombreArea.BackColor = Color.White;
            txtNombreArea.BorderStyle = BorderStyle.FixedSingle;
            txtNombreArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreArea.Location = new Point(583, 112);
            txtNombreArea.Margin = new Padding(1);
            txtNombreArea.Name = "txtNombreArea";
            txtNombreArea.PlaceholderText = "Buscar Área/Departamento";
            txtNombreArea.Size = new Size(218, 29);
            txtNombreArea.TabIndex = 103;
            // 
            // pnlAreaDpto
            // 
            pnlAreaDpto.BackColor = Color.White;
            pnlAreaDpto.BorderStyle = BorderStyle.FixedSingle;
            pnlAreaDpto.Controls.Add(txtDescripcion);
            pnlAreaDpto.Controls.Add(txtMatricula);
            pnlAreaDpto.Location = new Point(64, 144);
            pnlAreaDpto.Name = "pnlAreaDpto";
            pnlAreaDpto.Size = new Size(321, 125);
            pnlAreaDpto.TabIndex = 102;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(21, 72);
            txtDescripcion.Margin = new Padding(1);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(272, 29);
            txtDescripcion.TabIndex = 95;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(21, 23);
            txtMatricula.Margin = new Padding(1);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Nombre del Área/Departamento";
            txtMatricula.Size = new Size(272, 29);
            txtMatricula.TabIndex = 94;
            // 
            // dgvUsuarios
            // 
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
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(583, 144);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(510, 223);
            dgvUsuarios.TabIndex = 101;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 62, 80);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
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
            btnEliminar.Location = new Point(285, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 48);
            btnEliminar.TabIndex = 106;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(174, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 48);
            btnGuardar.TabIndex = 105;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(63, 284);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 48);
            btnNuevo.TabIndex = 104;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmAreaDpto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombreArea);
            Controls.Add(pnlAreaDpto);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAreaDpto";
            Text = "Áreas y Departamentos";
            pnlAreaDpto.ResumeLayout(false);
            pnlAreaDpto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombreArea;
        private Panel pnlAreaDpto;
        private TextBox txtMatricula;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}