﻿namespace AgendaCT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.AgendaTareas2 = new System.Windows.Forms.Label();
            this.Mas = new System.Windows.Forms.Button();
            this.TodasTareas = new System.Windows.Forms.Button();
            this.Trabajos = new System.Windows.Forms.Button();
            this.Personales = new System.Windows.Forms.Button();
            this.Metas = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AgendaTareas2
            // 
            this.AgendaTareas2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AgendaTareas2.AutoSize = true;
            this.AgendaTareas2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaTareas2.Location = new System.Drawing.Point(12, 9);
            this.AgendaTareas2.Name = "AgendaTareas2";
            this.AgendaTareas2.Size = new System.Drawing.Size(234, 32);
            this.AgendaTareas2.TabIndex = 1;
            this.AgendaTareas2.Text = "Agenda de tareas";
            this.AgendaTareas2.Click += new System.EventHandler(this.AgendaTareas2_Click);
            // 
            // Mas
            // 
            this.Mas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Mas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mas.BackgroundImage")));
            this.Mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mas.Location = new System.Drawing.Point(706, 321);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(40, 28);
            this.Mas.TabIndex = 8;
            this.Mas.UseVisualStyleBackColor = true;
            this.Mas.Click += new System.EventHandler(this.button1_Click);
            // 
            // TodasTareas
            // 
            this.TodasTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TodasTareas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TodasTareas.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodasTareas.Location = new System.Drawing.Point(71, 64);
            this.TodasTareas.Name = "TodasTareas";
            this.TodasTareas.Size = new System.Drawing.Size(148, 40);
            this.TodasTareas.TabIndex = 10;
            this.TodasTareas.Text = "Todas";
            this.TodasTareas.UseVisualStyleBackColor = false;
            this.TodasTareas.Click += new System.EventHandler(this.TodasTareas_Click);
            // 
            // Trabajos
            // 
            this.Trabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Trabajos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Trabajos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trabajos.Location = new System.Drawing.Point(246, 64);
            this.Trabajos.Name = "Trabajos";
            this.Trabajos.Size = new System.Drawing.Size(148, 40);
            this.Trabajos.TabIndex = 11;
            this.Trabajos.Text = "Trabajo";
            this.Trabajos.UseVisualStyleBackColor = false;
            this.Trabajos.Click += new System.EventHandler(this.Trabajos_Click);
            // 
            // Personales
            // 
            this.Personales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Personales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Personales.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personales.Location = new System.Drawing.Point(420, 64);
            this.Personales.Name = "Personales";
            this.Personales.Size = new System.Drawing.Size(148, 40);
            this.Personales.TabIndex = 12;
            this.Personales.Text = "Personal";
            this.Personales.UseVisualStyleBackColor = false;
            this.Personales.Click += new System.EventHandler(this.Personales_Click);
            // 
            // Metas
            // 
            this.Metas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Metas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Metas.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metas.Location = new System.Drawing.Point(598, 64);
            this.Metas.Name = "Metas";
            this.Metas.Size = new System.Drawing.Size(148, 40);
            this.Metas.TabIndex = 13;
            this.Metas.Text = "Meta";
            this.Metas.UseVisualStyleBackColor = false;
            this.Metas.Click += new System.EventHandler(this.Metas_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 9);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(767, 378);
            this.progressBar.TabIndex = 14;
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.ItemHeight = 20;
            this.listBoxTareas.Location = new System.Drawing.Point(71, 122);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(308, 224);
            this.listBoxTareas.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.listBoxTareas);
            this.Controls.Add(this.Metas);
            this.Controls.Add(this.Personales);
            this.Controls.Add(this.Trabajos);
            this.Controls.Add(this.TodasTareas);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.AgendaTareas2);
            this.Controls.Add(this.progressBar);
            this.Name = "Form3";
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgendaTareas2;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Button TodasTareas;
        private System.Windows.Forms.Button Trabajos;
        private System.Windows.Forms.Button Personales;
        private System.Windows.Forms.Button Metas;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxTareas;
    }
}