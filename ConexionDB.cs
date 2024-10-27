using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Carrasco, Nathan
 * Herrera, Francisco
 * Wu, Iván
 */

namespace Lab4v2
{
    internal class ConexionDB
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Hotel_otaku;Integrated Security=True";

        // Método para crear una nueva reserva
        public void CrearReserva(string nombre, string tipoHabitacion, DateTime fechaEntrada, DateTime fechaSalida)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la reserva: " + ex.Message);
            }
        }

        // Método para obtener todas las reservas existentes
        public DataTable VerReservasExistentes()
        {
            DataTable reservasTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("VerReservasExistentes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar el procedimiento y llenar el DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(reservasTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener las reservas: " + ex.Message);
                    }
                }
            }

            return reservasTable;
        }
    }
}
