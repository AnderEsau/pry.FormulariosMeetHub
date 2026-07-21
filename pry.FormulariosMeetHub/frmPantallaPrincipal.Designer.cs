namespace pry.FormulariosMeetHub
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbTiraInferior = new PictureBox();
            pcbLogotipo = new PictureBox();
            pnlContenedor = new Panel();
            lblMeetHub = new Label();
            btnReservaciones = new Button();
            pnlMenu = new Panel();
            btnResponsables = new Button();
            btnEquipamiento = new Button();
            btnAreasDpto = new Button();
            btnUsuarios = new Button();
            btnSalas = new Button();
            btnSalir = new Button();
            btnReporteP = new Button();
            btnCancelaciones = new Button();
            btnReservasPnds = new Button();
            lblModulo = new Label();
            lblNombreModulo = new Label();
            lblNombreUser = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbTiraInferior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pcbTiraInferior
            // 
            pcbTiraInferior.Image = (Image)resources.GetObject("pcbTiraInferior.Image");
            pcbTiraInferior.Location = new Point(0, 683);
            pcbTiraInferior.Name = "pcbTiraInferior";
            pcbTiraInferior.Size = new Size(1365, 22);
            pcbTiraInferior.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTiraInferior.TabIndex = 0;
            pcbTiraInferior.TabStop = false;
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.BackColor = Color.Transparent;
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(37, 3);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(103, 99);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 17;
            pcbLogotipo.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(240, 236, 230);
            pnlContenedor.Location = new Point(203, 57);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1135, 595);
            pnlContenedor.TabIndex = 23;
            // 
            // lblMeetHub
            // 
            lblMeetHub.AutoSize = true;
            lblMeetHub.BackColor = Color.Transparent;
            lblMeetHub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeetHub.ForeColor = Color.FromArgb(43, 62, 80);
            lblMeetHub.Location = new Point(39, 107);
            lblMeetHub.Name = "lblMeetHub";
            lblMeetHub.Size = new Size(100, 30);
            lblMeetHub.TabIndex = 25;
            lblMeetHub.Text = "MeetHub";
            // 
            // btnReservaciones
            // 
            btnReservaciones.BackColor = Color.Transparent;
            btnReservaciones.BackgroundImage = (Image)resources.GetObject("btnReservaciones.BackgroundImage");
            btnReservaciones.BackgroundImageLayout = ImageLayout.Stretch;
            btnReservaciones.Cursor = Cursors.Hand;
            btnReservaciones.FlatAppearance.BorderSize = 0;
            btnReservaciones.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReservaciones.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReservaciones.FlatStyle = FlatStyle.Flat;
            btnReservaciones.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservaciones.ImageAlign = ContentAlignment.TopCenter;
            btnReservaciones.Location = new Point(25, 145);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(128, 44);
            btnReservaciones.TabIndex = 32;
            btnReservaciones.TextAlign = ContentAlignment.BottomCenter;
            btnReservaciones.UseVisualStyleBackColor = false;
            btnReservaciones.Click += btnReservaciones_Click;
            btnReservaciones.MouseDown += btnGeneral_MouseDown;
            btnReservaciones.MouseUp += btnGeneral_MouseUp;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(210, 195, 175);
            pnlMenu.Controls.Add(btnResponsables);
            pnlMenu.Controls.Add(btnEquipamiento);
            pnlMenu.Controls.Add(btnAreasDpto);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnSalas);
            pnlMenu.Controls.Add(lblMeetHub);
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReporteP);
            pnlMenu.Controls.Add(btnCancelaciones);
            pnlMenu.Controls.Add(pcbLogotipo);
            pnlMenu.Controls.Add(btnReservasPnds);
            pnlMenu.Controls.Add(btnReservaciones);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(180, 705);
            pnlMenu.TabIndex = 31;
            // 
            // btnResponsables
            // 
            btnResponsables.BackColor = Color.Transparent;
            btnResponsables.BackgroundImage = (Image)resources.GetObject("btnResponsables.BackgroundImage");
            btnResponsables.BackgroundImageLayout = ImageLayout.Stretch;
            btnResponsables.Cursor = Cursors.Hand;
            btnResponsables.FlatAppearance.BorderSize = 0;
            btnResponsables.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnResponsables.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnResponsables.FlatStyle = FlatStyle.Flat;
            btnResponsables.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResponsables.ImageAlign = ContentAlignment.TopCenter;
            btnResponsables.Location = new Point(62, 683);
            btnResponsables.Name = "btnResponsables";
            btnResponsables.Size = new Size(50, 19);
            btnResponsables.TabIndex = 35;
            btnResponsables.TextAlign = ContentAlignment.BottomCenter;
            btnResponsables.UseVisualStyleBackColor = false;
            btnResponsables.Click += btnResponsables_Click;
            btnResponsables.MouseDown += btnGeneral_MouseDown;
            btnResponsables.MouseUp += btnGeneral_MouseUp;
            // 
            // btnEquipamiento
            // 
            btnEquipamiento.BackColor = Color.Transparent;
            btnEquipamiento.BackgroundImage = (Image)resources.GetObject("btnEquipamiento.BackgroundImage");
            btnEquipamiento.BackgroundImageLayout = ImageLayout.Stretch;
            btnEquipamiento.Cursor = Cursors.Hand;
            btnEquipamiento.FlatAppearance.BorderSize = 0;
            btnEquipamiento.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEquipamiento.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEquipamiento.FlatStyle = FlatStyle.Flat;
            btnEquipamiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquipamiento.ImageAlign = ContentAlignment.TopCenter;
            btnEquipamiento.Location = new Point(25, 267);
            btnEquipamiento.Name = "btnEquipamiento";
            btnEquipamiento.Size = new Size(128, 44);
            btnEquipamiento.TabIndex = 39;
            btnEquipamiento.TextAlign = ContentAlignment.BottomCenter;
            btnEquipamiento.UseVisualStyleBackColor = false;
            btnEquipamiento.Click += btnEquipamiento_Click;
            // 
            // btnAreasDpto
            // 
            btnAreasDpto.BackColor = Color.Transparent;
            btnAreasDpto.BackgroundImage = (Image)resources.GetObject("btnAreasDpto.BackgroundImage");
            btnAreasDpto.BackgroundImageLayout = ImageLayout.Stretch;
            btnAreasDpto.Cursor = Cursors.Hand;
            btnAreasDpto.FlatAppearance.BorderSize = 0;
            btnAreasDpto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAreasDpto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAreasDpto.FlatStyle = FlatStyle.Flat;
            btnAreasDpto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAreasDpto.ImageAlign = ContentAlignment.TopCenter;
            btnAreasDpto.Location = new Point(25, 328);
            btnAreasDpto.Name = "btnAreasDpto";
            btnAreasDpto.Size = new Size(128, 44);
            btnAreasDpto.TabIndex = 38;
            btnAreasDpto.TextAlign = ContentAlignment.BottomCenter;
            btnAreasDpto.UseVisualStyleBackColor = false;
            btnAreasDpto.Click += btnAreasDpto_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.BackgroundImage = (Image)resources.GetObject("btnUsuarios.BackgroundImage");
            btnUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.ImageAlign = ContentAlignment.TopCenter;
            btnUsuarios.Location = new Point(25, 389);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(128, 44);
            btnUsuarios.TabIndex = 37;
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            btnUsuarios.MouseDown += btnGeneral_MouseDown;
            btnUsuarios.MouseUp += btnGeneral_MouseUp;
            // 
            // btnSalas
            // 
            btnSalas.BackColor = Color.Transparent;
            btnSalas.BackgroundImage = (Image)resources.GetObject("btnSalas.BackgroundImage");
            btnSalas.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalas.Cursor = Cursors.Hand;
            btnSalas.FlatAppearance.BorderSize = 0;
            btnSalas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalas.FlatStyle = FlatStyle.Flat;
            btnSalas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalas.ImageAlign = ContentAlignment.TopCenter;
            btnSalas.Location = new Point(25, 572);
            btnSalas.Name = "btnSalas";
            btnSalas.Size = new Size(128, 44);
            btnSalas.TabIndex = 36;
            btnSalas.TextAlign = ContentAlignment.BottomCenter;
            btnSalas.UseVisualStyleBackColor = false;
            btnSalas.Click += btnSalas_Click;
            btnSalas.MouseDown += btnGeneral_MouseDown;
            btnSalas.MouseUp += btnGeneral_MouseUp;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(25, 633);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 44);
            btnSalir.TabIndex = 34;
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseDown += btnGeneral_MouseDown;
            btnSalir.MouseUp += btnGeneral_MouseUp;
            // 
            // btnReporteP
            // 
            btnReporteP.BackColor = Color.Transparent;
            btnReporteP.BackgroundImage = (Image)resources.GetObject("btnReporteP.BackgroundImage");
            btnReporteP.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporteP.Cursor = Cursors.Hand;
            btnReporteP.FlatAppearance.BorderSize = 0;
            btnReporteP.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReporteP.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReporteP.FlatStyle = FlatStyle.Flat;
            btnReporteP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteP.ImageAlign = ContentAlignment.TopCenter;
            btnReporteP.Location = new Point(25, 511);
            btnReporteP.Name = "btnReporteP";
            btnReporteP.Size = new Size(128, 44);
            btnReporteP.TabIndex = 33;
            btnReporteP.TextAlign = ContentAlignment.BottomCenter;
            btnReporteP.UseVisualStyleBackColor = false;
            btnReporteP.Click += btnReporteP_Click;
            btnReporteP.MouseDown += btnGeneral_MouseDown;
            btnReporteP.MouseUp += btnGeneral_MouseUp;
            // 
            // btnCancelaciones
            // 
            btnCancelaciones.BackColor = Color.Transparent;
            btnCancelaciones.BackgroundImage = (Image)resources.GetObject("btnCancelaciones.BackgroundImage");
            btnCancelaciones.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelaciones.Cursor = Cursors.Hand;
            btnCancelaciones.FlatAppearance.BorderSize = 0;
            btnCancelaciones.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelaciones.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancelaciones.FlatStyle = FlatStyle.Flat;
            btnCancelaciones.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelaciones.ImageAlign = ContentAlignment.TopCenter;
            btnCancelaciones.Location = new Point(25, 206);
            btnCancelaciones.Name = "btnCancelaciones";
            btnCancelaciones.Size = new Size(128, 44);
            btnCancelaciones.TabIndex = 32;
            btnCancelaciones.TextAlign = ContentAlignment.BottomCenter;
            btnCancelaciones.UseVisualStyleBackColor = false;
            btnCancelaciones.Click += btnCancelaciones_Click;
            btnCancelaciones.MouseDown += btnGeneral_MouseDown;
            btnCancelaciones.MouseUp += btnGeneral_MouseUp;
            // 
            // btnReservasPnds
            // 
            btnReservasPnds.BackColor = Color.Transparent;
            btnReservasPnds.BackgroundImage = (Image)resources.GetObject("btnReservasPnds.BackgroundImage");
            btnReservasPnds.BackgroundImageLayout = ImageLayout.Stretch;
            btnReservasPnds.Cursor = Cursors.Hand;
            btnReservasPnds.FlatAppearance.BorderSize = 0;
            btnReservasPnds.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReservasPnds.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReservasPnds.FlatStyle = FlatStyle.Flat;
            btnReservasPnds.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservasPnds.ImageAlign = ContentAlignment.TopCenter;
            btnReservasPnds.Location = new Point(25, 450);
            btnReservasPnds.Name = "btnReservasPnds";
            btnReservasPnds.Size = new Size(128, 44);
            btnReservasPnds.TabIndex = 31;
            btnReservasPnds.TextAlign = ContentAlignment.BottomCenter;
            btnReservasPnds.UseVisualStyleBackColor = false;
            btnReservasPnds.Click += btnReservasPnds_Click;
            btnReservasPnds.MouseDown += btnGeneral_MouseDown;
            btnReservasPnds.MouseUp += btnGeneral_MouseUp;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.BackColor = Color.Transparent;
            lblModulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulo.ForeColor = Color.White;
            lblModulo.Location = new Point(203, 9);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(97, 30);
            lblModulo.TabIndex = 35;
            lblModulo.Text = "Módulo:";
            // 
            // lblNombreModulo
            // 
            lblNombreModulo.AutoSize = true;
            lblNombreModulo.BackColor = Color.Transparent;
            lblNombreModulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreModulo.ForeColor = Color.White;
            lblNombreModulo.Location = new Point(300, 9);
            lblNombreModulo.Name = "lblNombreModulo";
            lblNombreModulo.Size = new Size(37, 30);
            lblNombreModulo.TabIndex = 36;
            lblNombreModulo.Text = "---";
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.BackColor = Color.Transparent;
            lblNombreUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUser.ForeColor = Color.White;
            lblNombreUser.Location = new Point(1189, 9);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(83, 30);
            lblNombreUser.TabIndex = 37;
            lblNombreUser.Text = "Usuario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(1080, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 30);
            lblUsuario.TabIndex = 38;
            lblUsuario.Text = "Usuario:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 62, 80);
            ClientSize = new Size(1366, 705);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombreUser);
            Controls.Add(lblNombreModulo);
            Controls.Add(lblModulo);
            Controls.Add(pnlMenu);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbTiraInferior);
            Name = "frmPrincipal";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbTiraInferior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbTiraInferior;
        private PictureBox pcbTiraSuperior1;
        private PictureBox pcbLogotipo;
        private Panel pnlContenedor;
        private Label lblMeetHub;
        private Button btnReservaciones;
        private Panel pnlMenu;
        private Button btnReservasPnds;
        private Button btnCancelaciones;
        private Button btnReporteP;
        private Button btnSalir;
        private Label lblModulo;
        private Label lblNombreModulo;
        private Label lblNombreUser;
        private Label lblUsuario;
        private Button btnUsuarios;
        private Button btnSalas;
        private Button btnResponsables;
        private Button btnAreasDpto;
        private Button btnEquipamiento;
    }
}