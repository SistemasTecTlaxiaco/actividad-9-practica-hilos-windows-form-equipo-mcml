using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AgeT_Click(object sender, EventArgs e)
        {

        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {
            Contrasena3.BackColor = Color.Azure;
            Contrasena2.BackColor = Color.White;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent();
        }

        private void CajaGmail2_TextChanged(object sender, EventArgs e)
        {
            CajaGmail2.BackColor = Color.Azure;
            Contrasena2.BackColor = Color.White;

        }

        private void Contrasena2_TextChanged(object sender, EventArgs e)
        {
            Contrasena2.BackColor = Color.Azure;
            CajaGmail2.BackColor = Color.White;
        }
        private bool ValidarDatos()
        {
            // Verifica que los campos no estén vacíos y que las contraseñas coincidan
            return !string.IsNullOrWhiteSpace(CajaGmail2.Text)
                && !string.IsNullOrWhiteSpace(Contrasena2.Text)
                && !string.IsNullOrWhiteSpace(Contrasena3.Text)
                && Contrasena2.Text == Contrasena3.Text;
        }

        private void IniciaSesion2_Click(object sender, EventArgs e)
        {// Verifica si todos los campos están vacíos
            if (string.IsNullOrWhiteSpace(CajaGmail2.Text) && string.IsNullOrWhiteSpace(Contrasena2.Text) && string.IsNullOrWhiteSpace(Contrasena3.Text))
            {
                MessageBox.Show("Debes proporcionar tus datos para iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CajaGmail2.Focus();
                return;
            }

            // Verifica si las contraseñas coinciden
            if (Contrasena2.Text != Contrasena3.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Contrasena3.Focus();
                return;
            }

            // Verifica si el campo de correo está vacío
            if (string.IsNullOrWhiteSpace(CajaGmail2.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CajaGmail2.Focus();
                return;
            }

            // Si todo está correcto, muestra mensaje de confirmación
            DialogResult result = MessageBox.Show("Inicio de sesión exitoso. ¿Deseas continuar?",
                                                  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Abre Form3 y oculta Form2
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}
