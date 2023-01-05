using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Datos
{
    public class DConector
    {
        // STRING DE CONEXION PARA DB EN SERVIDOR DE UTU (ip 192.168.2.53)
        private static string connectionString = "datasource= 192.168.2.53;port=3306;uid=kefruta;pwd=kefruta;database=kefruta;"; // MYSQL.DATA 8.0.31
        
        public static int InsertCommand(string queryString)
        {
            int insertResult = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    try
                    {
                        connection.Open();
                        insertResult = command.ExecuteNonQuery(); // se ejecuta la query y guarda la cantidad de filas afectadas
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        insertResult = -1;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            command.Connection.Close();
                        }
                    }
                }
            }
            return insertResult; // devulve cuantas filas se afectaron
        }

        public static DataTable SelectTablaCommand(string tabla) // se le pasa solo la tabla a la que se quiere consultar
        {
            string query = "SELECT * FROM " + tabla;
            DataTable dt = new DataTable();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    try
                    {
                        cnn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                        {
                            cnn.Close();
                        }
                    }
                }
            }

            return dt;
        }

        public static DataTable SelectCommand(string query) // se le pasa la query del select
        {
            DataTable dt = new DataTable();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    try
                    {
                        cnn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                        {
                            cnn.Close();
                        }
                    }
                }
            }

            return dt;
        }

        public static int CountCommand(string queryString)
        {
            int countResult = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    try
                    {
                        connection.Open();
                        countResult = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            command.Connection.Close();
                        }
                    }
                }
            }
            return countResult; // devuelve la cantidad de tuplas contadas.
        }
    }
}
