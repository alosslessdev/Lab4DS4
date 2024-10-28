/*Carrasco, Nathan
Herrera, Francisco
Wu, Ivan*/


using System; //234567876543
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
    public partial class Ventana1 : Form
    {

        private int precio = 0;

        public Ventana1()
        {

            InitializeComponent();



            // Enlazar las situaciones o eventos del datagridview a este archivo
            this.dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += DataGridView_EditingControlShowing;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default para la primera fila
            }

        }



        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox dataGridViewTextBoxColumn1)
            {
                dataGridViewTextBoxColumn1.KeyPress -= TextBox_KeyPress; // Quitar manejadores de eventos.
                dataGridViewTextBoxColumn1.KeyPress += TextBox_KeyPress; // Aniadir nuestra validacion.
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox dataGridViewTextBoxColumn1 = sender as TextBox;

            // Revisar si la tecla es una letra o un espacio.
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false; // Permitir espacios.
            }
            else if (e.KeyChar == ' ')
            {
                // No permitir espacios al inicio o varios espacios entre palabras.
                if (dataGridViewTextBoxColumn1.SelectionStart == 0 || (dataGridViewTextBoxColumn1.Text.EndsWith(" ") && dataGridViewTextBoxColumn1.SelectionStart == dataGridViewTextBoxColumn1.Text.Length))
                {
                    e.Handled = true; // No permitir espacios.
                }
                else
                {
                    e.Handled = false; // Permitir un solo espacio.
                }
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar.
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // No permitir otros caracteres.
            }
        }

        //diferentes situaciones en el datagridview que llevan a calculos
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calcular(sender, e);
        }



        private void calcular(object sender, DataGridViewCellEventArgs ev) {

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            string valorSeleccionado = "vacio";
            DateTime fechaEntrada;
            DateTime fechaSalida;


            if (dataGridView1.CurrentRow != null)
            {

                    if (currentRow.Cells[1].Value == null)
                    {
                        currentRow.Cells[1].Value = ""; // Poner una opcion en blanco en el combobox por default para filas nuevas
                    }
            



                // Asegurar que el usuario haya hecho clic en una celda válida (no en la fila o columna de encabezado)
                if (ev.RowIndex >= 0)
                {
                    DataGridView dataGridView = sender as DataGridView;

                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dataGridView.Rows[ev.RowIndex];

                    // Establecer las etiquetas con los datos de la fila seleccionada

                     fechaEntrada = DateTime.Parse(filaSeleccionada.Cells["Column3"].Value.ToString());
                     fechaSalida = DateTime.Parse(filaSeleccionada.Cells["Column4"].Value.ToString());
                    TimeSpan fechaResta = fechaSalida.Date - fechaEntrada.Date;



                    //validacion de fecha
                    var exitDateCell = dataGridView.Rows[ev.RowIndex].Cells["Column4"];
                    if (fechaSalida.Date < fechaEntrada.Date)
                    {
                        exitDateCell.Value = fechaEntrada.Date;

                        DateTime fechaError = DateTime.Parse(exitDateCell.Value.ToString());
                        string fechaErrorString = fechaError.ToString("M");
                        string fechaErrorStringSoloAnio = fechaError.ToString("yyyy");

                        MessageBox.Show("La fecha de entrada debe ser antes de la fecha de salida. " +
                            "La fecha de salida se configuro a " + fechaErrorString + " de " + fechaErrorStringSoloAnio + ".", "Fecha de salida antes de fecha de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    labelFechaVariable.Text = fechaResta.ToString("%d");

                    //si el combobox con precios no ha sido tocado
                    if (ev.ColumnIndex == dataGridView1.Columns["Column2"].Index)
                    {
                        if (dataGridView1.Rows[ev.RowIndex].Cells["Column2"].Value.ToString() == "")
                        {
                            valorSeleccionado = "vacio";
                        }
                        else
                        {
                            valorSeleccionado = dataGridView1.Rows[ev.RowIndex].Cells["Column2"].Value.ToString();
                        }

                    }

                        ConexionDB conexionDB = new ConexionDB();

                        string nombre = (string)currentRow.Cells[0].Value;
                        string tipoHabitacion = dataGridView1.Rows[ev.RowIndex].Cells["Column2"].Value.ToString();


                    if (nombre != null && tipoHabitacion != null && !(fechaEntrada >= fechaSalida))
                    {
                        conexionDB.CrearReserva(nombre, tipoHabitacion, fechaEntrada, fechaSalida);

                    } else if ((fechaEntrada >= fechaSalida) && nombre != null && tipoHabitacion != "") {

                        MessageBox.Show("La reserva no se ha guardado porque la fecha de entrada y de salida son iguales" +
                            " o la fecha de entrada esta despues de la fecha de salida");

                    }
                    

                    
                }

            }


        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para guardar la reserva, presione enter despues de rellenar todos los datos del huesped.");
        }
    }

}
