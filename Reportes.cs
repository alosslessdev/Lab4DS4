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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    ConexionDB conexionDB = new ConexionDB();
                    DataSet datos = conexionDB.ObtenerDatos(comboBox1.SelectedIndex);
                    dataGridView1.DataSource  = datos.Tables["Reservas"];
            decimal montoTotal = 0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 montoTotal += (decimal)row.Cells[5].Value; // Poner una opcion en blanco en el combobox por default para la primera fila
            }

            labelVariableMonto.Text = Convert.ToString(montoTotal);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
