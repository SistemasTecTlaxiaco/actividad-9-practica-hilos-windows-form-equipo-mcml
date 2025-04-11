namespace AgendaCT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AgendaTareas = new System.Windows.Forms.Label();
            this.Bienvenido = new System.Windows.Forms.Label();
            this.CajaGmail = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.Olvi_Contra = new System.Windows.Forms.Label();
            this.No_Cuenta = new System.Windows.Forms.Label();
            this.Registrate = new System.Windows.Forms.Button();
            this.IniciaSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgendaTareas
            // 
            this.AgendaTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AgendaTareas.AutoSize = true;
            this.AgendaTareas.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaTareas.Location = new System.Drawing.Point(485, 39);
            this.AgendaTareas.Name = "AgendaTareas";
            this.AgendaTareas.Size = new System.Drawing.Size(292, 46);
            this.AgendaTareas.TabIndex = 0;
            this.AgendaTareas.Text = "Agenda de tareas";
            this.AgendaTareas.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Bienvenido
            // 
            this.Bienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(544, 111);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(200, 37);
            this.Bienvenido.TabIndex = 1;
            this.Bienvenido.Text = "Bienvenid@";
            this.Bienvenido.Click += new System.EventHandler(this.Bienvenido_Click);
            // 
            // CajaGmail
            // 
            this.CajaGmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CajaGmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaGmail.Location = new System.Drawing.Point(505, 181);
            this.CajaGmail.Name = "CajaGmail";
            this.CajaGmail.Size = new System.Drawing.Size(262, 26);
            this.CajaGmail.TabIndex = 2;
            this.CajaGmail.Text = "E-mail ";
            this.CajaGmail.TextChanged += new System.EventHandler(this.CajaGmail_TextChanged);
            // 
            // Contrasena
            // 
            this.Contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contrasena.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.Location = new System.Drawing.Point(505, 226);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(262, 26);
            this.Contrasena.TabIndex = 3;
            this.Contrasena.Text = "Contraseña ";
            this.Contrasena.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // Olvi_Contra
            // 
            this.Olvi_Contra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Olvi_Contra.AutoSize = true;
            this.Olvi_Contra.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olvi_Contra.Location = new System.Drawing.Point(502, 310);
            this.Olvi_Contra.Name = "Olvi_Contra";
            this.Olvi_Contra.Size = new System.Drawing.Size(187, 16);
            this.Olvi_Contra.TabIndex = 4;
            this.Olvi_Contra.Text = "Has alvidado tu contraseña?";
            this.Olvi_Contra.Click += new System.EventHandler(this.Olvi_Contra_Click);
            // 
            // No_Cuenta
            // 
            this.No_Cuenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.No_Cuenta.AutoSize = true;
            this.No_Cuenta.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Cuenta.Location = new System.Drawing.Point(439, 361);
            this.No_Cuenta.Name = "No_Cuenta";
            this.No_Cuenta.Size = new System.Drawing.Size(181, 16);
            this.No_Cuenta.TabIndex = 5;
            this.No_Cuenta.Text = "No cuento con una cuenta?";
            this.No_Cuenta.Click += new System.EventHandler(this.No_Cuenta_Click);
            // 
            // Registrate
            // 
            this.Registrate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registrate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Registrate.Location = new System.Drawing.Point(643, 351);
            this.Registrate.Name = "Registrate";
            this.Registrate.Size = new System.Drawing.Size(163, 34);
            this.Registrate.TabIndex = 8;
            this.Registrate.Text = "Registrate";
            this.Registrate.UseVisualStyleBackColor = false;
            this.Registrate.Click += new System.EventHandler(this.Registrate_Click);
            // 
            // IniciaSesion
            // 
            this.IniciaSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciaSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IniciaSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciaSesion.Location = new System.Drawing.Point(505, 267);
            this.IniciaSesion.Name = "IniciaSesion";
            this.IniciaSesion.Size = new System.Drawing.Size(262, 40);
            this.IniciaSesion.TabIndex = 9;
            this.IniciaSesion.Text = "Inicia sesión ";
            this.IniciaSesion.UseVisualStyleBackColor = false;
            this.IniciaSesion.Click += new System.EventHandler(this.IniciaSesion_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 450);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IniciaSesion);
            this.Controls.Add(this.Registrate);
            this.Controls.Add(this.No_Cuenta);
            this.Controls.Add(this.Olvi_Contra);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.CajaGmail);
            this.Controls.Add(this.Bienvenido);
            this.Controls.Add(this.AgendaTareas);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgendaTareas;
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.TextBox CajaGmail;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.Label Olvi_Contra;
        private System.Windows.Forms.Label No_Cuenta;
        private System.Windows.Forms.Button Registrate;
        private System.Windows.Forms.Button IniciaSesion;
        private System.Windows.Forms.Button button1;
    }
}

