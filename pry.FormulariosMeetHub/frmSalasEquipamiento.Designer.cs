namespace pry.FormulariosMeetHub
{
    partial class frmSalasEquipamiento
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalasEquipamiento));
            lblTitulo = new Label();
            pnlSalas = new Panel();
            txtAforo = new TextBox();
            txtDescripcion = new TextBox();
            txtSala = new TextBox();
            pnlEquipamiento = new Panel();
            cmbSala = new ComboBox();
            txtTipo = new TextBox();
            txtDescripcionEquip = new TextBox();
            txtEquipamiento = new TextBox();
            lblSalas = new Label();
            lblEquipamiento = new Label();
            txtNombreSala = new TextBox();
            txtNombreEquipamiento = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dgvEquipamiento = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dgvSalas = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnEliminarS = new Button();
            btnGuardarS = new Button();
            btnEliminarE = new Button();
            btnGuardarE = new Button();
            btnNuevoE = new Button();
            btnNuevoS = new Button();
            pnlSalas.SuspendLayout();
            pnlEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).BeginInit();
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
            lblTitulo.Size = new Size(372, 47);
            lblTitulo.TabIndex = 76;
            lblTitulo.Text = "Salas y Equipamiento";
            // 
            // pnlSalas
            // 
            pnlSalas.BackColor = Color.White;
            pnlSalas.Controls.Add(txtAforo);
            pnlSalas.Controls.Add(txtDescripcion);
            pnlSalas.Controls.Add(txtSala);
            pnlSalas.Location = new Point(27, 85);
            pnlSalas.Name = "pnlSalas";
            pnlSalas.Size = new Size(393, 164);
            pnlSalas.TabIndex = 77;
            // 
            // txtAforo
            // 
            txtAforo.BackColor = Color.White;
            txtAforo.BorderStyle = BorderStyle.FixedSingle;
            txtAforo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAforo.Location = new Point(27, 120);
            txtAforo.Margin = new Padding(1);
            txtAforo.Name = "txtAforo";
            txtAforo.PlaceholderText = "Aforo";
            txtAforo.Size = new Size(218, 29);
            txtAforo.TabIndex = 93;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(27, 67);
            txtDescripcion.Margin = new Padding(1);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(218, 29);
            txtDescripcion.TabIndex = 92;
            // 
            // txtSala
            // 
            txtSala.BackColor = Color.White;
            txtSala.BorderStyle = BorderStyle.FixedSingle;
            txtSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSala.Location = new Point(27, 15);
            txtSala.Margin = new Padding(1);
            txtSala.Name = "txtSala";
            txtSala.PlaceholderText = "Nombre de la sala";
            txtSala.Size = new Size(218, 29);
            txtSala.TabIndex = 91;
            // 
            // pnlEquipamiento
            // 
            pnlEquipamiento.BackColor = Color.White;
            pnlEquipamiento.Controls.Add(cmbSala);
            pnlEquipamiento.Controls.Add(txtTipo);
            pnlEquipamiento.Controls.Add(txtDescripcionEquip);
            pnlEquipamiento.Controls.Add(txtEquipamiento);
            pnlEquipamiento.Location = new Point(568, 85);
            pnlEquipamiento.Name = "pnlEquipamiento";
            pnlEquipamiento.Size = new Size(519, 161);
            pnlEquipamiento.TabIndex = 78;
            // 
            // cmbSala
            // 
            cmbSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(16, 35);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(209, 29);
            cmbSala.TabIndex = 97;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.White;
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipo.Location = new Point(247, 100);
            txtTipo.Margin = new Padding(1);
            txtTipo.Name = "txtTipo";
            txtTipo.PlaceholderText = "Tipo";
            txtTipo.Size = new Size(218, 29);
            txtTipo.TabIndex = 96;
            // 
            // txtDescripcionEquip
            // 
            txtDescripcionEquip.BackColor = Color.White;
            txtDescripcionEquip.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionEquip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcionEquip.Location = new Point(247, 35);
            txtDescripcionEquip.Margin = new Padding(1);
            txtDescripcionEquip.Name = "txtDescripcionEquip";
            txtDescripcionEquip.PlaceholderText = "Descripción";
            txtDescripcionEquip.Size = new Size(218, 29);
            txtDescripcionEquip.TabIndex = 95;
            // 
            // txtEquipamiento
            // 
            txtEquipamiento.BackColor = Color.White;
            txtEquipamiento.BorderStyle = BorderStyle.FixedSingle;
            txtEquipamiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipamiento.Location = new Point(16, 100);
            txtEquipamiento.Margin = new Padding(1);
            txtEquipamiento.Name = "txtEquipamiento";
            txtEquipamiento.PlaceholderText = "Equipamiento";
            txtEquipamiento.Size = new Size(218, 29);
            txtEquipamiento.TabIndex = 94;
            // 
            // lblSalas
            // 
            lblSalas.AutoSize = true;
            lblSalas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalas.ForeColor = Color.FromArgb(63, 95, 132);
            lblSalas.Location = new Point(27, 61);
            lblSalas.Name = "lblSalas";
            lblSalas.Size = new Size(46, 21);
            lblSalas.TabIndex = 79;
            lblSalas.Text = "Salas";
            // 
            // lblEquipamiento
            // 
            lblEquipamiento.AutoSize = true;
            lblEquipamiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipamiento.ForeColor = Color.FromArgb(63, 95, 132);
            lblEquipamiento.Location = new Point(568, 61);
            lblEquipamiento.Name = "lblEquipamiento";
            lblEquipamiento.Size = new Size(111, 21);
            lblEquipamiento.TabIndex = 94;
            lblEquipamiento.Text = "Equipamiento";
            // 
            // txtNombreSala
            // 
            txtNombreSala.BackColor = Color.White;
            txtNombreSala.BorderStyle = BorderStyle.FixedSingle;
            txtNombreSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreSala.Location = new Point(27, 328);
            txtNombreSala.Margin = new Padding(1);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.PlaceholderText = "Buscar sala";
            txtNombreSala.Size = new Size(218, 29);
            txtNombreSala.TabIndex = 103;
            // 
            // txtNombreEquipamiento
            // 
            txtNombreEquipamiento.BackColor = Color.White;
            txtNombreEquipamiento.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEquipamiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreEquipamiento.Location = new Point(568, 328);
            txtNombreEquipamiento.Margin = new Padding(1);
            txtNombreEquipamiento.Name = "txtNombreEquipamiento";
            txtNombreEquipamiento.PlaceholderText = "Buscar equipamiento";
            txtNombreEquipamiento.Size = new Size(218, 29);
            txtNombreEquipamiento.TabIndex = 104;
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
            // dgvEquipamiento
            // 
            dgvEquipamiento.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEquipamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamiento.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvEquipamiento.EnableHeadersVisualStyles = false;
            dgvEquipamiento.Location = new Point(568, 360);
            dgvEquipamiento.Margin = new Padding(2);
            dgvEquipamiento.Name = "dgvEquipamiento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEquipamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEquipamiento.RowHeadersWidth = 62;
            dgvEquipamiento.Size = new Size(519, 197);
            dgvEquipamiento.TabIndex = 106;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 62, 80);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
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
            // dgvSalas
            // 
            dgvSalas.BackgroundColor = Color.FromArgb(231, 238, 246);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(63, 95, 132);
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(43, 62, 80);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.Location = new Point(27, 360);
            dgvSalas.Margin = new Padding(2);
            dgvSalas.Name = "dgvSalas";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(235, 197, 153);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSalas.RowHeadersWidth = 62;
            dgvSalas.Size = new Size(393, 197);
            dgvSalas.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(43, 62, 80);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn4.HeaderText = "text1";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "text2";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "text3";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // btnEliminarS
            // 
            btnEliminarS.BackgroundImage = (Image)resources.GetObject("btnEliminarS.BackgroundImage");
            btnEliminarS.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarS.Cursor = Cursors.Hand;
            btnEliminarS.FlatAppearance.BorderSize = 0;
            btnEliminarS.FlatStyle = FlatStyle.Flat;
            btnEliminarS.Location = new Point(301, 255);
            btnEliminarS.Name = "btnEliminarS";
            btnEliminarS.Size = new Size(101, 48);
            btnEliminarS.TabIndex = 110;
            btnEliminarS.UseVisualStyleBackColor = true;
            // 
            // btnGuardarS
            // 
            btnGuardarS.BackgroundImage = (Image)resources.GetObject("btnGuardarS.BackgroundImage");
            btnGuardarS.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardarS.Cursor = Cursors.Hand;
            btnGuardarS.FlatAppearance.BorderSize = 0;
            btnGuardarS.FlatStyle = FlatStyle.Flat;
            btnGuardarS.Location = new Point(171, 255);
            btnGuardarS.Name = "btnGuardarS";
            btnGuardarS.Size = new Size(101, 48);
            btnGuardarS.TabIndex = 109;
            btnGuardarS.UseVisualStyleBackColor = true;
            // 
            // btnEliminarE
            // 
            btnEliminarE.BackgroundImage = (Image)resources.GetObject("btnEliminarE.BackgroundImage");
            btnEliminarE.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarE.Cursor = Cursors.Hand;
            btnEliminarE.FlatAppearance.BorderSize = 0;
            btnEliminarE.FlatStyle = FlatStyle.Flat;
            btnEliminarE.Location = new Point(950, 255);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(101, 48);
            btnEliminarE.TabIndex = 113;
            btnEliminarE.UseVisualStyleBackColor = true;
            // 
            // btnGuardarE
            // 
            btnGuardarE.BackgroundImage = (Image)resources.GetObject("btnGuardarE.BackgroundImage");
            btnGuardarE.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardarE.Cursor = Cursors.Hand;
            btnGuardarE.FlatAppearance.BorderSize = 0;
            btnGuardarE.FlatStyle = FlatStyle.Flat;
            btnGuardarE.Location = new Point(779, 255);
            btnGuardarE.Name = "btnGuardarE";
            btnGuardarE.Size = new Size(101, 48);
            btnGuardarE.TabIndex = 112;
            btnGuardarE.UseVisualStyleBackColor = true;
            // 
            // btnNuevoE
            // 
            btnNuevoE.BackgroundImage = (Image)resources.GetObject("btnNuevoE.BackgroundImage");
            btnNuevoE.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoE.Cursor = Cursors.Hand;
            btnNuevoE.FlatAppearance.BorderSize = 0;
            btnNuevoE.FlatStyle = FlatStyle.Flat;
            btnNuevoE.Location = new Point(609, 255);
            btnNuevoE.Name = "btnNuevoE";
            btnNuevoE.Size = new Size(101, 48);
            btnNuevoE.TabIndex = 111;
            btnNuevoE.UseVisualStyleBackColor = true;
            // 
            // btnNuevoS
            // 
            btnNuevoS.BackgroundImage = (Image)resources.GetObject("btnNuevoS.BackgroundImage");
            btnNuevoS.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoS.Cursor = Cursors.Hand;
            btnNuevoS.FlatAppearance.BorderSize = 0;
            btnNuevoS.FlatStyle = FlatStyle.Flat;
            btnNuevoS.Location = new Point(40, 255);
            btnNuevoS.Name = "btnNuevoS";
            btnNuevoS.Size = new Size(101, 48);
            btnNuevoS.TabIndex = 114;
            btnNuevoS.UseVisualStyleBackColor = true;
            // 
            // frmSalasEquipamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1135, 595);
            Controls.Add(btnNuevoS);
            Controls.Add(btnEliminarE);
            Controls.Add(btnGuardarE);
            Controls.Add(btnNuevoE);
            Controls.Add(btnEliminarS);
            Controls.Add(btnGuardarS);
            Controls.Add(dgvSalas);
            Controls.Add(dgvEquipamiento);
            Controls.Add(txtNombreEquipamiento);
            Controls.Add(txtNombreSala);
            Controls.Add(lblEquipamiento);
            Controls.Add(lblSalas);
            Controls.Add(pnlEquipamiento);
            Controls.Add(pnlSalas);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSalasEquipamiento";
            Text = "Salas y Equipamiento";
            pnlSalas.ResumeLayout(false);
            pnlSalas.PerformLayout();
            pnlEquipamiento.ResumeLayout(false);
            pnlEquipamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlSalas;
        private Panel pnlEquipamiento;
        private TextBox txtAforo;
        private TextBox txtDescripcion;
        private TextBox txtSala;
        private TextBox txtTipo;
        private TextBox txtDescripcionEquip;
        private TextBox txtEquipamiento;
        private Label lblSalas;
        private Label lblEquipamiento;
        private Button btnEliminarE;
        private Button btnGuardarE;
        private Button btnNuevoE;
        private Button btnGuardarS;
        private Button btnEliminarS;
        private ComboBox cmbSala;
        private TextBox txtNombreSala;
        private TextBox txtNombreEquipamiento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dgvEquipamiento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView dgvSalas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevoS;
    }
}