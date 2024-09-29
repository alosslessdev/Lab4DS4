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
                row.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default para la primera fila
            }

        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView1.CurrentRow;

                if (currentRow.Cells[1].Value == null)
                {
                    currentRow.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default para filas nuevas
                }
            }

            // Asegurar que el usuario haya hecho clic en una celda válida (no en la fila o columna de encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView.Rows[e.RowIndex];

                // Establecer las etiquetas con los datos de la fila seleccionada

                DateTime fechaEntrada = DateTime.Parse(filaSeleccionada.Cells["Column3"].Value.ToString());
                DateTime fechaSalida = DateTime.Parse(filaSeleccionada.Cells["Column4"].Value.ToString());
                TimeSpan fechaResta = fechaSalida.Date - fechaEntrada.Date;



                //validacion de fecha
                var exitDateCell = dataGridView.Rows[e.RowIndex].Cells["Column4"];
                if (fechaSalida.Date < fechaEntrada.Date) {
                    exitDateCell.Value = fechaEntrada.Date;

                    DateTime fechaError = DateTime.Parse(exitDateCell.Value.ToString());
                    string fechaErrorString = fechaError.ToString("M");
                    string fechaErrorStringSoloAnio = fechaError.ToString("yyyy");

                    MessageBox.Show("La fecha de entrada debe ser antes de la fecha de salida. " +
                        "La fecha de salida se configuro a " + fechaErrorString + " de " + fechaErrorStringSoloAnio + ".", "Fecha de salida antes de fecha de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                labelFechaVariable.Text = fechaResta.ToString("%d");

                //si el combobox con precios no ha sido tocado
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


                decimal precioSubTotal = precio * Convert.ToInt16(labelFechaVariable.Text);

                decimal itbms = (precio * (decimal)0.07);

                etiquetaVariablePrecio.Text = "$" + ((precioSubTotal)+(itbms));

            }
        }
    
    }

}
