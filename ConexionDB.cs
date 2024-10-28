using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Carrasco, Nathan
 * Herrera, Francisco
 * Wu, Iván
 */

namespace Lab4v2
{
    internal class ConexionDB
    {
        private string detallesConexion = "Data Source=localhost;Initial Catalog=Hotel_otaku;Integrated Security=True";

        // Método para crear una nueva reserva
        public void CrearReserva(string nombre, string tipoHabitacion, DateTime fechaEntrada, DateTime fechaSalida)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(detallesConexion))
                {
                    SqlCommand command = new SqlCommand("CrearReserva", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@tipo_habitacion", tipoHabitacion);
                    command.Parameters.AddWithValue("@fecha_entrada", fechaEntrada);
                    command.Parameters.AddWithValue("@fecha_salida", fechaSalida);


                    // Abrir la conexión y ejecutar el procedimiento almacenado
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reserva insertada con exito para: " + nombre);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la reserva: " + ex.Message);
            }
        }

        // Método para obtener todas las reservas existentes
        internal DataSet ObtenerDatos(int tipo)
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    switch (tipo)
                    {

                        case 0:
                            string query = "SELECT id_reserva, nombre, habitacion, fecha_entrada, fecha_salida," +
                                " monto_total FROM [Hotel_otaku].[dbo].[Reservas]";
                            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                            adaptador.Fill(datos, "Reservas");
                            break;
                        case 1:
                             query = "SELECT id_reserva, nombre, habitacion, fecha_entrada, fecha_salida," +
                               " monto_total FROM [Hotel_otaku].[dbo].[Reservas] WHERE Habitacion = 'Suite'";
                             adaptador = new SqlDataAdapter(query, conexion);
                            adaptador.Fill(datos, "Reservas");
                            break;
                        case 2:
                             query = "SELECT id_reserva, nombre, habitacion, fecha_entrada, fecha_salida," +
                               " monto_total FROM [Hotel_otaku].[dbo].[Reservas] WHERE Habitacion = 'Doble'";
                             adaptador = new SqlDataAdapter(query, conexion);
                            adaptador.Fill(datos, "Reservas");
                            break;
                        case 3:
                             query = "SELECT id_reserva, nombre, habitacion, fecha_entrada, fecha_salida," +
                               " monto_total FROM [Hotel_otaku].[dbo].[Reservas] WHERE Habitacion = 'Individual'";
                             adaptador = new SqlDataAdapter(query, conexion);
                            adaptador.Fill(datos, "Reservas");
                            break;
                        default:
                            break;

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener libros: " + ex.Message);
            }
            return datos;
        }
    }
}
