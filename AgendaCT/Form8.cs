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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent(); 
        }

        private void TodasTareas5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide(); 
        }

        private void Trabajos5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide(); 
        }

        private void Personales5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide(); 
        }

        private void Metas5_Click(object sender, EventArgs e)
        {

        }

        private void AgendaTareas4_Click(object sender, EventArgs e)
        {

        }
    }
}
