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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            pcbPasswordIcono = new PictureBox();
            pcbUsuarioIcono = new PictureBox();
            pcbLogotipo = new PictureBox();
            btnSalir = new Button();
            lblMeetHub = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPasswordIcono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarioIcono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(63, 95, 132);
            lblLogin.Location = new Point(212, 40);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(175, 65);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(716, 1);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(89, 67);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(231, 238, 246);
            txtUsuario.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(186, 132);
            txtUsuario.Margin = new Padding(1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(250, 29);
            txtUsuario.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(231, 238, 246);
            txtPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(186, 188);
            txtPassword.Margin = new Padding(1);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(250, 29);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(235, 197, 153);
            btnIngresar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Location = new Point(196, 243);
            btnIngresar.Margin = new Padding(1);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 33);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // pcbPasswordIcono
            // 
            pcbPasswordIcono.Image = Properties.Resources.IconoContraseña_removebg_preview;
            pcbPasswordIcono.Location = new Point(138, 184);
            pcbPasswordIcono.Name = "pcbPasswordIcono";
            pcbPasswordIcono.Size = new Size(40, 40);
            pcbPasswordIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPasswordIcono.TabIndex = 14;
            pcbPasswordIcono.TabStop = false;
            // 
            // pcbUsuarioIcono
            // 
            pcbUsuarioIcono.Image = (Image)resources.GetObject("pcbUsuarioIcono.Image");
            pcbUsuarioIcono.Location = new Point(138, 125);
            pcbUsuarioIcono.Name = "pcbUsuarioIcono";
            pcbUsuarioIcono.Size = new Size(40, 40);
            pcbUsuarioIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarioIcono.TabIndex = 15;
            pcbUsuarioIcono.TabStop = false;
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(481, 1);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(102, 104);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 16;
            pcbLogotipo.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(235, 197, 153);
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(328, 243);
            btnSalir.Margin = new Padding(1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 33);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblMeetHub
            // 
            lblMeetHub.AutoSize = true;
            lblMeetHub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeetHub.ForeColor = Color.FromArgb(63, 95, 132);
            lblMeetHub.Location = new Point(12, 9);
            lblMeetHub.Name = "lblMeetHub";
            lblMeetHub.Size = new Size(100, 30);
            lblMeetHub.TabIndex = 18;
            lblMeetHub.Text = "MeetHub";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(584, 361);
            Controls.Add(lblMeetHub);
            Controls.Add(btnSalir);
            Controls.Add(pcbLogotipo);
            Controls.Add(pcbUsuarioIcono);
            Controls.Add(pcbPasswordIcono);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLogo);
            Controls.Add(lblLogin);
            Name = "frmLogin";
            Text = "Control de acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPasswordIcono).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarioIcono).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private PictureBox pcbLogo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private PictureBox pcbPasswordIcono;
        private PictureBox pcbUsuarioIcono;
        private PictureBox pcbLogotipo;
        private Button btnSalir;
        private Label lblMeetHub;
    }
}
