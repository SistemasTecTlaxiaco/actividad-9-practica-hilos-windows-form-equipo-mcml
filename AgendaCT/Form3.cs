using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Clase Tarea
        public class Tarea
        {
            public string Nombre { get; set; }
            public DateTime FechaVencimiento { get; set; }
        }

        // Método para cargar tareas
        public List<Tarea> CargarTareas() {
            List<Tarea> tareas = new List<Tarea>();
            
            // Simulamos la carga con un retraso
            Thread.Sleep(2000); // 2 segundos de espera

// Agregar 8 tareas de ejemplo
            tareas.Add(new Tarea { Nombre = "Tarea 1", FechaVencimiento = DateTime.Now.AddDays(1) });
            tareas.Add(new Tarea { Nombre = "Tarea 2", FechaVencimiento = DateTime.Now.AddDays(2) });
            tareas.Add(new Tarea { Nombre = "Tarea 3", FechaVencimiento = DateTime.Now.AddDays(3) });
            tareas.Add(new Tarea { Nombre = "Tarea 4", FechaVencimiento = DateTime.Now.AddDays(4) });
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            
        }

        private void TodasTareas_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Trabajos_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void AgendaTareas2_Click(object sender, EventArgs e)
        {

        }

        private void Personales_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Metas_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void AgegraTareas_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
