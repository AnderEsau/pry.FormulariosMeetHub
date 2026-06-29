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
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(63, 95, 132);
            lblLogin.Location = new Point(199, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(135, 50);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(443, 12);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(84, 80);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(63, 95, 132);
            textBox1.Location = new Point(199, 116);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 11;
            textBox1.Text = "Nombre de usuario";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(63, 95, 132);
            textBox2.Location = new Point(199, 174);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 12;
            textBox2.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 197, 153);
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(214, 231);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 13;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 307);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pcbLogo);
            Controls.Add(lblLogin);
            Name = "frmLogin";
            Text = "Control de Acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private PictureBox pcbLogo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
