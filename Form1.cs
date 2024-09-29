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

        private int precio;

        public Form1()
        {
           


            InitializeComponent();

            // Enlazar el evento click al datagridview
            this.dataGridView1.CellClick += DataGridViewCellClick;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[1].Value = ""; // Set "Option 2" as the default value
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa la selección en "Individual" al cargar el formulario (opcional)
            comboBox1.SelectedIndex = 0;
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked a valid cell (not header row or column)
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Set the labels with the data from the selected row

                DateTime fecha = DateTime.Parse(selectedRow.Cells["Column4"].Value.ToString());
                TimeSpan fechaResta = fecha.Date - DateTime.Today.Date;
                label4.Text = fechaResta.ToString("%d");


                if (e.ColumnIndex == dataGridView1.Columns["Column2"].Index)
                {
                    string selectedValue;
                        if (dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString() == "")
                    {
                        selectedValue = "vacio";
                    }
                    else { 
                         selectedValue = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                    }


                // Do something with the selected value
                switch (selectedValue)
                {
                    case "vacio": // Individual
                        precio = 0;
                        break;
                    case "Individual: $50": // Individual
                        precio = 50;
                        break;
                    case "Doble: $75": // Doble
                            precio = 76;
                        break;
                    case "Suite: $120": // Suite
                            precio = 120;
                        break;
                    }
                }


                label5.Text = "Precio: " + (precio * Convert.ToInt16(label4.Text));

            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


  

}
