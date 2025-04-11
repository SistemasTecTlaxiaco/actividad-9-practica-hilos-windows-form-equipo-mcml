namespace AgendaCT
{
    partial class Form2
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
            this.CajaGmail2 = new System.Windows.Forms.TextBox();
            this.Contrasena3 = new System.Windows.Forms.TextBox();
            this.Contrasena2 = new System.Windows.Forms.TextBox();
            this.IniciaSesion2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CajaGmail2
            // 
            this.CajaGmail2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CajaGmail2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaGmail2.Location = new System.Drawing.Point(307, 96);
            this.CajaGmail2.Name = "CajaGmail2";
            this.CajaGmail2.Size = new System.Drawing.Size(175, 26);
            this.CajaGmail2.TabIndex = 3;
            this.CajaGmail2.Text = "E-mail ";
            this.CajaGmail2.TextChanged += new System.EventHandler(this.CajaGmail2_TextChanged);
            // 
            // Contrasena3
            // 
            this.Contrasena3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contrasena3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena3.Location = new System.Drawing.Point(307, 203);
            this.Contrasena3.Name = "Contrasena3";
            this.Contrasena3.Size = new System.Drawing.Size(175, 26);
            this.Contrasena3.TabIndex = 4;
            this.Contrasena3.Text = "Confirma Contraseña ";
            this.Contrasena3.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // Contrasena2
            // 
            this.Contrasena2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contrasena2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena2.Location = new System.Drawing.Point(307, 146);
            this.Contrasena2.Name = "Contrasena2";
            this.Contrasena2.Size = new System.Drawing.Size(175, 26);
            this.Contrasena2.TabIndex = 5;
            this.Contrasena2.Text = "Contraseña ";
            this.Contrasena2.TextChanged += new System.EventHandler(this.Contrasena2_TextChanged);
            // 
            // IniciaSesion2
            // 
            this.IniciaSesion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciaSesion2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IniciaSesion2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciaSesion2.Location = new System.Drawing.Point(317, 254);
            this.IniciaSesion2.Name = "IniciaSesion2";
            this.IniciaSesion2.Size = new System.Drawing.Size(154, 39);
            this.IniciaSesion2.TabIndex = 10;
            this.IniciaSesion2.Text = "Continuar ";
            this.IniciaSesion2.UseVisualStyleBackColor = false;
            this.IniciaSesion2.Click += new System.EventHandler(this.IniciaSesion2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IniciaSesion2);
            this.Controls.Add(this.Contrasena2);
            this.Controls.Add(this.Contrasena3);
            this.Controls.Add(this.CajaGmail2);
            this.Name = "Form2";
            this.Text = "Registrate";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CajaGmail2;
        private System.Windows.Forms.TextBox Contrasena3;
        private System.Windows.Forms.TextBox Contrasena2;
        private System.Windows.Forms.Button IniciaSesion2;
    }
}