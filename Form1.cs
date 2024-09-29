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
                row.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default
            }

        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurar que el usuario haya hecho clic en una celda válida (no en la fila o columna de encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView.Rows[e.RowIndex];

                // Establecer las etiquetas con los datos de la fila seleccionada

                DateTime fecha = DateTime.Parse(filaSeleccionada.Cells["Column4"].Value.ToString());
                TimeSpan fechaResta = fecha.Date - DateTime.Today.Date;
                label4.Text = fechaResta.ToString("%d");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default
                }


                if (e.ColumnIndex == dataGridView1.Columns["Column2"].Index)
                {
                    string valorSeleccionado;
                        if (dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString() == "")
                    {
                        valorSeleccionado = "vacio";
                    }
                    else { 
                         valorSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                    }


                // Escoger precio:
                switch (valorSeleccionado)
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


                etiquetaVariablePrecio.Text = "$" + (precio * Convert.ToInt16(label4.Text));

            }
        }

    
    }


}
