namespace pry.FormulariosMeetHub
{
    partial class frmResponsables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsables));
            lblTitulo = new Label();
            gbpOpciones = new GroupBox();
            rdbOpcion3 = new RadioButton();
            rdbOpcion2 = new RadioButton();
            rdbOpcion1 = new RadioButton();
            dgvReponsables = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnTrabajadores = new Button();
            btnAlumnos = new Button();
            btnExternos = new Button();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnEditarCambios = new Button();
            btnVer = new Button();
            gbpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReponsables).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            lblTitulo.Size = new Size(240, 47);
            lblTitulo.TabIndex = 75;
            lblTitulo.Text = "Responsables";
            // 
            // gbpOpciones
            // 
            gbpOpciones.Controls.Add(rdbOpcion3);
            gbpOpciones.Controls.Add(rdbOpcion2);
            gbpOpciones.Controls.Add(rdbOpcion1);
            gbpOpciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbpOpciones.ForeColor = Color.FromArgb(43, 62, 80);
            gbpOpciones.Location = new Point(21, 73);
            gbpOpciones.Name = "gbpOpciones";
            gbpOpciones.Size = new Size(516, 117);
            gbpOpciones.TabIndex = 76;
            gbpOpciones.TabStop = false;
            gbpOpciones.Text = "Opciones";
            // 
            // rdbOpcion3
            // 
            rdbOpcion3.AutoSize = true;
            rdbOpcion3.Location = new Point(6, 90);
            rdbOpcion3.Name = "rdbOpcion3";
            rdbOpcion3.Size = new Size(381, 25);
            rdbOpcion3.TabIndex = 2;
            rdbOpcion3.TabStop = true;
            rdbOpcion3.Text = "Mostrar a los responsables que son trabajadores";
            rdbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Location = new Point(6, 59);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(350, 25);
            rdbOpcion2.TabIndex = 1;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "Mostrar a los responsables que son alumnos";
            rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Location = new Point(6, 28);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(291, 25);
            rdbOpcion1.TabIndex = 0;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "Mostrar a los responsables externos";
            rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // dgvReponsables
            // 
            dgvReponsables.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReponsables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReponsables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReponsables.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvReponsables.EnableHeadersVisualStyles = false;
            dgvReponsables.Location = new Point(21, 253);
            dgvReponsables.Margin = new Padding(2);
            dgvReponsables.Name = "dgvReponsables";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReponsables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReponsables.RowHeadersWidth = 62;
            dgvReponsables.Size = new Size(571, 280);
            dgvReponsables.TabIndex = 77;
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
            // panel1
            // 
            panel1.Controls.Add(btnTrabajadores);
            panel1.Controls.Add(btnAlumnos);
            panel1.Controls.Add(btnExternos);
            panel1.Location = new Point(657, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 167);
            panel1.TabIndex = 78;
            // 
            // btnTrabajadores
            // 
            btnTrabajadores.BackColor = Color.FromArgb(43, 62, 80);
            btnTrabajadores.Cursor = Cursors.Hand;
            btnTrabajadores.FlatAppearance.BorderSize = 0;
            btnTrabajadores.FlatStyle = FlatStyle.Flat;
            btnTrabajadores.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrabajadores.ForeColor = Color.White;
            btnTrabajadores.Location = new Point(34, 120);
            btnTrabajadores.Margin = new Padding(1);
            btnTrabajadores.Name = "btnTrabajadores";
            btnTrabajadores.Size = new Size(340, 33);
            btnTrabajadores.TabIndex = 82;
            btnTrabajadores.Text = "Agregar un nuevo Trabajador";
            btnTrabajadores.UseVisualStyleBackColor = false;
            btnTrabajadores.Click += btnTrabajadores_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.FromArgb(43, 62, 80);
            btnAlumnos.Cursor = Cursors.Hand;
            btnAlumnos.FlatAppearance.BorderSize = 0;
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlumnos.ForeColor = Color.White;
            btnAlumnos.Location = new Point(34, 65);
            btnAlumnos.Margin = new Padding(1);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(340, 33);
            btnAlumnos.TabIndex = 81;
            btnAlumnos.Text = "Agregar un nuevo Alumno";
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnExternos
            // 
            btnExternos.BackColor = Color.FromArgb(43, 62, 80);
            btnExternos.Cursor = Cursors.Hand;
            btnExternos.FlatAppearance.BorderSize = 0;
            btnExternos.FlatStyle = FlatStyle.Flat;
            btnExternos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExternos.ForeColor = Color.White;
            btnExternos.Location = new Point(34, 10);
            btnExternos.Margin = new Padding(1);
            btnExternos.Name = "btnExternos";
            btnExternos.Size = new Size(340, 33);
            btnExternos.TabIndex = 80;
            btnExternos.Text = "Agregar un nuevo responsable Externo";
            btnExternos.UseVisualStyleBackColor = false;
            btnExternos.Click += btnExternos_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditarCambios);
            panel2.Location = new Point(657, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 280);
            panel2.TabIndex = 79;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(87, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 76);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditarCambios
            // 
            btnEditarCambios.BackgroundImage = (Image)resources.GetObject("btnEditarCambios.BackgroundImage");
            btnEditarCambios.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarCambios.Cursor = Cursors.Hand;
            btnEditarCambios.FlatAppearance.BorderSize = 0;
            btnEditarCambios.FlatStyle = FlatStyle.Flat;
            btnEditarCambios.Location = new Point(87, 31);
            btnEditarCambios.Name = "btnEditarCambios";
            btnEditarCambios.Size = new Size(235, 76);
            btnEditarCambios.TabIndex = 0;
            btnEditarCambios.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(210, 195, 175);
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.FromArgb(42, 36, 33);
            btnVer.Location = new Point(194, 207);
            btnVer.Margin = new Padding(1);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(183, 33);
            btnVer.TabIndex = 72;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // frmResponsables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(btnVer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvReponsables);
            Controls.Add(gbpOpciones);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmResponsables";
            Text = "Responsables";
            gbpOpciones.ResumeLayout(false);
            gbpOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReponsables).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbpOpciones;
        private RadioButton rdbOpcion3;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion1;
        private DataGridView dgvReponsables;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Panel panel2;
        private Button btnAlumnos;
        private Button btnExternos;
        private Button btnTrabajadores;
        private Button btnEliminar;
        private Button btnEditarCambios;
        private Button btnVer;
    }
}