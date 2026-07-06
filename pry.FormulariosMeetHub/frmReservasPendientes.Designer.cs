namespace pry.FormulariosMeetHub
{
    partial class frmReservasPendientes
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 197, 153);
            button1.Location = new Point(246, 368);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 0;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 197, 153);
            button2.Location = new Point(376, 368);
            button2.Name = "button2";
            button2.Size = new Size(111, 33);
            button2.TabIndex = 1;
            button2.Text = "RECHAZAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(36, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(359, 328);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
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
            // groupBox1
            // 
            groupBox1.Font = new Font("Arial", 11F);
            groupBox1.Location = new Point(466, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 215);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de la Reserva:";
            // 
            // frmReservasPendientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmReservasPendientes";
            Text = "Reservas Pendientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox1;
    }
}