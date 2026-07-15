namespace pry.FormulariosMeetHub
{
    partial class frmCancelaciones
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
            lblTitulo = new Label();
            pnlCancelaciones = new Panel();
            btnAceptar = new Button();
            txtFormalizacion = new TextBox();
            lblFormalizacion = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            txtSala = new TextBox();
            lblSala = new Label();
            txtResponsable = new TextBox();
            lblResponsable = new Label();
            txtFolio = new TextBox();
            lblFolio = new Label();
            txtMotivo = new TextBox();
            lblMotivo = new Label();
            pnlCancelaciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 62, 80);
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 47);
            lblTitulo.TabIndex = 74;
            lblTitulo.Text = "Cancelaciones";
            // 
            // pnlCancelaciones
            // 
            pnlCancelaciones.Controls.Add(btnAceptar);
            pnlCancelaciones.Controls.Add(txtFormalizacion);
            pnlCancelaciones.Controls.Add(lblFormalizacion);
            pnlCancelaciones.Controls.Add(txtFecha);
            pnlCancelaciones.Controls.Add(lblFecha);
            pnlCancelaciones.Controls.Add(txtSala);
            pnlCancelaciones.Controls.Add(lblSala);
            pnlCancelaciones.Controls.Add(txtResponsable);
            pnlCancelaciones.Controls.Add(lblResponsable);
            pnlCancelaciones.Controls.Add(txtFolio);
            pnlCancelaciones.Controls.Add(lblFolio);
            pnlCancelaciones.Controls.Add(txtMotivo);
            pnlCancelaciones.Controls.Add(lblMotivo);
            pnlCancelaciones.Dock = DockStyle.Bottom;
            pnlCancelaciones.Location = new Point(0, 59);
            pnlCancelaciones.Name = "pnlCancelaciones";
            pnlCancelaciones.Size = new Size(1119, 497);
            pnlCancelaciones.TabIndex = 75;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 62, 80);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(461, 400);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(217, 33);
            btnAceptar.TabIndex = 46;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // txtFormalizacion
            // 
            txtFormalizacion.BackColor = Color.White;
            txtFormalizacion.Location = new Point(607, 172);
            txtFormalizacion.Name = "txtFormalizacion";
            txtFormalizacion.Size = new Size(433, 23);
            txtFormalizacion.TabIndex = 45;
            // 
            // lblFormalizacion
            // 
            lblFormalizacion.AutoSize = true;
            lblFormalizacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFormalizacion.ForeColor = Color.FromArgb(63, 95, 132);
            lblFormalizacion.Location = new Point(607, 143);
            lblFormalizacion.Name = "lblFormalizacion";
            lblFormalizacion.Size = new Size(199, 21);
            lblFormalizacion.TabIndex = 44;
            lblFormalizacion.Text = "Fecha de la Formalización:";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.White;
            txtFecha.Location = new Point(607, 75);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(433, 23);
            txtFecha.TabIndex = 43;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(63, 95, 132);
            lblFecha.Location = new Point(607, 46);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(153, 21);
            lblFecha.TabIndex = 42;
            lblFecha.Text = "Fecha de la reserva:";
            // 
            // txtSala
            // 
            txtSala.BackColor = Color.White;
            txtSala.Location = new Point(78, 284);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(433, 23);
            txtSala.TabIndex = 41;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSala.ForeColor = Color.FromArgb(63, 95, 132);
            lblSala.Location = new Point(78, 249);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(144, 21);
            lblSala.TabIndex = 40;
            lblSala.Text = "Sala de la Reserva:";
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.White;
            txtResponsable.Location = new Point(78, 179);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(433, 23);
            txtResponsable.TabIndex = 39;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsable.ForeColor = Color.FromArgb(63, 95, 132);
            lblResponsable.Location = new Point(78, 143);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(208, 21);
            lblResponsable.TabIndex = 38;
            lblResponsable.Text = "Responsable de la Reserva:";
            // 
            // txtFolio
            // 
            txtFolio.BackColor = Color.White;
            txtFolio.Location = new Point(78, 75);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(433, 23);
            txtFolio.TabIndex = 37;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFolio.ForeColor = Color.FromArgb(63, 95, 132);
            lblFolio.Location = new Point(78, 46);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(225, 21);
            lblFolio.TabIndex = 36;
            lblFolio.Text = "Ingrese el folio de su reserva:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.White;
            txtMotivo.Location = new Point(607, 284);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(431, 23);
            txtMotivo.TabIndex = 35;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMotivo.ForeColor = Color.FromArgb(63, 95, 132);
            lblMotivo.Location = new Point(607, 249);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(332, 21);
            lblMotivo.TabIndex = 34;
            lblMotivo.Text = "Motivo por el cual desea cancelar la reserva:";
            // 
            // frmCancelaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1119, 556);
            Controls.Add(pnlCancelaciones);
            Controls.Add(lblTitulo);
            Name = "frmCancelaciones";
            Text = "Cancelaciones";
            pnlCancelaciones.ResumeLayout(false);
            pnlCancelaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Panel pnlCancelaciones;
        private Button btnAceptar;
        private TextBox txtFormalizacion;
        private Label lblFormalizacion;
        private TextBox txtFecha;
        private Label lblFecha;
        private TextBox txtSala;
        private Label lblSala;
        private TextBox txtResponsable;
        private Label lblResponsable;
        private TextBox txtFolio;
        private Label lblFolio;
        private TextBox txtMotivo;
        private Label lblMotivo;
    }
}