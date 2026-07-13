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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            lblMeetHub = new Label();
            pcbLoginMenu = new PictureBox();
            pcbPasswordIcono = new PictureBox();
            pcbLogotipo = new PictureBox();
            pcbUsuarioIcono = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLoginMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPasswordIcono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarioIcono).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(43, 62, 80);
            lblLogin.Location = new Point(207, 308);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(261, 96);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(167, 478);
            txtUsuario.Margin = new Padding(1, 2, 1, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(356, 35);
            txtUsuario.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(167, 575);
            txtPassword.Margin = new Padding(1, 2, 1, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(356, 35);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(43, 62, 80);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(207, 650);
            btnIngresar.Margin = new Padding(1, 2, 1, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(250, 55);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(210, 195, 175);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(42, 36, 33);
            btnSalir.Location = new Point(207, 732);
            btnSalir.Margin = new Padding(1, 2, 1, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 55);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblMeetHub
            // 
            lblMeetHub.AutoSize = true;
            lblMeetHub.BackColor = Color.White;
            lblMeetHub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeetHub.ForeColor = Color.FromArgb(179, 138, 88);
            lblMeetHub.Location = new Point(260, 258);
            lblMeetHub.Margin = new Padding(4, 0, 4, 0);
            lblMeetHub.Name = "lblMeetHub";
            lblMeetHub.Size = new Size(154, 45);
            lblMeetHub.TabIndex = 18;
            lblMeetHub.Text = "MeetHub";
            // 
            // pcbLoginMenu
            // 
            pcbLoginMenu.BackColor = Color.Transparent;
            pcbLoginMenu.Image = (Image)resources.GetObject("pcbLoginMenu.Image");
            pcbLoginMenu.Location = new Point(57, 45);
            pcbLoginMenu.Margin = new Padding(4, 5, 4, 5);
            pcbLoginMenu.Name = "pcbLoginMenu";
            pcbLoginMenu.Size = new Size(536, 792);
            pcbLoginMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginMenu.TabIndex = 20;
            pcbLoginMenu.TabStop = false;
            // 
            // pcbPasswordIcono
            // 
            pcbPasswordIcono.BackColor = Color.White;
            pcbPasswordIcono.Image = Properties.Resources.IconoContraseña_removebg_preview;
            pcbPasswordIcono.Location = new Point(104, 562);
            pcbPasswordIcono.Margin = new Padding(4, 5, 4, 5);
            pcbPasswordIcono.Name = "pcbPasswordIcono";
            pcbPasswordIcono.Size = new Size(57, 67);
            pcbPasswordIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPasswordIcono.TabIndex = 23;
            pcbPasswordIcono.TabStop = false;
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.BackColor = Color.White;
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(260, 70);
            pcbLogotipo.Margin = new Padding(4, 5, 4, 5);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(146, 173);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 25;
            pcbLogotipo.TabStop = false;
            // 
            // pcbUsuarioIcono
            // 
            pcbUsuarioIcono.BackColor = Color.White;
            pcbUsuarioIcono.Image = (Image)resources.GetObject("pcbUsuarioIcono.Image");
            pcbUsuarioIcono.Location = new Point(104, 462);
            pcbUsuarioIcono.Margin = new Padding(4, 5, 4, 5);
            pcbUsuarioIcono.Name = "pcbUsuarioIcono";
            pcbUsuarioIcono.Size = new Size(57, 67);
            pcbUsuarioIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarioIcono.TabIndex = 24;
            pcbUsuarioIcono.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 195, 175);
            ClientSize = new Size(649, 888);
            Controls.Add(pcbLogotipo);
            Controls.Add(pcbUsuarioIcono);
            Controls.Add(pcbPasswordIcono);
            Controls.Add(lblMeetHub);
            Controls.Add(btnSalir);
            Controls.Add(lblLogin);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(pcbLoginMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLoginMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPasswordIcono).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarioIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblMeetHub;
        private PictureBox pcbLoginMenu;
        private PictureBox pcbPasswordIcono;
        private PictureBox pcbLogotipo;
        private PictureBox pcbUsuarioIcono;
    }
}
