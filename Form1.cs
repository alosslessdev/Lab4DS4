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

            // Enlazar el evento SelectedIndexChanged al ComboBox
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

           


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
        }

        private void Cuartos_Click(object sender, EventArgs e)
        {

        }

        private void Encabezado_Click(object sender, EventArgs e)
        {

        }
    }


  

}
