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
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblFolio = new Label();
            txtFolio = new TextBox();
            txtResponsable = new TextBox();
            lblResponsable = new Label();
            txtSala = new TextBox();
            lblSala = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            txtFormalizacion = new TextBox();
            lblFormalizacion = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMotivo.ForeColor = Color.FromArgb(63, 95, 132);
            lblMotivo.Location = new Point(605, 253);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(332, 21);
            lblMotivo.TabIndex = 0;
            lblMotivo.Text = "Motivo por el cual desea cancelar la reserva:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.FromArgb(231, 238, 246);
            txtMotivo.Location = new Point(605, 288);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(431, 23);
            txtMotivo.TabIndex = 1;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFolio.ForeColor = Color.FromArgb(63, 95, 132);
            lblFolio.Location = new Point(76, 50);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(225, 21);
            lblFolio.TabIndex = 2;
            lblFolio.Text = "Ingrese el folio de su reserva:";
            // 
            // txtFolio
            // 
            txtFolio.BackColor = Color.FromArgb(231, 238, 246);
            txtFolio.Location = new Point(76, 79);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(433, 23);
            txtFolio.TabIndex = 3;
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = Color.FromArgb(231, 238, 246);
            txtResponsable.Location = new Point(76, 183);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(433, 23);
            txtResponsable.TabIndex = 22;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsable.ForeColor = Color.FromArgb(63, 95, 132);
            lblResponsable.Location = new Point(76, 147);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(208, 21);
            lblResponsable.TabIndex = 21;
            lblResponsable.Text = "Responsable de la Reserva:";
            // 
            // txtSala
            // 
            txtSala.BackColor = Color.FromArgb(231, 238, 246);
            txtSala.Location = new Point(76, 288);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(433, 23);
            txtSala.TabIndex = 24;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSala.ForeColor = Color.FromArgb(63, 95, 132);
            lblSala.Location = new Point(76, 253);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(144, 21);
            lblSala.TabIndex = 23;
            lblSala.Text = "Sala de la Reserva:";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(231, 238, 246);
            txtFecha.Location = new Point(605, 79);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(433, 23);
            txtFecha.TabIndex = 26;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(63, 95, 132);
            lblFecha.Location = new Point(605, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(153, 21);
            lblFecha.TabIndex = 25;
            lblFecha.Text = "Fecha de la reserva:";
            // 
            // txtFormalizacion
            // 
            txtFormalizacion.BackColor = Color.FromArgb(231, 238, 246);
            txtFormalizacion.Location = new Point(605, 176);
            txtFormalizacion.Name = "txtFormalizacion";
            txtFormalizacion.Size = new Size(433, 23);
            txtFormalizacion.TabIndex = 28;
            // 
            // lblFormalizacion
            // 
            lblFormalizacion.AutoSize = true;
            lblFormalizacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFormalizacion.ForeColor = Color.FromArgb(63, 95, 132);
            lblFormalizacion.Location = new Point(605, 147);
            lblFormalizacion.Name = "lblFormalizacion";
            lblFormalizacion.Size = new Size(199, 21);
            lblFormalizacion.TabIndex = 27;
            lblFormalizacion.Text = "Fecha de la Formalización:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 195, 175);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(42, 36, 33);
            btnCancelar.Location = new Point(634, 394);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(43, 62, 80);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(439, 394);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 33);
            btnAceptar.TabIndex = 32;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // frmCancelaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 230);
            ClientSize = new Size(1303, 445);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtFormalizacion);
            Controls.Add(lblFormalizacion);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtSala);
            Controls.Add(lblSala);
            Controls.Add(txtResponsable);
            Controls.Add(lblResponsable);
            Controls.Add(txtFolio);
            Controls.Add(lblFolio);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Name = "frmCancelaciones";
            Text = "Cancelaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblFolio;
        private TextBox txtFolio;
        private Button btnCancelar;
        private TextBox txtResponsable;
        private Label lblResponsable;
        private TextBox txtSala;
        private Label lblSala;
        private TextBox txtFecha;
        private Label lblFecha;
        private TextBox txtFormalizacion;
        private Label lblFormalizacion;
        private Button btnAceptar;
    }
}