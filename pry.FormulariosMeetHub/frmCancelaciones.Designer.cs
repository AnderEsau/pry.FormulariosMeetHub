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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelaciones));
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblFolio = new Label();
            txtFolio = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            pcbLogotipo = new PictureBox();
            txtResponsable = new TextBox();
            lblResponsable = new Label();
            txtSala = new TextBox();
            lblSala = new Label();
            textBox1 = new TextBox();
            lblFecha = new Label();
            txtFormalizacion = new TextBox();
            lblFormalizacion = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).BeginInit();
            SuspendLayout();
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Arial", 11F);
            lblMotivo.ForeColor = Color.FromArgb(63, 95, 132);
            lblMotivo.Location = new Point(605, 253);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(296, 17);
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
            lblFolio.Font = new Font("Arial", 11F);
            lblFolio.ForeColor = Color.FromArgb(63, 95, 132);
            lblFolio.Location = new Point(76, 50);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(198, 17);
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(235, 197, 153);
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(566, 364);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 33);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(235, 197, 153);
            btnAceptar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(434, 364);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 33);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pcbLogotipo
            // 
            pcbLogotipo.Image = (Image)resources.GetObject("pcbLogotipo.Image");
            pcbLogotipo.Location = new Point(1202, -2);
            pcbLogotipo.Name = "pcbLogotipo";
            pcbLogotipo.Size = new Size(102, 104);
            pcbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipo.TabIndex = 20;
            pcbLogotipo.TabStop = false;
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
            lblResponsable.Font = new Font("Arial", 11F);
            lblResponsable.ForeColor = Color.FromArgb(63, 95, 132);
            lblResponsable.Location = new Point(76, 147);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(192, 17);
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
            lblSala.Font = new Font("Arial", 11F);
            lblSala.ForeColor = Color.FromArgb(63, 95, 132);
            lblSala.Location = new Point(76, 253);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(135, 17);
            lblSala.TabIndex = 23;
            lblSala.Text = "Sala de la Reserva:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(231, 238, 246);
            textBox1.Location = new Point(605, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 23);
            textBox1.TabIndex = 26;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 11F);
            lblFecha.ForeColor = Color.FromArgb(63, 95, 132);
            lblFecha.Location = new Point(605, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(141, 17);
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
            lblFormalizacion.Font = new Font("Arial", 11F);
            lblFormalizacion.ForeColor = Color.FromArgb(63, 95, 132);
            lblFormalizacion.Location = new Point(605, 147);
            lblFormalizacion.Name = "lblFormalizacion";
            lblFormalizacion.Size = new Size(184, 17);
            lblFormalizacion.TabIndex = 27;
            lblFormalizacion.Text = "Fecha de la Formalización:";
            // 
            // frmCancelaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 220, 228);
            ClientSize = new Size(1303, 445);
            Controls.Add(txtFormalizacion);
            Controls.Add(lblFormalizacion);
            Controls.Add(textBox1);
            Controls.Add(lblFecha);
            Controls.Add(txtSala);
            Controls.Add(lblSala);
            Controls.Add(txtResponsable);
            Controls.Add(lblResponsable);
            Controls.Add(pcbLogotipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtFolio);
            Controls.Add(lblFolio);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Name = "frmCancelaciones";
            Text = "Cancelaciones";
            ((System.ComponentModel.ISupportInitialize)pcbLogotipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblFolio;
        private TextBox txtFolio;
        private Button btnCancelar;
        private Button btnAceptar;
        private PictureBox pcbLogotipo;
        private TextBox txtResponsable;
        private Label lblResponsable;
        private TextBox txtSala;
        private Label lblSala;
        private TextBox textBox1;
        private Label lblFecha;
        private TextBox txtFormalizacion;
        private Label lblFormalizacion;
    }
}