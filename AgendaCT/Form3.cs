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
            tareas.Add(new Tarea { Nombre = "Tarea 5", FechaVencimiento = DateTime.Now.AddDays(5) });
            tareas.Add(new Tarea { Nombre = "Tarea 6", FechaVencimiento = DateTime.Now.AddDays(6) });
            tareas.Add(new Tarea { Nombre = "Tarea 7", FechaVencimiento = DateTime.Now.AddDays(7) });
            tareas.Add(new Tarea { Nombre = "Tarea 8", FechaVencimiento = DateTime.Now.AddDays(8) });

            return tareas;

        }
        // Método para cargar las tareas al iniciar el formulario
        private async void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                // Centrar el formulario
                this.CenterToScreen();
                this.CenterToParent();

                // Deshabilitar algunos controles mientras se cargan las tareas
                progressBar.Visible = true; // Si tienes un progress bar, hazlo visible

                // Usar un Task para ejecutar la carga de tareas en segundo plano
                var tareas = await Task.Run(() => CargarTareas());

                // Aquí puedes actualizar la interfaz de usuario con las tareas cargadas
                listBoxTareas.Items.Clear();  // Limpiar el ListBox antes de agregar nuevas tareas
                foreach (var tarea in tareas)
                {
                    listBoxTareas.Items.Add($"{tarea.Nombre} - {tarea.FechaVencimiento.ToShortDateString()}");
                }
                // Ocultar el progress bar después de la carga
                progressBar.Visible = false; // Ocultar el progress bar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tareas: {ex.Message}");
            }
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
