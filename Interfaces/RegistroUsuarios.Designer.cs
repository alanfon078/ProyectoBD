namespace ProyectoBD.Interfaces
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            dtpFechaNacimiento = new DateTimePicker();
            lblRegistro = new Label();
            txtNombre = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrar = new Button();
            lblUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegresar = new Button();
            txtApellidos = new TextBox();
            SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.CalendarMonthBackground = Color.FromArgb(127, 127, 127);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(315, 493);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(558, 27);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.BackColor = Color.Transparent;
            lblRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.ForeColor = SystemColors.Control;
            lblRegistro.Location = new Point(12, 9);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(244, 28);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registrar Nuevo Usuario";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(312, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(312, 217);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(561, 27);
            txtUser.TabIndex = 3;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(312, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(561, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(312, 355);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(561, 27);
            txtCorreo.TabIndex = 5;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(312, 425);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(561, 27);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(127, 127, 127);
            btnRegistrar.Location = new Point(553, 551);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Control;
            lblUser.Location = new Point(315, 105);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(89, 28);
            lblUser.TabIndex = 10;
            lblUser.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(784, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 11;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(553, 186);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 12;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(543, 256);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 13;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(501, 324);
            label4.Name = "label4";
            label4.Size = new Size(187, 28);
            label4.TabIndex = 14;
            label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(553, 394);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 15;
            label5.Text = "Telefono";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.FromArgb(127, 127, 127);
            btnRegresar.Location = new Point(12, 631);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.White;
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApellidos.ForeColor = Color.Black;
            txtApellidos.Location = new Point(620, 148);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(253, 27);
            txtApellidos.TabIndex = 2;
            txtApellidos.TextAlign = HorizontalAlignment.Center;
            // 
            // RegistroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1208, 672);
            Controls.Add(btnRegresar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblRegistro);
            Name = "RegistroUsuarios";
            Text = "RegistroUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private TextBox txtNombre;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private Button btnRegistrar;
        private Label lblUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegresar;
        private TextBox txtApellidos;
    }
}