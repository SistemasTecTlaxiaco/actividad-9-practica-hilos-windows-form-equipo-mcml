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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ingresaT_TextChanged(object sender, EventArgs e)
        {
            ingresaT.BackColor = Color.LightBlue;
            elegir.BackColor = Color.White;
        }

        private void AgendaTareas2_Click(object sender, EventArgs e)
        {

        }

        private void TituloTareas_Click(object sender, EventArgs e)
        {

        }

        private void izq_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarTarea_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar esta tarea?",
                                                  "Confirmar Guardado",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Si el usuario hace clic en "Sí"
            if (result == DialogResult.Yes)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            // Si el usuario hace clic en "No", no hace nada
            else
            {
                // Aquí puedes dejar vacío o manejar otro comportamiento si es necesario
            }

        }

        private void Enero_Click(object sender, EventArgs e)
        {

        }
    }
}
