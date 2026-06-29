namespace pry.FormulariosMeetHub
{
    partial class ApartadoCancelaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApartadoCancelaciones));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(63, 95, 132);
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 0;
            label1.Text = "Motivo por el cual desea cancelar la reserva:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(231, 238, 246);
            textBox1.Location = new Point(76, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(63, 95, 132);
            label2.Location = new Point(76, 124);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el folio de su reserva:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(231, 238, 246);
            textBox2.Location = new Point(76, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 238, 246);
            button1.ForeColor = Color.FromArgb(63, 95, 132);
            button1.Location = new Point(207, 377);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(231, 238, 246);
            button2.ForeColor = Color.FromArgb(63, 95, 132);
            button2.Location = new Point(384, 377);
            button2.Name = "button2";
            button2.Size = new Size(107, 33);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(708, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ApartadoCancelaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ApartadoCancelaciones";
            Text = "ApartadoCancelaciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}