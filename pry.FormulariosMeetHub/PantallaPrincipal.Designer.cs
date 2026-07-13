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
            lblUsuario = new Label();
            lblMeetHub = new Label();
            btnReservaciones = new Button();
            panel1 = new Panel();
            btnSalir = new Button();
            btnReporteP = new Button();
            btnCancelaciones = new Button();
            btnReservasPnds = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcbTiraInferior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pcbTiraInferior
            // 
            pcbTiraInferior.Image = (Image)resources.GetObject("pcbTiraInferior.Image");
            pcbTiraInferior.Location = new Point(0, 672);
            pcbTiraInferior.Name = "pcbTiraInferior";
            pcbTiraInferior.Size = new Size(1365, 33);
            pcbTiraInferior.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTiraInferior.TabIndex = 0;
            pcbTiraInferior.TabStop = false;
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.BackColor = Color.Transparent;
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(1262, 3);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(103, 99);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 17;
            pcbLogotipo.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(240, 236, 230);
            pnlContenedor.BorderStyle = BorderStyle.Fixed3D;
            pnlContenedor.Location = new Point(24, 171);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1319, 484);
            pnlContenedor.TabIndex = 23;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.White;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(43, 62, 80);
            lblUsuario.Location = new Point(1271, 8);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 30);
            lblUsuario.TabIndex = 24;
            lblUsuario.Text = "Usuario";
            // 
            // lblMeetHub
            // 
            lblMeetHub.AutoSize = true;
            lblMeetHub.BackColor = Color.White;
            lblMeetHub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeetHub.ForeColor = Color.FromArgb(43, 62, 80);
            lblMeetHub.Location = new Point(12, 8);
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
            btnReservaciones.Location = new Point(24, 12);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(100, 84);
            btnReservaciones.TabIndex = 0;
            btnReservaciones.TextAlign = ContentAlignment.BottomCenter;
            btnReservaciones.UseVisualStyleBackColor = false;
            btnReservaciones.Click += btnReservaciones_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 195, 175);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReporteP);
            panel1.Controls.Add(btnCancelaciones);
            panel1.Controls.Add(pcbLogotipo);
            panel1.Controls.Add(btnReservasPnds);
            panel1.Controls.Add(btnReservaciones);
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 106);
            panel1.TabIndex = 31;
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
            btnSalir.Location = new Point(1137, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 84);
            btnSalir.TabIndex = 34;
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            btnReporteP.Location = new Point(476, 12);
            btnReporteP.Name = "btnReporteP";
            btnReporteP.Size = new Size(100, 84);
            btnReporteP.TabIndex = 33;
            btnReporteP.TextAlign = ContentAlignment.BottomCenter;
            btnReporteP.UseVisualStyleBackColor = false;
            btnReporteP.Click += btnReporteP_Click;
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
            btnCancelaciones.Location = new Point(324, 12);
            btnCancelaciones.Name = "btnCancelaciones";
            btnCancelaciones.Size = new Size(100, 84);
            btnCancelaciones.TabIndex = 32;
            btnCancelaciones.TextAlign = ContentAlignment.BottomCenter;
            btnCancelaciones.UseVisualStyleBackColor = false;
            btnCancelaciones.Click += btnCancelaciones_Click;
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
            btnReservasPnds.Location = new Point(172, 12);
            btnReservasPnds.Name = "btnReservasPnds";
            btnReservasPnds.Size = new Size(100, 84);
            btnReservasPnds.TabIndex = 31;
            btnReservasPnds.TextAlign = ContentAlignment.BottomCenter;
            btnReservasPnds.UseVisualStyleBackColor = false;
            btnReservasPnds.Click += btnReservasPnds_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblMeetHub);
            panel2.Controls.Add(lblUsuario);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1366, 45);
            panel2.TabIndex = 32;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 62, 80);
            ClientSize = new Size(1366, 705);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbTiraInferior);
            Name = "frmPrincipal";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pcbTiraInferior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbTiraInferior;
        private PictureBox pcbTiraSuperior1;
        private PictureBox pcbLogotipo;
        private Panel pnlContenedor;
        private Label lblUsuario;
        private Label lblMeetHub;
        private Button btnReservaciones;
        private Panel panel1;
        private Button btnReservasPnds;
        private Button btnCancelaciones;
        private Button btnReporteP;
        private Button btnSalir;
        private Panel panel2;
    }
}