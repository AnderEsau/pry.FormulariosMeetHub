namespace pry.FormulariosMeetHub
{
    partial class PantallaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaAdmin));
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            TextBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.BackColor = Color.FromArgb(231, 238, 246);
            TextBox1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox1.Location = new Point(-1, 0);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(702, 44);
            TextBox1.TabIndex = 4;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // TextBox2
            // 
            TextBox2.BackColor = Color.FromArgb(231, 238, 246);
            TextBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox2.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox2.Location = new Point(-1, 41);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(702, 35);
            TextBox2.TabIndex = 5;
            TextBox2.Text = "   Reservaciones                             Reporte Periodico";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.ButtonHighlight;
            Label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(109, 94);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(208, 30);
            Label1.TabIndex = 6;
            Label1.Text = "Bienvenido Admin   ";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(119, 138);
            Label2.Name = "Label2";
            Label2.Size = new Size(41, 15);
            Label2.TabIndex = 7;
            Label2.Text = "Label2";
            // 
            // TextBox3
            // 
            TextBox3.BackColor = Color.FromArgb(231, 238, 246);
            TextBox3.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox3.Location = new Point(-1, 427);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(803, 23);
            TextBox3.TabIndex = 8;
            TextBox3.Text = "TEL:                                                                                      EMAIL:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(693, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // PantallaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(TextBox3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Name = "PantallaAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal Label Label1;
        internal Label Label2;
        internal TextBox TextBox3;
        private PictureBox pictureBox1;
    }
}