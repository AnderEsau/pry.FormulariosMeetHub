namespace pry.FormulariosMeetHub
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblLogin = new Label();
            pcbLogo = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(63, 95, 132);
            lblLogin.Location = new Point(381, 165);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(117, 45);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(1023, 2);
            pcbLogo.Margin = new Padding(4, 5, 4, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(127, 112);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11F);
            textBox1.ForeColor = Color.FromArgb(63, 95, 132);
            textBox1.Location = new Point(279, 240);
            textBox1.Margin = new Padding(1, 2, 1, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 33);
            textBox1.TabIndex = 11;
            textBox1.Text = "Nombre de usuario";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11F);
            textBox2.ForeColor = Color.FromArgb(63, 95, 132);
            textBox2.Location = new Point(279, 313);
            textBox2.Margin = new Padding(1, 2, 1, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 33);
            textBox2.TabIndex = 12;
            textBox2.Text = "Contraseña";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 197, 153);
            button1.Font = new Font("Arial", 11F);
            button1.Location = new Point(381, 393);
            button1.Margin = new Padding(1, 2, 1, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 13;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 313);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(183, 213);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pcbLogo);
            Controls.Add(lblLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "Control de acceso - Meet Hub";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private PictureBox pcbLogo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
