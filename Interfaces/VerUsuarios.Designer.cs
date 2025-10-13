namespace ProyectoBD.Interfaces
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            listViewUsuarios = new ListView();
            lblUser = new Label();
            lblWelcome = new Label();
            btnVolver = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // listViewUsuarios
            // 
            listViewUsuarios.Location = new Point(73, 60);
            listViewUsuarios.Name = "listViewUsuarios";
            listViewUsuarios.Size = new Size(981, 510);
            listViewUsuarios.TabIndex = 0;
            listViewUsuarios.UseCompatibleStateImageBehavior = false;
            listViewUsuarios.View = View.Details;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Window;
            lblUser.Location = new Point(142, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 27);
            lblUser.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Window;
            lblWelcome.Location = new Point(12, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(124, 27);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Bienvenido:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.BackgroundImageLayout = ImageLayout.None;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Crimson;
            btnVolver.Location = new Point(20, 583);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 28);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Red;
            btnCerrarSesion.Location = new Point(142, 583);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(139, 28);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1107, 623);
            Controls.Add(btnVolver);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblUser);
            Controls.Add(lblWelcome);
            Controls.Add(listViewUsuarios);
            Name = "VerUsuarios";
            Text = "VerUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewUsuarios;
        private Label lblUser;
        private Label lblWelcome;
        private Button btnVolver;
        private Button btnCerrarSesion;
    }
}