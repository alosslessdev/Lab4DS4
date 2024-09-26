using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            // Enlazar el evento SelectedIndexChanged al ComboBox
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambiar imagen según la selección del ComboBox
            switch (comboBox1.SelectedIndex)
            {
                case 0: // Individual
                    Cuartos.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Individual.jpg");
                    break;
                case 1: // Doble
                    Cuartos.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Doble.jpg");
                    break;
                case 2: // Suite
                    Cuartos.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Suite.jpg");
                    break;
            }
        }

        private void Cuartos_Click(object sender, EventArgs e)
        {

        }

        private void Encabezado_Click(object sender, EventArgs e)
        {

        }
    }
}
