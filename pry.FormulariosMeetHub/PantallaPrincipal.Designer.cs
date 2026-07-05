namespace pry.FormulariosMeetHub
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            PictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            TextBox3 = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.BackColor = Color.LightSteelBlue;
            TextBox1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox1.Location = new Point(-2, 0);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(725, 44);
            TextBox1.TabIndex = 1;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // TextBox2
            // 
            TextBox2.BackColor = Color.LightSteelBlue;
            TextBox2.Font = new Font("Segoe UI", 16F);
            TextBox2.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox2.Location = new Point(-2, 41);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(725, 36);
            TextBox2.TabIndex = 2;
            TextBox2.Text = "Reservaciones                                         Cancelaciones";
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(322, 146);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(158, 136);
            PictureBox1.TabIndex = 3;
            PictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(565, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 136);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(81, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 136);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // TextBox3
            // 
            TextBox3.BackColor = Color.LightSteelBlue;
            TextBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox3.ForeColor = Color.FromArgb(63, 95, 132);
            TextBox3.Location = new Point(-2, 423);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(802, 27);
            TextBox3.TabIndex = 10;
            TextBox3.Text = "TEL:                                                                                      EMAIL:";
            TextBox3.TextChanged += TextBox3_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(81, 285);
            Label1.Name = "Label1";
            Label1.Size = new Size(41, 15);
            Label1.TabIndex = 11;
            Label1.Text = "Label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 285);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 285);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(694, -21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(TextBox3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal PictureBox PictureBox1;
        internal PictureBox pictureBox2;
        internal PictureBox pictureBox3;
        internal TextBox TextBox3;
        internal Label Label1;
        internal Label label2;
        internal Label label3;
        private PictureBox pictureBox4;
    }
}