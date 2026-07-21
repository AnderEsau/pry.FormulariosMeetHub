namespace pry.FormulariosMeetHub
{
    partial class frmExternos
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            pnlExterno = new Panel();
            txtEstado = new TextBox();
            txtCp = new TextBox();
            txtCiudad = new TextBox();
            txtColonia = new TextBox();
            txtCalle = new TextBox();
            txtInstitucion = new TextBox();
            txtCorreo = new TextBox();
            txtAMaterno = new TextBox();
            txtAPaterno = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            pnlExterno.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 62, 80);
            lblTitulo.Location = new Point(89, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(353, 37);
            lblTitulo.TabIndex = 76;
            lblTitulo.Text = "Nuevo responsable externo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 195, 175);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(42, 36, 33);
            btnCancelar.Location = new Point(296, 393);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
            btnCancelar.TabIndex = 78;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 62, 80);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(125, 393);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 33);
            btnGuardar.TabIndex = 77;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pnlExterno
            // 
            pnlExterno.BackColor = Color.White;
            pnlExterno.Controls.Add(txtEstado);
            pnlExterno.Controls.Add(txtCp);
            pnlExterno.Controls.Add(txtCiudad);
            pnlExterno.Controls.Add(txtColonia);
            pnlExterno.Controls.Add(txtCalle);
            pnlExterno.Controls.Add(txtInstitucion);
            pnlExterno.Controls.Add(txtCorreo);
            pnlExterno.Controls.Add(txtAMaterno);
            pnlExterno.Controls.Add(txtAPaterno);
            pnlExterno.Controls.Add(txtTelefono);
            pnlExterno.Controls.Add(txtNombre);
            pnlExterno.Controls.Add(btnCancelar);
            pnlExterno.Controls.Add(btnGuardar);
            pnlExterno.Location = new Point(0, 68);
            pnlExterno.Name = "pnlExterno";
            pnlExterno.Size = new Size(542, 449);
            pnlExterno.TabIndex = 79;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.White;
            txtEstado.BorderStyle = BorderStyle.FixedSingle;
            txtEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(296, 262);
            txtEstado.Margin = new Padding(1);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Size = new Size(218, 29);
            txtEstado.TabIndex = 89;
            // 
            // txtCp
            // 
            txtCp.BackColor = Color.White;
            txtCp.BorderStyle = BorderStyle.FixedSingle;
            txtCp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCp.Location = new Point(296, 200);
            txtCp.Margin = new Padding(1);
            txtCp.Name = "txtCp";
            txtCp.PlaceholderText = "Código Postal";
            txtCp.Size = new Size(218, 29);
            txtCp.TabIndex = 88;
            // 
            // txtCiudad
            // 
            txtCiudad.BackColor = Color.White;
            txtCiudad.BorderStyle = BorderStyle.FixedSingle;
            txtCiudad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCiudad.Location = new Point(296, 140);
            txtCiudad.Margin = new Padding(1);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PlaceholderText = "Ciudad";
            txtCiudad.Size = new Size(218, 29);
            txtCiudad.TabIndex = 87;
            // 
            // txtColonia
            // 
            txtColonia.BackColor = Color.White;
            txtColonia.BorderStyle = BorderStyle.FixedSingle;
            txtColonia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtColonia.Location = new Point(296, 81);
            txtColonia.Margin = new Padding(1);
            txtColonia.Name = "txtColonia";
            txtColonia.PlaceholderText = "Colonia";
            txtColonia.Size = new Size(218, 29);
            txtColonia.TabIndex = 86;
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.White;
            txtCalle.BorderStyle = BorderStyle.FixedSingle;
            txtCalle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCalle.Location = new Point(296, 22);
            txtCalle.Margin = new Padding(1);
            txtCalle.Name = "txtCalle";
            txtCalle.PlaceholderText = "Calle";
            txtCalle.Size = new Size(218, 29);
            txtCalle.TabIndex = 85;
            // 
            // txtInstitucion
            // 
            txtInstitucion.BackColor = Color.White;
            txtInstitucion.BorderStyle = BorderStyle.FixedSingle;
            txtInstitucion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstitucion.Location = new Point(19, 316);
            txtInstitucion.Margin = new Padding(1);
            txtInstitucion.Name = "txtInstitucion";
            txtInstitucion.PlaceholderText = "Institución de procedencia";
            txtInstitucion.Size = new Size(218, 29);
            txtInstitucion.TabIndex = 84;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(19, 200);
            txtCorreo.Margin = new Padding(1);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(218, 29);
            txtCorreo.TabIndex = 83;
            // 
            // txtAMaterno
            // 
            txtAMaterno.BackColor = Color.White;
            txtAMaterno.BorderStyle = BorderStyle.FixedSingle;
            txtAMaterno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAMaterno.Location = new Point(19, 140);
            txtAMaterno.Margin = new Padding(1);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(218, 29);
            txtAMaterno.TabIndex = 82;
            // 
            // txtAPaterno
            // 
            txtAPaterno.BackColor = Color.White;
            txtAPaterno.BorderStyle = BorderStyle.FixedSingle;
            txtAPaterno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAPaterno.Location = new Point(19, 81);
            txtAPaterno.Margin = new Padding(1);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(218, 29);
            txtAPaterno.TabIndex = 81;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(19, 262);
            txtTelefono.Margin = new Padding(1);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(219, 29);
            txtTelefono.TabIndex = 80;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(19, 22);
            txtNombre.Margin = new Padding(1);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(218, 29);
            txtNombre.TabIndex = 79;
            // 
            // frmExternos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 195, 175);
            ClientSize = new Size(542, 517);
            Controls.Add(pnlExterno);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExternos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExternos";
            pnlExterno.ResumeLayout(false);
            pnlExterno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Panel pnlExterno;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtAMaterno;
        private TextBox txtAPaterno;
        private TextBox txtTelefono;
        private TextBox txtEstado;
        private TextBox txtCp;
        private TextBox txtCiudad;
        private TextBox txtColonia;
        private TextBox txtCalle;
        private TextBox txtInstitucion;
    }
}