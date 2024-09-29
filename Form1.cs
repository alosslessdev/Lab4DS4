using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            // Create the DataGridView and add a CalendarColumn
           


            InitializeComponent();

<<<<<<< HEAD
            // Enlazar el evento SelectedIndexChanged al ComboBox
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

           


=======
            // Añadir opciones al ComboBox
            comboBox1.Items.Add("Individual: $50");
            comboBox1.Items.Add("Doble: $75");
            comboBox1.Items.Add("Suite: $120");

            // Enlazar el evento SelectedIndexChanged al ComboBox
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
>>>>>>> master
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa la selección en "Individual" al cargar el formulario (opcional)
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambiar imagen según la selección del ComboBox
<<<<<<< HEAD

=======
            switch (comboBox1.SelectedIndex)
            {
                case 0: // Individual
                    comboBox1.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Individual.jpg");
                    break;
                case 1: // Doble
                    comboBox1.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Doble.jpg");
                    break;
                case 2: // Suite
                    comboBox1.Image = Image.FromFile("C:\\Users\\Ivan\\OneDrive - Universidad Tecnológica de Panamá\\2 Year #2 Semester\\Desarrollo de Software 4\\trabajos\\Laboratorio#4\\Laboratorio#4\\Suite.jpg");
                    break;
            }
>>>>>>> master
        }

        private void Cuartos_Click(object sender, EventArgs e)
        {

        }

        private void Encabezado_Click(object sender, EventArgs e)
        {

        }
    }


  

}
