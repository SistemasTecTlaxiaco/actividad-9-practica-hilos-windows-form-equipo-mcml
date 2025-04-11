using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AgendaCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent();
        }

        private void Label1_Click(object sender, EventArgs e) 
        {
             
        }

        private void Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void CajaGmail_TextChanged(object sender, EventArgs e)
        {
            CajaGmail.BackColor = Color.Yellow;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 

        }
      
        private void Olvi_Contra_Click(object sender, EventArgs e)
        {

        }

        private void No_Cuenta_Click(object sender, EventArgs e)
        {

        }

        private void Registrate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {
            Contrasena.BackColor = Color.LightBlue;
            CajaGmail.BackColor = Color.White;
        }
        private bool ValidarDatos()
        {
            // Verifica que los campos no estén vacíos
            return !string.IsNullOrWhiteSpace(CajaGmail.Text) && !string.IsNullOrWhiteSpace(Contrasena.Text);
        }
        private void IniciaSesion_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show("Los datos son correctos. ¿Deseas continuar?",
                                                      "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // En lugar de abrir Form2, abrimos Form3
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide(); // Oculta Form1 en lugar de cerrarlo
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Enfocar el campo de correo para que el usuario lo corrija
                CajaGmail.Focus();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
