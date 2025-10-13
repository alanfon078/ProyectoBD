namespace ProyectoBD.Interfaces
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            lblWelcome = new Label();
            lblUser = new Label();
            btnRegistar = new Button();
            btnVerUsuarios = new Button();
            btnCerrarSesion = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Window;
            lblWelcome.Location = new Point(7, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(124, 27);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Window;
            lblUser.Location = new Point(137, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 27);
            lblUser.TabIndex = 1;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistar.Location = new Point(168, 121);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(299, 44);
            btnRegistar.TabIndex = 2;
            btnRegistar.Text = "Registrar Nuevo Usuario";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerUsuarios.Location = new Point(168, 171);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(299, 44);
            btnVerUsuarios.TabIndex = 3;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Red;
            btnCerrarSesion.Location = new Point(450, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(139, 28);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnVolver
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Crimson;
            btnSalir.Location = new Point(328, 12);
            btnSalir.Name = "btnVolver";
            btnSalir.Size = new Size(116, 28);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(601, 405);
            Controls.Add(btnSalir);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnVerUsuarios);
            Controls.Add(btnRegistar);
            Controls.Add(lblUser);
            Controls.Add(lblWelcome);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblUser;
        private Button btnRegistar;
        private Button btnVerUsuarios;
        private Button btnCerrarSesion;
        private Button btnSalir;
    }
}